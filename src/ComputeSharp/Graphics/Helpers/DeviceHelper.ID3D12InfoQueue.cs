﻿using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using CommunityToolkit.Diagnostics;
using TerraFX.Interop.DirectX;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.DirectX.D3D12_MESSAGE_SEVERITY;
#if NET6_0_OR_GREATER
using Enum = System.Enum;
#else
using Enum = ComputeSharp.NetStandard.System.Enum;
#endif

namespace ComputeSharp.Graphics.Helpers;

/// <inheritdoc/>
internal static partial class DeviceHelper
{
    /// <summary>
    /// Flushes all the pending debug messages for all existing <see cref="ID3D12Device"/> instances to the console/debugger.
    /// It also checks whether or not there are any error messages being logged that didn't result in an actual crash yet.
    /// </summary>
    /// <return>Whether or not there are any logged errors or warnings.</return>
    public static unsafe bool FlushAllID3D12InfoQueueMessagesAndCheckForErrorsOrWarnings()
    {
        bool hasErrorsOrWarnings = false;

        lock (DevicesCache)
        {
            StringBuilder builder = new(1024);

            foreach (var pair in D3D12InfoQueueMap)
            {
                GraphicsDevice device = DevicesCache[pair.Key];
                ID3D12InfoQueue* queue = pair.Value.Get();

                ulong messages = queue->GetNumStoredMessagesAllowedByRetrievalFilter();

                for (ulong i = 0; i < messages; i++)
                {
                    nuint length;

                    queue->GetMessage(i, null, &length);

                    D3D12_MESSAGE* message = (D3D12_MESSAGE*)NativeMemory.Alloc(length);

                    try
                    {
                        queue->GetMessage(i, message, &length);

                        builder.Clear();
                        builder.AppendLine($"[D3D12 message #{i} for \"{device}\" (HW: {device.IsHardwareAccelerated}, UMA: {device.IsCacheCoherentUMA})]");
                        builder.AppendLine($"[Category]: {Enum.GetName(message->Category)}");
                        builder.AppendLine($"[Severity]: {Enum.GetName(message->Severity)}");
                        builder.AppendLine($"[ID]: {Enum.GetName(message->ID)}");
                        builder.Append($"[Description]: \"{new string(message->pDescription)}\"");
                    }
                    finally
                    {
                        NativeMemory.Free(message);
                    }

                    if (message->Severity is D3D12_MESSAGE_SEVERITY_ERROR or D3D12_MESSAGE_SEVERITY_CORRUPTION or D3D12_MESSAGE_SEVERITY_WARNING)
                    {
                        hasErrorsOrWarnings = true;
                    }

                    string text = builder.ToString();

                    if (Debugger.IsAttached)
                    {
                        Debug.WriteLine(text);
                    }
                    else
                    {
                        Trace.WriteLine(text);
                    }
                }

                queue->ClearStoredMessages();

                HRESULT result = device.D3D12Device->GetDeviceRemovedReason();

                if (result != S.S_OK)
                {
                    string message = (int)result switch
                    {
                        DXGI.DXGI_ERROR_DEVICE_HUNG => nameof(DXGI.DXGI_ERROR_DEVICE_HUNG),
                        DXGI.DXGI_ERROR_DEVICE_REMOVED => nameof(DXGI.DXGI_ERROR_DEVICE_REMOVED),
                        DXGI.DXGI_ERROR_DEVICE_RESET => nameof(DXGI.DXGI_ERROR_DEVICE_RESET),
                        DXGI.DXGI_ERROR_DRIVER_INTERNAL_ERROR => nameof(DXGI.DXGI_ERROR_DRIVER_INTERNAL_ERROR),
                        DXGI.DXGI_ERROR_INVALID_CALL => nameof(DXGI.DXGI_ERROR_INVALID_CALL),
                        _ => ThrowHelper.ThrowArgumentOutOfRangeException<string>("Invalid GetDeviceRemovedReason HRESULT.")
                    };

                    builder.Clear();
                    builder.AppendLine($"[D3D12 device remove \"{device}\" (HW: {device.IsHardwareAccelerated}, UMA: {device.IsCacheCoherentUMA})]");
                    builder.AppendLine($"[Reason]: {message}");

                    hasErrorsOrWarnings = true;

                    string text = builder.ToString();

                    if (Debugger.IsAttached)
                    {
                        Debug.WriteLine(text);
                    }
                    else
                    {
                        Trace.WriteLine(text);
                    }
                }
            }
        }

        return hasErrorsOrWarnings;
    }
}
