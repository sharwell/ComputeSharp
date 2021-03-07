﻿using System.Runtime.InteropServices;
using ComputeSharp.Exceptions;

namespace ComputeSharp
{
    /// <inheritdoc cref="Bool1x1"/>
    [StructLayout(LayoutKind.Explicit, Size = 4, Pack = 4)]
    public partial struct Bool1x1
    {
        [FieldOffset(0)]
        private bool m11;

        /// <summary>
        /// Creates a new <see cref="Bool1x1"/> instance with the specified parameters.
        /// </summary>
        /// <param name="m11">The value to assign to the component at position [1, 1].</param>
        public Bool1x1(bool m11)
        {
            this.m11 = m11;
        }

        /// <summary>
        /// Gets a reference to a specific row in the current <see cref="Bool1x1"/> instance.
        /// </summary>
        /// <param name="row">The row to access.</param>
        public ref bool this[int row] => throw new InvalidExecutionContextException($"{typeof(Bool1x1)}[{typeof(int)}]");

        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool1x1"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        public ref Bool2 this[MatrixIndex xy0, MatrixIndex xy1] => throw new InvalidExecutionContextException($"{typeof(Bool1x1)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool1x1"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        public ref Bool3 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2] => throw new InvalidExecutionContextException($"{typeof(Bool1x1)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool1x1"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        /// <param name="xy3">The identifier of the fourth item to index.</param>
        public ref Bool4 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2, MatrixIndex xy3] => throw new InvalidExecutionContextException($"{typeof(Bool1x1)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 1].
        /// </summary>
        public ref bool M11 => throw new InvalidExecutionContextException($"{typeof(Bool1x1)}.M11");

        /// <summary>
        /// Creates a new <see cref="Bool1x1"/> value with the same value for all its components.
        /// </summary>
        /// <param name="x">The value to use for the components of the new <see cref="Bool1x1"/> instance.</param>
        public static implicit operator Bool1x1(bool x)
        {
            Bool1x1 matrix;

            matrix.m11 = x;

            return matrix;
        }

        /// <summary>
        /// Negates a <see cref="Bool1x1"/> value.
        /// </summary>
        /// <param name="matrix">The <see cref="Bool1x1"/> value to negate.</param>
        public static Bool1x1 operator -(Bool1x1 matrix) => throw new InvalidExecutionContextException($"{typeof(Bool1x1)}.-");

        /// <summary>
        /// Sums two <see cref="Bool1x1"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool1x1"/> value to sum.</param>
        /// <param name="right">The second <see cref="Bool1x1"/> value to sum.</param>
        public static Bool1x1 operator +(Bool1x1 left, Bool1x1 right) => throw new InvalidExecutionContextException($"{typeof(Bool1x1)}.+");

        /// <summary>
        /// Divides two <see cref="Bool1x1"/> values (elementwise division).
        /// </summary>
        /// <param name="left">The first <see cref="Bool1x1"/> value to divide.</param>
        /// <param name="right">The second <see cref="Bool1x1"/> value to divide.</param>
        public static Bool1x1 operator /(Bool1x1 left, Bool1x1 right) => throw new InvalidExecutionContextException($"{typeof(Bool1x1)}./");

        /// <summary>
        /// Multiplies two <see cref="Bool1x1"/> values (elementwise product).
        /// </summary>
        /// <param name="left">The first <see cref="Bool1x1"/> value to multiply.</param>
        /// <param name="right">The second <see cref="Bool1x1"/> value to multiply.</param>
        public static Bool1x1 operator *(Bool1x1 left, Bool1x1 right) => throw new InvalidExecutionContextException($"{typeof(Bool1x1)}.*");

        /// <summary>
        /// Subtracts two <see cref="Bool1x1"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool1x1"/> value to subtract.</param>
        /// <param name="right">The second <see cref="Bool1x1"/> value to subtract.</param>
        public static Bool1x1 operator -(Bool1x1 left, Bool1x1 right) => throw new InvalidExecutionContextException($"{typeof(Bool1x1)}.-");
    }

    /// <inheritdoc cref="Bool1x2"/>
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 4)]
    public partial struct Bool1x2
    {
        [FieldOffset(0)]
        private bool m11;

        [FieldOffset(4)]
        private bool m12;

        /// <summary>
        /// Creates a new <see cref="Bool1x2"/> instance with the specified parameters.
        /// </summary>
        /// <param name="m11">The value to assign to the component at position [1, 1].</param>
        /// <param name="m12">The value to assign to the component at position [1, 2].</param>
        public Bool1x2(bool m11, bool m12)
        {
            this.m11 = m11;
            this.m12 = m12;
        }

        /// <summary>
        /// Gets a reference to a specific row in the current <see cref="Bool1x2"/> instance.
        /// </summary>
        /// <param name="row">The row to access.</param>
        public ref Bool2 this[int row] => throw new InvalidExecutionContextException($"{typeof(Bool1x2)}[{typeof(int)}]");

        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool1x2"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        public ref Bool2 this[MatrixIndex xy0, MatrixIndex xy1] => throw new InvalidExecutionContextException($"{typeof(Bool1x2)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool1x2"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        public ref Bool3 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2] => throw new InvalidExecutionContextException($"{typeof(Bool1x2)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool1x2"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        /// <param name="xy3">The identifier of the fourth item to index.</param>
        public ref Bool4 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2, MatrixIndex xy3] => throw new InvalidExecutionContextException($"{typeof(Bool1x2)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 1].
        /// </summary>
        public ref bool M11 => throw new InvalidExecutionContextException($"{typeof(Bool1x2)}.M11");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 2].
        /// </summary>
        public ref bool M12 => throw new InvalidExecutionContextException($"{typeof(Bool1x2)}.M12");

        /// <summary>
        /// Creates a new <see cref="Bool1x2"/> value with the same value for all its components.
        /// </summary>
        /// <param name="x">The value to use for the components of the new <see cref="Bool1x2"/> instance.</param>
        public static implicit operator Bool1x2(bool x)
        {
            Bool1x2 matrix;

            matrix.m11 = x;
            matrix.m12 = x;

            return matrix;
        }

        /// <summary>
        /// Negates a <see cref="Bool1x2"/> value.
        /// </summary>
        /// <param name="matrix">The <see cref="Bool1x2"/> value to negate.</param>
        public static Bool1x2 operator -(Bool1x2 matrix) => throw new InvalidExecutionContextException($"{typeof(Bool1x2)}.-");

        /// <summary>
        /// Sums two <see cref="Bool1x2"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool1x2"/> value to sum.</param>
        /// <param name="right">The second <see cref="Bool1x2"/> value to sum.</param>
        public static Bool1x2 operator +(Bool1x2 left, Bool1x2 right) => throw new InvalidExecutionContextException($"{typeof(Bool1x2)}.+");

        /// <summary>
        /// Divides two <see cref="Bool1x2"/> values (elementwise division).
        /// </summary>
        /// <param name="left">The first <see cref="Bool1x2"/> value to divide.</param>
        /// <param name="right">The second <see cref="Bool1x2"/> value to divide.</param>
        public static Bool1x2 operator /(Bool1x2 left, Bool1x2 right) => throw new InvalidExecutionContextException($"{typeof(Bool1x2)}./");

        /// <summary>
        /// Multiplies two <see cref="Bool1x2"/> values (elementwise product).
        /// </summary>
        /// <param name="left">The first <see cref="Bool1x2"/> value to multiply.</param>
        /// <param name="right">The second <see cref="Bool1x2"/> value to multiply.</param>
        public static Bool1x2 operator *(Bool1x2 left, Bool1x2 right) => throw new InvalidExecutionContextException($"{typeof(Bool1x2)}.*");

        /// <summary>
        /// Subtracts two <see cref="Bool1x2"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool1x2"/> value to subtract.</param>
        /// <param name="right">The second <see cref="Bool1x2"/> value to subtract.</param>
        public static Bool1x2 operator -(Bool1x2 left, Bool1x2 right) => throw new InvalidExecutionContextException($"{typeof(Bool1x2)}.-");

        /// <summary>
        /// Casts a <see cref="Bool2"/> value to a <see cref="Bool1x2"/> one.
        /// </summary>
        /// <param name="vector">The input <see cref="Bool2"/> value to cast.</param>
        public static implicit operator Bool1x2(Bool2 vector) => throw new InvalidExecutionContextException($"{typeof(Bool1x2)}.{typeof(Bool1x2)}({typeof(Bool2)})");
    }

    /// <inheritdoc cref="Bool1x3"/>
    [StructLayout(LayoutKind.Explicit, Size = 12, Pack = 4)]
    public partial struct Bool1x3
    {
        [FieldOffset(0)]
        private bool m11;

        [FieldOffset(4)]
        private bool m12;

        [FieldOffset(8)]
        private bool m13;

        /// <summary>
        /// Creates a new <see cref="Bool1x3"/> instance with the specified parameters.
        /// </summary>
        /// <param name="m11">The value to assign to the component at position [1, 1].</param>
        /// <param name="m12">The value to assign to the component at position [1, 2].</param>
        /// <param name="m13">The value to assign to the component at position [1, 3].</param>
        public Bool1x3(bool m11, bool m12, bool m13)
        {
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
        }

        /// <summary>
        /// Gets a reference to a specific row in the current <see cref="Bool1x3"/> instance.
        /// </summary>
        /// <param name="row">The row to access.</param>
        public ref Bool3 this[int row] => throw new InvalidExecutionContextException($"{typeof(Bool1x3)}[{typeof(int)}]");

        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool1x3"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        public ref Bool2 this[MatrixIndex xy0, MatrixIndex xy1] => throw new InvalidExecutionContextException($"{typeof(Bool1x3)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool1x3"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        public ref Bool3 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2] => throw new InvalidExecutionContextException($"{typeof(Bool1x3)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool1x3"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        /// <param name="xy3">The identifier of the fourth item to index.</param>
        public ref Bool4 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2, MatrixIndex xy3] => throw new InvalidExecutionContextException($"{typeof(Bool1x3)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 1].
        /// </summary>
        public ref bool M11 => throw new InvalidExecutionContextException($"{typeof(Bool1x3)}.M11");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 2].
        /// </summary>
        public ref bool M12 => throw new InvalidExecutionContextException($"{typeof(Bool1x3)}.M12");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 3].
        /// </summary>
        public ref bool M13 => throw new InvalidExecutionContextException($"{typeof(Bool1x3)}.M13");

        /// <summary>
        /// Creates a new <see cref="Bool1x3"/> value with the same value for all its components.
        /// </summary>
        /// <param name="x">The value to use for the components of the new <see cref="Bool1x3"/> instance.</param>
        public static implicit operator Bool1x3(bool x)
        {
            Bool1x3 matrix;

            matrix.m11 = x;
            matrix.m12 = x;
            matrix.m13 = x;

            return matrix;
        }

        /// <summary>
        /// Negates a <see cref="Bool1x3"/> value.
        /// </summary>
        /// <param name="matrix">The <see cref="Bool1x3"/> value to negate.</param>
        public static Bool1x3 operator -(Bool1x3 matrix) => throw new InvalidExecutionContextException($"{typeof(Bool1x3)}.-");

        /// <summary>
        /// Sums two <see cref="Bool1x3"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool1x3"/> value to sum.</param>
        /// <param name="right">The second <see cref="Bool1x3"/> value to sum.</param>
        public static Bool1x3 operator +(Bool1x3 left, Bool1x3 right) => throw new InvalidExecutionContextException($"{typeof(Bool1x3)}.+");

