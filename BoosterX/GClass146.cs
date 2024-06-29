using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Management.Automation;
using System.Runtime.CompilerServices;

// Token: 0x020004CD RID: 1229
public static class GClass146
{
	// Token: 0x06001AED RID: 6893 RVA: 0x0006EF3C File Offset: 0x0006D13C
	public static List<GClass146.GClass148> smethod_0()
	{
		List<GClass146.GClass148> result;
		using (PowerShell powerShell = PowerShell.Create())
		{
			GClass146.Class575 @class = new GClass146.Class575();
			@class.list_0 = GClass146.smethod_1();
			powerShell.AddScript("Get-AppxPackage");
			result = powerShell.Invoke().ToList<PSObject>().FindAll(new Predicate<PSObject>(GClass146.Class573.class573_0.method_0)).Select(new Func<PSObject, GClass146.GClass148>(@class.method_0)).ToList<GClass146.GClass148>();
		}
		return result;
	}

	// Token: 0x06001AEE RID: 6894 RVA: 0x0006EFD0 File Offset: 0x0006D1D0
	public static List<GClass146.GClass147> smethod_1()
	{
		List<GClass146.GClass147> result;
		using (PowerShell powerShell = PowerShell.Create())
		{
			powerShell.AddScript("[Windows.Management.Deployment.PackageManager,Windows.Web,ContentType=WindowsRuntime]::new().FindPackages() | Select-Object DisplayName -ExpandProperty Id");
			result = powerShell.Invoke().ToList<PSObject>().Select(new Func<PSObject, GClass146.GClass147>(GClass146.Class573.class573_0.method_1)).ToList<GClass146.GClass147>();
		}
		return result;
	}

	// Token: 0x06001AEF RID: 6895 RVA: 0x0006F044 File Offset: 0x0006D244
	public static void smethod_2()
	{
		using (PowerShell powerShell = PowerShell.Create())
		{
			powerShell.AddScript("help");
			powerShell.Invoke();
		}
	}

