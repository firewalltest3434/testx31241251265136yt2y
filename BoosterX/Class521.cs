using System;
using System.IO;
using Microsoft.Win32;
using ns0;

// Token: 0x020002C4 RID: 708
internal sealed class Class521 : GClass131
{
	// Token: 0x06001051 RID: 4177 RVA: 0x00045324 File Offset: 0x00043524
	public Class521(Class720 class720_1)
	{
		this.class720_0 = class720_1;
	}

	// Token: 0x06001052 RID: 4178 RVA: 0x00045334 File Offset: 0x00043534
	protected override void RunFunction(object argument)
	{
		string a = (string)argument;
		if (a == "Disable")
		{
			base.imethod_1(Class364.smethod_0("Disabling") + " " + this.class720_0.Name, (GEnum93)0);
			if (this.class720_0.Type == dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd.Registry)
			{
				Class185.smethod_22(string.Concat(new string[]
				{
					"reg add \"",
					this.class720_0.Path,
					"\\AutorunsDisabled\" /v \"",
					this.class720_0.Name,
					"\" /t REG_SZ /d \"",
					this.class720_0.Runs,
					"\" /f"
				}));
				Class185.smethod_22(string.Concat(new string[]
				{
					"reg delete \"",
					this.class720_0.Path,
					"\" /v \"",
					this.class720_0.Name,
					"\" /f"
				}));
				return;
			}
			if (this.class720_0.Type == dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd.File)
			{
				string text = this.class720_0.Path + "\\AutorunsDisabled\\";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				new DirectoryInfo(text).Attributes |= FileAttributes.Hidden;
				File.Move(this.class720_0.Path + "\\" + this.class720_0.Name, text + this.class720_0.Name);
				return;
			}
			if (this.class720_0.Type == dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd.Service)
			{
				Class185.smethod_22(string.Format("reg add \"{0}\" /v \"AutorunsDisabled\" /t REG_DWORD /d \"{1}\" /f", this.class720_0.Path, Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\" + this.class720_0.Name).GetValue("Start")));
				Class185.smethod_22("reg add \"" + this.class720_0.Path + "\" /v \"Start\" /t REG_DWORD /d \"4\" /f");
				Class185.smethod_22("sc stop \"" + this.class720_0.Name + "\"");
				return;
			}
			if (this.class720_0.Path.StartsWith("\\"))
			{
				Class185.smethod_22("schtasks /Change /TN \"" + this.class720_0.Path + "\" /Disable");
				return;
			}
			Class185.smethod_22("schtasks /Change /TN \"\\" + this.class720_0.Path + "\" /Disable");
			return;
		}
		else if (a == "Enable")
		{
			base.imethod_1(Class364.smethod_0("Enabling") + " " + this.class720_0.Name, (GEnum93)0);
			if (this.class720_0.Type == dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd.Registry)
			{
				string text2 = this.class720_0.Path.Remove(this.class720_0.Path.Length - 17);
				Class185.smethod_22(string.Concat(new string[]
				{
					"reg add \"",
					text2,
					"\" /v \"",
					this.class720_0.Name,
					"\" /t REG_SZ /d \"",
					this.class720_0.Runs,
					"\" /f"
				}));
				Class185.smethod_22(string.Concat(new string[]
				{
					"reg delete \"",
					this.class720_0.Path,
					"\" /v \"",
					this.class720_0.Name,
					"\" /f"
				}));
				return;
			}
			if (this.class720_0.Type == dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd.File)
			{
				File.Move(this.class720_0.Path + "\\" + this.class720_0.Name, this.class720_0.Path.Replace("\\AutorunsDisabled", string.Empty) + "\\" + this.class720_0.Name);
				return;
			}
			if (this.class720_0.Type == dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd.Service)
			{
				try
				{
					Class185.smethod_22(string.Format("reg add \"{0}\" /v \"Start\" /t REG_DWORD /d \"{1}\" /f", this.class720_0.Path, Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\" + this.class720_0.Name).GetValue("AutorunsDisabled")));
				}
				catch
				{
					Class185.smethod_22("reg add \"" + this.class720_0.Path + "\" /v \"Start\" /t REG_SZ /d \"2\" /f");
				}
				Class185.smethod_22("reg delete \"" + this.class720_0.Path + "\" /v \"AutorunsDisabled\" /f");
				return;
			}
			if (this.class720_0.Path.StartsWith("\\"))
			{
				Class185.smethod_22("schtasks /Change /TN \"" + this.class720_0.Path + "\" /Enable");
				return;
			}
			Class185.smethod_22("schtasks /Change /TN \"\\" + this.class720_0.Path + "\" /Enable");
			return;
		}
		else
		{
			base.imethod_1(Class364.smethod_0("Deleting") + " " + this.class720_0.Name, (GEnum93)0);
			if (this.class720_0.Type == dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd.Registry)
			{
				Class185.smethod_22(string.Concat(new string[]
				{
					"reg delete \"",
					this.class720_0.Path,
					"\" /v \"",
					this.class720_0.Name,
					"\" /f"
				}));
				return;
			}
			if (this.class720_0.Type == dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd.File)
			{
				Class185.smethod_22(string.Concat(new string[]
				{
					"del /f \"",
					this.class720_0.Path,
					"\\",
					this.class720_0.Name,
					"\""
				}));
				return;
			}
			if (this.class720_0.Type == dje_zQQ8PAQK69CSBPJ5AVCVULES665YRQ4MK2CQJEA7JTNN29TCK4JVCEMDPVSG6B9PSDW_ejd.Service)
			{
				Class185.smethod_22("net stop " + this.class720_0.Name + " & sc delete " + this.class720_0.Name);
				return;
			}
			if (this.class720_0.Path.StartsWith("\\"))
			{
				Class185.smethod_22("schtasks /Delete /TN \"" + this.class720_0.Path + "\" /F");
				return;
			}
			Class185.smethod_22("schtasks /Delete /TN \"\\" + this.class720_0.Path + "\" /F");
			return;
		}
	}

	// Token: 0x040009C0 RID: 2496
	private Class720 class720_0;
}
