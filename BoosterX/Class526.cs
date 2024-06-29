using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BoosterX.Classes.Tweaks.CleanerModel;
using Microsoft.Win32;

// Token: 0x020005EB RID: 1515
internal sealed class Class526 : GClass131
{
	// Token: 0x060020FF RID: 8447 RVA: 0x00085C98 File Offset: 0x00083E98
	protected override void RunFunction(object argument)
	{
		if (argument.ToString() == "RegistryClean")
		{
			foreach (string text in Class186.string_14)
			{
				try
				{
					foreach (string text2 in Registry.CurrentUser.OpenSubKey(text).GetValueNames())
					{
						Class185.smethod_22(string.Concat(new string[]
						{
							"reg delete \"HKCU\\",
							text,
							"\" /v \"",
							text2,
							"\" /f"
						}));
					}
				}
				catch (object obj)
				{
				}
			}
			foreach (string text3 in Class186.string_15)
			{
				try
				{
					foreach (string text4 in Registry.CurrentUser.OpenSubKey(text3).GetValueNames())
					{
						Class185.smethod_22(string.Concat(new string[]
						{
							"reg delete \"HKLM\\",
							text3,
							"\" /v \"",
							text4,
							"\" /f"
						}));
					}
				}
				catch (object obj2)
				{
				}
			}
		}
		if (argument.GetType() == typeof(Class750))
		{
			Class526.Class676 @class = new Class526.Class676();
			@class.class750_0 = (argument as Class750);
			base.imethod_1(Class364.smethod_0("Deleting") + " " + @class.class750_0.Name, (GEnum93)0);
			try
			{
				Directory.GetDirectories("C:\\Program Files\\WindowsApps").Where(new Func<string, bool>(@class.method_0)).ToList<string>().ForEach(new Action<string>(this.method_6));
			}
			catch (object obj3)
			{
			}
		}
		if (argument.GetType() == typeof(Class722))
		{
			Class722 class2 = argument as Class722;
			base.imethod_1(Class364.smethod_0("Deleting") + " " + class2.Name, (GEnum93)0);
			Class694.smethod_4(class2.Id);
		}
		if (argument.GetType() == typeof(JsonCleanDto))
		{
			Class526.Class677 class3 = new Class526.Class677();
			class3.class526_0 = this;
			class3.jsonCleanDto_0 = (JsonCleanDto)argument;
			try
			{
				class3.jsonCleanDto_0.Paths.ForEach(new Action<string>(class3.method_0));
			}
			catch (object obj4)
			{
			}
		}
	}

	// Token: 0x06002100 RID: 8448 RVA: 0x00085F44 File Offset: 0x00084144
	private void method_6(string string_2)
	{
		Class650.smethod_16(this.string_1, "rmdir /s /q \"" + string_2 + "\"", null);
	}

	// Token: 0x06002101 RID: 8449 RVA: 0x00085F64 File Offset: 0x00084164
	private void method_7(string string_2)
	{
		Directory.GetFiles(string_2).ToList<string>().ForEach(new Action<string>(this.method_8));
		Directory.GetDirectories(string_2).ToList<string>().ForEach(new Action<string>(this.method_9));
	}

	// Token: 0x06002102 RID: 8450 RVA: 0x00085FA0 File Offset: 0x000841A0
	private void method_8(string string_2)
	{
		Class650.smethod_16(this.string_1, "del /s /f /q \"" + string_2 + "\"", null);
	}

	// Token: 0x06002103 RID: 8451 RVA: 0x00085FC0 File Offset: 0x000841C0
	private void method_9(string string_2)
	{
		this.method_7(string_2);
	}

	// Token: 0x06002104 RID: 8452 RVA: 0x00085FCC File Offset: 0x000841CC
	private void method_10(string string_2)
	{
		this.method_7(string_2);
	}

	// Token: 0x040016C2 RID: 5826
	private string string_1 = Class186.string_4 + "\\UninstallBat.bat";