	// Token: 0x06001AF0 RID: 6896 RVA: 0x0006F088 File Offset: 0x0006D288
	public static void smethod_3(string string_0)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "powershell.exe",
				Arguments = string_0,
				WindowStyle = ProcessWindowStyle.Hidden
			});
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x06001AF1 RID: 6897 RVA: 0x0006F0D0 File Offset: 0x0006D2D0
	public static Collection<PSObject> smethod_4(string string_0)
	{
		Collection<PSObject> result;
		using (PowerShell powerShell = PowerShell.Create())
		{
			powerShell.AddScript(string_0);
			result = powerShell.Invoke();
		}
		return result;
	}

	// Token: 0x06001AF2 RID: 6898 RVA: 0x0006F110 File Offset: 0x0006D310
	public static void smethod_5(string string_0)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "powershell.exe",
				Arguments = string_0,
				Verb = "runas",
				WindowStyle = ProcessWindowStyle.Hidden
			}).WaitForExit();
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x020004CE RID: 1230
	public sealed class GClass147
	{
		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x0006F170 File Offset: 0x0006D370
		// (set) Token: 0x06001AF5 RID: 6901 RVA: 0x0006F178 File Offset: 0x0006D378
		public string FullName
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x0006F184 File Offset: 0x0006D384
		// (set) Token: 0x06001AF7 RID: 6903 RVA: 0x0006F18C File Offset: 0x0006D38C
		public string DisplayName
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x040012F6 RID: 4854
		private string string_0;

		// Token: 0x040012F7 RID: 4855
		private string string_1;
	}

	// Token: 0x020004CF RID: 1231
	public sealed class GClass148
	{
		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x0006F1A0 File Offset: 0x0006D3A0
		// (set) Token: 0x06001AFA RID: 6906 RVA: 0x0006F1A8 File Offset: 0x0006D3A8
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x0006F1B4 File Offset: 0x0006D3B4
		public string method_0()
		{
			return this.string_1;
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x0006F1BC File Offset: 0x0006D3BC
		public void method_1(string string_12)
		{
			this.string_1 = string_12;
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x0006F1C8 File Offset: 0x0006D3C8
		public string method_2()
		{
			return this.string_2;
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0006F1D0 File Offset: 0x0006D3D0
		public void method_3(string string_12)
		{
			this.string_2 = string_12;
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x0006F1DC File Offset: 0x0006D3DC
		public string method_4()
		{
			return this.string_3;
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0006F1E4 File Offset: 0x0006D3E4
		public void method_5(string string_12)
		{
			this.string_3 = string_12;
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x0006F1F0 File Offset: 0x0006D3F0
		public string method_6()
		{
			return this.string_4;
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x0006F1F8 File Offset: 0x0006D3F8
		public void method_7(string string_12)
		{
			this.string_4 = string_12;
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x0006F204 File Offset: 0x0006D404
		public string method_8()
		{
			return this.string_5;
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x0006F20C File Offset: 0x0006D40C
		public void method_9(string string_12)
		{
			this.string_5 = string_12;
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x0006F218 File Offset: 0x0006D418
		public string method_10()
		{
			return this.string_6;
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x0006F220 File Offset: 0x0006D420
		public void method_11(string string_12)
		{
			this.string_6 = string_12;
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x0006F22C File Offset: 0x0006D42C
		public bool method_12()
		{
			return this.bool_0;
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x0006F234 File Offset: 0x0006D434
		public void method_13(bool bool_6)
		{
			this.bool_0 = bool_6;
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x0006F240 File Offset: 0x0006D440
		public string method_14()
		{
			return this.string_7;
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x0006F248 File Offset: 0x0006D448
		public void method_15(string string_12)
		{
			this.string_7 = string_12;
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x0006F254 File Offset: 0x0006D454
		public string method_16()
		{
			return this.string_8;
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x0006F25C File Offset: 0x0006D45C
		public void method_17(string string_12)
		{
			this.string_8 = string_12;
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x0006F268 File Offset: 0x0006D468
		public bool method_18()
		{
			return this.bool_1;
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x0006F270 File Offset: 0x0006D470
		public void method_19(bool bool_6)
		{
			this.bool_1 = bool_6;
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x0006F27C File Offset: 0x0006D47C
		public bool method_20()
		{
			return this.bool_2;
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x0006F284 File Offset: 0x0006D484
		public void method_21(bool bool_6)
		{
			this.bool_2 = bool_6;
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x0006F290 File Offset: 0x0006D490
		public bool method_22()
		{
			return this.bool_3;
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x0006F298 File Offset: 0x0006D498
		public void method_23(bool bool_6)
		{
			this.bool_3 = bool_6;
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x0006F2A4 File Offset: 0x0006D4A4
		public bool method_24()
		{
			return this.bool_4;
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x0006F2AC File Offset: 0x0006D4AC
		public void method_25(bool bool_6)
		{
			this.bool_4 = bool_6;
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x0006F2B8 File Offset: 0x0006D4B8
		public bool method_26()
		{
			return this.bool_5;
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x0006F2C0 File Offset: 0x0006D4C0
		public void method_27(bool bool_6)
		{
			this.bool_5 = bool_6;
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x0006F2CC File Offset: 0x0006D4CC
		public string method_28()
		{
			return this.string_9;
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x0006F2D4 File Offset: 0x0006D4D4
		public void method_29(string string_12)
		{
			this.string_9 = string_12;
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x0006F2E0 File Offset: 0x0006D4E0
		// (set) Token: 0x06001B1A RID: 6938 RVA: 0x0006F2E8 File Offset: 0x0006D4E8
		public string Status
		{
			[CompilerGenerated]
			get
			{
				return this.string_10;
			}
			[CompilerGenerated]
			set
			{
				this.string_10 = value;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x0006F2F4 File Offset: 0x0006D4F4
		// (set) Token: 0x06001B1C RID: 6940 RVA: 0x0006F2FC File Offset: 0x0006D4FC
		public string DisplayName
		{
			[CompilerGenerated]
			get
			{
				return this.string_11;
			}
			[CompilerGenerated]
			set
			{
				this.string_11 = value;
			}
		}

		// Token: 0x040012F8 RID: 4856
		private string string_0;

		// Token: 0x040012F9 RID: 4857
		private string string_1;

		// Token: 0x040012FA RID: 4858
		private string string_2;

		// Token: 0x040012FB RID: 4859
		private string string_3;

		// Token: 0x040012FC RID: 4860
		private string string_4;

		// Token: 0x040012FD RID: 4861
		private string string_5;

		// Token: 0x040012FE RID: 4862
		private string string_6;

		// Token: 0x040012FF RID: 4863
		private bool bool_0;

		// Token: 0x04001300 RID: 4864
		private string string_7;

		// Token: 0x04001301 RID: 4865
		private string string_8;

		// Token: 0x04001302 RID: 4866
		private bool bool_1;

		// Token: 0x04001303 RID: 4867
		private bool bool_2;

		// Token: 0x04001304 RID: 4868
		private bool bool_3;

		// Token: 0x04001305 RID: 4869
		private bool bool_4;

		// Token: 0x04001306 RID: 4870
		private bool bool_5;

		// Token: 0x04001307 RID: 4871
		private string string_9;

		// Token: 0x04001308 RID: 4872
		private string string_10;

		// Token: 0x04001309 RID: 4873
		private string string_11;
	}

	// Token: 0x020004D0 RID: 1232
	[Serializable]
	private sealed class Class573
	{
		// Token: 0x06001B1F RID: 6943 RVA: 0x0006F31C File Offset: 0x0006D51C
		internal bool method_0(PSObject psobject_0)
		{
			PSPropertyInfo pspropertyInfo = psobject_0.Properties["SignatureKind"];
			return ((pspropertyInfo != null) ? pspropertyInfo.Value.ToString().ToLower() : null) != "system";
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x0006F354 File Offset: 0x0006D554
		internal GClass146.GClass147 method_1(PSObject psobject_0)
		{
			GClass146.GClass147 result;
			try
			{
				GClass146.GClass147 gclass = new GClass146.GClass147();
				PSPropertyInfo pspropertyInfo = psobject_0.Properties["DisplayName"];
				gclass.DisplayName = ((pspropertyInfo != null) ? pspropertyInfo.Value.ToString() : null);
				PSPropertyInfo pspropertyInfo2 = psobject_0.Properties["FullName"];
				gclass.FullName = ((pspropertyInfo2 != null) ? pspropertyInfo2.Value.ToString() : null);
				result = gclass;
			}
			catch
			{
				GClass146.GClass147 gclass2 = new GClass146.GClass147();
				gclass2.DisplayName = null;
				PSPropertyInfo pspropertyInfo3 = psobject_0.Properties["FullName"];
				gclass2.FullName = ((pspropertyInfo3 != null) ? pspropertyInfo3.Value.ToString() : null);
				result = gclass2;
			}
			return result;
		}

		// Token: 0x0400130A RID: 4874
		public static readonly GClass146.Class573 class573_0 = new GClass146.Class573();

		// Token: 0x0400130B RID: 4875
		public static Predicate<PSObject> predicate_0;

		// Token: 0x0400130C RID: 4876
		public static Func<PSObject, GClass146.GClass147> func_0;
	}

	// Token: 0x020004D1 RID: 1233
	private sealed class Class574
	{
		// Token: 0x06001B22 RID: 6946 RVA: 0x0006F408 File Offset: 0x0006D608
		internal bool method_0(GClass146.GClass147 gclass147_0)
		{
			string fullName = gclass147_0.FullName;
			PSPropertyInfo pspropertyInfo = this.psobject_0.Properties["PackageFullName"];
			return fullName == ((pspropertyInfo != null) ? pspropertyInfo.Value.ToString() : null);
		}

		// Token: 0x0400130D RID: 4877
		public PSObject psobject_0;
	}

	// Token: 0x020004D2 RID: 1234
	private sealed class Class575
	{
		// Token: 0x06001B24 RID: 6948 RVA: 0x0006F444 File Offset: 0x0006D644
		internal GClass146.GClass148 method_0(PSObject psobject_0)
		{
			GClass146.Class574 @class = new GClass146.Class574();
			@class.psobject_0 = psobject_0;
			GClass146.GClass148 gclass = new GClass146.GClass148();
			GClass146.GClass148 gclass2 = gclass;
			PSPropertyInfo pspropertyInfo = @class.psobject_0.Properties["Name"];
			gclass2.Name = ((pspropertyInfo != null) ? pspropertyInfo.Value.ToString() : null);
			GClass146.GClass148 gclass3 = gclass;
			PSPropertyInfo pspropertyInfo2 = @class.psobject_0.Properties["Publisher"];
			gclass3.method_1((pspropertyInfo2 != null) ? pspropertyInfo2.Value.ToString() : null);
			GClass146.GClass148 gclass4 = gclass;
			PSPropertyInfo pspropertyInfo3 = @class.psobject_0.Properties["Architecture"];
			gclass4.method_3((pspropertyInfo3 != null) ? pspropertyInfo3.Value.ToString() : null);
			GClass146.GClass148 gclass5 = gclass;
			PSPropertyInfo pspropertyInfo4 = @class.psobject_0.Properties["Version"];
			gclass5.method_7((pspropertyInfo4 != null) ? pspropertyInfo4.Value.ToString() : null);
			GClass146.GClass148 gclass6 = gclass;
			PSPropertyInfo pspropertyInfo5 = @class.psobject_0.Properties["PackageFullName"];
			gclass6.method_9((pspropertyInfo5 != null) ? pspropertyInfo5.Value.ToString() : null);
			try
			{
				GClass146.GClass148 gclass7 = gclass;
				PSPropertyInfo pspropertyInfo6 = @class.psobject_0.Properties["InstallLocation"];
				gclass7.method_11((pspropertyInfo6 != null) ? pspropertyInfo6.Value.ToString() : null);
			}
			catch
			{
				gclass.method_11(null);
			}
			GClass146.GClass148 gclass8 = gclass;
			PSPropertyInfo pspropertyInfo7 = @class.psobject_0.Properties["IsFramework"];
			gclass8.method_13(((pspropertyInfo7 != null) ? pspropertyInfo7.Value.ToString().ToLower() : null) == "true");
			GClass146.GClass148 gclass9 = gclass;
			PSPropertyInfo pspropertyInfo8 = @class.psobject_0.Properties["PackageFamilyName"];
			gclass9.method_15((pspropertyInfo8 != null) ? pspropertyInfo8.Value.ToString() : null);
			GClass146.GClass148 gclass10 = gclass;
			PSPropertyInfo pspropertyInfo9 = @class.psobject_0.Properties["PublisherId"];
			gclass10.method_17((pspropertyInfo9 != null) ? pspropertyInfo9.Value.ToString() : null);
			GClass146.GClass148 gclass11 = gclass;
			PSPropertyInfo pspropertyInfo10 = @class.psobject_0.Properties["IsResourcePackage"];
			gclass11.method_19(((pspropertyInfo10 != null) ? pspropertyInfo10.Value.ToString().ToLower() : null) == "true");
			GClass146.GClass148 gclass12 = gclass;
			PSPropertyInfo pspropertyInfo11 = @class.psobject_0.Properties["IsBundle"];
			gclass12.method_21(((pspropertyInfo11 != null) ? pspropertyInfo11.Value.ToString().ToLower() : null) == "true");
			GClass146.GClass148 gclass13 = gclass;
			PSPropertyInfo pspropertyInfo12 = @class.psobject_0.Properties["IsDevelopmentMode"];
			gclass13.method_23(((pspropertyInfo12 != null) ? pspropertyInfo12.Value.ToString().ToLower() : null) == "true");
			GClass146.GClass148 gclass14 = gclass;
			PSPropertyInfo pspropertyInfo13 = @class.psobject_0.Properties["NonRemovable"];
			gclass14.method_25(((pspropertyInfo13 != null) ? pspropertyInfo13.Value.ToString().ToLower() : null) == "true");
			GClass146.GClass148 gclass15 = gclass;
			PSPropertyInfo pspropertyInfo14 = @class.psobject_0.Properties["IsPartiallyStaged"];
			gclass15.method_27(((pspropertyInfo14 != null) ? pspropertyInfo14.Value.ToString().ToLower() : null) == "true");
			GClass146.GClass148 gclass16 = gclass;
			PSPropertyInfo pspropertyInfo15 = @class.psobject_0.Properties["SignatureKind"];
			gclass16.method_29((pspropertyInfo15 != null) ? pspropertyInfo15.Value.ToString() : null);
			GClass146.GClass148 gclass17 = gclass;
			PSPropertyInfo pspropertyInfo16 = @class.psobject_0.Properties["Status"];
			gclass17.Status = ((pspropertyInfo16 != null) ? pspropertyInfo16.Value.ToString() : null);
			GClass146.GClass147 gclass18 = null;
			try
			{
				gclass18 = this.list_0.First(new Func<GClass146.GClass147, bool>(@class.method_0));
			}
			catch (object obj)
			{
			}
			gclass.DisplayName = ((gclass18 != null) ? (gclass18.DisplayName ?? gclass.Name) : gclass.Name);
			return gclass;
		}

		// Token: 0x0400130E RID: 4878
		public List<GClass146.GClass147> list_0;
	}
}
