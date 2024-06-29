using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

// Token: 0x02000616 RID: 1558
internal sealed class Class694
{
	// Token: 0x060021B6 RID: 8630 RVA: 0x00088240 File Offset: 0x00086440
	private static void smethod_0()
	{
		try
		{
			if (Class694.gclass99_0 == null)
			{
				Class694.gclass99_0 = new GClass99();
			}
		}
		catch (object obj)
		{
		}
		if (Class694.bool_0)
		{
			return;
		}
		if (!Directory.Exists(Class186.string_11))
		{
			Directory.CreateDirectory(Class186.string_11);
		}
		if (!Directory.Exists(Class186.string_12))
		{
			Directory.CreateDirectory(Class186.string_12);
		}
		Class694.string_0 = "\"" + Path.Combine(Class186.string_11, "pnputil.exe") + "\"";
		if (!File.Exists(Path.Combine(Class186.string_11, "pnputil.exe")))
		{
			Class650.smethod_4("BoosterX", Class186.string_11, "Resources.EmbedRes.Exes.Pnp", "pnputil.exe", false);
		}
		if (!File.Exists(Path.Combine(Class186.string_12, "pnputil.exe.mui")))
		{
			Class650.smethod_4("BoosterX", Class186.string_12, "Resources.EmbedRes.Exes.Pnp", "pnputil.exe.mui", false);
		}
		Class694.bool_0 = true;
	}

	// Token: 0x060021B7 RID: 8631 RVA: 0x0008834C File Offset: 0x0008654C
	public static List<GClass116> smethod_1()
	{
		return Class694.smethod_3("/enum-devices /disconnected");
	}

	// Token: 0x060021B8 RID: 8632 RVA: 0x00088358 File Offset: 0x00086558
	public static List<GClass116> smethod_2()
	{
		return Class694.smethod_3("/enum-devices");
	}

	// Token: 0x060021B9 RID: 8633 RVA: 0x00088364 File Offset: 0x00086564
	private static List<GClass116> smethod_3(string string_1)
	{
		List<GClass116> result;
		try
		{
			Class694.smethod_0();
			Process process = new Process();
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.FileName = "cmd";
			process.StartInfo.Arguments = "/c chcp 437 & " + Class694.string_0 + " " + string_1;
			process.Start();
			string text = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			text = text.Replace("Active code page: 437\r\nMicrosoft PnP Utility\r\n\r\n", string.Empty);
			string text2 = string.Empty;
			foreach (string text3 in text.Split(new char[]
			{
				'\n'
			}))
			{
				if (text3.smethod_7())
				{
					text2 += "\n";
				}
				else
				{
					string str = text3.Split(new char[]
					{
						':'
					}).First<string>();
					string text4 = text3.Replace(str + ":", string.Empty);
					if (text4.StartsWith(" ") || text4.StartsWith("\t"))
					{
						int j;
						for (j = 0; j < text4.Length; j++)
						{
							if (text4[j] != ' ')
							{
								break;
							}
						}
						text4 = text4.Substring(j);
					}
					text2 = text2 + text4 + "\n";
				}
			}
			string[] separator = new string[]
			{
				"\r\n\r\n"
			};
			List<string> list = text2.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
			List<GClass116> list2 = new List<GClass116>();
			foreach (string text5 in list)
			{
				if (text5.Split(new char[]
				{
					'\n'
				}).Count<string>() == 7)
				{
					List<GClass116> list3 = list2;
					GClass116 gclass = new GClass116();
					gclass.method_1(text5.smethod_1(0));
					gclass.Name = text5.smethod_1(1);
					gclass.method_3(text5.smethod_1(2));
					gclass.method_5(text5.smethod_1(3));
					gclass.method_7(text5.smethod_1(4));
					gclass.Status = text5.smethod_1(5);
					gclass.method_9(text5.smethod_1(6));
					gclass.method_15(Class137.smethod_0().method_3(text5.smethod_1(0)));
					gclass.method_17(!Class137.smethod_0().method_4(text5.smethod_1(0)));
					list3.Add(gclass);
				}
				else if (text5.Split(new char[]
				{
					'\n'
				}).Count<string>() == 6)
				{
					List<GClass116> list4 = list2;
					GClass116 gclass2 = new GClass116();
					gclass2.method_1(text5.smethod_1(0));
					gclass2.Name = text5.smethod_1(1);
					gclass2.method_3(text5.smethod_1(2));
					gclass2.method_5(text5.smethod_1(3));
					gclass2.method_7(text5.smethod_1(4));
					gclass2.Status = text5.smethod_1(5);
					gclass2.method_15(Class137.smethod_0().method_3(text5.smethod_1(0)));
					gclass2.method_17(!Class137.smethod_0().method_4(text5.smethod_1(0)));
					list4.Add(gclass2);
				}
				else if (text5.Split(new char[]
				{
					'\n'
				}).Count<string>() == 8)
				{
					List<GClass116> list5 = list2;
					GClass116 gclass3 = new GClass116();
					gclass3.method_1(text5.smethod_1(0));
					gclass3.Name = text5.smethod_1(1);
					gclass3.method_3(text5.smethod_1(2));
					gclass3.method_5(text5.smethod_1(3));
					gclass3.method_7(text5.smethod_1(4));
					gclass3.method_9(text5.smethod_1(6));
					gclass3.Status = text5.smethod_1(5);
					gclass3.method_11(text5.smethod_1(6));
					gclass3.method_13(text5.smethod_1(7));
					gclass3.method_15(Class137.smethod_0().method_3(text5.smethod_1(0)));
					gclass3.method_17(!Class137.smethod_0().method_4(text5.smethod_1(0)));
					list5.Add(gclass3);
				}
			}
			result = list2;
		}
		catch
		{
			result = new List<GClass116>();
		}
		return result;
	}

