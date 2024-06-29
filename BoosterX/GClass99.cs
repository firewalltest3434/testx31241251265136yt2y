using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000330 RID: 816
public sealed class GClass99
{
	// Token: 0x0600128D RID: 4749 RVA: 0x0004C934 File Offset: 0x0004AB34
	public List<GStruct5> method_0()
	{
		List<GStruct5> list = new List<GStruct5>();
		try
		{
			Guid empty = Guid.Empty;
			IntPtr intptr_ = dje_zQE7X9KAD45FPNM2_ejd.SetupDiGetClassDevs(ref empty, 0U, IntPtr.Zero, 6U);
			if (intptr_.ToInt64() == -1L)
			{
				throw new Exception("Invalid Handle");
			}
			dje_zQE7X9KAD45FPNM2_ejd.GClass231 gclass = new dje_zQE7X9KAD45FPNM2_ejd.GClass231();
			if (IntPtr.Size == 4)
			{
				gclass.int_0 = 28;
			}
			else if (IntPtr.Size == 8)
			{
				gclass.int_0 = 32;
			}
			gclass.uint_0 = 0U;
			gclass.guid_0 = Guid.Empty;
			gclass.ulong_0 = 0UL;
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = new StringBuilder();
			StringBuilder stringBuilder3 = new StringBuilder();
			StringBuilder stringBuilder4 = stringBuilder;
			StringBuilder stringBuilder5 = stringBuilder2;
			stringBuilder3.Capacity = 1000;
			stringBuilder5.Capacity = 1000;
			stringBuilder4.Capacity = 1000;
			uint num = 0U;
			while (dje_zQE7X9KAD45FPNM2_ejd.SetupDiEnumDeviceInfo(intptr_, num, gclass))
			{
				try
				{
					StringBuilder stringBuilder6 = stringBuilder;
					StringBuilder stringBuilder7 = stringBuilder2;
					stringBuilder3.Length = 0;
					stringBuilder7.Length = 0;
					stringBuilder6.Length = 0;
					dje_zQE7X9KAD45FPNM2_ejd.SetupDiGetDeviceRegistryProperty(intptr_, gclass, 0U, 0U, stringBuilder, 1000U, IntPtr.Zero);
					dje_zQE7X9KAD45FPNM2_ejd.SetupDiGetDeviceRegistryProperty(intptr_, gclass, 12U, 0U, stringBuilder2, 1000U, IntPtr.Zero);
					dje_zQE7X9KAD45FPNM2_ejd.SetupDiGetDeviceRegistryProperty(intptr_, gclass, 1U, 0U, stringBuilder3, 1000U, IntPtr.Zero);
					string empty2 = string.Empty;
					string string_ = string.Empty;
					GEnum64 genum64_ = (GEnum64)0;
					uint num2;
					uint num3;
					if (dje_zQE7X9KAD45FPNM2_ejd.CM_Get_DevNode_Status(out num2, out num3, gclass.uint_0, 0) == 0)
					{
						genum64_ = (((num2 & 8U) > 0U) ? ((GEnum64)1) : ((GEnum64)2));
						string_ = num3.ToString();
					}
					list.Add(new GStruct5
					{
						string_0 = stringBuilder.ToString(),
						string_1 = stringBuilder2.ToString(),
						string_2 = stringBuilder3.ToString(),
						genum64_0 = genum64_,
						string_3 = empty2,
						string_4 = string_
					});
				}
				catch (object obj)
				{
				}
				num += 1U;
			}
			dje_zQE7X9KAD45FPNM2_ejd.SetupDiDestroyDeviceInfoList(intptr_);
		}
		catch (Exception innerException)
		{
			throw new Exception("Failed to enumerate device tree!", innerException);
		}
		return list;
	}

