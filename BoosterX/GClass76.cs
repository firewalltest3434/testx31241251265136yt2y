using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using Newtonsoft.Json;

// Token: 0x020002AF RID: 687
public static class GClass76
{
	// Token: 0x06000FD5 RID: 4053
	[DllImport("PowrProf.dll")]
	public static extern uint PowerEnumerate(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, uint uint_0, uint uint_1, ref Guid guid_0, ref uint uint_2);

	// Token: 0x06000FD6 RID: 4054
	[DllImport("PowrProf.dll")]
	public static extern uint PowerReadFriendlyName(IntPtr intptr_0, ref Guid guid_0, IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, ref uint uint_0);

	// Token: 0x06000FD7 RID: 4055 RVA: 0x00043AB0 File Offset: 0x00041CB0
	public static string smethod_0()
	{
		string str = "66666666-6666-6666-6666-666666666666";
		string text = Path.Combine(Class186.string_4, "BackUpPower.pow");
		Class185.smethod_22("powercfg /export \"" + text + "\" " + str);
		string result = JsonConvert.SerializeObject(new Class391<byte[]>(File.ReadAllBytes(text).smethod_0()));
		File.Delete(text);
		return result;
	}

	// Token: 0x06000FD8 RID: 4056 RVA: 0x00043B04 File Offset: 0x00041D04
	public static byte[] smethod_1()
	{
		string text = "66666666-6666-6666-6666-666666666666";
		if (text.smethod_7())
		{
			return null;
		}
		string text2 = Path.Combine(Class186.string_4, "BackUpPower.pow");
		Class185.smethod_22("powercfg /export \"" + text2 + "\" " + text);
		if (!File.Exists(text2))
		{
			return null;
		}
		byte[] result = File.ReadAllBytes(text2).smethod_0();
		try
		{
			File.Delete(text2);
		}
		catch (object obj)
		{
		}
		return result;
	}

	// Token: 0x06000FD9 RID: 4057 RVA: 0x00043B7C File Offset: 0x00041D7C
	public static string smethod_2()
	{
		return GClass76.smethod_3(Guid.Parse("66666666-6666-6666-6666-666666666666"));
	}

