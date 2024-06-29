using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

// Token: 0x0200018D RID: 397
public sealed class GClass26 : IDisposable
{
	// Token: 0x06000A15 RID: 2581 RVA: 0x0002E0D0 File Offset: 0x0002C2D0
	public GClass26(string string_0)
	{
		FileStream stream = new FileStream(string_0, FileMode.Create);
		this.zipArchive_0 = new ZipArchive(stream, ZipArchiveMode.Create);
	}

	// Token: 0x06000A16 RID: 2582 RVA: 0x0002E0F8 File Offset: 0x0002C2F8
	public void method_0(ValueTuple<string, byte[]>[] valueTuple_0)
	{
		this.method_1(valueTuple_0);
	}

	// Token: 0x06000A17 RID: 2583 RVA: 0x0002E104 File Offset: 0x0002C304
	public void method_1(IEnumerable<ValueTuple<string, byte[]>> ienumerable_0)
	{
		foreach (ValueTuple<string, byte[]> valueTuple in ienumerable_0)
		{
			using (Stream stream = this.zipArchive_0.CreateEntry(valueTuple.Item1).Open())
			{
				stream.Write(valueTuple.Item2, 0, valueTuple.Item2.Length);
			}
		}
	}

	// Token: 0x06000A18 RID: 2584 RVA: 0x0002E198 File Offset: 0x0002C398
	public void Dispose()
	{
		ZipArchive zipArchive = this.zipArchive_0;
		if (zipArchive == null)
		{
			return;
		}
		zipArchive.Dispose();
	}

	// Token: 0x040005E2 RID: 1506
	private ZipArchive zipArchive_0;
}
