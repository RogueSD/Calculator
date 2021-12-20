using System.Runtime.InteropServices;

namespace Calculator.Evaluations
{
    public static class Evaluator
    {
        [DllImport("QtLib.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "?Multiply@QtMath@@QEAANNN@Z")]
        public static extern double Multiply(double arg1, double arg2);

        public static double Add(double param1, double param2)
        {
            return param1 + param2;
        }
    }
}
