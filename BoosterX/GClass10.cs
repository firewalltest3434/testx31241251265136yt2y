using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x0200036D RID: 877
public sealed class GClass10 : GClass7
{
	// Token: 0x0600139A RID: 5018 RVA: 0x00051B1C File Offset: 0x0004FD1C
	public GClass10(GClass42 gclass42_1, GClass8 gclass8_1) : base(gclass42_1, gclass8_1)
	{
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x00051B54 File Offset: 0x0004FD54
	private bool method_20(IntPtr intptr_0, IntPtr intptr_1, GStruct3 gstruct3_0, ref int int_0, uint uint_1, bool bool_0, ref List<uint> list_2)
	{
		if ((long)int_0 >= (long)((ulong)gstruct3_0.uint_3))
		{
			return false;
		}
		GStruct1 gstruct = default(GStruct1);
		gstruct.uint_0 = GClass202.uint_1;
		if (GClass202.smethod_6(intptr_0, intptr_1, uint_1, ref gstruct) != GEnum0.NVAPI_OK)
		{
			return false;
		}
		if (gstruct.genum1_0 != (GEnum1)0)
		{
			return false;
		}
		if (!bool_0 && gstruct.uint_2 == 1U)
		{
			int_0++;
		}
		else
		{
			if (bool_0)
			{
				if (this.gclass8_0 != null)
				{
					this.gclass8_0.method_23(gstruct3_0.string_0, ref gstruct);
				}
				int_0++;
				this.method_23(gstruct3_0, gstruct);
				list_2.Add(gstruct.uint_1);
				return gstruct.uint_2 != 1U;
			}
			if (gstruct.uint_2 != 1U)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600139C RID: 5020 RVA: 0x00051C24 File Offset: 0x0004FE24
	private int method_21(int int_0, int int_1)
	{
		if (int_0 <= 0)
		{
			return 0;
		}
		return (int)Math.Round((double)((float)int_0 * 100f / (float)int_1));
	}

	// Token: 0x0600139D RID: 5021 RVA: 0x00051C44 File Offset: 0x0004FE44
	public Task method_22(bool bool_0, IProgress<int> iprogress_0, CancellationToken cancellationToken_0)
	{
		GClass10.Struct178 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass10_0 = this;
		@struct.bool_0 = bool_0;
		@struct.iprogress_0 = iprogress_0;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass10.Struct178>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600139E RID: 5022 RVA: 0x00051CA0 File Offset: 0x0004FEA0
	private void method_23(GStruct3 gstruct3_0, GStruct1 gstruct1_0)
	{
		GClass10.Class403 @class = new GClass10.Class403();
		@class.gstruct1_0 = gstruct1_0;
		bool flag = (@class.gstruct1_0.uint_1 & 1879048192U) != 1879048192U;
		GClass75 gclass = this.list_0.FirstOrDefault(new Func<GClass75, bool>(@class.method_0));
		if (@class.gstruct1_0.uint_3 == 1U)
		{
			if (flag)
			{
				if (@class.gstruct1_0.nvdrs_SETTING_TYPE_0 == NVDRS_SETTING_TYPE.NVDRS_WSTRING_TYPE)
				{
					gclass.method_1(@class.gstruct1_0.nvdrs_SETTING_UNION_0.stringValue, gstruct3_0.string_0);
				}
				else if (@class.gstruct1_0.nvdrs_SETTING_TYPE_0 == NVDRS_SETTING_TYPE.NVDRS_DWORD_TYPE)
				{
					gclass.method_0(@class.gstruct1_0.nvdrs_SETTING_UNION_0.dwordValue, gstruct3_0.string_0);
				}
				else if (@class.gstruct1_0.nvdrs_SETTING_TYPE_0 == NVDRS_SETTING_TYPE.NVDRS_BINARY_TYPE)
				{
					gclass.method_2(@class.gstruct1_0.nvdrs_SETTING_UNION_0.binaryValue, gstruct3_0.string_0);
				}
			}
			else
			{
				gclass.uint_1 += 1U;
			}
			bool flag2;
			if (!flag2)
			{
				this.list_0.Add(gclass);
			}
		}
	}

	// Token: 0x0600139F RID: 5023 RVA: 0x00051DBC File Offset: 0x0004FFBC
	public string method_24(string string_0)
	{
		GClass10.Class404 @class = new GClass10.Class404();
		@class.gclass10_0 = this;
		string b = string_0.ToLowerInvariant();
		@class.string_0 = "C:\\Users\\Administrator\\AppData\\Local\\Temp\\26134099d9cf4cb58606965d480c33d0";
		string result;
		try
		{
			List<string> list = new List<string>();
			base.method_1(new Action<IntPtr>(@class.method_0), false, false);
			if (File.Exists(@class.string_0))
			{
				foreach (object obj in Regex.Matches(File.ReadAllText(@class.string_0), "\\sProfile\\s\\\"(?<profile>.*?)\\\"(?<scope>.*?Executable.*?)EndProfile", RegexOptions.Singleline))
				{
					Match match = (Match)obj;
					using (IEnumerator enumerator2 = Regex.Matches(match.Result("${scope}"), "Executable\\s\\\"(?<app>.*?)\\\"", RegexOptions.Singleline).GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (((Match)enumerator2.Current).Result("${app}").ToLowerInvariant() == b)
							{
								list.Add(match.Result("${profile}"));
							}
						}
					}
				}
			}
			result = string.Join(";", list);
		}
		finally
		{
			if (File.Exists(@class.string_0))
			{
				File.Delete(@class.string_0);
			}
		}
		return result;
	}

	// Token: 0x04000BF3 RID: 3059
	public List<GClass75> list_0 = new List<GClass75>();

	// Token: 0x04000BF4 RID: 3060
	public List<GClass136> list_1;

	// Token: 0x04000BF5 RID: 3061
	public HashSet<GClass136> hashSet_0 = new HashSet<GClass136>();

	// Token: 0x04000BF6 RID: 3062
	private readonly uint[] uint_0 = new uint[]
	{
		278257400U,
		271834322U,
		271830721U,
		278073158U,
		10512710U,
		283958146U,
		552327096U,
		9821945U,
		13983613U,
		271834323U,
		271830722U,
		544403510U,
		6701881U,
		2916165U,
		546784961U,
		7790948U,
		553612435U,
		541917051U
	};

	// Token: 0x0200036E RID: 878
	private sealed class Class402
	{
		// Token: 0x060013A1 RID: 5025 RVA: 0x00051F6C File Offset: 0x0005016C
		internal void method_0(IntPtr intptr_0)
		{
			this.class405_0.gclass10_0.method_3(intptr_0, string.Empty);
			List<IntPtr> list = this.class405_0.gclass10_0.method_14(intptr_0);
			int count = list.Count;
			int num = 0;
			foreach (IntPtr intptr_ in list)
			{
				if (this.class405_0.cancellationToken_0.IsCancellationRequested)
				{
					break;
				}
				IProgress<int> iprogress_ = this.class405_0.iprogress_0;
				if (iprogress_ != null)
				{
					iprogress_.Report(this.class405_0.gclass10_0.method_21(num++, count));
				}
				GStruct3 gstruct = this.class405_0.gclass10_0.method_5(intptr_0, intptr_);
				int num2 = 0;
				List<uint> list2 = new List<uint>();
				bool flag = false;
				if (gstruct.uint_1 == 0U)
				{
					this.class405_0.gclass10_0.list_1.Add(new GClass136(gstruct));
					this.class405_0.gclass10_0.hashSet_0.Add(new GClass136(gstruct));
					flag = true;
					if (this.class405_0.bool_0)
					{
						continue;
					}
				}
				foreach (uint uint_ in this.list_0)
				{
					if (this.class405_0.gclass10_0.method_20(intptr_0, intptr_, gstruct, ref num2, uint_, !this.class405_0.bool_0, ref list2) && !flag)
					{
						flag = true;
						this.class405_0.gclass10_0.list_1.Add(new GClass136(gstruct));
						if (this.class405_0.bool_0)
						{
							break;
						}
					}
				}
				if (!(flag & this.class405_0.bool_0) && (long)num2 < (long)((ulong)gstruct.uint_3))
				{
					foreach (GStruct1 gstruct2 in this.class405_0.gclass10_0.method_15(intptr_0, intptr_))
					{
						if (this.list_0.IndexOf(gstruct2.uint_1) < 0)
						{
							this.list_0.Add(gstruct2.uint_1);
						}
						if (!this.class405_0.bool_0 && list2.IndexOf(gstruct2.uint_1) < 0)
						{
							this.class405_0.gclass10_0.method_23(gstruct, gstruct2);
						}
						if (gstruct2.uint_2 != 1U && !flag)
						{
							flag = true;
							this.class405_0.gclass10_0.list_1.Add(new GClass136(gstruct));
							if (this.class405_0.bool_0)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x04000BF7 RID: 3063
		public List<uint> list_0;

		// Token: 0x04000BF8 RID: 3064
		public GClass10.Class405 class405_0;
	}

	// Token: 0x0200036F RID: 879
	private sealed class Class403
	{
		// Token: 0x060013A3 RID: 5027 RVA: 0x000522A0 File Offset: 0x000504A0
		internal bool method_0(GClass75 gclass75_0)
		{
			return gclass75_0.uint_0.Equals(this.gstruct1_0.uint_1);
		}

		// Token: 0x04000BF9 RID: 3065
		public GStruct1 gstruct1_0;
	}

	// Token: 0x02000370 RID: 880
	private sealed class Class404
	{
		// Token: 0x060013A5 RID: 5029 RVA: 0x000522C0 File Offset: 0x000504C0
		internal void method_0(IntPtr intptr_0)
		{
			this.gclass10_0.method_19(intptr_0, this.string_0);
		}

		// Token: 0x04000BFA RID: 3066
		public GClass10 gclass10_0;

		// Token: 0x04000BFB RID: 3067
		public string string_0;
	}

	// Token: 0x02000371 RID: 881
	[StructLayout(LayoutKind.Auto)]
	private struct Struct178 : IAsyncStateMachine
	{
		// Token: 0x060013A6 RID: 5030 RVA: 0x000522D4 File Offset: 0x000504D4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(new GClass10.Class405
					{
						gclass10_0 = this.gclass10_0,
						cancellationToken_0 = this.cancellationToken_0,
						iprogress_0 = this.iprogress_0,
						bool_0 = this.bool_0
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass10.Struct178>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x000523C0 File Offset: 0x000505C0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000BFC RID: 3068
		public int int_0;

		// Token: 0x04000BFD RID: 3069
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000BFE RID: 3070
		public GClass10 gclass10_0;

		// Token: 0x04000BFF RID: 3071
		public CancellationToken cancellationToken_0;

		// Token: 0x04000C00 RID: 3072
		public IProgress<int> iprogress_0;

		// Token: 0x04000C01 RID: 3073
		public bool bool_0;

		// Token: 0x04000C02 RID: 3074
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000372 RID: 882
	private sealed class Class405
	{
		// Token: 0x060013A9 RID: 5033 RVA: 0x000523D8 File Offset: 0x000505D8
		internal void method_0()
		{
			GClass10.Class402 @class = new GClass10.Class402();
			@class.class405_0 = this;
			this.gclass10_0.list_1 = new List<GClass136>();
			this.gclass10_0.hashSet_0 = new HashSet<GClass136>();
			@class.list_0 = new List<uint>(this.gclass10_0.uint_0);
			this.gclass10_0.method_1(new Action<IntPtr>(@class.method_0), false, false);
		}

		// Token: 0x04000C03 RID: 3075
		public GClass10 gclass10_0;

		// Token: 0x04000C04 RID: 3076
		public CancellationToken cancellationToken_0;

		// Token: 0x04000C05 RID: 3077
		public IProgress<int> iprogress_0;

		// Token: 0x04000C06 RID: 3078
		public bool bool_0;
	}
}
