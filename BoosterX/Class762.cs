using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ns0;

// Token: 0x02000679 RID: 1657
internal sealed class Class762
{
	// Token: 0x06002398 RID: 9112 RVA: 0x0008D894 File Offset: 0x0008BA94
	public static Task smethod_0(string string_0)
	{
		Class762.Struct385 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class762.Struct385>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002399 RID: 9113 RVA: 0x0008D8D8 File Offset: 0x0008BAD8
	private static Task<List<Class188>> smethod_1()
	{
		Class762.Struct386 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class188>>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class762.Struct386>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0200067A RID: 1658
	private sealed class Class763
	{
		// Token: 0x0600239B RID: 9115 RVA: 0x0008D91C File Offset: 0x0008BB1C
		internal Task method_0()
		{
			Class762.Class763.Struct384 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class763_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class762.Class763.Struct384>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0400183B RID: 6203
		public string string_0;

		// Token: 0x0200067B RID: 1659
		[StructLayout(LayoutKind.Auto)]
		private struct Struct384 : IAsyncStateMachine
		{
			// Token: 0x0600239C RID: 9116 RVA: 0x0008D960 File Offset: 0x0008BB60
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class762.Class763 @class = this.class763_0;
				try
				{
					TaskAwaiter<List<Class188>> awaiter;
					switch (num)
					{
					case 0:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<Class188>>);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						break;
					}
					case 1:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<Class188>>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
						goto IL_188;
					}
					case 2:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<Class188>>);
						int num4 = -1;
						num = -1;
						this.int_0 = num4;
						goto IL_205;
					}
					case 3:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<Class188>>);
						int num5 = -1;
						num = -1;
						this.int_0 = num5;
						goto IL_2B4;
					}
					case 4:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<Class188>>);
						int num6 = -1;
						num = -1;
						this.int_0 = num6;
						goto IL_341;
					}
					case 5:
					{
						IL_3A1:
						try
						{
							TaskAwaiter awaiter2;
							if (num != 5)
							{
								if (!dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_3)
								{
									goto IL_435;
								}
								awaiter2 = GClass113.smethod_9().GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									int num7 = 5;
									num = 5;
									this.int_0 = num7;
									this.taskAwaiter_1 = awaiter2;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class762.Class763.Struct384>(ref awaiter2, ref this);
									return;
								}
							}
							else
							{
								awaiter2 = this.taskAwaiter_1;
								this.taskAwaiter_1 = default(TaskAwaiter);
								int num8 = -1;
								num = -1;
								this.int_0 = num8;
							}
							awaiter2.GetResult();
							this.list_1.Add(new ValueTuple<string, byte[]>("NVIDIA.nvx", GClass113.smethod_27().smethod_20(true)));
							IL_435:;
						}
						catch (Exception exception_)
						{
							GClass141.smethod_0(exception_);
						}
						int num9 = 0;
						try
						{
							while (File.Exists(Class186.string_6 + string.Format("\\{0}_{1}.buxz", @class.string_0, num9)))
							{
								num9++;
							}
							GClass26 gclass = new GClass26(Class186.string_6 + string.Format("\\{0}_{1}.buxz", @class.string_0, num9));
							try
							{
								gclass.method_1(this.list_1);
								gclass.Dispose();
							}
							finally
							{
								if (num < 0 && gclass != null)
								{
									((IDisposable)gclass).Dispose();
								}
							}
						}
						catch (Exception exception_2)
						{
							GClass141.smethod_0(exception_2);
						}
						goto IL_510;
					}
					default:
						this.list_0 = new List<Class188>();
						this.list_2 = this.list_0;
						awaiter = Class588.smethod_14().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num10 = 0;
							num = 0;
							this.int_0 = num10;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class188>>, Class762.Class763.Struct384>(ref awaiter, ref this);
							return;
						}
						break;
					}
					List<Class188> result = awaiter.GetResult();
					this.list_2.AddRange(result);
					this.list_2 = null;
					try
					{
						byte[] array = GClass76.smethod_1();
						if (array != null)
						{
							Class571 class2 = new Class571
							{
								Name = "PowerX v2",
								Guid = "66666666-6666-6666-6666-666666666666",
								Data = array
							};
							this.list_0.Add(new Class188
							{
								Type = dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.Power,
								Name = "CurrentProfile",
								State = JsonConvert.SerializeObject(class2)
							});
						}
					}
					catch (Exception exception_3)
					{
						GClass141.smethod_0(exception_3);
					}
					this.list_2 = this.list_0;
					awaiter = Class462.smethod_5().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num11 = 1;
						num = 1;
						this.int_0 = num11;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class188>>, Class762.Class763.Struct384>(ref awaiter, ref this);
						return;
					}
					IL_188:
					result = awaiter.GetResult();
					this.list_2.AddRange(result);
					this.list_2 = null;
					this.list_2 = this.list_0;
					awaiter = Class150.smethod_6().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num12 = 2;
						num = 2;
						this.int_0 = num12;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class188>>, Class762.Class763.Struct384>(ref awaiter, ref this);
						return;
					}
					IL_205:
					result = awaiter.GetResult();
					this.list_2.AddRange(result);
					this.list_2 = null;
					this.list_0.Add(new Class188
					{
						Type = dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.Affinity,
						Name = "ThreadsCount",
						State = Class389.class504_0.method_60()
					});
					this.list_2 = this.list_0;
					awaiter = Class310.smethod_5().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num13 = 3;
						num = 3;
						this.int_0 = num13;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class188>>, Class762.Class763.Struct384>(ref awaiter, ref this);
						return;
					}
					IL_2B4:
					result = awaiter.GetResult();
					this.list_2.AddRange(result);
					this.list_2 = null;
					this.list_0.AddRange(Class576.smethod_0());
					this.list_2 = this.list_0;
					awaiter = Class762.smethod_1().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num14 = 4;
						num = 4;
						this.int_0 = num14;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class188>>, Class762.Class763.Struct384>(ref awaiter, ref this);
						return;
					}
					IL_341:
					result = awaiter.GetResult();
					this.list_2.AddRange(result);
					this.list_2 = null;
					Class660 class660_ = new Class660
					{
						DateTime_0 = DateTime.Now,
						List_0 = this.list_0
					};
					this.list_1 = new List<ValueTuple<string, byte[]>>();
					this.list_1.Add(new ValueTuple<string, byte[]>("BOOSTER.bux", Class482.smethod_0(class660_)));
					goto IL_3A1;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.list_0 = null;
					this.list_1 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_510:
				this.int_0 = -2;
				this.list_0 = null;
				this.list_1 = null;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x0600239D RID: 9117 RVA: 0x0008DF1C File Offset: 0x0008C11C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400183C RID: 6204
			public int int_0;

			// Token: 0x0400183D RID: 6205
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x0400183E RID: 6206
			public Class762.Class763 class763_0;

			// Token: 0x0400183F RID: 6207
			private List<Class188> list_0;

			// Token: 0x04001840 RID: 6208
			private List<ValueTuple<string, byte[]>> list_1;

			// Token: 0x04001841 RID: 6209
			private List<Class188> list_2;

			// Token: 0x04001842 RID: 6210
			private TaskAwaiter<List<Class188>> taskAwaiter_0;

			// Token: 0x04001843 RID: 6211
			private TaskAwaiter taskAwaiter_1;
		}
	}

	// Token: 0x0200067C RID: 1660
	[StructLayout(LayoutKind.Auto)]
	private struct Struct385 : IAsyncStateMachine
	{
		// Token: 0x0600239E RID: 9118 RVA: 0x0008DF2C File Offset: 0x0008C12C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(new Class762.Class763
					{
						string_0 = this.string_0
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class762.Struct385>(ref awaiter, ref this);
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

		// Token: 0x0600239F RID: 9119 RVA: 0x0008DFF4 File Offset: 0x0008C1F4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001844 RID: 6212
		public int int_0;

		// Token: 0x04001845 RID: 6213
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001846 RID: 6214
		public string string_0;

		// Token: 0x04001847 RID: 6215
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200067D RID: 1661
	[StructLayout(LayoutKind.Auto)]
	private struct Struct386 : IAsyncStateMachine
	{
		// Token: 0x060023A0 RID: 9120 RVA: 0x0008E004 File Offset: 0x0008C204
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<Class188> result;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					this.list_0 = new List<Class188>();
					this.gclass223_0 = GClass161.smethod_0(false);
					awaiter = GClass161.smethod_5().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class762.Struct386>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				IEnumerator<GClass221> enumerator = this.gclass223_0.MsiSupportedDevices.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						GClass221 gclass = enumerator.Current;
						this.list_0.Add(new Class188
						{
							Type = dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.DevicesMSI,
							Name = gclass.Name,
							State = gclass.MsiCurrentStatus.ToString()
						});
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				enumerator = this.gclass223_0.CanBeDisabled.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						GClass221 gclass2 = enumerator.Current;
						this.list_0.Add(new Class188
						{
							Type = dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.DevicesDisabled,
							Name = gclass2.Name,
							State = gclass2.CurrentStatus.ToString()
						});
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				IEnumerator<GClass226> enumerator2 = this.gclass223_0.CustomDisableDevices.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						GClass226 gclass3 = enumerator2.Current;
						if (gclass3.CurrentIsDisabled != null)
						{
							this.list_0.Add(new Class188
							{
								Type = dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.DevicesGroupDisabled,
								Name = gclass3.Name,
								State = gclass3.CurrentIsDisabled.ToString()
							});
						}
					}
				}
				finally
				{
					if (num < 0 && enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
				result = this.list_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.list_0 = null;
				this.gclass223_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.list_0 = null;
			this.gclass223_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x0008E2B4 File Offset: 0x0008C4B4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001848 RID: 6216
		public int int_0;

		// Token: 0x04001849 RID: 6217
		public AsyncTaskMethodBuilder<List<Class188>> asyncTaskMethodBuilder_0;

		// Token: 0x0400184A RID: 6218
		private List<Class188> list_0;

		// Token: 0x0400184B RID: 6219
		private GClass161.GClass223 gclass223_0;

		// Token: 0x0400184C RID: 6220
		private TaskAwaiter taskAwaiter_0;
	}
}
