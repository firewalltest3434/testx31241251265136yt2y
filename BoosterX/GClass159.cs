using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using Microsoft.Win32.SafeHandles;

// Token: 0x02000523 RID: 1315
public static class GClass159
{
	// Token: 0x06001CE6 RID: 7398 RVA: 0x0007860C File Offset: 0x0007680C
	public static bool smethod_0()
	{
		WindowsIdentity current = WindowsIdentity.GetCurrent();
		return current != null && new WindowsPrincipal(current).IsInRole(WindowsBuiltInRole.Administrator);
	}

	// Token: 0x06001CE7 RID: 7399 RVA: 0x00078634 File Offset: 0x00076834
	public static GClass51 smethod_1(string string_0, GEnum40 genum40_0, bool bool_0)
	{
		GClass51 result = new GClass51();
		DriveInfo driveInfo = new DriveInfo(string_0);
		if (driveInfo.DriveType == DriveType.Fixed && driveInfo.IsReady)
		{
			GClass51 gclass = new GClass51();
			gclass.method_9(driveInfo.DriveFormat);
			gclass.method_7(driveInfo.VolumeLabel);
			gclass.Name = driveInfo.Name;
			gclass.method_21(GClass14.smethod_0(driveInfo.Name));
			gclass.method_3(driveInfo.DriveType);
			gclass.method_15(driveInfo.AvailableFreeSpace);
			gclass.method_13(driveInfo.TotalSize);
			gclass.method_11(driveInfo.TotalFreeSpace);
			gclass.method_19(driveInfo.RootDirectory);
			gclass.method_1(driveInfo.Name.Substring(0, 1).ToCharArray()[0]);
			GClass51 gclass2 = gclass;
			int num = GClass159.smethod_5(gclass2.method_0());
			if (num != -1)
			{
				gclass2.method_5(num);
				if (genum40_0 != (GEnum40)0)
				{
					gclass2.method_17(GClass159.smethod_9(num));
				}
				else
				{
					gclass2.method_17(GClass159.smethod_7(num));
				}
				if (gclass2.method_16() != (GEnum53)0)
				{
					result = gclass2;
				}
			}
		}
		return result;
	}

