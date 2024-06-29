using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows;
using ns0;

// Token: 0x02000239 RID: 569
internal sealed class Class292
{
	// Token: 0x06000D8F RID: 3471 RVA: 0x0003BF9C File Offset: 0x0003A19C
	private Class292()
	{
	}

	// Token: 0x06000D90 RID: 3472 RVA: 0x0003BFA4 File Offset: 0x0003A1A4
	public void method_0(Class292.Delegate25 delegate25_1)
	{
		Class292.Delegate25 @delegate = this.delegate25_0;
		Class292.Delegate25 delegate2;
		do
		{
			delegate2 = @delegate;
			Class292.Delegate25 value = (Class292.Delegate25)Delegate.Combine(delegate2, delegate25_1);
			@delegate = Interlocked.CompareExchange<Class292.Delegate25>(ref this.delegate25_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06000D91 RID: 3473 RVA: 0x0003BFDC File Offset: 0x0003A1DC
	public void method_1(Class292.Delegate25 delegate25_1)
	{
		Class292.Delegate25 @delegate = this.delegate25_0;
		Class292.Delegate25 delegate2;
		do
		{
			delegate2 = @delegate;
			Class292.Delegate25 value = (Class292.Delegate25)Delegate.Remove(delegate2, delegate25_1);
			@delegate = Interlocked.CompareExchange<Class292.Delegate25>(ref this.delegate25_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06000D92 RID: 3474 RVA: 0x0003C014 File Offset: 0x0003A214
	public static Class292 smethod_0()
	{
		if (Class292.class292_0 == null)
		{
			Class292.class292_0 = new Class292();
		}
		return Class292.class292_0;
	}

	// Token: 0x06000D93 RID: 3475 RVA: 0x0003C02C File Offset: 0x0003A22C
	public void method_2()
	{
		if (Class389.class504_0.method_62() != null && !(Class389.class504_0.method_62() == string.Empty))
		{
			this.method_4(Class389.class504_0.method_62());
			return;
		}
		this.method_4(CultureInfo.CurrentCulture.Name);
	}

	// Token: 0x06000D94 RID: 3476 RVA: 0x0003C07C File Offset: 0x0003A27C
	public void method_3(CultureInfo cultureInfo_0)
	{
		string text = cultureInfo_0.Name.ToString();
		if (cultureInfo_0.Name != "ru-RU" && cultureInfo_0.Name != "uk-UA" && cultureInfo_0.Name != "zh-CN")
		{
			text = "en-US";
		}
		dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_0(text);
		try
		{
			Class389.class504_0.method_63(text);
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(text);
			this.method_5(new CultureInfo(text));
		}
		catch
		{
			text = "en-US";
			Class389.class504_0.method_63(text);
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(text);
			this.method_5(new CultureInfo(text));
		}
	}

	// Token: 0x06000D95 RID: 3477 RVA: 0x0003C140 File Offset: 0x0003A340
	public void method_4(string string_0)
	{
		this.method_3(new CultureInfo(string_0));
	}

	// Token: 0x06000D96 RID: 3478 RVA: 0x0003C150 File Offset: 0x0003A350
	private void method_5(CultureInfo cultureInfo_0)
	{
		ResourceDictionary item = new ResourceDictionary
		{
			Source = new Uri(string.Format("pack://application:,,,/Resources/Localization/{0}.xaml", cultureInfo_0.Name))
		};
		ResourceDictionary resourceDictionary = Application.Current.Resources.MergedDictionaries.FirstOrDefault(new Func<ResourceDictionary, bool>(Class292.Class293.class293_0.method_0));
		if (resourceDictionary != null)
		{
			Application.Current.Resources.MergedDictionaries.Remove(resourceDictionary);
		}
		Application.Current.Resources.MergedDictionaries.Add(item);
		Class292.Delegate25 @delegate = this.delegate25_0;
		if (@delegate == null)
		{
			return;
		}
		@delegate(cultureInfo_0);
	}

	// Token: 0x04000864 RID: 2148
	private Class292.Delegate25 delegate25_0;

	// Token: 0x04000865 RID: 2149
	private static Class292 class292_0;

	// Token: 0x0200023A RID: 570
	// (Invoke) Token: 0x06000D98 RID: 3480
	public delegate void Delegate25(CultureInfo cultureInfo_0);

	// Token: 0x0200023B RID: 571
	[Serializable]
	private sealed class Class293
	{
		// Token: 0x06000D9D RID: 3485 RVA: 0x0003C208 File Offset: 0x0003A408
		internal bool method_0(ResourceDictionary resourceDictionary_0)
		{
			return resourceDictionary_0.Source.OriginalString.StartsWith("pack://application:,,,/Resources/Localization/");
		}

		// Token: 0x04000866 RID: 2150
		public static readonly Class292.Class293 class293_0 = new Class292.Class293();

		// Token: 0x04000867 RID: 2151
		public static Func<ResourceDictionary, bool> func_0;
	}
}
