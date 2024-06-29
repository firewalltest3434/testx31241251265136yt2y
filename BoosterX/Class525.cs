using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BoosterX.Classes.Tweaks.OptimizationTweaks.GlobalTweak;
using ns0;

// Token: 0x0200051D RID: 1309
internal sealed class Class525 : GClass131
{
	// Token: 0x06001CCE RID: 7374 RVA: 0x000749E4 File Offset: 0x00072BE4
	public Class525(GClass179 gclass179_1)
	{
		this.gclass179_0 = gclass179_1;
	}

	// Token: 0x06001CCF RID: 7375 RVA: 0x000749F4 File Offset: 0x00072BF4
	public GClass179 method_6()
	{
		return this.gclass179_0;
	}

	// Token: 0x06001CD0 RID: 7376 RVA: 0x000749FC File Offset: 0x00072BFC
	protected override void RunFunction(object argument)
	{
		Class525.Class604 @class = new Class525.Class604();
		@class.jsonTweakArgument_0 = (JsonTweakArgument)argument;
		base.imethod_1(Class364.smethod_0("Changing") + " \"" + Class364.smethod_0(this.gclass179_0.Name) + "\"", (GEnum93)0);
		bool flag = this.gclass179_0.List_0.Contains("TRUSTED");
		foreach (GClass67 gclass in this.gclass179_0.List_4)
		{
			if (!(gclass.String_0 == "CHECK"))
			{
				if (gclass.String_0 == "EMBEDDEDTWEAK")
				{
					Class608.smethod_0(gclass.Path, @class.jsonTweakArgument_0.NewTweakStatus);
				}
				else
				{
					string text = string.Empty;
					string text2 = string.Empty;
					if (@class.jsonTweakArgument_0.NewTweakStatus == "CUSTOM")
					{
						text2 = "0x" + @class.jsonTweakArgument_0.CustomValue;
					}
					else
					{
						if (gclass.String_0 == "POWER")
						{
							text2 = gclass.Values.First<GClass72>().String_0;
						}
						else if (gclass.String_0 == "SCRIPT")
						{
							text2 = gclass.Values[0].String_0;
						}
						else
						{
							IEnumerable<GClass72> values = gclass.Values;
							Func<GClass72, bool> predicate;
							if ((predicate = @class.func_0) == null)
							{
								predicate = (@class.func_0 = new Func<GClass72, bool>(@class.method_0));
							}
							text2 = values.First(predicate).String_0;
						}
						if (this.gclass179_0.Type == "CUSTOM_VALUE")
						{
							text2 = text2.PadLeft(8, '0');
							text2 = "0x" + text2;
						}
					}
					if (gclass.String_0 == "DEVICE")
					{
						Class137.smethod_0().method_0(gclass.Path, text2 != "Enable");
					}
					else if (gclass.String_0 == "BCDEDIT")
					{
						Class375.smethod_1(gclass.Path, text2);
					}
					else if (gclass.String_0 == "TASK")
					{
						if (text2 == "Enable")
						{
							Class210.smethod_1(gclass.Path);
						}
						else
						{
							Class210.smethod_2(gclass.Path);
						}
					}
					else if (gclass.String_0 == "WEVTUTIL")
					{
						if (text2 == "Enable")
						{
							Class417.smethod_1(gclass.Path);
						}
						else
						{
							Class417.smethod_0(gclass.Path);
						}
					}
					else if (gclass.String_0 == "DISM")
					{
						if (text2 == "Enable")
						{
							Class203.smethod_1(gclass.Path);
						}
						else
						{
							Class203.smethod_2(gclass.Path);
						}
					}
					else if (gclass.String_0 == "EMBEDDED_FILE")
					{
						Class650.smethod_4("BoosterX", Class186.string_4, gclass.Path, text2, false);
						text = Class186.string_4 + "\\" + text2;
						GClass104.smethod_0("cmd.exe /c \"" + text + "\"", false);
						File.Delete(text);
					}
					else if (gclass.String_0 == "POWER")
					{
						Class650.smethod_4("BoosterX", Class186.string_4, gclass.Path, text2, false);
						string text3 = Class186.string_4 + "\\" + text2;
						Class185.smethod_22("powercfg -import \"" + text3 + "\" " + gclass.Key);
						Class185.smethod_22("powercfg -setactive " + gclass.Key);
						File.Delete(text3);
					}
					else
					{
						if (gclass.String_0 == "REG" || gclass.String_0 == "REG_SZ" || gclass.String_0 == "REG_BINARY" || gclass.String_0 == "REG_EXPAND_SZ")
						{
							string text4 = (text2 == "Null") ? "reg delete" : "reg add";
							string string_ = gclass.String_0;
							string text5;
							if (!(string_ == "REG"))
							{
								if (!(string_ == "REG_SZ"))
								{
									if (!(string_ == "REG_BINARY"))
									{
										if (!(string_ == "REG_EXPAND_SZ"))
										{
											throw new NotImplementedException("Invalid tweak type.");
										}
										text5 = "reg_expand_sz";
									}
									else
									{
										text5 = "reg_binary";
									}
								}
								else
								{
									text5 = "reg_sz";
								}
							}
							else
							{
								text5 = "reg_dword";
							}
							string text6 = text5;
							if (gclass.Key == "/ve")
							{
								if (text4 == "reg delete")
								{
									text = text4 + " \"" + gclass.Path + "\" /ve /f";
								}
								else
								{
									text = string.Concat(new string[]
									{
										text4,
										" \"",
										gclass.Path,
										"\" /ve /t ",
										text6,
										" /d \"",
										text2,
										"\" /f"
									});
								}
							}
							else if (gclass.Key == string.Empty && text4 == "reg delete")
							{
								text = text4 + " \"" + gclass.Path + "\" /f";
							}
							else if (text4 == "reg delete")
							{
								text = string.Concat(new string[]
								{
									text4,
									" \"",
									gclass.Path,
									"\" /v \"",
									gclass.Key,
									"\" /f"
								});
							}
							else
							{
								text = string.Concat(new string[]
								{
									text4,
									" \"",
									gclass.Path,
									"\" /v \"",
									gclass.Key,
									"\" /t ",
									text6,
									" /d \"",
									text2,
									"\" /f"
								});
							}
						}
						if (gclass.String_0 == "BAT")
						{
							if (gclass.Path == "cmd64")
							{
								Class185.smethod_26(text2);
							}
							else
							{
								text = text2;
							}
						}
						if (gclass.String_0 == "SCRIPT")
						{
							string text7 = Path.Combine(Class186.string_4, "script.bat");
							Class650.smethod_16(text7, text2, Encoding.GetEncoding("windows-1251"));
							if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_7)
							{
								if (flag)
								{
									GClass104.smethod_1(text7, true);
								}
								else
								{
									Class185.smethod_25(text7);
								}
							}
							else if (flag)
							{
								GClass104.smethod_0(text7, false);
							}
							else
							{
								Class185.smethod_22(text7);
							}
							File.Delete(text7);
						}
						else if (text != string.Empty)
						{
							if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_7)
							{
								if (flag)
								{
									GClass104.smethod_1(text, false);
								}
								else
								{
									Class185.smethod_24(text);
								}
							}
							else if (flag)
							{
								GClass104.smethod_0(text, false);
							}
							else
							{
								Class185.smethod_22(text);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x04001414 RID: 5140
	private GClass179 gclass179_0;

	// Token: 0x0200051E RID: 1310
	private sealed class Class604
	{
		// Token: 0x06001CD2 RID: 7378 RVA: 0x00075190 File Offset: 0x00073390
		internal bool method_0(GClass72 gclass72_0)
		{
			return this.jsonTweakArgument_0.NewTweakStatus != null && gclass72_0.List_0.Contains(this.jsonTweakArgument_0.NewTweakStatus);
		}

		// Token: 0x04001415 RID: 5141
		public JsonTweakArgument jsonTweakArgument_0;

		// Token: 0x04001416 RID: 5142
		public Func<GClass72, bool> func_0;
	}
}
