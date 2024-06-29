using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x02000140 RID: 320
internal sealed class Class176
{
	// Token: 0x06000835 RID: 2101 RVA: 0x00028798 File Offset: 0x00026998
	// Note: this type is marked as 'beforefieldinit'.
	static Class176()
	{
		Class555.smethod_0().method_4(Class555.smethod_2(), "&ebgU()MB6", null);
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x000287B0 File Offset: 0x000269B0
	public static Task<GClass41> smethod_0(bool bool_0)
	{
		object[] object_ = new object[]
		{
			bool_0
		};
		return (Task<GClass41>)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebh_()M31", object_);
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x000287E8 File Offset: 0x000269E8
	private static void smethod_1(ref Class176.Struct63 struct63_0)
	{
		struct63_0.asyncTaskMethodBuilder_0.Start<Class176.Struct63>(ref struct63_0);
	}

	// Token: 0x04000495 RID: 1173
	private static GClass178 gclass178_0;

	// Token: 0x04000496 RID: 1174
	private static string string_0;

	// Token: 0x02000141 RID: 321
	[StructLayout(LayoutKind.Auto)]
	private struct Struct63 : IAsyncStateMachine
	{
		// Token: 0x06000838 RID: 2104 RVA: 0x000287F8 File Offset: 0x000269F8
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
				@class.method_4(stream_, "&ebiO()LNs", array);
			}
			finally
			{
				this = (Class176.Struct63)array[0];
			}
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00028860 File Offset: 0x00026A60
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00028870 File Offset: 0x00026A70
		private static void MoveNext(ref TaskAwaiter<GClass41> taskAwaiter_1, ref Class176.Struct63 struct63_0)
		{
			struct63_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass41>, Class176.Struct63>(ref taskAwaiter_1, ref struct63_0);
		}

		// Token: 0x04000497 RID: 1175
		public int int_0;

		// Token: 0x04000498 RID: 1176
		public AsyncTaskMethodBuilder<GClass41> asyncTaskMethodBuilder_0;

		// Token: 0x04000499 RID: 1177
		private TaskAwaiter<GClass41> taskAwaiter_0;
	}

	// Token: 0x02000142 RID: 322
	[Serializable]
	private sealed class Class177
	{
		// Token: 0x0600083D RID: 2109 RVA: 0x00028894 File Offset: 0x00026A94
		internal GClass41 method_0()
		{
			Class176.gclass178_0 = new GClass178(Class176.string_0);
			GClass41 gclass = Class176.gclass178_0.imethod_6().imethod_2(null);
			if (Class245.bool_0)
			{
				gclass.method_0().String_0 = GClass89.smethod_12();
			}
			else
			{
				gclass.method_0().String_0 = GClass89.smethod_14();
			}
			gclass.method_0().Nullable_0 = new double?(0.1);
			return gclass;
		}

		// Token: 0x0400049A RID: 1178
		public static readonly Class176.Class177 class177_0 = new Class176.Class177();

		// Token: 0x0400049B RID: 1179
		public static Func<GClass41> func_0;
	}
}
