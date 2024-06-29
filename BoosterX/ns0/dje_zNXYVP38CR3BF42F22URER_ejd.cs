using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace ns0
{
	// Token: 0x020007CF RID: 1999
	public sealed class dje_zNXYVP38CR3BF42F22URER_ejd : Application
	{
		// Token: 0x06002909 RID: 10505 RVA: 0x000B041C File Offset: 0x000AE61C
		public dje_zNXYVP38CR3BF42F22URER_ejd()
		{
			AppDomain.CurrentDomain.ProcessExit += this.method_1;
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x000B043C File Offset: 0x000AE63C
		private void dje_zNXYVP38CR3BF42F22URER_ejd_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs p1)
		{
			GClass141.smethod_0(p1.Exception);
			bool? flag = Class389.class504_0.method_48();
			if (flag.GetValueOrDefault() & flag != null)
			{
				MessageBox.Show(p1.Exception.Message + "\n" + p1.Exception.StackTrace, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Exclamation);
			}
			p1.Handled = true;
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x000B04A8 File Offset: 0x000AE6A8
		private void dje_zNXYVP38CR3BF42F22URER_ejd_Startup(object sender, StartupEventArgs p1)
		{
			dje_zNXYVP38CR3BF42F22URER_ejd.Struct560 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zNXYVP38CR3BF42F22URER_ejd_0 = this;
			@struct.startupEventArgs_0 = p1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zNXYVP38CR3BF42F22URER_ejd.Struct560>(ref @struct);
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x000B04E8 File Offset: 0x000AE6E8
		private void method_0()
		{
			this.class292_0 = Class292.smethod_0();
			this.class292_0.method_2();
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x000B0500 File Offset: 0x000AE700
		private void dje_zNXYVP38CR3BF42F22URER_ejd_SessionEnding(object sender, SessionEndingCancelEventArgs p1)
		{
			if (this.window_0 != null)
			{
				(this.window_0 as dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd).button_2_Click(null, null);
			}
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x000B051C File Offset: 0x000AE71C
		private void dje_zNXYVP38CR3BF42F22URER_ejd_Exit(object sender, ExitEventArgs p1)
		{
			this.dje_zNXYVP38CR3BF42F22URER_ejd_SessionEnding(null, null);
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x000B0528 File Offset: 0x000AE728
		private void method_1(object sender, EventArgs p1)
		{
			this.dje_zNXYVP38CR3BF42F22URER_ejd_SessionEnding(null, null);
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x000B0534 File Offset: 0x000AE734
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void method_2()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			base.DispatcherUnhandledException += this.dje_zNXYVP38CR3BF42F22URER_ejd_DispatcherUnhandledException;
			base.Exit += this.dje_zNXYVP38CR3BF42F22URER_ejd_Exit;
			base.SessionEnding += this.dje_zNXYVP38CR3BF42F22URER_ejd_SessionEnding;
			base.Startup += this.dje_zNXYVP38CR3BF42F22URER_ejd_Startup;
			Uri resourceLocator = new Uri("/BoosterX;component/app.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x000B05AC File Offset: 0x000AE7AC
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[STAThread]
		public static void smethod_0()
		{
			dje_zNXYVP38CR3BF42F22URER_ejd dje_zNXYVP38CR3BF42F22URER_ejd = new dje_zNXYVP38CR3BF42F22URER_ejd();
			dje_zNXYVP38CR3BF42F22URER_ejd.method_2();
			dje_zNXYVP38CR3BF42F22URER_ejd.Run();
		}

		// Token: 0x04001EF7 RID: 7927
		private Window window_0;

		// Token: 0x04001EF8 RID: 7928
		private Class292 class292_0;

		// Token: 0x04001EF9 RID: 7929
		private bool bool_0;

		// Token: 0x020007D0 RID: 2000
		[StructLayout(LayoutKind.Auto)]
		private struct Struct560 : IAsyncStateMachine
		{
			// Token: 0x06002912 RID: 10514 RVA: 0x000B05C0 File Offset: 0x000AE7C0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zNXYVP38CR3BF42F22URER_ejd dje_zNXYVP38CR3BF42F22URER_ejd = this.dje_zNXYVP38CR3BF42F22URER_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						dje_zNXYVP38CR3BF42F22URER_ejd.method_0();
						string fileName = Process.GetCurrentProcess().MainModule.FileName;
						if (!Class572.smethod_1(fileName) && !Class572.smethod_2(fileName))
						{
							Application.Current.Shutdown();
							Environment.Exit(0);
							Process.GetCurrentProcess().Kill();
							goto IL_1E9;
						}
						bool? flag = Class389.class504_0.method_56();
						if (!(flag.GetValueOrDefault() & flag != null))
						{
							dje_zNXYVP38CR3BF42F22URER_ejd.window_0 = new dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd(null);
							dje_zNXYVP38CR3BF42F22URER_ejd.window_0.Show();
							goto IL_1E9;
						}
						dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.smethod_4();
						if (this.startupEventArgs_0.Args.Length == 0)
						{
							new dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd(null).Show();
							goto IL_1E9;
						}
						if (this.startupEventArgs_0.Args[0].ToLower() == "-gamemodex")
						{
							dje_zNXYVP38CR3BF42F22URER_ejd.window_0 = new dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd(typeof(dje_zCV7WQQTQ2B6GRWUB4EXSGWENM3R826Y7L9EAD6NPD84F7RBCWT5FE_ejd));
							dje_zNXYVP38CR3BF42F22URER_ejd.window_0.Show();
							goto IL_1E9;
						}
						if (!(this.startupEventArgs_0.Args[0] == "-DisableAV"))
						{
							Class400.smethod_0(this.startupEventArgs_0.Args[0]);
							Application.Current.Shutdown();
							goto IL_1E9;
						}
						awaiter = Task.Delay(5000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zNXYVP38CR3BF42F22URER_ejd.Struct560>(ref awaiter, ref this);
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
					Class185.smethod_22("schtasks /Delete /TN \"BoosterXStartupTask\" /F");
					Class389.class504_0.method_21(new bool?(true));
					dje_zNXYVP38CR3BF42F22URER_ejd.window_0 = new dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd(typeof(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd));
					dje_zNXYVP38CR3BF42F22URER_ejd.window_0.Show();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_1E9:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002913 RID: 10515 RVA: 0x000B07E8 File Offset: 0x000AE9E8
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001EFA RID: 7930
			public int int_0;

			// Token: 0x04001EFB RID: 7931
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001EFC RID: 7932
			public dje_zNXYVP38CR3BF42F22URER_ejd dje_zNXYVP38CR3BF42F22URER_ejd_0;

			// Token: 0x04001EFD RID: 7933
			public StartupEventArgs startupEventArgs_0;

			// Token: 0x04001EFE RID: 7934
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
