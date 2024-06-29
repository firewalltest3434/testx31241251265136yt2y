using System;
using System.Collections.Generic;
using System.Windows.Media;

// Token: 0x020005C8 RID: 1480
internal sealed class Class658
{
	// Token: 0x06002044 RID: 8260 RVA: 0x0008363C File Offset: 0x0008183C
	public Class658(GClass67 gclass67_1, bool bool_1)
	{
		this.gclass67_0 = gclass67_1;
		this.bool_0 = bool_1;
	}

	// Token: 0x06002045 RID: 8261 RVA: 0x00083654 File Offset: 0x00081854
	public string method_0()
	{
		if (this.bool_0)
		{
			return this.gclass67_0.String_0;
		}
		return new string('X', this.gclass67_0.String_0.Length);
	}

	// Token: 0x17000524 RID: 1316
	// (get) Token: 0x06002046 RID: 8262 RVA: 0x00083684 File Offset: 0x00081884
	public string Path
	{
		get
		{
			if (this.bool_0)
			{
				return this.gclass67_0.Path;
			}
			return new string('X', this.gclass67_0.Path.Length);
		}
	}

	// Token: 0x17000525 RID: 1317
	// (get) Token: 0x06002047 RID: 8263 RVA: 0x000836B4 File Offset: 0x000818B4
	public string Key
	{
		get
		{
			if (this.bool_0)
			{
				return this.gclass67_0.Key;
			}
			return new string('X', this.gclass67_0.Key.Length);
		}
	}

	// Token: 0x17000526 RID: 1318
	// (get) Token: 0x06002048 RID: 8264 RVA: 0x000836E4 File Offset: 0x000818E4
	public FontFamily MyFontFamily
	{
		get
		{
			if (!this.bool_0)
			{
				return new FontFamily(new Uri("pack://application:,,,/Resources/Fonts/"), "./#Flow Circular");
			}
			return new FontFamily(new Uri("pack://application:,,,/Resources/Fonts/"), "./#Jost");
		}
	}

	// Token: 0x17000527 RID: 1319
	// (get) Token: 0x06002049 RID: 8265 RVA: 0x0008371C File Offset: 0x0008191C
	public List<Class700> Values
	{
		get
		{
			Class658.Class659 @class = new Class658.Class659();
			@class.class658_0 = this;
			@class.list_0 = new List<Class700>();
			this.gclass67_0.Values.ForEach(new Action<GClass72>(@class.method_0));
			return @class.list_0;
		}
	}

	// Token: 0x17000528 RID: 1320
	// (get) Token: 0x0600204A RID: 8266 RVA: 0x00083764 File Offset: 0x00081964
	public string Type
	{
		get
		{
			GClass67 gclass = this.gclass67_0;
			if (gclass == null)
			{
				return null;
			}
			return gclass.Type;
		}
	}

	// Token: 0x17000529 RID: 1321
	// (get) Token: 0x0600204B RID: 8267 RVA: 0x00083778 File Offset: 0x00081978
	public string RegType
	{
		get
		{
			GClass67 gclass = this.gclass67_0;
			if (gclass == null)
			{
				return null;
			}
			return gclass.RegType;
		}
	}

	// Token: 0x04001652 RID: 5714
	public GClass67 gclass67_0;

	// Token: 0x04001653 RID: 5715
	public bool bool_0;

	// Token: 0x020005C9 RID: 1481
	private sealed class Class659
	{
		// Token: 0x0600204D RID: 8269 RVA: 0x00083794 File Offset: 0x00081994
		internal void method_0(GClass72 gclass72_0)
		{
			this.list_0.Add(new Class700(gclass72_0, this.class658_0.bool_0));
		}

		// Token: 0x04001654 RID: 5716
		public List<Class700> list_0;

		// Token: 0x04001655 RID: 5717
		public Class658 class658_0;
	}
}
