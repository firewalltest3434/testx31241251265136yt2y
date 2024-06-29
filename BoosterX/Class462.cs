using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ns0;

// Token: 0x020003F5 RID: 1013
internal sealed class Class462
{
	// Token: 0x0600160D RID: 5645 RVA: 0x0005CD7C File Offset: 0x0005AF7C
	public static Class730 smethod_0(bool bool_2)
	{
		if (!Class462.bool_0 || bool_2)
		{
			Class462.bool_0 = true;
			Class462.bool_1 = false;
			GClass93.smethod_0().method_17<Class523>();
			Class462.smethod_1();
		}
		return Class462.class730_0;
	}

	// Token: 0x0600160E RID: 5646 RVA: 0x0005CDAC File Offset: 0x0005AFAC
	public static void smethod_1()
	{
		Class462.Struct220 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class462.Struct220>(ref @struct);
	}

	// Token: 0x0600160F RID: 5647 RVA: 0x0005CDDC File Offset: 0x0005AFDC
	public static void smethod_2()
	{
		Class462.Struct217 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class462.Struct217>(ref @struct);
	}

	// Token: 0x06001610 RID: 5648 RVA: 0x0005CE0C File Offset: 0x0005B00C
	public static void smethod_3()
	{
		Class462.Struct219 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class462.Struct219>(ref @struct);
	}

