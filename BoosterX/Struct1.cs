using System;
using System.Runtime.CompilerServices;

// Token: 0x02000020 RID: 32
internal struct Struct1
{
	// Token: 0x060000BC RID: 188 RVA: 0x00003E44 File Offset: 0x00002044
	public Struct1(string string_0)
	{
		this.class82_0 = new Class82
		{
			class94_0 = Class114.smethod_0(string_0)
		};
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00003E78 File Offset: 0x00002078
	private bool method_0(out string string_0)
	{
		string_0 = null;
		Class82 @class = this.class82_0;
		Class94 class2 = (@class != null) ? @class.class94_0 : null;
		if (class2 == null)
		{
			return true;
		}
		WeakReference weakReference_ = class2.weakReference_0;
		string_0 = (((weakReference_ != null) ? weakReference_.Target : null) as string);
		return string_0 != null;
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00003EC0 File Offset: 0x000020C0
	public string method_1()
	{
		string text;
		if (this.method_0(out text))
		{
			return text;
		}
		object obj = Struct1.object_0;
		lock (obj)
		{
			if (this.method_0(out text))
			{
				return text;
			}
			Class103 class103_ = this.class82_0.class94_0.class103_0;
			object obj2 = class103_.object_0;
			byte[] byte_;
			bool bool_;
			lock (obj2)
			{
				byte_ = class103_.byte_0;
				bool_ = class103_.bool_0;
				if (class103_.bool_1)
				{
					if (byte_ == null)
					{
						throw new Exception("Unable to decrypt string data: encrypted value is null");
					}
				}
				else
				{
					WeakReference weakReference_ = this.class82_0.class94_0.weakReference_1;
					string text2 = ((weakReference_ != null) ? weakReference_.Target : null) as string;
					if (text2 == null)
					{
						throw new Exception("Unable to obtain original string data");
					}
					text = string.Copy(text2);
					Class114.smethod_3(text2);
				}
				class103_.bool_1 = true;
			}
			if (text == null)
			{
				text = Class114.smethod_2(byte_, bool_);
			}
			this.method_3(text);
		}
		return text;
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00003FD8 File Offset: 0x000021D8
	public string method_2()
	{
		return this.method_1();
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00003FE0 File Offset: 0x000021E0
	private void method_3(string string_0)
	{
		Class11 @class;
		if (!Struct1.conditionalWeakTable_0.TryGetValue(string_0, out @class))
		{
			Class94 class2 = new Class94
			{
				class103_0 = new Class103(),
				weakReference_0 = new WeakReference(string_0),
				weakReference_1 = new WeakReference(string_0, true)
			};
			@class = new Class11(string_0, class2, class2.class103_0);
			Struct1.conditionalWeakTable_0.Add(string_0, @class);
		}
		this.class82_0.class94_0 = @class.class94_0;
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00004054 File Offset: 0x00002254
	public void method_4(string string_0)
	{
		object obj = Struct1.object_0;
		lock (obj)
		{
			if (string_0 == null)
			{
				this.class82_0 = null;
			}
			else
			{
				this.class82_0 = new Class82();
				this.method_3(string_0);
			}
		}
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x000040AC File Offset: 0x000022AC
	public void method_5(string string_0)
	{
		this.method_4(string_0);
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x000040B8 File Offset: 0x000022B8
	public void method_6()
	{
		this.method_4(null);
	}

	// Token: 0x04000035 RID: 53
	private static readonly ConditionalWeakTable<string, Class11> conditionalWeakTable_0 = new ConditionalWeakTable<string, Class11>();

	// Token: 0x04000036 RID: 54
	private static readonly object object_0 = new object();

	// Token: 0x04000037 RID: 55
	private Class82 class82_0;
}
