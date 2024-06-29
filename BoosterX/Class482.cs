using System;
using System.IO;
using ns0;

// Token: 0x02000426 RID: 1062
internal sealed class Class482
{
	// Token: 0x06001769 RID: 5993 RVA: 0x00061C38 File Offset: 0x0005FE38
	public static byte[] smethod_0(Class660 class660_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		long value = class660_0.DateTime_0.smethod_0();
		binaryWriter.Write(value);
		foreach (Class188 @class in class660_0.List_0)
		{
			if (@class != null && @class.State != null && @class.Name != null)
			{
				binaryWriter.Write(@class.State);
				binaryWriter.Write(@class.Name);
				binaryWriter.Write((byte)@class.Type);
			}
		}
		return GClass85.smethod_0(memoryStream.ToArray()).smethod_2(2);
	}

	// Token: 0x0600176A RID: 5994 RVA: 0x00061CF0 File Offset: 0x0005FEF0
	public static Class660 smethod_1(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream(GClass85.smethod_1(byte_0.smethod_2(2)));
		BinaryReader binaryReader = new BinaryReader(memoryStream);
		Class660 @class = new Class660();
		DateTime dateTime_ = binaryReader.ReadInt64().smethod_1();
		@class.DateTime_0 = dateTime_;
		while (memoryStream.Position < memoryStream.Length)
		{
			@class.List_0.Add(new Class188
			{
				State = binaryReader.ReadString(),
				Name = binaryReader.ReadString(),
				Type = (dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd)binaryReader.ReadByte()
			});
		}
		return @class;
	}
}
