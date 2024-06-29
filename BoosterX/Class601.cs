using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000511 RID: 1297
internal sealed class Class601
{
	// Token: 0x06001C75 RID: 7285
	[DllImport("Wintrust.dll")]
	private static extern uint WinVerifyTrust(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);

	// Token: 0x06001C76 RID: 7286 RVA: 0x000744CC File Offset: 0x000726CC
	private static uint smethod_0(string string_0)
	{
		object[] object_ = new object[]
		{
			string_0
		};
		return (uint)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebhQ()PsF", object_);
	}

	// Token: 0x06001C77 RID: 7287 RVA: 0x00074504 File Offset: 0x00072704
	public static bool smethod_1(string string_0)
	{
		object[] object_ = new object[]
		{
			string_0
		};
		return (bool)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebhJ()Q<P", object_);
	}

	// Token: 0x06001C78 RID: 7288 RVA: 0x0007453C File Offset: 0x0007273C
	public static bool smethod_2(string string_0)
	{
		object[] object_ = new object[]
		{
			string_0
		};
		return (bool)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebi1()Q<P", object_);
	}

	// Token: 0x06001C79 RID: 7289 RVA: 0x00074574 File Offset: 0x00072774
	public static void smethod_3()
	{
		Class555.smethod_0().method_4(Class555.smethod_2(), "&ebh=()QES", null);
	}

	// Token: 0x06001C7A RID: 7290 RVA: 0x0007458C File Offset: 0x0007278C
	private static void smethod_4(ref Class601.Struct292 struct292_0)
	{
		struct292_0.asyncVoidMethodBuilder_0.Start<Class601.Struct292>(ref struct292_0);
	}

	// Token: 0x02000512 RID: 1298
	[Serializable]
	private sealed class Class602
	{
		// Token: 0x06001C7D RID: 7293 RVA: 0x000745B0 File Offset: 0x000727B0
		internal void method_0()
		{
			string fileName = Process.GetCurrentProcess().MainModule.FileName;
			if (!Class601.smethod_1(fileName) && !Class601.smethod_2(fileName))
			{
				Class585.struct13_0.method_1(false);
				Class585.smethod_7();
			}
		}

		// Token: 0x040013EF RID: 5103
		public static readonly Class601.Class602 class602_0 = new Class601.Class602();

		// Token: 0x040013F0 RID: 5104
		public static Action action_0;
	}

	// Token: 0x02000513 RID: 1299
	[StructLayout(LayoutKind.Auto)]
	private struct Struct292 : IAsyncStateMachine
	{
		// Token: 0x06001C7E RID: 7294 RVA: 0x000745F0 File Offset: 0x000727F0
		void IAsyncStateMachine.MoveNext()
		{
			object[] array = new object[]
			{
				this
			};
			Class27 @class = Class555.smethod_0();
			Stream stream_ = Class555.smethod_2();
			try
			{
				@class.method_4(stream_, "&ebiF()Q0L", array);
			}
			finally
			{
				this = (Class601.Struct292)array[0];
			}
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x00074658 File Offset: 0x00072858
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x00074668 File Offset: 0x00072868
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class601.Struct292 struct292_0)
		{
			struct292_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class601.Struct292>(ref taskAwaiter_1, ref struct292_0);
		}

		// Token: 0x040013F1 RID: 5105
		public int int_0;

		// Token: 0x040013F2 RID: 5106
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040013F3 RID: 5107
		private TaskAwaiter taskAwaiter_0;
	}
}