	// Token: 0x06001CE8 RID: 7400 RVA: 0x00078748 File Offset: 0x00076948
	public static List<GClass51> smethod_2(GEnum40 genum40_0, bool bool_0)
	{
		List<GClass51> list = new List<GClass51>();
		foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
		{
			if (driveInfo.DriveType == DriveType.Fixed && driveInfo.IsReady)
			{
				GClass51 gclass = new GClass51();
				gclass.method_9(driveInfo.DriveFormat);
				gclass.method_7(driveInfo.VolumeLabel);
				gclass.Name = driveInfo.Name;
				gclass.method_21(GClass14.smethod_0(driveInfo.Name));
				gclass.method_3(driveInfo.DriveType);
				gclass.method_15(driveInfo.AvailableFreeSpace);
				gclass.method_13(driveInfo.TotalSize);
				gclass.method_11(driveInfo.TotalFreeSpace);
				gclass.method_19(driveInfo.RootDirectory);
				gclass.method_1(driveInfo.Name.Substring(0, 1).ToCharArray()[0]);
				GClass51 gclass2 = gclass;
				int num = GClass159.smethod_5(gclass2.method_0());
				if (num != -1)
				{
					gclass2.method_5(num);
					if (genum40_0 != (GEnum40)0)
					{
						gclass2.method_17(GClass159.smethod_9(num));
					}
					else
					{
						gclass2.method_17(GClass159.smethod_7(num));
					}
					if (gclass2.method_16() != (GEnum53)0)
					{
						list.Add(gclass2);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06001CE9 RID: 7401 RVA: 0x0007887C File Offset: 0x00076A7C
	public static GClass51 smethod_3(string string_0, GEnum40 genum40_0, bool bool_0)
	{
		GClass51 result = new GClass51();
		DriveInfo driveInfo = new DriveInfo(string_0);
		if (driveInfo.DriveType == DriveType.Fixed)
		{
			if (driveInfo.IsReady)
			{
				GClass51 gclass = new GClass51();
				gclass.method_9(driveInfo.DriveFormat);
				gclass.method_7(driveInfo.VolumeLabel);
				gclass.Name = driveInfo.Name;
				gclass.method_21(GClass14.smethod_0(driveInfo.Name));
				gclass.method_3(driveInfo.DriveType);
				gclass.method_15(driveInfo.AvailableFreeSpace);
				gclass.method_13(driveInfo.TotalSize);
				gclass.method_11(driveInfo.TotalFreeSpace);
				gclass.method_19(driveInfo.RootDirectory);
				gclass.method_1(driveInfo.Name.Substring(0, 1).ToCharArray()[0]);
				GClass51 gclass2 = gclass;
				int num = GClass159.smethod_5(gclass2.method_0());
				if (num != -1)
				{
					gclass2.method_5(num);
					if (genum40_0 != (GEnum40)0)
					{
						gclass2.method_17(GClass159.smethod_9(num));
					}
					else
					{
						gclass2.method_17(GClass159.smethod_7(num));
					}
					result = gclass2;
				}
			}
		}
		else if (driveInfo.IsReady)
		{
			GClass51 gclass3 = new GClass51();
			gclass3.method_9(driveInfo.DriveFormat);
			gclass3.method_7(driveInfo.VolumeLabel);
			gclass3.Name = driveInfo.Name;
			gclass3.method_21(GClass14.smethod_0(driveInfo.Name));
			gclass3.method_3(driveInfo.DriveType);
			gclass3.method_15(driveInfo.AvailableFreeSpace);
			gclass3.method_13(driveInfo.TotalSize);
			gclass3.method_11(driveInfo.TotalFreeSpace);
			gclass3.method_19(driveInfo.RootDirectory);
			gclass3.method_1(driveInfo.Name.Substring(0, 1).ToCharArray()[0]);
			gclass3.method_17((GEnum53)0);
			gclass3.method_5(-1);
			result = gclass3;
		}
		return result;
	}

	// Token: 0x06001CEA RID: 7402 RVA: 0x00078A30 File Offset: 0x00076C30
	public static List<GClass51> smethod_4(GEnum40 genum40_0, bool bool_0)
	{
		List<GClass51> list = new List<GClass51>();
		foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
		{
			if (driveInfo.DriveType == DriveType.Fixed)
			{
				if (driveInfo.IsReady)
				{
					GClass51 gclass = new GClass51();
					gclass.method_9(driveInfo.DriveFormat);
					gclass.method_7(driveInfo.VolumeLabel);
					gclass.Name = driveInfo.Name;
					gclass.method_21(GClass14.smethod_0(driveInfo.Name));
					gclass.method_3(driveInfo.DriveType);
					gclass.method_15(driveInfo.AvailableFreeSpace);
					gclass.method_13(driveInfo.TotalSize);
					gclass.method_11(driveInfo.TotalFreeSpace);
					gclass.method_19(driveInfo.RootDirectory);
					gclass.method_1(driveInfo.Name.Substring(0, 1).ToCharArray()[0]);
					GClass51 gclass2 = gclass;
					int num = GClass159.smethod_5(gclass2.method_0());
					if (num != -1)
					{
						gclass2.method_5(num);
						if (genum40_0 != (GEnum40)0)
						{
							gclass2.method_17(GClass159.smethod_9(num));
						}
						else
						{
							gclass2.method_17(GClass159.smethod_7(num));
						}
						list.Add(gclass2);
					}
				}
			}
			else if (driveInfo.IsReady)
			{
				GClass51 gclass3 = new GClass51();
				gclass3.method_9(driveInfo.DriveFormat);
				gclass3.method_7(driveInfo.VolumeLabel);
				gclass3.Name = driveInfo.Name;
				gclass3.method_21(GClass14.smethod_0(driveInfo.Name));
				gclass3.method_3(driveInfo.DriveType);
				gclass3.method_15(driveInfo.AvailableFreeSpace);
				gclass3.method_13(driveInfo.TotalSize);
				gclass3.method_11(driveInfo.TotalFreeSpace);
				gclass3.method_19(driveInfo.RootDirectory);
				gclass3.method_1(driveInfo.Name.Substring(0, 1).ToCharArray()[0]);
				gclass3.method_17((GEnum53)0);
				gclass3.method_5(-1);
				GClass51 item = gclass3;
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06001CEB RID: 7403
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeviceIoControl(SafeFileHandle safeFileHandle_0, uint uint_0, IntPtr intptr_0, uint uint_1, ref GClass159.Struct295 struct295_0, uint uint_2, out uint uint_3, IntPtr intptr_1);

	// Token: 0x06001CEC RID: 7404 RVA: 0x00078C14 File Offset: 0x00076E14
	private static int smethod_5(char char_0)
	{
		if (new DriveInfo(char_0.ToString()).DriveType != DriveType.Fixed)
		{
			throw new GException1(string.Format("This drive is not fixed drive: {0}", char_0));
		}
		SafeFileHandle safeFileHandle = GClass159.CreateFileW("\\\\.\\" + char_0.ToString() + ":", 0U, 3U, IntPtr.Zero, 3U, 128U, IntPtr.Zero);
		if (safeFileHandle != null && !safeFileHandle.IsInvalid)
		{
			uint uint_ = GClass159.smethod_11(86U, 0U, 0U, 0U);
			GClass159.Struct295 @struct = default(GClass159.Struct295);
			uint num;
			bool flag = GClass159.DeviceIoControl(safeFileHandle, uint_, IntPtr.Zero, 0U, ref @struct, (uint)Marshal.SizeOf<GClass159.Struct295>(@struct), out num, IntPtr.Zero);
			safeFileHandle.Close();
			if (!flag)
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error != 234 || @struct.struct298_0.Length < 1)
				{
					throw new GException1(string.Format("Could not detect Disk Id of {0}", char_0), new Win32Exception(lastWin32Error));
				}
			}
			return (int)@struct.struct298_0[0].uint_0;
		}
		int lastWin32Error2 = Marshal.GetLastWin32Error();
		throw new GException1(string.Format("Could not detect Disk Id of {0}", char_0), new Win32Exception(lastWin32Error2));
	}

	// Token: 0x06001CED RID: 7405 RVA: 0x00078D3C File Offset: 0x00076F3C
	public static GEnum53 smethod_6(char char_0)
	{
		GEnum53 result;
		try
		{
			result = GClass159.smethod_7(GClass159.smethod_5(char_0));
		}
		catch (GException1)
		{
			result = (GEnum53)0;
		}
		return result;
	}

	// Token: 0x06001CEE RID: 7406 RVA: 0x00078D70 File Offset: 0x00076F70
	public static GEnum53 smethod_7(int int_0)
	{
		string string_ = "\\\\.\\PhysicalDrive" + int_0.ToString();
		GEnum53 result;
		try
		{
			result = (GClass159.smethod_12(string_) ? ((GEnum53)1) : ((GEnum53)2));
		}
		catch (GException1)
		{
			result = (GEnum53)0;
		}
		return result;
	}

	// Token: 0x06001CEF RID: 7407 RVA: 0x00078DB4 File Offset: 0x00076FB4
	public static GEnum53 smethod_8(char char_0)
	{
		GEnum53 result;
		try
		{
			result = GClass159.smethod_9(GClass159.smethod_5(char_0));
		}
		catch (GException1)
		{
			result = (GEnum53)0;
		}
		return result;
	}

	// Token: 0x06001CF0 RID: 7408 RVA: 0x00078DE8 File Offset: 0x00076FE8
	public static GEnum53 smethod_9(int int_0)
	{
		string string_ = "\\\\.\\PhysicalDrive" + int_0.ToString();
		GEnum53 result;
		try
		{
			result = (GClass159.smethod_13(string_) ? ((GEnum53)1) : ((GEnum53)2));
		}
		catch (GException1)
		{
			result = (GEnum53)0;
		}
		return result;
	}

	// Token: 0x06001CF1 RID: 7409
	[DllImport("mpr.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int WNetGetConnection([MarshalAs(UnmanagedType.LPTStr)] string string_0, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder stringBuilder_0, ref int int_0);

	// Token: 0x06001CF2 RID: 7410 RVA: 0x00078E2C File Offset: 0x0007702C
	private static object smethod_10(string string_0)
	{
		int num = 200;
		StringBuilder stringBuilder_ = new StringBuilder(200);
		GClass159.WNetGetConnection("Z:", stringBuilder_, ref num);
		int num2 = 255;
		StringBuilder stringBuilder = new StringBuilder(255);
		GClass159.WNetGetConnection("Z:", stringBuilder, ref num2);
		return stringBuilder.ToString();
	}

	// Token: 0x06001CF3 RID: 7411
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern SafeFileHandle CreateFileW([MarshalAs(UnmanagedType.LPWStr)] string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	// Token: 0x06001CF4 RID: 7412 RVA: 0x00078E80 File Offset: 0x00077080
	private static uint smethod_11(uint uint_0, uint uint_1, uint uint_2, uint uint_3)
	{
		return uint_0 << 16 | uint_3 << 14 | uint_1 << 2 | uint_2;
	}

	// Token: 0x06001CF5 RID: 7413
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeviceIoControl(SafeFileHandle safeFileHandle_0, uint uint_0, ref GClass159.Struct293 struct293_0, uint uint_1, ref GClass159.Struct294 struct294_0, uint uint_2, out uint uint_3, IntPtr intptr_0);

	// Token: 0x06001CF6 RID: 7414
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeviceIoControl(SafeFileHandle safeFileHandle_0, uint uint_0, ref GClass159.Struct297 struct297_0, uint uint_1, ref GClass159.Struct297 struct297_1, uint uint_2, out uint uint_3, IntPtr intptr_0);

	// Token: 0x06001CF7 RID: 7415 RVA: 0x00078E94 File Offset: 0x00077094
	private static bool smethod_12(string string_0)
	{
		SafeFileHandle safeFileHandle = GClass159.CreateFileW(string_0, 0U, 3U, IntPtr.Zero, 3U, 128U, IntPtr.Zero);
		if (safeFileHandle == null || safeFileHandle.IsInvalid)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			throw new GException1(string.Format("Could not detect SeekPenalty of {0}", string_0), new Win32Exception(lastWin32Error));
		}
		uint uint_ = GClass159.smethod_11(45U, 1280U, 0U, 0U);
		GClass159.Struct293 structure = new GClass159.Struct293
		{
			uint_0 = 7U,
			uint_1 = 0U
		};
		GClass159.Struct294 @struct = default(GClass159.Struct294);
		uint num;
		bool flag = GClass159.DeviceIoControl(safeFileHandle, uint_, ref structure, (uint)Marshal.SizeOf<GClass159.Struct293>(structure), ref @struct, (uint)Marshal.SizeOf<GClass159.Struct294>(@struct), out num, IntPtr.Zero);
		safeFileHandle.Close();
		if (!flag)
		{
			int lastWin32Error2 = Marshal.GetLastWin32Error();
			throw new GException1(string.Format("Could not detect SeekPenalty of {0}", string_0), new Win32Exception(lastWin32Error2));
		}
		return @struct.bool_0;
	}

	// Token: 0x06001CF8 RID: 7416 RVA: 0x00078F6C File Offset: 0x0007716C
	private static bool smethod_13(string string_0)
	{
		SafeFileHandle safeFileHandle = GClass159.CreateFileW(string_0, 3221225472U, 3U, IntPtr.Zero, 3U, 128U, IntPtr.Zero);
		if (safeFileHandle == null || safeFileHandle.IsInvalid)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			throw new GException1(string.Format("Could not detect NominalMediaRotationRate of {0}", string_0), new Win32Exception(lastWin32Error));
		}
		uint uint_ = GClass159.smethod_11(4U, 1035U, 0U, 3U);
		GClass159.Struct297 @struct = new GClass159.Struct297
		{
			ushort_0 = new ushort[256]
		};
		@struct.struct296_0.ushort_0 = (ushort)Marshal.SizeOf<GClass159.Struct296>(@struct.struct296_0);
		@struct.struct296_0.ushort_1 = 2;
		@struct.struct296_0.uint_0 = (uint)(@struct.ushort_0.Length * 2);
		@struct.struct296_0.uint_1 = 3U;
		@struct.struct296_0.intptr_0 = Marshal.OffsetOf(typeof(GClass159.Struct297), "#=zDSHr2g0=");
		@struct.struct296_0.byte_4 = new byte[8];
		@struct.struct296_0.byte_5 = new byte[8];
		@struct.struct296_0.byte_5[6] = 236;
		uint num;
		bool flag = GClass159.DeviceIoControl(safeFileHandle, uint_, ref @struct, (uint)Marshal.SizeOf<GClass159.Struct297>(@struct), ref @struct, (uint)Marshal.SizeOf<GClass159.Struct297>(@struct), out num, IntPtr.Zero);
		safeFileHandle.Close();
		if (!flag)
		{
			int lastWin32Error2 = Marshal.GetLastWin32Error();
			throw new GException1(string.Format("Could not detect NominalMediaRotationRate of {0}", string_0), new Win32Exception(lastWin32Error2));
		}
		return @struct.ushort_0[217] != 1;
	}

	// Token: 0x02000524 RID: 1316
	private struct Struct293
	{
		// Token: 0x0400143D RID: 5181
		public uint uint_0;

		// Token: 0x0400143E RID: 5182
		public uint uint_1;

		// Token: 0x0400143F RID: 5183
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public readonly byte[] byte_0;
	}

	// Token: 0x02000525 RID: 1317
	private struct Struct294
	{
		// Token: 0x04001440 RID: 5184
		public readonly uint uint_0;

		// Token: 0x04001441 RID: 5185
		public readonly uint uint_1;

		// Token: 0x04001442 RID: 5186
		[MarshalAs(UnmanagedType.U1)]
		public readonly bool bool_0;
	}

	// Token: 0x02000526 RID: 1318
	private struct Struct295
	{
		// Token: 0x04001443 RID: 5187
		public readonly uint uint_0;

		// Token: 0x04001444 RID: 5188
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public readonly GClass159.Struct298[] struct298_0;
	}

	// Token: 0x02000527 RID: 1319
	private struct Struct296
	{
		// Token: 0x04001445 RID: 5189
		public ushort ushort_0;

		// Token: 0x04001446 RID: 5190
		public ushort ushort_1;

		// Token: 0x04001447 RID: 5191
		public readonly byte byte_0;

		// Token: 0x04001448 RID: 5192
		public readonly byte byte_1;

		// Token: 0x04001449 RID: 5193
		public readonly byte byte_2;

		// Token: 0x0400144A RID: 5194
		public readonly byte byte_3;

		// Token: 0x0400144B RID: 5195
		public uint uint_0;

		// Token: 0x0400144C RID: 5196
		public uint uint_1;

		// Token: 0x0400144D RID: 5197
		public readonly uint uint_2;

		// Token: 0x0400144E RID: 5198
		public IntPtr intptr_0;

		// Token: 0x0400144F RID: 5199
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] byte_4;

		// Token: 0x04001450 RID: 5200
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] byte_5;
	}

	// Token: 0x02000528 RID: 1320
	private struct Struct297
	{
		// Token: 0x04001451 RID: 5201
		public GClass159.Struct296 struct296_0;

		// Token: 0x04001452 RID: 5202
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		public ushort[] ushort_0;
	}

	// Token: 0x02000529 RID: 1321
	private struct Struct298
	{
		// Token: 0x04001453 RID: 5203
		public readonly uint uint_0;

		// Token: 0x04001454 RID: 5204
		public readonly long long_0;

		// Token: 0x04001455 RID: 5205
		public readonly long long_1;
	}
}
