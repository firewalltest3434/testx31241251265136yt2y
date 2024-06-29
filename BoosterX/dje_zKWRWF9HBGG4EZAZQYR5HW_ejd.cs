using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

// Token: 0x02000857 RID: 2135
[XmlRoot("download")]
public sealed class dje_zKWRWF9HBGG4EZAZQYR5HW_ejd
{
	// Token: 0x17000628 RID: 1576
	// (get) Token: 0x06002BB9 RID: 11193 RVA: 0x000BB7DC File Offset: 0x000B99DC
	// (set) Token: 0x06002BBA RID: 11194 RVA: 0x000BB7E4 File Offset: 0x000B99E4
	[XmlAttribute("testlength")]
	public int TestLength
	{
		[CompilerGenerated]
		get
		{
			return this.int_0;
		}
		[CompilerGenerated]
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x17000629 RID: 1577
	// (get) Token: 0x06002BBB RID: 11195 RVA: 0x000BB7F0 File Offset: 0x000B99F0
	// (set) Token: 0x06002BBC RID: 11196 RVA: 0x000BB7F8 File Offset: 0x000B99F8
	[XmlAttribute("initialtest")]
	public string InitialTest
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

	// Token: 0x1700062A RID: 1578
	// (get) Token: 0x06002BBD RID: 11197 RVA: 0x000BB804 File Offset: 0x000B9A04
	// (set) Token: 0x06002BBE RID: 11198 RVA: 0x000BB80C File Offset: 0x000B9A0C
	[XmlAttribute("mintestsize")]
	public string MinTestSize
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

	// Token: 0x1700062B RID: 1579
	// (get) Token: 0x06002BBF RID: 11199 RVA: 0x000BB818 File Offset: 0x000B9A18
	// (set) Token: 0x06002BC0 RID: 11200 RVA: 0x000BB820 File Offset: 0x000B9A20
	[XmlAttribute("threadsperurl")]
	public int ThreadsPerUrl
	{
		[CompilerGenerated]
		get
		{
			return this.int_1;
		}
		[CompilerGenerated]
		set
		{
			this.int_1 = value;
		}
	}

	// Token: 0x040021CE RID: 8654
	private int int_0;

	// Token: 0x040021CF RID: 8655
	private string string_0;

	// Token: 0x040021D0 RID: 8656
	private string string_1;

	// Token: 0x040021D1 RID: 8657
	private int int_1;
}