	// Token: 0x0600128E RID: 4750 RVA: 0x0004CB6C File Offset: 0x0004AD6C
	public bool method_1(GStruct5 gstruct5_0, bool bool_0)
	{
		Guid empty = Guid.Empty;
		IntPtr intptr_ = dje_zQE7X9KAD45FPNM2_ejd.SetupDiGetClassDevs(ref empty, 0U, IntPtr.Zero, 6U);
		if (intptr_.ToInt64() == -1L)
		{
			throw new Exception("Could retrieve handle for device");
		}
		dje_zQE7X9KAD45FPNM2_ejd.GClass231 gclass = new dje_zQE7X9KAD45FPNM2_ejd.GClass231();
		if (IntPtr.Size == 4)
		{
			gclass.int_0 = 28;
		}
		else if (IntPtr.Size == 8)
		{
			gclass.int_0 = 32;
		}
		gclass.uint_0 = 0U;
		gclass.guid_0 = Guid.Empty;
		gclass.ulong_0 = 0UL;
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		StringBuilder stringBuilder3 = stringBuilder;
		stringBuilder2.Capacity = 1000;
		stringBuilder3.Capacity = 1000;
		uint num = 0U;
		while (dje_zQE7X9KAD45FPNM2_ejd.SetupDiEnumDeviceInfo(intptr_, num, gclass))
		{
			StringBuilder stringBuilder4 = stringBuilder2;
			stringBuilder.Length = 0;
			stringBuilder4.Length = 0;
			dje_zQE7X9KAD45FPNM2_ejd.SetupDiGetDeviceRegistryProperty(intptr_, gclass, 1U, 0U, stringBuilder, 1000U, IntPtr.Zero);
			dje_zQE7X9KAD45FPNM2_ejd.SetupDiGetDeviceRegistryProperty(intptr_, gclass, 12U, 0U, stringBuilder2, 1000U, IntPtr.Zero);
			StringBuilder stringBuilder5 = stringBuilder;
			string str = (stringBuilder5 != null) ? stringBuilder5.ToString() : null;
			string str2 = " -- ";
			StringBuilder stringBuilder6 = stringBuilder2;
			Console.WriteLine(str + str2 + ((stringBuilder6 != null) ? stringBuilder6.ToString() : null));
			if (!stringBuilder.ToString().ToLower().Contains(gstruct5_0.string_2.ToLower()))
			{
				num += 1U;
			}
			else
			{
				string str3 = "Found: ";
				StringBuilder stringBuilder7 = stringBuilder2;
				Console.WriteLine(str3 + ((stringBuilder7 != null) ? stringBuilder7.ToString() : null));
				if (!this.method_4(intptr_, gclass, bool_0))
				{
					string str4 = "Unable to change ";
					StringBuilder stringBuilder8 = stringBuilder2;
					throw new Exception(str4 + ((stringBuilder8 != null) ? stringBuilder8.ToString() : null) + " device state, make sure you have administrator privileges");
				}
				break;
			}
		}
		dje_zQE7X9KAD45FPNM2_ejd.SetupDiDestroyDeviceInfoList(intptr_);
		return true;
	}

	// Token: 0x0600128F RID: 4751 RVA: 0x0004CD30 File Offset: 0x0004AF30
	public bool method_2(IntPtr intptr_0, bool bool_0)
	{
		bool result;
		try
		{
			dje_zQE7X9KAD45FPNM2_ejd.GClass233 gclass = new dje_zQE7X9KAD45FPNM2_ejd.GClass233();
			gclass.int_0 = Marshal.SizeOf<dje_zQE7X9KAD45FPNM2_ejd.GClass233>(gclass);
			gclass.int_2 = 0;
			gclass.int_1 = 5;
			if (bool_0)
			{
				dje_zQE7X9KAD45FPNM2_ejd.RegisterDeviceNotification(intptr_0, gclass, 4U);
			}
			else
			{
				dje_zQE7X9KAD45FPNM2_ejd.RegisterDeviceNotification(intptr_0, gclass, 5U);
			}
			result = true;
		}
		catch (Exception ex)
		{
			string message = ex.Message;
			result = false;
		}
		return result;
	}

	// Token: 0x06001290 RID: 4752 RVA: 0x0004CD94 File Offset: 0x0004AF94
	public void method_3(IntPtr intptr_0)
	{
		try
		{
			dje_zQE7X9KAD45FPNM2_ejd.UnregisterDeviceNotification(intptr_0);
		}
		catch (object obj)
		{
		}
	}

