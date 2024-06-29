using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Threading;

// Token: 0x020002FC RID: 764
internal static class Class374
{
	// Token: 0x06001141 RID: 4417 RVA: 0x00048894 File Offset: 0x00046A94
	// Note: this type is marked as 'beforefieldinit'.
	static Class374()
	{
		Class374.dictionary_1.Add("capture", "costura.capture.dll.compressed");
		Class374.dictionary_1.Add("communitytoolkit.mvvm", "costura.communitytoolkit.mvvm.dll.compressed");
		Class374.dictionary_2.Add("communitytoolkit.mvvm", "costura.communitytoolkit.mvvm.pdb.compressed");
		Class374.dictionary_1.Add("costura", "costura.costura.dll.compressed");
		Class374.dictionary_2.Add("costura", "costura.costura.pdb.compressed");
		Class374.dictionary_1.Add("de.microsoft.win32.taskscheduler.resources", "costura.de.microsoft.win32.taskscheduler.resources.dll.compressed");
		Class374.dictionary_1.Add("discordrpc", "costura.discordrpc.dll.compressed");
		Class374.dictionary_2.Add("discordrpc", "costura.discordrpc.pdb.compressed");
		Class374.dictionary_1.Add("easyhook", "costura.easyhook.dll.compressed");
		Class374.dictionary_1.Add("elevrightsx", "costura.elevrightsx.dll.compressed");
		Class374.dictionary_1.Add("es.microsoft.win32.taskscheduler.resources", "costura.es.microsoft.win32.taskscheduler.resources.dll.compressed");
		Class374.dictionary_1.Add("fr.microsoft.win32.taskscheduler.resources", "costura.fr.microsoft.win32.taskscheduler.resources.dll.compressed");
		Class374.dictionary_1.Add("gameloop.vdf", "costura.gameloop.vdf.dll.compressed");
		Class374.dictionary_1.Add("htmlagilitypack", "costura.htmlagilitypack.dll.compressed");
		Class374.dictionary_2.Add("htmlagilitypack", "costura.htmlagilitypack.pdb.compressed");
		Class374.dictionary_1.Add("iconextractor", "costura.iconextractor.dll.compressed");
		Class374.dictionary_1.Add("igdb", "costura.igdb.dll.compressed");
		Class374.dictionary_1.Add("it.microsoft.win32.taskscheduler.resources", "costura.it.microsoft.win32.taskscheduler.resources.dll.compressed");
		Class374.dictionary_1.Add("librehardwaremonitorlib", "costura.librehardwaremonitorlib.dll.compressed");
		Class374.dictionary_1.Add("material.icons", "costura.material.icons.dll.compressed");
		Class374.dictionary_1.Add("material.icons.wpf", "costura.material.icons.wpf.dll.compressed");
		Class374.dictionary_1.Add("microsoft.bcl.asyncinterfaces", "costura.microsoft.bcl.asyncinterfaces.dll.compressed");
		Class374.dictionary_1.Add("microsoft.dism", "costura.microsoft.dism.dll.compressed");
		Class374.dictionary_2.Add("microsoft.dism", "costura.microsoft.dism.pdb.compressed");
		Class374.dictionary_1.Add("microsoft.expression.drawing", "costura.microsoft.expression.drawing.dll.compressed");
		Class374.dictionary_1.Add("microsoft.extensions.configuration.abstractions", "costura.microsoft.extensions.configuration.abstractions.dll.compressed");
		Class374.dictionary_1.Add("microsoft.extensions.dependencyinjection.abstractions", "costura.microsoft.extensions.dependencyinjection.abstractions.dll.compressed");
		Class374.dictionary_1.Add("microsoft.extensions.dependencyinjection", "costura.microsoft.extensions.dependencyinjection.dll.compressed");
		Class374.dictionary_1.Add("microsoft.extensions.http", "costura.microsoft.extensions.http.dll.compressed");
		Class374.dictionary_1.Add("microsoft.extensions.logging.abstractions", "costura.microsoft.extensions.logging.abstractions.dll.compressed");
		Class374.dictionary_1.Add("microsoft.extensions.logging", "costura.microsoft.extensions.logging.dll.compressed");
		Class374.dictionary_1.Add("microsoft.extensions.options", "costura.microsoft.extensions.options.dll.compressed");
		Class374.dictionary_1.Add("microsoft.extensions.primitives", "costura.microsoft.extensions.primitives.dll.compressed");
		Class374.dictionary_1.Add("microsoft.win32.taskscheduler", "costura.microsoft.win32.taskscheduler.dll.compressed");
		Class374.dictionary_1.Add("microsoft.windowsapicodepack", "costura.microsoft.windowsapicodepack.dll.compressed");
		Class374.dictionary_1.Add("microsoft.windowsapicodepack.shell", "costura.microsoft.windowsapicodepack.shell.dll.compressed");
		Class374.dictionary_1.Add("microsoft.xaml.behaviors", "costura.microsoft.xaml.behaviors.dll.compressed");
		Class374.dictionary_2.Add("microsoft.xaml.behaviors", "costura.microsoft.xaml.behaviors.pdb.compressed");
		Class374.dictionary_1.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
		Class374.dictionary_1.Add("oxyplot", "costura.oxyplot.dll.compressed");
		Class374.dictionary_1.Add("oxyplot.wpf", "costura.oxyplot.wpf.dll.compressed");
		Class374.dictionary_1.Add("oxyplot.wpf.shared", "costura.oxyplot.wpf.shared.dll.compressed");
		Class374.dictionary_1.Add("pl.microsoft.win32.taskscheduler.resources", "costura.pl.microsoft.win32.taskscheduler.resources.dll.compressed");
		Class374.dictionary_1.Add("rawinput.sharp", "costura.rawinput.sharp.dll.compressed");
		Class374.dictionary_1.Add("restease", "costura.restease.dll.compressed");
		Class374.dictionary_1.Add("ru.microsoft.win32.taskscheduler.resources", "costura.ru.microsoft.win32.taskscheduler.resources.dll.compressed");
		Class374.dictionary_1.Add("sharpdx.d3dcompiler", "costura.sharpdx.d3dcompiler.dll.compressed");
		Class374.dictionary_1.Add("sharpdx.desktop", "costura.sharpdx.desktop.dll.compressed");
		Class374.dictionary_1.Add("sharpdx.direct2d1", "costura.sharpdx.direct2d1.dll.compressed");
		Class374.dictionary_1.Add("sharpdx.direct3d10", "costura.sharpdx.direct3d10.dll.compressed");
		Class374.dictionary_1.Add("sharpdx.direct3d11", "costura.sharpdx.direct3d11.dll.compressed");
		Class374.dictionary_1.Add("sharpdx.direct3d11.effects", "costura.sharpdx.direct3d11.effects.dll.compressed");
		Class374.dictionary_1.Add("sharpdx.direct3d9", "costura.sharpdx.direct3d9.dll.compressed");
		Class374.dictionary_1.Add("sharpdx", "costura.sharpdx.dll.compressed");
		Class374.dictionary_1.Add("sharpdx.dxgi", "costura.sharpdx.dxgi.dll.compressed");
		Class374.dictionary_1.Add("sharpdx.mathematics", "costura.sharpdx.mathematics.dll.compressed");
		Class374.dictionary_1.Add("system.buffers", "costura.system.buffers.dll.compressed");
		Class374.dictionary_1.Add("system.componentmodel.annotations", "costura.system.componentmodel.annotations.dll.compressed");
		Class374.dictionary_1.Add("system.diagnostics.diagnosticsource", "costura.system.diagnostics.diagnosticsource.dll.compressed");
		Class374.dictionary_1.Add("system.management.automation", "costura.system.management.automation.dll.compressed");
		Class374.dictionary_1.Add("system.memory", "costura.system.memory.dll.compressed");
		Class374.dictionary_1.Add("system.numerics.vectors", "costura.system.numerics.vectors.dll.compressed");
		Class374.dictionary_1.Add("system.runtime.compilerservices.unsafe", "costura.system.runtime.compilerservices.unsafe.dll.compressed");
		Class374.dictionary_1.Add("system.threading.tasks.extensions", "costura.system.threading.tasks.extensions.dll.compressed");
		Class374.dictionary_1.Add("system.valuetuple", "costura.system.valuetuple.dll.compressed");
		Class374.dictionary_1.Add("wincopies.util", "costura.wincopies.util.dll.compressed");
		Class374.dictionary_1.Add("wincopies.windowsapicodepack.win32native.consts", "costura.wincopies.windowsapicodepack.win32native.consts.dll.compressed");
		Class374.dictionary_1.Add("wincopies.windowsapicodepack.win32native", "costura.wincopies.windowsapicodepack.win32native.dll.compressed");
		Class374.dictionary_1.Add("xamlanimatedgif", "costura.xamlanimatedgif.dll.compressed");
		Class374.dictionary_2.Add("xamlanimatedgif", "costura.xamlanimatedgif.pdb.compressed");
		Class374.dictionary_1.Add("zh-cn.microsoft.win32.taskscheduler.resources", "costura.zh-cn.microsoft.win32.taskscheduler.resources.dll.compressed");
		Class374.dictionary_1.Add("zh-hant.microsoft.win32.taskscheduler.resources", "costura.zh-hant.microsoft.win32.taskscheduler.resources.dll.compressed");
	}

