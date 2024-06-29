using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Token: 0x02000292 RID: 658
internal sealed class Class727 : GClass211
{
	// Token: 0x06000F31 RID: 3889 RVA: 0x00041304 File Offset: 0x0003F504
	public Class727()
	{
		this.class506_0 = Class389.class506_0;
		this.GMXAddGameVMs.CollectionChanged += this.method_4;
		this.GMXStoredSettingsGamesVMs.CollectionChanged += this.method_5;
	}

	// Token: 0x06000F32 RID: 3890 RVA: 0x00041368 File Offset: 0x0003F568
	private void method_1(string string_0)
	{
		base.method_0(string_0);
	}

	// Token: 0x170001D0 RID: 464
	// (get) Token: 0x06000F33 RID: 3891 RVA: 0x00041374 File Offset: 0x0003F574
	public ObservableCollection<Class738> GMXAddGameVMs
	{
		get
		{
			if (this.observableCollection_0.Count == 0 && !this.bool_1)
			{
				this.method_3();
			}
			return this.observableCollection_0;
		}
	}

	// Token: 0x170001D1 RID: 465
	// (get) Token: 0x06000F34 RID: 3892 RVA: 0x00041398 File Offset: 0x0003F598
	public ObservableCollection<Class735> GMXAddAppsVMs
	{
		get
		{
			if (this.observableCollection_1.Count == 0 && !this.bool_0)
			{
				this.method_2();
			}
			return this.observableCollection_1;
		}
	}

	// Token: 0x06000F35 RID: 3893 RVA: 0x000413BC File Offset: 0x0003F5BC
	private void method_2()
	{
		Class727.Struct140 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class727_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class727.Struct140>(ref @struct);
	}

	// Token: 0x06000F36 RID: 3894 RVA: 0x000413F4 File Offset: 0x0003F5F4
	public void method_3()
	{
		Class727.Struct139 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class727_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class727.Struct139>(ref @struct);
	}

	// Token: 0x170001D2 RID: 466
	// (get) Token: 0x06000F37 RID: 3895 RVA: 0x0004142C File Offset: 0x0003F62C
	public ObservableCollection<Class742> GMXStoredSettingsGamesVMs
	{
		get
		{
			return this.class506_0.method_0();
		}
	}

	// Token: 0x170001D3 RID: 467
	// (get) Token: 0x06000F38 RID: 3896 RVA: 0x0004143C File Offset: 0x0003F63C
	public ObservableCollection<Class747> GMXStoredSettingsAppsVMs
	{
		get
		{
			return this.class506_0.method_1();
		}
	}

	// Token: 0x170001D4 RID: 468
	// (get) Token: 0x06000F39 RID: 3897 RVA: 0x0004144C File Offset: 0x0003F64C
	// (set) Token: 0x06000F3A RID: 3898 RVA: 0x0004145C File Offset: 0x0003F65C
	public string OnOffShortcut
	{
		get
		{
			return this.class506_0.OnOffShortcut;
		}
		set
		{
			this.class506_0.OnOffShortcut = value;
			base.method_0("OnOffShortcut");
		}
	}

	// Token: 0x170001D5 RID: 469
	// (get) Token: 0x06000F3B RID: 3899 RVA: 0x00041478 File Offset: 0x0003F678
	// (set) Token: 0x06000F3C RID: 3900 RVA: 0x00041488 File Offset: 0x0003F688
	public bool? DisableDWM
	{
		get
		{
			return this.class506_0.DisableDWM;
		}
		set
		{
			this.class506_0.DisableDWM = value;
			base.method_0("DisableDWM");
		}
	}

	// Token: 0x170001D6 RID: 470
	// (get) Token: 0x06000F3D RID: 3901 RVA: 0x000414A4 File Offset: 0x0003F6A4
	// (set) Token: 0x06000F3E RID: 3902 RVA: 0x000414B4 File Offset: 0x0003F6B4
	public bool? DisableExplorer
	{
		get
		{
			return this.class506_0.DisableExplorer;
		}
		set
		{
			this.class506_0.DisableExplorer = value;
			base.method_0("DisableExplorer");
		}
	}

	// Token: 0x170001D7 RID: 471
	// (get) Token: 0x06000F3F RID: 3903 RVA: 0x000414D0 File Offset: 0x0003F6D0
	// (set) Token: 0x06000F40 RID: 3904 RVA: 0x000414E0 File Offset: 0x0003F6E0
	public string CleanCacheShortcut
	{
		get
		{
			return this.class506_0.CleanCacheShortcut;
		}
		set
		{
			this.class506_0.CleanCacheShortcut = value;
			base.method_0("CleanCacheShortcut");
		}
	}

