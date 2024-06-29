using System;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Web;
using System.Xml.Serialization;

// Token: 0x020002C3 RID: 707
internal sealed class Class351 : WebClient
{
	// Token: 0x0600104B RID: 4171 RVA: 0x00045200 File Offset: 0x00043400
	public Class351()
	{
		this.method_1(10);
	}

	// Token: 0x0600104C RID: 4172 RVA: 0x00045210 File Offset: 0x00043410
	public int method_0()
	{
		return this.int_0;
	}

	// Token: 0x0600104D RID: 4173 RVA: 0x00045218 File Offset: 0x00043418
	public void method_1(int int_1)
	{
		this.int_0 = int_1;
	}

	// Token: 0x0600104E RID: 4174 RVA: 0x00045224 File Offset: 0x00043424
	public T method_2<T>(string string_0)
	{
		string s = base.DownloadString(string_0);
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
		StringReader stringReader = new StringReader(s);
		T result;
		try
		{
			result = (T)((object)xmlSerializer.Deserialize(stringReader));
		}
		finally
		{
			((IDisposable)stringReader).Dispose();
		}
		return result;
	}

	// Token: 0x0600104F RID: 4175 RVA: 0x00045278 File Offset: 0x00043478
	protected override WebRequest GetWebRequest(Uri address)
	{
		HttpWebRequest httpWebRequest = base.GetWebRequest(Class351.smethod_0(address)) as HttpWebRequest;
		httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36";
		httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7";
		httpWebRequest.CachePolicy = new RequestCachePolicy(RequestCacheLevel.BypassCache);
		httpWebRequest.ServicePoint.ConnectionLimit = this.method_0();
		return httpWebRequest;
	}

	// Token: 0x06001050 RID: 4176 RVA: 0x000452CC File Offset: 0x000434CC
	private static Uri smethod_0(Uri uri_0)
	{
		UriBuilder uriBuilder = new UriBuilder(uri_0);
		NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(uriBuilder.Query);
		nameValueCollection["x"] = DateTime.Now.ToFileTime().ToString(CultureInfo.InvariantCulture);
		uriBuilder.Query = nameValueCollection.ToString();
		return uriBuilder.Uri;
	}

	// Token: 0x040009BF RID: 2495
	private int int_0;
}
