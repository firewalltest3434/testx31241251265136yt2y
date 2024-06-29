using System;
using System.Collections.Generic;

// Token: 0x02000459 RID: 1113
public static class GClass127
{
	// Token: 0x060018B3 RID: 6323 RVA: 0x000666E8 File Offset: 0x000648E8
	// Note: this type is marked as 'beforefieldinit'.
	static GClass127()
	{
		List<GClass149> list = new List<GClass149>();
		GClass149 gclass = new GClass149();
		gclass.method_1("root\\umbus");
		gclass.Description = Class364.smethod_0(string.Empty);
		list.Add(gclass);
		GClass149 gclass2 = new GClass149();
		gclass2.method_1("ROOT\\VID");
		gclass2.Description = Class364.smethod_0(string.Empty);
		list.Add(gclass2);
		GClass149 gclass3 = new GClass149();
		gclass3.method_1("ROOT\\vdrvroot");
		gclass3.Description = Class364.smethod_0(string.Empty);
		list.Add(gclass3);
		GClass149 gclass4 = new GClass149();
		gclass4.method_1("ROOT\\NdisVirtualBus");
		gclass4.Description = Class364.smethod_0(string.Empty);
		list.Add(gclass4);
		GClass149 gclass5 = new GClass149();
		gclass5.method_1("ROOT\\CompositeBus");
		gclass5.Description = Class364.smethod_0(string.Empty);
		list.Add(gclass5);
		GClass149 gclass6 = new GClass149();
		gclass6.method_1("ACPI\\VEN_PNP&DEV_0103");
		gclass6.Description = Class364.smethod_0(string.Empty);
		list.Add(gclass6);
		GClass149 gclass7 = new GClass149();
		gclass7.method_1("ACPI\\VEN_PNP&DEV_0000");
		gclass7.Description = Class364.smethod_0(string.Empty);
		list.Add(gclass7);
		GClass149 gclass8 = new GClass149();
		gclass8.method_1("ROOT\\RDPBUS");
		gclass8.Description = Class364.smethod_0(string.Empty);
		list.Add(gclass8);
		GClass149 gclass9 = new GClass149();
		gclass9.method_1("ACPI\\VEN_PNP&DEV_0C04");
		gclass9.Description = Class364.smethod_0(string.Empty);
		list.Add(gclass9);
		GClass127.list_2 = list;
	}

	// Token: 0x04001142 RID: 4418
	public static List<string> list_0 = new List<string>
	{
		"ROOT\\umbus",
		"ROOT\\vdrvroot",
		"ROOT\\NdisVirtualBus",
		"ROOT\\CompositeBus"
	};

	// Token: 0x04001143 RID: 4419
	public static List<string> list_1 = new List<string>
	{
		"ROOT\\CompositeBus",
		"ROOT\\umbus",
		"ROOT\\vdrvroot",
		"ROOT\\NdisVirtualBus"
	};

	// Token: 0x04001144 RID: 4420
	public static List<GClass149> list_2;
}
