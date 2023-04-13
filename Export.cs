using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Experimental_Calculator
{
    public static class Export
    {
        [UnmanagedCallersOnly(EntryPoint = "Init", CallConvs = new[] { typeof(CallConvCdecl) })]
        public static IntPtr Init(double data)
        {
            return GCHandle.ToIntPtr(
                GCHandle.Alloc(
                    new Calculator().setData(data)
                    )
                );
        }

        [UnmanagedCallersOnly(EntryPoint = "Result", CallConvs = new[] { typeof(CallConvCdecl) })]
        [return: MarshalAs(UnmanagedType.R8)]
        public static double Result(IntPtr calculator)
        {
            return As(calculator)?.getData() ?? 0.0;
        }

        [UnmanagedCallersOnly(EntryPoint = "Add", CallConvs = new[] { typeof(CallConvCdecl) })]
        public static int Add(IntPtr calculator, double value)
        {
            As(calculator)?.Add(value);

            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "Subtract", CallConvs = new[] { typeof(CallConvCdecl) })]
        public static int Subtract(IntPtr calculator, double value)
        {
            As(calculator)?.Subtract(value);

            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "Multiply", CallConvs = new[] { typeof(CallConvCdecl) })]
        public static int Multiply(IntPtr calculator, double value)
        {
            As(calculator)?.Multiply(value);

            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "Divide", CallConvs = new[] { typeof(CallConvCdecl) })]
        public static int Divide(IntPtr calculator, double value)
        {
            As(calculator)?.Divide(value);

            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "Power", CallConvs = new[] { typeof(CallConvCdecl) })]
        public static int Power(IntPtr calculator, int value)
        {
            As(calculator)?.Power(value);

            return 0;
        }

        private static Calculator? As(IntPtr ptr)
        {
            return (Calculator?)GCHandle.FromIntPtr(ptr).Target;
        }
    }
}
