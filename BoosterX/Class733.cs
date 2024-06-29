using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using ns0;

// Token: 0x02000316 RID: 790
internal sealed class Class733 : GClass211
{
	// Token: 0x06001231 RID: 4657 RVA: 0x0004B598 File Offset: 0x00049798
	public Class733(Class383 class383_1)
	{
		this.class383_0 = class383_1;
		this.class529_0 = class383_1.Contents.FirstOrDefault(new Func<Class529, bool>(Class733.Class377.class377_0.method_0));
		base.method_0(".ctor");
	}

	// Token: 0x1700023A RID: 570
	// (get) Token: 0x06001232 RID: 4658 RVA: 0x0004B5F0 File Offset: 0x000497F0
	public string DateCreated
	{
		get
		{
			DateTime dateCreated = this.class383_0.DateCreated;
			return this.class383_0.DateCreated.ToString("dd/MM/yyyy").Replace('/', '.');
		}
	}

	// Token: 0x1700023B RID: 571
	// (get) Token: 0x06001233 RID: 4659 RVA: 0x0004B62C File Offset: 0x0004982C
	public string Name
	{
		get
		{
			if (this.class383_0.Name != null && this.class383_0.Name != string.Empty)
			{
				return this.class383_0.Name;
			}
			return "UPDATE";
		}
	}

	// Token: 0x1700023C RID: 572
	// (get) Token: 0x06001234 RID: 4660 RVA: 0x0004B66C File Offset: 0x0004986C
	public string Creator
	{
		get
		{
			if (this.class383_0.Creator != null && this.class383_0.Creator != string.Empty)
			{
				return this.class383_0.Creator;
			}
			return "Developer";
		}
	}

	// Token: 0x1700023D RID: 573
	// (get) Token: 0x06001235 RID: 4661 RVA: 0x0004B6AC File Offset: 0x000498AC
	public string Content
	{
		get
		{
			if (this.class529_0 != null && this.class529_0.Content != string.Empty)
			{
				return this.class529_0.Content;
			}
			return Class364.smethod_0("unknownerror");
		}
	}

	// Token: 0x1700023E RID: 574
	// (get) Token: 0x06001236 RID: 4662 RVA: 0x0004B6EC File Offset: 0x000498EC
	public SolidColorBrush Color
	{
		get
		{
			if (this.class529_0.Color != null && this.class529_0.Color != string.Empty)
			{
				return new SolidColorBrush((Color)ColorConverter.ConvertFromString(this.class529_0.Color));
			}
			return dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z2NVHWHQTTE97LGZ_ejd;
		}
	}

	// Token: 0x1700023F RID: 575
	// (get) Token: 0x06001237 RID: 4663 RVA: 0x0004B740 File Offset: 0x00049940
	// (set) Token: 0x06001238 RID: 4664 RVA: 0x0004B748 File Offset: 0x00049948
	public Visibility ButtonsVisibility
	{
		get
		{
			return this.visibility_0;
		}
		set
		{
			this.visibility_0 = value;
			base.method_0("ButtonsVisibility");
		}
	}

	// Token: 0x17000240 RID: 576
	// (get) Token: 0x06001239 RID: 4665 RVA: 0x0004B75C File Offset: 0x0004995C
	public List<Class731> Buttons
	{
		get
		{
			Class733.Class378 @class = new Class733.Class378();
			if (this.class383_0.Buttons != null && this.class383_0.Buttons.Count<Class528>() != 0)
			{
				@class.list_0 = new List<Class731>();
				this.class383_0.Buttons.ForEach(new Action<Class528>(@class.method_0));
				return @class.list_0;
			}
			this.visibility_0 = Visibility.Collapsed;
			return new List<Class731>();
		}
	}

	// Token: 0x04000B13 RID: 2835
	private readonly Class383 class383_0;

	// Token: 0x04000B14 RID: 2836
	private readonly Class529 class529_0;

	// Token: 0x04000B15 RID: 2837
	private Visibility visibility_0;

	// Token: 0x02000317 RID: 791
	[Serializable]
	private sealed class Class377
	{
		// Token: 0x0600123C RID: 4668 RVA: 0x0004B7DC File Offset: 0x000499DC
		internal bool method_0(Class529 class529_0)
		{
			return class529_0.Language == Class364.smethod_0("CurrentLocalization");
		}

		// Token: 0x04000B16 RID: 2838
		public static readonly Class733.Class377 class377_0 = new Class733.Class377();

		// Token: 0x04000B17 RID: 2839
		public static Func<Class529, bool> func_0;
	}

	// Token: 0x02000318 RID: 792
	private sealed class Class378
	{
		// Token: 0x0600123E RID: 4670 RVA: 0x0004B7FC File Offset: 0x000499FC
		internal void method_0(Class528 class528_0)
		{
			this.list_0.Add(new Class731(class528_0));
		}

		// Token: 0x04000B18 RID: 2840
		public List<Class731> list_0;
	}
}
