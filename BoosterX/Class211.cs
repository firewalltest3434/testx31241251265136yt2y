using System;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// Token: 0x02000191 RID: 401
internal sealed class Class211
{
	// Token: 0x06000A24 RID: 2596 RVA: 0x0002E498 File Offset: 0x0002C698
	// Note: this type is marked as 'beforefieldinit'.
	static Class211()
	{
		Class555.smethod_0().method_4(Class555.smethod_2(), "&ebg<()Hrc", null);
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x0002E4B0 File Offset: 0x0002C6B0
	public static bool smethod_0()
	{
		return (bool)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebfl()JqF", null);
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x0002E4D4 File Offset: 0x0002C6D4
	public static string smethod_1()
	{
		return (string)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebi4()JV=", null);
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x0002E4F0 File Offset: 0x0002C6F0
	public static string smethod_2()
	{
		return (string)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebg]()L3j", null);
	}

	// Token: 0x06000A28 RID: 2600 RVA: 0x0002E50C File Offset: 0x0002C70C
	public static string smethod_3()
	{
		return (string)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebi,()K=Q", null);
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x0002E528 File Offset: 0x0002C728
	public static string smethod_4()
	{
		return (string)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebfW()MiC", null);
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x0002E544 File Offset: 0x0002C744
	public static Task<string> smethod_5()
	{
		return (Task<string>)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebiG()N_\\", null);
	}

	// Token: 0x06000A2B RID: 2603 RVA: 0x0002E560 File Offset: 0x0002C760
	public static string smethod_6()
	{
		return (string)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebgo()O1i", null);
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x0002E57C File Offset: 0x0002C77C
	public static string smethod_7()
	{
		return (string)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebiC()O7k", null);
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x0002E598 File Offset: 0x0002C798
	public static string smethod_8()
	{
		return (string)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebfg()Ne^", null);
	}

	// Token: 0x06000A2E RID: 2606 RVA: 0x0002E5B4 File Offset: 0x0002C7B4
	public static Task<bool> smethod_9()
	{
		return (Task<bool>)Class555.smethod_0().method_1(Class555.smethod_2(), "&ebhR()M<3", null);
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x0002E5D0 File Offset: 0x0002C7D0
	private static void smethod_10(ref Class211.Struct79 struct79_0)
	{
		struct79_0.asyncTaskMethodBuilder_0.Start<Class211.Struct79>(ref struct79_0);
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x0002E5E0 File Offset: 0x0002C7E0
	private static void smethod_11(ref Class211.Struct80 struct80_0)
	{
		struct80_0.asyncTaskMethodBuilder_0.Start<Class211.Struct80>(ref struct80_0);
	}

	// Token: 0x040005F1 RID: 1521
	private static bool bool_0;

	// Token: 0x040005F2 RID: 1522
	private static string string_0;

	// Token: 0x040005F3 RID: 1523
	private static string string_1;

	// Token: 0x040005F4 RID: 1524
	private static string string_2;

	// Token: 0x040005F5 RID: 1525
	private static object object_0;

	// Token: 0x040005F6 RID: 1526
	private static object object_1;

	// Token: 0x040005F7 RID: 1527
	private static object object_2;

	// Token: 0x040005F8 RID: 1528
	private static object object_3;

	// Token: 0x040005F9 RID: 1529
	private static object object_4;

	// Token: 0x02000192 RID: 402
	[StructLayout(LayoutKind.Auto)]
	private struct Struct79 : IAsyncStateMachine
	{
		// Token: 0x06000A31 RID: 2609 RVA: 0x0002E5F0 File Offset: 0x0002C7F0
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
				@class.method_4(stream_, "&ebhD()O.h", array);
			}
			finally
			{
				this = (Class211.Struct79)array[0];
			}
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0002E658 File Offset: 0x0002C858
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0002E668 File Offset: 0x0002C868
		private static void MoveNext(ref TaskAwaiter<string> taskAwaiter_1, ref Class211.Struct79 struct79_0)
		{
			struct79_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class211.Struct79>(ref taskAwaiter_1, ref struct79_0);
		}

		// Token: 0x040005FA RID: 1530
		public int int_0;

		// Token: 0x040005FB RID: 1531
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x040005FC RID: 1532
		private StringBuilder stringBuilder_0;

		// Token: 0x040005FD RID: 1533
		private StringBuilder stringBuilder_1;

		// Token: 0x040005FE RID: 1534
		private TaskAwaiter<string> taskAwaiter_0;
	}

	// Token: 0x02000193 RID: 403
	[StructLayout(LayoutKind.Auto)]
	private struct Struct80 : IAsyncStateMachine
	{
		// Token: 0x06000A34 RID: 2612 RVA: 0x0002E678 File Offset: 0x0002C878
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
				@class.method_4(stream_, "&ebgJ()LNr", array);
			}
			finally
			{
				this = (Class211.Struct80)array[0];
			}
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0002E6E0 File Offset: 0x0002C8E0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x0002E6F0 File Offset: 0x0002C8F0
		private static void MoveNext(ref TaskAwaiter<bool> taskAwaiter_1, ref Class211.Struct80 struct80_0)
		{
			struct80_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Class211.Struct80>(ref taskAwaiter_1, ref struct80_0);
		}

		// Token: 0x040005FF RID: 1535
		public int int_0;

		// Token: 0x04000600 RID: 1536
		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		// Token: 0x04000601 RID: 1537
		private TaskAwaiter<bool> taskAwaiter_0;
	}

	// Token: 0x02000194 RID: 404
	[Serializable]
	private sealed class Class212
	{
		// Token: 0x06000A39 RID: 2617 RVA: 0x0002E714 File Offset: 0x0002C914
		internal bool method_0(DriveInfo driveInfo_0)
		{
			return driveInfo_0.DriveType == DriveType.Fixed;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0002E720 File Offset: 0x0002C920
		internal bool method_1()
		{
			try
			{
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
				try
				{
					using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
					{
						foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
						{
							string text = managementBaseObject["Manufacturer"].ToString().ToLower();
							if ((text == "microsoft corporation" && managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || managementBaseObject["Model"].ToString() == "VirtualBox")
							{
								return true;
							}
						}
					}
				}
				finally
				{
					((IDisposable)managementObjectSearcher).Dispose();
				}
				using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard").Get().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (((ManagementObject)enumerator.Current)["Manufacturer"].ToString() == "Microsoft Corporation")
						{
							return true;
						}
					}
				}
			}
			catch (object obj)
			{
			}
			return Directory.Exists("C:\\Program Files\\VMware\\VMware Tools") || "".smethod_2("Error");
		}

		// Token: 0x04000602 RID: 1538
		public static readonly Class211.Class212 class212_0 = new Class211.Class212();

		// Token: 0x04000603 RID: 1539
		public static Func<DriveInfo, bool> func_0;

		// Token: 0x04000604 RID: 1540
		public static Func<bool> func_1;
	}

	// Token: 0x02000195 RID: 405
	private sealed class Class213
	{
		// Token: 0x06000A3C RID: 2620 RVA: 0x0002E940 File Offset: 0x0002CB40
		internal void method_0()
		{
			/*
An exception occurred when decompiling this method (06000A3C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Class211/Class213::method_0()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_82:; 	brtrue(IL_EA, logicnot:bool(call:bool(string::op_Equality, ldfld:string(Class213::string_0, ldloc:Class213(this)), ldsfld:string(string::Empty)))); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x04000605 RID: 1541
		public string string_0;
	}
}
