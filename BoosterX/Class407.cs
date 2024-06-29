using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Material.Icons;

// Token: 0x0200037A RID: 890
internal sealed class Class407
{
	// Token: 0x060013CD RID: 5069 RVA: 0x00052738 File Offset: 0x00050938
	public static List<Class407.Class737> smethod_0()
	{
		List<Class407.Class737> list = new List<Class407.Class737>();
		Class407.Class737 @class = new Class407.Class737();
		@class.Name = "Panorama";
		@class.Icon = 5079;
		@class.Checker = new Func<bool>(Class407.Class408.class408_0.method_0);
		@class.Unchecked = new Action(Class407.Class408.class408_0.method_1);
		@class.Checked = new Action(Class407.Class408.class408_0.method_2);
		list.Add(@class);
		return list;
	}

	// Token: 0x0200037B RID: 891
	public sealed class Class737 : GClass211
	{
		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x000527EC File Offset: 0x000509EC
		// (set) Token: 0x060013D0 RID: 5072 RVA: 0x000527F4 File Offset: 0x000509F4
		public string _Name
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x00052800 File Offset: 0x00050A00
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x00052810 File Offset: 0x00050A10
		public string Name
		{
			get
			{
				return Class364.smethod_0(this._Name);
			}
			set
			{
				this._Name = value;
				base.method_0("Name");
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x00052824 File Offset: 0x00050A24
		public string Description
		{
			get
			{
				return Class364.smethod_0(this._Name + "Desc");
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x0005283C File Offset: 0x00050A3C
		// (set) Token: 0x060013D5 RID: 5077 RVA: 0x00052844 File Offset: 0x00050A44
		public bool _IsChecked
		{
			[CompilerGenerated]
			get
			{
				return this.bool_1;
			}
			[CompilerGenerated]
			set
			{
				this.bool_1 = value;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x00052850 File Offset: 0x00050A50
		// (set) Token: 0x060013D7 RID: 5079 RVA: 0x00052858 File Offset: 0x00050A58
		public bool IsChecked
		{
			get
			{
				return this._IsChecked;
			}
			set
			{
				this._IsChecked = value;
				base.method_0("IsChecked");
				if (this.bool_0)
				{
					this.bool_0 = false;
					return;
				}
				if (value)
				{
					this.Checked();
					return;
				}
				this.Unchecked();
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x00052898 File Offset: 0x00050A98
		// (set) Token: 0x060013D9 RID: 5081 RVA: 0x000528A0 File Offset: 0x00050AA0
		public Action Checked
		{
			[CompilerGenerated]
			get
			{
				return this.action_0;
			}
			[CompilerGenerated]
			set
			{
				this.action_0 = value;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x000528AC File Offset: 0x00050AAC
		// (set) Token: 0x060013DB RID: 5083 RVA: 0x000528B4 File Offset: 0x00050AB4
		public Action Unchecked
		{
			[CompilerGenerated]
			get
			{
				return this.action_1;
			}
			[CompilerGenerated]
			set
			{
				this.action_1 = value;
			}
		}

		// Token: 0x1700029F RID: 671
		// (set) Token: 0x060013DC RID: 5084 RVA: 0x000528C0 File Offset: 0x00050AC0
		public Func<bool> Checker
		{
			set
			{
				this.method_1(value);
			}
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x000528CC File Offset: 0x00050ACC
		public void method_1(Func<bool> func_0)
		{
			this.IsChecked = !func_0();
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x000528E0 File Offset: 0x00050AE0
		private MaterialIconKind method_2()
		{
			return this.materialIconKind_0;
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x000528E8 File Offset: 0x00050AE8
		private void method_3(MaterialIconKind materialIconKind_1)
		{
			this.materialIconKind_0 = materialIconKind_1;
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x000528F4 File Offset: 0x00050AF4
		// (set) Token: 0x060013E1 RID: 5089 RVA: 0x000528FC File Offset: 0x00050AFC
		public MaterialIconKind Icon
		{
			get
			{
				return this.method_2();
			}
			set
			{
				this.method_3(value);
				base.method_0("Icon");
			}
		}

		// Token: 0x04000C17 RID: 3095
		private string string_0;

		// Token: 0x04000C18 RID: 3096
		public bool bool_0 = true;

		// Token: 0x04000C19 RID: 3097
		private bool bool_1;

		// Token: 0x04000C1A RID: 3098
		private Action action_0;

		// Token: 0x04000C1B RID: 3099
		private Action action_1;

		// Token: 0x04000C1C RID: 3100
		private MaterialIconKind materialIconKind_0;
	}

	// Token: 0x0200037C RID: 892
	[Serializable]
	private sealed class Class408
	{
		// Token: 0x060013E4 RID: 5092 RVA: 0x00052924 File Offset: 0x00050B24
		internal bool method_0()
		{
			return Directory.Exists(GClass88.smethod_0().method_3() + "\\game\\csgo\\panorama\\fonts") && Directory.Exists(GClass88.smethod_0().method_3() + "\\game\\csgo\\panorama\\videos");
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0005295C File Offset: 0x00050B5C
		internal void method_1()
		{
			try
			{
				Class650.smethod_1(Class650.smethod_3(GClass88.smethod_0().method_3() + "\\game\\csgo\\panorama", "fonts"), "fonts");
				Class650.smethod_1(Class650.smethod_3(GClass88.smethod_0().method_3() + "\\game\\csgo\\panorama", "videos"), "videos");
			}
			catch (object obj)
			{
			}
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x000529D0 File Offset: 0x00050BD0
		internal void method_2()
		{
			try
			{
				foreach (GClass215 gclass215_ in new GClass224().Profiles)
				{
					new GClass214(gclass215_)
					{
						Param = "-novid"
					}.method_1();
				}
			}
			catch (object obj)
			{
			}
			try
			{
				Class650.smethod_1(GClass88.smethod_0().method_3() + "\\game\\csgo\\panorama\\fonts", "fonts_");
				Class650.smethod_1(GClass88.smethod_0().method_3() + "\\game\\csgo\\panorama\\videos", "videos_");
			}
			catch
			{
				try
				{
					Directory.Delete(GClass88.smethod_0().method_3() + "\\game\\csgo\\panorama\\fonts_", true);
				}
				catch (object obj2)
				{
				}
				try
				{
					Directory.Delete(GClass88.smethod_0().method_3() + "\\game\\csgo\\panorama\\videos_", true);
				}
				catch (object obj3)
				{
				}
				try
				{
					Class650.smethod_1(GClass88.smethod_0().method_3() + "\\game\\csgo\\panorama\\fonts", "fonts_");
					Class650.smethod_1(GClass88.smethod_0().method_3() + "\\game\\csgo\\panorama\\videos", "videos_");
				}
				catch (object obj4)
				{
				}
			}
		}

		// Token: 0x04000C1D RID: 3101
		public static readonly Class407.Class408 class408_0 = new Class407.Class408();

		// Token: 0x04000C1E RID: 3102
		public static Func<bool> func_0;

		// Token: 0x04000C1F RID: 3103
		public static Action action_0;

		// Token: 0x04000C20 RID: 3104
		public static Action action_1;
	}
}
