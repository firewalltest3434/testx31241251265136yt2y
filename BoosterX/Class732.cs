using System;

// Token: 0x0200030C RID: 780
internal sealed class Class732 : GClass211
{
	// Token: 0x06001213 RID: 4627 RVA: 0x0004A7D4 File Offset: 0x000489D4
	public Class732(Class416 class416_1)
	{
		this.class416_0 = class416_1;
	}

	// Token: 0x17000238 RID: 568
	// (get) Token: 0x06001214 RID: 4628 RVA: 0x0004A7E4 File Offset: 0x000489E4
	public string Command
	{
		get
		{
			return this.class416_0.Command;
		}
	}

	// Token: 0x17000239 RID: 569
	// (get) Token: 0x06001215 RID: 4629 RVA: 0x0004A7F4 File Offset: 0x000489F4
	public string Description
	{
		get
		{
			if (!(this.class416_0.Description[Class364.smethod_0("CurrentLocalization")] == string.Empty))
			{
				return Class364.smethod_0("Description") + ": " + this.class416_0.Description[Class364.smethod_0("CurrentLocalization")];
			}
			return Class364.smethod_0("NoDescription");
		}
	}

	// Token: 0x04000AD7 RID: 2775
	private Class416 class416_0;
}
