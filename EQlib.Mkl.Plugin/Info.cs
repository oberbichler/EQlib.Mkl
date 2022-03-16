namespace EQlib.Plugin;

using System;
using System.Drawing;
using System.Reflection;
using Grasshopper.Kernel;

public class PluginInfo : GH_AssemblyInfo
{
	public override string Name { get; } = "EQlib-Mkl";

	public override Bitmap Icon { get; } = null;

	public override string Description { get; } = "Interface to Intel oneAPI Math Kernel Library (Intel oneMKL) for EQlib";

	public override Guid Id { get; } = new("{6485DEEA-2E92-4F13-9C82-168720846C16}");

	public override string AuthorName { get; } = "Thomas Oberbichler";

	public override string AuthorContact { get; } = "https://github.com/oberbichler";

	public override string Version { get; } = Assembly.GetAssembly(typeof(Mkl.Info)).GetName().Version.ToString();

	public override string AssemblyVersion => Version;
}
