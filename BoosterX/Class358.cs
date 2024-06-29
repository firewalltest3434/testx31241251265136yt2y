using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ns0;

// Token: 0x020002E3 RID: 739
internal sealed class Class358
{
	// Token: 0x060010F7 RID: 4343 RVA: 0x000477E4 File Offset: 0x000459E4
	private Class358()
	{
	}

	// Token: 0x060010F8 RID: 4344 RVA: 0x00047948 File Offset: 0x00045B48
	public static Class358 smethod_0()
	{
		if (Class358.class358_0 == null)
		{
			Class358.class358_0 = new Class358();
		}
		return Class358.class358_0;
	}

	// Token: 0x060010F9 RID: 4345 RVA: 0x00047960 File Offset: 0x00045B60
	public Task<object> method_0(Type type_0)
	{
		Class358.Struct156 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<object>.Create();
		@struct.class358_0 = this;
		@struct.type_0 = type_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class358.Struct156>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060010FA RID: 4346 RVA: 0x000479AC File Offset: 0x00045BAC
	public Task<object> method_1(Type type_0)
	{
		Class358.Struct155 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<object>.Create();
		@struct.class358_0 = this;
		@struct.type_0 = type_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class358.Struct155>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060010FB RID: 4347 RVA: 0x000479F8 File Offset: 0x00045BF8
	public Task method_2(Type type_0)
	{
		Class358.Struct157 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class358_0 = this;
		@struct.type_0 = type_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class358.Struct157>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060010FC RID: 4348 RVA: 0x00047A44 File Offset: 0x00045C44
	public void method_3(Type type_0, Frame frame_4)
	{
		Class358.Struct154 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class358_0 = this;
		@struct.type_0 = type_0;
		@struct.frame_0 = frame_4;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class358.Struct154>(ref @struct);
	}

	// Token: 0x060010FD RID: 4349 RVA: 0x00047A8C File Offset: 0x00045C8C
	public void method_4(Type type_0)
	{
		new dje_z8VF85V8XHQJ2N4WA52Y63GQ3X9G8QE5HD473ZEY3_ejd(typeof(dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd)).Show();
	}

	// Token: 0x060010FE RID: 4350 RVA: 0x00047AA4 File Offset: 0x00045CA4
	public Window method_5(Type type_0)
	{
		Class358.Class362 @class = new Class358.Class362();
		@class.type_0 = type_0;
		return Application.Current.Dispatcher.Invoke<Window>(new Func<Window>(@class.method_0));
	}

	// Token: 0x060010FF RID: 4351 RVA: 0x00047ADC File Offset: 0x00045CDC
	public Task method_6()
	{
		this.list_2.Clear();
		try
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
			GC.Collect();
			while (this.frame_0.NavigationService.RemoveBackEntry() != null)
			{
			}
		}
		catch (object obj)
		{
		}
		Class655.smethod_1();
		try
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
			GC.Collect();
		}
		catch (object obj2)
		{
		}
		return Task.CompletedTask;
	}

	// Token: 0x04000A47 RID: 2631
	private static Class358 class358_0;

	// Token: 0x04000A48 RID: 2632
	public List<Type> list_0 = new List<Type>
	{
		typeof(dje_zYPQKVHV4ELZF9HATU6HU9QNCKG5CDLSCPBQXLLW5L5927RPJPF2UK7DXV23A_ejd),
		typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd),
		typeof(dje_zMRNJMY8LXC8JEAZBR27ZQYBV3R5VZ89KXGVN3G7UUNPME38ZKS6PJB7CH77U7HZPP3_ejd),
		typeof(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd),
		typeof(dje_z4EFBE23NRXT78H3EAL45CK9M5K537HLZVTED9PC5FL6WLE8YYJD3VFKL5QNA_ejd),
		typeof(dje_zPV9EV2BDCHXQH35DVJL4BPMXCFMJM3NRZT64XH72KWT6TPH46ZAALK2JQUUA_ejd),
		typeof(dje_z627PU6QDPF5L5L22PZKAYL8VEPS25LWV7TFR5U5JH6MNTERGA6VSXSKBF49Q_ejd),
		typeof(dje_z8NYEPSSJS77QLDRYJP4YDHXMCCZX642R76WUWAX6XD7EC3JPH2Y7TCVK5HRQ_ejd),
		typeof(dje_zTGEPDZPEXBPCNC7GHSZYZV868XZCRS2VHUBBLX2NGBMBUBPFKXX7KVDJJJJPWEWFPS_ejd),
		typeof(dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd),
		typeof(dje_zEAHJHJCF7YEVQXCTVJ6ZYLNYMV3GV7DXZT4HM29Y3NNNKUR5WQZEF_ejd),
		typeof(dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd),
		typeof(dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd)
	};

