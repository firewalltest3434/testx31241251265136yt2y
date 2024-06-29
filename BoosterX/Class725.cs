using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Newtonsoft.Json;
using ns0;

// Token: 0x02000288 RID: 648
internal sealed class Class725 : GClass211
{
	// Token: 0x06000F07 RID: 3847 RVA: 0x00040040 File Offset: 0x0003E240
	public Class725(GClass112 gclass112_1, Class755 class755_1 = null)
	{
		this.gclass112_0 = gclass112_1;
		this.class755_0 = class755_1;
		if (class755_1 == null)
		{
			this.DeleteVisibility = Visibility.Collapsed;
		}
	}

	// Token: 0x170001C7 RID: 455
	// (get) Token: 0x06000F08 RID: 3848 RVA: 0x00040078 File Offset: 0x0003E278
	// (set) Token: 0x06000F09 RID: 3849 RVA: 0x00040080 File Offset: 0x0003E280
	public Visibility DeleteVisibility
	{
		get
		{
			return this.visibility_0;
		}
		set
		{
			this.visibility_0 = value;
			base.method_0("DeleteVisibility");
		}
	}

	// Token: 0x170001C8 RID: 456
	// (get) Token: 0x06000F0A RID: 3850 RVA: 0x00040094 File Offset: 0x0003E294
	// (set) Token: 0x06000F0B RID: 3851 RVA: 0x0004009C File Offset: 0x0003E29C
	public string StatusText
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x170001C9 RID: 457
	// (get) Token: 0x06000F0C RID: 3852 RVA: 0x000400B0 File Offset: 0x0003E2B0
	// (set) Token: 0x06000F0D RID: 3853 RVA: 0x000400B8 File Offset: 0x0003E2B8
	public SolidColorBrush StatusColor
	{
		get
		{
			return this.solidColorBrush_0;
		}
		set
		{
			this.solidColorBrush_0 = value;
			base.method_0("StatusColor");
		}
	}

