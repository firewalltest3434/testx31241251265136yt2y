using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using BoosterX.Services.SteamService;
using Microsoft.Win32;

// Token: 0x020002FF RID: 767
public sealed class GClass88
{
	// Token: 0x06001152 RID: 4434 RVA: 0x000493B4 File Offset: 0x000475B4
	public static GClass88 smethod_0()
	{
		if (GClass88.gclass88_0 == null)
		{
			GClass88.gclass88_0 = new GClass88();
		}
		return GClass88.gclass88_0;
	}

	// Token: 0x06001153 RID: 4435 RVA: 0x000493CC File Offset: 0x000475CC
	public Dictionary<string, string> method_0()
	{
		if (this.dictionary_0.Count == 0)
		{
			foreach (string text in this.method_9())
			{
				try
				{
					VdfManager vdfManager = new VdfManager(this.method_5() + "\\userdata\\" + text + "\\config\\localconfig.vdf").Read();
					this.dictionary_0.Add(vdfManager.GetValueByPath(new List<string>
					{
						"friends"
					}, "PersonaName"), text.ToString());
				}
				catch (object obj)
				{
				}
			}
		}
		return this.dictionary_0;
	}

	// Token: 0x06001154 RID: 4436 RVA: 0x00049490 File Offset: 0x00047690
	public string method_1()
	{
		return this.string_0;
	}

	// Token: 0x06001155 RID: 4437 RVA: 0x00049498 File Offset: 0x00047698
	public void method_2(string string_4)
	{
		this.string_0 = string_4;
	}

	// Token: 0x06001156 RID: 4438 RVA: 0x000494A4 File Offset: 0x000476A4
	public string method_3()
	{
		return this.string_1;
	}

	// Token: 0x06001157 RID: 4439 RVA: 0x000494AC File Offset: 0x000476AC
	public void method_4(string string_4)
	{
		this.string_1 = string_4;
	}

	// Token: 0x06001158 RID: 4440 RVA: 0x000494B8 File Offset: 0x000476B8
	public string method_5()
	{
		return this.string_2;
	}

	// Token: 0x06001159 RID: 4441 RVA: 0x000494C0 File Offset: 0x000476C0
	public void method_6(string string_4)
	{
		this.string_2 = string_4;
	}

	// Token: 0x0600115A RID: 4442 RVA: 0x000494CC File Offset: 0x000476CC
	public string method_7()
	{
		return this.string_3;
	}

	// Token: 0x0600115B RID: 4443 RVA: 0x000494D4 File Offset: 0x000476D4
	public void method_8(string string_4)
	{
		this.string_3 = string_4;
	}

	// Token: 0x0600115C RID: 4444 RVA: 0x000494E0 File Offset: 0x000476E0
	public List<string> method_9()
	{
		return this.list_0;
	}

	// Token: 0x0600115D RID: 4445 RVA: 0x000494E8 File Offset: 0x000476E8
	public void method_10(List<string> list_1)
	{
		this.list_0 = list_1;
	}

	// Token: 0x0600115E RID: 4446 RVA: 0x000494F4 File Offset: 0x000476F4
	public string method_11()
	{
		string text = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamPath", string.Empty);
		string path = Path.Combine(text, "steamapps", "libraryfolders.vdf");
		if (!File.Exists(path))
		{
			return null;
		}
		List<string> list = new List<string>
		{
			Path.Combine(new string[]
			{
				text
			})
		};
		string[] array = File.ReadAllLines(path);
		Regex regex = new Regex("\\\"(([^\\\"]*):\\\\([^\\\"]*))\\\"");
		foreach (string input in array)
		{
			if (regex.IsMatch(input))
			{
				string value = regex.Matches(input)[0].Groups[1].Value;
				list.Add(value.Replace("\\\\", "\\"));
			}
		}
		foreach (string path2 in list)
		{
			string text2 = Path.Combine(path2, "steamapps\\common\\Counter-Strike Global Offensive");
			if (Directory.Exists(text2))
			{
				return text2.ToString();
			}
		}
		return null;
	}

	// Token: 0x0600115F RID: 4447 RVA: 0x00049640 File Offset: 0x00047840
	public string method_12()
	{
		return (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamPath", string.Empty);
	}

	// Token: 0x06001160 RID: 4448 RVA: 0x0004965C File Offset: 0x0004785C
	public List<string> method_13()
	{
		List<string> list = new List<string>();
		foreach (string text in Directory.GetDirectories(this.method_12() + "\\userdata"))
		{
			list.Add(text.Split(new char[]
			{
				'\\'
			}).Last<string>());
		}
		return list;
	}

	// Token: 0x04000A8F RID: 2703
	private static GClass88 gclass88_0;

	// Token: 0x04000A90 RID: 2704
	private Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();

	// Token: 0x04000A91 RID: 2705
	private string string_0 = string.Empty;

	// Token: 0x04000A92 RID: 2706
	private string string_1;

	// Token: 0x04000A93 RID: 2707
	private string string_2;

	// Token: 0x04000A94 RID: 2708
	private string string_3;

	// Token: 0x04000A95 RID: 2709
	private List<string> list_0;
}
