namespace EQlib.Mkl;

using System.Security;

[SuppressUnmanagedCodeSecurity]
public static class SparseSolver
{
	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	private static extern unsafe void pardiso(IntPtr* pt, ref int maxfct, ref int mnum, ref int mtype, ref int phase, ref int n, double* a, int* ia, int* ja, int* perm, ref int nrhs, int* iparm, ref int msglvl, double* b, double* x, out int error);

	public static void Pardiso(ReadOnlySpan<IntPtr> pt, int maxfct, int mnum, int mtype, int phase, int n, ReadOnlySpan<double> a, ReadOnlySpan<int> ia, ReadOnlySpan<int> ja, Span<int> perm, int nrhs, ReadOnlySpan<int> iparm, int msglvl, ReadOnlySpan<double> b, Span<double> x, out int error)
	{
		unsafe
		{
			fixed (IntPtr* ptPtr = pt)
			fixed (double* aPtr = a)
			fixed (int* iaPtr = ia)
			fixed (int* jaPtr = ja)
			fixed (int* permPtr = perm)
			fixed (int* iparmPtr = iparm)
			fixed (double* bPtr = b)
			fixed (double* xPtr = x)
			{
				pardiso(ptPtr, ref maxfct, ref mnum, ref mtype, ref phase, ref n, aPtr, iaPtr, jaPtr, permPtr, ref nrhs, iparmPtr, ref msglvl, bPtr, xPtr, out error);
			}
		}
	}
}
