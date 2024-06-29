using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Token: 0x02000356 RID: 854
internal sealed class Class394
{
	// Token: 0x06001342 RID: 4930 RVA: 0x0004E550 File Offset: 0x0004C750
	public static void smethod_0(string string_1)
	{
		object[] object_ = new object[]
		{
			string_1
		};
		Class555.smethod_0().method_4(Class555.smethod_2(), "&ebh:()QNV", object_);
	}

	// Token: 0x06001343 RID: 4931 RVA: 0x0004E580 File Offset: 0x0004C780
	public static string smethod_1()
	{
		return Class394.string_0;
	}

	// Token: 0x06001344 RID: 4932 RVA: 0x0004E588 File Offset: 0x0004C788
	public static void smethod_2(string string_1)
	{
		Class394.string_0 = string_1;
	}

	// Token: 0x06001345 RID: 4933 RVA: 0x0004E590 File Offset: 0x0004C790
	public static void smethod_3(string string_1, double double_0)
	{
		object[] object_ = new object[]
		{
			string_1,
			double_0
		};
		Class555.smethod_0().method_4(Class555.smethod_2(), "&ebi-()Ql`", object_);
	}

	// Token: 0x06001346 RID: 4934 RVA: 0x0004E5C8 File Offset: 0x0004C7C8
	private static void smethod_4(ref Class394.Struct175 struct175_0)
	{
		struct175_0.asyncVoidMethodBuilder_0.Start<Class394.Struct175>(ref struct175_0);
	}

	// Token: 0x04000BC8 RID: 3016
	private static string string_0;

	// Token: 0x02000357 RID: 855
	[StructLayout(LayoutKind.Auto)]
	private struct Struct175 : IAsyncStateMachine
	{
		// Token: 0x06001347 RID: 4935 RVA: 0x0004E5D8 File Offset: 0x0004C7D8
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
				@class.method_4(stream_, "&ebhm()Q`\\", array);
			}
			finally
			{
				this = (Class394.Struct175)array[0];
			}
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x0004E640 File Offset: 0x0004C840
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x0004E650 File Offset: 0x0004C850
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class394.Struct175 struct175_0)
		{
			struct175_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class394.Struct175>(ref taskAwaiter_1, ref struct175_0);
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x0004E660 File Offset: 0x0004C860
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref Class394.Struct175 struct175_0)
		{
			struct175_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class394.Struct175>(ref taskAwaiter_1, ref struct175_0);
		}

		// Token: 0x04000BC9 RID: 3017
		public int int_0;

		// Token: 0x04000BCA RID: 3018
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000BCB RID: 3019
		public string string_0;

		// Token: 0x04000BCC RID: 3020
		public double double_0;

		// Token: 0x04000BCD RID: 3021
		private DateTime dateTime_0;

		// Token: 0x04000BCE RID: 3022
		private DateTime dateTime_1;

		// Token: 0x04000BCF RID: 3023
		private bool bool_0;

		// Token: 0x04000BD0 RID: 3024
		private SHA256 sha256_0;

		// Token: 0x04000BD1 RID: 3025
		private TaskAwaiter taskAwaiter_0;
	}
}
