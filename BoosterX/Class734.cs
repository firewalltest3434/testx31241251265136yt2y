using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ns0;

// Token: 0x02000326 RID: 806
internal sealed class Class734 : GClass211
{
	// Token: 0x0600124A RID: 4682 RVA: 0x0004B96C File Offset: 0x00049B6C
	public Class734(string string_3, Class755 class755_1)
	{
		this.class755_0 = class755_1;
		this.method_1(string_3);
	}

	// Token: 0x0600124B RID: 4683 RVA: 0x0004B998 File Offset: 0x00049B98
	private void method_1(string string_3)
	{
		this.string_0 = string_3;
		this.Name = Path.GetFileNameWithoutExtension(string_3);
		FileStream fileStream = new FileStream(string_3, FileMode.Open);
		ZipArchive zipArchive = new ZipArchive(fileStream, ZipArchiveMode.Read);
		Dictionary<string, byte[]> dictionary = new Dictionary<string, byte[]>();
		foreach (ZipArchiveEntry zipArchiveEntry in zipArchive.Entries)
		{
			MemoryStream memoryStream = new MemoryStream();
			try
			{
				using (Stream stream = zipArchiveEntry.Open())
				{
					stream.CopyTo(memoryStream);
				}
				byte[] value = memoryStream.ToArray();
				dictionary[zipArchiveEntry.Name] = value;
			}
			finally
			{
				((IDisposable)memoryStream).Dispose();
			}
		}
		foreach (KeyValuePair<string, byte[]> keyValuePair in dictionary)
		{
			if (keyValuePair.Key == "BOOSTER.bux")
			{
				this.class660_0 = Class482.smethod_1(keyValuePair.Value);
			}
			if (keyValuePair.Key == "NVIDIA.nvx")
			{
				this.byte_0 = keyValuePair.Value;
			}
		}
		zipArchive.Dispose();
		fileStream.Dispose();
		base.method_0("Name");
		base.method_0("DateCreated");
	}

	// Token: 0x17000244 RID: 580
	// (get) Token: 0x0600124C RID: 4684 RVA: 0x0004BB28 File Offset: 0x00049D28
	// (set) Token: 0x0600124D RID: 4685 RVA: 0x0004BB30 File Offset: 0x00049D30
	public string StatusText
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x17000245 RID: 581
	// (get) Token: 0x0600124E RID: 4686 RVA: 0x0004BB44 File Offset: 0x00049D44
	// (set) Token: 0x0600124F RID: 4687 RVA: 0x0004BB4C File Offset: 0x00049D4C
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

	// Token: 0x17000246 RID: 582
	// (get) Token: 0x06001250 RID: 4688 RVA: 0x0004BB60 File Offset: 0x00049D60
	// (set) Token: 0x06001251 RID: 4689 RVA: 0x0004BB68 File Offset: 0x00049D68
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

	// Token: 0x06001252 RID: 4690 RVA: 0x0004BB7C File Offset: 0x00049D7C
	private void method_2(string string_3, SolidColorBrush solidColorBrush_1)
	{
		Class734.Struct172 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class734_0 = this;
		@struct.string_0 = string_3;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class734.Struct172>(ref @struct);
	}

