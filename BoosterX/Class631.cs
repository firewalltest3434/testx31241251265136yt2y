using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;
using Linearstar.Windows.RawInput;
using Linearstar.Windows.RawInput.Native;
using ns0;

// Token: 0x0200057B RID: 1403
internal sealed class Class631
{
	// Token: 0x06001E72 RID: 7794 RVA: 0x0007F1A0 File Offset: 0x0007D3A0
	public static void smethod_0(Class631.Delegate31 delegate31_1)
	{
		Class631.Delegate31 @delegate = Class631.delegate31_0;
		Class631.Delegate31 delegate2;
		do
		{
			delegate2 = @delegate;
			Class631.Delegate31 value = (Class631.Delegate31)Delegate.Combine(delegate2, delegate31_1);
			@delegate = Interlocked.CompareExchange<Class631.Delegate31>(ref Class631.delegate31_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06001E73 RID: 7795 RVA: 0x0007F1D4 File Offset: 0x0007D3D4
	public static void smethod_1(Class631.Delegate31 delegate31_1)
	{
		Class631.Delegate31 @delegate = Class631.delegate31_0;
		Class631.Delegate31 delegate2;
		do
		{
			delegate2 = @delegate;
			Class631.Delegate31 value = (Class631.Delegate31)Delegate.Remove(delegate2, delegate31_1);
			@delegate = Interlocked.CompareExchange<Class631.Delegate31>(ref Class631.delegate31_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06001E74 RID: 7796 RVA: 0x0007F208 File Offset: 0x0007D408
	public static void smethod_2(Class631.Delegate32 delegate32_1)
	{
		Class631.Delegate32 @delegate = Class631.delegate32_0;
		Class631.Delegate32 delegate2;
		do
		{
			delegate2 = @delegate;
			Class631.Delegate32 value = (Class631.Delegate32)Delegate.Combine(delegate2, delegate32_1);
			@delegate = Interlocked.CompareExchange<Class631.Delegate32>(ref Class631.delegate32_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06001E75 RID: 7797 RVA: 0x0007F23C File Offset: 0x0007D43C
	public static void smethod_3(Class631.Delegate32 delegate32_1)
	{
		Class631.Delegate32 @delegate = Class631.delegate32_0;
		Class631.Delegate32 delegate2;
		do
		{
			delegate2 = @delegate;
			Class631.Delegate32 value = (Class631.Delegate32)Delegate.Remove(delegate2, delegate32_1);
			@delegate = Interlocked.CompareExchange<Class631.Delegate32>(ref Class631.delegate32_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06001E76 RID: 7798 RVA: 0x0007F270 File Offset: 0x0007D470
	public static void smethod_4()
	{
		Class631.Struct334 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class631.Struct334>(ref @struct);
	}

	// Token: 0x06001E77 RID: 7799 RVA: 0x0007F2A0 File Offset: 0x0007D4A0
	public static void smethod_5()
	{
		Class631.Struct333 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class631.Struct333>(ref @struct);
	}

	// Token: 0x06001E78 RID: 7800 RVA: 0x0007F2D0 File Offset: 0x0007D4D0
	private void method_0(object sender, EventArgs p1)
	{
		IntPtr handle = new WindowInteropHelper(Class358.smethod_0().method_5(typeof(dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd))).Handle;
		RawInputDevice.GetDevices();
		RawInputDevice.RegisterDevice(HidUsageAndPage.Mouse, 4144, handle);
		HwndSource hwndSource = HwndSource.FromHwnd(handle);
		HwndSourceHook hook;
		if ((hook = Class631.Class634.hwndSourceHook_0) == null)
		{
			hook = (Class631.Class634.hwndSourceHook_0 = new HwndSourceHook(Class631.smethod_6));
		}
		hwndSource.AddHook(hook);
	}

	// Token: 0x06001E79 RID: 7801 RVA: 0x0007F338 File Offset: 0x0007D538
	private static IntPtr smethod_6(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2, ref bool bool_1)
	{
		if (int_0 == 255)
		{
			RawInputData rawInputData = RawInputData.FromHandle(intptr_2);
			RawInputMouseData rawInputMouseData = rawInputData as RawInputMouseData;
			if (rawInputMouseData == null)
			{
				RawInputKeyboardData rawInputKeyboardData = rawInputData as RawInputKeyboardData;
				if (rawInputKeyboardData != null)
				{
					Class631.smethod_8(rawInputKeyboardData.Keyboard);
				}
			}
			else
			{
				Class631.smethod_7(rawInputMouseData.Mouse);
			}
		}
		return IntPtr.Zero;
	}

	// Token: 0x06001E7A RID: 7802 RVA: 0x0007F388 File Offset: 0x0007D588
	private static void smethod_7(RawMouse rawMouse_0)
	{
		if (rawMouse_0.Buttons == 1)
		{
			Class631.Delegate31 @delegate = Class631.delegate31_0;
			if (@delegate == null)
			{
				return;
			}
			@delegate();
		}
	}

	// Token: 0x06001E7B RID: 7803 RVA: 0x0007F3A4 File Offset: 0x0007D5A4
	private static void smethod_8(RawKeyboard rawKeyboard_0)
	{
		Class631.Delegate32 @delegate = Class631.delegate32_0;
		if (@delegate == null)
		{
			return;
		}
		@delegate(rawKeyboard_0);
	}

	// Token: 0x04001575 RID: 5493
	private static Class631.Delegate31 delegate31_0;

	// Token: 0x04001576 RID: 5494
	private static Class631.Delegate32 delegate32_0;

	// Token: 0x04001577 RID: 5495
	private static bool bool_0;

	// Token: 0x0200057C RID: 1404
	// (Invoke) Token: 0x06001E7D RID: 7805
	public delegate void Delegate31();

	// Token: 0x0200057D RID: 1405
	private sealed class Class632
	{
		// Token: 0x06001E81 RID: 7809 RVA: 0x0007F3C0 File Offset: 0x0007D5C0
		internal void method_0()
		{
			this.intptr_0 = this.windowInteropHelper_0.Handle;
		}

		// Token: 0x04001578 RID: 5496
		public IntPtr intptr_0;

		// Token: 0x04001579 RID: 5497
		public WindowInteropHelper windowInteropHelper_0;
	}

	// Token: 0x0200057E RID: 1406
	private sealed class Class633
	{
		// Token: 0x06001E83 RID: 7811 RVA: 0x0007F3DC File Offset: 0x0007D5DC
		internal void method_0()
		{
			this.intptr_0 = this.windowInteropHelper_0.Handle;
		}

		// Token: 0x0400157A RID: 5498
		public IntPtr intptr_0;

		// Token: 0x0400157B RID: 5499
		public WindowInteropHelper windowInteropHelper_0;
	}

	// Token: 0x0200057F RID: 1407
	[StructLayout(LayoutKind.Auto)]
	private struct Struct333 : IAsyncStateMachine
	{
		// Token: 0x06001E84 RID: 7812 RVA: 0x0007F3F0 File Offset: 0x0007D5F0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class631.Class635.class635_0.method_1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class631.Struct333>(ref awaiter, ref this);
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

		// Token: 0x06001E85 RID: 7813 RVA: 0x0007F4BC File Offset: 0x0007D6BC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400157C RID: 5500
		public int int_0;

		// Token: 0x0400157D RID: 5501
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400157E RID: 5502
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000580 RID: 1408
	private static class Class634
	{
		// Token: 0x0400157F RID: 5503
		public static HwndSourceHook hwndSourceHook_0;
	}

	// Token: 0x02000581 RID: 1409
	[Serializable]
	private sealed class Class635
	{
		// Token: 0x06001E88 RID: 7816 RVA: 0x0007F4E0 File Offset: 0x0007D6E0
		internal void method_0()
		{
			Class631.Class633 @class = new Class631.Class633();
			if (Class631.bool_0)
			{
				return;
			}
			Class631.bool_0 = true;
			@class.windowInteropHelper_0 = new WindowInteropHelper(Class358.smethod_0().method_5(typeof(dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd)));
			@class.intptr_0 = IntPtr.Zero;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
			RawInputDevice.GetDevices();
			RawInputDevice.RegisterDevice(HidUsageAndPage.Mouse, 304, @class.intptr_0);
			RawInputDevice.RegisterDevice(HidUsageAndPage.Keyboard, 304, @class.intptr_0);
			HwndSource hwndSource = HwndSource.FromHwnd(@class.intptr_0);
			HwndSourceHook hook;
			if ((hook = Class631.Class634.hwndSourceHook_0) == null)
			{
				hook = (Class631.Class634.hwndSourceHook_0 = new HwndSourceHook(Class631.smethod_6));
			}
			hwndSource.AddHook(hook);
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x0007F5A4 File Offset: 0x0007D7A4
		internal void method_1()
		{
			Class631.bool_0 = false;
			try
			{
				Class631.Class632 @class = new Class631.Class632();
				@class.windowInteropHelper_0 = new WindowInteropHelper(Class358.smethod_0().method_5(typeof(dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd)));
				@class.intptr_0 = IntPtr.Zero;
				Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
				RawInputDevice.UnregisterDevice(HidUsageAndPage.Mouse);
				RawInputDevice.UnregisterDevice(HidUsageAndPage.Keyboard);
				HwndSource hwndSource = HwndSource.FromHwnd(@class.intptr_0);
				HwndSourceHook hook;
				if ((hook = Class631.Class634.hwndSourceHook_0) == null)
				{
					hook = (Class631.Class634.hwndSourceHook_0 = new HwndSourceHook(Class631.smethod_6));
				}
				hwndSource.RemoveHook(hook);
			}
			catch (object obj)
			{
			}
		}

		// Token: 0x04001580 RID: 5504
		public static readonly Class631.Class635 class635_0 = new Class631.Class635();

		// Token: 0x04001581 RID: 5505
		public static Action action_0;

		// Token: 0x04001582 RID: 5506
		public static Action action_1;
	}

	// Token: 0x02000582 RID: 1410
	// (Invoke) Token: 0x06001E8B RID: 7819
	public delegate void Delegate32(RawKeyboard rawKeyboard_0);

	// Token: 0x02000583 RID: 1411
	[StructLayout(LayoutKind.Auto)]
	private struct Struct334 : IAsyncStateMachine
	{
		// Token: 0x06001E8E RID: 7822 RVA: 0x0007F658 File Offset: 0x0007D858
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class631.Class635.class635_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class631.Struct334>(ref awaiter, ref this);
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

		// Token: 0x06001E8F RID: 7823 RVA: 0x0007F724 File Offset: 0x0007D924
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001583 RID: 5507
		public int int_0;

		// Token: 0x04001584 RID: 5508
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001585 RID: 5509
		private TaskAwaiter taskAwaiter_0;
	}
}
