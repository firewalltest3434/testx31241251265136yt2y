using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x020002C5 RID: 709
internal sealed class Class352
{
	// Token: 0x06001054 RID: 4180 RVA: 0x0004597C File Offset: 0x00043B7C
	// Note: this type is marked as 'beforefieldinit'.
	static Class352()
	{
		Class555.smethod_0().method_4(Class555.smethod_2(), "&ebiS()LTt", null);
	}

	// Token: 0x06001055 RID: 4181 RVA: 0x00045994 File Offset: 0x00043B94
	public static Task<string> smethod_0()
	{
		return (Task<string>)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebi'()LEo", null);
	}

	// Token: 0x06001056 RID: 4182 RVA: 0x000459B0 File Offset: 0x00043BB0
	public static Task<string> smethod_1()
	{
		return (Task<string>)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebh0()IZ!", null);
	}

	// Token: 0x06001057 RID: 4183 RVA: 0x000459CC File Offset: 0x00043BCC
	public static Task<string> smethod_2()
	{
		return (Task<string>)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebg.()ISt", null);
	}

	// Token: 0x06001058 RID: 4184 RVA: 0x000459E8 File Offset: 0x00043BE8
	private static void smethod_3(ref Class352.Struct143 struct143_0)
	{
		struct143_0.asyncTaskMethodBuilder_0.Start<Class352.Struct143>(ref struct143_0);
	}

	// Token: 0x06001059 RID: 4185 RVA: 0x000459F8 File Offset: 0x00043BF8
	private static void smethod_4(ref Class352.Struct144 struct144_0)
	{
		struct144_0.asyncTaskMethodBuilder_0.Start<Class352.Struct144>(ref struct144_0);
	}

	// Token: 0x0600105A RID: 4186 RVA: 0x00045A08 File Offset: 0x00043C08
	private static void smethod_5(ref Class352.Struct142 struct142_0)
	{
		struct142_0.asyncTaskMethodBuilder_0.Start<Class352.Struct142>(ref struct142_0);
	}

	// Token: 0x040009C1 RID: 2497
	public static string string_0;

	// Token: 0x040009C2 RID: 2498
	public static string string_1;

	// Token: 0x040009C3 RID: 2499
	public static string string_2;

	// Token: 0x040009C4 RID: 2500
	private static List<string> list_0;

