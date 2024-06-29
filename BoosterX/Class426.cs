using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using ns0;

// Token: 0x020003AD RID: 941
internal sealed class Class426
{
	// Token: 0x06001506 RID: 5382 RVA: 0x00055DE8 File Offset: 0x00053FE8
	// Note: this type is marked as 'beforefieldinit'.
	static Class426()
	{
		GClass52 gclass = new GClass52();
		gclass.method_1(string.Empty);
		gclass.method_3((Thread.CurrentThread.CurrentUICulture.ToString() == "ru-RU") ? GEnum70.RU : GEnum70.US);
		gclass.method_5((Thread.CurrentThread.CurrentUICulture.ToString() == "ru-RU") ? GEnum68.f000069 : GEnum68.f00001c);
		gclass.method_7((GEnum97)0);
		gclass.method_9((GEnum26)0);
		gclass.method_11(GEnum49.Desktop);
		Class426.gclass52_0 = gclass;
		GClass52 gclass2 = new GClass52();
		gclass2.method_1(string.Empty);
		gclass2.method_3(GEnum70.US);
		gclass2.method_5(GEnum68.f00001c);
		gclass2.method_7((GEnum97)0);
		gclass2.method_9((GEnum26)0);
		gclass2.method_11(GEnum49.Desktop);
		Class426.gclass52_1 = gclass2;
	}

