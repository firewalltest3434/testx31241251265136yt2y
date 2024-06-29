using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ns0;

// Token: 0x02000264 RID: 612
internal sealed class Class310
{
	// Token: 0x06000E60 RID: 3680 RVA: 0x0003E554 File Offset: 0x0003C754
	public static Class744 smethod_0(bool bool_3)
	{
		if (!Class310.bool_0 || bool_3)
		{
			GClass93.smethod_0().method_17<Class524>();
			Class310.bool_1 = false;
			Class310.bool_0 = true;
			Class310.smethod_1();
		}
		return Class310.class744_0;
	}

	// Token: 0x06000E61 RID: 3681 RVA: 0x0003E584 File Offset: 0x0003C784
	public static void smethod_1()
	{
		Class310.Struct129 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class310.Struct129>(ref @struct);
	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x0003E5B4 File Offset: 0x0003C7B4
	public static void smethod_2()
	{
		Class310.Struct126 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class310.Struct126>(ref @struct);
	}

	// Token: 0x06000E63 RID: 3683 RVA: 0x0003E5E4 File Offset: 0x0003C7E4
	public static void smethod_3()
	{
		Class310.Struct127 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class310.Struct127>(ref @struct);
	}

	// Token: 0x06000E64 RID: 3684 RVA: 0x0003E614 File Offset: 0x0003C814
	public static Task smethod_4()
	{
		Class310.Struct128 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class310.Struct128>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000E65 RID: 3685 RVA: 0x0003E650 File Offset: 0x0003C850
	public static Task<List<Class188>> smethod_5()
	{
		Class310.Struct130 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class188>>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class310.Struct130>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x040008C4 RID: 2244
	private static Class744 class744_0 = new Class744();

	// Token: 0x040008C5 RID: 2245
	private static bool bool_0 = false;

	// Token: 0x040008C6 RID: 2246
	private static bool bool_1 = false;

	// Token: 0x040008C7 RID: 2247
	private static bool bool_2 = false;

	// Token: 0x02000265 RID: 613
	[StructLayout(LayoutKind.Auto)]
	private struct Struct126 : IAsyncStateMachine
	{
		// Token: 0x06000E66 RID: 3686 RVA: 0x0003E68C File Offset: 0x0003C88C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (!Class585.struct13_0.method_0())
					{
						goto IL_20A;
					}
					awaiter = Class310.smethod_4().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class310.Struct126>(ref awaiter, ref this);
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
				if (Class250.int_0 <= 2 & Class250.bool_0)
				{
					IEnumerator<Class716> enumerator = Class310.class744_0.DeviceViewModels.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class716 @class = enumerator.Current;
							if (@class.Name == Class364.smethod_0("mousehostcontroller"))
							{
								@class.bool_1 = false;
								@class.NewAffinity = "2";
							}
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				else if (Class250.int_0 <= 2 & !Class250.bool_0)
				{
					IEnumerator<Class716> enumerator = Class310.class744_0.DeviceViewModels.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class716 class2 = enumerator.Current;
							if (class2.Name == Class364.smethod_0("mousehostcontroller"))
							{
								class2.bool_1 = false;
								class2.NewAffinity = "1";
							}
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				else
				{
					int num4 = 0;
					IEnumerator<Class716> enumerator = Class310.class744_0.DeviceViewModels.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class310.Class316 class3 = new Class310.Class316();
							class3.class716_0 = enumerator.Current;
							if (!Class605.list_3.Any(new Func<string, bool>(class3.method_0)))
							{
								if (Class250.bool_0)
								{
									num4 += 2;
								}
								else
								{
									num4++;
								}
								class3.class716_0.bool_1 = false;
								class3.class716_0.NewAffinity = num4.ToString();
							}
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_20A:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x0003E91C File Offset: 0x0003CB1C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040008C8 RID: 2248
		public int int_0;

		// Token: 0x040008C9 RID: 2249
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040008CA RID: 2250
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000266 RID: 614
	private sealed class Class311
	{
		// Token: 0x06000E69 RID: 3689 RVA: 0x0003E934 File Offset: 0x0003CB34
		internal void method_0()
		{
			Class310.class744_0.DeviceViewModels.Last<Class716>().Name = this.string_0;
			Class310.class744_0.DeviceViewModels.Last<Class716>().Path = this.string_1;
			Class310.class744_0.DeviceViewModels.Last<Class716>().NewAffinity = this.string_2;
			Class310.bool_1 = true;
		}

		// Token: 0x040008CB RID: 2251
		public string string_0;

		// Token: 0x040008CC RID: 2252
		public string string_1;

		// Token: 0x040008CD RID: 2253
		public string string_2;
	}

	// Token: 0x02000267 RID: 615
	[StructLayout(LayoutKind.Auto)]
	private struct Struct127 : IAsyncStateMachine
	{
		// Token: 0x06000E6A RID: 3690 RVA: 0x0003E998 File Offset: 0x0003CB98
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (!Class585.struct13_0.method_0())
					{
						goto IL_D0;
					}
					awaiter = Class310.smethod_4().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class310.Struct127>(ref awaiter, ref this);
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
				IEnumerator<Class716> enumerator = Class310.class744_0.DeviceViewModels.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class716 @class = enumerator.Current;
						@class.bool_1 = false;
						@class.NewAffinity = "default";
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_D0:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x0003EAA4 File Offset: 0x0003CCA4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040008CE RID: 2254
		public int int_0;

		// Token: 0x040008CF RID: 2255
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040008D0 RID: 2256
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000268 RID: 616
	private sealed class Class312
	{
		// Token: 0x06000E6D RID: 3693 RVA: 0x0003EABC File Offset: 0x0003CCBC
		internal void method_0()
		{
			Class310.class744_0.DeviceViewModels.Last<Class716>().Name = this.string_0;
			Class310.class744_0.DeviceViewModels.Last<Class716>().Path = this.string_1;
			Class310.class744_0.DeviceViewModels.Last<Class716>().NewAffinity = this.string_2;
			Class310.bool_1 = true;
		}

		// Token: 0x040008D1 RID: 2257
		public string string_0;

		// Token: 0x040008D2 RID: 2258
		public string string_1;

		// Token: 0x040008D3 RID: 2259
		public string string_2;
	}

	// Token: 0x02000269 RID: 617
	[StructLayout(LayoutKind.Auto)]
	private struct Struct128 : IAsyncStateMachine
	{
		// Token: 0x06000E6E RID: 3694 RVA: 0x0003EB20 File Offset: 0x0003CD20
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_5E;
				}
				this.int_1 = 0;
				IL_41:
				if (Class310.bool_1)
				{
					goto IL_AD;
				}
				awaiter = Task.Delay(40).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class310.Struct128>(ref awaiter, ref this);
					return;
				}
				IL_5E:
				awaiter.GetResult();
				if (this.int_1 <= 1000)
				{
					int num2 = this.int_1;
					this.int_1 = num2 + 1;
					goto IL_41;
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_AD:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x0003EC00 File Offset: 0x0003CE00
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040008D4 RID: 2260
		public int int_0;

		// Token: 0x040008D5 RID: 2261
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040008D6 RID: 2262
		private int int_1;

		// Token: 0x040008D7 RID: 2263
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200026A RID: 618
	[StructLayout(LayoutKind.Auto)]
	private struct Struct129 : IAsyncStateMachine
	{
		// Token: 0x06000E70 RID: 3696 RVA: 0x0003EC10 File Offset: 0x0003CE10
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					Class310.Class314 @class = new Class310.Class314();
					if (Class310.bool_2)
					{
						goto IL_A5;
					}
					Class310.bool_2 = true;
					@class.bool_0 = false;
					awaiter = Task.Run(new Action(@class.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class310.Struct129>(ref awaiter, ref this);
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
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_A5:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0003ECE8 File Offset: 0x0003CEE8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040008D8 RID: 2264
		public int int_0;

		// Token: 0x040008D9 RID: 2265
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040008DA RID: 2266
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200026B RID: 619
	[Serializable]
	private sealed class Class313
	{
		// Token: 0x06000E74 RID: 3700 RVA: 0x0003ED0C File Offset: 0x0003CF0C
		internal void method_0()
		{
			Class310.class744_0.DeviceViewModels.Clear();
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x0003ED20 File Offset: 0x0003CF20
		internal void method_1()
		{
			Class716 item = new Class716(Class310.class744_0)
			{
				Name = Class364.smethod_0("Searching"),
				DeviceTypeName = "Mouse",
				Icon = Class364.smethod_2("MouseSvg")
			};
			Class310.class744_0.DeviceViewModels.Add(item);
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x0003ED74 File Offset: 0x0003CF74
		internal void method_2()
		{
			Class310.class744_0.DeviceViewModels.Remove(Class310.class744_0.DeviceViewModels.Last<Class716>());
		}

		// Token: 0x040008DB RID: 2267
		public static readonly Class310.Class313 class313_0 = new Class310.Class313();

		// Token: 0x040008DC RID: 2268
		public static Action action_0;

		// Token: 0x040008DD RID: 2269
		public static Action action_1;

		// Token: 0x040008DE RID: 2270
		public static Action action_2;
	}

	// Token: 0x0200026C RID: 620
	private sealed class Class314
	{
		// Token: 0x06000E78 RID: 3704 RVA: 0x0003EDA0 File Offset: 0x0003CFA0
		internal void method_0()
		{
			try
			{
				Application.Current.Dispatcher.Invoke(new Action(Class310.Class313.class313_0.method_0));
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					Class310.Class315 @class = new Class310.Class315();
					@class.string_0 = managementObject.GetPropertyValue("Description").ToString();
					@class.string_1 = "GPU";
					@class.drawingImage_0 = Class364.smethod_2("GPUSvg");
					@class.string_2 = managementObject.GetPropertyValue("PNPDeviceID").ToString();
					@class.string_3 = Class672.smethod_0(managementObject.GetPropertyValue("PNPDeviceID").ToString());
					Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
				}
				Application.Current.Dispatcher.Invoke(new Action(Class310.Class313.class313_0.method_1));
				int num = 0;
				managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_USBController");
				foreach (ManagementObject managementObject2 in managementObjectSearcher.Get().Cast<ManagementObject>())
				{
					string string_ = managementObject2["Description"].ToString();
					if (string_.smethod_2("host") || string_.smethod_2("хост"))
					{
						num++;
					}
				}
				if (num == 1)
				{
					foreach (ManagementObject managementObject3 in managementObjectSearcher.Get().Cast<ManagementObject>())
					{
						string string_2 = managementObject3["Description"].ToString();
						if (string_2.smethod_2("host") || string_2.smethod_2("хост"))
						{
							Class310.Class312 class2 = new Class310.Class312();
							class2.string_0 = Class364.smethod_0("mousehostcontroller");
							class2.string_1 = managementObject3.GetPropertyValue("PNPDeviceID").ToString();
							class2.string_2 = Class672.smethod_0(managementObject3.GetPropertyValue("PNPDeviceID").ToString());
							Application.Current.Dispatcher.Invoke(new Action(class2.method_0));
							this.bool_0 = true;
							return;
						}
					}
				}
				managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM win32_pointingdevice");
				foreach (ManagementObject managementObject4 in managementObjectSearcher.Get().Cast<ManagementObject>())
				{
					if (this.bool_0)
					{
						break;
					}
					ManagementObject managementObject5 = managementObject4;
					try
					{
						while (!this.bool_0)
						{
							managementObject5 = Class672.smethod_3(Class672.smethod_2(managementObject5));
							if (managementObject5.GetPropertyValue("Description").ToString().smethod_2("I2C"))
							{
								break;
							}
							foreach (string string_3 in Class605.list_8)
							{
								if (this.bool_0)
								{
									break;
								}
								if (managementObject5.GetPropertyValue("Description").ToString().smethod_2(string_3))
								{
									Class310.Class311 class3 = new Class310.Class311();
									class3.string_0 = Class364.smethod_0("mousehostcontroller");
									class3.string_1 = managementObject5.GetPropertyValue("PNPDeviceID").ToString();
									class3.string_2 = Class672.smethod_0(managementObject5.GetPropertyValue("PNPDeviceID").ToString());
									Application.Current.Dispatcher.Invoke(new Action(class3.method_0));
									this.bool_0 = true;
								}
							}
						}
					}
					catch (object obj)
					{
					}
				}
			}
			catch (object obj2)
			{
			}
			finally
			{
				if (!this.bool_0)
				{
					Application.Current.Dispatcher.Invoke(new Action(Class310.Class313.class313_0.method_2));
				}
				Class310.bool_1 = true;
				Class310.bool_2 = false;
			}
		}

		// Token: 0x040008DF RID: 2271
		public bool bool_0;
	}

	// Token: 0x0200026D RID: 621
	[StructLayout(LayoutKind.Auto)]
	private struct Struct130 : IAsyncStateMachine
	{
		// Token: 0x06000E79 RID: 3705 RVA: 0x0003F2D0 File Offset: 0x0003D4D0
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
					Class310.smethod_0(false);
					awaiter = Class310.smethod_4().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class310.Struct130>(ref awaiter, ref this);
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
				IEnumerator<Class716> enumerator = Class310.class744_0.DeviceViewModels.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class716 @class = enumerator.Current;
						try
						{
							this.list_0.Add(new Class188
							{
								Type = dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.Affinity,
								Name = @class.Name,
								State = @class.Affinity
							});
						}
						catch (object obj)
						{
						}
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				result = this.list_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.list_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.list_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x0003F428 File Offset: 0x0003D628
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040008E0 RID: 2272
		public int int_0;

		// Token: 0x040008E1 RID: 2273
		public AsyncTaskMethodBuilder<List<Class188>> asyncTaskMethodBuilder_0;

		// Token: 0x040008E2 RID: 2274
		private List<Class188> list_0;

		// Token: 0x040008E3 RID: 2275
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200026E RID: 622
	private sealed class Class315
	{
		// Token: 0x06000E7C RID: 3708 RVA: 0x0003F440 File Offset: 0x0003D640
		internal void method_0()
		{
			Class310.class744_0.DeviceViewModels.Add(new Class716(Class310.class744_0)
			{
				Name = this.string_0,
				DeviceTypeName = this.string_1,
				Icon = this.drawingImage_0,
				Path = this.string_2,
				NewAffinity = this.string_3
			});
			Class310.class744_0.DeviceViewModels.First<Class716>().IsChecked = true;
		}

		// Token: 0x040008E4 RID: 2276
		public string string_0;

		// Token: 0x040008E5 RID: 2277
		public string string_1;

		// Token: 0x040008E6 RID: 2278
		public DrawingImage drawingImage_0;

		// Token: 0x040008E7 RID: 2279
		public string string_2;

		// Token: 0x040008E8 RID: 2280
		public string string_3;
	}

	// Token: 0x0200026F RID: 623
	private sealed class Class316
	{
		// Token: 0x06000E7E RID: 3710 RVA: 0x0003F4C0 File Offset: 0x0003D6C0
		internal bool method_0(string string_0)
		{
			return this.class716_0.Name.ToLower().Contains(string_0);
		}

		// Token: 0x040008E9 RID: 2281
		public Class716 class716_0;
	}
}