	// Token: 0x06001142 RID: 4418 RVA: 0x00048E6C File Offset: 0x0004706C
	private static string smethod_0(CultureInfo cultureInfo_0)
	{
		if (cultureInfo_0 == null)
		{
			return string.Empty;
		}
		return cultureInfo_0.Name;
	}

	// Token: 0x06001143 RID: 4419 RVA: 0x00048E80 File Offset: 0x00047080
	private static Assembly smethod_1(AssemblyName assemblyName_0)
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		Assembly[] assemblies = currentDomain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			AssemblyName name = assembly.GetName();
			if (string.Equals(name.Name, assemblyName_0.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(Class374.smethod_0(name.CultureInfo), Class374.smethod_0(assemblyName_0.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
			{
				return assembly;
			}
		}
		return null;
	}

	// Token: 0x06001144 RID: 4420 RVA: 0x00048EFC File Offset: 0x000470FC
	private static void smethod_2(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[81920];
		int count;
		while ((count = stream_0.Read(array, 0, array.Length)) != 0)
		{
			stream_1.Write(array, 0, count);
		}
	}

	// Token: 0x06001145 RID: 4421 RVA: 0x00048F30 File Offset: 0x00047130
	private static Stream smethod_3(string string_0)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (string_0.EndsWith(".compressed"))
		{
			Stream result;
			using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(string_0))
			{
				DeflateStream deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress);
				try
				{
					MemoryStream memoryStream = new MemoryStream();
					Class374.smethod_2(deflateStream, memoryStream);
					memoryStream.Position = 0L;
					result = memoryStream;
				}
				finally
				{
					((IDisposable)deflateStream).Dispose();
				}
			}
			return result;
		}
		return executingAssembly.GetManifestResourceStream(string_0);
	}

	// Token: 0x06001146 RID: 4422 RVA: 0x00048FB8 File Offset: 0x000471B8
	private static Stream smethod_4(Dictionary<string, string> dictionary_3, string string_0)
	{
		string string_;
		if (dictionary_3.TryGetValue(string_0, out string_))
		{
			return Class374.smethod_3(string_);
		}
		return null;
	}

	// Token: 0x06001147 RID: 4423 RVA: 0x00048FD8 File Offset: 0x000471D8
	private static byte[] smethod_5(Stream stream_0)
	{
		byte[] array = new byte[stream_0.Length];
		stream_0.Read(array, 0, array.Length);
		return array;
	}

	// Token: 0x06001148 RID: 4424 RVA: 0x00049000 File Offset: 0x00047200
	private static Assembly smethod_6(Dictionary<string, string> dictionary_3, Dictionary<string, string> dictionary_4, AssemblyName assemblyName_0)
	{
		string text = assemblyName_0.Name.ToLowerInvariant();
		if (assemblyName_0.CultureInfo != null && !string.IsNullOrEmpty(assemblyName_0.CultureInfo.Name))
		{
			text = assemblyName_0.CultureInfo.Name + "." + text;
		}
		byte[] rawAssembly;
		using (Stream stream = Class374.smethod_4(dictionary_3, text))
		{
			if (stream == null)
			{
				return null;
			}
			rawAssembly = Class374.smethod_5(stream);
		}
		using (Stream stream2 = Class374.smethod_4(dictionary_4, text))
		{
			if (stream2 != null)
			{
				byte[] rawSymbolStore = Class374.smethod_5(stream2);
				return Assembly.Load(rawAssembly, rawSymbolStore);
			}
		}
		return Assembly.Load(rawAssembly);
	}

	// Token: 0x06001149 RID: 4425 RVA: 0x000490C0 File Offset: 0x000472C0
	public static Assembly smethod_7(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		object obj = Class374.object_0;
		lock (obj)
		{
			if (Class374.dictionary_0.ContainsKey(resolveEventArgs_0.Name))
			{
				return null;
			}
		}
		AssemblyName assemblyName = new AssemblyName(resolveEventArgs_0.Name);
		Assembly assembly = Class374.smethod_1(assemblyName);
		if (assembly != null)
		{
			return assembly;
		}
		assembly = Class374.smethod_6(Class374.dictionary_1, Class374.dictionary_2, assemblyName);
		if (assembly == null)
		{
			object obj2 = Class374.object_0;
			lock (obj2)
			{
				Class374.dictionary_0[resolveEventArgs_0.Name] = true;
			}
			if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
			{
				assembly = Assembly.Load(assemblyName);
			}
		}
		return assembly;
	}

	// Token: 0x0600114A RID: 4426 RVA: 0x00049194 File Offset: 0x00047394
	public static void smethod_8()
	{
		if (Interlocked.Exchange(ref Class374.int_0, 1) == 1)
		{
			return;
		}
		AppDomain currentDomain = AppDomain.CurrentDomain;
		currentDomain.AssemblyResolve += Class374.smethod_7;
	}

	// Token: 0x04000A8A RID: 2698
	private static object object_0 = new object();

	// Token: 0x04000A8B RID: 2699
	private static Dictionary<string, bool> dictionary_0 = new Dictionary<string, bool>();

	// Token: 0x04000A8C RID: 2700
	private static Dictionary<string, string> dictionary_1 = new Dictionary<string, string>();

	// Token: 0x04000A8D RID: 2701
	private static Dictionary<string, string> dictionary_2 = new Dictionary<string, string>();

	// Token: 0x04000A8E RID: 2702
	private static int int_0;
}
