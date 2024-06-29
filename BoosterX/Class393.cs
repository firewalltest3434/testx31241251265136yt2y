using System;

// Token: 0x02000353 RID: 851
internal sealed class Class393
{
	// Token: 0x0600133A RID: 4922 RVA: 0x0004E48C File Offset: 0x0004C68C
	public Class393(Class179 class179_1)
	{
		this.class179_0 = class179_1;
	}

	// Token: 0x17000282 RID: 642
	// (get) Token: 0x0600133B RID: 4923 RVA: 0x0004E49C File Offset: 0x0004C69C
	public string Command
	{
		get
		{
			return this.class179_0.Command;
		}
	}

	// Token: 0x17000283 RID: 643
	// (get) Token: 0x0600133C RID: 4924 RVA: 0x0004E4AC File Offset: 0x0004C6AC
	public string DefaultValue
	{
		get
		{
			return this.class179_0.DefaultValue;
		}
	}

	// Token: 0x17000284 RID: 644
	// (get) Token: 0x0600133D RID: 4925 RVA: 0x0004E4BC File Offset: 0x0004C6BC
	public bool IsCheat
	{
		get
		{
			return this.class179_0.IsCheat;
		}
	}

	// Token: 0x17000285 RID: 645
	// (get) Token: 0x0600133E RID: 4926 RVA: 0x0004E4CC File Offset: 0x0004C6CC
	public bool IsClient
	{
		get
		{
			return this.class179_0.IsClient;
		}
	}

	// Token: 0x17000286 RID: 646
	// (get) Token: 0x0600133F RID: 4927 RVA: 0x0004E4DC File Offset: 0x0004C6DC
	public bool IsServer
	{
		get
		{
			return this.class179_0.IsServer;
		}
	}

	// Token: 0x17000287 RID: 647
	// (get) Token: 0x06001340 RID: 4928 RVA: 0x0004E4EC File Offset: 0x0004C6EC
	public string Description
	{
		get
		{
			if (!(this.class179_0.Description[Class364.smethod_0("CurrentLocalization")] == string.Empty))
			{
				return this.class179_0.Description[Class364.smethod_0("CurrentLocalization")];
			}
			return Class364.smethod_0("NoDescription");
		}
	}

	// Token: 0x04000BC5 RID: 3013
	private Class179 class179_0;
}