	// Token: 0x04000A49 RID: 2633
	public List<Type> list_1 = new List<Type>
	{
		typeof(dje_zQQ3WV9B57B4Q2DKX7UXQQ3W7C8NZFEHVBRNTGQEURUFDS2REYAJR4_ejd),
		typeof(dje_z34Q9QPAA7BQQJMZXHNU4FEKEN2D27DPBNGJF3B2SU3DB3VTR63M8E_ejd),
		typeof(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd),
		typeof(dje_zGU8RRRCRFHL6UCRYZQ7BE3MV3MUB4LDX899YZ688K9QWF72_ejd),
		typeof(dje_zA6HRDGVQ449XDH4D5NPJHBXAQ5BZC26NDGXJQ5PLSURH2QZ_ejd),
		typeof(dje_zF5RBQBAG5YAJ8ZN4XLUCQ6DCAWKZ7LNPXW2R3TZDK3BHNS2_ejd)
	};

	// Token: 0x04000A4A RID: 2634
	public List<Page> list_2 = new List<Page>();

	// Token: 0x04000A4B RID: 2635
	public Frame frame_0;

	// Token: 0x04000A4C RID: 2636
	public dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd dje_z8NYEPSSJS77QLDRYJP4YDHXMCMFPJZU47H9BSPLK9CBEHD2_ejd_0;

	// Token: 0x04000A4D RID: 2637
	public Frame frame_1;

	// Token: 0x04000A4E RID: 2638
	public Frame frame_2;

	// Token: 0x04000A4F RID: 2639
	public Frame frame_3;

	// Token: 0x04000A50 RID: 2640
	private Page page_0;

	// Token: 0x04000A51 RID: 2641
	public bool bool_0;

	// Token: 0x020002E4 RID: 740
	[StructLayout(LayoutKind.Auto)]
	private struct Struct154 : IAsyncStateMachine
	{
		// Token: 0x06001100 RID: 4352 RVA: 0x00047B54 File Offset: 0x00045D54
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class358 @class = this.class358_0;
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
				if (num != 1)
				{
					this.class359_0 = new Class358.Class359();
					this.class359_0.type_0 = this.type_0;
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(this.frame_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class358.Struct154>(ref awaiter, ref this);
						return;
					}
					goto IL_BD;
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				IL_95:
				awaiter.GetResult();
				goto IL_1A4;
				IL_BD:
				awaiter.GetResult();
				Page page = @class.list_2.FirstOrDefault(new Func<Page, bool>(this.class359_0.method_0));
				if (page != null)
				{
					this.frame_0.NavigationService.Navigate(page);
				}
				else
				{
					@class.page_0 = (Page)Activator.CreateInstance(this.class359_0.type_0);
					@class.list_2.Add(@class.page_0);
					this.frame_0.NavigationService.Navigate(@class.page_0);
				}
				awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(this.frame_0).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class358.Struct154>(ref awaiter, ref this);
					return;
				}
				goto IL_95;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class359_0 = null;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1A4:
			this.int_0 = -2;
			this.class359_0 = null;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x00047D3C File Offset: 0x00045F3C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000A52 RID: 2642
		public int int_0;

		// Token: 0x04000A53 RID: 2643
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000A54 RID: 2644
		public Type type_0;

