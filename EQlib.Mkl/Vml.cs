namespace EQlib.Mkl;

using System.Runtime.CompilerServices;
using System.Security;

[SuppressUnmanagedCodeSecurity]
public static class Vml
{
	public enum VmlMode : long
	{
		LA = 0x00000001,
		HA = 0x00000002,
		EP = 0x00000003,
		ERRMODE_IGNORE = 0x00000100,
		ERRMODE_ERRNO = 0x00000200,
		ERRMODE_STDERR = 0x00000400,
		ERRMODE_EXCEPT = 0x00000800,
		ERRMODE_CALLBACK = 0x00001000,
		ERRMODE_NOERR = 0x00002000,
		ERRMODE_DEFAULT = ERRMODE_ERRNO | ERRMODE_CALLBACK | ERRMODE_EXCEPT,
		FTZDAZ_ON = 0x00280000,
		FTZDAZ_OFF = 0x00140000,
	}

	public enum VmlStatus
	{
		OK = 0,
		BADSIZE = -1,
		BADMEM = -2,
		ERRDOM = 1,
		SING = 2,
		OVERFLOW = 3,
		UNDERFLOW = 4,
		ACCURACYWARNING = 1000,

	}

	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe VmlStatus vmlClearErrStatus();

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static VmlStatus ClearErrStatus()
	{
		return vmlClearErrStatus();
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe VmlStatus vmlGetErrStatus();

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static VmlStatus GetErrStatus()
	{
		return vmlGetErrStatus();
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe VmlMode vmlGetMode();

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static VmlMode GetMode()
	{
		return vmlGetMode();
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe VmlStatus vmlSetErrStatus(VmlStatus status);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static VmlStatus SetErrStatus(VmlStatus status)
	{
		return SetErrStatus(status);
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe VmlMode vmlSetMode(VmlMode newmode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static VmlMode SetMode(VmlMode newmode)
	{
		return vmlSetMode(newmode);
	}

	//

	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAbs(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Abs(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAbs(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAbsI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AbsI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAbsI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAcos(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Acos(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAcos(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAcosh(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Acosh(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAcosh(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAcoshI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AcoshI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAcoshI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAcosI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AcosI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAcosI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAcospi(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Acospi(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAcospi(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAcospiI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AcospiI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAcospiI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAdd(int n, double* a, double* b, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdAdd(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAddI(int n, double* a, int inca, double* b, int incb, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AddI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdAddI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAsin(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Asin(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAsin(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAsinh(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Asinh(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAsinh(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAsinhI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AsinhI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAsinhI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAsinI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AsinI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAsinI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAsinpi(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Asinpi(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAsinpi(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAsinpiI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AsinpiI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAsinpiI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAtan(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Atan(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAtan(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAtan2(int n, double* a, double* b, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Atan2(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdAtan2(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAtan2I(int n, double* a, int inca, double* b, int incb, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Atan2I(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdAtan2I(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAtan2pi(int n, double* a, double* b, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Atan2pi(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdAtan2pi(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAtan2piI(int n, double* a, int inca, double* b, int incb, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Atan2piI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdAtan2piI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAtanh(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Atanh(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAtanh(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAtanhI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AtanhI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAtanhI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAtanI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AtanI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAtanI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAtanpi(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Atanpi(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAtanpi(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdAtanpiI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AtanpiI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdAtanpiI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdCbrt(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Cbrt(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdCbrt(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdCbrtI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void CbrtI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdCbrtI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdCdfNorm(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void CdfNorm(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdCdfNorm(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdCdfNormI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void CdfNormI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdCdfNormI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdCdfNormInv(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void CdfNormInv(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdCdfNormInv(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdCdfNormInvI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void CdfNormInvI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdCdfNormInvI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdCeil(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Ceil(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdCeil(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdCeilI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void CeilI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdCeilI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdCopySign(int n, double* a, double* b, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void CopySign(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdCopySign(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdCopySignI(int n, double* a, int inca, double* b, int incb, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void CopySignI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdCopySignI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdCos(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Cos(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdCos(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdCosd(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Cosd(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdCosd(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdCosdI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void CosdI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdCosdI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdCosh(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Cosh(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdCosh(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdCoshI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void CoshI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdCoshI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdCosI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void CosI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdCosI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdCospi(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Cospi(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdCospi(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdCospiI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void CospiI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdCospiI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdDiv(int n, double* a, double* b, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Div(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdDiv(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdDivI(int n, double* a, int inca, double* b, int incb, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void DivI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdDivI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdErf(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Erf(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdErf(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdErfc(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Erfc(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdErfc(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdErfcI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ErfcI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdErfcI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdErfcInv(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ErfcInv(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdErfcInv(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdErfcInvI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ErfcInvI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdErfcInvI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdErfI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ErfI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdErfI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdErfInv(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ErfInv(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdErfInv(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdErfInvI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ErfInvI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdErfInvI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdExp(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Exp(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdExp(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdExp10(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Exp10(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdExp10(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdExp10I(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Exp10I(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdExp10I(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdExp2(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Exp2(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdExp2(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdExp2I(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Exp2I(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdExp2I(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdExpI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ExpI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdExpI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdExpInt1(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ExpInt1(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdExpInt1(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdExpInt1I(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ExpInt1I(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdExpInt1I(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdExpm1(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Expm1(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdExpm1(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdExpm1I(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Expm1I(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdExpm1I(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdFdim(int n, double* a, double* b, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Fdim(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdFdim(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdFdimI(int n, double* a, int inca, double* b, int incb, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void FdimI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdFdimI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdFloor(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Floor(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdFloor(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdFloorI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void FloorI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdFloorI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdFmax(int n, double* a, double* b, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Fmax(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdFmax(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdFmaxI(int n, double* a, int inca, double* b, int incb, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void FmaxI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdFmaxI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdFmin(int n, double* a, double* b, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Fmin(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdFmin(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdFminI(int n, double* a, int inca, double* b, int incb, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void FminI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdFminI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdFmod(int n, double* a, double* b, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Fmod(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdFmod(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdFmodI(int n, double* a, int inca, double* b, int incb, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void FmodI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdFmodI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdFrac(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Frac(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdFrac(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdFracI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void FracI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdFracI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdHypot(int n, double* a, double* b, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Hypot(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdHypot(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdHypotI(int n, double* a, int inca, double* b, int incb, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void HypotI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdHypotI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdInv(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Inv(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdInv(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdInvCbrt(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void InvCbrt(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdInvCbrt(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdInvCbrtI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void InvCbrtI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdInvCbrtI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdInvI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void InvI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdInvI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdInvSqrt(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void InvSqrt(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdInvSqrt(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdInvSqrtI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void InvSqrtI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdInvSqrtI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdLGamma(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void LGamma(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdLGamma(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdLGammaI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void LGammaI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdLGammaI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdLinearFrac(int n, double* a, double* b, double scalea, double shifta, double scaleb, double shiftb, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void LinearFrac(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, double scalea, double shifta, double scaleb, double shiftb, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdLinearFrac(n, aPtr, bPtr, scalea, shifta, scaleb, shiftb, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdLinearFracI(int n, double* a, int inca, double* b, int incb, double scalea, double shifta, double scaleb, double shiftb, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void LinearFracI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, double scalea, double shifta, double scaleb, double shiftb, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdLinearFracI(n, aPtr, inca, bPtr, incb, scalea, shifta, scaleb, shiftb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdLn(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Ln(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdLn(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdLnI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void LnI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdLnI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdLog10(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Log10(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdLog10(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdLog10I(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Log10I(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdLog10I(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdLog1p(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Log1p(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdLog1p(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdLog1pI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Log1pI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdLog1pI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdLog2(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Log2(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdLog2(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdLog2I(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Log2I(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdLog2I(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdLogb(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Logb(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdLogb(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdLogbI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void LogbI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdLogbI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdMaxMag(int n, double* a, double* b, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void MaxMag(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdMaxMag(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdMaxMagI(int n, double* a, int inca, double* b, int incb, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void MaxMagI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdMaxMagI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdMinMag(int n, double* a, double* b, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void MinMag(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdMinMag(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdMinMagI(int n, double* a, int inca, double* b, int incb, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void MinMagI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdMinMagI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdModf(int n, double* a, double* r1, double* r2);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Modf(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> r1, ReadOnlySpan<double> r2)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* r1Ptr = r1)
			fixed (double* r2Ptr = r2)
			{
				vdModf(n, aPtr, r1Ptr, r2Ptr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdModfI(int n, double* a, int inca, double* r1, int incr1, double* r2, int incr2);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ModfI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> r1, int incr1, ReadOnlySpan<double> r2, int incr2)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* r1Ptr = r1)
			fixed (double* r2Ptr = r2)
			{
				vdModfI(n, aPtr, inca, r1Ptr, incr1, r2Ptr, incr2);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdMul(int n, double* a, double* b, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Mul(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdMul(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdMulI(int n, double* a, int inca, double* b, int incb, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void MulI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdMulI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdNearbyInt(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void NearbyInt(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdNearbyInt(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdNearbyIntI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void NearbyIntI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdNearbyIntI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdNextAfter(int n, double* a, double* b, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void NextAfter(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdNextAfter(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdNextAfterI(int n, double* a, int inca, double* b, int incb, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void NextAfterI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdNextAfterI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdPackI(int n, double* a, int incra, double* y);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void PackI(int n, ReadOnlySpan<double> a, int incra, ReadOnlySpan<double> y)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* yPtr = y)
			{
				vdPackI(n, aPtr, incra, yPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdPackM(int n, double* a, int[] ma, double* y);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void PackM(int n, ReadOnlySpan<double> a, int[] ma, ReadOnlySpan<double> y)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* yPtr = y)
			{
				vdPackM(n, aPtr, ma, yPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdPackV(int n, double* a, int[] ia, double* y);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void PackV(int n, ReadOnlySpan<double> a, int[] ia, ReadOnlySpan<double> y)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* yPtr = y)
			{
				vdPackV(n, aPtr, ia, yPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdPow(int n, double* a, double* b, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Pow(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdPow(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdPow2o3(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Pow2o3(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdPow2o3(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdPow2o3I(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Pow2o3I(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdPow2o3I(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdPow3o2(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Pow3o2(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdPow3o2(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdPow3o2I(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Pow3o2I(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdPow3o2I(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdPowI(int n, double* a, int inca, double* b, int incb, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void PowI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdPowI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdPowr(int n, double* a, double* b, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Powr(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdPowr(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdPowrI(int n, double* a, int inca, double* b, int incb, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void PowrI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdPowrI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdPowx(int n, double* a, double b, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Powx(int n, ReadOnlySpan<double> a, double b, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdPowx(n, aPtr, b, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdPowxI(int n, double* a, int inca, double b, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void PowxI(int n, ReadOnlySpan<double> a, int inca, double b, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdPowxI(n, aPtr, inca, b, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdRemainder(int n, double* a, double* b, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Remainder(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdRemainder(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdRemainderI(int n, double* a, int inca, double* b, int incb, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void RemainderI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdRemainderI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdRint(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Rint(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdRint(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdRintI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void RintI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdRintI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdRound(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Round(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdRound(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdRoundI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void RoundI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdRoundI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdSin(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Sin(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdSin(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdSinCos(int n, double* a, double* r1, double* r2);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void SinCos(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> r1, ReadOnlySpan<double> r2)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* r1Ptr = r1)
			fixed (double* r2Ptr = r2)
			{
				vdSinCos(n, aPtr, r1Ptr, r2Ptr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdSinCosI(int n, double* a, int inca, double* r1, int incr1, double* r2, int incr2);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void SinCosI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> r1, int incr1, ReadOnlySpan<double> r2, int incr2)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* r1Ptr = r1)
			fixed (double* r2Ptr = r2)
			{
				vdSinCosI(n, aPtr, inca, r1Ptr, incr1, r2Ptr, incr2);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdSind(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Sind(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdSind(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdSindI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void SindI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdSindI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdSinh(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Sinh(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdSinh(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdSinhI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void SinhI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdSinhI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdSinI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void SinI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdSinI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdSinpi(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Sinpi(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdSinpi(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdSinpiI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void SinpiI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdSinpiI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdSqr(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Sqr(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdSqr(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdSqrI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void SqrI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdSqrI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdSqrt(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Sqrt(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdSqrt(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdSqrtI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void SqrtI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdSqrtI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdSub(int n, double* a, double* b, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Sub(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdSub(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdSubI(int n, double* a, int inca, double* b, int incb, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void SubI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vdSubI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdTan(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Tan(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdTan(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdTand(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Tand(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdTand(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdTandI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void TandI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdTandI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdTanh(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Tanh(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdTanh(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdTanhI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void TanhI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdTanhI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdTanI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void TanI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdTanI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdTanpi(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Tanpi(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdTanpi(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdTanpiI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void TanpiI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdTanpiI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdTGamma(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void TGamma(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdTGamma(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdTGammaI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void TGammaI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdTGammaI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdTrunc(int n, double* a, double* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Trunc(int n, ReadOnlySpan<double> a, Span<double> r)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdTrunc(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdTruncI(int n, double* a, int inca, double* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void TruncI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vdTruncI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdUnpackI(int n, double* a, double* y, int incry);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void UnpackI(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> y, int incry)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* yPtr = y)
			{
				vdUnpackI(n, aPtr, yPtr, incry);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdUnpackM(int n, double* a, double* y, int[] my);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void UnpackM(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> y, int[] my)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* yPtr = y)
			{
				vdUnpackM(n, aPtr, yPtr, my);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vdUnpackV(int n, double* a, double* y, int[] iy);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void UnpackV(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> y, int[] iy)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* yPtr = y)
			{
				vdUnpackV(n, aPtr, yPtr, iy);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAbs(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAbs(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAbs(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAbsI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAbsI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAbsI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAcos(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAcos(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAcos(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAcosh(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAcosh(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAcosh(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAcoshI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAcoshI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAcoshI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAcosI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAcosI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAcosI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAcospi(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAcospi(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAcospi(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAcospiI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAcospiI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAcospiI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAdd(int n, double* a, double* b, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAdd(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdAdd(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAddI(int n, double* a, int inca, double* b, int incb, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAddI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdAddI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAsin(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAsin(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAsin(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAsinh(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAsinh(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAsinh(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAsinhI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAsinhI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAsinhI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAsinI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAsinI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAsinI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAsinpi(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAsinpi(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAsinpi(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAsinpiI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAsinpiI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAsinpiI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAtan(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAtan(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAtan(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAtan2(int n, double* a, double* b, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAtan2(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdAtan2(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAtan2I(int n, double* a, int inca, double* b, int incb, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAtan2I(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdAtan2I(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAtan2pi(int n, double* a, double* b, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAtan2pi(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdAtan2pi(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAtan2piI(int n, double* a, int inca, double* b, int incb, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAtan2piI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdAtan2piI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAtanh(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAtanh(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAtanh(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAtanhI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAtanhI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAtanhI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAtanI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAtanI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAtanI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAtanpi(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAtanpi(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAtanpi(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdAtanpiI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdAtanpiI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdAtanpiI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdCbrt(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdCbrt(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdCbrt(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdCbrtI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdCbrtI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdCbrtI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdCdfNorm(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdCdfNorm(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdCdfNorm(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdCdfNormI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdCdfNormI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdCdfNormI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdCdfNormInv(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdCdfNormInv(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdCdfNormInv(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdCdfNormInvI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdCdfNormInvI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdCdfNormInvI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdCeil(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdCeil(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdCeil(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdCeilI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdCeilI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdCeilI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdCopySign(int n, double* a, double* b, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdCopySign(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdCopySign(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdCopySignI(int n, double* a, int inca, double* b, int incb, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdCopySignI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdCopySignI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdCos(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdCos(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdCos(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdCosd(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdCosd(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdCosd(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdCosdI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdCosdI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdCosdI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdCosh(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdCosh(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdCosh(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdCoshI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdCoshI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdCoshI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdCosI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdCosI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdCosI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdCospi(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdCospi(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdCospi(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdCospiI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdCospiI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdCospiI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdDiv(int n, double* a, double* b, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdDiv(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdDiv(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdDivI(int n, double* a, int inca, double* b, int incb, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdDivI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdDivI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdErf(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdErf(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdErf(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdErfc(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdErfc(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdErfc(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdErfcI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdErfcI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdErfcI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdErfcInv(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdErfcInv(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdErfcInv(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdErfcInvI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdErfcInvI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdErfcInvI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdErfI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdErfI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdErfI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdErfInv(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdErfInv(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdErfInv(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdErfInvI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdErfInvI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdErfInvI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdExp(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdExp(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdExp(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdExp10(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdExp10(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdExp10(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdExp10I(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdExp10I(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdExp10I(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdExp2(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdExp2(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdExp2(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdExp2I(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdExp2I(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdExp2I(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdExpI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdExpI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdExpI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdExpInt1(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdExpInt1(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdExpInt1(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdExpInt1I(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdExpInt1I(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdExpInt1I(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdExpm1(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdExpm1(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdExpm1(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdExpm1I(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdExpm1I(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdExpm1I(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdFdim(int n, double* a, double* b, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdFdim(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdFdim(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdFdimI(int n, double* a, int inca, double* b, int incb, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdFdimI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdFdimI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdFloor(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdFloor(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdFloor(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdFloorI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdFloorI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdFloorI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdFmax(int n, double* a, double* b, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdFmax(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdFmax(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdFmaxI(int n, double* a, int inca, double* b, int incb, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdFmaxI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdFmaxI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdFmin(int n, double* a, double* b, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdFmin(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdFmin(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdFminI(int n, double* a, int inca, double* b, int incb, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdFminI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdFminI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdFmod(int n, double* a, double* b, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdFmod(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdFmod(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdFmodI(int n, double* a, int inca, double* b, int incb, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdFmodI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdFmodI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdFrac(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdFrac(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdFrac(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdFracI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdFracI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdFracI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdHypot(int n, double* a, double* b, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdHypot(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdHypot(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdHypotI(int n, double* a, int inca, double* b, int incb, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdHypotI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdHypotI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdInv(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdInv(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdInv(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdInvCbrt(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdInvCbrt(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdInvCbrt(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdInvCbrtI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdInvCbrtI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdInvCbrtI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdInvI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdInvI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdInvI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdInvSqrt(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdInvSqrt(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdInvSqrt(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdInvSqrtI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdInvSqrtI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdInvSqrtI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdLGamma(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdLGamma(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdLGamma(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdLGammaI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdLGammaI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdLGammaI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdLinearFrac(int n, double* a, double* b, double scalea, double shifta, double scaleb, double shiftb, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdLinearFrac(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, double scalea, double shifta, double scaleb, double shiftb, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdLinearFrac(n, aPtr, bPtr, scalea, shifta, scaleb, shiftb, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdLinearFracI(int n, double* a, int inca, double* b, int incb, double scalea, double shifta, double scaleb, double shiftb, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdLinearFracI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, double scalea, double shifta, double scaleb, double shiftb, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdLinearFracI(n, aPtr, inca, bPtr, incb, scalea, shifta, scaleb, shiftb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdLn(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdLn(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdLn(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdLnI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdLnI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdLnI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdLog10(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdLog10(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdLog10(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdLog10I(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdLog10I(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdLog10I(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdLog1p(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdLog1p(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdLog1p(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdLog1pI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdLog1pI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdLog1pI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdLog2(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdLog2(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdLog2(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdLog2I(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdLog2I(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdLog2I(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdLogb(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdLogb(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdLogb(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdLogbI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdLogbI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdLogbI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdMaxMag(int n, double* a, double* b, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdMaxMag(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdMaxMag(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdMaxMagI(int n, double* a, int inca, double* b, int incb, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdMaxMagI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdMaxMagI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdMinMag(int n, double* a, double* b, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdMinMag(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdMinMag(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdMinMagI(int n, double* a, int inca, double* b, int incb, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdMinMagI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdMinMagI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdModf(int n, double* a, double* r1, double* r2, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdModf(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> r1, ReadOnlySpan<double> r2, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* r1Ptr = r1)
			fixed (double* r2Ptr = r2)
			{
				vmdModf(n, aPtr, r1Ptr, r2Ptr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdModfI(int n, double* a, int inca, double* r1, int incr1, double* r2, int incr2, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdModfI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> r1, int incr1, ReadOnlySpan<double> r2, int incr2, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* r1Ptr = r1)
			fixed (double* r2Ptr = r2)
			{
				vmdModfI(n, aPtr, inca, r1Ptr, incr1, r2Ptr, incr2, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdMul(int n, double* a, double* b, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdMul(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdMul(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdMulI(int n, double* a, int inca, double* b, int incb, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdMulI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdMulI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdNearbyInt(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdNearbyInt(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdNearbyInt(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdNearbyIntI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdNearbyIntI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdNearbyIntI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdNextAfter(int n, double* a, double* b, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdNextAfter(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdNextAfter(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdNextAfterI(int n, double* a, int inca, double* b, int incb, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdNextAfterI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdNextAfterI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdPow(int n, double* a, double* b, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdPow(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdPow(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdPow2o3(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdPow2o3(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdPow2o3(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdPow2o3I(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdPow2o3I(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdPow2o3I(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdPow3o2(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdPow3o2(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdPow3o2(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdPow3o2I(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdPow3o2I(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdPow3o2I(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdPowI(int n, double* a, int inca, double* b, int incb, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdPowI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdPowI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdPowr(int n, double* a, double* b, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdPowr(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdPowr(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdPowrI(int n, double* a, int inca, double* b, int incb, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdPowrI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdPowrI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdPowx(int n, double* a, double b, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdPowx(int n, ReadOnlySpan<double> a, double b, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdPowx(n, aPtr, b, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdPowxI(int n, double* a, int inca, double b, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdPowxI(int n, ReadOnlySpan<double> a, int inca, double b, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdPowxI(n, aPtr, inca, b, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdRemainder(int n, double* a, double* b, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdRemainder(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdRemainder(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdRemainderI(int n, double* a, int inca, double* b, int incb, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdRemainderI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdRemainderI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdRint(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdRint(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdRint(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdRintI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdRintI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdRintI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdRound(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdRound(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdRound(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdRoundI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdRoundI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdRoundI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdSin(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdSin(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdSin(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdSinCos(int n, double* a, double* r1, double* r2, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdSinCos(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> r1, ReadOnlySpan<double> r2, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* r1Ptr = r1)
			fixed (double* r2Ptr = r2)
			{
				vmdSinCos(n, aPtr, r1Ptr, r2Ptr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdSinCosI(int n, double* a, int inca, double* r1, int incr1, double* r2, int incr2, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdSinCosI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> r1, int incr1, ReadOnlySpan<double> r2, int incr2, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* r1Ptr = r1)
			fixed (double* r2Ptr = r2)
			{
				vmdSinCosI(n, aPtr, inca, r1Ptr, incr1, r2Ptr, incr2, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdSind(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdSind(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdSind(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdSindI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdSindI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdSindI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdSinh(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdSinh(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdSinh(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdSinhI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdSinhI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdSinhI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdSinI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdSinI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdSinI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdSinpi(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdSinpi(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdSinpi(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdSinpiI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdSinpiI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdSinpiI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdSqr(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdSqr(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdSqr(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdSqrI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdSqrI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdSqrI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdSqrt(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdSqrt(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdSqrt(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdSqrtI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdSqrtI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdSqrtI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdSub(int n, double* a, double* b, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdSub(int n, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdSub(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdSubI(int n, double* a, int inca, double* b, int incb, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdSubI(int n, ReadOnlySpan<double> a, int inca, ReadOnlySpan<double> b, int incb, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				vmdSubI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdTan(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdTan(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdTan(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdTand(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdTand(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdTand(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdTandI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdTandI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdTandI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdTanh(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdTanh(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdTanh(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdTanhI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdTanhI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdTanhI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdTanI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdTanI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdTanI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdTanpi(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdTanpi(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdTanpi(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdTanpiI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdTanpiI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdTanpiI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdTGamma(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdTGamma(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdTGamma(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdTGammaI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdTGammaI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdTGammaI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdTrunc(int n, double* a, double* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdTrunc(int n, ReadOnlySpan<double> a, Span<double> r, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdTrunc(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmdTruncI(int n, double* a, int inca, double* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmdTruncI(int n, ReadOnlySpan<double> a, int inca, Span<double> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				vmdTruncI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAbs(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAbs(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAbs(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAbsI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAbsI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAbsI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAcos(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAcos(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAcos(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAcosh(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAcosh(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAcosh(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAcoshI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAcoshI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAcoshI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAcosI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAcosI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAcosI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAcospi(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAcospi(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAcospi(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAcospiI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAcospiI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAcospiI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAdd(int n, float* a, float* b, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAdd(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsAdd(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAddI(int n, float* a, int inca, float* b, int incb, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAddI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsAddI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAsin(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAsin(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAsin(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAsinh(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAsinh(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAsinh(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAsinhI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAsinhI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAsinhI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAsinI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAsinI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAsinI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAsinpi(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAsinpi(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAsinpi(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAsinpiI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAsinpiI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAsinpiI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAtan(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAtan(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAtan(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAtan2(int n, float* a, float* b, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAtan2(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsAtan2(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAtan2I(int n, float* a, int inca, float* b, int incb, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAtan2I(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsAtan2I(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAtan2pi(int n, float* a, float* b, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAtan2pi(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsAtan2pi(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAtan2piI(int n, float* a, int inca, float* b, int incb, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAtan2piI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsAtan2piI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAtanh(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAtanh(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAtanh(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAtanhI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAtanhI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAtanhI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAtanI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAtanI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAtanI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAtanpi(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAtanpi(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAtanpi(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsAtanpiI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsAtanpiI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsAtanpiI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsCbrt(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsCbrt(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsCbrt(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsCbrtI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsCbrtI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsCbrtI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsCdfNorm(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsCdfNorm(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsCdfNorm(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsCdfNormI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsCdfNormI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsCdfNormI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsCdfNormInv(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsCdfNormInv(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsCdfNormInv(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsCdfNormInvI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsCdfNormInvI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsCdfNormInvI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsCeil(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsCeil(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsCeil(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsCeilI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsCeilI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsCeilI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsCopySign(int n, float* a, float* b, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsCopySign(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsCopySign(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsCopySignI(int n, float* a, int inca, float* b, int incb, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsCopySignI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsCopySignI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsCos(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsCos(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsCos(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsCosd(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsCosd(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsCosd(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsCosdI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsCosdI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsCosdI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsCosh(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsCosh(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsCosh(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsCoshI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsCoshI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsCoshI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsCosI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsCosI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsCosI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsCospi(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsCospi(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsCospi(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsCospiI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsCospiI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsCospiI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsDiv(int n, float* a, float* b, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsDiv(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsDiv(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsDivI(int n, float* a, int inca, float* b, int incb, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsDivI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsDivI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsErf(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsErf(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsErf(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsErfc(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsErfc(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsErfc(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsErfcI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsErfcI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsErfcI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsErfcInv(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsErfcInv(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsErfcInv(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsErfcInvI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsErfcInvI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsErfcInvI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsErfI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsErfI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsErfI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsErfInv(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsErfInv(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsErfInv(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsErfInvI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsErfInvI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsErfInvI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsExp(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsExp(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsExp(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsExp10(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsExp10(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsExp10(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsExp10I(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsExp10I(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsExp10I(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsExp2(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsExp2(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsExp2(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsExp2I(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsExp2I(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsExp2I(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsExpI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsExpI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsExpI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsExpInt1(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsExpInt1(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsExpInt1(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsExpInt1I(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsExpInt1I(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsExpInt1I(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsExpm1(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsExpm1(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsExpm1(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsExpm1I(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsExpm1I(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsExpm1I(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsFdim(int n, float* a, float* b, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsFdim(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsFdim(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsFdimI(int n, float* a, int inca, float* b, int incb, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsFdimI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsFdimI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsFloor(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsFloor(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsFloor(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsFloorI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsFloorI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsFloorI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsFmax(int n, float* a, float* b, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsFmax(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsFmax(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsFmaxI(int n, float* a, int inca, float* b, int incb, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsFmaxI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsFmaxI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsFmin(int n, float* a, float* b, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsFmin(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsFmin(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsFminI(int n, float* a, int inca, float* b, int incb, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsFminI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsFminI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsFmod(int n, float* a, float* b, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsFmod(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsFmod(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsFmodI(int n, float* a, int inca, float* b, int incb, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsFmodI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsFmodI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsFrac(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsFrac(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsFrac(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsFracI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsFracI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsFracI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsHypot(int n, float* a, float* b, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsHypot(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsHypot(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsHypotI(int n, float* a, int inca, float* b, int incb, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsHypotI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsHypotI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsInv(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsInv(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsInv(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsInvCbrt(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsInvCbrt(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsInvCbrt(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsInvCbrtI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsInvCbrtI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsInvCbrtI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsInvI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsInvI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsInvI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsInvSqrt(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsInvSqrt(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsInvSqrt(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsInvSqrtI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsInvSqrtI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsInvSqrtI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsLGamma(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsLGamma(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsLGamma(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsLGammaI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsLGammaI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsLGammaI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsLinearFrac(int n, float* a, float* b, float scalea, float shifta, float scaleb, float shiftb, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsLinearFrac(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, float scalea, float shifta, float scaleb, float shiftb, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsLinearFrac(n, aPtr, bPtr, scalea, shifta, scaleb, shiftb, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsLinearFracI(int n, float* a, int inca, float* b, int incb, float scalea, float shifta, float scaleb, float shiftb, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsLinearFracI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, float scalea, float shifta, float scaleb, float shiftb, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsLinearFracI(n, aPtr, inca, bPtr, incb, scalea, shifta, scaleb, shiftb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsLn(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsLn(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsLn(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsLnI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsLnI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsLnI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsLog10(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsLog10(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsLog10(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsLog10I(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsLog10I(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsLog10I(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsLog1p(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsLog1p(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsLog1p(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsLog1pI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsLog1pI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsLog1pI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsLog2(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsLog2(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsLog2(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsLog2I(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsLog2I(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsLog2I(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsLogb(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsLogb(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsLogb(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsLogbI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsLogbI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsLogbI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsMaxMag(int n, float* a, float* b, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsMaxMag(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsMaxMag(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsMaxMagI(int n, float* a, int inca, float* b, int incb, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsMaxMagI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsMaxMagI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsMinMag(int n, float* a, float* b, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsMinMag(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsMinMag(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsMinMagI(int n, float* a, int inca, float* b, int incb, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsMinMagI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsMinMagI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsModf(int n, float* a, float* r1, float* r2, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsModf(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> r1, ReadOnlySpan<float> r2, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* r1Ptr = r1)
			fixed (float* r2Ptr = r2)
			{
				vmsModf(n, aPtr, r1Ptr, r2Ptr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsModfI(int n, float* a, int inca, float* r1, int incr1, float* r2, int incr2, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsModfI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> r1, int incr1, ReadOnlySpan<float> r2, int incr2, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* r1Ptr = r1)
			fixed (float* r2Ptr = r2)
			{
				vmsModfI(n, aPtr, inca, r1Ptr, incr1, r2Ptr, incr2, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsMul(int n, float* a, float* b, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsMul(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsMul(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsMulI(int n, float* a, int inca, float* b, int incb, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsMulI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsMulI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsNearbyInt(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsNearbyInt(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsNearbyInt(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsNearbyIntI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsNearbyIntI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsNearbyIntI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsNextAfter(int n, float* a, float* b, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsNextAfter(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsNextAfter(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsNextAfterI(int n, float* a, int inca, float* b, int incb, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsNextAfterI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsNextAfterI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsPow(int n, float* a, float* b, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsPow(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsPow(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsPow2o3(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsPow2o3(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsPow2o3(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsPow2o3I(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsPow2o3I(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsPow2o3I(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsPow3o2(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsPow3o2(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsPow3o2(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsPow3o2I(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsPow3o2I(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsPow3o2I(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsPowI(int n, float* a, int inca, float* b, int incb, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsPowI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsPowI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsPowr(int n, float* a, float* b, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsPowr(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsPowr(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsPowrI(int n, float* a, int inca, float* b, int incb, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsPowrI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsPowrI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsPowx(int n, float* a, float b, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsPowx(int n, ReadOnlySpan<float> a, float b, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsPowx(n, aPtr, b, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsPowxI(int n, float* a, int inca, float b, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsPowxI(int n, ReadOnlySpan<float> a, int inca, float b, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsPowxI(n, aPtr, inca, b, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsRemainder(int n, float* a, float* b, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsRemainder(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsRemainder(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsRemainderI(int n, float* a, int inca, float* b, int incb, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsRemainderI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsRemainderI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsRint(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsRint(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsRint(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsRintI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsRintI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsRintI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsRound(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsRound(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsRound(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsRoundI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsRoundI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsRoundI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsSin(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsSin(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsSin(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsSinCos(int n, float* a, float* r1, float* r2, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsSinCos(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> r1, ReadOnlySpan<float> r2, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* r1Ptr = r1)
			fixed (float* r2Ptr = r2)
			{
				vmsSinCos(n, aPtr, r1Ptr, r2Ptr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsSinCosI(int n, float* a, int inca, float* r1, int incr1, float* r2, int incr2, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsSinCosI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> r1, int incr1, ReadOnlySpan<float> r2, int incr2, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* r1Ptr = r1)
			fixed (float* r2Ptr = r2)
			{
				vmsSinCosI(n, aPtr, inca, r1Ptr, incr1, r2Ptr, incr2, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsSind(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsSind(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsSind(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsSindI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsSindI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsSindI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsSinh(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsSinh(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsSinh(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsSinhI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsSinhI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsSinhI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsSinI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsSinI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsSinI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsSinpi(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsSinpi(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsSinpi(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsSinpiI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsSinpiI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsSinpiI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsSqr(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsSqr(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsSqr(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsSqrI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsSqrI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsSqrI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsSqrt(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsSqrt(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsSqrt(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsSqrtI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsSqrtI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsSqrtI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsSub(int n, float* a, float* b, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsSub(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsSub(n, aPtr, bPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsSubI(int n, float* a, int inca, float* b, int incb, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsSubI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vmsSubI(n, aPtr, inca, bPtr, incb, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsTan(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsTan(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsTan(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsTand(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsTand(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsTand(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsTandI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsTandI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsTandI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsTanh(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsTanh(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsTanh(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsTanhI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsTanhI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsTanhI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsTanI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsTanI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsTanI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsTanpi(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsTanpi(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsTanpi(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsTanpiI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsTanpiI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsTanpiI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsTGamma(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsTGamma(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsTGamma(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsTGammaI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsTGammaI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsTGammaI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsTrunc(int n, float* a, float* r, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsTrunc(int n, ReadOnlySpan<float> a, Span<float> r, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsTrunc(n, aPtr, rPtr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vmsTruncI(int n, float* a, int inca, float* r, int incr, VmlMode mode);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vmsTruncI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr, VmlMode mode)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vmsTruncI(n, aPtr, inca, rPtr, incr, mode);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAbs(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAbs(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAbs(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAbsI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAbsI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAbsI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAcos(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAcos(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAcos(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAcosh(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAcosh(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAcosh(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAcoshI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAcoshI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAcoshI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAcosI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAcosI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAcosI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAcospi(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAcospi(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAcospi(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAcospiI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAcospiI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAcospiI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAdd(int n, float* a, float* b, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAdd(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsAdd(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAddI(int n, float* a, int inca, float* b, int incb, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAddI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsAddI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAsin(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAsin(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAsin(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAsinh(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAsinh(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAsinh(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAsinhI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAsinhI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAsinhI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAsinI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAsinI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAsinI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAsinpi(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAsinpi(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAsinpi(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAsinpiI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAsinpiI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAsinpiI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAtan(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAtan(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAtan(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAtan2(int n, float* a, float* b, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAtan2(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsAtan2(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAtan2I(int n, float* a, int inca, float* b, int incb, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAtan2I(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsAtan2I(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAtan2pi(int n, float* a, float* b, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAtan2pi(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsAtan2pi(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAtan2piI(int n, float* a, int inca, float* b, int incb, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAtan2piI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsAtan2piI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAtanh(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAtanh(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAtanh(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAtanhI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAtanhI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAtanhI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAtanI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAtanI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAtanI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAtanpi(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAtanpi(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAtanpi(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsAtanpiI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsAtanpiI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsAtanpiI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsCbrt(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsCbrt(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsCbrt(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsCbrtI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsCbrtI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsCbrtI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsCdfNorm(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsCdfNorm(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsCdfNorm(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsCdfNormI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsCdfNormI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsCdfNormI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsCdfNormInv(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsCdfNormInv(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsCdfNormInv(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsCdfNormInvI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsCdfNormInvI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsCdfNormInvI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsCeil(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsCeil(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsCeil(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsCeilI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsCeilI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsCeilI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsCopySign(int n, float* a, float* b, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsCopySign(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsCopySign(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsCopySignI(int n, float* a, int inca, float* b, int incb, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsCopySignI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsCopySignI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsCos(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsCos(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsCos(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsCosd(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsCosd(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsCosd(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsCosdI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsCosdI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsCosdI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsCosh(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsCosh(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsCosh(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsCoshI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsCoshI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsCoshI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsCosI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsCosI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsCosI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsCospi(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsCospi(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsCospi(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsCospiI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsCospiI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsCospiI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsDiv(int n, float* a, float* b, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsDiv(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsDiv(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsDivI(int n, float* a, int inca, float* b, int incb, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsDivI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsDivI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsErf(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsErf(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsErf(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsErfc(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsErfc(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsErfc(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsErfcI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsErfcI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsErfcI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsErfcInv(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsErfcInv(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsErfcInv(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsErfcInvI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsErfcInvI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsErfcInvI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsErfI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsErfI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsErfI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsErfInv(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsErfInv(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsErfInv(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsErfInvI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsErfInvI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsErfInvI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsExp(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsExp(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsExp(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsExp10(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsExp10(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsExp10(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsExp10I(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsExp10I(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsExp10I(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsExp2(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsExp2(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsExp2(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsExp2I(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsExp2I(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsExp2I(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsExpI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsExpI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsExpI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsExpInt1(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsExpInt1(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsExpInt1(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsExpInt1I(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsExpInt1I(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsExpInt1I(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsExpm1(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsExpm1(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsExpm1(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsExpm1I(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsExpm1I(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsExpm1I(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsFdim(int n, float* a, float* b, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsFdim(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsFdim(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsFdimI(int n, float* a, int inca, float* b, int incb, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsFdimI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsFdimI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsFloor(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsFloor(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsFloor(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsFloorI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsFloorI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsFloorI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsFmax(int n, float* a, float* b, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsFmax(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsFmax(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsFmaxI(int n, float* a, int inca, float* b, int incb, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsFmaxI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsFmaxI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsFmin(int n, float* a, float* b, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsFmin(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsFmin(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsFminI(int n, float* a, int inca, float* b, int incb, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsFminI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsFminI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsFmod(int n, float* a, float* b, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsFmod(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsFmod(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsFmodI(int n, float* a, int inca, float* b, int incb, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsFmodI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsFmodI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsFrac(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsFrac(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsFrac(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsFracI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsFracI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsFracI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsHypot(int n, float* a, float* b, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsHypot(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsHypot(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsHypotI(int n, float* a, int inca, float* b, int incb, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsHypotI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsHypotI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsInv(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsInv(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsInv(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsInvCbrt(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsInvCbrt(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsInvCbrt(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsInvCbrtI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsInvCbrtI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsInvCbrtI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsInvI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsInvI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsInvI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsInvSqrt(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsInvSqrt(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsInvSqrt(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsInvSqrtI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsInvSqrtI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsInvSqrtI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsLGamma(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsLGamma(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsLGamma(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsLGammaI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsLGammaI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsLGammaI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsLinearFrac(int n, float* a, float* b, float scalea, float shifta, float scaleb, float shiftb, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsLinearFrac(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, float scalea, float shifta, float scaleb, float shiftb, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsLinearFrac(n, aPtr, bPtr, scalea, shifta, scaleb, shiftb, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsLinearFracI(int n, float* a, int inca, float* b, int incb, float scalea, float shifta, float scaleb, float shiftb, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsLinearFracI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, float scalea, float shifta, float scaleb, float shiftb, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsLinearFracI(n, aPtr, inca, bPtr, incb, scalea, shifta, scaleb, shiftb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsLn(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsLn(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsLn(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsLnI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsLnI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsLnI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsLog10(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsLog10(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsLog10(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsLog10I(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsLog10I(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsLog10I(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsLog1p(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsLog1p(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsLog1p(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsLog1pI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsLog1pI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsLog1pI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsLog2(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsLog2(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsLog2(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsLog2I(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsLog2I(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsLog2I(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsLogb(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsLogb(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsLogb(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsLogbI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsLogbI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsLogbI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsMaxMag(int n, float* a, float* b, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsMaxMag(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsMaxMag(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsMaxMagI(int n, float* a, int inca, float* b, int incb, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsMaxMagI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsMaxMagI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsMinMag(int n, float* a, float* b, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsMinMag(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsMinMag(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsMinMagI(int n, float* a, int inca, float* b, int incb, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsMinMagI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsMinMagI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsModf(int n, float* a, float* r1, float* r2);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsModf(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> r1, ReadOnlySpan<float> r2)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* r1Ptr = r1)
			fixed (float* r2Ptr = r2)
			{
				vsModf(n, aPtr, r1Ptr, r2Ptr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsModfI(int n, float* a, int inca, float* r1, int incr1, float* r2, int incr2);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsModfI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> r1, int incr1, ReadOnlySpan<float> r2, int incr2)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* r1Ptr = r1)
			fixed (float* r2Ptr = r2)
			{
				vsModfI(n, aPtr, inca, r1Ptr, incr1, r2Ptr, incr2);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsMul(int n, float* a, float* b, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsMul(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsMul(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsMulI(int n, float* a, int inca, float* b, int incb, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsMulI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsMulI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsNearbyInt(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsNearbyInt(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsNearbyInt(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsNearbyIntI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsNearbyIntI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsNearbyIntI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsNextAfter(int n, float* a, float* b, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsNextAfter(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsNextAfter(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsNextAfterI(int n, float* a, int inca, float* b, int incb, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsNextAfterI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsNextAfterI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsPackI(int n, float* a, int incra, float* y);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsPackI(int n, ReadOnlySpan<float> a, int incra, ReadOnlySpan<float> y)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* yPtr = y)
			{
				vsPackI(n, aPtr, incra, yPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsPackM(int n, float* a, int[] ma, float* y);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsPackM(int n, ReadOnlySpan<float> a, int[] ma, ReadOnlySpan<float> y)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* yPtr = y)
			{
				vsPackM(n, aPtr, ma, yPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsPackV(int n, float* a, int[] ia, float* y);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsPackV(int n, ReadOnlySpan<float> a, int[] ia, ReadOnlySpan<float> y)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* yPtr = y)
			{
				vsPackV(n, aPtr, ia, yPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsPow(int n, float* a, float* b, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsPow(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsPow(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsPow2o3(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsPow2o3(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsPow2o3(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsPow2o3I(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsPow2o3I(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsPow2o3I(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsPow3o2(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsPow3o2(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsPow3o2(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsPow3o2I(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsPow3o2I(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsPow3o2I(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsPowI(int n, float* a, int inca, float* b, int incb, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsPowI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsPowI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsPowr(int n, float* a, float* b, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsPowr(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsPowr(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsPowrI(int n, float* a, int inca, float* b, int incb, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsPowrI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsPowrI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsPowx(int n, float* a, float b, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsPowx(int n, ReadOnlySpan<float> a, float b, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsPowx(n, aPtr, b, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsPowxI(int n, float* a, int inca, float b, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsPowxI(int n, ReadOnlySpan<float> a, int inca, float b, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsPowxI(n, aPtr, inca, b, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsRemainder(int n, float* a, float* b, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsRemainder(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsRemainder(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsRemainderI(int n, float* a, int inca, float* b, int incb, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsRemainderI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsRemainderI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsRint(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsRint(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsRint(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsRintI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsRintI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsRintI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsRound(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsRound(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsRound(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsRoundI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsRoundI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsRoundI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsSin(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsSin(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsSin(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsSinCos(int n, float* a, float* r1, float* r2);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsSinCos(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> r1, ReadOnlySpan<float> r2)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* r1Ptr = r1)
			fixed (float* r2Ptr = r2)
			{
				vsSinCos(n, aPtr, r1Ptr, r2Ptr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsSinCosI(int n, float* a, int inca, float* r1, int incr1, float* r2, int incr2);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsSinCosI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> r1, int incr1, ReadOnlySpan<float> r2, int incr2)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* r1Ptr = r1)
			fixed (float* r2Ptr = r2)
			{
				vsSinCosI(n, aPtr, inca, r1Ptr, incr1, r2Ptr, incr2);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsSind(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsSind(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsSind(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsSindI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsSindI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsSindI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsSinh(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsSinh(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsSinh(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsSinhI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsSinhI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsSinhI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsSinI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsSinI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsSinI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsSinpi(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsSinpi(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsSinpi(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsSinpiI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsSinpiI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsSinpiI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsSqr(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsSqr(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsSqr(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsSqrI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsSqrI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsSqrI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsSqrt(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsSqrt(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsSqrt(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsSqrtI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsSqrtI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsSqrtI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsSub(int n, float* a, float* b, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsSub(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> b, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsSub(n, aPtr, bPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsSubI(int n, float* a, int inca, float* b, int incb, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsSubI(int n, ReadOnlySpan<float> a, int inca, ReadOnlySpan<float> b, int incb, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* bPtr = b)
			fixed (float* rPtr = r)
			{
				vsSubI(n, aPtr, inca, bPtr, incb, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsTan(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsTan(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsTan(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsTand(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsTand(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsTand(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsTandI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsTandI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsTandI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsTanh(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsTanh(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsTanh(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsTanhI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsTanhI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsTanhI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsTanI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsTanI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsTanI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsTanpi(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsTanpi(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsTanpi(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsTanpiI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsTanpiI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsTanpiI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsTGamma(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsTGamma(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsTGamma(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsTGammaI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsTGammaI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsTGammaI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsTrunc(int n, float* a, float* r);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsTrunc(int n, ReadOnlySpan<float> a, Span<float> r)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsTrunc(n, aPtr, rPtr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsTruncI(int n, float* a, int inca, float* r, int incr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsTruncI(int n, ReadOnlySpan<float> a, int inca, Span<float> r, int incr)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* rPtr = r)
			{
				vsTruncI(n, aPtr, inca, rPtr, incr);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsUnpackI(int n, float* a, float* y, int incry);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsUnpackI(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> y, int incry)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* yPtr = y)
			{
				vsUnpackI(n, aPtr, yPtr, incry);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsUnpackM(int n, float* a, float* y, int[] my);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsUnpackM(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> y, int[] my)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* yPtr = y)
			{
				vsUnpackM(n, aPtr, yPtr, my);
			}
		}
	}


	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	internal static extern unsafe void vsUnpackV(int n, float* a, float* y, int[] iy);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void vsUnpackV(int n, ReadOnlySpan<float> a, ReadOnlySpan<float> y, int[] iy)
	{
		unsafe
		{
			fixed (float* aPtr = a)
			fixed (float* yPtr = y)
			{
				vsUnpackV(n, aPtr, yPtr, iy);
			}
		}
	}
}
