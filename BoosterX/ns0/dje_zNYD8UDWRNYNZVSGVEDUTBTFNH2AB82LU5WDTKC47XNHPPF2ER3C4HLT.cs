using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007D1 RID: 2001
	public sealed class dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd : Page, IComponentConnector
	{
		// Token: 0x06002914 RID: 10516 RVA: 0x000B07F8 File Offset: 0x000AE9F8
		public dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd()
		{
			this.InitializeComponent();
			base.Loaded += this.dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd_Loaded;
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x000B0868 File Offset: 0x000AEA68
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x000B0870 File Offset: 0x000AEA70
		public void method_1(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x000B087C File Offset: 0x000AEA7C
		private void dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd_Loaded(object sender, RoutedEventArgs p1)
		{
			base.DataContext = this.gclass224_0;
			this.radioButton_0.IsChecked = new bool?(true);
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x000B089C File Offset: 0x000AEA9C
		private void textBox_0_KeyUp(object sender, KeyEventArgs p1)
		{
			this.button_0.IsEnabled = (this.textBox_0.Text != this.method_0());
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x000B08C0 File Offset: 0x000AEAC0
		private void button_0_Click(object sender, RoutedEventArgs p1)
		{
			try
			{
				FileStream fileStream = new FileStream(this.gclass224_0.SelectedProfile.Autoexec.FilePath, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
				try
				{
					StreamWriter streamWriter = new StreamWriter(fileStream);
					try
					{
						streamWriter.Write(this.textBox_0.Text);
					}
					finally
					{
						((IDisposable)streamWriter).Dispose();
					}
				}
				finally
				{
					((IDisposable)fileStream).Dispose();
				}
			}
			catch (object obj)
			{
			}
			this.button_0.IsEnabled = false;
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x000B0950 File Offset: 0x000AEB50
		private Task method_2()
		{
			dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.Struct563 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.Struct563>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x000B0994 File Offset: 0x000AEB94
		private void radioButton_0_Checked(object sender, RoutedEventArgs p1)
		{
			dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.Struct564 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.Struct564>(ref @struct);
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x000B09CC File Offset: 0x000AEBCC
		private void method_3(object sender, RoutedEventArgs p1)
		{
			dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.Struct562 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.Struct562>(ref @struct);
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x000B0A04 File Offset: 0x000AEC04
		private void method_4()
		{
			if (this.list_1.Count == 0)
			{
				this.list_1 = dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.gclass207_0.method_2<List<Class416>>("BoosterX.Resources.Json.CSGOJsons.CsgoRunCvars.json");
			}
			foreach (Class416 class416_ in this.list_1)
			{
				this.list_0.Add(new Class732(class416_));
			}
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x000B0A84 File Offset: 0x000AEC84
		private void method_5()
		{
			if (this.list_3.Count == 0)
			{
				this.list_3 = dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.gclass207_0.method_2<List<Class179>>("BoosterX.Resources.Json.CSGOJsons.CsgoSettingsCvars.json");
			}
			foreach (Class179 class179_ in this.list_3)
			{
				this.list_2.Add(new Class393(class179_));
			}
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x000B0B04 File Offset: 0x000AED04
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/cs2/views/autoexeceditor/autoexeceditor.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x000B0B34 File Offset: 0x000AED34
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.radioButton_0 = (RadioButton)target;
				this.radioButton_0.Checked += this.radioButton_0_Checked;
				return;
			case 2:
				((RadioButton)target).Checked += this.method_3;
				return;
			case 3:
				this.grid_0 = (Grid)target;
				return;
			case 4:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			case 5:
				this.grid_1 = (Grid)target;
				return;
			case 6:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 7:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.KeyUp += this.textBox_0_KeyUp;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x000B0C18 File Offset: 0x000AEE18
		private Task method_6()
		{
			dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.Struct561 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.Struct561>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04001EFF RID: 7935
		private GClass224 gclass224_0 = new GClass224();

		// Token: 0x04001F00 RID: 7936
		private string string_0;

		// Token: 0x04001F01 RID: 7937
		private List<Class732> list_0 = new List<Class732>();

		// Token: 0x04001F02 RID: 7938
		private List<Class416> list_1 = new List<Class416>();

		// Token: 0x04001F03 RID: 7939
		private List<Class393> list_2 = new List<Class393>();

		// Token: 0x04001F04 RID: 7940
		private List<Class179> list_3 = new List<Class179>();

		// Token: 0x04001F05 RID: 7941
		private static GClass207 gclass207_0 = new GClass207();

		// Token: 0x04001F06 RID: 7942
		internal RadioButton radioButton_0;

		// Token: 0x04001F07 RID: 7943
		internal Grid grid_0;

		// Token: 0x04001F08 RID: 7944
		internal ItemsControl itemsControl_0;

		// Token: 0x04001F09 RID: 7945
		internal Grid grid_1;

		// Token: 0x04001F0A RID: 7946
		internal Button button_0;

		// Token: 0x04001F0B RID: 7947
		internal TextBox textBox_0;

		// Token: 0x04001F0C RID: 7948
		private bool bool_0;

		// Token: 0x020007D2 RID: 2002
		[StructLayout(LayoutKind.Auto)]
		private struct Struct561 : IAsyncStateMachine
		{
			// Token: 0x06002923 RID: 10531 RVA: 0x000B0C5C File Offset: 0x000AEE5C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd = this.dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_B1;
					}
					if (num != 1)
					{
						if (dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.grid_0.Visibility != Visibility.Visible)
						{
							goto IL_B8;
						}
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.grid_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.Struct561>(ref awaiter, ref this);
							return;
						}
						goto IL_B1;
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					IL_89:
					awaiter.GetResult();
					goto IL_122;
					IL_B1:
					awaiter.GetResult();
					IL_B8:
					if (dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.grid_1.Visibility == Visibility.Visible)
					{
						awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_11(dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.grid_1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 1;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.Struct561>(ref awaiter, ref this);
							return;
						}
						goto IL_89;
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_122:
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06002924 RID: 10532 RVA: 0x000B0DB0 File Offset: 0x000AEFB0
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F0D RID: 7949
			public int int_0;

			// Token: 0x04001F0E RID: 7950
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04001F0F RID: 7951
			public dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd_0;

			// Token: 0x04001F10 RID: 7952
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007D3 RID: 2003
		[StructLayout(LayoutKind.Auto)]
		private struct Struct562 : IAsyncStateMachine
		{
			// Token: 0x06002925 RID: 10533 RVA: 0x000B0DC0 File Offset: 0x000AEFC0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd = this.dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_9C;
					}
					if (num != 1)
					{
						awaiter = dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.method_2().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.Struct562>(ref awaiter, ref this);
							return;
						}
						goto IL_9C;
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					IL_74:
					awaiter.GetResult();
					goto IL_150;
					IL_9C:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.grid_1);
					dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.button_0.IsEnabled = false;
					try
					{
						dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.method_1(File.ReadAllText(dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.gclass224_0.SelectedProfile.Autoexec.FilePath));
						dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.textBox_0.Text = dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.method_0();
					}
					catch (object obj)
					{
					}
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.grid_1).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.Struct562>(ref awaiter, ref this);
						return;
					}
					goto IL_74;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_150:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002926 RID: 10534 RVA: 0x000B0F64 File Offset: 0x000AF164
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F11 RID: 7953
			public int int_0;

			// Token: 0x04001F12 RID: 7954
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001F13 RID: 7955
			public dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd_0;

			// Token: 0x04001F14 RID: 7956
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007D4 RID: 2004
		[StructLayout(LayoutKind.Auto)]
		private struct Struct563 : IAsyncStateMachine
		{
			// Token: 0x06002927 RID: 10535 RVA: 0x000B0F74 File Offset: 0x000AF174
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd = this.dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd_0;
				try
				{
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.Dispatcher.Invoke<Task>(new Func<Task>(dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.method_6)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.Struct563>(ref awaiter, ref this);
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
					catch (object obj)
					{
					}
					dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.grid_0.Visibility = Visibility.Collapsed;
					dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.grid_1.Visibility = Visibility.Collapsed;
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

			// Token: 0x06002928 RID: 10536 RVA: 0x000B1060 File Offset: 0x000AF260
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F15 RID: 7957
			public int int_0;

			// Token: 0x04001F16 RID: 7958
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04001F17 RID: 7959
			public dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd_0;

			// Token: 0x04001F18 RID: 7960
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007D5 RID: 2005
		[StructLayout(LayoutKind.Auto)]
		private struct Struct564 : IAsyncStateMachine
		{
			// Token: 0x06002929 RID: 10537 RVA: 0x000B1070 File Offset: 0x000AF270
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd = this.dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_9C;
					}
					if (num != 1)
					{
						awaiter = dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.method_2().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.Struct564>(ref awaiter, ref this);
							return;
						}
						goto IL_9C;
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					IL_74:
					awaiter.GetResult();
					goto IL_108;
					IL_9C:
					awaiter.GetResult();
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_27(dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.grid_0);
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_15(dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.grid_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd.Struct564>(ref awaiter, ref this);
						return;
					}
					goto IL_74;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_108:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600292A RID: 10538 RVA: 0x000B11A8 File Offset: 0x000AF3A8
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F19 RID: 7961
			public int int_0;

			// Token: 0x04001F1A RID: 7962
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001F1B RID: 7963
			public dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd dje_zNYD8UDWRNYNZVSGVEDUTBTFNH2AB82LU5WDTKC47XNHPPF2ER3C4HLTNNMK52AYSN2_ejd_0;

			// Token: 0x04001F1C RID: 7964
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
