using System;
using System.Drawing;
using System.IO;
using System.Windows.Media.Imaging;

// Token: 0x020001F3 RID: 499
internal sealed class Class267
{
	// Token: 0x06000BFA RID: 3066 RVA: 0x00036D30 File Offset: 0x00034F30
	public static Bitmap smethod_0(string string_0)
	{
		BitmapImage bitmapImage = new BitmapImage();
		bitmapImage.BeginInit();
		bitmapImage.UriSource = new Uri(string_0, UriKind.RelativeOrAbsolute);
		bitmapImage.EndInit();
		MemoryStream memoryStream = new MemoryStream();
		Bitmap result;
		try
		{
			new PngBitmapEncoder
			{
				Frames = 
				{
					BitmapFrame.Create(bitmapImage)
				}
			}.Save(memoryStream);
			result = new Bitmap(memoryStream);
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return result;
	}

	// Token: 0x06000BFB RID: 3067 RVA: 0x00036DA0 File Offset: 0x00034FA0
	public static byte[] smethod_1(string string_0)
	{
		BitmapImage bitmapImage = new BitmapImage();
		bitmapImage.BeginInit();
		bitmapImage.UriSource = new Uri(string_0, UriKind.RelativeOrAbsolute);
		bitmapImage.EndInit();
		MemoryStream memoryStream = new MemoryStream();
		byte[] result;
		try
		{
			new PngBitmapEncoder
			{
				Frames = 
				{
					BitmapFrame.Create(bitmapImage)
				}
			}.Save(memoryStream);
			result = memoryStream.ToArray();
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return result;
	}
}
