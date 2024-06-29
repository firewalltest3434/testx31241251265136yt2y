using System;

// Token: 0x020002C2 RID: 706
public static class GClass80
{
	// Token: 0x06001048 RID: 4168 RVA: 0x00045060 File Offset: 0x00043260
	public static Uri smethod_0(GEnum97 genum97_0, string string_0, GEnum26 genum26_0, GClass4 gclass4_0)
	{
		switch (genum26_0)
		{
		case (GEnum26)0:
			return new Uri(string.Format("{0}{1}?{2}", GClass73.smethod_0(genum97_0), string_0, gclass4_0.method_8()));
		case (GEnum26)1:
			return new Uri(string.Format("{0}lookup?alternateId=XboxTitleID&Value={1}&{2}&fieldsTemplate=Details", GClass73.smethod_0(genum97_0), string_0, gclass4_0.method_8()));
		case (GEnum26)2:
			return new Uri(string.Format("{0}lookup?alternateId=PackageFamilyName&Value={1}&{2}&fieldsTemplate=Details", GClass73.smethod_0(genum97_0), string_0, gclass4_0.method_8()));
		case (GEnum26)3:
			return new Uri(string.Format("{0}lookup?alternateId=CONTENTID&Value={1}&{2}&fieldsTemplate=Details", GClass73.smethod_0(genum97_0), string_0, gclass4_0.method_8()));
		case (GEnum26)4:
			return new Uri(string.Format("{0}lookup?alternateId=LegacyWindowsPhoneProductID&Value={1}&{2}&fieldsTemplate=Details", GClass73.smethod_0(genum97_0), string_0, gclass4_0.method_8()));
		case (GEnum26)5:
			return new Uri(string.Format("{0}lookup?alternateId=LegacyWindowsStoreProductID&Value={1}&{2}&fieldsTemplate=Details", GClass73.smethod_0(genum97_0), string_0, gclass4_0.method_8()));
		case (GEnum26)6:
			return new Uri(string.Format("{0}lookup?alternateId=LegacyXboxProductID&Value={1}&{2}&fieldsTemplate=Details", GClass73.smethod_0(genum97_0), string_0, gclass4_0.method_8()));
		default:
			throw new Exception("CreateAlternateDCatUri: Unknown IdentifierType was passed, an update is likely required, please report this issue.");
		}
	}

	// Token: 0x06001049 RID: 4169 RVA: 0x0004516C File Offset: 0x0004336C
	public static Uri smethod_1(GEnum97 genum97_0, GEnum49 genum49_0, GClass4 gclass4_0, string string_0)
	{
		return new Uri(string.Format("{0}{1}&productFamilyNames=apps,games&market={2}&languages={3}&platformDependencyName={4}", new object[]
		{
			GClass73.smethod_1(genum97_0),
			string_0,
			gclass4_0.method_0(),
			gclass4_0.method_2(),
			GClass73.smethod_2(genum49_0)
		}));
	}

	// Token: 0x0600104A RID: 4170 RVA: 0x000451C0 File Offset: 0x000433C0
	public static Uri smethod_2(GClass4 gclass4_0, string string_0)
	{
		return new Uri(string.Format("{0}?hl={1}&gl={2}&icid=CNavAppsWindowsApps&FilteredCategories=AllProducts&Query={3}", new object[]
		{
			GClass20.uri_17,
			gclass4_0.method_2(),
			gclass4_0.method_0(),
			string_0
		}));
	}
}
