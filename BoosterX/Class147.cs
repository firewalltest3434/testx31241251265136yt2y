using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;

// Token: 0x02000105 RID: 261
internal sealed class Class147
{
	// Token: 0x0600077D RID: 1917 RVA: 0x0002444C File Offset: 0x0002264C
	public static Class726 smethod_0(bool bool_0)
	{
		if (bool_0)
		{
			Class147.class726_0.method_1();
		}
		return Class147.class726_0;
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x00024460 File Offset: 0x00022660
	public static Task<string> smethod_1(GClass179 gclass179_0)
	{
		Class147.Struct45 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass179_0 = gclass179_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class147.Struct45>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x000244A4 File Offset: 0x000226A4
	public static Task<string> smethod_2(GClass179 gclass179_0)
	{
		Class147.Struct44 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass179_0 = gclass179_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class147.Struct44>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x000244E8 File Offset: 0x000226E8
	public static Task<string> smethod_3(GClass179 gclass179_0)
	{
		Class147.Struct46 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass179_0 = gclass179_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class147.Struct46>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x0002452C File Offset: 0x0002272C
	internal static void smethod_4()
	{
		Class147.class726_0.method_2();
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x00024538 File Offset: 0x00022738
	internal static void smethod_5()
	{
		Class147.class726_0.method_3();
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x00024544 File Offset: 0x00022744
	internal static List<string> smethod_6()
	{
		List<string> list = new List<string>();
		foreach (Class745 @class in Class147.class726_0.Tweaks)
		{
			list.Add(@class.Name);
		}
		return list;
	}

	// Token: 0x040003E9 RID: 1001
	private static Class726 class726_0 = new Class726();

	// Token: 0x02000106 RID: 262
	[StructLayout(LayoutKind.Auto)]
	private struct Struct44 : IAsyncStateMachine
	{
		// Token: 0x06000784 RID: 1924 RVA: 0x000245A4 File Offset: 0x000227A4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			string result2;
			try
			{
				TaskAwaiter<Class289> awaiter;
				if (num != 0)
				{
					Class196<Guid> object_ = new Class196<Guid>(this.gclass179_0.Guid_0);
					awaiter = Class166.smethod_1(Class193.uri_16, object_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class289>, Class147.Struct44>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Class289>);
					this.int_0 = -1;
				}
				Class289 result = awaiter.GetResult();
				if (!result.Success)
				{
					result2 = Class364.smethod_0(result.Message);
				}
				else
				{
					try
					{
						File.Delete(Path.Combine(Class186.string_9, this.gclass179_0.Guid_0.ToString()));
					}
					catch (object obj)
					{
					}
					Class147.smethod_0(true);
					result2 = Class364.smethod_0("success");
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x000246E8 File Offset: 0x000228E8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040003EA RID: 1002
		public int int_0;

		// Token: 0x040003EB RID: 1003
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x040003EC RID: 1004
		public GClass179 gclass179_0;

		// Token: 0x040003ED RID: 1005
		private TaskAwaiter<Class289> taskAwaiter_0;
	}

	// Token: 0x02000107 RID: 263
	[StructLayout(LayoutKind.Auto)]
	private struct Struct45 : IAsyncStateMachine
	{
		// Token: 0x06000786 RID: 1926 RVA: 0x000246F8 File Offset: 0x000228F8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			string result2;
			try
			{
				TaskAwaiter<Class289> awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Class289>);
					this.int_0 = -1;
					goto IL_D1;
				}
				if (num != 1)
				{
					Guid guid_ = this.gclass179_0.Guid_0;
					Class196<Guid> object_ = new Class196<Guid>(this.gclass179_0.Guid_0);
					awaiter = Class166.smethod_1(Class193.uri_18, object_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class289>, Class147.Struct45>(ref awaiter, ref this);
						return;
					}
					goto IL_D1;
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Class289>);
					this.int_0 = -1;
				}
				IL_91:
				Class289 result = awaiter.GetResult();
				if (!result.Success)
				{
					result2 = Class364.smethod_0(result.Message);
					goto IL_1E6;
				}
				Class650.smethod_16(Path.Combine(Class186.string_9, this.class628_0.Id.ToString()), Class376.smethod_0(this.class628_0.Json), null);
				Class147.smethod_0(true);
				result2 = Class364.smethod_0("success");
				goto IL_1E6;
				IL_D1:
				if (awaiter.GetResult().Success)
				{
					result2 = Class364.smethod_0("TweakAlreadyExists");
				}
				else
				{
					this.gclass179_0.Guid_0 = Guid.NewGuid();
					this.class628_0 = new Class628<string, Guid, string>(Class389.class504_0.Key, this.gclass179_0.Guid_0, JsonConvert.SerializeObject(this.gclass179_0));
					awaiter = Class166.smethod_1(Class193.uri_15, this.class628_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class289>, Class147.Struct45>(ref awaiter, ref this);
						return;
					}
					goto IL_91;
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class628_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1E6:
			this.int_0 = -2;
			this.class628_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00024924 File Offset: 0x00022B24
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040003EE RID: 1006
		public int int_0;

		// Token: 0x040003EF RID: 1007
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x040003F0 RID: 1008
		public GClass179 gclass179_0;

		// Token: 0x040003F1 RID: 1009
		private Class628<string, Guid, string> class628_0;

		// Token: 0x040003F2 RID: 1010
		private TaskAwaiter<Class289> taskAwaiter_0;
	}

	// Token: 0x02000108 RID: 264
	[StructLayout(LayoutKind.Auto)]
	private struct Struct46 : IAsyncStateMachine
	{
		// Token: 0x06000788 RID: 1928 RVA: 0x00024934 File Offset: 0x00022B34
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			string result2;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					TaskAwaiter<Class289> awaiter2;
					if (num != 1)
					{
						Guid guid_ = this.gclass179_0.Guid_0;
						if (this.gclass179_0.Guid_0 == Guid.Empty)
						{
							awaiter = Class147.smethod_1(this.gclass179_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class147.Struct46>(ref awaiter, ref this);
								return;
							}
							goto IL_192;
						}
						else
						{
							this.class536_0 = new Class536<Guid, string>(this.gclass179_0.Guid_0, JsonConvert.SerializeObject(this.gclass179_0));
							awaiter2 = Class166.smethod_1(Class193.uri_17, this.class536_0).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								this.int_0 = 1;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class289>, Class147.Struct46>(ref awaiter2, ref this);
								return;
							}
						}
					}
					else
					{
						awaiter2 = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter<Class289>);
						this.int_0 = -1;
					}
					Class289 result = awaiter2.GetResult();
					if (!result.Success)
					{
						result2 = Class364.smethod_0(result.Message);
						goto IL_1C2;
					}
					Class650.smethod_17(Path.Combine(Class186.string_9, this.class536_0.Id.ToString()), Class376.smethod_0(this.class536_0.Json), null);
					Class147.smethod_0(true);
					result2 = Class364.smethod_0("success");
					goto IL_1C2;
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					this.int_0 = -1;
				}
				IL_192:
				result2 = awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class536_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1C2:
			this.int_0 = -2;
			this.class536_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00024B3C File Offset: 0x00022D3C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040003F3 RID: 1011
		public int int_0;

		// Token: 0x040003F4 RID: 1012
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x040003F5 RID: 1013
		public GClass179 gclass179_0;

		// Token: 0x040003F6 RID: 1014
		private Class536<Guid, string> class536_0;

		// Token: 0x040003F7 RID: 1015
		private TaskAwaiter<string> taskAwaiter_0;

		// Token: 0x040003F8 RID: 1016
		private TaskAwaiter<Class289> taskAwaiter_1;
	}
}
