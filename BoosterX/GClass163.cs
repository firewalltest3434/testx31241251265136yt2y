using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Token: 0x02000560 RID: 1376
public sealed class GClass163
{
	// Token: 0x06001DD9 RID: 7641 RVA: 0x0007D4CC File Offset: 0x0007B6CC
	public GClass163()
	{
		this.GClass170_0 = GClass170.smethod_2();
	}

	// Token: 0x06001DDA RID: 7642 RVA: 0x0007D4EC File Offset: 0x0007B6EC
	public GClass163(GClass170 gclass170_0, string string_3)
	{
		this.GClass170_0 = gclass170_0;
		this.String_1 = string_3;
	}

	// Token: 0x06001DDB RID: 7643 RVA: 0x0007D510 File Offset: 0x0007B710
	public GClass163(GClass170 gclass170_0, string string_3, params GClass163.GClass164[] gclass164_0)
	{
		this.GClass170_0 = gclass170_0;
		this.String_1 = string_3;
		this.List_0.AddRange(gclass164_0);
	}

	// Token: 0x170004A2 RID: 1186
	// (get) Token: 0x06001DDC RID: 7644 RVA: 0x0007D540 File Offset: 0x0007B740
	// (set) Token: 0x06001DDD RID: 7645 RVA: 0x0007D548 File Offset: 0x0007B748
	[JsonProperty("role")]
	internal string String_0
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

	// Token: 0x170004A3 RID: 1187
	// (get) Token: 0x06001DDE RID: 7646 RVA: 0x0007D554 File Offset: 0x0007B754
	// (set) Token: 0x06001DDF RID: 7647 RVA: 0x0007D564 File Offset: 0x0007B764
	[JsonIgnore]
	public GClass170 GClass170_0
	{
		get
		{
			return GClass170.smethod_0(this.String_0);
		}
		set
		{
			this.String_0 = value.ToString();
		}
	}

	// Token: 0x170004A4 RID: 1188
	// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x0007D574 File Offset: 0x0007B774
	// (set) Token: 0x06001DE1 RID: 7649 RVA: 0x0007D57C File Offset: 0x0007B77C
	[JsonIgnore]
	public string String_1
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x170004A5 RID: 1189
	// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x0007D588 File Offset: 0x0007B788
	// (set) Token: 0x06001DE3 RID: 7651 RVA: 0x0007D590 File Offset: 0x0007B790
	[JsonIgnore]
	[Obsolete("This property has been renamed to TextContent.")]
	public string Content
	{
		get
		{
			return this.String_1;
		}
		set
		{
			this.String_1 = value;
		}
	}

	// Token: 0x170004A6 RID: 1190
	// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x0007D59C File Offset: 0x0007B79C
	// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x0007D630 File Offset: 0x0007B830
	[JsonConverter]
	[JsonProperty("content")]
	internal IList<GClass163.Class623> IList_0
	{
		get
		{
			List<GClass163.Class623> list = new List<GClass163.Class623>();
			if (!string.IsNullOrEmpty(this.String_1))
			{
				list.Add(new GClass163.Class623(this.String_1));
			}
			if (this.List_0 != null && this.List_0.Count > 0)
			{
				foreach (GClass163.GClass164 gclass164_ in this.List_0)
				{
					list.Add(new GClass163.Class623(gclass164_));
				}
			}
			return list;
		}
		set
		{
			foreach (GClass163.Class623 @class in value)
			{
				if (@class.Type == "text")
				{
					this.String_1 = @class.Text;
				}
				else if (@class.Type == "image_url")
				{
					this.List_0.Add(@class.GClass164_0);
				}
			}
		}
	}

	// Token: 0x170004A7 RID: 1191
	// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x0007D6B8 File Offset: 0x0007B8B8
	// (set) Token: 0x06001DE7 RID: 7655 RVA: 0x0007D6C0 File Offset: 0x0007B8C0
	[JsonProperty("name")]
	public string Name
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

