using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Token: 0x02000281 RID: 641
internal sealed class Class323
{
	// Token: 0x170001BB RID: 443
	// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x0003FBE8 File Offset: 0x0003DDE8
	// (set) Token: 0x06000ED1 RID: 3793 RVA: 0x0003FBF0 File Offset: 0x0003DDF0
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

	// Token: 0x06000ED2 RID: 3794 RVA: 0x0003FBFC File Offset: 0x0003DDFC
	public Task method_0()
	{
		return this.task_0;
	}

	// Token: 0x06000ED3 RID: 3795 RVA: 0x0003FC04 File Offset: 0x0003DE04
	public void method_1(Task task_2)
	{
		this.task_0 = task_2;
	}

	// Token: 0x06000ED4 RID: 3796 RVA: 0x0003FC10 File Offset: 0x0003DE10
	public Task<bool> method_2()
	{
		return this.task_1;
	}

	// Token: 0x06000ED5 RID: 3797 RVA: 0x0003FC18 File Offset: 0x0003DE18
	public void method_3(Task<bool> task_2)
	{
		this.task_1 = task_2;
	}

	// Token: 0x0400090C RID: 2316
	private string string_0;

	// Token: 0x0400090D RID: 2317
	private Task task_0;

	// Token: 0x0400090E RID: 2318
	private Task<bool> task_1;
}