	// Token: 0x170001D8 RID: 472
	// (get) Token: 0x06000F41 RID: 3905 RVA: 0x000414FC File Offset: 0x0003F6FC
	// (set) Token: 0x06000F42 RID: 3906 RVA: 0x0004150C File Offset: 0x0003F70C
	public bool? CleanCacheAtStart
	{
		get
		{
			return this.class506_0.CleanCacheAtStart;
		}
		set
		{
			this.class506_0.CleanCacheAtStart = value;
			base.method_0("CleanCacheAtStart");
		}
	}

	// Token: 0x170001D9 RID: 473
	// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00041528 File Offset: 0x0003F728
	public List<Class506.Class702> PowerSchemes
	{
		get
		{
			return this.class506_0.PowerSchemes;
		}
	}

	// Token: 0x170001DA RID: 474
	// (get) Token: 0x06000F44 RID: 3908 RVA: 0x00041538 File Offset: 0x0003F738
	// (set) Token: 0x06000F45 RID: 3909 RVA: 0x00041548 File Offset: 0x0003F748
	public Class506.Class702 PSGaming
	{
		get
		{
			return this.class506_0.PSGaming;
		}
		set
		{
			this.class506_0.PSGaming = value;
			base.method_0("PSGaming");
		}
	}

	// Token: 0x170001DB RID: 475
	// (get) Token: 0x06000F46 RID: 3910 RVA: 0x00041564 File Offset: 0x0003F764
	// (set) Token: 0x06000F47 RID: 3911 RVA: 0x00041574 File Offset: 0x0003F774
	public Class506.Class702 PSGameOff
	{
		get
		{
			return this.class506_0.PSGameOff;
		}
		set
		{
			this.class506_0.PSGameOff = value;
			base.method_0("PSGameOff");
		}
	}

	// Token: 0x06000F48 RID: 3912 RVA: 0x00041590 File Offset: 0x0003F790
	private void method_4(object sender, NotifyCollectionChangedEventArgs p1)
	{
		this.method_1("GMXAddGameVMs");
	}

	// Token: 0x06000F49 RID: 3913 RVA: 0x000415A0 File Offset: 0x0003F7A0
	private void method_5(object sender, NotifyCollectionChangedEventArgs p1)
	{
		this.method_1("GMXStoredSettingsGamesVMs");
	}

