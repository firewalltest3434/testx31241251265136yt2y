using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Newtonsoft.Json;

// Token: 0x0200028E RID: 654
internal sealed class Class726 : GClass211
{
	// Token: 0x06000F23 RID: 3875 RVA: 0x00040C70 File Offset: 0x0003EE70
	public Class726()
	{
		this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
		this.method_1();
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x00040CB0 File Offset: 0x0003EEB0
	private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
	{
		base.method_0("ColChanged");
	}

	// Token: 0x170001CF RID: 463
	// (get) Token: 0x06000F26 RID: 3878 RVA: 0x00040CC0 File Offset: 0x0003EEC0
	// (set) Token: 0x06000F27 RID: 3879 RVA: 0x00040CC8 File Offset: 0x0003EEC8
	public ObservableCollection<Class745> Tweaks
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("Tweaks");
		}
	}

	// Token: 0x06000F28 RID: 3880 RVA: 0x00040CDC File Offset: 0x0003EEDC
	public void method_1()
	{
		Class726.Struct136 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class726_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class726.Struct136>(ref @struct);
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x00040D14 File Offset: 0x0003EF14
	public void method_2()
	{
		Class726.Struct138 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class726_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class726.Struct138>(ref @struct);
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x00040D4C File Offset: 0x0003EF4C
	public void method_3()
	{
		Class726.Struct137 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class726_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class726.Struct137>(ref @struct);
	}

	// Token: 0x0400093D RID: 2365
	private static readonly SemaphoreSlim semaphoreSlim_0 = new SemaphoreSlim(1, 1);

	// Token: 0x0400093E RID: 2366
	public ObservableCollection<Class745> observableCollection_0 = new ObservableCollection<Class745>();

	// Token: 0x0200028F RID: 655
	[StructLayout(LayoutKind.Auto)]
	private struct Struct136 : IAsyncStateMachine
	{
		// Token: 0x06000F2B RID: 3883 RVA: 0x00040D84 File Offset: 0x0003EF84
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class726 @class = this.class726_0;
			try
			{
				if (num == 0)
				{
					goto IL_A9;
				}
				TaskAwaiter<Class289> awaiter2;
				if (num != 1)
				{
					TaskAwaiter awaiter = Class726.semaphoreSlim_0.WaitAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class726.Struct136>(ref awaiter, ref this);
						return;
					}
					goto IL_C6;
				}
				else
				{
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<Class289>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				IL_7B:
				Class289 result = awaiter2.GetResult();
				if (!result.Success)
				{
					goto IL_280;
				}
				List<Class256>.Enumerator enumerator = JsonConvert.DeserializeObject<List<Class256>>(result.Message).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class256 class2 = enumerator.Current;
						try
						{
							GClass179 gclass = JsonConvert.DeserializeObject<GClass179>(class2.Json);
							gclass.Guid_0 = class2.Id;
							@class.Tweaks.Add(new Class745(gclass, new Class525(gclass), false, false));
						}
						catch (object obj)
						{
						}
					}
					goto IL_280;
					IL_A9:
					TaskAwaiter awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num4 = -1;
					num = -1;
					this.int_0 = num4;
					IL_C6:
					awaiter.GetResult();
					@class.Tweaks.Clear();
					if (Directory.Exists(Class186.string_9))
					{
						goto IL_F2;
					}
					Directory.CreateDirectory(Class186.string_9);
					IL_F2:
					List<string> list = Directory.GetFiles(Class186.string_9).ToList<string>();
					List<Guid> list2 = new List<Guid>();
					if (list.Count<string>() == 0)
					{
						goto IL_19E;
					}
					List<string>.Enumerator enumerator2 = list.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							string path = enumerator2.Current;
							try
							{
								GClass179 gclass2 = JsonConvert.DeserializeObject<GClass179>(Class376.smethod_1(File.ReadAllText(path)));
								@class.Tweaks.Add(new Class745(gclass2, new Class525(gclass2), true, false));
								Guid guid_ = gclass2.Guid_0;
								list2.Add(gclass2.Guid_0);
							}
							catch (object obj2)
							{
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator2).Dispose();
						}
					}
					IL_19E:
					if (Class585.struct13_0.method_0())
					{
						goto IL_1BD;
					}
					Class726.semaphoreSlim_0.Release();
					goto IL_2AC;
					IL_1BD:
					Class646<string, List<Guid>> object_ = new Class646<string, List<Guid>>(Class389.class504_0.Key, list2);
					awaiter2 = Class166.smethod_1(Class193.uri_14, object_).GetAwaiter();
					if (awaiter2.IsCompleted)
					{
						goto IL_7B;
					}
					int num5 = 1;
					num = 1;
					this.int_0 = num5;
					this.taskAwaiter_1 = awaiter2;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class289>, Class726.Struct136>(ref awaiter2, ref this);
					return;
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)enumerator).Dispose();
					}
				}
				IL_280:
				Class726.semaphoreSlim_0.Release();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_2AC:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x000410CC File Offset: 0x0003F2CC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400093F RID: 2367
		public int int_0;

		// Token: 0x04000940 RID: 2368
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000941 RID: 2369
		public Class726 class726_0;

		// Token: 0x04000942 RID: 2370
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x04000943 RID: 2371
		private TaskAwaiter<Class289> taskAwaiter_1;
	}

	// Token: 0x02000290 RID: 656
	[StructLayout(LayoutKind.Auto)]
	private struct Struct137 : IAsyncStateMachine
	{
		// Token: 0x06000F2D RID: 3885 RVA: 0x000410DC File Offset: 0x0003F2DC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class726 @class = this.class726_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Class726.semaphoreSlim_0.WaitAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class726.Struct137>(ref awaiter, ref this);
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
				IEnumerator<Class745> enumerator = @class.Tweaks.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class745 class2 = enumerator.Current;
						class2.method_16();
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				Class726.semaphoreSlim_0.Release();
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

		// Token: 0x06000F2E RID: 3886 RVA: 0x000411E0 File Offset: 0x0003F3E0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000944 RID: 2372
		public int int_0;

		// Token: 0x04000945 RID: 2373
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000946 RID: 2374
		public Class726 class726_0;

		// Token: 0x04000947 RID: 2375
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000291 RID: 657
	[StructLayout(LayoutKind.Auto)]
	private struct Struct138 : IAsyncStateMachine
	{
		// Token: 0x06000F2F RID: 3887 RVA: 0x000411F0 File Offset: 0x0003F3F0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class726 @class = this.class726_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Class726.semaphoreSlim_0.WaitAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class726.Struct138>(ref awaiter, ref this);
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
				IEnumerator<Class745> enumerator = @class.Tweaks.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class745 class2 = enumerator.Current;
						class2.method_14();
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				Class726.semaphoreSlim_0.Release();
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

		// Token: 0x06000F30 RID: 3888 RVA: 0x000412F4 File Offset: 0x0003F4F4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000948 RID: 2376
		public int int_0;

		// Token: 0x04000949 RID: 2377
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400094A RID: 2378
		public Class726 class726_0;

		// Token: 0x0400094B RID: 2379
		private TaskAwaiter taskAwaiter_0;
	}
}
