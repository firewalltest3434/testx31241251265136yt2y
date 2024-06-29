using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;

// Token: 0x020000C4 RID: 196
internal sealed class Class131
{
	// Token: 0x020000C5 RID: 197
	public sealed class Class711 : GClass211
	{
		// Token: 0x060005EA RID: 1514 RVA: 0x0001E478 File Offset: 0x0001C678
		public Class711()
		{
			this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0001E4A4 File Offset: 0x0001C6A4
		public void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
		{
			base.method_0("PropertyCh");
		}

		// Token: 0x04000271 RID: 625
		public ObservableCollection<Class131.Class712> observableCollection_0 = new ObservableCollection<Class131.Class712>();
	}

	// Token: 0x020000C6 RID: 198
	public sealed class Class712 : GClass211
	{
		// Token: 0x060005EC RID: 1516 RVA: 0x0001E4B4 File Offset: 0x0001C6B4
		public Class712()
		{
			this.method_1();
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x0001E4EC File Offset: 0x0001C6EC
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x0001E4F4 File Offset: 0x0001C6F4
		public bool IsUser
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
				if (!value)
				{
					this.method_2();
				}
				base.method_0("IsUser");
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x0001E514 File Offset: 0x0001C714
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x0001E51C File Offset: 0x0001C71C
		public bool IsGenerating
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				this.bool_1 = value;
				if (value)
				{
					this.method_4();
				}
				else
				{
					this.method_3();
				}
				base.method_0("IsGenerating");
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0001E544 File Offset: 0x0001C744
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x0001E54C File Offset: 0x0001C74C
		public bool IsSystemMessage
		{
			get
			{
				return this.bool_2;
			}
			set
			{
				this.bool_2 = value;
				base.method_0("IsSystemMessage");
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x0001E560 File Offset: 0x0001C760
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x0001E568 File Offset: 0x0001C768
		public bool IsMessageOnWrite
		{
			get
			{
				return this.bool_3;
			}
			set
			{
				this.bool_3 = value;
				base.method_0("IsMessageOnWrite");
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0001E57C File Offset: 0x0001C77C
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x0001E584 File Offset: 0x0001C784
		public string Message
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
				base.method_0("Message");
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x0001E598 File Offset: 0x0001C798
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x0001E5A0 File Offset: 0x0001C7A0
		public Visibility HasTweak
		{
			get
			{
				return this.visibility_0;
			}
			set
			{
				this.visibility_0 = value;
				base.method_0("HasTweak");
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x0001E5B4 File Offset: 0x0001C7B4
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x0001E5BC File Offset: 0x0001C7BC
		public List<Class745> Tweaks
		{
			get
			{
				return this.list_0;
			}
			set
			{
				this.list_0 = value;
				base.method_0("Tweaks");
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x0001E5D0 File Offset: 0x0001C7D0
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x0001E5D8 File Offset: 0x0001C7D8
		public Visibility TypingVisiblity
		{
			get
			{
				return this.visibility_1;
			}
			set
			{
				this.visibility_1 = value;
				base.method_0("TypingVisiblity");
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x0001E5EC File Offset: 0x0001C7EC
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x0001E5F4 File Offset: 0x0001C7F4
		public double TypingOpacity
		{
			get
			{
				return this.double_0;
			}
			set
			{
				this.double_0 = value;
				base.method_0("TypingOpacity");
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x0001E608 File Offset: 0x0001C808
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x0001E610 File Offset: 0x0001C810
		public Visibility GenVisiblity
		{
			get
			{
				return this.visibility_2;
			}
			set
			{
				this.visibility_2 = value;
				base.method_0("GenVisiblity");
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x0001E624 File Offset: 0x0001C824
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x0001E62C File Offset: 0x0001C82C
		public double GenOpacity
		{
			get
			{
				return this.double_1;
			}
			set
			{
				this.double_1 = value;
				base.method_0("GenOpacity");
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x0001E640 File Offset: 0x0001C840
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x0001E648 File Offset: 0x0001C848
		public double MainOpacity
		{
			get
			{
				return this.double_2;
			}
			set
			{
				this.double_2 = value;
				base.method_0("MainOpacity");
			}
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0001E65C File Offset: 0x0001C85C
		private void method_1()
		{
			Class131.Class712.Struct21 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.class712_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class131.Class712.Struct21>(ref @struct);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0001E694 File Offset: 0x0001C894
		private void method_2()
		{
			Class131.Class712.Struct19 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.class712_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class131.Class712.Struct19>(ref @struct);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0001E6CC File Offset: 0x0001C8CC
		private void method_3()
		{
			this.GenVisiblity = Visibility.Collapsed;
			this.GenOpacity = 0.0;
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0001E6E4 File Offset: 0x0001C8E4
		private void method_4()
		{
			Class131.Class712.Struct20 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.class712_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class131.Class712.Struct20>(ref @struct);
		}

		// Token: 0x04000272 RID: 626
		private bool bool_0;

		// Token: 0x04000273 RID: 627
		private bool bool_1;

		// Token: 0x04000274 RID: 628
		private bool bool_2;

		// Token: 0x04000275 RID: 629
		private bool bool_3 = true;

		// Token: 0x04000276 RID: 630
		private string string_0;

		// Token: 0x04000277 RID: 631
		private Visibility visibility_0 = Visibility.Collapsed;

		// Token: 0x04000278 RID: 632
		private List<Class745> list_0 = new List<Class745>();

		// Token: 0x04000279 RID: 633
		private Visibility visibility_1 = Visibility.Collapsed;

		// Token: 0x0400027A RID: 634
		private double double_0;

		// Token: 0x0400027B RID: 635
		private Visibility visibility_2 = Visibility.Collapsed;

		// Token: 0x0400027C RID: 636
		private double double_1;

		// Token: 0x0400027D RID: 637
		private double double_2;

		// Token: 0x020000C7 RID: 199
		[StructLayout(LayoutKind.Auto)]
		private struct Struct19 : IAsyncStateMachine
		{
			// Token: 0x06000609 RID: 1545 RVA: 0x0001E71C File Offset: 0x0001C91C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class131.Class712 @class = this.class712_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_D1;
					}
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_101;
					}
					@class.TypingVisiblity = Visibility.Visible;
					IL_24:
					if (@class.TypingOpacity == 1.0)
					{
						goto IL_108;
					}
					@class.TypingOpacity += 0.13333333333333333;
					if (@class.TypingOpacity > 0.95)
					{
						@class.TypingOpacity = 1.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class131.Class712.Struct19>(ref awaiter, ref this);
						return;
					}
					IL_D1:
					awaiter.GetResult();
					goto IL_24;
					IL_101:
					awaiter.GetResult();
					IL_108:
					if (!(@class.Message == string.Empty))
					{
						@class.TypingVisiblity = Visibility.Collapsed;
						@class.TypingOpacity = 0.0;
					}
					else if (!@class.IsGenerating)
					{
						awaiter = Task.Delay(10).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_101;
						}
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class131.Class712.Struct19>(ref awaiter, ref this);
						return;
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

			// Token: 0x0600060A RID: 1546 RVA: 0x0001E8F8 File Offset: 0x0001CAF8
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400027E RID: 638
			public int int_0;

			// Token: 0x0400027F RID: 639
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04000280 RID: 640
			public Class131.Class712 class712_0;

			// Token: 0x04000281 RID: 641
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020000C8 RID: 200
		[StructLayout(LayoutKind.Auto)]
		private struct Struct20 : IAsyncStateMachine
		{
			// Token: 0x0600060B RID: 1547 RVA: 0x0001E908 File Offset: 0x0001CB08
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class131.Class712 @class = this.class712_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_BD;
					}
					@class.TypingVisiblity = Visibility.Collapsed;
					@class.TypingOpacity = 0.0;
					@class.GenVisiblity = Visibility.Visible;
					IL_31:
					if (@class.GenOpacity == 1.0)
					{
						goto IL_106;
					}
					@class.GenOpacity += 0.13333333333333333;
					if (@class.GenOpacity > 0.95)
					{
						@class.GenOpacity = 1.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class131.Class712.Struct20>(ref awaiter, ref this);
						return;
					}
					IL_BD:
					awaiter.GetResult();
					goto IL_31;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_106:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600060C RID: 1548 RVA: 0x0001EA40 File Offset: 0x0001CC40
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000282 RID: 642
			public int int_0;

			// Token: 0x04000283 RID: 643
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04000284 RID: 644
			public Class131.Class712 class712_0;

			// Token: 0x04000285 RID: 645
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020000C9 RID: 201
		[StructLayout(LayoutKind.Auto)]
		private struct Struct21 : IAsyncStateMachine
		{
			// Token: 0x0600060D RID: 1549 RVA: 0x0001EA50 File Offset: 0x0001CC50
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class131.Class712 @class = this.class712_0;
				try
				{
					if (num != 0)
					{
						goto IL_8E;
					}
					TaskAwaiter awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					IL_87:
					awaiter.GetResult();
					IL_8E:
					if (@class.MainOpacity != 1.0)
					{
						@class.MainOpacity += 0.13333333333333333;
						if (@class.MainOpacity > 0.95)
						{
							@class.MainOpacity = 1.0;
						}
						awaiter = Task.Delay(40).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_87;
						}
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class131.Class712.Struct21>(ref awaiter, ref this);
						return;
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

			// Token: 0x0600060E RID: 1550 RVA: 0x0001EB64 File Offset: 0x0001CD64
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000286 RID: 646
			public int int_0;

			// Token: 0x04000287 RID: 647
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04000288 RID: 648
			public Class131.Class712 class712_0;

			// Token: 0x04000289 RID: 649
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