	// Token: 0x020002C6 RID: 710
	[Serializable]
	private sealed class Class353
	{
		// Token: 0x0600105D RID: 4189 RVA: 0x00045A2C File Offset: 0x00043C2C
		internal string method_0()
		{
			try
			{
				List<string> list = new List<string>();
				foreach (IPAddress ipaddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
				{
					if (ipaddress.AddressFamily == AddressFamily.InterNetwork)
					{
						list.Add(ipaddress.ToString());
					}
				}
				Class352.string_1 = list.Last<string>();
			}
			catch (object obj)
			{
			}
			finally
			{
				if (Class352.string_1 == string.Empty)
				{
					Class352.string_1 = "1";
				}
			}
			return Class352.string_1;
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00045AD8 File Offset: 0x00043CD8
		internal string method_1()
		{
			try
			{
				Class352.string_2 = NetworkInterface.GetAllNetworkInterfaces().Where(new Func<NetworkInterface, bool>(Class352.Class353.class353_0.method_2)).Select(new Func<NetworkInterface, string>(Class352.Class353.class353_0.method_3)).FirstOrDefault<string>();
			}
			catch (object obj)
			{
			}
			finally
			{
				if (Class352.string_2 == string.Empty)
				{
					Class352.string_2 = "1";
				}
			}
			return Class352.string_2;
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00045B80 File Offset: 0x00043D80
		internal bool method_2(NetworkInterface networkInterface_0)
		{
			return networkInterface_0.OperationalStatus == OperationalStatus.Up;
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00045B8C File Offset: 0x00043D8C
		internal string method_3(NetworkInterface networkInterface_0)
		{
			return networkInterface_0.GetPhysicalAddress().ToString();
		}

		// Token: 0x040009C5 RID: 2501
		public static readonly Class352.Class353 class353_0 = new Class352.Class353();

		// Token: 0x040009C6 RID: 2502
		public static Func<string> func_0;

		// Token: 0x040009C7 RID: 2503
		public static Func<NetworkInterface, bool> func_1;

		// Token: 0x040009C8 RID: 2504
		public static Func<NetworkInterface, string> func_2;

		// Token: 0x040009C9 RID: 2505
		public static Func<string> func_3;
	}

	// Token: 0x020002C7 RID: 711
	[StructLayout(LayoutKind.Auto)]
	private struct Struct142 : IAsyncStateMachine
	{
		// Token: 0x06001061 RID: 4193 RVA: 0x00045B9C File Offset: 0x00043D9C
		void IAsyncStateMachine.MoveNext()
		{
			object[] array = new object[]
			{
				this
			};
			Class27 @class = Class555.smethod_0();
			Stream stream_ = Class555.smethod_2();
			try
			{
				@class.method_4(stream_, "&ebgG()Lg%", array);
			}
			finally
			{
				this = (Class352.Struct142)array[0];
			}
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00045C04 File Offset: 0x00043E04
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00045C14 File Offset: 0x00043E14
		private static void MoveNext(ref TaskAwaiter<string> taskAwaiter_1, ref Class352.Struct142 struct142_0)
		{
			struct142_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class352.Struct142>(ref taskAwaiter_1, ref struct142_0);
		}

		// Token: 0x040009CA RID: 2506
		public int int_0;

		// Token: 0x040009CB RID: 2507
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x040009CC RID: 2508
		private HttpClient httpClient_0;

		// Token: 0x040009CD RID: 2509
		private string string_0;

		// Token: 0x040009CE RID: 2510
		private List<string>.Enumerator enumerator_0;

		// Token: 0x040009CF RID: 2511
		private TaskAwaiter<string> taskAwaiter_0;
	}

	// Token: 0x020002C8 RID: 712
	[StructLayout(LayoutKind.Auto)]
	private struct Struct143 : IAsyncStateMachine
	{
		// Token: 0x06001064 RID: 4196 RVA: 0x00045C24 File Offset: 0x00043E24
		void IAsyncStateMachine.MoveNext()
		{
			object[] array = new object[]
			{
				this
			};
			Class27 @class = Class555.smethod_0();
			Stream stream_ = Class555.smethod_2();
			try
			{
				@class.method_4(stream_, "&ebi!()I`#", array);
			}
			finally
			{
				this = (Class352.Struct143)array[0];
			}
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00045C8C File Offset: 0x00043E8C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00045C9C File Offset: 0x00043E9C
		private static void MoveNext(ref TaskAwaiter<string> taskAwaiter_1, ref Class352.Struct143 struct143_0)
		{
			struct143_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class352.Struct143>(ref taskAwaiter_1, ref struct143_0);
		}

		// Token: 0x040009D0 RID: 2512
		public int int_0;

		// Token: 0x040009D1 RID: 2513
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x040009D2 RID: 2514
		private TaskAwaiter<string> taskAwaiter_0;
	}

	// Token: 0x020002C9 RID: 713
	[StructLayout(LayoutKind.Auto)]
	private struct Struct144 : IAsyncStateMachine
	{
		// Token: 0x06001067 RID: 4199 RVA: 0x00045CAC File Offset: 0x00043EAC
		void IAsyncStateMachine.MoveNext()
		{
			object[] array = new object[]
			{
				this
			};
			Class27 @class = Class555.smethod_0();
			Stream stream_ = Class555.smethod_2();
			try
			{
				@class.method_4(stream_, "&ebgr()IVu", array);
			}
			finally
			{
				this = (Class352.Struct144)array[0];
			}
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x00045D14 File Offset: 0x00043F14
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00045D24 File Offset: 0x00043F24
		private static void MoveNext(ref TaskAwaiter<string> taskAwaiter_1, ref Class352.Struct144 struct144_0)
		{
			struct144_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class352.Struct144>(ref taskAwaiter_1, ref struct144_0);
		}

		// Token: 0x040009D3 RID: 2515
		public int int_0;

		// Token: 0x040009D4 RID: 2516
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x040009D5 RID: 2517
		private TaskAwaiter<string> taskAwaiter_0;
	}
}
