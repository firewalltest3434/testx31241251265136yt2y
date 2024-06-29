using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x0200065C RID: 1628
internal sealed class Class506 : Class502
{
	// Token: 0x060022D9 RID: 8921 RVA: 0x0008B144 File Offset: 0x00089344
	public ObservableCollection<Class742> method_0()
	{
		Class506.Class701 @class = new Class506.Class701();
		@class.observableCollection_0 = new ObservableCollection<Class742>();
		List<string> list = Class502.smethod_2("Games", "GameModeX");
		if (list != null)
		{
			list.ForEach(new Action<string>(@class.method_0));
		}
		return @class.observableCollection_0;
	}

	// Token: 0x060022DA RID: 8922 RVA: 0x0008B190 File Offset: 0x00089390
	public ObservableCollection<Class747> method_1()
	{
		Class506.Class703 @class = new Class506.Class703();
		@class.observableCollection_0 = new ObservableCollection<Class747>();
		List<string> list = Class502.smethod_2("Apps", "GameModeX");
		if (list != null)
		{
			list.ForEach(new Action<string>(@class.method_0));
		}
		return @class.observableCollection_0;
	}

	// Token: 0x1700057E RID: 1406
	// (get) Token: 0x060022DB RID: 8923 RVA: 0x0008B1DC File Offset: 0x000893DC
	// (set) Token: 0x060022DC RID: 8924 RVA: 0x0008B204 File Offset: 0x00089404
	public string OnOffShortcut
	{
		get
		{
			string text = "CTRL+SHIFT+O";
			return Class502.smethod_0("OnOffShortcut", this.string_0) ?? text;
		}
		set
		{
			Class502.smethod_1("OnOffShortcut", value.ToString(), this.string_0);
		}
	}

	// Token: 0x1700057F RID: 1407
	// (get) Token: 0x060022DD RID: 8925 RVA: 0x0008B21C File Offset: 0x0008941C
	// (set) Token: 0x060022DE RID: 8926 RVA: 0x0008B250 File Offset: 0x00089450
	public bool? DisableDWM
	{
		get
		{
			return new bool?(new bool?(Convert.ToBoolean(Class502.smethod_0("DisableDWM", this.string_0))).GetValueOrDefault());
		}
		set
		{
			Class502.smethod_1("DisableDWM", value.ToString(), this.string_0);
		}
	}

	// Token: 0x17000580 RID: 1408
	// (get) Token: 0x060022DF RID: 8927 RVA: 0x0008B270 File Offset: 0x00089470
	// (set) Token: 0x060022E0 RID: 8928 RVA: 0x0008B2A8 File Offset: 0x000894A8
	public bool? DisableExplorer
	{
		get
		{
			return new bool?(new bool?(Convert.ToBoolean(Class502.smethod_0("DisableExplorer", this.string_0))).GetValueOrDefault(true));
		}
		set
		{
			Class502.smethod_1("DisableExplorer", value.ToString(), this.string_0);
		}
	}

	// Token: 0x17000581 RID: 1409
	// (get) Token: 0x060022E1 RID: 8929 RVA: 0x0008B2C8 File Offset: 0x000894C8
	// (set) Token: 0x060022E2 RID: 8930 RVA: 0x0008B2E4 File Offset: 0x000894E4
	public string CleanCacheShortcut
	{
		get
		{
			return Class502.smethod_0("CleanCacheShortcut", this.string_0) ?? "CTRL+SHIFT+P";
		}
		set
		{
			Class502.smethod_1("CleanCacheShortcut", value.ToString(), this.string_0);
		}
	}

	// Token: 0x17000582 RID: 1410
	// (get) Token: 0x060022E3 RID: 8931 RVA: 0x0008B2FC File Offset: 0x000894FC
	// (set) Token: 0x060022E4 RID: 8932 RVA: 0x0008B334 File Offset: 0x00089534
	public bool? CleanCacheAtStart
	{
		get
		{
			return new bool?(new bool?(Convert.ToBoolean(Class502.smethod_0("CleanCacheAtStart", this.string_0))).GetValueOrDefault(true));
		}
		set
		{
			Class502.smethod_1("CleanCacheAtStart", value.ToString(), this.string_0);
		}
	}

	// Token: 0x060022E5 RID: 8933 RVA: 0x0008B354 File Offset: 0x00089554
	private List<Class506.Class702> method_2()
	{
		return this.list_0;
	}

	// Token: 0x060022E6 RID: 8934 RVA: 0x0008B35C File Offset: 0x0008955C
	private void method_3(List<Class506.Class702> list_1)
	{
		this.list_0 = list_1;
	}

