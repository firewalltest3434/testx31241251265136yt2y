using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x02000572 RID: 1394
internal sealed class Class627
{
	// Token: 0x06001E4D RID: 7757 RVA: 0x0007EBE8 File Offset: 0x0007CDE8
	public static bool smethod_0()
	{
		Class627.string_0 = Class475.smethod_7();
		using (List<string>.Enumerator enumerator = Class627.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!Class627.smethod_2(enumerator.Current))
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06001E4E RID: 7758 RVA: 0x0007EC4C File Offset: 0x0007CE4C
	public static void smethod_1()
	{
		Class627.string_0 = Class475.smethod_7();
		foreach (string path in Class627.list_0)
		{
			try
			{
				File.Delete(Path.Combine(Class627.string_0, path));
			}
			catch (object obj)
			{
			}
		}
	}

	// Token: 0x06001E4F RID: 7759 RVA: 0x0007ECC4 File Offset: 0x0007CEC4
	public static bool smethod_2(string string_1)
	{
		if (File.Exists(Path.Combine(Class627.string_0, string_1)))
		{
			return true;
		}
		bool result;
		try
		{
			Class650.smethod_4("BoosterX", Class627.string_0, "Resources.EmbedRes.EasyHook", string_1, true);
			return true;
		}
		catch (Exception exception_)
		{
			GClass141.smethod_0(exception_);
			result = false;
		}
		return result;
	}

	// Token: 0x04001563 RID: 5475
	public static readonly List<string> list_0 = new List<string>
	{
		"SharpDX.D3DCompiler.dll",
		"SharpDX.Desktop.dll",
		"SharpDX.Direct2D1.dll",
		"SharpDX.Direct3D9.dll",
		"SharpDX.Direct3D10.dll",
		"SharpDX.Direct3D11.dll",
		"SharpDX.Direct3D11.Effects.dll",
		"SharpDX.dll",
		"SharpDX.DXGI.dll",
		"SharpDX.Mathematics.dll",
		"sharpdx_direct3d11_1_effects_x64.dll",
		"sharpdx_direct3d11_1_effects_x86.dll",
		"Capture.dll",
		"EasyHook.dll",
		"EasyHook32.dll",
		"EasyHook32Svc.exe",
		"EasyHook64.dll",
		"EasyHook64Svc.exe",
		"EasyLoad32.dll",
		"EasyLoad64.dll"
	};

	// Token: 0x04001564 RID: 5476
	private static string string_0 = string.Empty;
}
