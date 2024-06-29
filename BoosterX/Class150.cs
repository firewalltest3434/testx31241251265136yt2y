using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using Microsoft.Win32.TaskScheduler;
using ns0;

// Token: 0x02000113 RID: 275
internal sealed class Class150
{
	// Token: 0x06000793 RID: 1939 RVA: 0x00024D44 File Offset: 0x00022F44
	public static Class150.Class161 smethod_0(bool bool_2)
	{
		if (!Class150.bool_0 || bool_2)
		{
			Class150.bool_0 = true;
			Class150.bool_1 = false;
			GClass93.smethod_0().method_17<Class521>();
			Class150.smethod_1();
		}
		return Class150.class161_0;
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x00024D74 File Offset: 0x00022F74
	private static void smethod_1()
	{
		Class150.Struct52 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class150.Struct52>(ref @struct);
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x00024DA4 File Offset: 0x00022FA4
	public static void smethod_2()
	{
		Class150.Struct55 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class150.Struct55>(ref @struct);
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x00024DD4 File Offset: 0x00022FD4
	public static void smethod_3()
	{
		Class150.Struct51 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class150.Struct51>(ref @struct);
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x00024E04 File Offset: 0x00023004
	public static void smethod_4()
	{
		Class150.Struct53 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class150.Struct53>(ref @struct);
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x00024E34 File Offset: 0x00023034
	public static Task smethod_5()
	{
		Class150.Struct54 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class150.Struct54>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x00024E70 File Offset: 0x00023070
	public static Task<List<Class188>> smethod_6()
	{
		Class150.Struct56 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class188>>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class150.Struct56>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04000401 RID: 1025
	private static Class150.Class161 class161_0 = new Class150.Class161();

	// Token: 0x04000402 RID: 1026
	private static bool bool_0 = false;

	// Token: 0x04000403 RID: 1027
	private static bool bool_1 = false;

	// Token: 0x02000114 RID: 276
	private sealed class Class151
	{
		// Token: 0x0600079B RID: 1947 RVA: 0x00024EB4 File Offset: 0x000230B4
		internal void method_0(string string_0)
		{
			if (this.class157_0.class720_0.Name.ToLower().Contains(string_0))
			{
				this.bool_0 = true;
			}
		}

		// Token: 0x04000404 RID: 1028
		public bool bool_0;

		// Token: 0x04000405 RID: 1029
		public Class150.Class157 class157_0;
	}

	// Token: 0x02000115 RID: 277
	private sealed class Class152
	{
		// Token: 0x0600079D RID: 1949 RVA: 0x00024EE4 File Offset: 0x000230E4
		internal void method_0()
		{
			Collection<Class720> taskARModels = Class150.class161_0.TaskARModels;
			Class720 @class = new Class720();
			@class.Icon = Class650.smethod_6(this.string_0);
			@class.Type = dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd.Task;
			@class.Name = this.string_1;
			@class.Runs = this.string_0;
			@class.Description = this.string_2;
			TaskFolder taskFolder_ = this.class162_0.taskFolder_0;
			@class.Path = ((taskFolder_ != null) ? taskFolder_.ToString() : null) + "\\" + this.string_1;
			@class.NewStatus = new bool?(this.bool_0);
			taskARModels.Add(@class);
		}

		// Token: 0x04000406 RID: 1030
		public string string_0;

		// Token: 0x04000407 RID: 1031
		public string string_1;

		// Token: 0x04000408 RID: 1032
		public string string_2;

		// Token: 0x04000409 RID: 1033
		public bool bool_0;

		// Token: 0x0400040A RID: 1034
		public Class150.Class162 class162_0;
	}

	// Token: 0x02000116 RID: 278
	[StructLayout(LayoutKind.Auto)]
	private struct Struct51 : IAsyncStateMachine
	{
		// Token: 0x0600079E RID: 1950 RVA: 0x00024F88 File Offset: 0x00023188
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (!Class585.struct13_0.method_0())
					{
						goto IL_12B;
					}
					if (!Class150.bool_0)
					{
						Class150.smethod_0(false);
					}
					awaiter = Class150.smethod_5().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class150.Struct51>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				IEnumerator<Class720> enumerator = Class150.class161_0.method_0().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class150.Class157 @class = new Class150.Class157();
						@class.class720_0 = enumerator.Current;
						Class150.Class151 class2 = new Class150.Class151();
						class2.class157_0 = @class;
						class2.bool_0 = false;
						Class605.list_6.ForEach(new Action<string>(class2.method_0));
						if (!class2.bool_0)
						{
							Class605.list_5.ForEach(new Action<string>(class2.class157_0.method_0));
						}
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_12B:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00025108 File Offset: 0x00023308
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400040B RID: 1035
		public int int_0;

		// Token: 0x0400040C RID: 1036
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400040D RID: 1037
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000117 RID: 279
	private sealed class Class153
	{
		// Token: 0x060007A1 RID: 1953 RVA: 0x00025120 File Offset: 0x00023320
		internal void method_0()
		{
			Class150.class161_0.TaskARModels.Add(new Class720
			{
				Icon = Class650.smethod_6(this.string_0),
				Type = dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd.Task,
				Name = this.string_1,
				Runs = this.string_0,
				Description = this.string_2,
				Path = this.string_1,
				NewStatus = new bool?(this.bool_0)
			});
		}

		// Token: 0x0400040E RID: 1038
		public string string_0;

		// Token: 0x0400040F RID: 1039
		public string string_1;

		// Token: 0x04000410 RID: 1040
		public string string_2;

		// Token: 0x04000411 RID: 1041
		public bool bool_0;
	}

	// Token: 0x02000118 RID: 280
	[StructLayout(LayoutKind.Auto)]
	private struct Struct52 : IAsyncStateMachine
	{
		// Token: 0x060007A2 RID: 1954 RVA: 0x0002519C File Offset: 0x0002339C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class150.Class158.class158_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class150.Struct52>(ref awaiter, ref this);
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

		// Token: 0x060007A3 RID: 1955 RVA: 0x00025268 File Offset: 0x00023468
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000412 RID: 1042
		public int int_0;

		// Token: 0x04000413 RID: 1043
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000414 RID: 1044
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000119 RID: 281
	private sealed class Class154
	{
		// Token: 0x060007A5 RID: 1957 RVA: 0x00025280 File Offset: 0x00023480
		internal void method_0()
		{
			Collection<Class720> serviceARModels = Class150.class161_0.ServiceARModels;
			Class720 @class = new Class720();
			object value = this.registryKey_0.GetValue("ImagePath");
			@class.Icon = Class650.smethod_6((value != null) ? value.ToString() : null);
			@class.Type = dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd.Service;
			@class.Name = this.class156_0.string_0.ToString();
			object value2 = this.registryKey_0.GetValue("ImagePath");
			@class.Runs = ((value2 != null) ? value2.ToString() : null);
			object value3 = this.registryKey_0.GetValue("Description");
			@class.Description = ((value3 != null) ? value3.ToString() : null);
			@class.Path = this.registryKey_0.ToString();
			@class.NewStatus = this.nullable_0;
			serviceARModels.Add(@class);
		}

		// Token: 0x04000415 RID: 1045
		public RegistryKey registryKey_0;

		// Token: 0x04000416 RID: 1046
		public bool? nullable_0;

		// Token: 0x04000417 RID: 1047
		public Class150.Class156 class156_0;
	}

	// Token: 0x0200011A RID: 282
	private sealed class Class155
	{
		// Token: 0x060007A7 RID: 1959 RVA: 0x00025350 File Offset: 0x00023550
		internal void method_0()
		{
			Class150.class161_0.FileARModels.Add(new Class720
			{
				Icon = Class650.smethod_6(Class650.smethod_8(this.string_0)),
				Type = dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd.File,
				Name = this.fileInfo_0.Name,
				Runs = Class650.smethod_8(this.string_0),
				Description = this.fileInfo_0.FullName,
				Path = this.string_1,
				NewStatus = new bool?(this.string_1.EndsWith("AutorunsDisabled"))
			});
		}

		// Token: 0x04000418 RID: 1048
		public string string_0;

		// Token: 0x04000419 RID: 1049
		public FileInfo fileInfo_0;

		// Token: 0x0400041A RID: 1050
		public string string_1;
	}

	// Token: 0x0200011B RID: 283
	private sealed class Class156
	{
		// Token: 0x060007A9 RID: 1961 RVA: 0x000253F0 File Offset: 0x000235F0
		internal bool method_0(string string_1)
		{
			return string_1.Contains(this.string_0);
		}

		// Token: 0x0400041B RID: 1051
		public string string_0;
	}

	// Token: 0x0200011C RID: 284
	private sealed class Class157
	{
		// Token: 0x060007AB RID: 1963 RVA: 0x00025408 File Offset: 0x00023608
		internal void method_0(string string_0)
		{
			if (this.class720_0.Name.ToLower().Contains(string_0))
			{
				this.class720_0.NewStatus = new bool?(true);
			}
		}

		// Token: 0x0400041C RID: 1052
		public Class720 class720_0;
	}

	// Token: 0x0200011D RID: 285
	[Serializable]
	private sealed class Class158
	{
		// Token: 0x060007AE RID: 1966 RVA: 0x00025448 File Offset: 0x00023648
		internal void method_0()
		{
			Application.Current.Dispatcher.Invoke(new Action(Class150.Class158.class158_0.method_1));
			using (List<RegistryKey>.Enumerator enumerator = Class186.list_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class150.Class159 @class = new Class150.Class159();
					@class.registryKey_0 = enumerator.Current;
					try
					{
						string[] array = @class.registryKey_0.GetValueNames();
						for (int i = 0; i < array.Length; i++)
						{
							Class150.Class160 class2 = new Class150.Class160();
							class2.class159_0 = @class;
							class2.string_0 = array[i];
							if (!(class2.string_0 == string.Empty))
							{
								Application.Current.Dispatcher.Invoke(new Action(class2.method_0));
							}
						}
					}
					catch (object obj)
					{
					}
				}
			}
			foreach (string path in Class186.list_1)
			{
				if (Directory.Exists(path))
				{
					string[] array = Directory.GetFiles(path);
					for (int i = 0; i < array.Length; i++)
					{
						Class150.Class155 class3 = new Class150.Class155();
						class3.string_0 = array[i];
						if (!class3.string_0.Contains("desktop.ini"))
						{
							try
							{
								class3.fileInfo_0 = new FileInfo(class3.string_0);
								class3.string_1 = Path.GetFullPath(path);
								Application.Current.Dispatcher.Invoke(new Action(class3.method_0));
							}
							catch (object obj2)
							{
							}
						}
					}
				}
			}
			using (TaskService taskService = new TaskService())
			{
				TaskFolder rootFolder = taskService.RootFolder;
				foreach (Task task in rootFolder.Tasks)
				{
					try
					{
						Class150.Class153 class4 = new Class150.Class153();
						string[] array2 = task.Xml.Split(new string[]
						{
							Environment.NewLine
						}, StringSplitOptions.None);
						class4.string_0 = string.Empty;
						class4.string_2 = string.Empty;
						foreach (string text in array2)
						{
							if (text.Contains("Command"))
							{
								class4.string_0 = text.Split(new char[]
								{
									'>'
								})[1].Replace("</Command", string.Empty);
							}
							if (text.Contains("Description"))
							{
								class4.string_2 = text.Split(new char[]
								{
									'>'
								})[1].Replace("</Description", string.Empty);
							}
						}
						class4.string_1 = task.Name;
						class4.bool_0 = !task.IsActive;
						Application.Current.Dispatcher.Invoke(new Action(class4.method_0));
					}
					catch (object obj3)
					{
					}
				}
				using (IEnumerator<TaskFolder> enumerator4 = rootFolder.SubFolders.GetEnumerator())
				{
					while (enumerator4.MoveNext())
					{
						Class150.Class162 class5 = new Class150.Class162();
						class5.taskFolder_0 = enumerator4.Current;
						if (!class5.taskFolder_0.Name.Contains("Microsoft") && !class5.taskFolder_0.Name.Contains("Agent Activation Runtime"))
						{
							foreach (Task task2 in class5.taskFolder_0.Tasks)
							{
								try
								{
									Class150.Class152 class6 = new Class150.Class152();
									class6.class162_0 = class5;
									string[] array3 = task2.Xml.Split(new string[]
									{
										Environment.NewLine
									}, StringSplitOptions.None);
									class6.string_0 = string.Empty;
									class6.string_2 = string.Empty;
									foreach (string text2 in array3)
									{
										if (text2.Contains("Command"))
										{
											class6.string_0 = text2.Split(new char[]
											{
												'>'
											})[1].Replace("</Command", string.Empty);
										}
										if (text2.Contains("Description"))
										{
											class6.string_2 = text2.Split(new char[]
											{
												'>'
											})[1].Replace("</Description", string.Empty);
										}
									}
									class6.string_1 = task2.Name;
									class6.bool_0 = !task2.IsActive;
									Application.Current.Dispatcher.Invoke(new Action(class6.method_0));
								}
								catch (object obj4)
								{
								}
							}
						}
					}
				}
				string[] array = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services").GetSubKeyNames();
				for (int i = 0; i < array.Length; i++)
				{
					Class150.Class156 class7 = new Class150.Class156();
					class7.string_0 = array[i];
					try
					{
						Class150.Class154 class8 = new Class150.Class154();
						class8.class156_0 = class7;
						class8.registryKey_0 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\" + class8.class156_0.string_0);
						if (!Class605.list_4.Any(new Func<string, bool>(class8.class156_0.method_0)))
						{
							if (class8.registryKey_0.GetValueNames().Any(new Func<string, bool>(Class150.Class158.class158_0.method_2)))
							{
								if (!class8.registryKey_0.GetValue("ImagePath").ToString().ToLower().Contains("system32") && !class8.registryKey_0.GetValue("ImagePath").ToString().ToLower().Contains("c:\\windows"))
								{
									class8.nullable_0 = null;
									if (class8.registryKey_0.GetValue("Start").ToString() == "4")
									{
										class8.nullable_0 = new bool?(true);
									}
									else
									{
										class8.nullable_0 = new bool?(false);
									}
									Application.Current.Dispatcher.Invoke(new Action(class8.method_0));
								}
							}
						}
					}
					catch (object obj5)
					{
					}
				}
				Class150.bool_1 = true;
			}
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00025C04 File Offset: 0x00023E04
		internal void method_1()
		{
			Class150.class161_0.method_1();
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00025C10 File Offset: 0x00023E10
		internal bool method_2(string string_0)
		{
			return string_0.ToString() == "ImagePath";
		}

		// Token: 0x0400041D RID: 1053
		public static readonly Class150.Class158 class158_0 = new Class150.Class158();

		// Token: 0x0400041E RID: 1054
		public static Action action_0;

		// Token: 0x0400041F RID: 1055
		public static Func<string, bool> func_0;

		// Token: 0x04000420 RID: 1056
		public static Action action_1;
	}

	// Token: 0x0200011E RID: 286
	[StructLayout(LayoutKind.Auto)]
	private struct Struct53 : IAsyncStateMachine
	{
		// Token: 0x060007B1 RID: 1969 RVA: 0x00025C24 File Offset: 0x00023E24
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (!Class150.bool_0)
					{
						Class150.smethod_0(false);
					}
					awaiter = Class150.smethod_5().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class150.Struct53>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				IEnumerator<Class720> enumerator = Class150.class161_0.method_0().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class720 @class = enumerator.Current;
						@class.NewStatus = new bool?(true);
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
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

		// Token: 0x060007B2 RID: 1970 RVA: 0x00025D28 File Offset: 0x00023F28
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000421 RID: 1057
		public int int_0;

		// Token: 0x04000422 RID: 1058
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000423 RID: 1059
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200011F RID: 287
	private sealed class Class159
	{
		// Token: 0x04000424 RID: 1060
		public RegistryKey registryKey_0;
	}

	// Token: 0x02000120 RID: 288
	[StructLayout(LayoutKind.Auto)]
	private struct Struct54 : IAsyncStateMachine
	{
		// Token: 0x060007B4 RID: 1972 RVA: 0x00025D40 File Offset: 0x00023F40
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_5E;
				}
				this.int_1 = 0;
				IL_41:
				if (Class150.bool_1)
				{
					goto IL_AD;
				}
				awaiter = Task.Delay(20).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class150.Struct54>(ref awaiter, ref this);
					return;
				}
				IL_5E:
				awaiter.GetResult();
				if (this.int_1 <= 500)
				{
					int num2 = this.int_1;
					this.int_1 = num2 + 1;
					goto IL_41;
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_AD:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00025E20 File Offset: 0x00024020
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000425 RID: 1061
		public int int_0;

		// Token: 0x04000426 RID: 1062
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000427 RID: 1063
		private int int_1;

		// Token: 0x04000428 RID: 1064
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000121 RID: 289
	private sealed class Class160
	{
		// Token: 0x060007B7 RID: 1975 RVA: 0x00025E38 File Offset: 0x00024038
		internal void method_0()
		{
			Class150.class161_0.RegARModels.Add(new Class720
			{
				Icon = Class650.smethod_6(this.class159_0.registryKey_0.GetValue(this.string_0).ToString()),
				Type = dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd.Registry,
				Name = this.string_0.ToString(),
				Runs = this.class159_0.registryKey_0.GetValue(this.string_0).ToString(),
				Description = this.string_0.ToString(),
				Path = this.class159_0.registryKey_0.ToString(),
				NewStatus = new bool?(this.class159_0.registryKey_0.ToString().EndsWith("AutorunsDisabled") > false)
			});
		}

		// Token: 0x04000429 RID: 1065
		public string string_0;

		// Token: 0x0400042A RID: 1066
		public Class150.Class159 class159_0;
	}

	// Token: 0x02000122 RID: 290
	[StructLayout(LayoutKind.Auto)]
	private struct Struct55 : IAsyncStateMachine
	{
		// Token: 0x060007B8 RID: 1976 RVA: 0x00025F08 File Offset: 0x00024108
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (!Class150.bool_0)
					{
						Class150.smethod_0(false);
					}
					awaiter = Class150.smethod_5().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class150.Struct55>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				IEnumerator<Class720> enumerator = Class150.class161_0.method_0().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class720 @class = enumerator.Current;
						@class.NewStatus = new bool?(false);
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
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

		// Token: 0x060007B9 RID: 1977 RVA: 0x0002600C File Offset: 0x0002420C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400042B RID: 1067
		public int int_0;

		// Token: 0x0400042C RID: 1068
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400042D RID: 1069
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000123 RID: 291
	public sealed class Class161
	{
		// Token: 0x060007BB RID: 1979 RVA: 0x00026050 File Offset: 0x00024250
		public ObservableCollection<Class720> method_0()
		{
			ObservableCollection<Class720> observableCollection = new ObservableCollection<Class720>();
			foreach (Class720 item in this.FileARModels)
			{
				observableCollection.Add(item);
			}
			foreach (Class720 item2 in this.TaskARModels)
			{
				observableCollection.Add(item2);
			}
			foreach (Class720 item3 in this.RegARModels)
			{
				observableCollection.Add(item3);
			}
			foreach (Class720 item4 in this.ServiceARModels)
			{
				observableCollection.Add(item4);
			}
			return observableCollection;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x00026160 File Offset: 0x00024360
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x00026168 File Offset: 0x00024368
		public ObservableCollection<Class720> FileARModels
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_0;
			}
			[CompilerGenerated]
			set
			{
				this.observableCollection_0 = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x00026174 File Offset: 0x00024374
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x0002617C File Offset: 0x0002437C
		public ObservableCollection<Class720> RegARModels
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_1;
			}
			[CompilerGenerated]
			set
			{
				this.observableCollection_1 = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00026188 File Offset: 0x00024388
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x00026190 File Offset: 0x00024390
		public ObservableCollection<Class720> TaskARModels
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_2;
			}
			[CompilerGenerated]
			set
			{
				this.observableCollection_2 = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x0002619C File Offset: 0x0002439C
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x000261A4 File Offset: 0x000243A4
		public ObservableCollection<Class720> ServiceARModels
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_3;
			}
			[CompilerGenerated]
			set
			{
				this.observableCollection_3 = value;
			}
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000261B0 File Offset: 0x000243B0
		public void method_1()
		{
			this.FileARModels.Clear();
			this.RegARModels.Clear();
			this.TaskARModels.Clear();
			this.ServiceARModels.Clear();
		}

		// Token: 0x0400042E RID: 1070
		private ObservableCollection<Class720> observableCollection_0 = new ObservableCollection<Class720>();

		// Token: 0x0400042F RID: 1071
		private ObservableCollection<Class720> observableCollection_1 = new ObservableCollection<Class720>();

		// Token: 0x04000430 RID: 1072
		private ObservableCollection<Class720> observableCollection_2 = new ObservableCollection<Class720>();

		// Token: 0x04000431 RID: 1073
		private ObservableCollection<Class720> observableCollection_3 = new ObservableCollection<Class720>();
	}

	// Token: 0x02000124 RID: 292
	private sealed class Class162
	{
		// Token: 0x04000432 RID: 1074
		public TaskFolder taskFolder_0;
	}

	// Token: 0x02000125 RID: 293
	[StructLayout(LayoutKind.Auto)]
	private struct Struct56 : IAsyncStateMachine
	{
		// Token: 0x060007C6 RID: 1990 RVA: 0x000261E8 File Offset: 0x000243E8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<Class188> result;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					this.list_0 = new List<Class188>();
					this.class161_0 = Class150.smethod_0(false);
					awaiter = Class150.smethod_5().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class150.Struct56>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				IEnumerator<Class720> enumerator = this.class161_0.method_0().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class720 @class = enumerator.Current;
						this.list_0.Add(new Class188
						{
							Type = dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.Autoruns,
							Name = @class.NameClean,
							State = @class.Status.ToString()
						});
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				result = this.list_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.list_0 = null;
				this.class161_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.list_0 = null;
			this.class161_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00026354 File Offset: 0x00024554
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000433 RID: 1075
		public int int_0;

		// Token: 0x04000434 RID: 1076
		public AsyncTaskMethodBuilder<List<Class188>> asyncTaskMethodBuilder_0;

		// Token: 0x04000435 RID: 1077
		private List<Class188> list_0;

		// Token: 0x04000436 RID: 1078
		private Class150.Class161 class161_0;

		// Token: 0x04000437 RID: 1079
		private TaskAwaiter taskAwaiter_0;
	}
}
