using System;
using System.Linq;
using System.Management;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

// Token: 0x020005E7 RID: 1511
internal sealed class Class672
{
	// Token: 0x060020E7 RID: 8423 RVA: 0x00084FA4 File Offset: 0x000831A4
	public static string smethod_0(string string_0)
	{
		string result;
		try
		{
			result = Class672.smethod_1(BitConverter.ToString((byte[])Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Enum\\" + string_0 + "\\Device Parameters\\Interrupt Management\\Affinity Policy").GetValue("AssignmentSetOverride")));
		}
		catch
		{
			result = "default";
		}
		return result;
	}

	// Token: 0x060020E8 RID: 8424 RVA: 0x00085004 File Offset: 0x00083204
	private static string smethod_1(string string_0)
	{
		string text = string.Empty;
		if (string_0.Length > 2)
		{
			string[] array = string_0.Split(new char[]
			{
				'-'
			});
			Array.Reverse(array);
			foreach (string str in array)
			{
				text += str;
			}
		}
		else
		{
			text = string_0;
		}
		uint num = 0U;
		string text2 = "ERROR";
		bool flag = false;
		ulong num2 = Convert.ToUInt64(text, 16);
		while (num2 > 0UL)
		{
			if ((num2 & 1UL) == 1UL)
			{
				if (!flag)
				{
					text2 = Conversions.ToString(num);
					flag = true;
				}
				else
				{
					text2 = text2 + ", " + Conversions.ToString(num);
				}
			}
			num2 /= 2UL;
			num = checked((uint)(unchecked((ulong)num) + 1UL));
		}
		return text2;
	}

	// Token: 0x060020E9 RID: 8425 RVA: 0x000850F4 File Offset: 0x000832F4
	public static string smethod_2(ManagementObject managementObject_0)
	{
		string result = string.Empty;
		string value = string.Empty;
		foreach (PropertyData propertyData in managementObject_0.Properties)
		{
			if (propertyData.Name == "PNPDeviceID")
			{
				value = propertyData.Value.ToString();
			}
		}
		foreach (ManagementObject managementObject in new ManagementObjectSearcher(null, "SELECT * FROM Win32_PnPEntity").Get().OfType<ManagementObject>())
		{
			object[] array = new object[2];
			array[0] = new string[]
			{
				"DEVPKEY_Device_InstanceId",
				"DEVPKEY_Device_LastKnownParent"
			};
			object[] array2 = array;
			managementObject.InvokeMethod("GetDeviceProperties", array2);
			ManagementBaseObject[] array3 = (ManagementBaseObject[])array2[1];
			PropertyData propertyData2 = array3[0].Properties.OfType<PropertyData>().FirstOrDefault(new Func<PropertyData, bool>(Class672.Class673.class673_0.method_0));
			object obj = (propertyData2 != null) ? propertyData2.Value : null;
			if (obj != null && obj.ToString().Contains(value))
			{
				PropertyData propertyData3 = array3[1].Properties.OfType<PropertyData>().FirstOrDefault(new Func<PropertyData, bool>(Class672.Class673.class673_0.method_1));
				result = ((propertyData3 != null) ? propertyData3.Value : null).ToString();
			}
		}
		return result;
	}

	// Token: 0x060020EA RID: 8426 RVA: 0x00085294 File Offset: 0x00083494
	public static ManagementObject smethod_3(string string_0)
	{
		ManagementObject result = null;
		foreach (ManagementObject managementObject in new ManagementObjectSearcher(null, "SELECT * FROM Win32_PnPEntity").Get().OfType<ManagementObject>())
		{
			object[] array = new object[2];
			array[0] = new string[]
			{
				"DEVPKEY_Device_InstanceId"
			};
			object[] array2 = array;
			managementObject.InvokeMethod("GetDeviceProperties", array2);
			PropertyData propertyData = ((ManagementBaseObject[])array2[1])[0].Properties.OfType<PropertyData>().FirstOrDefault(new Func<PropertyData, bool>(Class672.Class673.class673_0.method_2));
			object obj = (propertyData != null) ? propertyData.Value : null;
			if (obj != null && obj.ToString() == string_0.ToUpper())
			{
				result = managementObject;
			}
		}
		return result;
	}

	// Token: 0x060020EB RID: 8427 RVA: 0x00085378 File Offset: 0x00083578
	public static string smethod_4(string string_0)
	{
		/*
An exception occurred when decompiling this method (060020EB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Class672::smethod_4(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_79:; 	brtrue(IL_1EE, cle:bool(callvirtgetter:int32(string::get_Length, ldloc:string(var_0)), ldc.i4:int32(0))); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
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

	// Token: 0x060020EC RID: 8428 RVA: 0x00085B68 File Offset: 0x00083D68
	private static string smethod_5(int int_0)
	{
		string result = "0";
		if (int_0 % 4 == 1)
		{
			result = "1";
		}
		else if (int_0 % 4 == 2)
		{
			result = "2";
		}
		else if (int_0 % 4 == 3)
		{
			result = "4";
		}
		else if (int_0 % 4 == 0)
		{
			result = "8";
		}
		return result;
	}

	// Token: 0x020005E8 RID: 1512
	[Serializable]
	private sealed class Class673
	{
		// Token: 0x060020EF RID: 8431 RVA: 0x00085BC8 File Offset: 0x00083DC8
		internal bool method_0(PropertyData propertyData_0)
		{
			return propertyData_0.Name == "Data";
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x00085BDC File Offset: 0x00083DDC
		internal bool method_1(PropertyData propertyData_0)
		{
			return propertyData_0.Name == "Data";
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x00085BF0 File Offset: 0x00083DF0
		internal bool method_2(PropertyData propertyData_0)
		{
			return propertyData_0.Name == "Data";
		}

		// Token: 0x040016B9 RID: 5817
		public static readonly Class672.Class673 class673_0 = new Class672.Class673();

		// Token: 0x040016BA RID: 5818
		public static Func<PropertyData, bool> func_0;

		// Token: 0x040016BB RID: 5819
		public static Func<PropertyData, bool> func_1;

		// Token: 0x040016BC RID: 5820
		public static Func<PropertyData, bool> func_2;
	}
}
