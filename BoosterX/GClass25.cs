using System;
using System.Text;
using System.Threading;
using Microsoft.Win32;

// Token: 0x020004AB RID: 1195
public sealed class GClass25 : GClass24
{
	// Token: 0x06001A4E RID: 6734 RVA: 0x0006C3BC File Offset: 0x0006A5BC
	public GClass25(GClass54 gclass54_0 = null)
	{
		gclass54_0 = (gclass54_0 ?? new GClass54(true, false));
		if (this.ginterface3_0.imethod_2(gclass54_0.method_0()) != 0U)
		{
			throw new Exception("Unable to open local machine GPO");
		}
		this.bool_0 = true;
	}

	// Token: 0x06001A4F RID: 6735 RVA: 0x0006C3FC File Offset: 0x0006A5FC
	public GClass25(string string_0, GClass54 gclass54_0 = null)
	{
		gclass54_0 = (gclass54_0 ?? new GClass54(true, false));
		if (this.ginterface3_0.imethod_3(string_0, gclass54_0.method_0()) != 0U)
		{
			throw new Exception(string.Format("Unable to open GPO on remote machine '{0}'", string_0));
		}
		this.bool_0 = false;
	}

	// Token: 0x06001A50 RID: 6736 RVA: 0x0006C44C File Offset: 0x0006A64C
	public static void smethod_2(string string_0, string string_1, RegistryValueKind registryValueKind_0)
	{
		GClass25.Class563 @class = new GClass25.Class563();
		@class.string_0 = string_1;
		@class.registryValueKind_0 = registryValueKind_0;
		@class.string_1 = GClass25.smethod_4(string_0, out @class.string_2, out @class.groupPolicySection_0);
		@class.exception_0 = null;
		Thread thread = new Thread(new ThreadStart(@class.method_0));
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		thread.Join();
		if (@class.exception_0 != null)
		{
			throw @class.exception_0;
		}
	}

	// Token: 0x06001A51 RID: 6737 RVA: 0x0006C4C0 File Offset: 0x0006A6C0
	public static object smethod_3(string string_0)
	{
		GClass25.Class562 @class = new GClass25.Class562();
		@class.string_0 = GClass25.smethod_4(string_0, out @class.string_1, out @class.groupPolicySection_0);
		@class.object_0 = null;
		Thread thread = new Thread(new ThreadStart(@class.method_0));
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		thread.Join();
		return @class.object_0;
	}

	// Token: 0x06001A52 RID: 6738 RVA: 0x0006C51C File Offset: 0x0006A71C
	private static string smethod_4(string string_0, out string string_1, out GroupPolicySection groupPolicySection_0)
	{
		string[] array = string_0.Split(new char[]
		{
			'!'
		});
		string text = array[0];
		string text2 = text.Substring(0, text.IndexOf('\\'));
		text = text.Substring(text.IndexOf('\\') + 1);
		string_1 = array[1];
		if (!text2.Equals("HKLM", StringComparison.OrdinalIgnoreCase) && !text2.Equals("HKEY_LOCAL_MACHINE", StringComparison.OrdinalIgnoreCase))
		{
			groupPolicySection_0 = GroupPolicySection.User;
		}
		else
		{
			groupPolicySection_0 = GroupPolicySection.Machine;
		}
		return text;
	}

	// Token: 0x06001A53 RID: 6739 RVA: 0x0006C58C File Offset: 0x0006A78C
	public override string vmethod_0(GroupPolicySection groupPolicySection_0)
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		if (this.ginterface3_0.imethod_11((uint)groupPolicySection_0, stringBuilder, 1024) != 0U)
		{
			throw new Exception(string.Format("Unable to retrieve path to section '{0}'", Enum.GetName(typeof(GroupPolicySection), groupPolicySection_0)));
		}
		return stringBuilder.ToString();
	}

	// Token: 0x04001279 RID: 4729
	public readonly bool bool_0;

	// Token: 0x020004AC RID: 1196
	private sealed class Class562
	{
		// Token: 0x06001A55 RID: 6741 RVA: 0x0006C5EC File Offset: 0x0006A7EC
		internal void method_0()
		{
			using (RegistryKey registryKey = new GClass25(null).method_2(this.groupPolicySection_0))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(this.string_0, true))
				{
					if (registryKey2 == null)
					{
						this.object_0 = null;
					}
					else
					{
						this.object_0 = registryKey2.GetValue(this.string_1);
					}
				}
			}
		}

		// Token: 0x0400127A RID: 4730
		public GroupPolicySection groupPolicySection_0;

		// Token: 0x0400127B RID: 4731
		public string string_0;

		// Token: 0x0400127C RID: 4732
		public object object_0;

		// Token: 0x0400127D RID: 4733
		public string string_1;
	}

	// Token: 0x020004AD RID: 1197
	private sealed class Class563
	{
		// Token: 0x06001A57 RID: 6743 RVA: 0x0006C674 File Offset: 0x0006A874
		internal void method_0()
		{
			try
			{
				GClass25 gclass = new GClass25(null);
				using (RegistryKey registryKey = gclass.method_2(this.groupPolicySection_0))
				{
					if (this.string_0 == null)
					{
						using (RegistryKey registryKey2 = registryKey.OpenSubKey(this.string_1, true))
						{
							if (registryKey2 != null)
							{
								registryKey2.DeleteValue(this.string_2);
							}
							goto IL_76;
						}
					}
					using (RegistryKey registryKey3 = registryKey.CreateSubKey(this.string_1))
					{
						registryKey3.SetValue(this.string_2, this.string_0, this.registryValueKind_0);
					}
					IL_76:;
				}
				gclass.method_0();
			}
			catch (Exception ex)
			{
				this.exception_0 = ex;
			}
		}

		// Token: 0x0400127E RID: 4734
		public GroupPolicySection groupPolicySection_0;

		// Token: 0x0400127F RID: 4735
		public string string_0;

		// Token: 0x04001280 RID: 4736
		public string string_1;

		// Token: 0x04001281 RID: 4737
		public string string_2;

		// Token: 0x04001282 RID: 4738
		public RegistryValueKind registryValueKind_0;

		// Token: 0x04001283 RID: 4739
		public Exception exception_0;
	}
}
