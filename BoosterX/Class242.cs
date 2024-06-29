using System;
using System.Threading;

// Token: 0x020001BC RID: 444
internal static class Class242
{
	// Token: 0x020001BD RID: 445
	internal sealed class Class243 : Interface9<int>, Interface10<int>, Interface7, Interface14, Interface15
	{
		// Token: 0x06000AA6 RID: 2726 RVA: 0x00031774 File Offset: 0x0002F974
		public Class243(int int_5)
		{
			this.int_0 = int_5;
			this.int_2 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00031794 File Offset: 0x0002F994
		void Interface14.imethod_0()
		{
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00031798 File Offset: 0x0002F998
		bool Interface7.imethod_0()
		{
			switch (this.int_0)
			{
			case 0:
				this.int_0 = -1;
				this.int_1 = 468360524;
				this.int_0 = 1;
				return true;
			case 1:
				this.int_0 = -1;
				this.int_1 = (this.int_3 ^ 1431634894);
				this.int_0 = 2;
				return true;
			case 2:
				this.int_0 = -1;
				this.int_1 = 1017906678;
				this.int_0 = 3;
				return true;
			case 3:
				this.int_0 = -1;
				this.int_1 = (this.int_3 ^ 1431634894);
				this.int_0 = 4;
				return true;
			case 4:
				this.int_0 = -1;
				this.int_1 = -1181805345;
				this.int_0 = 5;
				return true;
			case 5:
				this.int_0 = -1;
				this.int_1 = (this.int_3 ^ 237901828);
				this.int_0 = 6;
				return true;
			case 6:
				this.int_0 = -1;
				this.int_1 = -2051503665;
				this.int_0 = 7;
				return true;
			case 7:
				this.int_0 = -1;
				this.int_1 = -1756408561;
				this.int_0 = 8;
				return true;
			case 8:
				this.int_0 = -1;
				return false;
			default:
				return false;
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x000318D0 File Offset: 0x0002FAD0
		int Interface9<int>.imethod_3()
		{
			return this.int_1;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x000318D8 File Offset: 0x0002FAD8
		void Interface7.imethod_2()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x000318E0 File Offset: 0x0002FAE0
		object Interface7.imethod_1()
		{
			return this.int_1;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x000318F0 File Offset: 0x0002FAF0
		Interface9<int> Interface10<int>.GetEnumerator()
		{
			Class242.Class243 @class;
			if (this.int_0 == -2 && this.int_2 == Thread.CurrentThread.ManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class242.Class243(0);
			}
			@class.int_3 = this.int_4;
			return @class;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00031938 File Offset: 0x0002FB38
		Interface7 Interface15.imethod_0()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000678 RID: 1656
		private int int_0;

		// Token: 0x04000679 RID: 1657
		private int int_1;

		// Token: 0x0400067A RID: 1658
		private int int_2;

		// Token: 0x0400067B RID: 1659
		private int int_3;

		// Token: 0x0400067C RID: 1660
		public int int_4;
	}
}