	// Token: 0x06001291 RID: 4753 RVA: 0x0004CDC0 File Offset: 0x0004AFC0
	private bool method_4(IntPtr intptr_0, dje_zQE7X9KAD45FPNM2_ejd.GClass231 gclass231_0, bool bool_0)
	{
		bool result;
		try
		{
			dje_zQE7X9KAD45FPNM2_ejd.SP_PROPCHANGE_PARAMS sp_PROPCHANGE_PARAMS = new dje_zQE7X9KAD45FPNM2_ejd.SP_PROPCHANGE_PARAMS();
			IntPtr intPtr;
			IntPtr intPtr2;
			if (bool_0)
			{
				sp_PROPCHANGE_PARAMS.ClassInstallHeader.cbSize = Marshal.SizeOf(typeof(dje_zQE7X9KAD45FPNM2_ejd.SP_CLASSINSTALL_HEADER));
				sp_PROPCHANGE_PARAMS.ClassInstallHeader.InstallFunction = 18;
				sp_PROPCHANGE_PARAMS.StateChange = 1;
				sp_PROPCHANGE_PARAMS.Scope = 1;
				sp_PROPCHANGE_PARAMS.HwProfile = 0;
				intPtr = Marshal.AllocHGlobal(Marshal.SizeOf<dje_zQE7X9KAD45FPNM2_ejd.SP_PROPCHANGE_PARAMS>(sp_PROPCHANGE_PARAMS));
				Marshal.StructureToPtr<dje_zQE7X9KAD45FPNM2_ejd.SP_PROPCHANGE_PARAMS>(sp_PROPCHANGE_PARAMS, intPtr, true);
				intPtr2 = Marshal.AllocHGlobal(Marshal.SizeOf<dje_zQE7X9KAD45FPNM2_ejd.GClass231>(gclass231_0));
				if (dje_zQE7X9KAD45FPNM2_ejd.SetupDiSetClassInstallParams(intptr_0, intPtr2, intPtr, Marshal.SizeOf(typeof(dje_zQE7X9KAD45FPNM2_ejd.SP_PROPCHANGE_PARAMS))))
				{
					dje_zQE7X9KAD45FPNM2_ejd.SetupDiCallClassInstaller(18U, intptr_0, intPtr2);
				}
				sp_PROPCHANGE_PARAMS.ClassInstallHeader.cbSize = Marshal.SizeOf(typeof(dje_zQE7X9KAD45FPNM2_ejd.SP_CLASSINSTALL_HEADER));
				sp_PROPCHANGE_PARAMS.ClassInstallHeader.InstallFunction = 18;
				sp_PROPCHANGE_PARAMS.StateChange = 1;
				sp_PROPCHANGE_PARAMS.Scope = 2;
				sp_PROPCHANGE_PARAMS.HwProfile = 0;
			}
			else
			{
				sp_PROPCHANGE_PARAMS.ClassInstallHeader.cbSize = Marshal.SizeOf(typeof(dje_zQE7X9KAD45FPNM2_ejd.SP_CLASSINSTALL_HEADER));
				sp_PROPCHANGE_PARAMS.ClassInstallHeader.InstallFunction = 18;
				sp_PROPCHANGE_PARAMS.StateChange = 2;
				sp_PROPCHANGE_PARAMS.Scope = 2;
				sp_PROPCHANGE_PARAMS.HwProfile = 0;
			}
			intPtr = Marshal.AllocHGlobal(Marshal.SizeOf<dje_zQE7X9KAD45FPNM2_ejd.SP_PROPCHANGE_PARAMS>(sp_PROPCHANGE_PARAMS));
			Marshal.StructureToPtr<dje_zQE7X9KAD45FPNM2_ejd.SP_PROPCHANGE_PARAMS>(sp_PROPCHANGE_PARAMS, intPtr, true);
			intPtr2 = Marshal.AllocHGlobal(Marshal.SizeOf<dje_zQE7X9KAD45FPNM2_ejd.GClass231>(gclass231_0));
			Marshal.StructureToPtr<dje_zQE7X9KAD45FPNM2_ejd.GClass231>(gclass231_0, intPtr2, true);
			bool flag = dje_zQE7X9KAD45FPNM2_ejd.SetupDiSetClassInstallParams(intptr_0, intPtr2, intPtr, Marshal.SizeOf(typeof(dje_zQE7X9KAD45FPNM2_ejd.SP_PROPCHANGE_PARAMS)));
			bool flag2 = dje_zQE7X9KAD45FPNM2_ejd.SetupDiCallClassInstaller(18U, intptr_0, intPtr2);
			if (!flag || !flag2)
			{
				throw new Exception("Unable to change device state!");
			}
			result = true;
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x04000B63 RID: 2915
	private Version version_0 = new Version(1, 0, 0);
}
