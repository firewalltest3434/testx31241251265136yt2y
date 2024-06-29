using System;
using System.Collections.Generic;
using System.Reflection;

// Token: 0x02000575 RID: 1397
internal static class Class629
{
	// Token: 0x06001E58 RID: 7768 RVA: 0x0007EED4 File Offset: 0x0007D0D4
	internal static void smethod_0()
	{
		AppDomain.CurrentDomain.ResourceResolve += Class629.smethod_1;
	}

	// Token: 0x06001E59 RID: 7769 RVA: 0x0007EEEC File Offset: 0x0007D0EC
	private static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (resolveEventArgs_0.RequestingAssembly != Class629.assembly_0)
		{
			return null;
		}
		if (Class629.bool_0)
		{
			return null;
		}
		return Class629.smethod_2(resolveEventArgs_0.Name);
	}

	// Token: 0x06001E5A RID: 7770 RVA: 0x0007EF1C File Offset: 0x0007D11C
	private static Assembly smethod_2(string string_0)
	{
		Class629.bool_0 = true;
		Assembly result;
		try
		{
			Class629.smethod_3();
			Class629.Class630 @class;
			if (!Class629.dictionary_0.TryGetValue(string_0, out @class))
			{
				result = null;
			}
			else
			{
				result = @class.method_0();
			}
		}
		finally
		{
			Class629.bool_0 = false;
		}
		return result;
	}

	// Token: 0x06001E5B RID: 7771 RVA: 0x0007EF6C File Offset: 0x0007D16C
	private static void smethod_3()
	{
		if (Class629.dictionary_0 == null)
		{
			Assembly obj = Class629.assembly_0;
			lock (obj)
			{
				if (Class629.dictionary_0 == null)
				{
					string text = "zx_6525a1ba43284c439391f43a5488635e, PublicKeyToken=null|BoosterX.g.resources:zx_a170746b41f54fe04022c291d85e2700, PublicKeyToken=null|BoosterX.Properties.Resources.resources:zx_b15aa6e8430e45a67b0b31685f1cd359, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.EasyHook32.dll:zx_64bb5178910e46cc563b5d961e6ae347, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.EasyHook64.dll:zx_eb28dbbc040647d8d9063a2fe48781ac, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.EasyLoad32.dll:zx_c67c00a3355a4fca9b67b2473a0d141f, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.EasyLoad64.dll:zx_e0aa3506a7c7465d528bd3337c9f5212, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.sharpdx_direct3d11_1_effects_x64.dll:zx_006ec97b64cf4f5861daedb03904fa99, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.sharpdx_direct3d11_1_effects_x86.dll:zx_68b4d7227afa4ceb7f9d5ebc016d45ad, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.Capture.dll:zx_384e2fbd375444ecf7bfd79b1c1bf87e, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.EasyHook.dll:zx_46eb57f6694e45048604bf92a12a8edc, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.SharpDX.D3DCompiler.dll:zx_47dd596f7f41462f619565cc52c39c96, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.SharpDX.Desktop.dll:zx_0c5e45288eb34b5233c787be14f95114, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.SharpDX.Direct2D1.dll:zx_62cc9a2c7c5146c21175de2129322f5c, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.SharpDX.Direct3D10.dll:zx_48c695765a374819156fa54c82df6894, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.SharpDX.Direct3D11.dll:zx_598c0255038741755c5f4f500d80ac51, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.SharpDX.Direct3D11.Effects.dll:zx_5ca8d1a1ca954538bcfdc8e2bdf4260b, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.SharpDX.Direct3D9.dll:zx_8bfce6b626244f0f64b290268db1cf14, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.SharpDX.dll:zx_62bcae8a9a214a680d5937f655415335, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.SharpDX.DXGI.dll:zx_7f7be5d04f0642731882ca96d439b664, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.SharpDX.Mathematics.dll:zx_b4ef50aaa94149572466c5b8ea205c54, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.EasyHook32Svc.exe:zx_d03382e7fa0c4d88aa76a23fb4f10586, PublicKeyToken=null|BoosterX.Resources.EmbedRes.EasyHook.EasyHook64Svc.exe:zx_954746246afa48d809fec62deb898f5c, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Exes.Updater.exe:zx_defe7e92c22548ab28bc674ad6088b59, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Exes.Pnp.pnputil.exe:zx_c57f224603364948ea10e9ee435f5cd2, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Exes.ServiceX.exe:zx_a5cce475361c48bc6f8bd5f016c9eef9, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Exes.GameModeX.exe:zx_3a679c8b6a9341658963d8b334784617, PublicKeyToken=null|BoosterX.Services.NvidiaX.CustomSettingNames.json:zx_17c55be6bca84992480b978d2c1ff265, PublicKeyToken=null|BoosterX.Resources.Json.BasicSettingsTweaks.json:zx_0fb36b67ffa042ed58570080f3bb77ac, PublicKeyToken=null|BoosterX.Resources.Json.PowerSettings.json:zx_490c9157df28440a0ae2e4c205d7b4f9, PublicKeyToken=null|BoosterX.Resources.Json.RegistryTweaks.json:zx_e0a613500af2427e560bebc74cbf767b, PublicKeyToken=null|BoosterX.Resources.Json.CleanUp.json:zx_2564a021f5b4494b5e98782f1bed0017, PublicKeyToken=null|BoosterX.Resources.Json.CSGOJsons.CsgoRunCvars.json:zx_c3cbcef73ff64f843d1a7e1439482711, PublicKeyToken=null|BoosterX.Resources.Json.CSGOJsons.CsgoSettingsCvars.json:zx_558b7c3a365d4379babb01d900c62b45, PublicKeyToken=null|BoosterX.Resources.Json.TelemetryJsons.WindowsTelemetry.json:zx_a0dcde47cbd8450a5faa4f5d7d466e7c, PublicKeyToken=null|BoosterX.Resources.Json.Debloat.json:zx_88e6cbbc10164a53486a434c6ad6c975, PublicKeyToken=null|BoosterX.Resources.Json.Tasks.json:zx_500f32dfae7649f140a809cc826a5fc4, PublicKeyToken=null|BoosterX.Resources.Json.DwmTweaks.json:zx_42abef838a5247c729dcd476f2b2613c, PublicKeyToken=null|BoosterX.Resources.Json.Customization.json:zx_c275214d0e78445aeb9912ea3457a3f3, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Debloat.edge.json:zx_1e1ac68660004cacd251e6f263c0a6a3, PublicKeyToken=null|BoosterX.Resources.Json.allServices.json:zx_6a5148299c774bda630de95bb648c1a4, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Defender.enable.bat:zx_74577e1bb6ba41e21f2e58bc486269f7, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Updates.disable.bat:zx_91681012e6004201aeb1b8792b35b382, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Updates.enable.bat:zx_4a19ad15b1f94ec435e29e2fae8d4c6e, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Debloat.DeleteOneDrive.bat:zx_cfd3db16aca9433aa2d1c32e5b03ea68, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Debloat.RemoveEgde.bat:zx_70d378f741df4d3b114922ec51b2d477, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Defender.RemoveDefenderRegs.bat:zx_82ecab4710e94c363f9dbbcfcccf12b7, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Defender.disable.bat:zx_d09a8ec2c15446e0bd422de28971cb88, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Debloat.EdgeRemover2.bat:zx_129b59eecd714d992eebb425a15225fb, PublicKeyToken=null|BoosterX.Resources.EmbedRes.PowerPlans.balance.pow:zx_061c6c6698964cb267c851cdf9f8d29a, PublicKeyToken=null|BoosterX.Resources.EmbedRes.PowerPlans.high.pow:zx_5bad925e928847f219182cb6e2182c77, PublicKeyToken=null|BoosterX.Resources.EmbedRes.PowerPlans.save.pow:zx_9977fe05cbe94d79beef6d0af4284179, PublicKeyToken=null|BoosterX.Resources.EmbedRes.PowerPlans.ultra.pow:zx_ae2b308e118a4a718a149d49145c2c60, PublicKeyToken=null|BoosterX.Resources.EmbedRes.PowerPlans.PowerXv1.pow:zx_1ec207ee69394599633c3a3f86472659, PublicKeyToken=null|BoosterX.Resources.EmbedRes.PowerPlans.PowerXv2.pow:zx_4573291f6ceb40b55b19d83d885acd65, PublicKeyToken=null|BoosterX.Resources.EmbedRes.PowerPlans.PowerXv3BETA.pow:zx_481783c917e540408a3afb38561e45d0, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Nvidia.BestProfile.nvx:zx_36b2a5e4f8be4da55d93d0cc9a718068, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Exes.Pnp.pnputil.exe.mui:zx_1a8c11823ea24596745a4016693efc49, PublicKeyToken=null|BoosterX.App.config:zx_c086b64b02a5432fa64041cf21755480, PublicKeyToken=null|BoosterX.Services.StoreLib.Xml.FE3FileUrl.xml:zx_fc8d97714d2547b968629bb0fc791e73, PublicKeyToken=null|BoosterX.Services.StoreLib.Xml.GetCookie.xml:zx_4d3618d0f2c446d0a0c0af206e698cbd, PublicKeyToken=null|BoosterX.Services.StoreLib.Xml.WUIDRequest.xml:zx_53c5f6c24bfb46d18c44742ac9d98e84, PublicKeyToken=null|BoosterX.Resources.Icon.Logo.ico:zx_75d0034e467c4716f924c58b8c498c0b, PublicKeyToken=null|costura.communitytoolkit.mvvm.dll.compressed:zx_5025efdf6d034451e74e8d619a7c50f3, PublicKeyToken=null|costura.communitytoolkit.mvvm.pdb.compressed:zx_1e176d44a6e54bfe28965cd845a7f922, PublicKeyToken=null|costura.costura.dll.compressed:zx_1912ad4824764ee1f768656db0cb9a9a, PublicKeyToken=null|costura.costura.pdb.compressed:zx_130531344b7c47038a2537c4492b4246, PublicKeyToken=null|costura.discordrpc.dll.compressed:zx_fc48b6facb79452c355db0707426c7d9, PublicKeyToken=null|costura.discordrpc.pdb.compressed:zx_097b12999916444b1df5f121cb21c7fe, PublicKeyToken=null|costura.gameloop.vdf.dll.compressed:zx_63222169084c459136bf6ab9dc78f38e, PublicKeyToken=null|costura.htmlagilitypack.dll.compressed:zx_38788934220e4a539d4926ac44da3e09, PublicKeyToken=null|costura.htmlagilitypack.pdb.compressed:zx_ca687003a19c408e129995a8b466f0df, PublicKeyToken=null|costura.igdb.dll.compressed:zx_912eed85024a45b366ee4f774f72ccfa, PublicKeyToken=null|costura.material.icons.dll.compressed:zx_d9d862855cc0495d2c500fef28f760cf, PublicKeyToken=null|costura.material.icons.wpf.dll.compressed:zx_038ad1729cda4a62d8d7828d77efcb75, PublicKeyToken=null|costura.microsoft.windowsapicodepack.dll.compressed:zx_f7b153059b38462868dbc21a499c16eb, PublicKeyToken=null|costura.microsoft.windowsapicodepack.shell.dll.compressed:zx_33cfcb496cb54ccfc4cc5d738417a545, PublicKeyToken=null|costura.microsoft.bcl.asyncinterfaces.dll.compressed:zx_8a3ae22d1c1246a840eb5b5e56874947, PublicKeyToken=null|costura.microsoft.dism.dll.compressed:zx_b90c0d0a9f50417c023f862c87bc972c, PublicKeyToken=null|costura.microsoft.dism.pdb.compressed:zx_2ad60a9045aa4e6f1293075ee02eeb10, PublicKeyToken=null|costura.microsoft.extensions.configuration.abstractions.dll.compressed:zx_a98163d379db4d5e552c9114f94377c5, PublicKeyToken=null|costura.microsoft.extensions.dependencyinjection.dll.compressed:zx_15e8650684ad415f24b7f3b8fdf88b66, PublicKeyToken=null|costura.microsoft.extensions.dependencyinjection.abstractions.dll.compressed:zx_bbb8c767e5f24b9918379fc03c0b0146, PublicKeyToken=null|costura.microsoft.extensions.http.dll.compressed:zx_6be5eca8d81844b8b4e6131964493782, PublicKeyToken=null|costura.microsoft.extensions.logging.dll.compressed:zx_d644f795dd6641edfbf9118fbdd03dbc, PublicKeyToken=null|costura.microsoft.extensions.logging.abstractions.dll.compressed:zx_307faf5666454169c29f1ff85a1f7314, PublicKeyToken=null|costura.microsoft.extensions.options.dll.compressed:zx_50b702e5ae004c88aee84f61065b4675, PublicKeyToken=null|costura.microsoft.extensions.primitives.dll.compressed:zx_d33705022d014856dcb9c5a28053cf6a, PublicKeyToken=null|costura.microsoft.xaml.behaviors.dll.compressed:zx_0e3d76cb09d94d80a5ebe868de104daf, PublicKeyToken=null|costura.microsoft.xaml.behaviors.pdb.compressed:zx_8e15b77c59ff4f5378beeec097807492, PublicKeyToken=null|costura.newtonsoft.json.dll.compressed:zx_4418bbdc3eff467bf3015f98aa92b6e0, PublicKeyToken=null|costura.oxyplot.dll.compressed:zx_370ed353892247321d6b217cb578922b, PublicKeyToken=null|costura.oxyplot.wpf.dll.compressed:zx_89f56cc921bc44b231d58d0c6fc5abd4, PublicKeyToken=null|costura.oxyplot.wpf.shared.dll.compressed:zx_7cadb413b36345e7024e4eee21d9a223, PublicKeyToken=null|costura.rawinput.sharp.dll.compressed:zx_01b6c363583c4bfa9e179ccfdb374fed, PublicKeyToken=null|costura.restease.dll.compressed:zx_fc1480ec09404de82f4df55de2e4db86, PublicKeyToken=null|costura.system.buffers.dll.compressed:zx_eb8bc8829e50485c9429fb88798f2ce5, PublicKeyToken=null|costura.system.componentmodel.annotations.dll.compressed:zx_7046d83f1c0b48bc7cc0aad793fdd416, PublicKeyToken=null|costura.system.diagnostics.diagnosticsource.dll.compressed:zx_a883fa78019740d1a3cabefe08a68930, PublicKeyToken=null|costura.system.memory.dll.compressed:zx_73c059121280433d189caa41992e775c, PublicKeyToken=null|costura.system.numerics.vectors.dll.compressed:zx_542c35e49d364d1e22789c59b6a8fc1c, PublicKeyToken=null|costura.system.runtime.compilerservices.unsafe.dll.compressed:zx_9a6cfc3cf55a41a16a4ca75d0fa226a2, PublicKeyToken=null|costura.system.threading.tasks.extensions.dll.compressed:zx_774331b375454040c8e6f75fa2bf2da6, PublicKeyToken=null|costura.system.valuetuple.dll.compressed:zx_c4b9c8006a704e889e69d35206c0001a, PublicKeyToken=null|costura.microsoft.win32.taskscheduler.dll.compressed:zx_5f7465aa92414cc2daeb5714fce358f2, PublicKeyToken=null|costura.de.microsoft.win32.taskscheduler.resources.dll.compressed:zx_87c7159c9d2042d2beef1ef718461216, PublicKeyToken=null|costura.es.microsoft.win32.taskscheduler.resources.dll.compressed:zx_c527f69f58ea4c7a11107652254a0f8e, PublicKeyToken=null|costura.fr.microsoft.win32.taskscheduler.resources.dll.compressed:zx_e3e8434d8fc5481a6c62c60685b6df46, PublicKeyToken=null|costura.it.microsoft.win32.taskscheduler.resources.dll.compressed:zx_a032eac647ba4fec5fea1fc7d377cca2, PublicKeyToken=null|costura.pl.microsoft.win32.taskscheduler.resources.dll.compressed:zx_ba139ad77b3545dc80c8159453e01603, PublicKeyToken=null|costura.ru.microsoft.win32.taskscheduler.resources.dll.compressed:zx_e4c689a33c414ce6fd0f14fa039a9468, PublicKeyToken=null|costura.zh-cn.microsoft.win32.taskscheduler.resources.dll.compressed:zx_9b42bb3a73504faff86766447c2a5a16, PublicKeyToken=null|costura.zh-hant.microsoft.win32.taskscheduler.resources.dll.compressed:zx_90f44c916df94b392f61736b536d2496, PublicKeyToken=null|costura.iconextractor.dll.compressed:zx_d4ac10541eb24ae07beb9dd01e26cfcf, PublicKeyToken=null|costura.wincopies.util.dll.compressed:zx_b116cfe6fe76436811337a3f027da556, PublicKeyToken=null|costura.wincopies.windowsapicodepack.win32native.dll.compressed:zx_c45750fc725b494233a05fd1fdf13959, PublicKeyToken=null|costura.wincopies.windowsapicodepack.win32native.consts.dll.compressed:zx_5a42642a87134e316aa422c4df4f3747, PublicKeyToken=null|costura.xamlanimatedgif.dll.compressed:zx_fe52ef10b1c04735109c35d17efcdb26, PublicKeyToken=null|costura.xamlanimatedgif.pdb.compressed:zx_5803805851ec475a99cb1d954d32a463, PublicKeyToken=null|costura.capture.dll.compressed:zx_9c8c8d5197534c9912a5014a11cfee53, PublicKeyToken=null|costura.easyhook.dll.compressed:zx_b4966d9e4d58484c936f253e7afa3db4, PublicKeyToken=null|costura.elevrightsx.dll.compressed:zx_0e8fcad1c64842ef6d3ee71d79cd89bc, PublicKeyToken=null|costura.librehardwaremonitorlib.dll.compressed:zx_904e8e89920a48e69d392e9b9e639fe6, PublicKeyToken=null|costura.microsoft.expression.drawing.dll.compressed:zx_d25290c500a041dd5db8b8ab8cc3bfcc, PublicKeyToken=null|costura.system.management.automation.dll.compressed:zx_f64bee09ea3c479c31aa256ad0a34254, PublicKeyToken=null|costura.sharpdx.dll.compressed:zx_c79b020bb0364e0f1463b0d665f55611, PublicKeyToken=null|costura.sharpdx.direct3d9.dll.compressed|costura.sharpdx.dxgi.dll.compressed|costura.sharpdx.direct3d10.dll.compressed|costura.sharpdx.mathematics.dll.compressed|costura.sharpdx.desktop.dll.compressed|costura.sharpdx.direct3d11.dll.compressed|costura.sharpdx.direct2d1.dll.compressed|costura.sharpdx.direct3d11.effects.dll.compressed|costura.sharpdx.d3dcompiler.dll.compressed|costura.metadata";
					string[] array = text.Split(new char[]
					{
						':'
					});
					int num = array.Length;
					Dictionary<string, Class629.Class630> dictionary = new Dictionary<string, Class629.Class630>(135, StringComparer.Ordinal);
					for (int num2 = 0; num2 != num; num2++)
					{
						string text2 = array[num2];
						string[] array2 = text2.Split(new char[]
						{
							'|'
						});
						Class629.Class630 value = new Class629.Class630(array2[0]);
						int num3 = array2.Length;
						for (int num4 = 1; num4 != num3; num4++)
						{
							string key = array2[num4];
							dictionary.Add(key, value);
						}
					}
					Class629.dictionary_0 = dictionary;
				}
			}
		}
	}

	// Token: 0x04001569 RID: 5481
	private static readonly Assembly assembly_0 = typeof(Class629).Assembly;

	// Token: 0x0400156A RID: 5482
	private static volatile Dictionary<string, Class629.Class630> dictionary_0;

	// Token: 0x0400156B RID: 5483
	[ThreadStatic]
	private static bool bool_0;

	// Token: 0x02000576 RID: 1398
	private sealed class Class630
	{
		// Token: 0x06001E5C RID: 7772 RVA: 0x0007F044 File Offset: 0x0007D244
		internal Class630(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x0007F054 File Offset: 0x0007D254
		internal Assembly method_0()
		{
			if (this.assembly_0 == null)
			{
				lock (this)
				{
					if (this.assembly_0 == null)
					{
						this.assembly_0 = Class629.Class630.smethod_0(this.string_0);
					}
				}
			}
			return this.assembly_0;
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x0007F0B4 File Offset: 0x0007D2B4
		private static Assembly smethod_0(string string_1)
		{
			return Class483.smethod_3(string_1) ?? Assembly.Load(string_1);
		}

		// Token: 0x0400156C RID: 5484
		private readonly string string_0;

		// Token: 0x0400156D RID: 5485
		private volatile Assembly assembly_0;
	}
}
