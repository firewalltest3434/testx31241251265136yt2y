using System;
using System.IO;
using System.Runtime.CompilerServices;

// Token: 0x020005BF RID: 1471
internal sealed class Class654
{
	// Token: 0x0600200C RID: 8204 RVA: 0x00082FF8 File Offset: 0x000811F8
	public Class654()
	{
		Class654.smethod_0(ref this.string_0);
		base..ctor();
	}

	// Token: 0x17000514 RID: 1300
	// (get) Token: 0x0600200D RID: 8205 RVA: 0x0008300C File Offset: 0x0008120C
	// (set) Token: 0x0600200E RID: 8206 RVA: 0x00083014 File Offset: 0x00081214
	public TimeSpan ExpiryLeft
	{
		[CompilerGenerated]
		get
		{
			return this.timeSpan_0;
		}
		[CompilerGenerated]
		set
		{
			this.timeSpan_0 = value;
		}
	}

	// Token: 0x17000515 RID: 1301
	// (get) Token: 0x0600200F RID: 8207 RVA: 0x00083020 File Offset: 0x00081220
	// (set) Token: 0x06002010 RID: 8208 RVA: 0x00083028 File Offset: 0x00081228
	public string DiscordNick
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

	// Token: 0x06002011 RID: 8209 RVA: 0x00083034 File Offset: 0x00081234
	private static void smethod_0(ref string string_1)
	{
		object[] array = new object[]
		{
			string_1
		};
		Class27 @class = Class555.smethod_0();
		Stream stream_ = Class555.smethod_2();
		try
		{
			@class.method_4(stream_, "&ebh_()JV<", array);
		}
		finally
		{
			string_1 = (string)array[0];
		}
	}

	// Token: 0x04001637 RID: 5687
	private TimeSpan timeSpan_0;

	// Token: 0x04001638 RID: 5688
	private string string_0;
}
