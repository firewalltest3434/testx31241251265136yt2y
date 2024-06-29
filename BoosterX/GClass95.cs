using System;
using System.Text.RegularExpressions;

// Token: 0x0200030D RID: 781
public sealed class GClass95
{
	// Token: 0x06001218 RID: 4632 RVA: 0x0004A880 File Offset: 0x00048A80
	public static GClass81 smethod_0(string string_0)
	{
		if (!GClass95.regex_0.IsMatch(string_0))
		{
			throw new GException0();
		}
		int[] int_ = GClass63.smethod_0(string_0.Substring(4).Replace("-", string.Empty));
		return new GClass81(string_0, int_);
	}

	// Token: 0x04000AD8 RID: 2776
	private static Regex regex_0 = new Regex("^CSGO(-?[\\w]{5}){5}$");
}
