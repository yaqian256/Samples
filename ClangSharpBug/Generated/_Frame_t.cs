using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Net.Interop;

internal partial struct _Frame_t
{
    [NativeTypeName("unsigned int")]
    public uint Length;

    [NativeTypeName("unsigned char[1]")]
    public _Data_e__FixedBuffer Data;

    public partial struct _Data_e__FixedBuffer
    {
        public byte e0;

        [UnscopedRef]
        public ref byte this[int index]
        {
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [UnscopedRef]
        public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