	// Token: 0x170004A8 RID: 1192
	// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x0007D6CC File Offset: 0x0007B8CC
	// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x0007D6D4 File Offset: 0x0007B8D4
	[JsonIgnore]
	public List<GClass163.GClass164> List_0
	{
		get
		{
			return this.list_0;
		}
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x04001521 RID: 5409
	private string string_0;

	// Token: 0x04001522 RID: 5410
	private string string_1;

	// Token: 0x04001523 RID: 5411
	private string string_2;

	// Token: 0x04001524 RID: 5412
	private List<GClass163.GClass164> list_0 = new List<GClass163.GClass164>();

	// Token: 0x02000561 RID: 1377
	internal sealed class Class622 : JsonConverter
	{
		// Token: 0x06001DEB RID: 7659 RVA: 0x0007D6E8 File Offset: 0x0007B8E8
		public override bool CanConvert(Type type_0)
		{
			return true;
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x0007D6EC File Offset: 0x0007B8EC
		public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			JToken jtoken = JToken.Load(jsonReader_0);
			if (jtoken.Type == 1)
			{
				return jtoken.ToObject<IList<GClass163.Class623>>();
			}
			if (jtoken.Type == 8)
			{
				return new List<GClass163.Class623>
				{
					new GClass163.Class623(jtoken.ToObject<string>())
				};
			}
			return null;
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x0007D734 File Offset: 0x0007B934
		public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			jsonSerializer_0.Serialize(jsonWriter_0, object_0);
		}
	}

	// Token: 0x02000562 RID: 1378
	public sealed class GClass164
	{
		// Token: 0x06001DEE RID: 7662 RVA: 0x0007D740 File Offset: 0x0007B940
		public GClass164(string string_2, string string_3 = "auto")
		{
			this.String_0 = string_2;
			this.String_1 = string_3;
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x0007D764 File Offset: 0x0007B964
		public GClass164(byte[] byte_0, string string_2 = "auto")
		{
			this.String_0 = "data:image/jpeg;base64," + Convert.ToBase64String(byte_0);
			this.String_1 = string_2;
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x0007D794 File Offset: 0x0007B994
		// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x0007D79C File Offset: 0x0007B99C
		[JsonProperty("url")]
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

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x0007D7A8 File Offset: 0x0007B9A8
		// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x0007D7B0 File Offset: 0x0007B9B0
		[JsonProperty("detail")]
		public string String_1
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x0007D7BC File Offset: 0x0007B9BC
		public static GClass163.GClass164 smethod_0(string string_2, string string_3)
		{
			return new GClass163.GClass164(File.ReadAllBytes(string_2), string_3);
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x0007D7CC File Offset: 0x0007B9CC
		public static GClass163.GClass164 smethod_1(byte[] byte_0, string string_2)
		{
			return new GClass163.GClass164(byte_0, string_2);
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x0007D7D8 File Offset: 0x0007B9D8
		public static GClass163.GClass164 smethod_2(string string_2, string string_3)
		{
			return new GClass163.GClass164(string_2, string_3);
		}

		// Token: 0x04001525 RID: 5413
		private string string_0;

		// Token: 0x04001526 RID: 5414
		private string string_1 = "auto";
	}

	// Token: 0x02000563 RID: 1379
	internal sealed class Class623
	{
		// Token: 0x06001DF7 RID: 7671 RVA: 0x0007D7E4 File Offset: 0x0007B9E4
		public Class623()
		{
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x0007D7F8 File Offset: 0x0007B9F8
		public Class623(string string_2)
		{
			this.Text = string_2;
			this.Type = "text";
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x0007D820 File Offset: 0x0007BA20
		public Class623(GClass163.GClass164 gclass164_1)
		{
			this.GClass164_0 = gclass164_1;
			this.Type = "image_url";
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001DFA RID: 7674 RVA: 0x0007D848 File Offset: 0x0007BA48
		// (set) Token: 0x06001DFB RID: 7675 RVA: 0x0007D850 File Offset: 0x0007BA50
		[JsonProperty("type")]
		public string Type
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

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001DFC RID: 7676 RVA: 0x0007D85C File Offset: 0x0007BA5C
		// (set) Token: 0x06001DFD RID: 7677 RVA: 0x0007D878 File Offset: 0x0007BA78
		[JsonProperty("text")]
		public string Text
		{
			get
			{
				if (this.Type == "text")
				{
					return this.string_0;
				}
				return null;
			}
			set
			{
				this.string_0 = value;
				this.gclass164_0 = null;
				this.Type = "text";
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001DFE RID: 7678 RVA: 0x0007D894 File Offset: 0x0007BA94
		// (set) Token: 0x06001DFF RID: 7679 RVA: 0x0007D8B0 File Offset: 0x0007BAB0
		[JsonProperty("image_url")]
		public GClass163.GClass164 GClass164_0
		{
			get
			{
				if (this.Type == "image_url")
				{
					return this.gclass164_0;
				}
				return null;
			}
			set
			{
				this.gclass164_0 = value;
				this.string_0 = null;
				this.Type = "image_url";
			}
		}

		// Token: 0x04001527 RID: 5415
		private string string_0;

		// Token: 0x04001528 RID: 5416
		private GClass163.GClass164 gclass164_0;

		// Token: 0x04001529 RID: 5417
		private string string_1 = "text";
	}
}
