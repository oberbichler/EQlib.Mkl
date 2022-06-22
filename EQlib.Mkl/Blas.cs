namespace EQlib.Mkl;

using System.Runtime.CompilerServices;
using System.Security;

[SuppressUnmanagedCodeSecurity]
public static class Blas
{
	// --- BLAS Level 1


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe double cblas_dasum(int n, double* x, int incx);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Dasum(int n, ReadOnlySpan<double> x, int incx)
	{
		unsafe
		{
			fixed (double* xPtr = x)
			{
				return cblas_dasum(n, xPtr, incx);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void cblas_daxpy(int n, double a, double* x, int incx, double* y, int incy);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Daxpy(int n, double a, ReadOnlySpan<double> x, int incx, Span<double> y, int incy)
	{
		unsafe
		{
			fixed (double* xPtr = x)
			fixed (double* yPtr = y)
			{
				cblas_daxpy(n, a, xPtr, incx, yPtr, incy);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void cblas_dcopy(int n, double* x, int incx, double* y, int incy);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Dcopy(int n, ReadOnlySpan<double> x, int incx, Span<double> y, int incy)
	{
		unsafe
		{
			fixed (double* xPtr = x)
			fixed (double* yPtr = y)
			{
				cblas_dcopy(n, xPtr, incx, yPtr, incy);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe double cblas_ddot(int n, double* x, int incx, double* y, int incy);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Ddot(int n, ReadOnlySpan<double> x, int incx, ReadOnlySpan<double> y, int incy)
	{
		unsafe
		{
			fixed (double* xPtr = x)
			fixed (double* yPtr = y)
			{
				return cblas_ddot(n, xPtr, incx, yPtr, incy);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe double cblas_dnrm2(int n, double* x, int incx);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Dnrm2(int n, ReadOnlySpan<double> x, int incx)
	{
		unsafe
		{
			fixed (double* xPtr = x)
			{
				return cblas_dnrm2(n, xPtr, incx);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void cblas_drot(int n, double* x, int incx, double* y, int incy, double c, double s);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Drot(int n, ReadOnlySpan<double> x, int incx, ReadOnlySpan<double> y, int incy, double c, double s)
	{
		unsafe
		{
			fixed (double* xPtr = x)
			fixed (double* yPtr = y)
			{
				cblas_drot(n, xPtr, incx, yPtr, incy, c, s);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void cblas_drotg(double* a, double* b, double* c, double* s);


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void cblas_drotm(int n, double* x, int incx, double* y, int incy, double* param);


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void cblas_drotmg(double* d1, double* d2, double* x1, double y1, double* param);


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void cblas_dscal(int n, double a, double* x, int incx);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Dscal(int n, double a, Span<double> x, int incx)
	{
		unsafe
		{
			fixed (double* xPtr = x)
			{
				cblas_dscal(n, a, xPtr, incx);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void cblas_dswap(int n, double* x, int incx, double* y, int incy);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Dswap(int n, ReadOnlySpan<double> x, int incx, ReadOnlySpan<double> y, int incy)
	{
		unsafe
		{
			fixed (double* xPtr = x)
			fixed (double* yPtr = y)
			{
				cblas_dswap(n, xPtr, incx, yPtr, incy);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe int cblas_idamax(int n, double* x, int incx);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Idamax(int n, ReadOnlySpan<double> x, int incx)
	{
		unsafe
		{
			fixed (double* xPtr = x)
			{
				cblas_idamax(n, xPtr, incx);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe int cblas_idamin(int n, double* x, int incx);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Idamin(int n, ReadOnlySpan<double> x, int incx)
	{
		unsafe
		{
			fixed (double* xPtr = x)
			{
				cblas_idamin(n, xPtr, incx);
			}
		}
	}


	// --- BLAS Level 2


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void cblas_dgemv([In] ref char transa, [In] ref int m, double* a, int* ia, int* ja, double* x, double* y);


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void cblas_dsymv([In] ref char uplo, [In] ref int m, double* a, int* ia, int* ja, double* x, double* y);


	// --- BLAS-like Extensions


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void cblas_daxpby(int n, double a, double* x, int incx, double b, double* y, int incy);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Daxpby(int n, double a, ReadOnlySpan<double> x, int incx, double b, ReadOnlySpan<double> y, int incy)
	{
		unsafe
		{
			fixed (double* xPtr = x)
			fixed (double* yPtr = y)
			{
				cblas_daxpby(n, a, xPtr, incx, b, yPtr, incy);
			}
		}
	}
}
