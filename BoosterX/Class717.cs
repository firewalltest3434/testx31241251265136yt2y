using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;

// Token: 0x02000176 RID: 374
internal sealed class Class717 : GClass211
{
	// Token: 0x060009AD RID: 2477 RVA: 0x0002C780 File Offset: 0x0002A980
	public Class717()
	{
		this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
		this.method_1();
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x0002C7BC File Offset: 0x0002A9BC
	private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
	{
		base.method_0("News");
	}

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x060009AF RID: 2479 RVA: 0x0002C7CC File Offset: 0x0002A9CC
	// (set) Token: 0x060009B0 RID: 2480 RVA: 0x0002C7D4 File Offset: 0x0002A9D4
	public ObservableCollection<Class733> News
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("News");
		}
	}

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x060009B1 RID: 2481 RVA: 0x0002C7E8 File Offset: 0x0002A9E8
	// (set) Token: 0x060009B2 RID: 2482 RVA: 0x0002C7F0 File Offset: 0x0002A9F0
	public string _Error
	{
		[CompilerGenerated]
		get
		{
			return this.string_1;
		}
		[CompilerGenerated]
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x060009B3 RID: 2483 RVA: 0x0002C7FC File Offset: 0x0002A9FC
	// (set) Token: 0x060009B4 RID: 2484 RVA: 0x0002C804 File Offset: 0x0002AA04
	public string Error
	{
		get
		{
			return this._Error;
		}
		set
		{
			this._Error = value;
			base.method_0("Error");
		}
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x0002C818 File Offset: 0x0002AA18
	private void method_1()
	{
		Class717.Struct72 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class717_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class717.Struct72>(ref @struct);
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x0002C850 File Offset: 0x0002AA50
	private Task method_2()
	{
		Class717.Struct73 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class717_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class717.Struct73>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x0002C894 File Offset: 0x0002AA94
	private void method_3(Class383 class383_0)
	{
		this.News.Add(new Class733(class383_0));
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x0002C8A8 File Offset: 0x0002AAA8
	private void method_4(Class383 class383_0)
	{
		this.News.Add(new Class733(class383_0));
	}

	// Token: 0x04000599 RID: 1433
	private string string_0 = "News.json";

	// Token: 0x0400059A RID: 1434
	public ObservableCollection<Class733> observableCollection_0 = new ObservableCollection<Class733>();

	// Token: 0x0400059B RID: 1435
	private string string_1;

	// Token: 0x02000177 RID: 375
	[StructLayout(LayoutKind.Auto)]
	private struct Struct72 : IAsyncStateMachine
	{
		// Token: 0x060009B9 RID: 2489 RVA: 0x0002C8BC File Offset: 0x0002AABC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class717 @object = this.class717_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(@object.method_2)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class717.Struct72>(ref awaiter, ref this);
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

		// Token: 0x060009BA RID: 2490 RVA: 0x0002C97C File Offset: 0x0002AB7C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400059C RID: 1436
		public int int_0;

		// Token: 0x0400059D RID: 1437
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400059E RID: 1438
		public Class717 class717_0;

		// Token: 0x0400059F RID: 1439
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000178 RID: 376
	[StructLayout(LayoutKind.Auto)]
	private struct Struct73 : IAsyncStateMachine
	{
		// Token: 0x060009BB RID: 2491 RVA: 0x0002C98C File Offset: 0x0002AB8C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class717 @class = this.class717_0;
			try
			{
				TaskAwaiter<Class289> awaiter;
				if (num != 0)
				{
					if (Directory.Exists(Class186.string_7) && File.Exists(Path.Combine(Class186.string_7, @class.string_0)))
					{
						StreamReader streamReader = new StreamReader(Path.Combine(Class186.string_7, @class.string_0));
						try
						{
							string text = streamReader.ReadToEnd();
							streamReader.Close();
							try
							{
								Class717.Class202 class2 = new Class717.Class202();
								class2.class717_0 = @class;
								class2.list_0 = JsonConvert.DeserializeObject<List<Class383>>(text);
								Application.Current.Dispatcher.Invoke(new Action(class2.method_0));
							}
							catch
							{
								File.Delete(Path.Combine(Class186.string_7, @class.string_0));
							}
						}
						finally
						{
							if (num < 0 && streamReader != null)
							{
								((IDisposable)streamReader).Dispose();
							}
						}
					}
					awaiter = Class166.smethod_1(Class193.uri_6, null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class289>, Class717.Struct73>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Class289>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				Class289 result = awaiter.GetResult();
				if (!result.Success)
				{
					@class.Error = Class364.smethod_0("noconnection");
				}
				else
				{
					try
					{
						Class717.Class201 class3 = new Class717.Class201();
						class3.class717_0 = @class;
						class3.list_0 = JsonConvert.DeserializeObject<List<Class383>>(result.Message);
						Application.Current.Dispatcher.Invoke(new Action(class3.method_0));
						if (!Directory.Exists(Class186.string_7))
						{
							Directory.CreateDirectory(Class186.string_7);
						}
						StreamWriter streamWriter = new StreamWriter(Path.Combine(Class186.string_7, @class.string_0));
						try
						{
							streamWriter.Write(result.Message);
							streamWriter.Close();
						}
						finally
						{
							if (num < 0 && streamWriter != null)
							{
								((IDisposable)streamWriter).Dispose();
							}
						}
					}
					catch (Exception exception_)
					{
						GClass141.smethod_0(exception_);
						@class.Error = Class364.smethod_0("unknownerror");
					}
				}
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

		// Token: 0x060009BC RID: 2492 RVA: 0x0002CC60 File Offset: 0x0002AE60
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040005A0 RID: 1440
		public int int_0;

		// Token: 0x040005A1 RID: 1441
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040005A2 RID: 1442
		public Class717 class717_0;

		// Token: 0x040005A3 RID: 1443
		private TaskAwaiter<Class289> taskAwaiter_0;
	}

	// Token: 0x02000179 RID: 377
	private sealed class Class201
	{
		// Token: 0x060009BE RID: 2494 RVA: 0x0002CC78 File Offset: 0x0002AE78
		internal void method_0()
		{
			if (this.class717_0.News.Count<Class733>() > 0)
			{
				this.class717_0.News.Clear();
			}
			this.list_0.ForEach(new Action<Class383>(this.class717_0.method_4));
		}

		// Token: 0x040005A4 RID: 1444
		public List<Class383> list_0;

		// Token: 0x040005A5 RID: 1445
		public Class717 class717_0;
	}

	// Token: 0x0200017A RID: 378
	private sealed class Class202
	{
		// Token: 0x060009C0 RID: 2496 RVA: 0x0002CCCC File Offset: 0x0002AECC
		internal void method_0()
		{
			this.list_0.ForEach(new Action<Class383>(this.class717_0.method_3));
		}

		// Token: 0x040005A6 RID: 1446
		public List<Class383> list_0;

		// Token: 0x040005A7 RID: 1447
		public Class717 class717_0;
	}
}