        /// <summary>
        /// Divides two <see cref="Bool1x3"/> values (elementwise division).
        /// </summary>
        /// <param name="left">The first <see cref="Bool1x3"/> value to divide.</param>
        /// <param name="right">The second <see cref="Bool1x3"/> value to divide.</param>
        public static Bool1x3 operator /(Bool1x3 left, Bool1x3 right) => throw new InvalidExecutionContextException($"{typeof(Bool1x3)}./");

        /// <summary>
        /// Multiplies two <see cref="Bool1x3"/> values (elementwise product).
        /// </summary>
        /// <param name="left">The first <see cref="Bool1x3"/> value to multiply.</param>
        /// <param name="right">The second <see cref="Bool1x3"/> value to multiply.</param>
        public static Bool1x3 operator *(Bool1x3 left, Bool1x3 right) => throw new InvalidExecutionContextException($"{typeof(Bool1x3)}.*");

        /// <summary>
        /// Subtracts two <see cref="Bool1x3"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool1x3"/> value to subtract.</param>
        /// <param name="right">The second <see cref="Bool1x3"/> value to subtract.</param>
        public static Bool1x3 operator -(Bool1x3 left, Bool1x3 right) => throw new InvalidExecutionContextException($"{typeof(Bool1x3)}.-");

        /// <summary>
        /// Casts a <see cref="Bool3"/> value to a <see cref="Bool1x3"/> one.
        /// </summary>
        /// <param name="vector">The input <see cref="Bool3"/> value to cast.</param>
        public static implicit operator Bool1x3(Bool3 vector) => throw new InvalidExecutionContextException($"{typeof(Bool1x3)}.{typeof(Bool1x3)}({typeof(Bool3)})");
    }

