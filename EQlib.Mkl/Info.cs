namespace EQlib.Mkl;

using System.Runtime.CompilerServices;
using System.Security;

[SuppressUnmanagedCodeSecurity]
public static class Info
{
#if Windows
	internal const string mkl_rt = "mkl_rt.2.dll";
#elif OSX
	internal const string mkl_rt = "mkl_rt.1.dylib";
#endif

	internal unsafe struct MKLVersion_
	{
		public int MajorVersion;
		public int MinorVersion;
		public int UpdateVersion;
		public sbyte* ProductStatus;
		public sbyte* Build;
		public sbyte* Processor;
		public sbyte* Platform;
	}

	public struct MKLVersion
	{
		public int MajorVersion;
		public int MinorVersion;
		public int UpdateVersion;
		public string ProductStatus;
		public string Build;
		public string Processor;
		public string Platform;
	}

	[DllImport(mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	private static extern int mkl_get_version(ref MKLVersion_ version);

	public static MKLVersion GetVersion()
	{
		var mklVer_ = new MKLVersion_();

		mkl_get_version(ref mklVer_);

		unsafe
		{
			return new MKLVersion
			{
				MajorVersion = mklVer_.MajorVersion,
				MinorVersion = mklVer_.MinorVersion,
				UpdateVersion = mklVer_.UpdateVersion,
				ProductStatus = new string(mklVer_.ProductStatus),
				Build = new string(mklVer_.Build),
				Processor = new string(mklVer_.Processor),
				Platform = new string(mklVer_.Platform),
			};
		}
	}


	[DllImport(mkl_rt, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	private static extern unsafe void mkl_get_version_string(sbyte* buf, int len);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string GetVersionString()
	{
		const int len = 198;

		unsafe
		{
			fixed (sbyte* chars = new sbyte[len])
			{
				mkl_get_version_string(chars, len);
				return new string(chars).TrimEnd();
			}
		}
	}
}