	// Token: 0x17000583 RID: 1411
	// (get) Token: 0x060022E7 RID: 8935 RVA: 0x0008B368 File Offset: 0x00089568
	public List<Class506.Class702> PowerSchemes
	{
		get
		{
			if (this.method_2() != null)
			{
				return this.method_2();
			}
			this.method_3(new List<Class506.Class702>());
			try
			{
				GClass76.smethod_4().ToList<Guid>().ForEach(new Action<Guid>(this.method_4));
			}
			catch (object obj)
			{
			}
			finally
			{
				this.method_2().Add(new Class506.Class702
				{
					Name = Class364.smethod_0("disabled"),
					Guid = string.Empty
				});
			}
			return this.method_2();
		}
	}

	// Token: 0x17000584 RID: 1412
	// (get) Token: 0x060022E8 RID: 8936 RVA: 0x0008B400 File Offset: 0x00089600
	// (set) Token: 0x060022E9 RID: 8937 RVA: 0x0008B440 File Offset: 0x00089640
	public Class506.Class702 PSGaming
	{
		get
		{
			if (this.PowerSchemes.Any(new Func<Class506.Class702, bool>(this.method_5)))
			{
				return this.PowerSchemes.First(new Func<Class506.Class702, bool>(this.method_6));
			}
			return this.PowerSchemes.Last<Class506.Class702>();
		}
		set
		{
			Class502.smethod_1("PSGaming", value.Guid.ToString(), this.string_0);
		}
	}

	// Token: 0x17000585 RID: 1413
	// (get) Token: 0x060022EA RID: 8938 RVA: 0x0008B460 File Offset: 0x00089660
	// (set) Token: 0x060022EB RID: 8939 RVA: 0x0008B4A0 File Offset: 0x000896A0
	public Class506.Class702 PSGameOff
	{
		get
		{
			if (this.PowerSchemes.Any(new Func<Class506.Class702, bool>(this.method_7)))
			{
				return this.PowerSchemes.First(new Func<Class506.Class702, bool>(this.method_8));
			}
			return this.PowerSchemes.Last<Class506.Class702>();
		}
		set
		{
			Class502.smethod_1("PSGameOff", value.Guid.ToString(), this.string_0);
		}
	}

	// Token: 0x060022EC RID: 8940 RVA: 0x0008B4C0 File Offset: 0x000896C0
	private void method_4(Guid guid_0)
	{
		this.method_2().Add(new Class506.Class702
		{
			Name = GClass76.smethod_3(guid_0),
			Guid = guid_0.ToString()
		});
	}

	// Token: 0x060022ED RID: 8941 RVA: 0x0008B4F4 File Offset: 0x000896F4
	private bool method_5(Class506.Class702 class702_0)
	{
		return class702_0.Guid == Class502.smethod_0("PSGaming", this.string_0);
	}

	// Token: 0x060022EE RID: 8942 RVA: 0x0008B514 File Offset: 0x00089714
	private bool method_6(Class506.Class702 class702_0)
	{
		return class702_0.Guid == Class502.smethod_0("PSGaming", this.string_0);
	}

	// Token: 0x060022EF RID: 8943 RVA: 0x0008B534 File Offset: 0x00089734
	private bool method_7(Class506.Class702 class702_0)
	{
		return class702_0.Guid == Class502.smethod_0("PSGameOff", this.string_0);
	}

	// Token: 0x060022F0 RID: 8944 RVA: 0x0008B554 File Offset: 0x00089754
	private bool method_8(Class506.Class702 class702_0)
	{
		return class702_0.Guid == Class502.smethod_0("PSGameOff", this.string_0);
	}

	// Token: 0x040017D6 RID: 6102
	private string string_0 = "GameModeX";

	// Token: 0x040017D7 RID: 6103
	private List<Class506.Class702> list_0;

	// Token: 0x0200065D RID: 1629
	private sealed class Class701
	{
		// Token: 0x060022F2 RID: 8946 RVA: 0x0008B57C File Offset: 0x0008977C
		internal void method_0(string string_0)
		{
			this.observableCollection_0.Add(new Class742(string_0));
		}

		// Token: 0x040017D8 RID: 6104
		public ObservableCollection<Class742> observableCollection_0;
	}

	// Token: 0x0200065E RID: 1630
	public sealed class Class702
	{
		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x0008B598 File Offset: 0x00089798
		// (set) Token: 0x060022F5 RID: 8949 RVA: 0x0008B5A0 File Offset: 0x000897A0
		public string Name
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

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060022F6 RID: 8950 RVA: 0x0008B5AC File Offset: 0x000897AC
		// (set) Token: 0x060022F7 RID: 8951 RVA: 0x0008B5B4 File Offset: 0x000897B4
		public string Guid
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x040017D9 RID: 6105
		private string string_0;

		// Token: 0x040017DA RID: 6106
		private string string_1;
	}

	// Token: 0x0200065F RID: 1631
	private sealed class Class703
	{
		// Token: 0x060022F9 RID: 8953 RVA: 0x0008B5C8 File Offset: 0x000897C8
		internal void method_0(string string_0)
		{
			this.observableCollection_0.Add(new Class747(string_0));
		}

		// Token: 0x040017DB RID: 6107
		public ObservableCollection<Class747> observableCollection_0;
	}
}