	// Token: 0x06000FDA RID: 4058 RVA: 0x00043B90 File Offset: 0x00041D90
	public static string smethod_3(Guid guid_0)
	{
		uint num = 1024U;
		IntPtr intPtr = Marshal.AllocHGlobal(1024);
		string result;
		try
		{
			GClass76.PowerReadFriendlyName(IntPtr.Zero, ref guid_0, IntPtr.Zero, IntPtr.Zero, intPtr, ref num);
			result = Marshal.PtrToStringUni(intPtr);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		return result;
	}

	// Token: 0x06000FDB RID: 4059 RVA: 0x00043BEC File Offset: 0x00041DEC
	public static IEnumerable<Guid> smethod_4()
	{
		return new GClass76.Class341(-2);
	}

	// Token: 0x06000FDC RID: 4060 RVA: 0x00043BF8 File Offset: 0x00041DF8
	public static string[] smethod_5()
	{
		IEnumerable<Guid> enumerable = GClass76.smethod_4();
		string[] array = new string[50];
		int num = 0;
		foreach (Guid guid in enumerable)
		{
			array[num] = guid.ToString();
			num++;
		}
		return array;
	}

	// Token: 0x06000FDD RID: 4061 RVA: 0x00043C60 File Offset: 0x00041E60
	public static string smethod_6()
	{
		string result;
		try
		{
			result = (string)Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Power\\User\\PowerSchemes").GetValue("ActivePowerScheme");
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06000FDE RID: 4062 RVA: 0x00043CA4 File Offset: 0x00041EA4
	public static string smethod_7()
	{
		string result;
		try
		{
			string str = (string)Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Power\\User\\PowerSchemes").GetValue("ActivePowerScheme");
			result = (string)Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Power\\User\\PowerSchemes\\" + str).GetValue("FriendlyName");
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06000FDF RID: 4063 RVA: 0x00043D10 File Offset: 0x00041F10
	public static bool smethod_8()
	{
		bool result;
		try
		{
			string str = (string)Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Power\\User\\PowerSchemes").GetValue("ActivePowerScheme");
			string text = (string)Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Power\\User\\PowerSchemes\\" + str).GetValue("FriendlyName");
			if (!text.Contains("Balanced") && !text.Contains("High") && !text.Contains("Saver"))
			{
				result = true;
			}
			else
			{
				result = false;
			}
		}
		catch
		{
			result = true;
		}
		return result;
	}

	// Token: 0x0400098B RID: 2443
	private static readonly Regex regex_0 = new Regex("\\(([a-fA-F0-9-]+)\\)", RegexOptions.Compiled);

	// Token: 0x0400098C RID: 2444
	private static readonly Regex regex_1 = new Regex("(.*?) \\(", RegexOptions.Compiled);

	// Token: 0x020002B0 RID: 688
	public enum GEnum36 : uint
	{

	}

	// Token: 0x020002B1 RID: 689
	public sealed class GClass77
	{
		// Token: 0x06000FE1 RID: 4065 RVA: 0x00043DB0 File Offset: 0x00041FB0
		public Guid method_0()
		{
			return this.guid_0;
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x00043DB8 File Offset: 0x00041FB8
		public void method_1(Guid guid_1)
		{
			this.guid_0 = guid_1;
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x00043DC4 File Offset: 0x00041FC4
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x00043DCC File Offset: 0x00041FCC
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

		// Token: 0x0400098E RID: 2446
		private Guid guid_0;

		// Token: 0x0400098F RID: 2447
		private string string_0;
	}

	// Token: 0x020002B2 RID: 690
	private sealed class Class341 : IDisposable, IEnumerator<Guid>, IEnumerable<Guid>, IEnumerable, IEnumerator
	{
		// Token: 0x06000FE5 RID: 4069 RVA: 0x00043DD8 File Offset: 0x00041FD8
		public Class341(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00043DF4 File Offset: 0x00041FF4
		void IDisposable.Dispose()
		{
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00043DF8 File Offset: 0x00041FF8
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.int_0 = -1;
				uint num2 = this.uint_1;
				this.uint_1 = num2 + 1U;
			}
			else
			{
				this.int_0 = -1;
				this.guid_1 = Guid.Empty;
				this.uint_0 = (uint)Marshal.SizeOf(typeof(Guid));
				this.uint_1 = 0U;
			}
			if (GClass76.PowerEnumerate(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, 16U, this.uint_1, ref this.guid_1, ref this.uint_0) != 0U)
			{
				return false;
			}
			this.guid_0 = this.guid_1;
			this.int_0 = 1;
			return true;
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x00043EAC File Offset: 0x000420AC
		Guid IEnumerator<Guid>.p000002
		{
			get
			{
				return this.guid_0;
			}
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00043EB4 File Offset: 0x000420B4
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x00043EBC File Offset: 0x000420BC
		object IEnumerator.Current
		{
			get
			{
				return this.guid_0;
			}
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x00043ECC File Offset: 0x000420CC
		IEnumerator<Guid> IEnumerable<Guid>.GetEnumerator()
		{
			GClass76.Class341 result;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				result = this;
			}
			else
			{
				result = new GClass76.Class341(0);
			}
			return result;
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00043F04 File Offset: 0x00042104
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000990 RID: 2448
		private int int_0;

		// Token: 0x04000991 RID: 2449
		private Guid guid_0;

		// Token: 0x04000992 RID: 2450
		private int int_1;

		// Token: 0x04000993 RID: 2451
		private Guid guid_1;

		// Token: 0x04000994 RID: 2452
		private uint uint_0;

		// Token: 0x04000995 RID: 2453
		private uint uint_1;
	}
}