	// Token: 0x17000247 RID: 583
	// (get) Token: 0x06001253 RID: 4691 RVA: 0x0004BBC4 File Offset: 0x00049DC4
	// (set) Token: 0x06001254 RID: 4692 RVA: 0x0004BBCC File Offset: 0x00049DCC
	public string Name
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			base.method_0("Name");
		}
	}

	// Token: 0x17000248 RID: 584
	// (get) Token: 0x06001255 RID: 4693 RVA: 0x0004BBE0 File Offset: 0x00049DE0
	public string DateCreated
	{
		get
		{
			return this.class660_0.DateTime_0.ToString("dd.MM.yyyy HH:mm");
		}
	}

	// Token: 0x17000249 RID: 585
	// (get) Token: 0x06001256 RID: 4694 RVA: 0x0004BC08 File Offset: 0x00049E08
	public GClass134 Rename
	{
		get
		{
			return new GClass134(new Action<object>(this.method_3), null);
		}
	}

	// Token: 0x1700024A RID: 586
	// (get) Token: 0x06001257 RID: 4695 RVA: 0x0004BC1C File Offset: 0x00049E1C
	public GClass134 Delete
	{
		get
		{
			return new GClass134(new Action<object>(this.method_5), null);
		}
	}

	// Token: 0x1700024B RID: 587
	// (get) Token: 0x06001258 RID: 4696 RVA: 0x0004BC30 File Offset: 0x00049E30
	public GClass134 Choose
	{
		get
		{
			return new GClass134(new Action<object>(this.method_7), null);
		}
	}

	// Token: 0x1700024C RID: 588
	// (get) Token: 0x06001259 RID: 4697 RVA: 0x0004BC44 File Offset: 0x00049E44
	public GClass134 OpenLocation
	{
		get
		{
			return new GClass134(new Action<object>(this.method_9), null);
		}
	}

	// Token: 0x1700024D RID: 589
	// (get) Token: 0x0600125A RID: 4698 RVA: 0x0004BC58 File Offset: 0x00049E58
	public GClass134 UploadToCloud
	{
		get
		{
			if (this.bool_0)
			{
				return null;
			}
			return new GClass134(new Action<object>(this.method_11), null);
		}
	}

	// Token: 0x0600125B RID: 4699 RVA: 0x0004BC78 File Offset: 0x00049E78
	private void method_3(object object_0)
	{
		Task.Run(new Func<Task>(this.method_4));
	}

	// Token: 0x0600125C RID: 4700 RVA: 0x0004BC8C File Offset: 0x00049E8C
	private Task method_4()
	{
		Class734.Struct171 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class734_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class734.Struct171>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600125D RID: 4701 RVA: 0x0004BCD0 File Offset: 0x00049ED0
	private void method_5(object object_0)
	{
		Task.Run(new Action(this.method_6));
	}

	// Token: 0x0600125E RID: 4702 RVA: 0x0004BCE4 File Offset: 0x00049EE4
	private void method_6()
	{
		File.Delete(this.string_0);
		this.class755_0.method_1();
	}

	// Token: 0x0600125F RID: 4703 RVA: 0x0004BCFC File Offset: 0x00049EFC
	private void method_7(object object_0)
	{
		Application.Current.Dispatcher.Invoke(new Action(this.method_8));
	}

	// Token: 0x06001260 RID: 4704 RVA: 0x0004BD1C File Offset: 0x00049F1C
	private void method_8()
	{
		this.class755_0.ChoosenForImport = this;
		Class358.smethod_0().method_3(typeof(dje_z9AF5UANMBE456HKG7QM7SSCRP9HB7ZTT9CF2NUY2TW79J9HLNAVBC2SKJ4ZA_ejd), Class358.smethod_0().frame_0);
	}

	// Token: 0x06001261 RID: 4705 RVA: 0x0004BD48 File Offset: 0x00049F48
	private void method_9(object object_0)
	{
		Task.Run(new Action(this.method_10));
	}

	// Token: 0x06001262 RID: 4706 RVA: 0x0004BD5C File Offset: 0x00049F5C
	private void method_10()
	{
		string arguments = "/select, \"" + this.string_0 + "\"";
		Process.Start("explorer.exe", arguments);
	}

	// Token: 0x06001263 RID: 4707 RVA: 0x0004BD8C File Offset: 0x00049F8C
	private void method_11(object object_0)
	{
		Class734.Struct170 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class734_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class734.Struct170>(ref @struct);
	}

	// Token: 0x06001264 RID: 4708 RVA: 0x0004BDC4 File Offset: 0x00049FC4
	private Task method_12()
	{
		Class734.Struct169 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class734_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class734.Struct169>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001265 RID: 4709 RVA: 0x0004BE08 File Offset: 0x0004A008
	private Task method_13()
	{
		Class734.Struct173 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class734_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class734.Struct173>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04000B37 RID: 2871
	private Class755 class755_0;

	// Token: 0x04000B38 RID: 2872
	public Class660 class660_0;

	// Token: 0x04000B39 RID: 2873
	public byte[] byte_0;

	// Token: 0x04000B3A RID: 2874
	private string string_0;

	// Token: 0x04000B3B RID: 2875
	private string string_1 = string.Empty;

	// Token: 0x04000B3C RID: 2876
	private SolidColorBrush solidColorBrush_0 = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd;

	// Token: 0x04000B3D RID: 2877
	private double double_0;

	// Token: 0x04000B3E RID: 2878
	private string string_2;

	// Token: 0x04000B3F RID: 2879
	private bool bool_0;

	// Token: 0x02000327 RID: 807
	[StructLayout(LayoutKind.Auto)]
	private struct Struct169 : IAsyncStateMachine
	{
		// Token: 0x06001266 RID: 4710 RVA: 0x0004BE4C File Offset: 0x0004A04C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class734 @class = this.class734_0;
			try
			{
				TaskAwaiter awaiter;
				TaskAwaiter<Class289> awaiter2;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					break;
				case 1:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<Class289>);
					this.int_0 = -1;
					goto IL_15C;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_234;
				case 3:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_269;
				default:
					if (!Class585.struct13_0.method_0())
					{
						awaiter = Application.Current.Dispatcher.Invoke<Task>(new Func<Task>(@class.method_13)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class734.Struct169>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						@class.method_2(Class364.smethod_0("Uploading"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
						Class600<string, string, DateTime, Guid, byte[]> object_ = new Class600<string, string, DateTime, Guid, byte[]>(Class389.class504_0.Key, @class.Name, @class.class660_0.DateTime_0.ToUniversalTime(), Guid.NewGuid(), File.ReadAllBytes(@class.string_0));
						awaiter2 = Class166.smethod_1(Class193.uri_12, object_).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.int_0 = 1;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class289>, Class734.Struct169>(ref awaiter2, ref this);
							return;
						}
						goto IL_15C;
					}
					break;
				}
				awaiter.GetResult();
				@class.bool_0 = false;
				goto IL_29B;
				IL_15C:
				Class289 result = awaiter2.GetResult();
				if (!result.Success)
				{
					@class.method_2(result.Message, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
					awaiter = Task.Delay(1500).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class734.Struct169>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					@class.class755_0.method_2();
					@class.method_2(Class364.smethod_0("storexins7"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
					awaiter = Task.Delay(1500).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 3;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class734.Struct169>(ref awaiter, ref this);
						return;
					}
					goto IL_269;
				}
				IL_234:
				awaiter.GetResult();
				@class.method_2(string.Empty, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				goto IL_29B;
				IL_269:
				awaiter.GetResult();
				@class.method_2(string.Empty, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_29B:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x0004C124 File Offset: 0x0004A324
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000B40 RID: 2880
		public int int_0;

		// Token: 0x04000B41 RID: 2881
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000B42 RID: 2882
		public Class734 class734_0;

		// Token: 0x04000B43 RID: 2883
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x04000B44 RID: 2884
		private TaskAwaiter<Class289> taskAwaiter_1;
	}

	// Token: 0x02000328 RID: 808
	[StructLayout(LayoutKind.Auto)]
	private struct Struct170 : IAsyncStateMachine
	{
		// Token: 0x06001268 RID: 4712 RVA: 0x0004C134 File Offset: 0x0004A334
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class734 @class = this.class734_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.bool_0 = true;
					awaiter = Task.Run(new Func<Task>(@class.method_12)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class734.Struct170>(ref awaiter, ref this);
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

		// Token: 0x06001269 RID: 4713 RVA: 0x0004C200 File Offset: 0x0004A400
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000B45 RID: 2885
		public int int_0;

		// Token: 0x04000B46 RID: 2886
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000B47 RID: 2887
		public Class734 class734_0;

		// Token: 0x04000B48 RID: 2888
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000329 RID: 809
	[StructLayout(LayoutKind.Auto)]
	private struct Struct171 : IAsyncStateMachine
	{
		// Token: 0x0600126A RID: 4714 RVA: 0x0004C210 File Offset: 0x0004A410
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class734 @class = this.class734_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (Path.GetFileNameWithoutExtension(@class.string_0) != @class.Name)
					{
						string text = Path.Combine(Path.GetDirectoryName(@class.string_0), @class.Name + ".buxz");
						File.Move(@class.string_0, text);
						@class.string_0 = text;
					}
					@class.method_2(Class364.smethod_0("Renamed"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
					awaiter = Task.Delay(1500).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class734.Struct171>(ref awaiter, ref this);
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
				@class.method_2(string.Empty, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
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

		// Token: 0x0600126B RID: 4715 RVA: 0x0004C33C File Offset: 0x0004A53C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000B49 RID: 2889
		public int int_0;

		// Token: 0x04000B4A RID: 2890
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000B4B RID: 2891
		public Class734 class734_0;

		// Token: 0x04000B4C RID: 2892
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200032A RID: 810
	[StructLayout(LayoutKind.Auto)]
	private struct Struct172 : IAsyncStateMachine
	{
		// Token: 0x0600126C RID: 4716 RVA: 0x0004C34C File Offset: 0x0004A54C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class734 @class = this.class734_0;
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class734.Struct172>(ref awaiter, ref this);
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class734.Struct172>(ref awaiter, ref this);
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

		// Token: 0x0600126D RID: 4717 RVA: 0x0004C548 File Offset: 0x0004A748
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000B4D RID: 2893
		public int int_0;

		// Token: 0x04000B4E RID: 2894
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000B4F RID: 2895
		public Class734 class734_0;

		// Token: 0x04000B50 RID: 2896
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04000B51 RID: 2897
		public string string_0;

		// Token: 0x04000B52 RID: 2898
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200032B RID: 811
	[StructLayout(LayoutKind.Auto)]
	private struct Struct173 : IAsyncStateMachine
	{
		// Token: 0x0600126E RID: 4718 RVA: 0x0004C558 File Offset: 0x0004A758
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class734 @class = this.class734_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.method_2(Class364.smethod_0("prorequired"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z4X7JAQVWCQJVN7A_ejd);
					awaiter = Task.Delay(1500).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class734.Struct173>(ref awaiter, ref this);
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
				@class.method_2(string.Empty, dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
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

		// Token: 0x0600126F RID: 4719 RVA: 0x0004C634 File Offset: 0x0004A834
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000B53 RID: 2899
		public int int_0;

		// Token: 0x04000B54 RID: 2900
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000B55 RID: 2901
		public Class734 class734_0;

		// Token: 0x04000B56 RID: 2902
		private TaskAwaiter taskAwaiter_0;
	}
}
