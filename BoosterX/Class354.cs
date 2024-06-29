using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x020002CB RID: 715
internal sealed class Class354
{
	// Token: 0x06001090 RID: 4240 RVA: 0x00046008 File Offset: 0x00044208
	public static void smethod_0()
	{
		Class354.Struct145 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class354.Struct145>(ref @struct);
	}

	// Token: 0x020002CC RID: 716
	[StructLayout(LayoutKind.Auto)]
	private struct Struct145 : IAsyncStateMachine
	{
		// Token: 0x06001091 RID: 4241 RVA: 0x00046038 File Offset: 0x00044238
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class354.Class355.class355_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class354.Struct145>(ref awaiter, ref this);
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

		// Token: 0x06001092 RID: 4242 RVA: 0x00046104 File Offset: 0x00044304
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040009E8 RID: 2536
		public int int_0;

		// Token: 0x040009E9 RID: 2537
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040009EA RID: 2538
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002CD RID: 717
	[Serializable]
	private sealed class Class355
	{
		// Token: 0x06001095 RID: 4245 RVA: 0x00046128 File Offset: 0x00044328
		internal void method_0()
		{
			Class185.smethod_24("sc stop R0BoosterX_2_0");
			Class185.smethod_24("sc delete R0BoosterX_2_0");
			Class185.smethod_24("sc stop inpoutx64");
			Class185.smethod_24("sc delete inpoutx64");
			Directory.GetFiles(Class186.string_4).ToList<string>().ForEach(new Action<string>(Class354.Class355.class355_0.method_1));
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00046190 File Offset: 0x00044390
		internal void method_1(string string_0)
		{
			try
			{
				File.Delete(string_0);
			}
			catch (object obj)
			{
			}
		}

		// Token: 0x040009EB RID: 2539
		public static readonly Class354.Class355 class355_0 = new Class354.Class355();

		// Token: 0x040009EC RID: 2540
		public static Action<string> action_0;

		// Token: 0x040009ED RID: 2541
		public static Action action_1;
	}
}