	// Token: 0x060021BA RID: 8634 RVA: 0x000887D0 File Offset: 0x000869D0
	public static void smethod_4(string string_1)
	{
		try
		{
			Class694.smethod_0();
			Class185.smethod_3(Class694.string_0, "/remove-device \"" + string_1 + "\"");
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x060021BB RID: 8635 RVA: 0x00088814 File Offset: 0x00086A14
	public static void smethod_5(string string_1)
	{
		Class694.Class695 @class = new Class694.Class695();
		@class.string_0 = string_1;
		Class694.smethod_0();
		try
		{
			Class185.smethod_3(Class694.string_0, "/disable-device \"" + @class.string_0 + "\"");
			Class694.gclass99_0.method_1(new GStruct5
			{
				string_2 = @class.string_0
			}, false);
			string text = GClass127.list_0.First(new Func<string, bool>(@class.method_0));
			if (!text.smethod_7())
			{
				Class185.smethod_3(Class694.string_0, "/disable-device \"" + text + "\"");
				Class694.gclass99_0.method_1(new GStruct5
				{
					string_2 = text
				}, false);
			}
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x060021BC RID: 8636 RVA: 0x000888E0 File Offset: 0x00086AE0
	public static void smethod_6(string string_1)
	{
		Class694.Class696 @class = new Class694.Class696();
		@class.string_0 = string_1;
		Class694.smethod_0();
		try
		{
			Class185.smethod_3(Class694.string_0, "/enable-device \"" + @class.string_0 + "\"");
			Class694.gclass99_0.method_1(new GStruct5
			{
				string_2 = @class.string_0
			}, true);
			string text = GClass127.list_0.First(new Func<string, bool>(@class.method_0));
			if (!text.smethod_7())
			{
				Class185.smethod_3(Class694.string_0, "/enable-device \"" + text + "\"");
				Class694.gclass99_0.method_1(new GStruct5
				{
					string_2 = text
				}, true);
			}
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x04001727 RID: 5927
	private static GClass99 gclass99_0;

	// Token: 0x04001728 RID: 5928
	private static string string_0 = string.Empty;

	// Token: 0x04001729 RID: 5929
	private static bool bool_0 = false;

	// Token: 0x02000617 RID: 1559
	private sealed class Class695
	{
		// Token: 0x060021BE RID: 8638 RVA: 0x000889B4 File Offset: 0x00086BB4
		internal bool method_0(string string_1)
		{
			return this.string_0.ToLower().StartsWith(string_1.ToLower());
		}

		// Token: 0x0400172A RID: 5930
		public string string_0;
	}

	// Token: 0x02000618 RID: 1560
	private sealed class Class696
	{
		// Token: 0x060021C0 RID: 8640 RVA: 0x000889D4 File Offset: 0x00086BD4
		internal bool method_0(string string_1)
		{
			return this.string_0.ToLower().StartsWith(string_1.ToLower());
		}

		// Token: 0x0400172B RID: 5931
		public string string_0;
	}
}