	// Token: 0x170001CA RID: 458
	// (get) Token: 0x06000F0E RID: 3854 RVA: 0x000400CC File Offset: 0x0003E2CC
	// (set) Token: 0x06000F0F RID: 3855 RVA: 0x000400D4 File Offset: 0x0003E2D4
	public double StatusOpacity
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
			base.method_0("StatusOpacity");
		}
	}

	// Token: 0x06000F10 RID: 3856 RVA: 0x000400E8 File Offset: 0x0003E2E8
	private void method_1(string string_1, SolidColorBrush solidColorBrush_1)
	{
		Class725.Struct134 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class725_0 = this;
		@struct.string_0 = string_1;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class725.Struct134>(ref @struct);
	}

	// Token: 0x170001CB RID: 459
	// (get) Token: 0x06000F11 RID: 3857 RVA: 0x00040130 File Offset: 0x0003E330
	public string Name
	{
		get
		{
			return this.gclass112_0.Name;
		}
	}

	// Token: 0x170001CC RID: 460
	// (get) Token: 0x06000F12 RID: 3858 RVA: 0x00040140 File Offset: 0x0003E340
	public string DateCreated
	{
		get
		{
			return this.gclass112_0.CreationDate.ToLocalTime().ToString("dd.MM.yyyy HH:mm");
		}
	}

	// Token: 0x170001CD RID: 461
	// (get) Token: 0x06000F13 RID: 3859 RVA: 0x00040170 File Offset: 0x0003E370
	public GClass134 Delete
	{
		get
		{
			if (this.bool_0)
			{
				return null;
			}
			return new GClass134(new Action<object>(this.method_2), null);
		}
	}

	// Token: 0x170001CE RID: 462
	// (get) Token: 0x06000F14 RID: 3860 RVA: 0x00040190 File Offset: 0x0003E390
	public GClass134 Download
	{
		get
		{
			if (this.bool_0)
			{
				return null;
			}
			return new GClass134(new Action<object>(this.method_4), null);
		}
	}

	// Token: 0x06000F15 RID: 3861 RVA: 0x000401B0 File Offset: 0x0003E3B0
	private void method_2(object object_0)
	{
		Class725.Struct133 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class725_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class725.Struct133>(ref @struct);
	}

	// Token: 0x06000F16 RID: 3862 RVA: 0x000401E8 File Offset: 0x0003E3E8
	private Task method_3()
	{
		Class725.Struct131 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class725_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class725.Struct131>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000F17 RID: 3863 RVA: 0x0004022C File Offset: 0x0003E42C
	private void method_4(object object_0)
	{
		Class725.Struct132 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class725_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class725.Struct132>(ref @struct);
	}

	// Token: 0x06000F18 RID: 3864 RVA: 0x00040264 File Offset: 0x0003E464
	private Task method_5()
	{
		Class725.Struct135 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class725_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class725.Struct135>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0400091E RID: 2334
	private Class755 class755_0;

	// Token: 0x0400091F RID: 2335
	private GClass112 gclass112_0;

	// Token: 0x04000920 RID: 2336
	private Visibility visibility_0;

	// Token: 0x04000921 RID: 2337
	private string string_0 = string.Empty;

	// Token: 0x04000922 RID: 2338
	private SolidColorBrush solidColorBrush_0 = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd;

	// Token: 0x04000923 RID: 2339
	private double double_0;

	// Token: 0x04000924 RID: 2340
	private bool bool_0;

	// Token: 0x02000289 RID: 649
	[StructLayout(LayoutKind.Auto)]
	private struct Struct131 : IAsyncStateMachine
	{
		// Token: 0x06000F19 RID: 3865 RVA: 0x000402A8 File Offset: 0x0003E4A8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class725 @class = this.class725_0;
			try
			{
				TaskAwaiter<Class289> awaiter;
				TaskAwaiter awaiter2;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Class289>);
					this.int_0 = -1;
					break;
				case 1:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_174;
				case 2:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_1A9;
				default:
					@class.method_1(Class364.smethod_0("Deleting"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
					awaiter = Class166.smethod_1(Class193.uri_13, @class.gclass112_0.Id).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class289>, Class725.Struct131>(ref awaiter, ref this);
						return;
					}
					break;
				}
				Class289 result = awaiter.GetResult();
				if (!result.Success)
				{
					@class.method_1(result.Message, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
					awaiter2 = Task.Delay(1500).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class725.Struct131>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					@class.class755_0.method_2();
					@class.method_1(result.Message, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
					awaiter2 = Task.Delay(1500).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class725.Struct131>(ref awaiter2, ref this);
						return;
					}
					goto IL_1A9;
				}
				IL_174:
				awaiter2.GetResult();
				@class.method_1(string.Empty, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				goto IL_1E0;
				IL_1A9:
				awaiter2.GetResult();
				@class.method_1(Class364.smethod_0("storexins7"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1E0:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x000404C4 File Offset: 0x0003E6C4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000925 RID: 2341
		public int int_0;

		// Token: 0x04000926 RID: 2342
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000927 RID: 2343
		public Class725 class725_0;

		// Token: 0x04000928 RID: 2344
		private TaskAwaiter<Class289> taskAwaiter_0;

		// Token: 0x04000929 RID: 2345
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x0200028A RID: 650
	[StructLayout(LayoutKind.Auto)]
	private struct Struct132 : IAsyncStateMachine
	{
		// Token: 0x06000F1B RID: 3867 RVA: 0x000404D4 File Offset: 0x0003E6D4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class725 @class = this.class725_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.bool_0 = true;
					awaiter = Task.Run(new Func<Task>(@class.method_5)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class725.Struct132>(ref awaiter, ref this);
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
				@class.bool_0 = false;
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

		// Token: 0x06000F1C RID: 3868 RVA: 0x000405A0 File Offset: 0x0003E7A0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400092A RID: 2346
		public int int_0;

		// Token: 0x0400092B RID: 2347
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400092C RID: 2348
		public Class725 class725_0;

		// Token: 0x0400092D RID: 2349
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200028B RID: 651
	[StructLayout(LayoutKind.Auto)]
	private struct Struct133 : IAsyncStateMachine
	{
		// Token: 0x06000F1D RID: 3869 RVA: 0x000405B0 File Offset: 0x0003E7B0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class725 @class = this.class725_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.bool_0 = true;
					awaiter = Task.Run(new Func<Task>(@class.method_3)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class725.Struct133>(ref awaiter, ref this);
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
				@class.bool_0 = false;
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

		// Token: 0x06000F1E RID: 3870 RVA: 0x0004067C File Offset: 0x0003E87C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400092E RID: 2350
		public int int_0;

		// Token: 0x0400092F RID: 2351
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000930 RID: 2352
		public Class725 class725_0;

		// Token: 0x04000931 RID: 2353
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200028C RID: 652
	[StructLayout(LayoutKind.Auto)]
	private struct Struct134 : IAsyncStateMachine
	{
		// Token: 0x06000F1F RID: 3871 RVA: 0x0004068C File Offset: 0x0003E88C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class725 @class = this.class725_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_E2;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_140;
				}
				IL_1D:
				if (@class.StatusOpacity == 0.0)
				{
					@class.StatusColor = this.solidColorBrush_0;
					@class.StatusText = this.string_0;
					goto IL_147;
				}
				@class.StatusOpacity -= 0.1;
				if (@class.StatusOpacity < 0.05)
				{
					@class.StatusOpacity = 0.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class725.Struct134>(ref awaiter, ref this);
					return;
				}
				IL_E2:
				awaiter.GetResult();
				goto IL_1D;
				IL_140:
				awaiter.GetResult();
				IL_147:
				if (@class.StatusOpacity != 1.0)
				{
					@class.StatusOpacity += 0.13333333333333333;
					if (@class.StatusOpacity > 0.95)
					{
						@class.StatusOpacity = 1.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_140;
					}
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class725.Struct134>(ref awaiter, ref this);
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

		// Token: 0x06000F20 RID: 3872 RVA: 0x00040888 File Offset: 0x0003EA88
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000932 RID: 2354
		public int int_0;

		// Token: 0x04000933 RID: 2355
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000934 RID: 2356
		public Class725 class725_0;

		// Token: 0x04000935 RID: 2357
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04000936 RID: 2358
		public string string_0;

		// Token: 0x04000937 RID: 2359
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200028D RID: 653
	[StructLayout(LayoutKind.Auto)]
	private struct Struct135 : IAsyncStateMachine
	{
		// Token: 0x06000F21 RID: 3873 RVA: 0x00040898 File Offset: 0x0003EA98
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class725 @class = this.class725_0;
			try
			{
				TaskAwaiter<Class289> awaiter;
				TaskAwaiter awaiter2;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Class289>);
					this.int_0 = -1;
					break;
				case 1:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_29A;
				case 2:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_2D2;
				case 3:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_30A;
				case 4:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_33F;
				default:
					@class.method_1(Class364.smethod_0("Downloading"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
					awaiter = Class166.smethod_1(Class193.uri_11, @class.gclass112_0.Id).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class289>, Class725.Struct135>(ref awaiter, ref this);
						return;
					}
					break;
				}
				Class289 result = awaiter.GetResult();
				if (!result.Success)
				{
					@class.method_1(result.Message, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
					awaiter2 = Task.Delay(1500).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class725.Struct135>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					string path = Path.Combine(Class186.string_6, @class.gclass112_0.Name + ".buxz");
					if (File.Exists(path))
					{
						@class.method_1(Class364.smethod_0("FileExists"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
						awaiter2 = Task.Delay(1500).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.int_0 = 2;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class725.Struct135>(ref awaiter2, ref this);
							return;
						}
						goto IL_2D2;
					}
					else
					{
						int num2 = 0;
						try
						{
							Class146 class2 = JsonConvert.DeserializeObject<Class146>(result.Message);
							File.WriteAllBytes(path, class2.Data);
						}
						catch (Exception obj)
						{
							num2 = 1;
						}
						if (num2 == 1)
						{
							object obj;
							GClass141.smethod_1(((Exception)obj).Message);
							@class.method_1(Class364.smethod_0("unknownerror"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
							awaiter2 = Task.Delay(1500).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								this.int_0 = 3;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class725.Struct135>(ref awaiter2, ref this);
								return;
							}
							goto IL_30A;
						}
						else
						{
							if (@class.class755_0 != null)
							{
								@class.class755_0.method_1();
							}
							@class.method_1(Class364.smethod_0("storexins7"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
							awaiter2 = Task.Delay(1500).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								this.int_0 = 4;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class725.Struct135>(ref awaiter2, ref this);
								return;
							}
							goto IL_33F;
						}
					}
				}
				IL_29A:
				awaiter2.GetResult();
				@class.method_1(string.Empty, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				goto IL_371;
				IL_2D2:
				awaiter2.GetResult();
				@class.method_1(string.Empty, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				goto IL_371;
				IL_30A:
				awaiter2.GetResult();
				@class.method_1(string.Empty, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				goto IL_371;
				IL_33F:
				awaiter2.GetResult();
				@class.method_1(string.Empty, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_371:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x00040C60 File Offset: 0x0003EE60
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000938 RID: 2360
		public int int_0;

		// Token: 0x04000939 RID: 2361
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400093A RID: 2362
		public Class725 class725_0;

		// Token: 0x0400093B RID: 2363
		private TaskAwaiter<Class289> taskAwaiter_0;

		// Token: 0x0400093C RID: 2364
		private TaskAwaiter taskAwaiter_1;
	}
}
