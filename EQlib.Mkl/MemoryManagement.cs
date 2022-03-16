namespace EQlib.Mkl;

using System.Runtime.CompilerServices;
using System.Security;

[SuppressUnmanagedCodeSecurity]
public static class MemoryManagement
{
	[DllImport(Info.mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, SetLastError = false)]
	private static extern void mkl_free_buffers();

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void FreeBuffers()
	{
		mkl_free_buffers();
	}
}
