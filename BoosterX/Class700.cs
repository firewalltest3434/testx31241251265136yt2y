using System;
using System.Windows.Media;

// Token: 0x02000630 RID: 1584
internal sealed class Class700
{
	// Token: 0x0600221A RID: 8730 RVA: 0x0008A970 File Offset: 0x00088B70
	public Class700(GClass72 gclass72_1, bool bool_1)
	{
		this.gclass72_0 = gclass72_1;
		this.bool_0 = bool_1;
	}

	// Token: 0x17000577 RID: 1399
	// (get) Token: 0x0600221B RID: 8731 RVA: 0x0008A988 File Offset: 0x00088B88
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

	// Token: 0x17000578 RID: 1400
	// (get) Token: 0x0600221C RID: 8732 RVA: 0x0008A9C0 File Offset: 0x00088BC0
	public string ValueHandler
	{
		get
		{
			return this.gclass72_0.ValueHandler;
		}
	}

	// Token: 0x17000579 RID: 1401
	// (get) Token: 0x0600221D RID: 8733 RVA: 0x0008A9D0 File Offset: 0x00088BD0
	public bool ContainsOpt
	{
		get
		{
			return this.gclass72_0.ContainsOpt;
		}
	}

	// Token: 0x1700057A RID: 1402
	// (get) Token: 0x0600221E RID: 8734 RVA: 0x0008A9E0 File Offset: 0x00088BE0
	public bool ContainsOn
	{
		get
		{
			return this.gclass72_0.ContainsOn;
		}
	}

	// Token: 0x1700057B RID: 1403
	// (get) Token: 0x0600221F RID: 8735 RVA: 0x0008A9F0 File Offset: 0x00088BF0
	public bool ContainsOff
	{
		get
		{
			return this.gclass72_0.ContainsOff;
		}
	}

	// Token: 0x1700057C RID: 1404
	// (get) Token: 0x06002220 RID: 8736 RVA: 0x0008AA00 File Offset: 0x00088C00
	public bool ContainsBest
	{
		get
		{
			return this.gclass72_0.ContainsBest;
		}
	}

	// Token: 0x1700057D RID: 1405
	// (get) Token: 0x06002221 RID: 8737 RVA: 0x0008AA10 File Offset: 0x00088C10
	public bool ContainsDefault
	{
		get
		{
			return this.gclass72_0.ContainsDefault;
		}
	}

	// Token: 0x040017A3 RID: 6051
	private GClass72 gclass72_0;

	// Token: 0x040017A4 RID: 6052
	private bool bool_0;
}
