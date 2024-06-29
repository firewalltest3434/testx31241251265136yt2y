using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using BoosterX.Services.SteamService;
using Gameloop.Vdf;
using Gameloop.Vdf.Linq;

// Token: 0x02000340 RID: 832
public sealed class GClass218 : GClass211
{
	// Token: 0x060012DC RID: 4828 RVA: 0x0004D460 File Offset: 0x0004B660
	public GClass218(string string_1)
	{
		if (!File.Exists(string_1))
		{
			if (!Directory.Exists(Path.GetDirectoryName(string_1)))
			{
				Directory.CreateDirectory(Path.GetDirectoryName(string_1));
			}
			File.Create(string_1).FlushAsync();
		}
		this.FilePath = string_1;
		this.method_7(string_1);
	}

	// Token: 0x1700026A RID: 618
	// (get) Token: 0x060012DD RID: 4829 RVA: 0x0004D4C4 File Offset: 0x0004B6C4
	// (set) Token: 0x060012DE RID: 4830 RVA: 0x0004D4CC File Offset: 0x0004B6CC
	public string FilePath
	{
		[CompilerGenerated]
		get
		{
			return this.string_0;
		}
		[CompilerGenerated]
		private set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x1700026B RID: 619
	// (get) Token: 0x060012DF RID: 4831 RVA: 0x0004D4D8 File Offset: 0x0004B6D8
	// (set) Token: 0x060012E0 RID: 4832 RVA: 0x0004D4E0 File Offset: 0x0004B6E0
	public Encoding Encoding
	{
		[CompilerGenerated]
		get
		{
			return this.encoding_0;
		}
		[CompilerGenerated]
		set
		{
			this.encoding_0 = value;
		}
	}

	// Token: 0x060012E1 RID: 4833 RVA: 0x0004D4EC File Offset: 0x0004B6EC
	public void method_1()
	{
		this.list_0.Clear();
		this.method_6();
	}

	// Token: 0x060012E2 RID: 4834 RVA: 0x0004D500 File Offset: 0x0004B700
	public void method_2(GClass108 gclass108_0)
	{
		GClass218.Class385 @class = new GClass218.Class385();
		@class.gclass108_0 = gclass108_0;
		if (this.list_0 != null && this.list_0.Any(new Func<GClass108, bool>(@class.method_0)))
		{
			this.list_0.Find(new Predicate<GClass108>(@class.method_1)).method_1(@class.gclass108_0.method_0());
		}
		this.list_0.Add(@class.gclass108_0);
		this.method_8();
	}

	// Token: 0x060012E3 RID: 4835 RVA: 0x0004D57C File Offset: 0x0004B77C
	public void method_3(GClass108 gclass108_0)
	{
		GClass218.Class386 @class = new GClass218.Class386();
		@class.gclass108_0 = gclass108_0;
		if (this.list_0 == null || this.list_0.Count == 0)
		{
			return;
		}
		if (this.list_0.Any(new Func<GClass108, bool>(@class.method_0)))
		{
			this.list_0.Remove(this.list_0.Find(new Predicate<GClass108>(@class.method_1)));
			base.method_0("CVars");
			this.method_8();
			return;
		}
		this.list_0.Remove(@class.gclass108_0);
		this.method_8();
	}

	// Token: 0x060012E4 RID: 4836 RVA: 0x0004D614 File Offset: 0x0004B814
	public void method_4(int int_0)
	{
		this.list_0.RemoveAt(int_0);
	}

	// Token: 0x060012E5 RID: 4837 RVA: 0x0004D624 File Offset: 0x0004B824
	public void method_5<CVars>(CVars gparam_0) where CVars : IEnumerable<GClass108>
	{
		this.list_0 = gparam_0.ToList<GClass108>();
	}

	// Token: 0x060012E6 RID: 4838 RVA: 0x0004D638 File Offset: 0x0004B838
	public void method_6()
	{
		this.method_7(this.FilePath);
	}

	// Token: 0x060012E7 RID: 4839 RVA: 0x0004D648 File Offset: 0x0004B848
	public void method_7(string string_1)
	{
		if (string_1 != this.FilePath)
		{
			this.FilePath = string_1;
		}
		VToken vtoken = VdfConvert.Deserialize(File.ReadAllText(string_1))["config"]["convars"];
	}

	// Token: 0x060012E8 RID: 4840 RVA: 0x0004D680 File Offset: 0x0004B880
	public void method_8()
	{
		this.method_9(this.FilePath);
	}

	// Token: 0x060012E9 RID: 4841 RVA: 0x0004D690 File Offset: 0x0004B890
	public void method_9(string string_1)
	{
		FileStream fileStream = new FileStream(string_1, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
		try
		{
			if (fileStream.Length > 0L)
			{
				fileStream.SetLength(0L);
			}
			byte[] array = this.method_10();
			int num = 0;
			int i = array.Length;
			while (i > 0)
			{
				int num2 = (i > 14456) ? 14456 : i;
				fileStream.Write(array, num, num2);
				i -= num2;
				num += num2;
			}
			fileStream.Close();
		}
		finally
		{
			((IDisposable)fileStream).Dispose();
		}
	}

	// Token: 0x060012EA RID: 4842 RVA: 0x0004D734 File Offset: 0x0004B934
	public byte[] method_10()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (GClass108 arg in this.list_0)
		{
			stringBuilder.Append(string.Format("{0}\n", arg));
		}
		return this.Encoding.GetBytes(stringBuilder.ToString());
	}

	// Token: 0x060012EB RID: 4843 RVA: 0x0004D7AC File Offset: 0x0004B9AC
	public void method_11()
	{
		if (this.list_0.Count > 0)
		{
			this.list_0.Clear();
		}
		this.list_0 = new List<GClass108>
		{
			new GClass108("viewmodel_fov", 68),
			new GClass108("viewmodel_offset_x", 2.5),
			new GClass108("viewmodel_offset_y", 0),
			new GClass108("viewmodel_offset_z", -1.5),
			new GClass108("viewmodel_recoil", 0),
			new GClass108("viewmodel_presetpos", 3),
			new GClass108("cl_viewmodel_shift_left_amt", 1.5),
			new GClass108("cl_viewmodel_shift_right_amt", 0.75),
			new GClass108("cl_bob_lower_amt", 21),
			new GClass108("cl_bobamt_lat", 0.33),
			new GClass108("cl_bobamt_vert", 0.14),
			new GClass108("cl_bobcycle", 0.98),
			new GClass108("cl_autowepswitch", 0),
			new GClass108("cl_crosshair_outlinethickness", 1),
			new GClass108("cl_autohelp", 0),
			new GClass108("cl_showhelp", 0),
			new GClass108("cl_cmdrate", 128),
			new GClass108("cl_updaterate", 128),
			new GClass108("cl_interp_ratio", 1),
			new GClass108("cl_interp", 0),
			new GClass108("cl_lagcompensation", 1),
			new GClass108("cl_predict", 1),
			new GClass108("cl_predictweapons", 1),
			new GClass108("cl_forcepreload", 1),
			new GClass108("tickrate", 128),
			new GClass108("m_rawinput", 1),
			new GClass108("m_mouseaccel1", 0),
			new GClass108("m_mouseaccel2", 0),
			new GClass108("fps_max", 0),
			new GClass108("r_dynamic", 1),
			new GClass108("r_drawtracers_firstperson", 0),
			new GClass108("r_eyegloss", 0),
			new GClass108("r_eyemove", 0),
			new GClass108("r_eyeshift_x", 0),
			new GClass108("r_eyeshift_y", 0),
			new GClass108("r_eyeshift_z", 0),
			new GClass108("r_eyesize", 0),
			new GClass108("snd_mix_async", 1),
			new GClass108("snd_mixahead", 1),
			new GClass108("snd_stream", 1),
			new GClass108("joystick", 1),
			new GClass108("joystick_force_disabled", 1),
			new GClass108("joystick_force_disabled_set_from_options", 1),
			new GClass108("host_writeconfig", null)
		};
	}

	// Token: 0x04000B91 RID: 2961
	public VdfManager vdfManager_0;

	// Token: 0x04000B92 RID: 2962
	public List<GClass108> list_0 = new List<GClass108>();

	// Token: 0x04000B93 RID: 2963
	private string string_0;

	// Token: 0x04000B94 RID: 2964
	private Encoding encoding_0 = Encoding.UTF8;

	// Token: 0x02000341 RID: 833
	private sealed class Class385
	{
		// Token: 0x060012ED RID: 4845 RVA: 0x0004DBF0 File Offset: 0x0004BDF0
		internal bool method_0(GClass108 gclass108_1)
		{
			return gclass108_1.Name == this.gclass108_0.Name;
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0004DC08 File Offset: 0x0004BE08
		internal bool method_1(GClass108 gclass108_1)
		{
			return gclass108_1.Name == this.gclass108_0.Name;
		}

		// Token: 0x04000B95 RID: 2965
		public GClass108 gclass108_0;
	}

	// Token: 0x02000342 RID: 834
	private sealed class Class386
	{
		// Token: 0x060012F0 RID: 4848 RVA: 0x0004DC28 File Offset: 0x0004BE28
		internal bool method_0(GClass108 gclass108_1)
		{
			return gclass108_1.Name == this.gclass108_0.Name;
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0004DC40 File Offset: 0x0004BE40
		internal bool method_1(GClass108 gclass108_1)
		{
			return gclass108_1.Name == this.gclass108_0.Name;
		}

		// Token: 0x04000B96 RID: 2966
		public GClass108 gclass108_0;
	}
}