	// Token: 0x020005EC RID: 1516
	private sealed class Class676
	{
		// Token: 0x06002106 RID: 8454 RVA: 0x00085FE0 File Offset: 0x000841E0
		internal bool method_0(string string_0)
		{
			return string_0.Split(new char[]
			{
				'\\'
			}).Last<string>().StartsWith(this.class750_0.Name);
		}

		// Token: 0x040016C3 RID: 5827
		public Class750 class750_0;
	}

	// Token: 0x020005ED RID: 1517
	private sealed class Class677
	{
		// Token: 0x06002108 RID: 8456 RVA: 0x00086010 File Offset: 0x00084210
		internal void method_0(string string_0)
		{
			Class526.Class679 @class = new Class526.Class679();
			@class.class677_0 = this;
			@class.list_0 = new List<string>();
			string text = string_0.Replace("%username%", Environment.UserName);
			if (text.StartsWith("?:\\"))
			{
				foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
				{
					@class.list_0.Add(text.Replace("?:\\", driveInfo.Name));
				}
			}
			else
			{
				@class.list_0.Add(text);
			}
			this.jsonCleanDto_0.SearchPattern.Split(new char[]
			{
				'\\'
			}).ToList<string>().ForEach(new Action<string>(@class.method_0));
		}

		// Token: 0x040016C4 RID: 5828
		public JsonCleanDto jsonCleanDto_0;

		// Token: 0x040016C5 RID: 5829
		public Class526 class526_0;
	}

	// Token: 0x020005EE RID: 1518
	private sealed class Class678
	{
		// Token: 0x0600210A RID: 8458 RVA: 0x000860E0 File Offset: 0x000842E0
		internal void method_0(string string_1)
		{
			if (this.class679_0.class677_0.jsonCleanDto_0.IncludeInsideFolders)
			{
				if (this.string_0 == "*.*")
				{
					try
					{
						Directory.GetDirectories(string_1).ToList<string>().ForEach(new Action<string>(this.class679_0.class677_0.class526_0.method_10));
						goto IL_A3;
					}
					catch (object obj)
					{
						goto IL_A3;
					}
				}
				try
				{
					List<string> list = Directory.GetDirectories(string_1).ToList<string>();
					Action<string> action;
					if ((action = this.action_0) == null)
					{
						action = (this.action_0 = new Action<string>(this.method_1));
					}
					list.ForEach(action);
				}
				catch (object obj2)
				{
				}
			}
			IL_A3:
			Class650.smethod_16(this.class679_0.class677_0.class526_0.string_1, string.Concat(new string[]
			{
				"del /s /f /q \"",
				string_1,
				"\\",
				this.string_0,
				"\""
			}), null);
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x000861F8 File Offset: 0x000843F8
		internal void method_1(string string_1)
		{
			Class650.smethod_16(this.class679_0.class677_0.class526_0.string_1, string.Concat(new string[]
			{
				"del /s /f /q \"",
				string_1,
				"\\",
				this.string_0,
				"\""
			}), null);
		}

		// Token: 0x040016C6 RID: 5830
		public string string_0;

		// Token: 0x040016C7 RID: 5831
		public Class526.Class679 class679_0;

		// Token: 0x040016C8 RID: 5832
		public Action<string> action_0;
	}

	// Token: 0x020005EF RID: 1519
	private sealed class Class679
	{
		// Token: 0x0600210D RID: 8461 RVA: 0x00086258 File Offset: 0x00084458
		internal void method_0(string string_0)
		{
			Class526.Class678 @class = new Class526.Class678();
			@class.class679_0 = this;
			@class.string_0 = string_0;
			this.list_0.ForEach(new Action<string>(@class.method_0));
		}

		// Token: 0x040016C9 RID: 5833
		public List<string> list_0;

		// Token: 0x040016CA RID: 5834
		public Class526.Class677 class677_0;
	}
}
