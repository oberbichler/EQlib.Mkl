namespace EQlib.Mkl;

using System;
using System.Diagnostics;

using static Blas;

public class HyperJet
{
	public static void Unary(int size, double f, double da, ReadOnlySpan<double> a, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = size + 1;

		Debug.Assert(a.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				*rPtr = f;

				var a1Ptr = aPtr + 1;

				var kPtr = rPtr + 1;

				cblas_daxpy(n - 1, da, a1Ptr, 1, kPtr, 1);
			}
		}
	}

	public static void Binary(int size, double f, double da, double db, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = size + 1;

		Debug.Assert(a.Length == n);
		Debug.Assert(b.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				*rPtr = f;

				var a1Ptr = aPtr + 1;
				var b1Ptr = bPtr + 1;

				var kPtr = rPtr + 1;

				cblas_daxpy(n - 1, da, a1Ptr, 1, kPtr, 1);
				cblas_daxpy(n - 1, db, b1Ptr, 1, kPtr, 1);
			}
		}
	}

	public static void Ternary(int size, double f, double da, double db, double dc, ReadOnlySpan<double> a, ReadOnlySpan<double> b, ReadOnlySpan<double> c, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = size + 1;

		Debug.Assert(a.Length == n);
		Debug.Assert(b.Length == n);
		Debug.Assert(c.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* cPtr = c)
			fixed (double* rPtr = r)
			{
				*rPtr = f;

				var a1Ptr = aPtr + 1;
				var b1Ptr = bPtr + 1;
				var c1Ptr = cPtr + 1;

				var kPtr = rPtr + 1;

				cblas_daxpy(n - 1, da, a1Ptr, 1, kPtr, 1);
				cblas_daxpy(n - 1, db, b1Ptr, 1, kPtr, 1);
				cblas_daxpy(n - 1, dc, c1Ptr, 1, kPtr, 1);
			}
		}
	}


	public static void DNegative(int size, ReadOnlySpan<double> a, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = size + 1;

		Debug.Assert(a.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				cblas_daxpy(n, -1, aPtr, 1, rPtr, 1);
			}
		}
	}


	public static void DAdd(int size, double a, ReadOnlySpan<double> b, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = size + 1;

		Debug.Assert(b.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				cblas_dcopy(n, bPtr, 1, rPtr, 1);
				rPtr[0] += a;
			}
		}
	}

	public static void DAdd(int size, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = size + 1;

		Debug.Assert(a.Length == n);
		Debug.Assert(b.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				Vml.vdAdd(n, aPtr, bPtr, rPtr);
			}
		}
	}


	public static void DSubtract(int size, double a, ReadOnlySpan<double> b, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = size + 1;

		Debug.Assert(b.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				cblas_daxpy(n, -1, bPtr, 1, rPtr, 1);
				rPtr[0] += a;
			}
		}
	}

	public static void DSubtract(int size, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = size + 1;

		Debug.Assert(a.Length == n);
		Debug.Assert(b.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				Vml.vdSub(n, aPtr, bPtr, rPtr);
			}
		}
	}


	public static void DMultiply(int size, double a, ReadOnlySpan<double> b, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = size + 1;

		Debug.Assert(b.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				rPtr[0] = a * bPtr[0];

				var db = a;

				cblas_daxpy(n, db, bPtr, 1, rPtr, 1);
			}
		}
	}

	public static void DMultiply(int size, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = size + 1;

		Debug.Assert(a.Length == n);
		Debug.Assert(b.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				rPtr[0] = aPtr[0] * bPtr[0];

				var da = bPtr[0];
				var db = aPtr[0];

				var a1Ptr = aPtr + 1;
				var b1Ptr = bPtr + 1;

				var kPtr = rPtr + 1;

				cblas_daxpy(n - 1, da, a1Ptr, 1, kPtr, 1);
				cblas_daxpy(n - 1, db, b1Ptr, 1, kPtr, 1);
			}
		}
	}


	public static void DDivide(int size, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = size + 1;

		Debug.Assert(a.Length == n);
		Debug.Assert(b.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				var da = 1 / bPtr[0];
				var tmp = da * da;
				var db = -aPtr[0] * tmp;
				var dadb = -1 * tmp;
				var dbdb = -2 * db * da;

				rPtr[0] = aPtr[0] / bPtr[0];

				var a1Ptr = aPtr + 1;
				var b1Ptr = bPtr + 1;

				var kPtr = rPtr + 1;

				cblas_daxpy(n - 1, da, a1Ptr, 1, kPtr, 1);
				cblas_daxpy(n - 1, db, b1Ptr, 1, kPtr, 1);
			}
		}
	}

	public static void DDivide(int size, double a, ReadOnlySpan<double> b, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = size + 1;

		Debug.Assert(b.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				var db = -a / (bPtr[0] * bPtr[0]);
				var dbdb = 2 * a / (bPtr[0] * bPtr[0] * bPtr[0]);

				rPtr[0] = a / bPtr[0];

				var b1Ptr = bPtr + 1;

				var kPtr = rPtr + 1;

				cblas_daxpy(n - 1, db, b1Ptr, 1, kPtr, 1);
			}
		}
	}




	public static void Unary(int size, double f, double da, double daa, ReadOnlySpan<double> a, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = (size + 1) * (size + 2) / 2;

		Debug.Assert(a.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				*rPtr = f;

				var a1Ptr = aPtr + 1;

				var kPtr = rPtr + 1;

				cblas_daxpy(n - 1, da, a1Ptr, 1, kPtr, 1);

				kPtr += size;

				for (var i = 0; i < size; i++)
				{
					var m = size - i;

					var ai = *(a1Ptr + i);

					var ca = daa * ai;

					cblas_daxpy(m, ca, a1Ptr + i, 1, kPtr, 1);

					kPtr += m;
				}
			}
		}
	}

	public static void Binary(int size, double f, double da, double db, double daa, double dab, double dbb, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = (size + 1) * (size + 2) / 2;

		Debug.Assert(a.Length == n);
		Debug.Assert(b.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				*rPtr = f;

				var a1Ptr = aPtr + 1;
				var b1Ptr = bPtr + 1;

				var kPtr = rPtr + 1;

				cblas_daxpy(n - 1, da, a1Ptr, 1, kPtr, 1);
				cblas_daxpy(n - 1, db, b1Ptr, 1, kPtr, 1);

				kPtr += size;

				for (var i = 0; i < size; i++)
				{
					var m = size - i;

					var ai = *(a1Ptr + i);
					var bi = *(b1Ptr + i);

					var ca = daa * ai + dab * bi;
					var cb = dab * ai + dbb * bi;

					cblas_daxpy(m, ca, a1Ptr + i, 1, kPtr, 1);
					cblas_daxpy(m, cb, b1Ptr + i, 1, kPtr, 1);

					kPtr += m;
				}
			}
		}
	}

	public static void Ternary(int size, double f, double da, double db, double dc, double daa, double dab, double dac, double dbb, double dbc, double dcc, ReadOnlySpan<double> a, ReadOnlySpan<double> b, ReadOnlySpan<double> c, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = (size + 1) * (size + 2) / 2;

		Debug.Assert(a.Length == n);
		Debug.Assert(b.Length == n);
		Debug.Assert(c.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* cPtr = c)
			fixed (double* rPtr = r)
			{
				*rPtr = f;

				var a1Ptr = aPtr + 1;
				var b1Ptr = bPtr + 1;
				var c1Ptr = cPtr + 1;

				var kPtr = rPtr + 1;

				cblas_daxpy(n - 1, da, a1Ptr, 1, kPtr, 1);
				cblas_daxpy(n - 1, db, b1Ptr, 1, kPtr, 1);
				cblas_daxpy(n - 1, dc, c1Ptr, 1, kPtr, 1);

				kPtr += size;

				for (var i = 0; i < size; i++)
				{
					var m = size - i;

					var ai = *(a1Ptr + i);
					var bi = *(b1Ptr + i);
					var ci = *(c1Ptr + i);

					var ca = daa * ai + dab * bi + dac * ci;
					var cb = dab * ai + dbb * bi + dbc * ci;
					var cc = dac * ai + dbc * bi + dcc * ci;

					cblas_daxpy(m, ca, a1Ptr + i, 1, kPtr, 1);
					cblas_daxpy(m, cb, b1Ptr + i, 1, kPtr, 1);
					cblas_daxpy(m, cc, c1Ptr + i, 1, kPtr, 1);

					kPtr += m;
				}
			}
		}
	}


	public static void Negative(int size, ReadOnlySpan<double> a, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = (size + 1) * (size + 2) / 2;

		Debug.Assert(a.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* rPtr = r)
			{
				cblas_daxpy(n, -1, aPtr, 1, rPtr, 1);
			}
		}
	}


	public static void Add(int size, double a, ReadOnlySpan<double> b, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = (size + 1) * (size + 2) / 2;

		Debug.Assert(b.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				cblas_dcopy(n, bPtr, 1, rPtr, 1);
				rPtr[0] += a;
			}
		}
	}

	public static void Add(int size, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = (size + 1) * (size + 2) / 2;

		Debug.Assert(a.Length == n);
		Debug.Assert(b.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				Vml.vdAdd(n, aPtr, bPtr, rPtr);
			}
		}
	}


	public static void Subtract(int size, double a, ReadOnlySpan<double> b, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = (size + 1) * (size + 2) / 2;

		Debug.Assert(b.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				cblas_daxpy(n, -1, bPtr, 1, rPtr, 1);
				rPtr[0] += a;
			}
		}
	}

	public static void Subtract(int size, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = (size + 1) * (size + 2) / 2;

		Debug.Assert(a.Length == n);
		Debug.Assert(b.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				Vml.vdSub(n, aPtr, bPtr, rPtr);
			}
		}
	}


	public static void Multiply(int size, double a, ReadOnlySpan<double> b, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = (size + 1) * (size + 2) / 2;

		Debug.Assert(b.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				cblas_daxpy(n, a, bPtr, 1, rPtr, 1);
			}
		}
	}

	public static void Multiply(int size, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = (size + 1) * (size + 2) / 2;

		Debug.Assert(a.Length == n);
		Debug.Assert(b.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				rPtr[0] = aPtr[0] * bPtr[0];

				var da = bPtr[0];
				var db = aPtr[0];

				var a1Ptr = aPtr + 1;
				var b1Ptr = bPtr + 1;

				var kPtr = rPtr + 1;

				cblas_daxpy(n - 1, da, a1Ptr, 1, kPtr, 1);
				cblas_daxpy(n - 1, db, b1Ptr, 1, kPtr, 1);

				kPtr += size;

				for (var i = 0; i < size; i++)
				{
					var m = size - i;

					var ai = *(a1Ptr + i);
					var bi = *(b1Ptr + i);

					var ca = bi;
					var cb = ai;

					cblas_daxpy(m, ca, a1Ptr + i, 1, kPtr, 1);
					cblas_daxpy(m, cb, b1Ptr + i, 1, kPtr, 1);

					kPtr += m;
				}
			}
		}
	}


	public static void Divide(int size, ReadOnlySpan<double> a, ReadOnlySpan<double> b, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = (size + 1) * (size + 2) / 2;

		Debug.Assert(a.Length == n);
		Debug.Assert(b.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* aPtr = a)
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				var da = 1 / bPtr[0];
				var tmp = da * da;
				var db = -aPtr[0] * tmp;
				var dadb = -1 * tmp;
				var dbdb = -2 * db * da;

				rPtr[0] = aPtr[0] / bPtr[0];

				var a1Ptr = aPtr + 1;
				var b1Ptr = bPtr + 1;

				var kPtr = rPtr + 1;

				cblas_daxpy(n - 1, da, a1Ptr, 1, kPtr, 1);
				cblas_daxpy(n - 1, db, b1Ptr, 1, kPtr, 1);

				kPtr += size;

				for (var i = 0; i < size; i++)
				{
					var m = size - i;

					var ai = *(a1Ptr + i);
					var bi = *(b1Ptr + i);

					var ca = dadb * bi;
					var cb = dadb * ai + dbdb * bi;

					cblas_daxpy(m, ca, a1Ptr + i, 1, kPtr, 1);
					cblas_daxpy(m, cb, b1Ptr + i, 1, kPtr, 1);

					kPtr += m;
				}
			}
		}
	}

	public static void Divide(int size, double a, ReadOnlySpan<double> b, Span<double> r)
	{
		Debug.Assert(size >= 0);

		var n = (size + 1) * (size + 2) / 2;

		Debug.Assert(b.Length == n);
		Debug.Assert(r.Length == n);

		unsafe
		{
			fixed (double* bPtr = b)
			fixed (double* rPtr = r)
			{
				var db = -a / (bPtr[0] * bPtr[0]);
				var dbdb = 2 * a / (bPtr[0] * bPtr[0] * bPtr[0]);

				rPtr[0] = a / bPtr[0];

				var b1Ptr = bPtr + 1;

				var kPtr = rPtr + 1;

				cblas_daxpy(n - 1, db, b1Ptr, 1, kPtr, 1);

				kPtr += size;

				for (var i = 0; i < size; i++)
				{
					var m = size - i;

					var bi = *(b1Ptr + i);

					var cb = dbdb * bi;

					cblas_daxpy(m, cb, b1Ptr + i, 1, kPtr, 1);

					kPtr += m;
				}
			}
		}
	}
}
