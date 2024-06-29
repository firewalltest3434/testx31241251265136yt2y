using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000173 RID: 371
public sealed class GClass212 : GClass211
{
	// Token: 0x06000997 RID: 2455 RVA: 0x0002BECC File Offset: 0x0002A0CC
	public GClass212(string string_1)
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

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x06000998 RID: 2456 RVA: 0x0002BF30 File Offset: 0x0002A130
	// (set) Token: 0x06000999 RID: 2457 RVA: 0x0002BF38 File Offset: 0x0002A138
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

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x0600099A RID: 2458 RVA: 0x0002BF44 File Offset: 0x0002A144
	// (set) Token: 0x0600099B RID: 2459 RVA: 0x0002BF4C File Offset: 0x0002A14C
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

	// Token: 0x0600099C RID: 2460 RVA: 0x0002BF58 File Offset: 0x0002A158
	public void method_1()
	{
		this.list_0.Clear();
		this.method_6();
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x0002BF6C File Offset: 0x0002A16C
	public void method_2(GClass108 gclass108_0)
	{
		GClass212.Class199 @class = new GClass212.Class199();
		@class.gclass108_0 = gclass108_0;
		if (this.list_0 != null && this.list_0.Any(new Func<GClass108, bool>(@class.method_0)))
		{
			this.list_0.Find(new Predicate<GClass108>(@class.method_1)).method_1(@class.gclass108_0.method_0());
		}
		this.list_0.Add(@class.gclass108_0);
		this.method_8();
	}

	// Token: 0x0600099E RID: 2462 RVA: 0x0002BFE8 File Offset: 0x0002A1E8
	public void method_3(GClass108 gclass108_0)
	{
		GClass212.Class200 @class = new GClass212.Class200();
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

	// Token: 0x0600099F RID: 2463 RVA: 0x0002C080 File Offset: 0x0002A280
	public void method_4(int int_0)
	{
		this.list_0.RemoveAt(int_0);
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x0002C090 File Offset: 0x0002A290
	public void method_5<CVars>(CVars gparam_0) where CVars : IEnumerable<GClass108>
	{
		this.list_0 = gparam_0.ToList<GClass108>();
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x0002C0A4 File Offset: 0x0002A2A4
	public void method_6()
	{
		this.method_7(this.FilePath);
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x0002C0B4 File Offset: 0x0002A2B4
	public void method_7(string string_1)
	{
		if (string_1 != this.FilePath)
		{
			this.FilePath = string_1;
		}
		FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
		try
		{
			byte[] array = new byte[fileStream.Length];
			int num = 0;
			int i = array.Length;
			while (i > 0)
			{
				int num2;
				if ((num2 = fileStream.Read(array, 0, array.Length)) > 0)
				{
					num += num2;
					i -= num2;
				}
			}
			foreach (string string_2 in this.Encoding.GetString(array, 0, num).Split(new string[]
			{
				"\n"
			}, StringSplitOptions.RemoveEmptyEntries))
			{
				this.list_0.Add(new GClass108(string_2));
				base.method_0("CVars");
			}
			fileStream.Close();
		}
		finally
		{
			((IDisposable)fileStream).Dispose();
		}
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x0002C1A8 File Offset: 0x0002A3A8
	public void method_8()
	{
		this.method_9(this.FilePath);
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x0002C1B8 File Offset: 0x0002A3B8
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

	// Token: 0x060009A5 RID: 2469 RVA: 0x0002C25C File Offset: 0x0002A45C
	public byte[] method_10()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (GClass108 arg in this.list_0)
		{
			stringBuilder.Append(string.Format("{0}\n", arg));
		}
		return this.Encoding.GetBytes(stringBuilder.ToString());
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x0002C2D4 File Offset: 0x0002A4D4
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

	// Token: 0x04000594 RID: 1428
	public List<GClass108> list_0 = new List<GClass108>();

	// Token: 0x04000595 RID: 1429
	private string string_0;

	// Token: 0x04000596 RID: 1430
	private Encoding encoding_0 = Encoding.UTF8;

	// Token: 0x02000174 RID: 372
	private sealed class Class199
	{
		// Token: 0x060009A8 RID: 2472 RVA: 0x0002C718 File Offset: 0x0002A918
		internal bool method_0(GClass108 gclass108_1)
		{
			return gclass108_1.Name == this.gclass108_0.Name;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0002C730 File Offset: 0x0002A930
		internal bool method_1(GClass108 gclass108_1)
		{
			return gclass108_1.Name == this.gclass108_0.Name;
		}

		// Token: 0x04000597 RID: 1431
		public GClass108 gclass108_0;
	}

	// Token: 0x02000175 RID: 373
	private sealed class Class200
	{
		// Token: 0x060009AB RID: 2475 RVA: 0x0002C750 File Offset: 0x0002A950
		internal bool method_0(GClass108 gclass108_1)
		{
			return gclass108_1.Name == this.gclass108_0.Name;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x0002C768 File Offset: 0x0002A968
		internal bool method_1(GClass108 gclass108_1)
		{
			return gclass108_1.Name == this.gclass108_0.Name;
		}

		// Token: 0x04000598 RID: 1432
		public GClass108 gclass108_0;
	}
}
