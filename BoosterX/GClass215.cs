using System;
using System.Collections.Generic;
using System.IO;
using BoosterX.Services.SteamService;

// Token: 0x0200025C RID: 604
public sealed class GClass215 : GClass211
{
	// Token: 0x06000E1C RID: 3612 RVA: 0x0003DB8C File Offset: 0x0003BD8C
	public GClass215(KeyValuePair<string, string> keyValuePair_0)
	{
		this.Name = keyValuePair_0.Key;
		this.ID = keyValuePair_0.Value;
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x06000E1D RID: 3613 RVA: 0x0003DBFC File Offset: 0x0003BDFC
	public string FullName
	{
		get
		{
			return this.Name + " [ID:" + this.ID + "]";
		}
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x06000E1E RID: 3614 RVA: 0x0003DC1C File Offset: 0x0003BE1C
	// (set) Token: 0x06000E1F RID: 3615 RVA: 0x0003DC24 File Offset: 0x0003BE24
	public string Name
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("Name");
		}
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x06000E20 RID: 3616 RVA: 0x0003DC38 File Offset: 0x0003BE38
	// (set) Token: 0x06000E21 RID: 3617 RVA: 0x0003DC40 File Offset: 0x0003BE40
	public string ID
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("ID");
		}
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x06000E22 RID: 3618 RVA: 0x0003DC54 File Offset: 0x0003BE54
	public GClass212 Autoexec
	{
		get
		{
			if (this.gclass212_0 != null)
			{
				return this.gclass212_0;
			}
			this.gclass212_0 = new GClass212(GClass88.smethod_0().method_3() + "\\game\\csgo\\cfg\\autoexec.cfg");
			return this.gclass212_0;
		}
	}

	// Token: 0x17000196 RID: 406
	// (get) Token: 0x06000E23 RID: 3619 RVA: 0x0003DC8C File Offset: 0x0003BE8C
	public List<GClass220> GroupCommands
	{
		get
		{
			if (this.list_0 != null)
			{
				return this.list_0;
			}
			this.list_0 = this.method_4(this.Autoexec);
			return this.list_0;
		}
	}

	// Token: 0x17000197 RID: 407
	// (get) Token: 0x06000E24 RID: 3620 RVA: 0x0003DCB8 File Offset: 0x0003BEB8
	// (set) Token: 0x06000E25 RID: 3621 RVA: 0x0003DCD0 File Offset: 0x0003BED0
	public string CSGOLaunchOptions
	{
		get
		{
			return this.method_1().Replace("  ", " ");
		}
		set
		{
			this.method_2(value);
			base.method_0("CSGOLaunchOptions");
		}
	}

	// Token: 0x06000E26 RID: 3622 RVA: 0x0003DCE4 File Offset: 0x0003BEE4
	private string method_1()
	{
		if (this.vdfManager_0 == null)
		{
			this.vdfManager_0 = new VdfManager(GClass88.smethod_0().method_5() + "\\userdata\\" + this.ID + "\\config\\localconfig.vdf").Read();
		}
		FileStream fileStream = new FileStream(GClass88.smethod_0().method_5() + "\\userdata\\" + this.ID + "\\config\\localconfig.vdf", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
		try
		{
			StreamReader streamReader = new StreamReader(fileStream);
			try
			{
				if (streamReader.ReadToEnd().Contains("\"steam\""))
				{
					this.list_1[2] = "steam";
				}
			}
			finally
			{
				((IDisposable)streamReader).Dispose();
			}
		}
		finally
		{
			((IDisposable)fileStream).Dispose();
		}
		try
		{
			if (this.vdfManager_0.GetValueByPath(this.list_1, "LaunchOptions") == null)
			{
				try
				{
					this.vdfManager_0.SetValueByPath(this.list_1, "LaunchOptions", string.Empty).Write();
				}
				catch
				{
					return string.Empty;
				}
			}
		}
		catch (object obj)
		{
		}
		return this.vdfManager_0.GetValueByPath(this.list_1, "LaunchOptions").TrimEnd(new char[]
		{
			' '
		}).TrimStart(new char[]
		{
			' '
		});
	}

	// Token: 0x06000E27 RID: 3623 RVA: 0x0003DE40 File Offset: 0x0003C040
	private void method_2(string string_2)
	{
		try
		{
			this.vdfManager_0.SetValueByPath(this.list_1, "LaunchOptions", string_2).Write();
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x06000E28 RID: 3624 RVA: 0x0003DE80 File Offset: 0x0003C080
	public List<GClass214> CSGOLaunchOptionsVMs
	{
		get
		{
			if (this.list_2 != null)
			{
				return this.list_2;
			}
			this.list_2 = this.method_3(this);
			return this.list_2;
		}
	}

	// Token: 0x06000E29 RID: 3625 RVA: 0x0003DEA4 File Offset: 0x0003C0A4
	public List<GClass214> method_3(GClass215 gclass215_0)
	{
		return new List<GClass214>
		{
			new GClass214(gclass215_0)
			{
				Name = "startupscreen",
				Icon = 5083,
				Param = "-novid"
			},
			new GClass214(gclass215_0)
			{
				Name = "limitparticles",
				Icon = 2501,
				Param = "-particles 512"
			},
			new GClass214(gclass215_0)
			{
				Name = "joysticksupport",
				Icon = 3434,
				Param = "-nojoy"
			},
			new GClass214(gclass215_0)
			{
				Name = "englishlang",
				Icon = 3,
				Param = "-language english"
			},
			new GClass214(gclass215_0)
			{
				Name = "openconsole",
				Icon = 2080,
				Param = "-console"
			},
			new GClass214(gclass215_0)
			{
				Name = "3partysoftware",
				Icon = 5023,
				Param = "-allow_third_party_software"
			}
		};
	}

	// Token: 0x06000E2A RID: 3626 RVA: 0x0003DFC0 File Offset: 0x0003C1C0
	public List<GClass220> method_4(GClass212 gclass212_1)
	{
		return new List<GClass220>
		{
			new GClass220(gclass212_1)
			{
				Name = "SPUNJBinds",
				Icon = 7241,
				CVars = new List<GClass108>
				{
					new GClass108("bind d \"+right;\""),
					new GClass108("bind a \"+left;\""),
					new GClass108("bind w \"+forward;\""),
					new GClass108("bind s \"+back;\""),
					new GClass108("bind ctrl \"+duck;\""),
					new GClass108("bind shift \"+sprint;\"")
				}
			}
		};
	}

	// Token: 0x040008A7 RID: 2215
	private string string_0;

	// Token: 0x040008A8 RID: 2216
	private string string_1;

	// Token: 0x040008A9 RID: 2217
	private GClass212 gclass212_0;

	// Token: 0x040008AA RID: 2218
	private List<GClass220> list_0;

	// Token: 0x040008AB RID: 2219
	private List<string> list_1 = new List<string>
	{
		"Software",
		"Valve",
		"Steam",
		"apps",
		"730"
	};

	// Token: 0x040008AC RID: 2220
	private VdfManager vdfManager_0;

	// Token: 0x040008AD RID: 2221
	private List<GClass214> list_2;
}
