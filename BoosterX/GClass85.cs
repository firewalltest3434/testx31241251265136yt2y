using System;
using System.IO;
using System.IO.Compression;

// Token: 0x020002F2 RID: 754
public static class GClass85
{
	// Token: 0x06001122 RID: 4386 RVA: 0x000483D8 File Offset: 0x000465D8
	public static byte[] smethod_0(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("#=zDSHr2g0=");
		}
		byte[] result;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress);
			try
			{
				gzipStream.Write(byte_0, 0, byte_0.Length);
			}
			finally
			{
				((IDisposable)gzipStream).Dispose();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	// Token: 0x06001123 RID: 4387 RVA: 0x00048448 File Offset: 0x00046648
	public static byte[] smethod_1(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("#=zhzxiuvg=");
		}
		MemoryStream memoryStream = new MemoryStream(byte_0);
		byte[] result;
		try
		{
			GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
			try
			{
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					byte[] array = new byte[8192];
					int count;
					while ((count = gzipStream.Read(array, 0, array.Length)) != 0)
					{
						memoryStream2.Write(array, 0, count);
					}
					result = memoryStream2.ToArray();
				}
				finally
				{
					((IDisposable)memoryStream2).Dispose();
				}
			}
			finally
			{
				((IDisposable)gzipStream).Dispose();
			}
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return result;
	}
}