	// Token: 0x06000F4A RID: 3914 RVA: 0x000415B0 File Offset: 0x0003F7B0
	private void method_6()
	{
		try
		{
			List<string> list = new List<string>();
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.Length; i++)
			{
				Class727.Class330 @class = new Class727.Class330();
				@class.class727_0 = this;
				@class.process_0 = processes[i];
				bool flag = false;
				using (List<string>.Enumerator enumerator = Class605.list_2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.ToLower() == @class.process_0.ProcessName.ToLower())
						{
							flag = true;
						}
					}
				}
				foreach (string b in list)
				{
					if (@class.process_0.ProcessName == b)
					{
						flag = true;
					}
				}
				if (!flag)
				{
					try
					{
						Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
						list.Add(@class.process_0.ProcessName);
					}
					catch (object obj)
					{
					}
				}
			}
		}
		catch (object obj2)
		{
		}
	}

	// Token: 0x06000F4B RID: 3915 RVA: 0x00041728 File Offset: 0x0003F928
	private void method_7()
	{
		Class727.Class331 @class = new Class727.Class331();
		@class.class727_0 = this;
		List<string> list = new List<string>();
		@class.observableCollection_0 = new ObservableCollection<Class738>();
		List<string> list_ = Class605.list_1;
		try
		{
			@class.registryKey_0 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Valve\\Steam");
			string str = @class.registryKey_0.GetValue("InstallPath").ToString();
			List<string> list2 = new List<string>();
			string pattern = "[A-Z]:\\\\";
			if (File.Exists(str + "\\steamapps\\libraryfolders.vdf"))
			{
				foreach (string text in File.ReadAllLines(str + "\\steamapps\\libraryfolders.vdf"))
				{
					Match match = Regex.Match(text, pattern);
					if (text != string.Empty && match.Success)
					{
						string value = match.ToString();
						string text2 = text.Substring(text.IndexOf(value));
						text2 = text2.Replace("\\\\", "\\");
						text2 = text2.Replace("\"", "\\steamapps\\common\\");
						list2.Add(text2);
					}
				}
			}
			foreach (string path in list2)
			{
				string[] array = Directory.GetDirectories(path);
				for (int i = 0; i < array.Length; i++)
				{
					string[] files = Directory.GetFiles(array[i], "*.exe", SearchOption.AllDirectories);
					for (int j = 0; j < files.Length; j++)
					{
						Class727.Class329 class2 = new Class727.Class329();
						class2.class331_0 = @class;
						class2.string_0 = files[j];
						bool flag = false;
						bool flag2 = false;
						foreach (string b in list_)
						{
							if (class2.string_0.Split(new char[]
							{
								'\\'
							}).Last<string>() == b)
							{
								flag = true;
							}
						}
						foreach (string b2 in list)
						{
							if (class2.string_0.Split(new char[]
							{
								'\\'
							}).Last<string>() == b2)
							{
								flag2 = true;
							}
						}
						if (flag && !flag2)
						{
							class2.string_1 = class2.string_0.Split(new char[]
							{
								'\\'
							});
							class2.int_0 = 0;
							for (int k = 0; k < class2.string_1.Length; k++)
							{
								if (class2.string_1[k] == "common")
								{
									class2.int_0 = k + 1;
								}
							}
							Application.Current.Dispatcher.Invoke(new Action(class2.method_0));
							list.Add(class2.string_0.Split(new char[]
							{
								'\\'
							}).Last<string>());
						}
					}
				}
			}
		}
		catch (object obj)
		{
		}
		try
		{
			List<string> list3 = new List<string>();
			string pattern2 = "[A-Z]:\\\\";
			if (File.Exists("C:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"))
			{
				foreach (string text3 in File.ReadAllLines("C:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"))
				{
					Match match2 = Regex.Match(text3, pattern2);
					if (text3 != string.Empty && match2.Success)
					{
						string value2 = match2.ToString();
						string text4 = text3.Substring(text3.IndexOf(value2));
						text4 = text4.Replace("\\\\", "\\");
						text4 = text4.Replace("\",", string.Empty);
						list3.Add(text4);
					}
				}
				using (List<string>.Enumerator enumerator = list3.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class727.Class332 class3 = new Class727.Class332();
						class3.class331_0 = @class;
						class3.string_0 = enumerator.Current;
						Directory.GetDirectories(class3.string_0);
						string[] array = Directory.GetFiles(class3.string_0, "*.exe", SearchOption.AllDirectories);
						for (int i = 0; i < array.Length; i++)
						{
							Class727.Class328 class4 = new Class727.Class328();
							class4.class332_0 = class3;
							class4.string_0 = array[i];
							bool flag3 = false;
							bool flag4 = false;
							foreach (string b3 in list_)
							{
								if (class4.string_0.Split(new char[]
								{
									'\\'
								}).Last<string>() == b3)
								{
									flag3 = true;
								}
							}
							foreach (string b4 in list)
							{
								if (class4.string_0.Split(new char[]
								{
									'\\'
								}).Last<string>() == b4)
								{
									flag4 = true;
								}
							}
							if (flag3 && !flag4)
							{
								Application.Current.Dispatcher.Invoke(new Action(class4.method_0));
								list.Add(class4.string_0.Split(new char[]
								{
									'\\'
								}).Last<string>());
							}
						}
					}
				}
			}
		}
		catch (object obj2)
		{
		}
		try
		{
			List<string> list4 = new List<string>();
			if (File.Exists("C:\\ProgramData\\Riot Games\\RiotClientInstalls.json"))
			{
				new JsonSerializer();
				foreach (JToken jtoken in ((IEnumerable<JToken>)JObject.Parse(File.ReadAllText("C:\\ProgramData\\Riot Games\\RiotClientInstalls.json"))["associated_client"].Children().ToList<JToken>()))
				{
					list4.Add(jtoken.ToString().Split(new char[]
					{
						'"'
					})[1].Replace('/', '\\'));
				}
				foreach (string path2 in list4)
				{
					string[] array = Directory.GetFiles(path2, "*.exe", SearchOption.AllDirectories);
					for (int i = 0; i < array.Length; i++)
					{
						Class727.Class327 class5 = new Class727.Class327();
						class5.class331_0 = @class;
						class5.string_0 = array[i];
						bool flag5 = false;
						bool flag6 = false;
						foreach (string b5 in list_)
						{
							if (class5.string_0.Split(new char[]
							{
								'\\'
							}).Last<string>() == b5)
							{
								flag5 = true;
							}
						}
						foreach (string b6 in list)
						{
							if (class5.string_0.Split(new char[]
							{
								'\\'
							}).Last<string>() == b6)
							{
								flag6 = true;
							}
						}
						if (flag5 && !flag6)
						{
							class5.string_1 = Class650.smethod_15(class5.string_0);
							Application.Current.Dispatcher.Invoke(new Action(class5.method_0));
							list.Add(class5.string_0.Split(new char[]
							{
								'\\'
							}).Last<string>());
						}
					}
				}
			}
		}
		catch (object obj3)
		{
		}
		try
		{
			@class.registryKey_0 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache");
			string[] array = @class.registryKey_0.GetValueNames();
			for (int i = 0; i < array.Length; i++)
			{
				Class727.Class326 class6 = new Class727.Class326();
				class6.class331_0 = @class;
				class6.string_0 = array[i];
				if (class6.string_0.EndsWith("exe.FriendlyAppName") && class6.string_0.Split(new char[]
				{
					'\\'
				}).Last<string>() != ".exe.FriendlyAppName")
				{
					string a = class6.string_0.Split(new char[]
					{
						'\\'
					}).Last<string>().Replace(".FriendlyAppName", string.Empty);
					bool flag7 = false;
					bool flag8 = false;
					foreach (string b7 in list_)
					{
						if (a == b7)
						{
							flag7 = true;
						}
					}
					foreach (string b8 in list)
					{
						if (a == b8)
						{
							flag8 = true;
						}
					}
					if (flag7 && !flag8)
					{
						Application.Current.Dispatcher.Invoke(new Action(class6.method_0));
						list.Add(class6.string_0.Split(new char[]
						{
							'\\'
						}).Last<string>().Replace(".FriendlyAppName", string.Empty));
					}
				}
			}
		}
		catch (object obj4)
		{
		}
	}

	// Token: 0x0400094C RID: 2380
	private Class506 class506_0;

	// Token: 0x0400094D RID: 2381
	private bool bool_0;

	// Token: 0x0400094E RID: 2382
	private bool bool_1;

	// Token: 0x0400094F RID: 2383
	private ObservableCollection<Class738> observableCollection_0 = new ObservableCollection<Class738>();

	// Token: 0x04000950 RID: 2384
	private ObservableCollection<Class735> observableCollection_1 = new ObservableCollection<Class735>();

	// Token: 0x02000293 RID: 659
	private sealed class Class326
	{
		// Token: 0x06000F4D RID: 3917 RVA: 0x00042260 File Offset: 0x00040460
		internal void method_0()
		{
			Class738 item = new Class738
			{
				Name = this.class331_0.registryKey_0.GetValue(this.string_0).ToString(),
				ExeDir = this.class331_0.registryKey_0.GetValue(this.string_0).ToString(),
				FoundIn = Class364.smethod_0("GMXFoundInCache"),
				ExeName = this.string_0.Split(new char[]
				{
					'\\'
				}).Last<string>().Replace(".FriendlyAppName", string.Empty).Replace(".exe", string.Empty)
			};
			this.class331_0.class727_0.observableCollection_0.Add(item);
			this.class331_0.observableCollection_0.Add(item);
		}

		// Token: 0x04000951 RID: 2385
		public string string_0;

		// Token: 0x04000952 RID: 2386
		public Class727.Class331 class331_0;
	}

	// Token: 0x02000294 RID: 660
	[StructLayout(LayoutKind.Auto)]
	private struct Struct139 : IAsyncStateMachine
	{
		// Token: 0x06000F4E RID: 3918 RVA: 0x00042330 File Offset: 0x00040530
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class727 @class = this.class727_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.bool_1 = true;
					awaiter = Task.Run(new Action(@class.method_7)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class727.Struct139>(ref awaiter, ref this);
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
				@class.bool_1 = false;
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

		// Token: 0x06000F4F RID: 3919 RVA: 0x000423FC File Offset: 0x000405FC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000953 RID: 2387
		public int int_0;

		// Token: 0x04000954 RID: 2388
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000955 RID: 2389
		public Class727 class727_0;

		// Token: 0x04000956 RID: 2390
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000295 RID: 661
	private sealed class Class327
	{
		// Token: 0x06000F51 RID: 3921 RVA: 0x00042414 File Offset: 0x00040614
		internal void method_0()
		{
			Class738 item = new Class738
			{
				Name = this.string_1,
				ExeDir = this.string_0,
				FoundIn = "Riot Games",
				ExeName = this.string_0.Split(new char[]
				{
					'\\'
				}).Last<string>().Replace(".exe", string.Empty)
			};
			this.class331_0.class727_0.observableCollection_0.Add(item);
			this.class331_0.observableCollection_0.Add(item);
		}

		// Token: 0x04000957 RID: 2391
		public string string_0;

		// Token: 0x04000958 RID: 2392
		public string string_1;

		// Token: 0x04000959 RID: 2393
		public Class727.Class331 class331_0;
	}

	// Token: 0x02000296 RID: 662
	private sealed class Class328
	{
		// Token: 0x06000F53 RID: 3923 RVA: 0x000424AC File Offset: 0x000406AC
		internal void method_0()
		{
			Class738 item = new Class738
			{
				Name = this.class332_0.string_0.Split(new char[]
				{
					'\\'
				}).Last<string>(),
				ExeDir = this.string_0,
				FoundIn = "Epic Games",
				ExeName = this.string_0.Split(new char[]
				{
					'\\'
				}).Last<string>().Replace(".exe", string.Empty)
			};
			this.class332_0.class331_0.class727_0.observableCollection_0.Add(item);
			this.class332_0.class331_0.observableCollection_0.Add(item);
		}

		// Token: 0x0400095A RID: 2394
		public string string_0;

		// Token: 0x0400095B RID: 2395
		public Class727.Class332 class332_0;
	}

	// Token: 0x02000297 RID: 663
	private sealed class Class329
	{
		// Token: 0x06000F55 RID: 3925 RVA: 0x00042568 File Offset: 0x00040768
		internal void method_0()
		{
			Class738 item = new Class738
			{
				Name = this.string_1[this.int_0],
				ExeDir = this.string_0,
				FoundIn = "Steam",
				ExeName = this.string_0.Split(new char[]
				{
					'\\'
				}).Last<string>().Replace(".exe", string.Empty)
			};
			this.class331_0.class727_0.observableCollection_0.Add(item);
			this.class331_0.observableCollection_0.Add(item);
		}

		// Token: 0x0400095C RID: 2396
		public string string_0;

		// Token: 0x0400095D RID: 2397
		public string[] string_1;

		// Token: 0x0400095E RID: 2398
		public int int_0;

		// Token: 0x0400095F RID: 2399
		public Class727.Class331 class331_0;
	}

	// Token: 0x02000298 RID: 664
	private sealed class Class330
	{
		// Token: 0x06000F57 RID: 3927 RVA: 0x00042608 File Offset: 0x00040808
		internal void method_0()
		{
			Class735 item = new Class735
			{
				Name = this.process_0.ProcessName,
				ExeName = this.process_0.ProcessName,
				ExeDir = this.process_0.MainModule.FileName,
				FoundIn = string.Empty
			};
			this.class727_0.GMXAddAppsVMs.Add(item);
		}

		// Token: 0x04000960 RID: 2400
		public Process process_0;

		// Token: 0x04000961 RID: 2401
		public Class727 class727_0;
	}

	// Token: 0x02000299 RID: 665
	private sealed class Class331
	{
		// Token: 0x04000962 RID: 2402
		public ObservableCollection<Class738> observableCollection_0;

		// Token: 0x04000963 RID: 2403
		public RegistryKey registryKey_0;

		// Token: 0x04000964 RID: 2404
		public Class727 class727_0;
	}

	// Token: 0x0200029A RID: 666
	private sealed class Class332
	{
		// Token: 0x04000965 RID: 2405
		public string string_0;

		// Token: 0x04000966 RID: 2406
		public Class727.Class331 class331_0;
	}

	// Token: 0x0200029B RID: 667
	[StructLayout(LayoutKind.Auto)]
	private struct Struct140 : IAsyncStateMachine
	{
		// Token: 0x06000F5A RID: 3930 RVA: 0x00042680 File Offset: 0x00040880
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class727 @class = this.class727_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.bool_0 = true;
					awaiter = Task.Run(new Action(@class.method_6)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class727.Struct140>(ref awaiter, ref this);
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

		// Token: 0x06000F5B RID: 3931 RVA: 0x0004274C File Offset: 0x0004094C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000967 RID: 2407
		public int int_0;

		// Token: 0x04000968 RID: 2408
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000969 RID: 2409
		public Class727 class727_0;

		// Token: 0x0400096A RID: 2410
		private TaskAwaiter taskAwaiter_0;
	}
}
