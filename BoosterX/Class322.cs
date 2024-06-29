using System;
using System.Globalization;
using Material.Icons;

// Token: 0x0200027F RID: 639
internal sealed class Class322
{
	// Token: 0x06000EC5 RID: 3781 RVA: 0x0003FB30 File Offset: 0x0003DD30
	public object method_0(object object_0, Type type_0, object object_1, CultureInfo cultureInfo_0)
	{
		string a = object_0 as string;
		MaterialIconKind materialIconKind = 3110;
		if (!(a == "Group1"))
		{
			if (a == "Group2")
			{
				materialIconKind = 172;
			}
		}
		else
		{
			materialIconKind = 45;
		}
		return materialIconKind;
	}
}
