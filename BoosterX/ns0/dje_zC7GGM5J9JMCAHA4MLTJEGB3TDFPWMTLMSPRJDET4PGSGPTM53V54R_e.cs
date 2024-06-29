using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000762 RID: 1890
	public sealed class dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002713 RID: 10003 RVA: 0x000A3EAC File Offset: 0x000A20AC
		public dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd()
		{
			this.InitializeComponent();
			this.method_0();
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x000A3EC0 File Offset: 0x000A20C0
		private void method_0()
		{
			dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.Struct505 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.Struct505>(ref @struct);
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x000A3EF8 File Offset: 0x000A20F8
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.Struct504 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd_0 = this;
			@struct.object_0 = sender;
			@struct.routedEventArgs_0 = p1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.Struct504>(ref @struct);
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x000A3F40 File Offset: 0x000A2140
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/mainpageucs/tipsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x000A3F70 File Offset: 0x000A2170
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			case 2:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 3:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x000A3FD8 File Offset: 0x000A21D8
		private void method_1(string string_0)
		{
			TextBlock textBlock = this.textBlock_0;
			textBlock.Text += string_0;
		}

		// Token: 0x04001C9C RID: 7324
		private GClass41 gclass41_0;

		// Token: 0x04001C9D RID: 7325
		internal ScrollViewer scrollViewer_0;

		// Token: 0x04001C9E RID: 7326
		internal TextBlock textBlock_0;

		// Token: 0x04001C9F RID: 7327
		internal Button button_0;

		// Token: 0x04001CA0 RID: 7328
		private bool bool_0;

		// Token: 0x02000763 RID: 1891
		[StructLayout(LayoutKind.Auto)]
		private struct Struct504 : IAsyncStateMachine
		{
			// Token: 0x06002719 RID: 10009 RVA: 0x000A3FF4 File Offset: 0x000A21F4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd = this.dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd_0;
				try
				{
					TaskAwaiter<List<string>> awaiter;
					TaskAwaiter<GClass41> awaiter3;
					switch (num)
					{
					case 0:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<string>>);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						break;
					}
					case 1:
					{
						IL_156:
						try
						{
							TaskAwaiter awaiter2;
							if (num != 1)
							{
								awaiter2 = dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.gclass41_0.method_19(new Action<string>(dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.method_1)).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									this.int_0 = 1;
									this.taskAwaiter_1 = awaiter2;
									this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.Struct504>(ref awaiter2, ref this);
									return;
								}
							}
							else
							{
								awaiter2 = this.taskAwaiter_1;
								this.taskAwaiter_1 = default(TaskAwaiter);
								this.int_0 = -1;
							}
							awaiter2.GetResult();
						}
						catch
						{
							this.int_1 = 1;
						}
						int num3 = this.int_1;
						if (num3 != 1)
						{
							dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.button_0.IsEnabled = true;
							goto IL_297;
						}
						awaiter3 = Class176.smethod_0(true).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							this.int_0 = 2;
							this.taskAwaiter_2 = awaiter3;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass41>, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.Struct504>(ref awaiter3, ref this);
							return;
						}
						goto IL_25C;
					}
					case 2:
						awaiter3 = this.taskAwaiter_2;
						this.taskAwaiter_2 = default(TaskAwaiter<GClass41>);
						this.int_0 = -1;
						goto IL_25C;
					default:
					{
						dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.textBlock_0.Text = string.Empty;
						dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.button_0.IsEnabled = false;
						dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.gclass41_0.method_11(Class364.smethod_0("ToolTipGPTBase"));
						dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.gclass41_0.method_9(Class364.smethod_0("ToolTipGPTInput"), Array.Empty<GClass163.GClass164>());
						dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.gclass41_0.method_12(Class364.smethod_0("ToolTipGPTOutput"));
						dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.gclass41_0.method_9(Class364.smethod_0("ToolTipGPTInput"), Array.Empty<GClass163.GClass164>());
						if (Class245.list_0.Count != 0)
						{
							goto IL_125;
						}
						Func<Task<List<string>>> function;
						if ((function = dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.Class822.func_0) == null)
						{
							function = (dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.Class822.func_0 = new Func<Task<List<string>>>(Class245.smethod_1));
						}
						awaiter = Task.Run<List<string>>(function).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<string>>, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.Struct504>(ref awaiter, ref this);
							return;
						}
						break;
					}
					}
					awaiter.GetResult();
					IL_125:
					int index = new Random().Next(84);
					dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.gclass41_0.method_9(Class245.list_0[index], Array.Empty<GClass163.GClass164>());
					this.int_1 = 0;
					goto IL_156;
					IL_25C:
					awaiter3.GetResult();
					dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.button_0_Click(this.object_0, this.routedEventArgs_0);
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_297:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600271A RID: 10010 RVA: 0x000A42E0 File Offset: 0x000A24E0
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001CA1 RID: 7329
			public int int_0;

			// Token: 0x04001CA2 RID: 7330
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001CA3 RID: 7331
			public dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd_0;

			// Token: 0x04001CA4 RID: 7332
			public object object_0;

			// Token: 0x04001CA5 RID: 7333
			public RoutedEventArgs routedEventArgs_0;

			// Token: 0x04001CA6 RID: 7334
			private TaskAwaiter<List<string>> taskAwaiter_0;

			// Token: 0x04001CA7 RID: 7335
			private int int_1;

			// Token: 0x04001CA8 RID: 7336
			private TaskAwaiter taskAwaiter_1;

			// Token: 0x04001CA9 RID: 7337
			private TaskAwaiter<GClass41> taskAwaiter_2;
		}

		// Token: 0x02000764 RID: 1892
		[StructLayout(LayoutKind.Auto)]
		private struct Struct505 : IAsyncStateMachine
		{
			// Token: 0x0600271B RID: 10011 RVA: 0x000A42F0 File Offset: 0x000A24F0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd = this.dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd_0;
				try
				{
					TaskAwaiter<GClass41> awaiter;
					if (num != 0)
					{
						int num2 = new Random().Next(1, 5);
						dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.textBlock_0.Text = Class364.smethod_0(string.Format("Tip{0}", num2));
						dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.gclass41_0 = null;
						awaiter = Class176.smethod_0(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass41>, dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.Struct505>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<GClass41>);
						this.int_0 = -1;
					}
					GClass41 result = awaiter.GetResult();
					dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd.gclass41_0 = result;
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

			// Token: 0x0600271C RID: 10012 RVA: 0x000A43E4 File Offset: 0x000A25E4
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001CAA RID: 7338
			public int int_0;

			// Token: 0x04001CAB RID: 7339
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001CAC RID: 7340
			public dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd dje_zC7GGM5J9JMCAHA4MLTJEGB3TDFPWMTLMSPRJDET4PGSGPTM53V54R_ejd_0;

			// Token: 0x04001CAD RID: 7341
			private TaskAwaiter<GClass41> taskAwaiter_0;
		}

		// Token: 0x02000765 RID: 1893
		private static class Class822
		{
			// Token: 0x04001CAE RID: 7342
			public static Func<Task<List<string>>> func_0;
		}
	}
}
