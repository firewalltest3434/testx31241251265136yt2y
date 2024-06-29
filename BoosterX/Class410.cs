using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Token: 0x02000382 RID: 898
internal sealed class Class410
{
	// Token: 0x0600142E RID: 5166 RVA: 0x000533F4 File Offset: 0x000515F4
	private static double smethod_0()
	{
		double result;
		try
		{
			double num = 0.0;
			foreach (string string_2 in Class186.string_17)
			{
				num += Class185.smethod_8(string_2);
			}
			result = num;
		}
		catch
		{
			result = 0.0;
		}
		return result;
	}

	// Token: 0x0600142F RID: 5167 RVA: 0x00053460 File Offset: 0x00051660
	public static Task smethod_1()
	{
		return Task.Run(new Action(Class410.Class411.class411_0.method_0));
	}

	// Token: 0x06001430 RID: 5168 RVA: 0x00053488 File Offset: 0x00051688
	public static Task smethod_2(int int_0)
	{
		return Task.Run(new Action(new Class410.Class412
		{
			int_0 = int_0
		}.method_0));
	}

	// Token: 0x04000C3A RID: 3130
	public static List<Class410.Class413> list_0 = new List<Class410.Class413>();

	// Token: 0x02000383 RID: 899
	[Serializable]
	private sealed class Class411
	{
		// Token: 0x06001433 RID: 5171 RVA: 0x000534BC File Offset: 0x000516BC
		internal void method_0()
		{
			Class410.list_0.Clear();
			try
			{
				foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
				{
					if (driveInfo.IsReady)
					{
						Class410.list_0.Add(new Class410.Class413(driveInfo.Name.Remove(driveInfo.Name.Length - 2), driveInfo.DriveType.ToString(), (double)driveInfo.TotalSize / 1073741824.0, (double)driveInfo.AvailableFreeSpace / 1073741824.0, driveInfo.Name.Remove(driveInfo.Name.Length - 2).Contains("C") ? Class410.smethod_0() : 0.0));
					}
				}
			}
			catch (object obj)
			{
			}
		}

		// Token: 0x04000C3B RID: 3131
		public static readonly Class410.Class411 class411_0 = new Class410.Class411();

		// Token: 0x04000C3C RID: 3132
		public static Action action_0;
	}

	// Token: 0x02000384 RID: 900
	private sealed class Class412
	{
		// Token: 0x06001435 RID: 5173 RVA: 0x000535B8 File Offset: 0x000517B8
		internal void method_0()
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			try
			{
				Class410.list_0[this.int_0].method_5((double)(drives[this.int_0].AvailableFreeSpace / 1073741824L));
				Class410.list_0[this.int_0].method_7(drives[this.int_0].Name.Remove(drives[this.int_0].Name.Length - 2).Contains("C") ? Class410.smethod_0() : 0.0);
			}
			catch (object obj)
			{
			}
		}

		// Token: 0x04000C3D RID: 3133
		public int int_0;
	}

	// Token: 0x02000385 RID: 901
	public sealed class Class413
	{
		// Token: 0x06001436 RID: 5174 RVA: 0x00053664 File Offset: 0x00051864
		public Class413(string string_2, string string_3, double double_3, double double_4, double double_5)
		{
			this.DiskName = string_2;
			this.method_1(string_3);
			this.method_3(double_3);
			this.method_5(double_4);
			this.method_7(double_5);
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x00053694 File Offset: 0x00051894
		// (set) Token: 0x06001438 RID: 5176 RVA: 0x0005369C File Offset: 0x0005189C
		public string DiskName
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

		// Token: 0x06001439 RID: 5177 RVA: 0x000536A8 File Offset: 0x000518A8
		public string method_0()
		{
			return this.string_1;
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x000536B0 File Offset: 0x000518B0
		public void method_1(string string_2)
		{
			this.string_1 = string_2;
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x000536BC File Offset: 0x000518BC
		public double method_2()
		{
			return this.double_0;
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x000536C4 File Offset: 0x000518C4
		public void method_3(double double_3)
		{
			this.double_0 = double_3;
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x000536D0 File Offset: 0x000518D0
		public double method_4()
		{
			return this.double_1;
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x000536D8 File Offset: 0x000518D8
		public void method_5(double double_3)
		{
			this.double_1 = double_3;
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x000536E4 File Offset: 0x000518E4
		public double method_6()
		{
			return this.double_2;
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x000536EC File Offset: 0x000518EC
		public void method_7(double double_3)
		{
			this.double_2 = double_3;
		}

		// Token: 0x04000C3E RID: 3134
		private string string_0;

		// Token: 0x04000C3F RID: 3135
		private string string_1;

		// Token: 0x04000C40 RID: 3136
		private double double_0;

		// Token: 0x04000C41 RID: 3137
		private double double_1;

		// Token: 0x04000C42 RID: 3138
		private double double_2;
	}
}