    /// <inheritdoc cref="Bool1x4"/>
    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 4)]
    public partial struct Bool1x4
    {
        [FieldOffset(0)]
        private bool m11;

        [FieldOffset(4)]
        private bool m12;

        [FieldOffset(8)]
        private bool m13;

        [FieldOffset(12)]
        private bool m14;

        /// <summary>
        /// Creates a new <see cref="Bool1x4"/> instance with the specified parameters.
        /// </summary>
        /// <param name="m11">The value to assign to the component at position [1, 1].</param>
        /// <param name="m12">The value to assign to the component at position [1, 2].</param>
        /// <param name="m13">The value to assign to the component at position [1, 3].</param>
        /// <param name="m14">The value to assign to the component at position [1, 4].</param>
        public Bool1x4(bool m11, bool m12, bool m13, bool m14)
        {
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m14 = m14;
        }

        /// <summary>
        /// Gets a reference to a specific row in the current <see cref="Bool1x4"/> instance.
        /// </summary>
        /// <param name="row">The row to access.</param>
        public ref Bool4 this[int row] => throw new InvalidExecutionContextException($"{typeof(Bool1x4)}[{typeof(int)}]");

        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool1x4"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        public ref Bool2 this[MatrixIndex xy0, MatrixIndex xy1] => throw new InvalidExecutionContextException($"{typeof(Bool1x4)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool1x4"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        public ref Bool3 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2] => throw new InvalidExecutionContextException($"{typeof(Bool1x4)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool1x4"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        /// <param name="xy3">The identifier of the fourth item to index.</param>
        public ref Bool4 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2, MatrixIndex xy3] => throw new InvalidExecutionContextException($"{typeof(Bool1x4)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 1].
        /// </summary>
        public ref bool M11 => throw new InvalidExecutionContextException($"{typeof(Bool1x4)}.M11");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 2].
        /// </summary>
        public ref bool M12 => throw new InvalidExecutionContextException($"{typeof(Bool1x4)}.M12");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 3].
        /// </summary>
        public ref bool M13 => throw new InvalidExecutionContextException($"{typeof(Bool1x4)}.M13");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 4].
        /// </summary>
        public ref bool M14 => throw new InvalidExecutionContextException($"{typeof(Bool1x4)}.M14");

        /// <summary>
        /// Creates a new <see cref="Bool1x4"/> value with the same value for all its components.
        /// </summary>
        /// <param name="x">The value to use for the components of the new <see cref="Bool1x4"/> instance.</param>
        public static implicit operator Bool1x4(bool x)
        {
            Bool1x4 matrix;

            matrix.m11 = x;
            matrix.m12 = x;
            matrix.m13 = x;
            matrix.m14 = x;

            return matrix;
        }

        /// <summary>
        /// Negates a <see cref="Bool1x4"/> value.
        /// </summary>
        /// <param name="matrix">The <see cref="Bool1x4"/> value to negate.</param>
        public static Bool1x4 operator -(Bool1x4 matrix) => throw new InvalidExecutionContextException($"{typeof(Bool1x4)}.-");

        /// <summary>
        /// Sums two <see cref="Bool1x4"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool1x4"/> value to sum.</param>
        /// <param name="right">The second <see cref="Bool1x4"/> value to sum.</param>
        public static Bool1x4 operator +(Bool1x4 left, Bool1x4 right) => throw new InvalidExecutionContextException($"{typeof(Bool1x4)}.+");

        /// <summary>
        /// Divides two <see cref="Bool1x4"/> values (elementwise division).
        /// </summary>
        /// <param name="left">The first <see cref="Bool1x4"/> value to divide.</param>
        /// <param name="right">The second <see cref="Bool1x4"/> value to divide.</param>
        public static Bool1x4 operator /(Bool1x4 left, Bool1x4 right) => throw new InvalidExecutionContextException($"{typeof(Bool1x4)}./");

        /// <summary>
        /// Multiplies two <see cref="Bool1x4"/> values (elementwise product).
        /// </summary>
        /// <param name="left">The first <see cref="Bool1x4"/> value to multiply.</param>
        /// <param name="right">The second <see cref="Bool1x4"/> value to multiply.</param>
        public static Bool1x4 operator *(Bool1x4 left, Bool1x4 right) => throw new InvalidExecutionContextException($"{typeof(Bool1x4)}.*");

        /// <summary>
        /// Subtracts two <see cref="Bool1x4"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool1x4"/> value to subtract.</param>
        /// <param name="right">The second <see cref="Bool1x4"/> value to subtract.</param>
        public static Bool1x4 operator -(Bool1x4 left, Bool1x4 right) => throw new InvalidExecutionContextException($"{typeof(Bool1x4)}.-");

        /// <summary>
        /// Casts a <see cref="Bool4"/> value to a <see cref="Bool1x4"/> one.
        /// </summary>
        /// <param name="vector">The input <see cref="Bool4"/> value to cast.</param>
        public static implicit operator Bool1x4(Bool4 vector) => throw new InvalidExecutionContextException($"{typeof(Bool1x4)}.{typeof(Bool1x4)}({typeof(Bool4)})");
    }

    /// <inheritdoc cref="Bool2x1"/>
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 4)]
    public partial struct Bool2x1
    {
        [FieldOffset(0)]
        private bool m11;

        [FieldOffset(4)]
        private bool m21;

        /// <summary>
        /// Creates a new <see cref="Bool2x1"/> instance with the specified parameters.
        /// </summary>
        /// <param name="m11">The value to assign to the component at position [1, 1].</param>
        /// <param name="m21">The value to assign to the component at position [2, 1].</param>
        public Bool2x1(bool m11, bool m21)
        {
            this.m11 = m11;
            this.m21 = m21;
        }

        /// <summary>
        /// Gets a reference to a specific row in the current <see cref="Bool2x1"/> instance.
        /// </summary>
        /// <param name="row">The row to access.</param>
        public ref bool this[int row] => throw new InvalidExecutionContextException($"{typeof(Bool2x1)}[{typeof(int)}]");

        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool2x1"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        public ref Bool2 this[MatrixIndex xy0, MatrixIndex xy1] => throw new InvalidExecutionContextException($"{typeof(Bool2x1)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool2x1"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        public ref Bool3 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2] => throw new InvalidExecutionContextException($"{typeof(Bool2x1)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool2x1"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        /// <param name="xy3">The identifier of the fourth item to index.</param>
        public ref Bool4 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2, MatrixIndex xy3] => throw new InvalidExecutionContextException($"{typeof(Bool2x1)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 1].
        /// </summary>
        public ref bool M11 => throw new InvalidExecutionContextException($"{typeof(Bool2x1)}.M11");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 1].
        /// </summary>
        public ref bool M21 => throw new InvalidExecutionContextException($"{typeof(Bool2x1)}.M21");

        /// <summary>
        /// Creates a new <see cref="Bool2x1"/> value with the same value for all its components.
        /// </summary>
        /// <param name="x">The value to use for the components of the new <see cref="Bool2x1"/> instance.</param>
        public static implicit operator Bool2x1(bool x)
        {
            Bool2x1 matrix;

            matrix.m11 = x;
            matrix.m21 = x;

            return matrix;
        }

        /// <summary>
        /// Negates a <see cref="Bool2x1"/> value.
        /// </summary>
        /// <param name="matrix">The <see cref="Bool2x1"/> value to negate.</param>
        public static Bool2x1 operator -(Bool2x1 matrix) => throw new InvalidExecutionContextException($"{typeof(Bool2x1)}.-");

        /// <summary>
        /// Sums two <see cref="Bool2x1"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool2x1"/> value to sum.</param>
        /// <param name="right">The second <see cref="Bool2x1"/> value to sum.</param>
        public static Bool2x1 operator +(Bool2x1 left, Bool2x1 right) => throw new InvalidExecutionContextException($"{typeof(Bool2x1)}.+");

        /// <summary>
        /// Divides two <see cref="Bool2x1"/> values (elementwise division).
        /// </summary>
        /// <param name="left">The first <see cref="Bool2x1"/> value to divide.</param>
        /// <param name="right">The second <see cref="Bool2x1"/> value to divide.</param>
        public static Bool2x1 operator /(Bool2x1 left, Bool2x1 right) => throw new InvalidExecutionContextException($"{typeof(Bool2x1)}./");

        /// <summary>
        /// Multiplies two <see cref="Bool2x1"/> values (elementwise product).
        /// </summary>
        /// <param name="left">The first <see cref="Bool2x1"/> value to multiply.</param>
        /// <param name="right">The second <see cref="Bool2x1"/> value to multiply.</param>
        public static Bool2x1 operator *(Bool2x1 left, Bool2x1 right) => throw new InvalidExecutionContextException($"{typeof(Bool2x1)}.*");

        /// <summary>
        /// Subtracts two <see cref="Bool2x1"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool2x1"/> value to subtract.</param>
        /// <param name="right">The second <see cref="Bool2x1"/> value to subtract.</param>
        public static Bool2x1 operator -(Bool2x1 left, Bool2x1 right) => throw new InvalidExecutionContextException($"{typeof(Bool2x1)}.-");

        /// <summary>
        /// Casts a <see cref="Bool2x1"/> value to a <see cref="Bool2"/> one.
        /// </summary>
        /// <param name="matrix">The input <see cref="Bool2x1"/> value to cast.</param>
        public static implicit operator Bool2(Bool2x1 matrix) => throw new InvalidExecutionContextException($"{typeof(Bool2x1)}.{typeof(Bool2)}({typeof(Bool2x1)})");
    }

    /// <inheritdoc cref="Bool2x2"/>
    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 4)]
    public partial struct Bool2x2
    {
        [FieldOffset(0)]
        private bool m11;

        [FieldOffset(4)]
        private bool m12;

        [FieldOffset(8)]
        private bool m21;

        [FieldOffset(12)]
        private bool m22;

        /// <summary>
        /// Creates a new <see cref="Bool2x2"/> instance with the specified parameters.
        /// </summary>
        /// <param name="m11">The value to assign to the component at position [1, 1].</param>
        /// <param name="m12">The value to assign to the component at position [1, 2].</param>
        /// <param name="m21">The value to assign to the component at position [2, 1].</param>
        /// <param name="m22">The value to assign to the component at position [2, 2].</param>
        public Bool2x2(bool m11, bool m12, bool m21, bool m22)
        {
            this.m11 = m11;
            this.m12 = m12;
            this.m21 = m21;
            this.m22 = m22;
        }

        /// <summary>
        /// Creates a new <see cref="Bool2x2"/> instance with the specified parameters.
        /// </summary>
        /// <param name="row1">The value to assign to the row at position [1].</param>
        /// <param name="row2">The value to assign to the row at position [2].</param>
        public Bool2x2(Bool2 row1, Bool2 row2)
        {
            this.m11 = row1.X;
            this.m12 = row1.Y;
            this.m21 = row2.X;
            this.m22 = row2.Y;
        }

        /// <summary>
        /// Gets a reference to a specific row in the current <see cref="Bool2x2"/> instance.
        /// </summary>
        /// <param name="row">The row to access.</param>
        public ref Bool2 this[int row] => throw new InvalidExecutionContextException($"{typeof(Bool2x2)}[{typeof(int)}]");

        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool2x2"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        public ref Bool2 this[MatrixIndex xy0, MatrixIndex xy1] => throw new InvalidExecutionContextException($"{typeof(Bool2x2)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool2x2"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        public ref Bool3 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2] => throw new InvalidExecutionContextException($"{typeof(Bool2x2)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool2x2"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        /// <param name="xy3">The identifier of the fourth item to index.</param>
        public ref Bool4 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2, MatrixIndex xy3] => throw new InvalidExecutionContextException($"{typeof(Bool2x2)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 1].
        /// </summary>
        public ref bool M11 => throw new InvalidExecutionContextException($"{typeof(Bool2x2)}.M11");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 2].
        /// </summary>
        public ref bool M12 => throw new InvalidExecutionContextException($"{typeof(Bool2x2)}.M12");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 1].
        /// </summary>
        public ref bool M21 => throw new InvalidExecutionContextException($"{typeof(Bool2x2)}.M21");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 2].
        /// </summary>
        public ref bool M22 => throw new InvalidExecutionContextException($"{typeof(Bool2x2)}.M22");

        /// <summary>
        /// Creates a new <see cref="Bool2x2"/> value with the same value for all its components.
        /// </summary>
        /// <param name="x">The value to use for the components of the new <see cref="Bool2x2"/> instance.</param>
        public static implicit operator Bool2x2(bool x)
        {
            Bool2x2 matrix;

            matrix.m11 = x;
            matrix.m12 = x;
            matrix.m21 = x;
            matrix.m22 = x;

            return matrix;
        }

        /// <summary>
        /// Negates a <see cref="Bool2x2"/> value.
        /// </summary>
        /// <param name="matrix">The <see cref="Bool2x2"/> value to negate.</param>
        public static Bool2x2 operator -(Bool2x2 matrix) => throw new InvalidExecutionContextException($"{typeof(Bool2x2)}.-");

        /// <summary>
        /// Sums two <see cref="Bool2x2"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool2x2"/> value to sum.</param>
        /// <param name="right">The second <see cref="Bool2x2"/> value to sum.</param>
        public static Bool2x2 operator +(Bool2x2 left, Bool2x2 right) => throw new InvalidExecutionContextException($"{typeof(Bool2x2)}.+");

        /// <summary>
        /// Divides two <see cref="Bool2x2"/> values (elementwise division).
        /// </summary>
        /// <param name="left">The first <see cref="Bool2x2"/> value to divide.</param>
        /// <param name="right">The second <see cref="Bool2x2"/> value to divide.</param>
        public static Bool2x2 operator /(Bool2x2 left, Bool2x2 right) => throw new InvalidExecutionContextException($"{typeof(Bool2x2)}./");

        /// <summary>
        /// Multiplies two <see cref="Bool2x2"/> values (elementwise product).
        /// </summary>
        /// <param name="left">The first <see cref="Bool2x2"/> value to multiply.</param>
        /// <param name="right">The second <see cref="Bool2x2"/> value to multiply.</param>
        public static Bool2x2 operator *(Bool2x2 left, Bool2x2 right) => throw new InvalidExecutionContextException($"{typeof(Bool2x2)}.*");

        /// <summary>
        /// Subtracts two <see cref="Bool2x2"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool2x2"/> value to subtract.</param>
        /// <param name="right">The second <see cref="Bool2x2"/> value to subtract.</param>
        public static Bool2x2 operator -(Bool2x2 left, Bool2x2 right) => throw new InvalidExecutionContextException($"{typeof(Bool2x2)}.-");
    }

    /// <inheritdoc cref="Bool2x3"/>
    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 4)]
    public partial struct Bool2x3
    {
        [FieldOffset(0)]
        private bool m11;

        [FieldOffset(4)]
        private bool m12;

        [FieldOffset(8)]
        private bool m13;

        [FieldOffset(12)]
        private bool m21;

        [FieldOffset(16)]
        private bool m22;

        [FieldOffset(20)]
        private bool m23;

        /// <summary>
        /// Creates a new <see cref="Bool2x3"/> instance with the specified parameters.
        /// </summary>
        /// <param name="m11">The value to assign to the component at position [1, 1].</param>
        /// <param name="m12">The value to assign to the component at position [1, 2].</param>
        /// <param name="m13">The value to assign to the component at position [1, 3].</param>
        /// <param name="m21">The value to assign to the component at position [2, 1].</param>
        /// <param name="m22">The value to assign to the component at position [2, 2].</param>
        /// <param name="m23">The value to assign to the component at position [2, 3].</param>
        public Bool2x3(bool m11, bool m12, bool m13, bool m21, bool m22, bool m23)
        {
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m21 = m21;
            this.m22 = m22;
            this.m23 = m23;
        }

        /// <summary>
        /// Creates a new <see cref="Bool2x3"/> instance with the specified parameters.
        /// </summary>
        /// <param name="row1">The value to assign to the row at position [1].</param>
        /// <param name="row2">The value to assign to the row at position [2].</param>
        public Bool2x3(Bool3 row1, Bool3 row2)
        {
            this.m11 = row1.X;
            this.m12 = row1.Y;
            this.m13 = row1.Z;
            this.m21 = row2.X;
            this.m22 = row2.Y;
            this.m23 = row2.Z;
        }

        /// <summary>
        /// Gets a reference to a specific row in the current <see cref="Bool2x3"/> instance.
        /// </summary>
        /// <param name="row">The row to access.</param>
        public ref Bool3 this[int row] => throw new InvalidExecutionContextException($"{typeof(Bool2x3)}[{typeof(int)}]");

        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool2x3"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        public ref Bool2 this[MatrixIndex xy0, MatrixIndex xy1] => throw new InvalidExecutionContextException($"{typeof(Bool2x3)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool2x3"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        public ref Bool3 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2] => throw new InvalidExecutionContextException($"{typeof(Bool2x3)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool2x3"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        /// <param name="xy3">The identifier of the fourth item to index.</param>
        public ref Bool4 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2, MatrixIndex xy3] => throw new InvalidExecutionContextException($"{typeof(Bool2x3)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 1].
        /// </summary>
        public ref bool M11 => throw new InvalidExecutionContextException($"{typeof(Bool2x3)}.M11");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 2].
        /// </summary>
        public ref bool M12 => throw new InvalidExecutionContextException($"{typeof(Bool2x3)}.M12");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 3].
        /// </summary>
        public ref bool M13 => throw new InvalidExecutionContextException($"{typeof(Bool2x3)}.M13");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 1].
        /// </summary>
        public ref bool M21 => throw new InvalidExecutionContextException($"{typeof(Bool2x3)}.M21");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 2].
        /// </summary>
        public ref bool M22 => throw new InvalidExecutionContextException($"{typeof(Bool2x3)}.M22");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 3].
        /// </summary>
        public ref bool M23 => throw new InvalidExecutionContextException($"{typeof(Bool2x3)}.M23");

        /// <summary>
        /// Creates a new <see cref="Bool2x3"/> value with the same value for all its components.
        /// </summary>
        /// <param name="x">The value to use for the components of the new <see cref="Bool2x3"/> instance.</param>
        public static implicit operator Bool2x3(bool x)
        {
            Bool2x3 matrix;

            matrix.m11 = x;
            matrix.m12 = x;
            matrix.m13 = x;
            matrix.m21 = x;
            matrix.m22 = x;
            matrix.m23 = x;

            return matrix;
        }

        /// <summary>
        /// Negates a <see cref="Bool2x3"/> value.
        /// </summary>
        /// <param name="matrix">The <see cref="Bool2x3"/> value to negate.</param>
        public static Bool2x3 operator -(Bool2x3 matrix) => throw new InvalidExecutionContextException($"{typeof(Bool2x3)}.-");

        /// <summary>
        /// Sums two <see cref="Bool2x3"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool2x3"/> value to sum.</param>
        /// <param name="right">The second <see cref="Bool2x3"/> value to sum.</param>
        public static Bool2x3 operator +(Bool2x3 left, Bool2x3 right) => throw new InvalidExecutionContextException($"{typeof(Bool2x3)}.+");

        /// <summary>
        /// Divides two <see cref="Bool2x3"/> values (elementwise division).
        /// </summary>
        /// <param name="left">The first <see cref="Bool2x3"/> value to divide.</param>
        /// <param name="right">The second <see cref="Bool2x3"/> value to divide.</param>
        public static Bool2x3 operator /(Bool2x3 left, Bool2x3 right) => throw new InvalidExecutionContextException($"{typeof(Bool2x3)}./");

        /// <summary>
        /// Multiplies two <see cref="Bool2x3"/> values (elementwise product).
        /// </summary>
        /// <param name="left">The first <see cref="Bool2x3"/> value to multiply.</param>
        /// <param name="right">The second <see cref="Bool2x3"/> value to multiply.</param>
        public static Bool2x3 operator *(Bool2x3 left, Bool2x3 right) => throw new InvalidExecutionContextException($"{typeof(Bool2x3)}.*");

        /// <summary>
        /// Subtracts two <see cref="Bool2x3"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool2x3"/> value to subtract.</param>
        /// <param name="right">The second <see cref="Bool2x3"/> value to subtract.</param>
        public static Bool2x3 operator -(Bool2x3 left, Bool2x3 right) => throw new InvalidExecutionContextException($"{typeof(Bool2x3)}.-");
    }

    /// <inheritdoc cref="Bool2x4"/>
    [StructLayout(LayoutKind.Explicit, Size = 32, Pack = 4)]
    public partial struct Bool2x4
    {
        [FieldOffset(0)]
        private bool m11;

        [FieldOffset(4)]
        private bool m12;

        [FieldOffset(8)]
        private bool m13;

        [FieldOffset(12)]
        private bool m14;

        [FieldOffset(16)]
        private bool m21;

        [FieldOffset(20)]
        private bool m22;

        [FieldOffset(24)]
        private bool m23;

        [FieldOffset(28)]
        private bool m24;

        /// <summary>
        /// Creates a new <see cref="Bool2x4"/> instance with the specified parameters.
        /// </summary>
        /// <param name="m11">The value to assign to the component at position [1, 1].</param>
        /// <param name="m12">The value to assign to the component at position [1, 2].</param>
        /// <param name="m13">The value to assign to the component at position [1, 3].</param>
        /// <param name="m14">The value to assign to the component at position [1, 4].</param>
        /// <param name="m21">The value to assign to the component at position [2, 1].</param>
        /// <param name="m22">The value to assign to the component at position [2, 2].</param>
        /// <param name="m23">The value to assign to the component at position [2, 3].</param>
        /// <param name="m24">The value to assign to the component at position [2, 4].</param>
        public Bool2x4(bool m11, bool m12, bool m13, bool m14, bool m21, bool m22, bool m23, bool m24)
        {
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m14 = m14;
            this.m21 = m21;
            this.m22 = m22;
            this.m23 = m23;
            this.m24 = m24;
        }

        /// <summary>
        /// Creates a new <see cref="Bool2x4"/> instance with the specified parameters.
        /// </summary>
        /// <param name="row1">The value to assign to the row at position [1].</param>
        /// <param name="row2">The value to assign to the row at position [2].</param>
        public Bool2x4(Bool4 row1, Bool4 row2)
        {
            this.m11 = row1.X;
            this.m12 = row1.Y;
            this.m13 = row1.Z;
            this.m14 = row1.W;
            this.m21 = row2.X;
            this.m22 = row2.Y;
            this.m23 = row2.Z;
            this.m24 = row2.W;
        }

        /// <summary>
        /// Gets a reference to a specific row in the current <see cref="Bool2x4"/> instance.
        /// </summary>
        /// <param name="row">The row to access.</param>
        public ref Bool4 this[int row] => throw new InvalidExecutionContextException($"{typeof(Bool2x4)}[{typeof(int)}]");

        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool2x4"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        public ref Bool2 this[MatrixIndex xy0, MatrixIndex xy1] => throw new InvalidExecutionContextException($"{typeof(Bool2x4)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool2x4"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        public ref Bool3 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2] => throw new InvalidExecutionContextException($"{typeof(Bool2x4)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool2x4"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        /// <param name="xy3">The identifier of the fourth item to index.</param>
        public ref Bool4 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2, MatrixIndex xy3] => throw new InvalidExecutionContextException($"{typeof(Bool2x4)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 1].
        /// </summary>
        public ref bool M11 => throw new InvalidExecutionContextException($"{typeof(Bool2x4)}.M11");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 2].
        /// </summary>
        public ref bool M12 => throw new InvalidExecutionContextException($"{typeof(Bool2x4)}.M12");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 3].
        /// </summary>
        public ref bool M13 => throw new InvalidExecutionContextException($"{typeof(Bool2x4)}.M13");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 4].
        /// </summary>
        public ref bool M14 => throw new InvalidExecutionContextException($"{typeof(Bool2x4)}.M14");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 1].
        /// </summary>
        public ref bool M21 => throw new InvalidExecutionContextException($"{typeof(Bool2x4)}.M21");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 2].
        /// </summary>
        public ref bool M22 => throw new InvalidExecutionContextException($"{typeof(Bool2x4)}.M22");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 3].
        /// </summary>
        public ref bool M23 => throw new InvalidExecutionContextException($"{typeof(Bool2x4)}.M23");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 4].
        /// </summary>
        public ref bool M24 => throw new InvalidExecutionContextException($"{typeof(Bool2x4)}.M24");

        /// <summary>
        /// Creates a new <see cref="Bool2x4"/> value with the same value for all its components.
        /// </summary>
        /// <param name="x">The value to use for the components of the new <see cref="Bool2x4"/> instance.</param>
        public static implicit operator Bool2x4(bool x)
        {
            Bool2x4 matrix;

            matrix.m11 = x;
            matrix.m12 = x;
            matrix.m13 = x;
            matrix.m14 = x;
            matrix.m21 = x;
            matrix.m22 = x;
            matrix.m23 = x;
            matrix.m24 = x;

            return matrix;
        }

        /// <summary>
        /// Negates a <see cref="Bool2x4"/> value.
        /// </summary>
        /// <param name="matrix">The <see cref="Bool2x4"/> value to negate.</param>
        public static Bool2x4 operator -(Bool2x4 matrix) => throw new InvalidExecutionContextException($"{typeof(Bool2x4)}.-");

        /// <summary>
        /// Sums two <see cref="Bool2x4"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool2x4"/> value to sum.</param>
        /// <param name="right">The second <see cref="Bool2x4"/> value to sum.</param>
        public static Bool2x4 operator +(Bool2x4 left, Bool2x4 right) => throw new InvalidExecutionContextException($"{typeof(Bool2x4)}.+");

        /// <summary>
        /// Divides two <see cref="Bool2x4"/> values (elementwise division).
        /// </summary>
        /// <param name="left">The first <see cref="Bool2x4"/> value to divide.</param>
        /// <param name="right">The second <see cref="Bool2x4"/> value to divide.</param>
        public static Bool2x4 operator /(Bool2x4 left, Bool2x4 right) => throw new InvalidExecutionContextException($"{typeof(Bool2x4)}./");

        /// <summary>
        /// Multiplies two <see cref="Bool2x4"/> values (elementwise product).
        /// </summary>
        /// <param name="left">The first <see cref="Bool2x4"/> value to multiply.</param>
        /// <param name="right">The second <see cref="Bool2x4"/> value to multiply.</param>
        public static Bool2x4 operator *(Bool2x4 left, Bool2x4 right) => throw new InvalidExecutionContextException($"{typeof(Bool2x4)}.*");

        /// <summary>
        /// Subtracts two <see cref="Bool2x4"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool2x4"/> value to subtract.</param>
        /// <param name="right">The second <see cref="Bool2x4"/> value to subtract.</param>
        public static Bool2x4 operator -(Bool2x4 left, Bool2x4 right) => throw new InvalidExecutionContextException($"{typeof(Bool2x4)}.-");
    }

    /// <inheritdoc cref="Bool3x1"/>
    [StructLayout(LayoutKind.Explicit, Size = 12, Pack = 4)]
    public partial struct Bool3x1
    {
        [FieldOffset(0)]
        private bool m11;

        [FieldOffset(4)]
        private bool m21;

        [FieldOffset(8)]
        private bool m31;

        /// <summary>
        /// Creates a new <see cref="Bool3x1"/> instance with the specified parameters.
        /// </summary>
        /// <param name="m11">The value to assign to the component at position [1, 1].</param>
        /// <param name="m21">The value to assign to the component at position [2, 1].</param>
        /// <param name="m31">The value to assign to the component at position [3, 1].</param>
        public Bool3x1(bool m11, bool m21, bool m31)
        {
            this.m11 = m11;
            this.m21 = m21;
            this.m31 = m31;
        }

        /// <summary>
        /// Gets a reference to a specific row in the current <see cref="Bool3x1"/> instance.
        /// </summary>
        /// <param name="row">The row to access.</param>
        public ref bool this[int row] => throw new InvalidExecutionContextException($"{typeof(Bool3x1)}[{typeof(int)}]");

        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool3x1"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        public ref Bool2 this[MatrixIndex xy0, MatrixIndex xy1] => throw new InvalidExecutionContextException($"{typeof(Bool3x1)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool3x1"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        public ref Bool3 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2] => throw new InvalidExecutionContextException($"{typeof(Bool3x1)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool3x1"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        /// <param name="xy3">The identifier of the fourth item to index.</param>
        public ref Bool4 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2, MatrixIndex xy3] => throw new InvalidExecutionContextException($"{typeof(Bool3x1)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 1].
        /// </summary>
        public ref bool M11 => throw new InvalidExecutionContextException($"{typeof(Bool3x1)}.M11");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 1].
        /// </summary>
        public ref bool M21 => throw new InvalidExecutionContextException($"{typeof(Bool3x1)}.M21");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 1].
        /// </summary>
        public ref bool M31 => throw new InvalidExecutionContextException($"{typeof(Bool3x1)}.M31");

        /// <summary>
        /// Creates a new <see cref="Bool3x1"/> value with the same value for all its components.
        /// </summary>
        /// <param name="x">The value to use for the components of the new <see cref="Bool3x1"/> instance.</param>
        public static implicit operator Bool3x1(bool x)
        {
            Bool3x1 matrix;

            matrix.m11 = x;
            matrix.m21 = x;
            matrix.m31 = x;

            return matrix;
        }

        /// <summary>
        /// Negates a <see cref="Bool3x1"/> value.
        /// </summary>
        /// <param name="matrix">The <see cref="Bool3x1"/> value to negate.</param>
        public static Bool3x1 operator -(Bool3x1 matrix) => throw new InvalidExecutionContextException($"{typeof(Bool3x1)}.-");

        /// <summary>
        /// Sums two <see cref="Bool3x1"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool3x1"/> value to sum.</param>
        /// <param name="right">The second <see cref="Bool3x1"/> value to sum.</param>
        public static Bool3x1 operator +(Bool3x1 left, Bool3x1 right) => throw new InvalidExecutionContextException($"{typeof(Bool3x1)}.+");

        /// <summary>
        /// Divides two <see cref="Bool3x1"/> values (elementwise division).
        /// </summary>
        /// <param name="left">The first <see cref="Bool3x1"/> value to divide.</param>
        /// <param name="right">The second <see cref="Bool3x1"/> value to divide.</param>
        public static Bool3x1 operator /(Bool3x1 left, Bool3x1 right) => throw new InvalidExecutionContextException($"{typeof(Bool3x1)}./");

        /// <summary>
        /// Multiplies two <see cref="Bool3x1"/> values (elementwise product).
        /// </summary>
        /// <param name="left">The first <see cref="Bool3x1"/> value to multiply.</param>
        /// <param name="right">The second <see cref="Bool3x1"/> value to multiply.</param>
        public static Bool3x1 operator *(Bool3x1 left, Bool3x1 right) => throw new InvalidExecutionContextException($"{typeof(Bool3x1)}.*");

        /// <summary>
        /// Subtracts two <see cref="Bool3x1"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool3x1"/> value to subtract.</param>
        /// <param name="right">The second <see cref="Bool3x1"/> value to subtract.</param>
        public static Bool3x1 operator -(Bool3x1 left, Bool3x1 right) => throw new InvalidExecutionContextException($"{typeof(Bool3x1)}.-");

        /// <summary>
        /// Casts a <see cref="Bool3x1"/> value to a <see cref="Bool3"/> one.
        /// </summary>
        /// <param name="matrix">The input <see cref="Bool3x1"/> value to cast.</param>
        public static implicit operator Bool3(Bool3x1 matrix) => throw new InvalidExecutionContextException($"{typeof(Bool3x1)}.{typeof(Bool3)}({typeof(Bool3x1)})");
    }

    /// <inheritdoc cref="Bool3x2"/>
    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 4)]
    public partial struct Bool3x2
    {
        [FieldOffset(0)]
        private bool m11;

        [FieldOffset(4)]
        private bool m12;

        [FieldOffset(8)]
        private bool m21;

        [FieldOffset(12)]
        private bool m22;

        [FieldOffset(16)]
        private bool m31;

        [FieldOffset(20)]
        private bool m32;

        /// <summary>
        /// Creates a new <see cref="Bool3x2"/> instance with the specified parameters.
        /// </summary>
        /// <param name="m11">The value to assign to the component at position [1, 1].</param>
        /// <param name="m12">The value to assign to the component at position [1, 2].</param>
        /// <param name="m21">The value to assign to the component at position [2, 1].</param>
        /// <param name="m22">The value to assign to the component at position [2, 2].</param>
        /// <param name="m31">The value to assign to the component at position [3, 1].</param>
        /// <param name="m32">The value to assign to the component at position [3, 2].</param>
        public Bool3x2(bool m11, bool m12, bool m21, bool m22, bool m31, bool m32)
        {
            this.m11 = m11;
            this.m12 = m12;
            this.m21 = m21;
            this.m22 = m22;
            this.m31 = m31;
            this.m32 = m32;
        }

        /// <summary>
        /// Creates a new <see cref="Bool3x2"/> instance with the specified parameters.
        /// </summary>
        /// <param name="row1">The value to assign to the row at position [1].</param>
        /// <param name="row2">The value to assign to the row at position [2].</param>
        /// <param name="row3">The value to assign to the row at position [3].</param>
        public Bool3x2(Bool2 row1, Bool2 row2, Bool2 row3)
        {
            this.m11 = row1.X;
            this.m12 = row1.Y;
            this.m21 = row2.X;
            this.m22 = row2.Y;
            this.m31 = row3.X;
            this.m32 = row3.Y;
        }

        /// <summary>
        /// Gets a reference to a specific row in the current <see cref="Bool3x2"/> instance.
        /// </summary>
        /// <param name="row">The row to access.</param>
        public ref Bool2 this[int row] => throw new InvalidExecutionContextException($"{typeof(Bool3x2)}[{typeof(int)}]");

        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool3x2"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        public ref Bool2 this[MatrixIndex xy0, MatrixIndex xy1] => throw new InvalidExecutionContextException($"{typeof(Bool3x2)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool3x2"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        public ref Bool3 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2] => throw new InvalidExecutionContextException($"{typeof(Bool3x2)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool3x2"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        /// <param name="xy3">The identifier of the fourth item to index.</param>
        public ref Bool4 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2, MatrixIndex xy3] => throw new InvalidExecutionContextException($"{typeof(Bool3x2)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 1].
        /// </summary>
        public ref bool M11 => throw new InvalidExecutionContextException($"{typeof(Bool3x2)}.M11");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 2].
        /// </summary>
        public ref bool M12 => throw new InvalidExecutionContextException($"{typeof(Bool3x2)}.M12");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 1].
        /// </summary>
        public ref bool M21 => throw new InvalidExecutionContextException($"{typeof(Bool3x2)}.M21");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 2].
        /// </summary>
        public ref bool M22 => throw new InvalidExecutionContextException($"{typeof(Bool3x2)}.M22");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 1].
        /// </summary>
        public ref bool M31 => throw new InvalidExecutionContextException($"{typeof(Bool3x2)}.M31");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 2].
        /// </summary>
        public ref bool M32 => throw new InvalidExecutionContextException($"{typeof(Bool3x2)}.M32");

        /// <summary>
        /// Creates a new <see cref="Bool3x2"/> value with the same value for all its components.
        /// </summary>
        /// <param name="x">The value to use for the components of the new <see cref="Bool3x2"/> instance.</param>
        public static implicit operator Bool3x2(bool x)
        {
            Bool3x2 matrix;

            matrix.m11 = x;
            matrix.m12 = x;
            matrix.m21 = x;
            matrix.m22 = x;
            matrix.m31 = x;
            matrix.m32 = x;

            return matrix;
        }

        /// <summary>
        /// Negates a <see cref="Bool3x2"/> value.
        /// </summary>
        /// <param name="matrix">The <see cref="Bool3x2"/> value to negate.</param>
        public static Bool3x2 operator -(Bool3x2 matrix) => throw new InvalidExecutionContextException($"{typeof(Bool3x2)}.-");

        /// <summary>
        /// Sums two <see cref="Bool3x2"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool3x2"/> value to sum.</param>
        /// <param name="right">The second <see cref="Bool3x2"/> value to sum.</param>
        public static Bool3x2 operator +(Bool3x2 left, Bool3x2 right) => throw new InvalidExecutionContextException($"{typeof(Bool3x2)}.+");

        /// <summary>
        /// Divides two <see cref="Bool3x2"/> values (elementwise division).
        /// </summary>
        /// <param name="left">The first <see cref="Bool3x2"/> value to divide.</param>
        /// <param name="right">The second <see cref="Bool3x2"/> value to divide.</param>
        public static Bool3x2 operator /(Bool3x2 left, Bool3x2 right) => throw new InvalidExecutionContextException($"{typeof(Bool3x2)}./");

        /// <summary>
        /// Multiplies two <see cref="Bool3x2"/> values (elementwise product).
        /// </summary>
        /// <param name="left">The first <see cref="Bool3x2"/> value to multiply.</param>
        /// <param name="right">The second <see cref="Bool3x2"/> value to multiply.</param>
        public static Bool3x2 operator *(Bool3x2 left, Bool3x2 right) => throw new InvalidExecutionContextException($"{typeof(Bool3x2)}.*");

        /// <summary>
        /// Subtracts two <see cref="Bool3x2"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool3x2"/> value to subtract.</param>
        /// <param name="right">The second <see cref="Bool3x2"/> value to subtract.</param>
        public static Bool3x2 operator -(Bool3x2 left, Bool3x2 right) => throw new InvalidExecutionContextException($"{typeof(Bool3x2)}.-");
    }

    /// <inheritdoc cref="Bool3x3"/>
    [StructLayout(LayoutKind.Explicit, Size = 36, Pack = 4)]
    public partial struct Bool3x3
    {
        [FieldOffset(0)]
        private bool m11;

        [FieldOffset(4)]
        private bool m12;

        [FieldOffset(8)]
        private bool m13;

        [FieldOffset(12)]
        private bool m21;

        [FieldOffset(16)]
        private bool m22;

        [FieldOffset(20)]
        private bool m23;

        [FieldOffset(24)]
        private bool m31;

        [FieldOffset(28)]
        private bool m32;

        [FieldOffset(32)]
        private bool m33;

        /// <summary>
        /// Creates a new <see cref="Bool3x3"/> instance with the specified parameters.
        /// </summary>
        /// <param name="m11">The value to assign to the component at position [1, 1].</param>
        /// <param name="m12">The value to assign to the component at position [1, 2].</param>
        /// <param name="m13">The value to assign to the component at position [1, 3].</param>
        /// <param name="m21">The value to assign to the component at position [2, 1].</param>
        /// <param name="m22">The value to assign to the component at position [2, 2].</param>
        /// <param name="m23">The value to assign to the component at position [2, 3].</param>
        /// <param name="m31">The value to assign to the component at position [3, 1].</param>
        /// <param name="m32">The value to assign to the component at position [3, 2].</param>
        /// <param name="m33">The value to assign to the component at position [3, 3].</param>
        public Bool3x3(bool m11, bool m12, bool m13, bool m21, bool m22, bool m23, bool m31, bool m32, bool m33)
        {
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m21 = m21;
            this.m22 = m22;
            this.m23 = m23;
            this.m31 = m31;
            this.m32 = m32;
            this.m33 = m33;
        }

        /// <summary>
        /// Creates a new <see cref="Bool3x3"/> instance with the specified parameters.
        /// </summary>
        /// <param name="row1">The value to assign to the row at position [1].</param>
        /// <param name="row2">The value to assign to the row at position [2].</param>
        /// <param name="row3">The value to assign to the row at position [3].</param>
        public Bool3x3(Bool3 row1, Bool3 row2, Bool3 row3)
        {
            this.m11 = row1.X;
            this.m12 = row1.Y;
            this.m13 = row1.Z;
            this.m21 = row2.X;
            this.m22 = row2.Y;
            this.m23 = row2.Z;
            this.m31 = row3.X;
            this.m32 = row3.Y;
            this.m33 = row3.Z;
        }

        /// <summary>
        /// Gets a reference to a specific row in the current <see cref="Bool3x3"/> instance.
        /// </summary>
        /// <param name="row">The row to access.</param>
        public ref Bool3 this[int row] => throw new InvalidExecutionContextException($"{typeof(Bool3x3)}[{typeof(int)}]");

        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool3x3"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        public ref Bool2 this[MatrixIndex xy0, MatrixIndex xy1] => throw new InvalidExecutionContextException($"{typeof(Bool3x3)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool3x3"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        public ref Bool3 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2] => throw new InvalidExecutionContextException($"{typeof(Bool3x3)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool3x3"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        /// <param name="xy3">The identifier of the fourth item to index.</param>
        public ref Bool4 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2, MatrixIndex xy3] => throw new InvalidExecutionContextException($"{typeof(Bool3x3)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 1].
        /// </summary>
        public ref bool M11 => throw new InvalidExecutionContextException($"{typeof(Bool3x3)}.M11");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 2].
        /// </summary>
        public ref bool M12 => throw new InvalidExecutionContextException($"{typeof(Bool3x3)}.M12");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 3].
        /// </summary>
        public ref bool M13 => throw new InvalidExecutionContextException($"{typeof(Bool3x3)}.M13");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 1].
        /// </summary>
        public ref bool M21 => throw new InvalidExecutionContextException($"{typeof(Bool3x3)}.M21");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 2].
        /// </summary>
        public ref bool M22 => throw new InvalidExecutionContextException($"{typeof(Bool3x3)}.M22");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 3].
        /// </summary>
        public ref bool M23 => throw new InvalidExecutionContextException($"{typeof(Bool3x3)}.M23");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 1].
        /// </summary>
        public ref bool M31 => throw new InvalidExecutionContextException($"{typeof(Bool3x3)}.M31");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 2].
        /// </summary>
        public ref bool M32 => throw new InvalidExecutionContextException($"{typeof(Bool3x3)}.M32");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 3].
        /// </summary>
        public ref bool M33 => throw new InvalidExecutionContextException($"{typeof(Bool3x3)}.M33");

        /// <summary>
        /// Creates a new <see cref="Bool3x3"/> value with the same value for all its components.
        /// </summary>
        /// <param name="x">The value to use for the components of the new <see cref="Bool3x3"/> instance.</param>
        public static implicit operator Bool3x3(bool x)
        {
            Bool3x3 matrix;

            matrix.m11 = x;
            matrix.m12 = x;
            matrix.m13 = x;
            matrix.m21 = x;
            matrix.m22 = x;
            matrix.m23 = x;
            matrix.m31 = x;
            matrix.m32 = x;
            matrix.m33 = x;

            return matrix;
        }

        /// <summary>
        /// Negates a <see cref="Bool3x3"/> value.
        /// </summary>
        /// <param name="matrix">The <see cref="Bool3x3"/> value to negate.</param>
        public static Bool3x3 operator -(Bool3x3 matrix) => throw new InvalidExecutionContextException($"{typeof(Bool3x3)}.-");

        /// <summary>
        /// Sums two <see cref="Bool3x3"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool3x3"/> value to sum.</param>
        /// <param name="right">The second <see cref="Bool3x3"/> value to sum.</param>
        public static Bool3x3 operator +(Bool3x3 left, Bool3x3 right) => throw new InvalidExecutionContextException($"{typeof(Bool3x3)}.+");

        /// <summary>
        /// Divides two <see cref="Bool3x3"/> values (elementwise division).
        /// </summary>
        /// <param name="left">The first <see cref="Bool3x3"/> value to divide.</param>
        /// <param name="right">The second <see cref="Bool3x3"/> value to divide.</param>
        public static Bool3x3 operator /(Bool3x3 left, Bool3x3 right) => throw new InvalidExecutionContextException($"{typeof(Bool3x3)}./");

        /// <summary>
        /// Multiplies two <see cref="Bool3x3"/> values (elementwise product).
        /// </summary>
        /// <param name="left">The first <see cref="Bool3x3"/> value to multiply.</param>
        /// <param name="right">The second <see cref="Bool3x3"/> value to multiply.</param>
        public static Bool3x3 operator *(Bool3x3 left, Bool3x3 right) => throw new InvalidExecutionContextException($"{typeof(Bool3x3)}.*");

        /// <summary>
        /// Subtracts two <see cref="Bool3x3"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool3x3"/> value to subtract.</param>
        /// <param name="right">The second <see cref="Bool3x3"/> value to subtract.</param>
        public static Bool3x3 operator -(Bool3x3 left, Bool3x3 right) => throw new InvalidExecutionContextException($"{typeof(Bool3x3)}.-");
    }

    /// <inheritdoc cref="Bool3x4"/>
    [StructLayout(LayoutKind.Explicit, Size = 48, Pack = 4)]
    public partial struct Bool3x4
    {
        [FieldOffset(0)]
        private bool m11;

        [FieldOffset(4)]
        private bool m12;

        [FieldOffset(8)]
        private bool m13;

        [FieldOffset(12)]
        private bool m14;

        [FieldOffset(16)]
        private bool m21;

        [FieldOffset(20)]
        private bool m22;

        [FieldOffset(24)]
        private bool m23;

        [FieldOffset(28)]
        private bool m24;

        [FieldOffset(32)]
        private bool m31;

        [FieldOffset(36)]
        private bool m32;

        [FieldOffset(40)]
        private bool m33;

        [FieldOffset(44)]
        private bool m34;

        /// <summary>
        /// Creates a new <see cref="Bool3x4"/> instance with the specified parameters.
        /// </summary>
        /// <param name="m11">The value to assign to the component at position [1, 1].</param>
        /// <param name="m12">The value to assign to the component at position [1, 2].</param>
        /// <param name="m13">The value to assign to the component at position [1, 3].</param>
        /// <param name="m14">The value to assign to the component at position [1, 4].</param>
        /// <param name="m21">The value to assign to the component at position [2, 1].</param>
        /// <param name="m22">The value to assign to the component at position [2, 2].</param>
        /// <param name="m23">The value to assign to the component at position [2, 3].</param>
        /// <param name="m24">The value to assign to the component at position [2, 4].</param>
        /// <param name="m31">The value to assign to the component at position [3, 1].</param>
        /// <param name="m32">The value to assign to the component at position [3, 2].</param>
        /// <param name="m33">The value to assign to the component at position [3, 3].</param>
        /// <param name="m34">The value to assign to the component at position [3, 4].</param>
        public Bool3x4(bool m11, bool m12, bool m13, bool m14, bool m21, bool m22, bool m23, bool m24, bool m31, bool m32, bool m33, bool m34)
        {
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m14 = m14;
            this.m21 = m21;
            this.m22 = m22;
            this.m23 = m23;
            this.m24 = m24;
            this.m31 = m31;
            this.m32 = m32;
            this.m33 = m33;
            this.m34 = m34;
        }

        /// <summary>
        /// Creates a new <see cref="Bool3x4"/> instance with the specified parameters.
        /// </summary>
        /// <param name="row1">The value to assign to the row at position [1].</param>
        /// <param name="row2">The value to assign to the row at position [2].</param>
        /// <param name="row3">The value to assign to the row at position [3].</param>
        public Bool3x4(Bool4 row1, Bool4 row2, Bool4 row3)
        {
            this.m11 = row1.X;
            this.m12 = row1.Y;
            this.m13 = row1.Z;
            this.m14 = row1.W;
            this.m21 = row2.X;
            this.m22 = row2.Y;
            this.m23 = row2.Z;
            this.m24 = row2.W;
            this.m31 = row3.X;
            this.m32 = row3.Y;
            this.m33 = row3.Z;
            this.m34 = row3.W;
        }

        /// <summary>
        /// Gets a reference to a specific row in the current <see cref="Bool3x4"/> instance.
        /// </summary>
        /// <param name="row">The row to access.</param>
        public ref Bool4 this[int row] => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}[{typeof(int)}]");

        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool3x4"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        public ref Bool2 this[MatrixIndex xy0, MatrixIndex xy1] => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool3x4"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        public ref Bool3 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2] => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool3x4"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        /// <param name="xy3">The identifier of the fourth item to index.</param>
        public ref Bool4 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2, MatrixIndex xy3] => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 1].
        /// </summary>
        public ref bool M11 => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}.M11");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 2].
        /// </summary>
        public ref bool M12 => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}.M12");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 3].
        /// </summary>
        public ref bool M13 => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}.M13");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 4].
        /// </summary>
        public ref bool M14 => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}.M14");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 1].
        /// </summary>
        public ref bool M21 => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}.M21");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 2].
        /// </summary>
        public ref bool M22 => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}.M22");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 3].
        /// </summary>
        public ref bool M23 => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}.M23");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 4].
        /// </summary>
        public ref bool M24 => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}.M24");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 1].
        /// </summary>
        public ref bool M31 => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}.M31");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 2].
        /// </summary>
        public ref bool M32 => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}.M32");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 3].
        /// </summary>
        public ref bool M33 => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}.M33");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 4].
        /// </summary>
        public ref bool M34 => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}.M34");

        /// <summary>
        /// Creates a new <see cref="Bool3x4"/> value with the same value for all its components.
        /// </summary>
        /// <param name="x">The value to use for the components of the new <see cref="Bool3x4"/> instance.</param>
        public static implicit operator Bool3x4(bool x)
        {
            Bool3x4 matrix;

            matrix.m11 = x;
            matrix.m12 = x;
            matrix.m13 = x;
            matrix.m14 = x;
            matrix.m21 = x;
            matrix.m22 = x;
            matrix.m23 = x;
            matrix.m24 = x;
            matrix.m31 = x;
            matrix.m32 = x;
            matrix.m33 = x;
            matrix.m34 = x;

            return matrix;
        }

        /// <summary>
        /// Negates a <see cref="Bool3x4"/> value.
        /// </summary>
        /// <param name="matrix">The <see cref="Bool3x4"/> value to negate.</param>
        public static Bool3x4 operator -(Bool3x4 matrix) => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}.-");

        /// <summary>
        /// Sums two <see cref="Bool3x4"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool3x4"/> value to sum.</param>
        /// <param name="right">The second <see cref="Bool3x4"/> value to sum.</param>
        public static Bool3x4 operator +(Bool3x4 left, Bool3x4 right) => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}.+");

        /// <summary>
        /// Divides two <see cref="Bool3x4"/> values (elementwise division).
        /// </summary>
        /// <param name="left">The first <see cref="Bool3x4"/> value to divide.</param>
        /// <param name="right">The second <see cref="Bool3x4"/> value to divide.</param>
        public static Bool3x4 operator /(Bool3x4 left, Bool3x4 right) => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}./");

        /// <summary>
        /// Multiplies two <see cref="Bool3x4"/> values (elementwise product).
        /// </summary>
        /// <param name="left">The first <see cref="Bool3x4"/> value to multiply.</param>
        /// <param name="right">The second <see cref="Bool3x4"/> value to multiply.</param>
        public static Bool3x4 operator *(Bool3x4 left, Bool3x4 right) => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}.*");

        /// <summary>
        /// Subtracts two <see cref="Bool3x4"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool3x4"/> value to subtract.</param>
        /// <param name="right">The second <see cref="Bool3x4"/> value to subtract.</param>
        public static Bool3x4 operator -(Bool3x4 left, Bool3x4 right) => throw new InvalidExecutionContextException($"{typeof(Bool3x4)}.-");
    }

    /// <inheritdoc cref="Bool4x1"/>
    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 4)]
    public partial struct Bool4x1
    {
        [FieldOffset(0)]
        private bool m11;

        [FieldOffset(4)]
        private bool m21;

        [FieldOffset(8)]
        private bool m31;

        [FieldOffset(12)]
        private bool m41;

        /// <summary>
        /// Creates a new <see cref="Bool4x1"/> instance with the specified parameters.
        /// </summary>
        /// <param name="m11">The value to assign to the component at position [1, 1].</param>
        /// <param name="m21">The value to assign to the component at position [2, 1].</param>
        /// <param name="m31">The value to assign to the component at position [3, 1].</param>
        /// <param name="m41">The value to assign to the component at position [4, 1].</param>
        public Bool4x1(bool m11, bool m21, bool m31, bool m41)
        {
            this.m11 = m11;
            this.m21 = m21;
            this.m31 = m31;
            this.m41 = m41;
        }

        /// <summary>
        /// Gets a reference to a specific row in the current <see cref="Bool4x1"/> instance.
        /// </summary>
        /// <param name="row">The row to access.</param>
        public ref bool this[int row] => throw new InvalidExecutionContextException($"{typeof(Bool4x1)}[{typeof(int)}]");

        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool4x1"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        public ref Bool2 this[MatrixIndex xy0, MatrixIndex xy1] => throw new InvalidExecutionContextException($"{typeof(Bool4x1)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool4x1"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        public ref Bool3 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2] => throw new InvalidExecutionContextException($"{typeof(Bool4x1)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool4x1"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        /// <param name="xy3">The identifier of the fourth item to index.</param>
        public ref Bool4 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2, MatrixIndex xy3] => throw new InvalidExecutionContextException($"{typeof(Bool4x1)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 1].
        /// </summary>
        public ref bool M11 => throw new InvalidExecutionContextException($"{typeof(Bool4x1)}.M11");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 1].
        /// </summary>
        public ref bool M21 => throw new InvalidExecutionContextException($"{typeof(Bool4x1)}.M21");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 1].
        /// </summary>
        public ref bool M31 => throw new InvalidExecutionContextException($"{typeof(Bool4x1)}.M31");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [4, 1].
        /// </summary>
        public ref bool M41 => throw new InvalidExecutionContextException($"{typeof(Bool4x1)}.M41");

        /// <summary>
        /// Creates a new <see cref="Bool4x1"/> value with the same value for all its components.
        /// </summary>
        /// <param name="x">The value to use for the components of the new <see cref="Bool4x1"/> instance.</param>
        public static implicit operator Bool4x1(bool x)
        {
            Bool4x1 matrix;

            matrix.m11 = x;
            matrix.m21 = x;
            matrix.m31 = x;
            matrix.m41 = x;

            return matrix;
        }

        /// <summary>
        /// Negates a <see cref="Bool4x1"/> value.
        /// </summary>
        /// <param name="matrix">The <see cref="Bool4x1"/> value to negate.</param>
        public static Bool4x1 operator -(Bool4x1 matrix) => throw new InvalidExecutionContextException($"{typeof(Bool4x1)}.-");

        /// <summary>
        /// Sums two <see cref="Bool4x1"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool4x1"/> value to sum.</param>
        /// <param name="right">The second <see cref="Bool4x1"/> value to sum.</param>
        public static Bool4x1 operator +(Bool4x1 left, Bool4x1 right) => throw new InvalidExecutionContextException($"{typeof(Bool4x1)}.+");

        /// <summary>
        /// Divides two <see cref="Bool4x1"/> values (elementwise division).
        /// </summary>
        /// <param name="left">The first <see cref="Bool4x1"/> value to divide.</param>
        /// <param name="right">The second <see cref="Bool4x1"/> value to divide.</param>
        public static Bool4x1 operator /(Bool4x1 left, Bool4x1 right) => throw new InvalidExecutionContextException($"{typeof(Bool4x1)}./");

        /// <summary>
        /// Multiplies two <see cref="Bool4x1"/> values (elementwise product).
        /// </summary>
        /// <param name="left">The first <see cref="Bool4x1"/> value to multiply.</param>
        /// <param name="right">The second <see cref="Bool4x1"/> value to multiply.</param>
        public static Bool4x1 operator *(Bool4x1 left, Bool4x1 right) => throw new InvalidExecutionContextException($"{typeof(Bool4x1)}.*");

        /// <summary>
        /// Subtracts two <see cref="Bool4x1"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool4x1"/> value to subtract.</param>
        /// <param name="right">The second <see cref="Bool4x1"/> value to subtract.</param>
        public static Bool4x1 operator -(Bool4x1 left, Bool4x1 right) => throw new InvalidExecutionContextException($"{typeof(Bool4x1)}.-");

        /// <summary>
        /// Casts a <see cref="Bool4x1"/> value to a <see cref="Bool4"/> one.
        /// </summary>
        /// <param name="matrix">The input <see cref="Bool4x1"/> value to cast.</param>
        public static implicit operator Bool4(Bool4x1 matrix) => throw new InvalidExecutionContextException($"{typeof(Bool4x1)}.{typeof(Bool4)}({typeof(Bool4x1)})");
    }

    /// <inheritdoc cref="Bool4x2"/>
    [StructLayout(LayoutKind.Explicit, Size = 32, Pack = 4)]
    public partial struct Bool4x2
    {
        [FieldOffset(0)]
        private bool m11;

        [FieldOffset(4)]
        private bool m12;

        [FieldOffset(8)]
        private bool m21;

        [FieldOffset(12)]
        private bool m22;

        [FieldOffset(16)]
        private bool m31;

        [FieldOffset(20)]
        private bool m32;

        [FieldOffset(24)]
        private bool m41;

        [FieldOffset(28)]
        private bool m42;

        /// <summary>
        /// Creates a new <see cref="Bool4x2"/> instance with the specified parameters.
        /// </summary>
        /// <param name="m11">The value to assign to the component at position [1, 1].</param>
        /// <param name="m12">The value to assign to the component at position [1, 2].</param>
        /// <param name="m21">The value to assign to the component at position [2, 1].</param>
        /// <param name="m22">The value to assign to the component at position [2, 2].</param>
        /// <param name="m31">The value to assign to the component at position [3, 1].</param>
        /// <param name="m32">The value to assign to the component at position [3, 2].</param>
        /// <param name="m41">The value to assign to the component at position [4, 1].</param>
        /// <param name="m42">The value to assign to the component at position [4, 2].</param>
        public Bool4x2(bool m11, bool m12, bool m21, bool m22, bool m31, bool m32, bool m41, bool m42)
        {
            this.m11 = m11;
            this.m12 = m12;
            this.m21 = m21;
            this.m22 = m22;
            this.m31 = m31;
            this.m32 = m32;
            this.m41 = m41;
            this.m42 = m42;
        }

        /// <summary>
        /// Creates a new <see cref="Bool4x2"/> instance with the specified parameters.
        /// </summary>
        /// <param name="row1">The value to assign to the row at position [1].</param>
        /// <param name="row2">The value to assign to the row at position [2].</param>
        /// <param name="row3">The value to assign to the row at position [3].</param>
        /// <param name="row4">The value to assign to the row at position [4].</param>
        public Bool4x2(Bool2 row1, Bool2 row2, Bool2 row3, Bool2 row4)
        {
            this.m11 = row1.X;
            this.m12 = row1.Y;
            this.m21 = row2.X;
            this.m22 = row2.Y;
            this.m31 = row3.X;
            this.m32 = row3.Y;
            this.m41 = row4.X;
            this.m42 = row4.Y;
        }

        /// <summary>
        /// Gets a reference to a specific row in the current <see cref="Bool4x2"/> instance.
        /// </summary>
        /// <param name="row">The row to access.</param>
        public ref Bool2 this[int row] => throw new InvalidExecutionContextException($"{typeof(Bool4x2)}[{typeof(int)}]");

        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool4x2"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        public ref Bool2 this[MatrixIndex xy0, MatrixIndex xy1] => throw new InvalidExecutionContextException($"{typeof(Bool4x2)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool4x2"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        public ref Bool3 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2] => throw new InvalidExecutionContextException($"{typeof(Bool4x2)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool4x2"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        /// <param name="xy3">The identifier of the fourth item to index.</param>
        public ref Bool4 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2, MatrixIndex xy3] => throw new InvalidExecutionContextException($"{typeof(Bool4x2)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 1].
        /// </summary>
        public ref bool M11 => throw new InvalidExecutionContextException($"{typeof(Bool4x2)}.M11");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 2].
        /// </summary>
        public ref bool M12 => throw new InvalidExecutionContextException($"{typeof(Bool4x2)}.M12");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 1].
        /// </summary>
        public ref bool M21 => throw new InvalidExecutionContextException($"{typeof(Bool4x2)}.M21");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 2].
        /// </summary>
        public ref bool M22 => throw new InvalidExecutionContextException($"{typeof(Bool4x2)}.M22");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 1].
        /// </summary>
        public ref bool M31 => throw new InvalidExecutionContextException($"{typeof(Bool4x2)}.M31");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 2].
        /// </summary>
        public ref bool M32 => throw new InvalidExecutionContextException($"{typeof(Bool4x2)}.M32");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [4, 1].
        /// </summary>
        public ref bool M41 => throw new InvalidExecutionContextException($"{typeof(Bool4x2)}.M41");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [4, 2].
        /// </summary>
        public ref bool M42 => throw new InvalidExecutionContextException($"{typeof(Bool4x2)}.M42");

        /// <summary>
        /// Creates a new <see cref="Bool4x2"/> value with the same value for all its components.
        /// </summary>
        /// <param name="x">The value to use for the components of the new <see cref="Bool4x2"/> instance.</param>
        public static implicit operator Bool4x2(bool x)
        {
            Bool4x2 matrix;

            matrix.m11 = x;
            matrix.m12 = x;
            matrix.m21 = x;
            matrix.m22 = x;
            matrix.m31 = x;
            matrix.m32 = x;
            matrix.m41 = x;
            matrix.m42 = x;

            return matrix;
        }

        /// <summary>
        /// Negates a <see cref="Bool4x2"/> value.
        /// </summary>
        /// <param name="matrix">The <see cref="Bool4x2"/> value to negate.</param>
        public static Bool4x2 operator -(Bool4x2 matrix) => throw new InvalidExecutionContextException($"{typeof(Bool4x2)}.-");

        /// <summary>
        /// Sums two <see cref="Bool4x2"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool4x2"/> value to sum.</param>
        /// <param name="right">The second <see cref="Bool4x2"/> value to sum.</param>
        public static Bool4x2 operator +(Bool4x2 left, Bool4x2 right) => throw new InvalidExecutionContextException($"{typeof(Bool4x2)}.+");

        /// <summary>
        /// Divides two <see cref="Bool4x2"/> values (elementwise division).
        /// </summary>
        /// <param name="left">The first <see cref="Bool4x2"/> value to divide.</param>
        /// <param name="right">The second <see cref="Bool4x2"/> value to divide.</param>
        public static Bool4x2 operator /(Bool4x2 left, Bool4x2 right) => throw new InvalidExecutionContextException($"{typeof(Bool4x2)}./");

        /// <summary>
        /// Multiplies two <see cref="Bool4x2"/> values (elementwise product).
        /// </summary>
        /// <param name="left">The first <see cref="Bool4x2"/> value to multiply.</param>
        /// <param name="right">The second <see cref="Bool4x2"/> value to multiply.</param>
        public static Bool4x2 operator *(Bool4x2 left, Bool4x2 right) => throw new InvalidExecutionContextException($"{typeof(Bool4x2)}.*");

        /// <summary>
        /// Subtracts two <see cref="Bool4x2"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool4x2"/> value to subtract.</param>
        /// <param name="right">The second <see cref="Bool4x2"/> value to subtract.</param>
        public static Bool4x2 operator -(Bool4x2 left, Bool4x2 right) => throw new InvalidExecutionContextException($"{typeof(Bool4x2)}.-");
    }

    /// <inheritdoc cref="Bool4x3"/>
    [StructLayout(LayoutKind.Explicit, Size = 48, Pack = 4)]
    public partial struct Bool4x3
    {
        [FieldOffset(0)]
        private bool m11;

        [FieldOffset(4)]
        private bool m12;

        [FieldOffset(8)]
        private bool m13;

        [FieldOffset(12)]
        private bool m21;

        [FieldOffset(16)]
        private bool m22;

        [FieldOffset(20)]
        private bool m23;

        [FieldOffset(24)]
        private bool m31;

        [FieldOffset(28)]
        private bool m32;

        [FieldOffset(32)]
        private bool m33;

        [FieldOffset(36)]
        private bool m41;

        [FieldOffset(40)]
        private bool m42;

        [FieldOffset(44)]
        private bool m43;

        /// <summary>
        /// Creates a new <see cref="Bool4x3"/> instance with the specified parameters.
        /// </summary>
        /// <param name="m11">The value to assign to the component at position [1, 1].</param>
        /// <param name="m12">The value to assign to the component at position [1, 2].</param>
        /// <param name="m13">The value to assign to the component at position [1, 3].</param>
        /// <param name="m21">The value to assign to the component at position [2, 1].</param>
        /// <param name="m22">The value to assign to the component at position [2, 2].</param>
        /// <param name="m23">The value to assign to the component at position [2, 3].</param>
        /// <param name="m31">The value to assign to the component at position [3, 1].</param>
        /// <param name="m32">The value to assign to the component at position [3, 2].</param>
        /// <param name="m33">The value to assign to the component at position [3, 3].</param>
        /// <param name="m41">The value to assign to the component at position [4, 1].</param>
        /// <param name="m42">The value to assign to the component at position [4, 2].</param>
        /// <param name="m43">The value to assign to the component at position [4, 3].</param>
        public Bool4x3(bool m11, bool m12, bool m13, bool m21, bool m22, bool m23, bool m31, bool m32, bool m33, bool m41, bool m42, bool m43)
        {
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m21 = m21;
            this.m22 = m22;
            this.m23 = m23;
            this.m31 = m31;
            this.m32 = m32;
            this.m33 = m33;
            this.m41 = m41;
            this.m42 = m42;
            this.m43 = m43;
        }

        /// <summary>
        /// Creates a new <see cref="Bool4x3"/> instance with the specified parameters.
        /// </summary>
        /// <param name="row1">The value to assign to the row at position [1].</param>
        /// <param name="row2">The value to assign to the row at position [2].</param>
        /// <param name="row3">The value to assign to the row at position [3].</param>
        /// <param name="row4">The value to assign to the row at position [4].</param>
        public Bool4x3(Bool3 row1, Bool3 row2, Bool3 row3, Bool3 row4)
        {
            this.m11 = row1.X;
            this.m12 = row1.Y;
            this.m13 = row1.Z;
            this.m21 = row2.X;
            this.m22 = row2.Y;
            this.m23 = row2.Z;
            this.m31 = row3.X;
            this.m32 = row3.Y;
            this.m33 = row3.Z;
            this.m41 = row4.X;
            this.m42 = row4.Y;
            this.m43 = row4.Z;
        }

        /// <summary>
        /// Gets a reference to a specific row in the current <see cref="Bool4x3"/> instance.
        /// </summary>
        /// <param name="row">The row to access.</param>
        public ref Bool3 this[int row] => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}[{typeof(int)}]");

        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool4x3"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        public ref Bool2 this[MatrixIndex xy0, MatrixIndex xy1] => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool4x3"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        public ref Bool3 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2] => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool4x3"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        /// <param name="xy3">The identifier of the fourth item to index.</param>
        public ref Bool4 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2, MatrixIndex xy3] => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 1].
        /// </summary>
        public ref bool M11 => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}.M11");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 2].
        /// </summary>
        public ref bool M12 => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}.M12");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 3].
        /// </summary>
        public ref bool M13 => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}.M13");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 1].
        /// </summary>
        public ref bool M21 => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}.M21");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 2].
        /// </summary>
        public ref bool M22 => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}.M22");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 3].
        /// </summary>
        public ref bool M23 => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}.M23");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 1].
        /// </summary>
        public ref bool M31 => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}.M31");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 2].
        /// </summary>
        public ref bool M32 => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}.M32");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 3].
        /// </summary>
        public ref bool M33 => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}.M33");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [4, 1].
        /// </summary>
        public ref bool M41 => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}.M41");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [4, 2].
        /// </summary>
        public ref bool M42 => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}.M42");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [4, 3].
        /// </summary>
        public ref bool M43 => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}.M43");

        /// <summary>
        /// Creates a new <see cref="Bool4x3"/> value with the same value for all its components.
        /// </summary>
        /// <param name="x">The value to use for the components of the new <see cref="Bool4x3"/> instance.</param>
        public static implicit operator Bool4x3(bool x)
        {
            Bool4x3 matrix;

            matrix.m11 = x;
            matrix.m12 = x;
            matrix.m13 = x;
            matrix.m21 = x;
            matrix.m22 = x;
            matrix.m23 = x;
            matrix.m31 = x;
            matrix.m32 = x;
            matrix.m33 = x;
            matrix.m41 = x;
            matrix.m42 = x;
            matrix.m43 = x;

            return matrix;
        }

        /// <summary>
        /// Negates a <see cref="Bool4x3"/> value.
        /// </summary>
        /// <param name="matrix">The <see cref="Bool4x3"/> value to negate.</param>
        public static Bool4x3 operator -(Bool4x3 matrix) => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}.-");

        /// <summary>
        /// Sums two <see cref="Bool4x3"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool4x3"/> value to sum.</param>
        /// <param name="right">The second <see cref="Bool4x3"/> value to sum.</param>
        public static Bool4x3 operator +(Bool4x3 left, Bool4x3 right) => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}.+");

        /// <summary>
        /// Divides two <see cref="Bool4x3"/> values (elementwise division).
        /// </summary>
        /// <param name="left">The first <see cref="Bool4x3"/> value to divide.</param>
        /// <param name="right">The second <see cref="Bool4x3"/> value to divide.</param>
        public static Bool4x3 operator /(Bool4x3 left, Bool4x3 right) => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}./");

        /// <summary>
        /// Multiplies two <see cref="Bool4x3"/> values (elementwise product).
        /// </summary>
        /// <param name="left">The first <see cref="Bool4x3"/> value to multiply.</param>
        /// <param name="right">The second <see cref="Bool4x3"/> value to multiply.</param>
        public static Bool4x3 operator *(Bool4x3 left, Bool4x3 right) => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}.*");

        /// <summary>
        /// Subtracts two <see cref="Bool4x3"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool4x3"/> value to subtract.</param>
        /// <param name="right">The second <see cref="Bool4x3"/> value to subtract.</param>
        public static Bool4x3 operator -(Bool4x3 left, Bool4x3 right) => throw new InvalidExecutionContextException($"{typeof(Bool4x3)}.-");
    }

    /// <inheritdoc cref="Bool4x4"/>
    [StructLayout(LayoutKind.Explicit, Size = 64, Pack = 4)]
    public partial struct Bool4x4
    {
        [FieldOffset(0)]
        private bool m11;

        [FieldOffset(4)]
        private bool m12;

        [FieldOffset(8)]
        private bool m13;

        [FieldOffset(12)]
        private bool m14;

        [FieldOffset(16)]
        private bool m21;

        [FieldOffset(20)]
        private bool m22;

        [FieldOffset(24)]
        private bool m23;

        [FieldOffset(28)]
        private bool m24;

        [FieldOffset(32)]
        private bool m31;

        [FieldOffset(36)]
        private bool m32;

        [FieldOffset(40)]
        private bool m33;

        [FieldOffset(44)]
        private bool m34;

        [FieldOffset(48)]
        private bool m41;

        [FieldOffset(52)]
        private bool m42;

        [FieldOffset(56)]
        private bool m43;

        [FieldOffset(60)]
        private bool m44;

        /// <summary>
        /// Creates a new <see cref="Bool4x4"/> instance with the specified parameters.
        /// </summary>
        /// <param name="m11">The value to assign to the component at position [1, 1].</param>
        /// <param name="m12">The value to assign to the component at position [1, 2].</param>
        /// <param name="m13">The value to assign to the component at position [1, 3].</param>
        /// <param name="m14">The value to assign to the component at position [1, 4].</param>
        /// <param name="m21">The value to assign to the component at position [2, 1].</param>
        /// <param name="m22">The value to assign to the component at position [2, 2].</param>
        /// <param name="m23">The value to assign to the component at position [2, 3].</param>
        /// <param name="m24">The value to assign to the component at position [2, 4].</param>
        /// <param name="m31">The value to assign to the component at position [3, 1].</param>
        /// <param name="m32">The value to assign to the component at position [3, 2].</param>
        /// <param name="m33">The value to assign to the component at position [3, 3].</param>
        /// <param name="m34">The value to assign to the component at position [3, 4].</param>
        /// <param name="m41">The value to assign to the component at position [4, 1].</param>
        /// <param name="m42">The value to assign to the component at position [4, 2].</param>
        /// <param name="m43">The value to assign to the component at position [4, 3].</param>
        /// <param name="m44">The value to assign to the component at position [4, 4].</param>
        public Bool4x4(bool m11, bool m12, bool m13, bool m14, bool m21, bool m22, bool m23, bool m24, bool m31, bool m32, bool m33, bool m34, bool m41, bool m42, bool m43, bool m44)
        {
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m14 = m14;
            this.m21 = m21;
            this.m22 = m22;
            this.m23 = m23;
            this.m24 = m24;
            this.m31 = m31;
            this.m32 = m32;
            this.m33 = m33;
            this.m34 = m34;
            this.m41 = m41;
            this.m42 = m42;
            this.m43 = m43;
            this.m44 = m44;
        }

        /// <summary>
        /// Creates a new <see cref="Bool4x4"/> instance with the specified parameters.
        /// </summary>
        /// <param name="row1">The value to assign to the row at position [1].</param>
        /// <param name="row2">The value to assign to the row at position [2].</param>
        /// <param name="row3">The value to assign to the row at position [3].</param>
        /// <param name="row4">The value to assign to the row at position [4].</param>
        public Bool4x4(Bool4 row1, Bool4 row2, Bool4 row3, Bool4 row4)
        {
            this.m11 = row1.X;
            this.m12 = row1.Y;
            this.m13 = row1.Z;
            this.m14 = row1.W;
            this.m21 = row2.X;
            this.m22 = row2.Y;
            this.m23 = row2.Z;
            this.m24 = row2.W;
            this.m31 = row3.X;
            this.m32 = row3.Y;
            this.m33 = row3.Z;
            this.m34 = row3.W;
            this.m41 = row4.X;
            this.m42 = row4.Y;
            this.m43 = row4.Z;
            this.m44 = row4.W;
        }

        /// <summary>
        /// Gets a reference to a specific row in the current <see cref="Bool4x4"/> instance.
        /// </summary>
        /// <param name="row">The row to access.</param>
        public ref Bool4 this[int row] => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}[{typeof(int)}]");

        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool4x4"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        public ref Bool2 this[MatrixIndex xy0, MatrixIndex xy1] => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool4x4"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        public ref Bool3 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2] => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");
        
        /// <summary>
        /// Gets a swizzled reference to a specific sequence of items in the current <see cref="Bool4x4"/> instance.
        /// </summary>
        /// <param name="xy0">The identifier of the first item to index.</param>
        /// <param name="xy1">The identifier of the second item to index.</param>
        /// <param name="xy2">The identifier of the third item to index.</param>
        /// <param name="xy3">The identifier of the fourth item to index.</param>
        public ref Bool4 this[MatrixIndex xy0, MatrixIndex xy1, MatrixIndex xy2, MatrixIndex xy3] => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}[{typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}, {typeof(MatrixIndex)}]");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 1].
        /// </summary>
        public ref bool M11 => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.M11");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 2].
        /// </summary>
        public ref bool M12 => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.M12");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 3].
        /// </summary>
        public ref bool M13 => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.M13");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [1, 4].
        /// </summary>
        public ref bool M14 => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.M14");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 1].
        /// </summary>
        public ref bool M21 => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.M21");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 2].
        /// </summary>
        public ref bool M22 => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.M22");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 3].
        /// </summary>
        public ref bool M23 => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.M23");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [2, 4].
        /// </summary>
        public ref bool M24 => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.M24");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 1].
        /// </summary>
        public ref bool M31 => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.M31");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 2].
        /// </summary>
        public ref bool M32 => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.M32");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 3].
        /// </summary>
        public ref bool M33 => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.M33");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [3, 4].
        /// </summary>
        public ref bool M34 => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.M34");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [4, 1].
        /// </summary>
        public ref bool M41 => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.M41");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [4, 2].
        /// </summary>
        public ref bool M42 => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.M42");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [4, 3].
        /// </summary>
        public ref bool M43 => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.M43");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the component at position [4, 4].
        /// </summary>
        public ref bool M44 => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.M44");

        /// <summary>
        /// Creates a new <see cref="Bool4x4"/> value with the same value for all its components.
        /// </summary>
        /// <param name="x">The value to use for the components of the new <see cref="Bool4x4"/> instance.</param>
        public static implicit operator Bool4x4(bool x)
        {
            Bool4x4 matrix;

            matrix.m11 = x;
            matrix.m12 = x;
            matrix.m13 = x;
            matrix.m14 = x;
            matrix.m21 = x;
            matrix.m22 = x;
            matrix.m23 = x;
            matrix.m24 = x;
            matrix.m31 = x;
            matrix.m32 = x;
            matrix.m33 = x;
            matrix.m34 = x;
            matrix.m41 = x;
            matrix.m42 = x;
            matrix.m43 = x;
            matrix.m44 = x;

            return matrix;
        }

        /// <summary>
        /// Negates a <see cref="Bool4x4"/> value.
        /// </summary>
        /// <param name="matrix">The <see cref="Bool4x4"/> value to negate.</param>
        public static Bool4x4 operator -(Bool4x4 matrix) => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.-");

        /// <summary>
        /// Sums two <see cref="Bool4x4"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool4x4"/> value to sum.</param>
        /// <param name="right">The second <see cref="Bool4x4"/> value to sum.</param>
        public static Bool4x4 operator +(Bool4x4 left, Bool4x4 right) => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.+");

        /// <summary>
        /// Divides two <see cref="Bool4x4"/> values (elementwise division).
        /// </summary>
        /// <param name="left">The first <see cref="Bool4x4"/> value to divide.</param>
        /// <param name="right">The second <see cref="Bool4x4"/> value to divide.</param>
        public static Bool4x4 operator /(Bool4x4 left, Bool4x4 right) => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}./");

        /// <summary>
        /// Multiplies two <see cref="Bool4x4"/> values (elementwise product).
        /// </summary>
        /// <param name="left">The first <see cref="Bool4x4"/> value to multiply.</param>
        /// <param name="right">The second <see cref="Bool4x4"/> value to multiply.</param>
        public static Bool4x4 operator *(Bool4x4 left, Bool4x4 right) => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.*");

        /// <summary>
        /// Subtracts two <see cref="Bool4x4"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Bool4x4"/> value to subtract.</param>
        /// <param name="right">The second <see cref="Bool4x4"/> value to subtract.</param>
        public static Bool4x4 operator -(Bool4x4 left, Bool4x4 right) => throw new InvalidExecutionContextException($"{typeof(Bool4x4)}.-");
    }
}