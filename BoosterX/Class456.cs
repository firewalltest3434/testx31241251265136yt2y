using System;
using System.Management;

// Token: 0x020003E3 RID: 995
internal sealed class Class456
{
	// Token: 0x060015E2 RID: 5602 RVA: 0x0005C170 File Offset: 0x0005A370
	public static bool smethod_0()
	{
		bool result = false;
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
			try
			{
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					object obj = ((ManagementObject)managementBaseObject)["Name"];
					if (obj == null)
					{
						goto IL_5F;
					}
					string text = obj.ToString();
					if (text == null)
					{
						goto IL_5F;
					}
					string text2;
					if ((text2 = text.ToLowerInvariant()) == null)
					{
						goto IL_5F;
					}
					IL_65:
					if (!text2.Contains("nvidia"))
					{
						continue;
					}
					result = true;
					break;
					IL_5F:
					text2 = string.Empty;
					goto IL_65;
				}
			}
			finally
			{
				((IDisposable)managementObjectSearcher).Dispose();
			}
		}
		catch (ManagementException exception_)
		{
			GClass141.smethod_0(exception_);
		}
		return result;
	}
}