	// Token: 0x06001611 RID: 5649 RVA: 0x0005CE3C File Offset: 0x0005B03C
	public static Task smethod_4()
	{
		Class462.Struct216 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class462.Struct216>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001612 RID: 5650 RVA: 0x0005CE78 File Offset: 0x0005B078
	public static Task<List<Class188>> smethod_5()
	{
		Class462.Struct218 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class188>>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class462.Struct218>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04000EEF RID: 3823
	private static Class730 class730_0 = new Class730();

	// Token: 0x04000EF0 RID: 3824
	private static bool bool_0 = false;

	// Token: 0x04000EF1 RID: 3825
	private static bool bool_1 = false;

	// Token: 0x020003F6 RID: 1014
	[StructLayout(LayoutKind.Auto)]
	private struct Struct216 : IAsyncStateMachine
	{
		// Token: 0x06001613 RID: 5651 RVA: 0x0005CEB4 File Offset: 0x0005B0B4
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
				if (Class462.bool_1)
				{
					goto IL_AD;
				}
				awaiter = Task.Delay(20).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class462.Struct216>(ref awaiter, ref this);
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

		// Token: 0x06001614 RID: 5652 RVA: 0x0005CF94 File Offset: 0x0005B194
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000EF2 RID: 3826
		public int int_0;

		// Token: 0x04000EF3 RID: 3827
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000EF4 RID: 3828
		private int int_1;

		// Token: 0x04000EF5 RID: 3829
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003F7 RID: 1015
	[StructLayout(LayoutKind.Auto)]
	private struct Struct217 : IAsyncStateMachine
	{
		// Token: 0x06001615 RID: 5653 RVA: 0x0005CFA4 File Offset: 0x0005B1A4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (!Class462.bool_0)
					{
						Class462.smethod_0(false);
					}
					awaiter = Class462.smethod_4().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class462.Struct217>(ref awaiter, ref this);
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
				if (Class462.class730_0.WinUwpAppsModels.Count != 0)
				{
					IEnumerator<Class713> enumerator = Class462.class730_0.WinUwpAppsModels.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class462.Class464 @class = new Class462.Class464();
							@class.class713_0 = enumerator.Current;
							if (Class605.list_10.Any(new Func<string, bool>(@class.method_0)))
							{
								@class.class713_0.ToDelete = true;
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
				IEnumerator<Class745> enumerator2 = Class462.class730_0.CustomDebloatList.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						Class745 class2 = enumerator2.Current;
						class2.method_15();
					}
				}
				finally
				{
					if (num < 0 && enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x0005D148 File Offset: 0x0005B348
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000EF6 RID: 3830
		public int int_0;

		// Token: 0x04000EF7 RID: 3831
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000EF8 RID: 3832
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003F8 RID: 1016
	[StructLayout(LayoutKind.Auto)]
	private struct Struct218 : IAsyncStateMachine
	{
		// Token: 0x06001617 RID: 5655 RVA: 0x0005D158 File Offset: 0x0005B358
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
					this.class730_0 = Class462.smethod_0(false);
					awaiter = Class462.smethod_4().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class462.Struct218>(ref awaiter, ref this);
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
				IEnumerator<Class713> enumerator = this.class730_0.WinUwpAppsModels.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class713 @class = enumerator.Current;
						this.list_0.Add(new Class188
						{
							Type = dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.APPX,
							Name = "APPX",
							State = @class.AppxFriendlyName
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
				IEnumerator<Class745> enumerator2 = this.class730_0.CustomDebloatList.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						Class745 class2 = enumerator2.Current;
						this.list_0.Add(new Class188
						{
							Type = dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.APPXCustom,
							Name = class2.NameRaw,
							State = ((class2.CurrentValueType != "CUSTOM") ? class2.CurrentValueType : class2.CurrentCustomValue)
						});
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
				this.class730_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.list_0 = null;
			this.class730_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x0005D364 File Offset: 0x0005B564
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000EF9 RID: 3833
		public int int_0;

		// Token: 0x04000EFA RID: 3834
		public AsyncTaskMethodBuilder<List<Class188>> asyncTaskMethodBuilder_0;

		// Token: 0x04000EFB RID: 3835
		private List<Class188> list_0;

		// Token: 0x04000EFC RID: 3836
		private Class730 class730_0;

		// Token: 0x04000EFD RID: 3837
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003F9 RID: 1017
	[StructLayout(LayoutKind.Auto)]
	private struct Struct219 : IAsyncStateMachine
	{
		// Token: 0x06001619 RID: 5657 RVA: 0x0005D374 File Offset: 0x0005B574
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (!Class462.bool_0)
					{
						Class462.smethod_0(false);
					}
					awaiter = Class462.smethod_4().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class462.Struct219>(ref awaiter, ref this);
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
				if (Class462.class730_0.WinUwpAppsModels.Count != 0)
				{
					IEnumerator<Class713> enumerator = Class462.class730_0.WinUwpAppsModels.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class713 @class = enumerator.Current;
							@class.ToDelete = true;
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
				IEnumerator<Class745> enumerator2 = Class462.class730_0.CustomDebloatList.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						Class745 class2 = enumerator2.Current;
						class2.method_14();
					}
				}
				finally
				{
					if (num < 0 && enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x0005D4C8 File Offset: 0x0005B6C8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000EFE RID: 3838
		public int int_0;

		// Token: 0x04000EFF RID: 3839
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000F00 RID: 3840
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003FA RID: 1018
	[StructLayout(LayoutKind.Auto)]
	private struct Struct220 : IAsyncStateMachine
	{
		// Token: 0x0600161B RID: 5659 RVA: 0x0005D4D8 File Offset: 0x0005B6D8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(Class462.Class463.class463_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class462.Struct220>(ref awaiter, ref this);
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
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x0005D5A4 File Offset: 0x0005B7A4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000F01 RID: 3841
		public int int_0;

		// Token: 0x04000F02 RID: 3842
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000F03 RID: 3843
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003FB RID: 1019
	[Serializable]
	private sealed class Class463
	{
		// Token: 0x0600161F RID: 5663 RVA: 0x0005D5C8 File Offset: 0x0005B7C8
		internal Task method_0()
		{
			Class462.Class463.Struct221 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class462.Class463.Struct221>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04000F04 RID: 3844
		public static readonly Class462.Class463 class463_0 = new Class462.Class463();

		// Token: 0x04000F05 RID: 3845
		public static Func<Task> func_0;

		// Token: 0x020003FC RID: 1020
		[StructLayout(LayoutKind.Auto)]
		private struct Struct221 : IAsyncStateMachine
		{
			// Token: 0x06001620 RID: 5664 RVA: 0x0005D604 File Offset: 0x0005B804
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class745>> awaiter;
					if (num != 0)
					{
						this.class465_0 = new Class462.Class465();
						awaiter = Class588.smethod_2(typeof(dje_z4EFBE23NRXT78H3EAL45CK9M5K537HLZVTED9PC5FL6WLE8YYJD3VFKL5QNA_ejd), true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class462.Class463.Struct221>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					ObservableCollection<Class745> result = awaiter.GetResult();
					this.class465_0.observableCollection_0 = result;
					Application.Current.Dispatcher.Invoke(new Action(this.class465_0.method_0));
					Class497.smethod_0().method_0();
					List<GClass146.GClass148>.Enumerator enumerator = Class497.smethod_0().method_4().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class462.Class466 @class = new Class462.Class466();
							@class.gclass148_0 = enumerator.Current;
							if (!@class.gclass148_0.method_12())
							{
								Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					Class462.bool_1 = true;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class465_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class465_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06001621 RID: 5665 RVA: 0x0005D7A4 File Offset: 0x0005B9A4
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000F06 RID: 3846
			public int int_0;

			// Token: 0x04000F07 RID: 3847
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000F08 RID: 3848
			private Class462.Class465 class465_0;

			// Token: 0x04000F09 RID: 3849
			private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
		}
	}

	// Token: 0x020003FD RID: 1021
	private sealed class Class464
	{
		// Token: 0x06001623 RID: 5667 RVA: 0x0005D7BC File Offset: 0x0005B9BC
		internal bool method_0(string string_0)
		{
			return this.class713_0.AppxFullName.ToLower().StartsWith(string_0.ToLower());
		}

		// Token: 0x04000F0A RID: 3850
		public Class713 class713_0;
	}

	// Token: 0x020003FE RID: 1022
	private sealed class Class465
	{
		// Token: 0x06001625 RID: 5669 RVA: 0x0005D7E4 File Offset: 0x0005B9E4
		internal void method_0()
		{
			Class462.class730_0.method_1();
			Class462.class730_0.CustomDebloatList = this.observableCollection_0;
		}

		// Token: 0x04000F0B RID: 3851
		public ObservableCollection<Class745> observableCollection_0;
	}

	// Token: 0x020003FF RID: 1023
	private sealed class Class466
	{
		// Token: 0x06001627 RID: 5671 RVA: 0x0005D808 File Offset: 0x0005BA08
		internal void method_0()
		{
			Class462.class730_0.WinUwpAppsModels.Add(new Class713
			{
				AppxFriendlyName = this.gclass148_0.DisplayName,
				AppxLocation = this.gclass148_0.method_10(),
				AppxFullName = this.gclass148_0.method_8(),
				ToDelete = false
			});
		}

		// Token: 0x04000F0C RID: 3852
		public GClass146.GClass148 gclass148_0;
	}
}
