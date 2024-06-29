using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x0200025E RID: 606
public sealed class GClass67
{
	// Token: 0x17000199 RID: 409
	// (get) Token: 0x06000E2C RID: 3628 RVA: 0x0003E068 File Offset: 0x0003C268
	// (set) Token: 0x06000E2D RID: 3629 RVA: 0x0003E070 File Offset: 0x0003C270
	[JsonProperty("TweakType")]
	public string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x06000E2E RID: 3630 RVA: 0x0003E07C File Offset: 0x0003C27C
	// (set) Token: 0x06000E2F RID: 3631 RVA: 0x0003E084 File Offset: 0x0003C284
	[JsonProperty("Path")]
	public string Path
	{
		[CompilerGenerated]
		get
		{
			return this.string_1;
		}
		[CompilerGenerated]
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x06000E30 RID: 3632 RVA: 0x0003E090 File Offset: 0x0003C290
	// (set) Token: 0x06000E31 RID: 3633 RVA: 0x0003E098 File Offset: 0x0003C298
	[JsonProperty("Key")]
	public string Key
	{
		[CompilerGenerated]
		get
		{
			return this.string_2;
		}
		[CompilerGenerated]
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x1700019C RID: 412
	// (get) Token: 0x06000E32 RID: 3634 RVA: 0x0003E0A4 File Offset: 0x0003C2A4
	// (set) Token: 0x06000E33 RID: 3635 RVA: 0x0003E0AC File Offset: 0x0003C2AC
	[JsonProperty("Values")]
	public List<GClass72> Values
	{
		[CompilerGenerated]
		get
		{
			return this.list_0;
		}
		[CompilerGenerated]
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x1700019D RID: 413
	// (get) Token: 0x06000E34 RID: 3636 RVA: 0x0003E0B8 File Offset: 0x0003C2B8
	[JsonIgnore]
	public bool OnEdit
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700019E RID: 414
	// (get) Token: 0x06000E35 RID: 3637 RVA: 0x0003E0BC File Offset: 0x0003C2BC
	[JsonIgnore]
	public string Type
	{
		get
		{
			string text = this.String_0;
			if (text != null)
			{
				switch (text.Length)
				{
				case 3:
				{
					char c = text[0];
					if (c == 'B')
					{
						if (text == "BAT")
						{
							return "BAT";
						}
					}
					else if (c == 'R' && text == "REG")
					{
						return "REG";
					}
					break;
				}
				case 4:
					if (text == "TASK")
					{
						return "TASK";
					}
					break;
				case 6:
				{
					char c = text[0];
					if (c <= 'I')
					{
						if (c != 'D')
						{
							if (c == 'I')
							{
								if (text == "IMPORT")
								{
									return "IMPORT";
								}
							}
						}
						else if (text == "DEVICE")
						{
							return "DEVICE";
						}
					}
					else if (c != 'R')
					{
						if (c == 'S')
						{
							if (text == "SCRIPT")
							{
								return "SCRIPT";
							}
						}
					}
					else if (text == "REG_SZ")
					{
						return "REG";
					}
					break;
				}
				case 7:
					if (text == "BCDEDIT")
					{
						return "BCDEDIT";
					}
					break;
				case 8:
					if (text == "WEVTUTIL")
					{
						return "WEVTUTIL";
					}
					break;
				case 10:
					if (text == "REG_BINARY")
					{
						return "REG";
					}
					break;
				case 13:
					if (text == "REG_EXPAND_SZ")
					{
						return "REG";
					}
					break;
				}
			}
			return "UNKNOWN";
		}
	}

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x06000E36 RID: 3638 RVA: 0x0003E2A8 File Offset: 0x0003C4A8
	// (set) Token: 0x06000E37 RID: 3639 RVA: 0x0003E330 File Offset: 0x0003C530
	[JsonIgnore]
	public string RegType
	{
		get
		{
			string a = this.String_0;
			string result;
			if (!(a == "REG"))
			{
				if (!(a == "REG_SZ"))
				{
					if (!(a == "REG_BINARY"))
					{
						if (!(a == "REG_EXPAND_SZ"))
						{
							result = "HIDE";
						}
						else
						{
							result = "REG_EXPAND_SZ";
						}
					}
					else
					{
						result = "REG_BINARY";
					}
				}
				else
				{
					result = "REG_SZ";
				}
			}
			else
			{
				result = "REG_DWORD";
			}
			return result;
		}
		set
		{
			if (value == "REG_DWORD")
			{
				this.String_0 = "REG";
				return;
			}
			this.String_0 = value;
		}
	}

	// Token: 0x06000E38 RID: 3640 RVA: 0x0003E354 File Offset: 0x0003C554
	public bool method_0()
	{
		return this.Values.Any(new Func<GClass72, bool>(GClass67.Class308.class308_0.method_0));
	}

	// Token: 0x06000E39 RID: 3641 RVA: 0x0003E380 File Offset: 0x0003C580
	public bool method_1()
	{
		return this.Values.Any(new Func<GClass72, bool>(GClass67.Class308.class308_0.method_1));
	}

	// Token: 0x06000E3A RID: 3642 RVA: 0x0003E3AC File Offset: 0x0003C5AC
	public bool method_2()
	{
		return this.Values.Any(new Func<GClass72, bool>(GClass67.Class308.class308_0.method_2));
	}

	// Token: 0x06000E3B RID: 3643 RVA: 0x0003E3D8 File Offset: 0x0003C5D8
	public bool method_3()
	{
		return this.Values.Any(new Func<GClass72, bool>(GClass67.Class308.class308_0.method_3));
	}

	// Token: 0x040008AF RID: 2223
	private string string_0;

	// Token: 0x040008B0 RID: 2224
	private string string_1;

	// Token: 0x040008B1 RID: 2225
	private string string_2;

	// Token: 0x040008B2 RID: 2226
	private List<GClass72> list_0;

	// Token: 0x0200025F RID: 607
	[Serializable]
	private sealed class Class308
	{
		// Token: 0x06000E3E RID: 3646 RVA: 0x0003E418 File Offset: 0x0003C618
		internal bool method_0(GClass72 gclass72_0)
		{
			return gclass72_0.method_0();
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0003E420 File Offset: 0x0003C620
		internal bool method_1(GClass72 gclass72_0)
		{
			return gclass72_0.method_1();
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0003E428 File Offset: 0x0003C628
		internal bool method_2(GClass72 gclass72_0)
		{
			return gclass72_0.ContainsBest;
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0003E430 File Offset: 0x0003C630
		internal bool method_3(GClass72 gclass72_0)
		{
			return gclass72_0.method_2();
		}

		// Token: 0x040008B3 RID: 2227
		public static readonly GClass67.Class308 class308_0 = new GClass67.Class308();

		// Token: 0x040008B4 RID: 2228
		public static Func<GClass72, bool> func_0;

		// Token: 0x040008B5 RID: 2229
		public static Func<GClass72, bool> func_1;

		// Token: 0x040008B6 RID: 2230
		public static Func<GClass72, bool> func_2;

		// Token: 0x040008B7 RID: 2231
		public static Func<GClass72, bool> func_3;
	}
}
