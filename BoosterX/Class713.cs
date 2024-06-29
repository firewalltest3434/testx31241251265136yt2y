using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ns0;

// Token: 0x020000CC RID: 204
internal sealed class Class713 : GClass211
{
	// Token: 0x06000619 RID: 1561 RVA: 0x0001EC2C File Offset: 0x0001CE2C
	public Class713()
	{
		this._appxDebloatTweak = new Class523(this);
		if (this.AppxBorderOpacity != null)
		{
			double? appxBorderOpacity = this.AppxBorderOpacity;
			if (!(appxBorderOpacity.GetValueOrDefault() == 0.0 & appxBorderOpacity != null))
			{
				return;
			}
		}
		this.method_12();
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x0600061A RID: 1562 RVA: 0x0001EC84 File Offset: 0x0001CE84
	// (set) Token: 0x0600061B RID: 1563 RVA: 0x0001EC8C File Offset: 0x0001CE8C
	public Class523 _appxDebloatTweak
	{
		[CompilerGenerated]
		get
		{
			return this.class523_0;
		}
		[CompilerGenerated]
		set
		{
			this.class523_0 = value;
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x0600061C RID: 1564 RVA: 0x0001EC98 File Offset: 0x0001CE98
	// (set) Token: 0x0600061D RID: 1565 RVA: 0x0001ECA0 File Offset: 0x0001CEA0
	public string AppxFriendlyName
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

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x0600061E RID: 1566 RVA: 0x0001ECAC File Offset: 0x0001CEAC
	// (set) Token: 0x0600061F RID: 1567 RVA: 0x0001ECB4 File Offset: 0x0001CEB4
	public string AppxLocation
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			this.method_1();
			base.method_0("AppxLocation");
		}
	}

	// Token: 0x06000620 RID: 1568 RVA: 0x0001ECD0 File Offset: 0x0001CED0
	private void method_1()
	{
		Class713.Struct23 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class713_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class713.Struct23>(ref @struct);
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06000621 RID: 1569 RVA: 0x0001ED08 File Offset: 0x0001CF08
	// (set) Token: 0x06000622 RID: 1570 RVA: 0x0001ED10 File Offset: 0x0001CF10
	public string AppxFullName
	{
		[CompilerGenerated]
		get
		{
			return this.string_2;
		}
		[CompilerGenerated]
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06000623 RID: 1571 RVA: 0x0001ED1C File Offset: 0x0001CF1C
	// (set) Token: 0x06000624 RID: 1572 RVA: 0x0001ED24 File Offset: 0x0001CF24
	public string AppxIcon
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
			base.method_0("AppxIcon");
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x06000625 RID: 1573 RVA: 0x0001ED38 File Offset: 0x0001CF38
	// (set) Token: 0x06000626 RID: 1574 RVA: 0x0001ED40 File Offset: 0x0001CF40
	public double? AppxBorderOpacity
	{
		get
		{
			return this.nullable_0;
		}
		set
		{
			this.nullable_0 = value;
			base.method_0("AppxBorderOpacity");
		}
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x0001ED54 File Offset: 0x0001CF54
	private bool method_2()
	{
		return this.bool_0;
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x0001ED5C File Offset: 0x0001CF5C
	private void method_3(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x06000629 RID: 1577 RVA: 0x0001ED68 File Offset: 0x0001CF68
	// (set) Token: 0x0600062A RID: 1578 RVA: 0x0001ED70 File Offset: 0x0001CF70
	public bool ToDelete
	{
		get
		{
			return this.method_2();
		}
		set
		{
			this.method_3(value);
			base.method_0("ToDelete");
			this.method_4();
		}
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x0001ED8C File Offset: 0x0001CF8C
	private void method_4()
	{
		Class713.Struct24 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class713_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class713.Struct24>(ref @struct);
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x0001EDC4 File Offset: 0x0001CFC4
	private SolidColorBrush method_5()
	{
		return this.solidColorBrush_0;
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x0001EDCC File Offset: 0x0001CFCC
	private void method_6(SolidColorBrush solidColorBrush_1)
	{
		this.solidColorBrush_0 = solidColorBrush_1;
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x0600062E RID: 1582 RVA: 0x0001EDD8 File Offset: 0x0001CFD8
	// (set) Token: 0x0600062F RID: 1583 RVA: 0x0001EDE0 File Offset: 0x0001CFE0
	public SolidColorBrush TextColor
	{
		get
		{
			return this.method_5();
		}
		set
		{
			this.method_6(value);
			base.method_0("TextColor");
		}
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x0001EDF4 File Offset: 0x0001CFF4
	private double method_7()
	{
		return this.double_0;
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x0001EDFC File Offset: 0x0001CFFC
	private void method_8(double double_1)
	{
		this.double_0 = double_1;
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x06000632 RID: 1586 RVA: 0x0001EE08 File Offset: 0x0001D008
	// (set) Token: 0x06000633 RID: 1587 RVA: 0x0001EE10 File Offset: 0x0001D010
	public double TextOpacity
	{
		get
		{
			return this.method_7();
		}
		set
		{
			this.method_8(value);
			base.method_0("TextOpacity");
		}
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x0001EE24 File Offset: 0x0001D024
	private string method_9()
	{
		return this.string_4;
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x0001EE2C File Offset: 0x0001D02C
	private void method_10(string string_5)
	{
		this.string_4 = string_5;
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x06000636 RID: 1590 RVA: 0x0001EE38 File Offset: 0x0001D038
	// (set) Token: 0x06000637 RID: 1591 RVA: 0x0001EE40 File Offset: 0x0001D040
	public string Text
	{
		get
		{
			return this.method_9();
		}
		set
		{
			this.method_10(value);
			base.method_0("Text");
		}
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x0001EE54 File Offset: 0x0001D054
	private void method_11(string string_5, SolidColorBrush solidColorBrush_1)
	{
		Class713.Struct26 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class713_0 = this;
		@struct.string_0 = string_5;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class713.Struct26>(ref @struct);
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x0001EE9C File Offset: 0x0001D09C
	private void method_12()
	{
		Class713.Struct27 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class713_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class713.Struct27>(ref @struct);
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x0001EED4 File Offset: 0x0001D0D4
	private void method_13()
	{
		try
		{
			Class713.Class133 @class = new Class713.Class133();
			@class.class713_0 = this;
			string text = Class185.smethod_11(this.AppxLocation);
			if (!File.Exists(text))
			{
				string str = text.Split(new char[]
				{
					'\\'
				}).Last<string>().Split(new char[]
				{
					'.'
				}).First<string>();
				text = Directory.GetFiles(this.AppxLocation, str + "*.png", SearchOption.AllDirectories).First<string>();
			}
			@class.string_0 = Path.GetTempPath() + this.AppxLocation.Split(new char[]
			{
				'\\'
			}).Last<string>().Split(new char[]
			{
				'_'
			}).First<string>() + text.Split(new char[]
			{
				'\\'
			}).Last<string>();
			if (!File.Exists(@class.string_0))
			{
				File.Copy(text, @class.string_0, true);
			}
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}
		catch
		{
			Application.Current.Dispatcher.Invoke(new Action(this.method_14));
		}
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x0001F008 File Offset: 0x0001D208
	private void method_14()
	{
		this.AppxIcon = string.Empty;
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x0001F018 File Offset: 0x0001D218
	private void method_15()
	{
		if (!this.method_2())
		{
			this.method_11(Class364.smethod_0("Calculating"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			this.method_11(Class185.smethod_7(this.AppxLocation).ToString() + " MB", Brushes.Gray);
			GClass93.smethod_0().method_15(typeof(Class523), this.AppxFullName);
			return;
		}
		this.method_11(Class364.smethod_0("willbedeleted"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
		GClass93.smethod_0().method_9<Class523>(this.AppxFullName, new Func<Class523>(this.method_16), string.Empty);
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x0001F0C0 File Offset: 0x0001D2C0
	private Class523 method_16()
	{
		return this._appxDebloatTweak;
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x0001F0C8 File Offset: 0x0001D2C8
	private Task method_17()
	{
		Class713.Struct25 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class713_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class713.Struct25>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0400028E RID: 654
	private Class523 class523_0;

	// Token: 0x0400028F RID: 655
	private string string_0;

	// Token: 0x04000290 RID: 656
	private string string_1;

	// Token: 0x04000291 RID: 657
	private string string_2;

	// Token: 0x04000292 RID: 658
	private string string_3;

	// Token: 0x04000293 RID: 659
	private double? nullable_0;

	// Token: 0x04000294 RID: 660
	private bool bool_0;

	// Token: 0x04000295 RID: 661
	private SolidColorBrush solidColorBrush_0;

	// Token: 0x04000296 RID: 662
	private double double_0;

	// Token: 0x04000297 RID: 663
	private string string_4;

	// Token: 0x020000CD RID: 205
	private sealed class Class132
	{
		// Token: 0x06000640 RID: 1600 RVA: 0x0001F114 File Offset: 0x0001D314
		internal Task method_0()
		{
			Class713.Class132.Struct22 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class132_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class713.Class132.Struct22>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04000298 RID: 664
		public Class713 class713_0;

		// Token: 0x04000299 RID: 665
		public string string_0;

		// Token: 0x0400029A RID: 666
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x020000CE RID: 206
		[StructLayout(LayoutKind.Auto)]
		private struct Struct22 : IAsyncStateMachine
		{
			// Token: 0x06000641 RID: 1601 RVA: 0x0001F158 File Offset: 0x0001D358
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class713.Class132 @class = this.class132_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_110;
					}
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_182;
					}
					IL_1D:
					if (@class.class713_0.TextOpacity == 0.0)
					{
						if (@class.string_0 != null)
						{
							@class.class713_0.Text = @class.string_0;
						}
						@class.class713_0.TextColor = @class.solidColorBrush_0;
						goto IL_189;
					}
					@class.class713_0.TextOpacity = @class.class713_0.TextOpacity - 0.1;
					if (@class.class713_0.TextOpacity < 0.05)
					{
						@class.class713_0.TextOpacity = 0.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class713.Class132.Struct22>(ref awaiter, ref this);
						return;
					}
					IL_110:
					awaiter.GetResult();
					goto IL_1D;
					IL_182:
					awaiter.GetResult();
					IL_189:
					if (@class.class713_0.TextOpacity != 1.0)
					{
						@class.class713_0.TextOpacity = @class.class713_0.TextOpacity + 0.13333333333333333;
						if (@class.class713_0.TextOpacity > 0.95)
						{
							@class.class713_0.TextOpacity = 1.0;
						}
						awaiter = Task.Delay(10).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_182;
						}
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class713.Class132.Struct22>(ref awaiter, ref this);
						return;
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

			// Token: 0x06000642 RID: 1602 RVA: 0x0001F39C File Offset: 0x0001D59C
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400029B RID: 667
			public int int_0;

			// Token: 0x0400029C RID: 668
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x0400029D RID: 669
			public Class713.Class132 class132_0;

			// Token: 0x0400029E RID: 670
			private TaskAwaiter taskAwaiter_0;
		}
	}

	// Token: 0x020000CF RID: 207
	[StructLayout(LayoutKind.Auto)]
	private struct Struct23 : IAsyncStateMachine
	{
		// Token: 0x06000643 RID: 1603 RVA: 0x0001F3AC File Offset: 0x0001D5AC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class713 @object = this.class713_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_13)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class713.Struct23>(ref awaiter, ref this);
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

		// Token: 0x06000644 RID: 1604 RVA: 0x0001F46C File Offset: 0x0001D66C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400029F RID: 671
		public int int_0;

		// Token: 0x040002A0 RID: 672
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040002A1 RID: 673
		public Class713 class713_0;

		// Token: 0x040002A2 RID: 674
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000D0 RID: 208
	private sealed class Class133
	{
		// Token: 0x06000646 RID: 1606 RVA: 0x0001F484 File Offset: 0x0001D684
		internal void method_0()
		{
			this.class713_0.AppxIcon = this.string_0;
		}

		// Token: 0x040002A3 RID: 675
		public string string_0;

		// Token: 0x040002A4 RID: 676
		public Class713 class713_0;
	}

	// Token: 0x020000D1 RID: 209
	[StructLayout(LayoutKind.Auto)]
	private struct Struct24 : IAsyncStateMachine
	{
		// Token: 0x06000647 RID: 1607 RVA: 0x0001F498 File Offset: 0x0001D698
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class713 @object = this.class713_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_15)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class713.Struct24>(ref awaiter, ref this);
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

		// Token: 0x06000648 RID: 1608 RVA: 0x0001F558 File Offset: 0x0001D758
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040002A5 RID: 677
		public int int_0;

		// Token: 0x040002A6 RID: 678
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040002A7 RID: 679
		public Class713 class713_0;

		// Token: 0x040002A8 RID: 680
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000D2 RID: 210
	[StructLayout(LayoutKind.Auto)]
	private struct Struct25 : IAsyncStateMachine
	{
		// Token: 0x06000649 RID: 1609 RVA: 0x0001F568 File Offset: 0x0001D768
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class713 @class = this.class713_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_100;
				}
				@class.AppxBorderOpacity = new double?(0.0);
				IL_28:
				double? appxBorderOpacity = @class.AppxBorderOpacity;
				double num2 = (double)1f;
				if (appxBorderOpacity.GetValueOrDefault() == num2 & appxBorderOpacity != null)
				{
					goto IL_151;
				}
				@class.AppxBorderOpacity += 0.13333333333333333;
				appxBorderOpacity = @class.AppxBorderOpacity;
				num2 = 0.95;
				if (appxBorderOpacity.GetValueOrDefault() > num2 & appxBorderOpacity != null)
				{
					@class.AppxBorderOpacity = new double?((double)1f);
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class713.Struct25>(ref awaiter, ref this);
					return;
				}
				IL_100:
				awaiter.GetResult();
				goto IL_28;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_151:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0001F6F8 File Offset: 0x0001D8F8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040002A9 RID: 681
		public int int_0;

		// Token: 0x040002AA RID: 682
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040002AB RID: 683
		public Class713 class713_0;

		// Token: 0x040002AC RID: 684
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000D3 RID: 211
	[StructLayout(LayoutKind.Auto)]
	private struct Struct26 : IAsyncStateMachine
	{
		// Token: 0x0600064B RID: 1611 RVA: 0x0001F708 File Offset: 0x0001D908
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					Class713.Class132 @class = new Class713.Class132();
					@class.class713_0 = this.class713_0;
					@class.string_0 = this.string_0;
					@class.solidColorBrush_0 = this.solidColorBrush_0;
					awaiter = Application.Current.Dispatcher.Invoke<Task>(new Func<Task>(@class.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class713.Struct26>(ref awaiter, ref this);
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

		// Token: 0x0600064C RID: 1612 RVA: 0x0001F7F4 File Offset: 0x0001D9F4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040002AD RID: 685
		public int int_0;

		// Token: 0x040002AE RID: 686
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040002AF RID: 687
		public Class713 class713_0;

		// Token: 0x040002B0 RID: 688
		public string string_0;

		// Token: 0x040002B1 RID: 689
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040002B2 RID: 690
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000D4 RID: 212
	[StructLayout(LayoutKind.Auto)]
	private struct Struct27 : IAsyncStateMachine
	{
		// Token: 0x0600064D RID: 1613 RVA: 0x0001F804 File Offset: 0x0001DA04
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class713 @object = this.class713_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Application.Current.Dispatcher.Invoke<Task>(new Func<Task>(@object.method_17)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class713.Struct27>(ref awaiter, ref this);
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

		// Token: 0x0600064E RID: 1614 RVA: 0x0001F8CC File Offset: 0x0001DACC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040002B3 RID: 691
		public int int_0;

		// Token: 0x040002B4 RID: 692
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040002B5 RID: 693
		public Class713 class713_0;

		// Token: 0x040002B6 RID: 694
		private TaskAwaiter taskAwaiter_0;
	}
}