		// Token: 0x04000A55 RID: 2645
		public Frame frame_0;

		// Token: 0x04000A56 RID: 2646
		public Class358 class358_0;

		// Token: 0x04000A57 RID: 2647
		private Class358.Class359 class359_0;

		// Token: 0x04000A58 RID: 2648
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002E5 RID: 741
	[StructLayout(LayoutKind.Auto)]
	private struct Struct155 : IAsyncStateMachine
	{
		// Token: 0x06001102 RID: 4354 RVA: 0x00047D4C File Offset: 0x00045F4C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			object result;
			try
			{
				TaskAwaiter<Page> awaiter;
				if (num != 0)
				{
					Class358.Class363 @class = new Class358.Class363();
					@class.class358_0 = this.class358_0;
					@class.type_0 = this.type_0;
					awaiter = Application.Current.Dispatcher.InvokeAsync<Page>(new Func<Page>(@class.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Page>, Class358.Struct155>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Page>);
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

		// Token: 0x06001103 RID: 4355 RVA: 0x00047E30 File Offset: 0x00046030
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000A59 RID: 2649
		public int int_0;

		// Token: 0x04000A5A RID: 2650
		public AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder_0;

		// Token: 0x04000A5B RID: 2651
		public Class358 class358_0;

		// Token: 0x04000A5C RID: 2652
		public Type type_0;

		// Token: 0x04000A5D RID: 2653
		private TaskAwaiter<Page> taskAwaiter_0;
	}

	// Token: 0x020002E6 RID: 742
	private sealed class Class359
	{
		// Token: 0x06001105 RID: 4357 RVA: 0x00047E48 File Offset: 0x00046048
		internal bool method_0(Page page_0)
		{
			return page_0.GetType() == this.type_0;
		}

		// Token: 0x04000A5E RID: 2654
		public Type type_0;
	}

	// Token: 0x020002E7 RID: 743
	private sealed class Class360
	{
		// Token: 0x06001107 RID: 4359 RVA: 0x00047E64 File Offset: 0x00046064
		internal void method_0()
		{
			IEnumerable<Page> list_ = this.class358_0.list_2;
			Func<Page, bool> predicate;
			if ((predicate = this.func_0) == null)
			{
				predicate = (this.func_0 = new Func<Page, bool>(this.method_1));
			}
			if (list_.Any(predicate))
			{
				List<Page> list_2 = this.class358_0.list_2;
				IEnumerable<Page> list_3 = this.class358_0.list_2;
				Func<Page, bool> predicate2;
				if ((predicate2 = this.func_1) == null)
				{
					predicate2 = (this.func_1 = new Func<Page, bool>(this.method_2));
				}
				list_2.Remove(list_3.FirstOrDefault(predicate2));
			}
			this.class358_0.list_2.Add((Page)Activator.CreateInstance(this.type_0));
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00047F04 File Offset: 0x00046104
		internal bool method_1(Page page_0)
		{
			return page_0.GetType() == this.type_0;
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00047F18 File Offset: 0x00046118
		internal bool method_2(Page page_0)
		{
			return page_0.GetType() == this.type_0;
		}

		// Token: 0x04000A5F RID: 2655
		public Class358 class358_0;

		// Token: 0x04000A60 RID: 2656
		public Type type_0;

		// Token: 0x04000A61 RID: 2657
		public Func<Page, bool> func_0;

		// Token: 0x04000A62 RID: 2658
		public Func<Page, bool> func_1;
	}

	// Token: 0x020002E8 RID: 744
	[StructLayout(LayoutKind.Auto)]
	private struct Struct156 : IAsyncStateMachine
	{
		// Token: 0x0600110A RID: 4362 RVA: 0x00047F2C File Offset: 0x0004612C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			object result;
			try
			{
				TaskAwaiter<object> awaiter;
				if (num != 0)
				{
					Class358.Class361 @class = new Class358.Class361();
					@class.class358_0 = this.class358_0;
					@class.type_0 = this.type_0;
					awaiter = Application.Current.Dispatcher.InvokeAsync<object>(new Func<object>(@class.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Class358.Struct156>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<object>);
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

		// Token: 0x0600110B RID: 4363 RVA: 0x00048010 File Offset: 0x00046210
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000A63 RID: 2659
		public int int_0;

		// Token: 0x04000A64 RID: 2660
		public AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder_0;

		// Token: 0x04000A65 RID: 2661
		public Class358 class358_0;

		// Token: 0x04000A66 RID: 2662
		public Type type_0;

		// Token: 0x04000A67 RID: 2663
		private TaskAwaiter<object> taskAwaiter_0;
	}

	// Token: 0x020002E9 RID: 745
	[StructLayout(LayoutKind.Auto)]
	private struct Struct157 : IAsyncStateMachine
	{
		// Token: 0x0600110C RID: 4364 RVA: 0x00048020 File Offset: 0x00046220
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					Class358.Class360 @class = new Class358.Class360();
					@class.class358_0 = this.class358_0;
					@class.type_0 = this.type_0;
					awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(@class.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class358.Struct157>(ref awaiter, ref this);
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

		// Token: 0x0600110D RID: 4365 RVA: 0x00048100 File Offset: 0x00046300
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000A68 RID: 2664
		public int int_0;

		// Token: 0x04000A69 RID: 2665
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000A6A RID: 2666
		public Class358 class358_0;

		// Token: 0x04000A6B RID: 2667
		public Type type_0;

		// Token: 0x04000A6C RID: 2668
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002EA RID: 746
	private sealed class Class361
	{
		// Token: 0x0600110F RID: 4367 RVA: 0x00048118 File Offset: 0x00046318
		internal object method_0()
		{
			IEnumerable<Page> list_ = this.class358_0.list_2;
			Func<Page, bool> predicate;
			if ((predicate = this.func_0) == null)
			{
				predicate = (this.func_0 = new Func<Page, bool>(this.method_1));
			}
			Page page = list_.FirstOrDefault(predicate);
			if (page == null)
			{
				return null;
			}
			return page.DataContext;
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x00048160 File Offset: 0x00046360
		internal bool method_1(Page page_0)
		{
			return page_0.GetType() == this.type_0;
		}

		// Token: 0x04000A6D RID: 2669
		public Class358 class358_0;

		// Token: 0x04000A6E RID: 2670
		public Type type_0;

		// Token: 0x04000A6F RID: 2671
		public Func<Page, bool> func_0;
	}

	// Token: 0x020002EB RID: 747
	private sealed class Class362
	{
		// Token: 0x06001112 RID: 4370 RVA: 0x0004817C File Offset: 0x0004637C
		internal Window method_0()
		{
			foreach (Window window in Application.Current.Windows.Cast<Window>())
			{
				if (window.GetType() == this.type_0)
				{
					return window;
				}
			}
			return null;
		}

		// Token: 0x04000A70 RID: 2672
		public Type type_0;
	}

	// Token: 0x020002EC RID: 748
	private sealed class Class363
	{
		// Token: 0x06001114 RID: 4372 RVA: 0x000481F0 File Offset: 0x000463F0
		internal Page method_0()
		{
			IEnumerable<Page> list_ = this.class358_0.list_2;
			Func<Page, bool> predicate;
			if ((predicate = this.func_0) == null)
			{
				predicate = (this.func_0 = new Func<Page, bool>(this.method_1));
			}
			Page page = list_.FirstOrDefault(predicate);
			if (page == null)
			{
				page = (Page)Activator.CreateInstance(this.type_0);
				this.class358_0.list_2.Add(page);
			}
			return page;
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00048254 File Offset: 0x00046454
		internal bool method_1(Page page_0)
		{
			return page_0.GetType() == this.type_0;
		}

		// Token: 0x04000A71 RID: 2673
		public Class358 class358_0;

		// Token: 0x04000A72 RID: 2674
		public Type type_0;

		// Token: 0x04000A73 RID: 2675
		public Func<Page, bool> func_0;
	}
}
