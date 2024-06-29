using System;

// Token: 0x02000022 RID: 34
internal sealed class Class50 : Class44
{
	// Token: 0x060000CC RID: 204 RVA: 0x0000432C File Offset: 0x0000252C
	public Class50() : base(6)
	{
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00004338 File Offset: 0x00002538
	public UIntPtr method_3()
	{
		return this.uintptr_0;
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00004340 File Offset: 0x00002540
	public void method_4(UIntPtr uintptr_1)
	{
		this.uintptr_0 = uintptr_1;
	}

	// Token: 0x060000CF RID: 207 RVA: 0x0000434C File Offset: 0x0000254C
	public override Class44 vmethod_3()
	{
		Class50 @class = new Class50();
		@class.method_4(this.uintptr_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x0000436C File Offset: 0x0000256C
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x0000437C File Offset: 0x0000257C
	public override void vmethod_1(object object_0)
	{
		this.method_4((UIntPtr)object_0);
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x0000438C File Offset: 0x0000258C
	public override Class44 vmethod_2(Class44 class44_0)
	{
		base.method_2(class44_0.method_1());
		int num = class44_0.method_0();
		switch (num)
		{
		case 2:
			this.method_4(new UIntPtr(Convert.ToUInt64(((Class53)class44_0).method_3())));
			return this;
		case 3:
		case 4:
		case 5:
			break;
		case 6:
			this.method_4(((Class50)class44_0).method_3());
			return this;
		case 7:
			this.method_4((UIntPtr)((ulong)((long)((Class54)class44_0).method_3())));
			return this;
		case 8:
			this.method_4((UIntPtr)((ulong)((Class58)class44_0).method_3()));
			return this;
		default:
			if (num == 12)
			{
				this.method_4((UIntPtr)((uint)((Class69)class44_0).method_3()));
				return this;
			}
			switch (num)
			{
			case 17:
				this.method_4((UIntPtr)((Class51)class44_0).method_3());
				return this;
			case 19:
				this.method_4((UIntPtr)((Class59)class44_0).method_3());
				return this;
			case 22:
				this.method_4((UIntPtr)((ulong)((Class56)class44_0).method_3()));
				return this;
			case 24:
				this.method_4((UIntPtr)((ulong)((Class57)class44_0).method_3()));
				return this;
			case 25:
				this.method_4((UIntPtr)((Class68)class44_0).method_3());
				return this;
			case 26:
				this.method_4((UIntPtr)((uint)((Class48)class44_0).method_3()));
				return this;
			}
			break;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x04000039 RID: 57
	private UIntPtr uintptr_0;
}
