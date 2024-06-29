using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x020000AB RID: 171
internal static class Class114
{
	// Token: 0x06000556 RID: 1366 RVA: 0x0001C91C File Offset: 0x0001AB1C
	public static Class94 smethod_0(string string_0)
	{
		byte[] array = Class36.smethod_5(string_0);
		if (array == null)
		{
			return null;
		}
		return new Class94
		{
			class103_0 = new Class103
			{
				byte_0 = array,
				bool_0 = true,
				bool_1 = true
			}
		};
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x0001C95C File Offset: 0x0001AB5C
	public static byte[] smethod_1(string string_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		if (string_0.Length == 0)
		{
			return new byte[0];
		}
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		byte[] result = Class108.smethod_0(bytes, Class87.smethod_3(), new Func<byte[]>(Class114.smethod_4));
		Array.Clear(bytes, 0, bytes.Length);
		return result;
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x0001C9AC File Offset: 0x0001ABAC
	public static string smethod_2(byte[] byte_0, bool bool_0)
	{
		if (byte_0 == null)
		{
			return null;
		}
		if (byte_0.Length == 0)
		{
			return string.Empty;
		}
		byte[] array = Class108.smethod_1<byte>(byte_0, 0, Class87.smethod_3(), new Func<byte[]>(Class114.smethod_4), bool_0);
		string @string = Encoding.UTF8.GetString(array);
		Array.Clear(array, 0, array.Length);
		return @string;
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x0001C9F8 File Offset: 0x0001ABF8
	public static void smethod_3(string string_0)
	{
		if (string.IsInterned(string_0) != null)
		{
			return;
		}
		GCHandle gchandle = default(GCHandle);
		try
		{
			gchandle = GCHandle.Alloc(string_0, GCHandleType.Pinned);
			IntPtr ptr = gchandle.AddrOfPinnedObject();
			bool flag = IntPtr.Size == 4;
			int num = string_0.Length * 2;
			int i = 0;
			int num2 = num / IntPtr.Size;
			for (int j = 0; j < num2; j++)
			{
				if (flag)
				{
					Marshal.WriteInt32(ptr, i, 0);
				}
				else
				{
					Marshal.WriteInt64(ptr, i, 0L);
				}
				i += IntPtr.Size;
			}
			while (i < num)
			{
				Marshal.WriteInt16(ptr, i, 0);
				i += 2;
			}
			gchandle.Free();
		}
		catch (Exception)
		{
			if (gchandle.IsAllocated)
			{
				gchandle.Free();
			}
		}
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x0001CAD8 File Offset: 0x0001ACD8
	private static byte[] smethod_4()
	{
		return (byte[])Class555.smethod_0().method_1(Class555.smethod_2(), "&ebgC()Hud", null);
	}
}
