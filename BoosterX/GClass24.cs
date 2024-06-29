using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

// Token: 0x02000189 RID: 393
public abstract class GClass24
{
	// Token: 0x06000A08 RID: 2568 RVA: 0x0002DE40 File Offset: 0x0002C040
	internal GClass24()
	{
		this.ginterface3_0 = GClass24.smethod_1();
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x0002DEB4 File Offset: 0x0002C0B4
	private static T smethod_0<T>(ICustomAttributeProvider icustomAttributeProvider_0) where T : Attribute
	{
		try
		{
			object[] customAttributes = icustomAttributeProvider_0.GetCustomAttributes(typeof(T), true);
			if (customAttributes.Length == 0)
			{
				return default(T);
			}
			return (T)((object)customAttributes[0]);
		}
		catch (object obj)
		{
		}
		return default(T);
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x0002DF0C File Offset: 0x0002C10C
	public void method_0()
	{
		if (this.ginterface3_0.imethod_4(true, true, GClass24.guid_0, GClass24.guid_1) != 0U)
		{
			throw new Exception("Error saving machine settings");
		}
		if (this.ginterface3_0.imethod_4(false, true, GClass24.guid_0, GClass24.guid_1) != 0U)
		{
			throw new Exception("Error saving user settings");
		}
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x0002DF64 File Offset: 0x0002C164
	public void method_1()
	{
		if (this.ginterface3_0.imethod_5() != 0U)
		{
			throw new Exception("Error deleting the GPO");
		}
		this.ginterface3_0 = null;
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x0002DF88 File Offset: 0x0002C188
	public RegistryKey method_2(GroupPolicySection groupPolicySection_0)
	{
		IntPtr preexistingHandle;
		if (this.ginterface3_0.imethod_12((uint)groupPolicySection_0, out preexistingHandle) != 0U)
		{
			throw new Exception(string.Format("Unable to get section '{0}'", Enum.GetName(typeof(GroupPolicySection), groupPolicySection_0)));
		}
		return RegistryKey.FromHandle(new SafeRegistryHandle(preexistingHandle, true), RegistryView.Default);
	}

	// Token: 0x06000A0E RID: 2574
	public abstract string vmethod_0(GroupPolicySection groupPolicySection_0);

	// Token: 0x06000A0F RID: 2575 RVA: 0x0002DFD8 File Offset: 0x0002C1D8
	protected static GInterface3 smethod_1()
	{
		return (GInterface3)new Class645();
	}

	// Token: 0x040005DB RID: 1499
	private static readonly Guid guid_0 = new Guid(892833452, 26687, 4562, 168, 154, 0, 192, 79, 187, 207, 162);

	// Token: 0x040005DC RID: 1500
	private static readonly Guid guid_1 = new Guid(GClass24.smethod_0<GuidAttribute>(Assembly.GetExecutingAssembly()).Value);

	// Token: 0x040005DD RID: 1501
	protected GInterface3 ginterface3_0;
}
