using System;
using System.Runtime.CompilerServices;
using System.ServiceProcess;

// Token: 0x02000304 RID: 772
public sealed class GClass92
{
	// Token: 0x17000218 RID: 536
	// (get) Token: 0x060011A0 RID: 4512 RVA: 0x00049CCC File Offset: 0x00047ECC
	// (set) Token: 0x060011A1 RID: 4513 RVA: 0x00049CD4 File Offset: 0x00047ED4
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

	// Token: 0x17000219 RID: 537
	// (get) Token: 0x060011A2 RID: 4514 RVA: 0x00049CE0 File Offset: 0x00047EE0
	// (set) Token: 0x060011A3 RID: 4515 RVA: 0x00049CE8 File Offset: 0x00047EE8
	public ServiceStartMode Status
	{
		[CompilerGenerated]
		get
		{
			return this.serviceStartMode_0;
		}
		[CompilerGenerated]
		set
		{
			this.serviceStartMode_0 = value;
		}
	}

	// Token: 0x04000AAB RID: 2731
	private string string_0;

	// Token: 0x04000AAC RID: 2732
	private ServiceStartMode serviceStartMode_0;
}