	// Token: 0x06001507 RID: 5383 RVA: 0x00055EA8 File Offset: 0x000540A8
	public static Task<List<Class754>> smethod_0(string string_0, Class752 class752_0)
	{
		Class426.Struct197 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class754>>.Create();
		@struct.string_0 = string_0;
		@struct.class752_0 = class752_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class426.Struct197>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001508 RID: 5384 RVA: 0x00055EF4 File Offset: 0x000540F4
	private static Task<List<Class754>> smethod_1(string string_0, GClass162 gclass162_0, Class752 class752_0)
	{
		Class426.Struct203 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class754>>.Create();
		@struct.string_0 = string_0;
		@struct.gclass162_0 = gclass162_0;
		@struct.class752_0 = class752_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class426.Struct203>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001509 RID: 5385 RVA: 0x00055F48 File Offset: 0x00054148
	private static Task<List<Class754>> smethod_2(string string_0, GClass162 gclass162_0, Class752 class752_0)
	{
		Class426.Struct200 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class754>>.Create();
		@struct.string_0 = string_0;
		@struct.gclass162_0 = gclass162_0;
		@struct.class752_0 = class752_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class426.Struct200>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600150A RID: 5386 RVA: 0x00055F9C File Offset: 0x0005419C
	private static Task<List<Class754>> smethod_3(string string_0, GClass162 gclass162_0, Class752 class752_0)
	{
		Class426.Struct198 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class754>>.Create();
		@struct.string_0 = string_0;
		@struct.gclass162_0 = gclass162_0;
		@struct.class752_0 = class752_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class426.Struct198>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600150B RID: 5387 RVA: 0x00055FF0 File Offset: 0x000541F0
	public static Task smethod_4(Class754 class754_0, Class752 class752_0, CancellationToken cancellationToken_0)
	{
		Class426.Struct202 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class754_0 = class754_0;
		@struct.class752_0 = class752_0;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class426.Struct202>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600150C RID: 5388 RVA: 0x00056044 File Offset: 0x00054244
	private static void smethod_5(GClass111 gclass111_0, Class752 class752_0, CancellationToken cancellationToken_0)
	{
		new Thread(new ThreadStart(new Class426.Class430
		{
			gclass111_0 = gclass111_0,
			class752_0 = class752_0,
			cancellationToken_0 = cancellationToken_0
		}.method_0)).Start();
	}

	// Token: 0x0600150D RID: 5389 RVA: 0x00056078 File Offset: 0x00054278
	private static void smethod_6(GClass111 gclass111_0, Class752 class752_0)
	{
		Class426.Class428 @class = new Class426.Class428();
		@class.class752_0 = class752_0;
		Class185.smethod_22("taskkill /f /im textinputhost.exe");
		using (PowerShell powerShell = PowerShell.Create())
		{
			powerShell.AddScript("Add-AppxPackage -ForceApplicationShutdown \"" + gclass111_0.method_4() + "\"");
			powerShell.Streams.Progress.DataAdded += @class.method_0;
			powerShell.Invoke();
		}
	}

	// Token: 0x04000CD3 RID: 3283
	public static GClass52 gclass52_0;

	// Token: 0x04000CD4 RID: 3284
	public static GClass52 gclass52_1;

	// Token: 0x020003AE RID: 942
	private sealed class Class427
	{
		// Token: 0x0600150F RID: 5391 RVA: 0x00056108 File Offset: 0x00054308
		internal void method_0()
		{
			if (this.class430_0.class752_0 != null)
			{
				this.class430_0.class752_0.ProgressText = string.Format("{0:F2}/{1:F2} MB", (double)this.long_0 / 1048576.0, this.nullable_0.GetValueOrDefault() / 1048576L);
				this.class430_0.class752_0.ProgressValue = Math.Round((double)this.long_0 / (double)this.nullable_0.Value * 100.0, 2);
			}
		}

		// Token: 0x04000CD5 RID: 3285
		public long long_0;

		// Token: 0x04000CD6 RID: 3286
		public long? nullable_0;

		// Token: 0x04000CD7 RID: 3287
		public Class426.Class430 class430_0;
	}

	// Token: 0x020003AF RID: 943
	private sealed class Class428
	{
		// Token: 0x06001511 RID: 5393 RVA: 0x000561AC File Offset: 0x000543AC
		internal void method_0(object sender, DataAddedEventArgs p1)
		{
			Class426.Class429 @class = new Class426.Class429();
			@class.class428_0 = this;
			@class.dataAddedEventArgs_0 = p1;
			@class.psdataCollection_0 = (PSDataCollection<ProgressRecord>)sender;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x04000CD8 RID: 3288
		public Class752 class752_0;
	}

	// Token: 0x020003B0 RID: 944
	private sealed class Class429
	{
		// Token: 0x06001513 RID: 5395 RVA: 0x000561FC File Offset: 0x000543FC
		internal void method_0()
		{
			if (this.class428_0.class752_0 != null)
			{
				this.class428_0.class752_0.ProgressText = this.psdataCollection_0[this.dataAddedEventArgs_0.Index].PercentComplete.ToString() + "%";
				this.class428_0.class752_0.ProgressValue = (double)this.psdataCollection_0[this.dataAddedEventArgs_0.Index].PercentComplete;
			}
		}

		// Token: 0x04000CD9 RID: 3289
		public PSDataCollection<ProgressRecord> psdataCollection_0;

		// Token: 0x04000CDA RID: 3290
		public DataAddedEventArgs dataAddedEventArgs_0;

		// Token: 0x04000CDB RID: 3291
		public Class426.Class428 class428_0;
	}

	// Token: 0x020003B1 RID: 945
	[StructLayout(LayoutKind.Auto)]
	private struct Struct197 : IAsyncStateMachine
	{
		// Token: 0x06001514 RID: 5396 RVA: 0x00056280 File Offset: 0x00054480
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<Class754> result;
			try
			{
				TaskAwaiter<List<Class754>> awaiter;
				if (num != 0)
				{
					awaiter = Task.Run<List<Class754>>(new Func<Task<List<Class754>>>(new Class426.Class434
					{
						string_0 = this.string_0,
						class752_0 = this.class752_0
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class754>>, Class426.Struct197>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<List<Class754>>);
					this.int_0 = -1;
				}
				result = awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x00056354 File Offset: 0x00054554
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000CDC RID: 3292
		public int int_0;

		// Token: 0x04000CDD RID: 3293
		public AsyncTaskMethodBuilder<List<Class754>> asyncTaskMethodBuilder_0;

		// Token: 0x04000CDE RID: 3294
		public string string_0;

		// Token: 0x04000CDF RID: 3295
		public Class752 class752_0;

		// Token: 0x04000CE0 RID: 3296
		private TaskAwaiter<List<Class754>> taskAwaiter_0;
	}

	// Token: 0x020003B2 RID: 946
	[StructLayout(LayoutKind.Auto)]
	private struct Struct198 : IAsyncStateMachine
	{
		// Token: 0x06001516 RID: 5398 RVA: 0x00056364 File Offset: 0x00054564
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<Class754> list_;
			try
			{
				if (num != 0)
				{
					this.class432_0 = new Class426.Class432();
					this.class432_0.class752_0 = this.class752_0;
					this.class432_0.list_0 = null;
					Application.Current.Dispatcher.Invoke(new Action(this.class432_0.method_0));
				}
				GClass180 result;
				try
				{
					TaskAwaiter<GClass180> awaiter;
					if (num != 0)
					{
						awaiter = this.gclass162_0.method_2(this.string_0, Class426.gclass52_0.method_10()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass180>, Class426.Struct198>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<GClass180>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					result = awaiter.GetResult();
				}
				catch (GException2 value)
				{
					Console.WriteLine("Failed to search DisplayCatalog");
					Console.WriteLine(value);
					list_ = this.class432_0.list_0;
					goto IL_1FA;
				}
				if (result.List_0.Count == 0)
				{
					list_ = this.class432_0.list_0;
				}
				else
				{
					List<GClass201>.Enumerator enumerator = result.List_0.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							GClass201 gclass = enumerator.Current;
							List<GClass209>.Enumerator enumerator2 = gclass.List_0.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									Class426.Class433 @class = new Class426.Class433();
									@class.class432_0 = this.class432_0;
									@class.gclass209_0 = enumerator2.Current;
									Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
								}
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)enumerator2).Dispose();
								}
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
					list_ = this.class432_0.list_0;
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class432_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1FA:
			this.int_0 = -2;
			this.class432_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(list_);
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x000565EC File Offset: 0x000547EC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000CE1 RID: 3297
		public int int_0;

		// Token: 0x04000CE2 RID: 3298
		public AsyncTaskMethodBuilder<List<Class754>> asyncTaskMethodBuilder_0;

		// Token: 0x04000CE3 RID: 3299
		public Class752 class752_0;

		// Token: 0x04000CE4 RID: 3300
		public GClass162 gclass162_0;

		// Token: 0x04000CE5 RID: 3301
		public string string_0;

		// Token: 0x04000CE6 RID: 3302
		private Class426.Class432 class432_0;

		// Token: 0x04000CE7 RID: 3303
		private TaskAwaiter<GClass180> taskAwaiter_0;
	}

	// Token: 0x020003B3 RID: 947
	private sealed class Class430
	{
		// Token: 0x06001519 RID: 5401 RVA: 0x00056604 File Offset: 0x00054804
		internal void method_0()
		{
			Class426.Class430.Struct199 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.class430_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class426.Class430.Struct199>(ref @struct);
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0005663C File Offset: 0x0005483C
		internal bool method_1(long? nullable_0, long long_0)
		{
			Class426.Class427 @class = new Class426.Class427();
			@class.class430_0 = this;
			@class.long_0 = long_0;
			@class.nullable_0 = nullable_0;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
			return this.cancellationToken_0.IsCancellationRequested;
		}

		// Token: 0x04000CE8 RID: 3304
		public GClass111 gclass111_0;

		// Token: 0x04000CE9 RID: 3305
		public Class752 class752_0;

		// Token: 0x04000CEA RID: 3306
		public CancellationToken cancellationToken_0;

		// Token: 0x04000CEB RID: 3307
		public GClass64.GDelegate0 gdelegate0_0;

		// Token: 0x020003B4 RID: 948
		[StructLayout(LayoutKind.Auto)]
		private struct Struct199 : IAsyncStateMachine
		{
			// Token: 0x0600151B RID: 5403 RVA: 0x0005668C File Offset: 0x0005488C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class426.Class430 @class = this.class430_0;
				try
				{
					if (num != 0)
					{
						this.string_0 = Path.Combine(Class186.string_10, @class.gclass111_0.method_0());
						this.gclass64_0 = new GClass64(@class.gclass111_0.method_2(), this.string_0);
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							GClass64 gclass = this.gclass64_0;
							GClass64.GDelegate0 gdelegate0_;
							if ((gdelegate0_ = @class.gdelegate0_0) == null)
							{
								gdelegate0_ = (@class.gdelegate0_0 = new GClass64.GDelegate0(@class.method_1));
							}
							gclass.method_2(gdelegate0_);
							awaiter = this.gclass64_0.method_4().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.int_0 = num2;
								this.taskAwaiter_0 = awaiter;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class426.Class430.Struct199>(ref awaiter, ref this);
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
					}
					finally
					{
						if (num < 0 && this.gclass64_0 != null)
						{
							((IDisposable)this.gclass64_0).Dispose();
						}
					}
					this.gclass64_0 = null;
					@class.gclass111_0.method_5(this.string_0);
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.string_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.string_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600151C RID: 5404 RVA: 0x0005682C File Offset: 0x00054A2C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000CEC RID: 3308
			public int int_0;

			// Token: 0x04000CED RID: 3309
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04000CEE RID: 3310
			public Class426.Class430 class430_0;

			// Token: 0x04000CEF RID: 3311
			private string string_0;

			// Token: 0x04000CF0 RID: 3312
			private GClass64 gclass64_0;

			// Token: 0x04000CF1 RID: 3313
			private TaskAwaiter taskAwaiter_0;
		}
	}

	// Token: 0x020003B5 RID: 949
	[StructLayout(LayoutKind.Auto)]
	private struct Struct200 : IAsyncStateMachine
	{
		// Token: 0x0600151D RID: 5405 RVA: 0x0005683C File Offset: 0x00054A3C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<Class754> list_;
			try
			{
				if (num != 0)
				{
					this.class435_0 = new Class426.Class435();
					this.class435_0.class752_0 = this.class752_0;
					this.class435_0.list_0 = null;
					Application.Current.Dispatcher.Invoke(new Action(this.class435_0.method_0));
				}
				try
				{
					TaskAwaiter<GClass18> awaiter;
					if (num != 0)
					{
						if (!this.string_0.StartsWith("https://apps.microsoft.com/store/detail"))
						{
							goto IL_153;
						}
						this.class438_0 = new Class426.Class438();
						this.class438_0.class435_0 = this.class435_0;
						string text = new Uri(this.string_0).Segments.Last<string>();
						awaiter = this.gclass162_0.method_1(text, (GEnum26)0, null).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass18>, Class426.Struct200>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<GClass18>);
						this.int_0 = -1;
					}
					GClass18 result = awaiter.GetResult();
					this.class438_0.gclass18_0 = result;
					if (this.class438_0.gclass18_0.GClass209_0 != null)
					{
						Application.Current.Dispatcher.Invoke(new Action(this.class438_0.method_0));
					}
					this.class438_0 = null;
					IL_153:;
				}
				catch (Exception exception_)
				{
					GClass141.smethod_0(exception_);
				}
				list_ = this.class435_0.list_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class435_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class435_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(list_);
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00056A30 File Offset: 0x00054C30
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000CF2 RID: 3314
		public int int_0;

		// Token: 0x04000CF3 RID: 3315
		public AsyncTaskMethodBuilder<List<Class754>> asyncTaskMethodBuilder_0;

		// Token: 0x04000CF4 RID: 3316
		public Class752 class752_0;

		// Token: 0x04000CF5 RID: 3317
		public string string_0;

		// Token: 0x04000CF6 RID: 3318
		public GClass162 gclass162_0;

		// Token: 0x04000CF7 RID: 3319
		private Class426.Class438 class438_0;

		// Token: 0x04000CF8 RID: 3320
		private Class426.Class435 class435_0;

		// Token: 0x04000CF9 RID: 3321
		private TaskAwaiter<GClass18> taskAwaiter_0;
	}

	// Token: 0x020003B6 RID: 950
	private sealed class Class431
	{
		// Token: 0x06001520 RID: 5408 RVA: 0x00056A48 File Offset: 0x00054C48
		internal void method_0()
		{
			this.list_0 = new List<Class754>();
		}

		// Token: 0x04000CFA RID: 3322
		public List<Class754> list_0;
	}

	// Token: 0x020003B7 RID: 951
	private sealed class Class432
	{
		// Token: 0x06001522 RID: 5410 RVA: 0x00056A60 File Offset: 0x00054C60
		internal void method_0()
		{
			this.list_0 = new List<Class754>();
		}

		// Token: 0x04000CFB RID: 3323
		public List<Class754> list_0;

		// Token: 0x04000CFC RID: 3324
		public Class752 class752_0;
	}

	// Token: 0x020003B8 RID: 952
	private sealed class Class433
	{
		// Token: 0x06001524 RID: 5412 RVA: 0x00056A78 File Offset: 0x00054C78
		internal void method_0()
		{
			Class754 item = new Class754(this.class432_0.class752_0)
			{
				AppXName = this.gclass209_0.String_13,
				AppXProductID = this.gclass209_0.String_12,
				AppXIcon = Class397.smethod_1("https:" + this.gclass209_0.Icon)
			};
			this.class432_0.list_0.Add(item);
		}

		// Token: 0x04000CFD RID: 3325
		public GClass209 gclass209_0;

		// Token: 0x04000CFE RID: 3326
		public Class426.Class432 class432_0;
	}

	// Token: 0x020003B9 RID: 953
	private sealed class Class434
	{
		// Token: 0x06001526 RID: 5414 RVA: 0x00056AF4 File Offset: 0x00054CF4
		internal Task<List<Class754>> method_0()
		{
			Class426.Class434.Struct201 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class754>>.Create();
			@struct.class434_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class426.Class434.Struct201>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04000CFF RID: 3327
		public string string_0;

		// Token: 0x04000D00 RID: 3328
		public Class752 class752_0;

		// Token: 0x020003BA RID: 954
		[StructLayout(LayoutKind.Auto)]
		private struct Struct201 : IAsyncStateMachine
		{
			// Token: 0x06001527 RID: 5415 RVA: 0x00056B38 File Offset: 0x00054D38
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class426.Class434 @class = this.class434_0;
				List<Class754> result2;
				try
				{
					TaskAwaiter<List<Class754>> awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<Class754>>);
						this.int_0 = -1;
						break;
					case 1:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<Class754>>);
						this.int_0 = -1;
						goto IL_21C;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<Class754>>);
						this.int_0 = -1;
						goto IL_2AD;
					default:
						this.class431_0 = new Class426.Class431();
						this.gclass162_0 = new GClass162(Class426.gclass52_0.method_6(), new GClass4(Class426.gclass52_0.method_2(), Class426.gclass52_0.method_4(), true));
						if (!string.IsNullOrEmpty(Class426.gclass52_0.method_0()) && !Class426.gclass52_0.method_0().StartsWith("Token") && !Class426.gclass52_0.method_0().StartsWith("Bearer") && !Class426.gclass52_0.method_0().StartsWith("XBL3.0="))
						{
							Console.WriteLine("Invalid token format, ignoring...");
						}
						else if (!string.IsNullOrEmpty(Class426.gclass52_0.method_0()))
						{
							Console.WriteLine("Setting token...");
						}
						this.class431_0.list_0 = null;
						Application.Current.Dispatcher.Invoke(new Action(this.class431_0.method_0));
						this.list_0 = this.class431_0.list_0;
						awaiter = Class426.smethod_1(@class.string_0, this.gclass162_0, @class.class752_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class754>>, Class426.Class434.Struct201>(ref awaiter, ref this);
							return;
						}
						break;
					}
					List<Class754> result = awaiter.GetResult();
					this.list_0.AddRange(result);
					this.list_0 = null;
					if (!@class.string_0.StartsWith("https://apps.microsoft.com/store/detail"))
					{
						goto IL_237;
					}
					this.list_0 = this.class431_0.list_0;
					awaiter = Class426.smethod_2(@class.string_0, this.gclass162_0, @class.class752_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class754>>, Class426.Class434.Struct201>(ref awaiter, ref this);
						return;
					}
					IL_21C:
					result = awaiter.GetResult();
					this.list_0.AddRange(result);
					this.list_0 = null;
					IL_237:
					this.list_0 = this.class431_0.list_0;
					awaiter = Class426.smethod_3(@class.string_0, this.gclass162_0, @class.class752_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class754>>, Class426.Class434.Struct201>(ref awaiter, ref this);
						return;
					}
					IL_2AD:
					result = awaiter.GetResult();
					this.list_0.AddRange(result);
					this.list_0 = null;
					result2 = this.class431_0.list_0;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class431_0 = null;
					this.gclass162_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class431_0 = null;
				this.gclass162_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult(result2);
			}

			// Token: 0x06001528 RID: 5416 RVA: 0x00056E84 File Offset: 0x00055084
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D01 RID: 3329
			public int int_0;

			// Token: 0x04000D02 RID: 3330
			public AsyncTaskMethodBuilder<List<Class754>> asyncTaskMethodBuilder_0;

			// Token: 0x04000D03 RID: 3331
			public Class426.Class434 class434_0;

			// Token: 0x04000D04 RID: 3332
			private Class426.Class431 class431_0;

			// Token: 0x04000D05 RID: 3333
			private GClass162 gclass162_0;

			// Token: 0x04000D06 RID: 3334
			private List<Class754> list_0;

			// Token: 0x04000D07 RID: 3335
			private TaskAwaiter<List<Class754>> taskAwaiter_0;
		}
	}

	// Token: 0x020003BB RID: 955
	private sealed class Class435
	{
		// Token: 0x0600152A RID: 5418 RVA: 0x00056E9C File Offset: 0x0005509C
		internal void method_0()
		{
			this.list_0 = new List<Class754>();
		}

		// Token: 0x04000D08 RID: 3336
		public List<Class754> list_0;

		// Token: 0x04000D09 RID: 3337
		public Class752 class752_0;
	}

	// Token: 0x020003BC RID: 956
	private sealed class Class436
	{
		// Token: 0x0600152C RID: 5420 RVA: 0x00056EB4 File Offset: 0x000550B4
		internal void method_0()
		{
			this.list_0 = new List<Class754>();
		}

		// Token: 0x04000D0A RID: 3338
		public List<Class754> list_0;

		// Token: 0x04000D0B RID: 3339
		public Class752 class752_0;
	}

	// Token: 0x020003BD RID: 957
	[StructLayout(LayoutKind.Auto)]
	private struct Struct202 : IAsyncStateMachine
	{
		// Token: 0x0600152D RID: 5421 RVA: 0x00056EC4 File Offset: 0x000550C4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter<GClass18> awaiter;
				TaskAwaiter<IList<GClass56>> awaiter2;
				TaskAwaiter awaiter3;
				switch (num)
				{
				case 0:
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass18>);
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
					break;
				}
				case 1:
				{
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<IList<GClass56>>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
					goto IL_1E6;
				}
				case 2:
				{
					awaiter3 = this.taskAwaiter_2;
					this.taskAwaiter_2 = default(TaskAwaiter);
					int num4 = -1;
					num = -1;
					this.int_0 = num4;
					goto IL_566;
				}
				case 3:
				{
					IL_58F:
					try
					{
						if (num == 3)
						{
							awaiter3 = this.taskAwaiter_2;
							this.taskAwaiter_2 = default(TaskAwaiter);
							int num5 = -1;
							num = -1;
							this.int_0 = num5;
							goto IL_6FC;
						}
						IL_608:
						if (!this.enumerator_0.MoveNext())
						{
							goto IL_76A;
						}
						KeyValuePair<string, GClass111> keyValuePair = this.enumerator_0.Current;
						this.gclass111_0 = keyValuePair.Value;
						Class752 @class = this.class439_0.class752_0;
						if (@class != null)
						{
							string str = Class364.smethod_0("storexins3");
							string format = " ({0}/{1})";
							int num6 = this.class439_0.int_0;
							this.class439_0.int_0 = num6 + 1;
							@class.method_5(str + string.Format(format, num6, this.class439_0.dictionary_0.Count), Brushes.White);
						}
						Class426.smethod_5(this.gclass111_0, this.class439_0.class752_0, this.cancellationToken_0);
						IL_6C0:
						if (this.gclass111_0.method_4() != null)
						{
							Dispatcher dispatcher = Application.Current.Dispatcher;
							Action callback;
							if ((callback = this.class439_0.action_0) == null)
							{
								callback = (this.class439_0.action_0 = new Action(this.class439_0.method_0));
							}
							dispatcher.Invoke(callback);
							this.gclass111_0 = null;
							goto IL_608;
						}
						if (this.cancellationToken_0.IsCancellationRequested)
						{
							Class752 class2 = this.class439_0.class752_0;
							if (class2 != null)
							{
								class2.method_2();
							}
							goto IL_DEF;
						}
						awaiter3 = Task.Delay(200).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num7 = 3;
							num = 3;
							this.int_0 = num7;
							this.taskAwaiter_2 = awaiter3;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class426.Struct202>(ref awaiter3, ref this);
							return;
						}
						IL_6FC:
						awaiter3.GetResult();
						goto IL_6C0;
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)this.enumerator_0).Dispose();
						}
					}
					IL_76A:
					this.enumerator_0 = default(Dictionary<string, GClass111>.Enumerator);
					if (this.cancellationToken_0.IsCancellationRequested)
					{
						Class752 class3 = this.class439_0.class752_0;
						if (class3 != null)
						{
							class3.method_2();
						}
						goto IL_DEF;
					}
					if (this.class439_0.class752_0 == null)
					{
						goto IL_82C;
					}
					Class752 class4 = this.class439_0.class752_0;
					awaiter3 = ((class4 != null) ? class4.method_4() : null).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						int num8 = 4;
						num = 4;
						this.int_0 = num8;
						this.taskAwaiter_2 = awaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class426.Struct202>(ref awaiter3, ref this);
						return;
					}
					goto IL_825;
				}
				case 4:
				{
					awaiter3 = this.taskAwaiter_2;
					this.taskAwaiter_2 = default(TaskAwaiter);
					int num9 = -1;
					num = -1;
					this.int_0 = num9;
					goto IL_825;
				}
				case 5:
				{
					awaiter3 = this.taskAwaiter_2;
					this.taskAwaiter_2 = default(TaskAwaiter);
					int num10 = -1;
					num = -1;
					this.int_0 = num10;
					goto IL_9FD;
				}
				case 6:
				{
					awaiter3 = this.taskAwaiter_2;
					this.taskAwaiter_2 = default(TaskAwaiter);
					int num11 = -1;
					num = -1;
					this.int_0 = num11;
					goto IL_C14;
				}
				case 7:
				{
					awaiter3 = this.taskAwaiter_2;
					this.taskAwaiter_2 = default(TaskAwaiter);
					int num12 = -1;
					num = -1;
					this.int_0 = num12;
					goto IL_CAD;
				}
				default:
				{
					this.class439_0 = new Class426.Class439();
					this.class439_0.class752_0 = this.class752_0;
					Class754 class5 = this.class754_0;
					if (class5 != null)
					{
						class5.method_3(Class364.smethod_0("storexins5"), Brushes.White);
					}
					Class752 class6 = this.class439_0.class752_0;
					if (class6 != null)
					{
						class6.method_5(Class364.smethod_0("storexins2"), Brushes.White);
					}
					this.class754_0.bool_0 = true;
					this.gclass162_0 = new GClass162(Class426.gclass52_1.method_6(), new GClass4(Class426.gclass52_1.method_2(), Class426.gclass52_1.method_4(), true));
					awaiter = this.gclass162_0.method_1(this.class754_0.AppXProductID, (GEnum26)0, null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num13 = 0;
						num = 0;
						this.int_0 = num13;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass18>, Class426.Struct202>(ref awaiter, ref this);
						return;
					}
					break;
				}
				}
				GClass18 result = awaiter.GetResult();
				if (this.cancellationToken_0.IsCancellationRequested)
				{
					Class752 class7 = this.class439_0.class752_0;
					if (class7 != null)
					{
						class7.method_2();
					}
					goto IL_DEF;
				}
				GClass209 gclass209_ = result.GClass209_0;
				awaiter2 = this.gclass162_0.method_0(gclass209_, null).GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					int num14 = 1;
					num = 1;
					this.int_0 = num14;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<IList<GClass56>>, Class426.Struct202>(ref awaiter2, ref this);
					return;
				}
				IL_1E6:
				IEnumerable<GClass56> result2 = awaiter2.GetResult();
				List<GClass111> list = new List<GClass111>();
				IEnumerator<GClass56> enumerator = result2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						GClass56 gclass = enumerator.Current;
						List<GClass111> list2 = list;
						GClass111 gclass2 = new GClass111();
						gclass2.method_1(gclass.string_0);
						gclass2.method_3(gclass.uri_0.ToString());
						gclass2.method_7(gclass.gclass2_0.GClass153_0.String_0);
						gclass2.method_9(gclass.gclass2_0.GClass153_0.String_1);
						gclass2.method_11(gclass.gclass2_0.GClass153_0.String_2);
						list2.Add(gclass2);
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				if (this.cancellationToken_0.IsCancellationRequested)
				{
					Class752 class8 = this.class439_0.class752_0;
					if (class8 != null)
					{
						class8.method_2();
					}
					goto IL_DEF;
				}
				this.class439_0.dictionary_0 = new Dictionary<string, GClass111>();
				Class497.smethod_0().method_0();
				bool flag = false;
				bool flag2 = false;
				List<GClass111>.Enumerator enumerator2 = list.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						GClass111 gclass3 = enumerator2.Current;
						if (!gclass3.method_23())
						{
							if (gclass3.method_21())
							{
								flag = true;
							}
							if (gclass3.method_19())
							{
								flag2 = true;
							}
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
				enumerator2 = list.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						GClass111 gclass4 = enumerator2.Current;
						if (!gclass4.method_18() && (!gclass4.method_12() || !gclass4.method_23()))
						{
							string key;
							if (gclass4.method_23())
							{
								if (!gclass4.method_19() && !gclass4.method_20())
								{
									continue;
								}
								key = gclass4.method_16();
							}
							else
							{
								if (!gclass4.method_19() && !gclass4.method_21() && (flag2 || flag))
								{
									continue;
								}
								key = gclass4.method_13();
							}
							if (!this.class439_0.dictionary_0.ContainsKey(key))
							{
								this.class439_0.dictionary_0[key] = gclass4;
							}
							else if (gclass4.method_22(this.class439_0.dictionary_0[key]) > 0)
							{
								this.class439_0.dictionary_0[key] = gclass4;
							}
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
				if (this.cancellationToken_0.IsCancellationRequested)
				{
					Class752 class9 = this.class439_0.class752_0;
					if (class9 != null)
					{
						class9.method_2();
					}
					goto IL_DEF;
				}
				Class752 class10 = this.class439_0.class752_0;
				if (class10 != null)
				{
					class10.method_5(Class364.smethod_0("storexins3") + string.Format(" (0/{0})", this.class439_0.dictionary_0.Count), Brushes.White);
				}
				if (this.class439_0.class752_0 == null)
				{
					goto IL_56D;
				}
				Class752 class11 = this.class439_0.class752_0;
				awaiter3 = ((class11 != null) ? class11.method_3() : null).GetAwaiter();
				if (!awaiter3.IsCompleted)
				{
					int num15 = 2;
					num = 2;
					this.int_0 = num15;
					this.taskAwaiter_2 = awaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class426.Struct202>(ref awaiter3, ref this);
					return;
				}
				IL_566:
				awaiter3.GetResult();
				IL_56D:
				this.class439_0.int_0 = 1;
				this.enumerator_0 = this.class439_0.dictionary_0.GetEnumerator();
				goto IL_58F;
				IL_825:
				awaiter3.GetResult();
				IL_82C:
				Class185.smethod_22("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\AppModelUnlock\" /v \"AllowDevelopmentWithoutDevLicense\" /t REG_DWORD /d \"1\" /f");
				this.list_0 = new List<GClass111>();
				this.list_1 = new List<GClass111>();
				this.string_0 = "C:\\Program Files\\WindowsApps\\";
				Dictionary<string, GClass111>.Enumerator enumerator3 = this.class439_0.dictionary_0.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						KeyValuePair<string, GClass111> keyValuePair2 = enumerator3.Current;
						GClass111 value = keyValuePair2.Value;
						if (value.method_23())
						{
							this.list_0.Add(value);
						}
						else
						{
							this.list_1.Add(value);
							this.string_0 += value.method_4().Split(new char[]
							{
								'\\'
							}).Last<string>();
						}
					}
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)enumerator3).Dispose();
					}
				}
				if (this.cancellationToken_0.IsCancellationRequested)
				{
					Class752 class12 = this.class439_0.class752_0;
					if (class12 != null)
					{
						class12.method_2();
					}
					goto IL_DEF;
				}
				Class752 class13 = this.class439_0.class752_0;
				if (class13 != null)
				{
					class13.method_5(Class364.smethod_0("storexins5") + string.Format(" (0/{0})", this.class439_0.dictionary_0.Count), Brushes.White);
				}
				if (this.class439_0.class752_0 == null)
				{
					goto IL_A04;
				}
				Class752 class14 = this.class439_0.class752_0;
				awaiter3 = ((class14 != null) ? class14.method_3() : null).GetAwaiter();
				if (!awaiter3.IsCompleted)
				{
					int num16 = 5;
					num = 5;
					this.int_0 = num16;
					this.taskAwaiter_2 = awaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class426.Struct202>(ref awaiter3, ref this);
					return;
				}
				IL_9FD:
				awaiter3.GetResult();
				IL_A04:
				this.class439_0.int_0 = 1;
				enumerator2 = this.list_0.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						GClass111 gclass5 = enumerator2.Current;
						Dispatcher dispatcher2 = Application.Current.Dispatcher;
						Action callback2;
						if ((callback2 = this.class439_0.action_1) == null)
						{
							callback2 = (this.class439_0.action_1 = new Action(this.class439_0.method_1));
						}
						dispatcher2.Invoke(callback2);
						Class426.smethod_6(gclass5, this.class439_0.class752_0);
						if (this.cancellationToken_0.IsCancellationRequested)
						{
							Class752 class15 = this.class439_0.class752_0;
							if (class15 != null)
							{
								class15.method_2();
							}
							goto IL_DEF;
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
				enumerator2 = this.list_1.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						GClass111 gclass6 = enumerator2.Current;
						Dispatcher dispatcher3 = Application.Current.Dispatcher;
						Action callback3;
						if ((callback3 = this.class439_0.action_2) == null)
						{
							callback3 = (this.class439_0.action_2 = new Action(this.class439_0.method_2));
						}
						dispatcher3.Invoke(callback3);
						Class426.smethod_6(gclass6, this.class439_0.class752_0);
						if (this.cancellationToken_0.IsCancellationRequested)
						{
							Class752 class16 = this.class439_0.class752_0;
							if (class16 != null)
							{
								class16.method_2();
							}
							goto IL_DEF;
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
				if (this.class439_0.class752_0 == null)
				{
					goto IL_C1B;
				}
				Class752 class17 = this.class439_0.class752_0;
				awaiter3 = ((class17 != null) ? class17.method_4() : null).GetAwaiter();
				if (!awaiter3.IsCompleted)
				{
					int num17 = 6;
					num = 6;
					this.int_0 = num17;
					this.taskAwaiter_2 = awaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class426.Struct202>(ref awaiter3, ref this);
					return;
				}
				IL_C14:
				awaiter3.GetResult();
				IL_C1B:
				Class752 class18 = this.class439_0.class752_0;
				if (class18 != null)
				{
					class18.method_5(Class364.smethod_0("storexins8"), Brushes.White);
				}
				Class185.smethod_5(this.string_0);
				awaiter3 = Task.Delay(2000).GetAwaiter();
				if (!awaiter3.IsCompleted)
				{
					int num18 = 7;
					num = 7;
					this.int_0 = num18;
					this.taskAwaiter_2 = awaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class426.Struct202>(ref awaiter3, ref this);
					return;
				}
				IL_CAD:
				awaiter3.GetResult();
				if (this.cancellationToken_0.IsCancellationRequested)
				{
					Class752 class19 = this.class439_0.class752_0;
					if (class19 != null)
					{
						class19.method_2();
					}
				}
				else
				{
					enumerator2 = this.list_1.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							GClass111 gclass7 = enumerator2.Current;
							File.Delete(gclass7.method_4());
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator2).Dispose();
						}
					}
					enumerator2 = this.list_0.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							GClass111 gclass8 = enumerator2.Current;
							File.Delete(gclass8.method_4());
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator2).Dispose();
						}
					}
					Class754 class20 = this.class754_0;
					if (class20 != null)
					{
						class20.method_3(Class364.smethod_0("Installed"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
					}
					this.class754_0.bool_0 = false;
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class439_0 = null;
				this.gclass162_0 = null;
				this.list_0 = null;
				this.list_1 = null;
				this.string_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_DEF:
			this.int_0 = -2;
			this.class439_0 = null;
			this.gclass162_0 = null;
			this.list_0 = null;
			this.list_1 = null;
			this.string_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00057DEC File Offset: 0x00055FEC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000D0C RID: 3340
		public int int_0;

		// Token: 0x04000D0D RID: 3341
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000D0E RID: 3342
		public Class752 class752_0;

		// Token: 0x04000D0F RID: 3343
		public Class754 class754_0;

		// Token: 0x04000D10 RID: 3344
		public CancellationToken cancellationToken_0;

		// Token: 0x04000D11 RID: 3345
		private Class426.Class439 class439_0;

		// Token: 0x04000D12 RID: 3346
		private GClass162 gclass162_0;

		// Token: 0x04000D13 RID: 3347
		private List<GClass111> list_0;

		// Token: 0x04000D14 RID: 3348
		private List<GClass111> list_1;

		// Token: 0x04000D15 RID: 3349
		private string string_0;

		// Token: 0x04000D16 RID: 3350
		private TaskAwaiter<GClass18> taskAwaiter_0;

		// Token: 0x04000D17 RID: 3351
		private TaskAwaiter<IList<GClass56>> taskAwaiter_1;

		// Token: 0x04000D18 RID: 3352
		private TaskAwaiter taskAwaiter_2;

		// Token: 0x04000D19 RID: 3353
		private Dictionary<string, GClass111>.Enumerator enumerator_0;

		// Token: 0x04000D1A RID: 3354
		private GClass111 gclass111_0;
	}

	// Token: 0x020003BE RID: 958
	private sealed class Class437
	{
		// Token: 0x06001530 RID: 5424 RVA: 0x00057E04 File Offset: 0x00056004
		internal void method_0()
		{
			Class754 @class = new Class754(this.class436_0.class752_0);
			List<GClass126> list_ = this.gclass18_0.GClass209_0.List_0;
			string appXName;
			if (list_ == null)
			{
				appXName = null;
			}
			else
			{
				GClass126 gclass = list_[0];
				appXName = ((gclass != null) ? gclass.String_5 : null);
			}
			@class.AppXName = appXName;
			@class.AppXProductID = this.gclass18_0.GClass209_0.String_12;
			string str = "https:";
			List<GClass126> list_2 = this.gclass18_0.GClass209_0.List_0;
			string str2;
			if (list_2 == null)
			{
				str2 = null;
			}
			else
			{
				GClass126 gclass2 = list_2[0];
				if (gclass2 == null)
				{
					str2 = null;
				}
				else
				{
					List<GClass137> list_3 = gclass2.List_1;
					if (list_3 == null)
					{
						str2 = null;
					}
					else
					{
						GClass137 gclass3 = list_3[0];
						str2 = ((gclass3 != null) ? gclass3.String_6 : null);
					}
				}
			}
			@class.AppXIcon = Class397.smethod_1(str + str2);
			Class754 item = @class;
			this.class436_0.list_0.Add(item);
		}

		// Token: 0x04000D1B RID: 3355
		public GClass18 gclass18_0;

		// Token: 0x04000D1C RID: 3356
		public Class426.Class436 class436_0;
	}

	// Token: 0x020003BF RID: 959
	private sealed class Class438
	{
		// Token: 0x06001532 RID: 5426 RVA: 0x00057ED8 File Offset: 0x000560D8
		internal void method_0()
		{
			Class754 @class = new Class754(this.class435_0.class752_0);
			List<GClass126> list_ = this.gclass18_0.GClass209_0.List_0;
			string appXName;
			if (list_ == null)
			{
				appXName = null;
			}
			else
			{
				GClass126 gclass = list_[0];
				appXName = ((gclass != null) ? gclass.String_5 : null);
			}
			@class.AppXName = appXName;
			@class.AppXProductID = this.gclass18_0.GClass209_0.String_12;
			string str = "https:";
			List<GClass126> list_2 = this.gclass18_0.GClass209_0.List_0;
			string str2;
			if (list_2 == null)
			{
				str2 = null;
			}
			else
			{
				GClass126 gclass2 = list_2[0];
				if (gclass2 == null)
				{
					str2 = null;
				}
				else
				{
					List<GClass137> list_3 = gclass2.List_1;
					if (list_3 == null)
					{
						str2 = null;
					}
					else
					{
						GClass137 gclass3 = list_3[0];
						str2 = ((gclass3 != null) ? gclass3.String_6 : null);
					}
				}
			}
			@class.AppXIcon = Class397.smethod_1(str + str2);
			Class754 item = @class;
			this.class435_0.list_0.Add(item);
		}

		// Token: 0x04000D1D RID: 3357
		public GClass18 gclass18_0;

		// Token: 0x04000D1E RID: 3358
		public Class426.Class435 class435_0;
	}

	// Token: 0x020003C0 RID: 960
	[StructLayout(LayoutKind.Auto)]
	private struct Struct203 : IAsyncStateMachine
	{
		// Token: 0x06001533 RID: 5427 RVA: 0x00057FA4 File Offset: 0x000561A4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<Class754> list_;
			try
			{
				if (num != 0)
				{
					this.class436_0 = new Class426.Class436();
					this.class436_0.class752_0 = this.class752_0;
					this.class436_0.list_0 = null;
					Application.Current.Dispatcher.Invoke(new Action(this.class436_0.method_0));
				}
				try
				{
					TaskAwaiter<GClass18> awaiter;
					if (num != 0)
					{
						this.class437_0 = new Class426.Class437();
						this.class437_0.class436_0 = this.class436_0;
						awaiter = this.gclass162_0.method_1(this.string_0, (GEnum26)0, null).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass18>, Class426.Struct203>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<GClass18>);
						this.int_0 = -1;
					}
					GClass18 result = awaiter.GetResult();
					this.class437_0.gclass18_0 = result;
					if (this.class437_0.gclass18_0.GClass209_0 != null)
					{
						Application.Current.Dispatcher.Invoke(new Action(this.class437_0.method_0));
					}
					this.class437_0 = null;
				}
				catch (Exception exception_)
				{
					GClass141.smethod_0(exception_);
				}
				list_ = this.class436_0.list_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class436_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class436_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(list_);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00058170 File Offset: 0x00056370
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000D1F RID: 3359
		public int int_0;

		// Token: 0x04000D20 RID: 3360
		public AsyncTaskMethodBuilder<List<Class754>> asyncTaskMethodBuilder_0;

		// Token: 0x04000D21 RID: 3361
		public Class752 class752_0;

		// Token: 0x04000D22 RID: 3362
		public GClass162 gclass162_0;

		// Token: 0x04000D23 RID: 3363
		public string string_0;

		// Token: 0x04000D24 RID: 3364
		private Class426.Class437 class437_0;

		// Token: 0x04000D25 RID: 3365
		private Class426.Class436 class436_0;

		// Token: 0x04000D26 RID: 3366
		private TaskAwaiter<GClass18> taskAwaiter_0;
	}

	// Token: 0x020003C1 RID: 961
	private sealed class Class439
	{
		// Token: 0x06001536 RID: 5430 RVA: 0x00058188 File Offset: 0x00056388
		internal void method_0()
		{
			if (this.class752_0 != null)
			{
				this.class752_0.ProgressValue = 0.0;
			}
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x000581A8 File Offset: 0x000563A8
		internal void method_1()
		{
			if (this.class752_0 != null)
			{
				this.class752_0.ProgressValue = 0.0;
				this.class752_0.ProgressText = "0%";
				Class752 @class = this.class752_0;
				string str = Class364.smethod_0("storexins5");
				string format = " ({0}/{1})";
				int num = this.int_0;
				this.int_0 = num + 1;
				@class.InstallStatusText = str + string.Format(format, num, this.dictionary_0.Count);
			}
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0005822C File Offset: 0x0005642C
		internal void method_2()
		{
			if (this.class752_0 != null)
			{
				this.class752_0.ProgressValue = 0.0;
				this.class752_0.ProgressText = "0%";
				Class752 @class = this.class752_0;
				string str = Class364.smethod_0("storexins5");
				string format = " ({0}/{1})";
				int num = this.int_0;
				this.int_0 = num + 1;
				@class.InstallStatusText = str + string.Format(format, num, this.dictionary_0.Count);
			}
		}

		// Token: 0x04000D27 RID: 3367
		public Class752 class752_0;

		// Token: 0x04000D28 RID: 3368
		public int int_0;

		// Token: 0x04000D29 RID: 3369
		public Dictionary<string, GClass111> dictionary_0;

		// Token: 0x04000D2A RID: 3370
		public Action action_0;

		// Token: 0x04000D2B RID: 3371
		public Action action_1;

		// Token: 0x04000D2C RID: 3372
		public Action action_2;
	}
}
