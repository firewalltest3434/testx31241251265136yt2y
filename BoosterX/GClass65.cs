using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000254 RID: 596
public static class GClass65
{
	// Token: 0x06000DF2 RID: 3570 RVA: 0x0003D638 File Offset: 0x0003B838
	public static string smethod_0(this string string_0, string string_1)
	{
		GClass65.Class305 @class = new GClass65.Class305();
		@class.string_0 = string_1;
		string text = string.Empty;
		try
		{
			text = string_0.Split(new char[]
			{
				'\n'
			}).ToList<string>().First(new Func<string, bool>(@class.method_0)).Split(new char[]
			{
				':'
			}).Last<string>();
			int i;
			for (i = 0; i < text.Length; i++)
			{
				if (text[i] != ' ')
				{
					break;
				}
			}
			text = text.Substring(i);
		}
		catch (object obj)
		{
		}
		return text.Replace("\r", string.Empty);
	}

	// Token: 0x06000DF3 RID: 3571 RVA: 0x0003D6F8 File Offset: 0x0003B8F8
	public static string smethod_1(this string string_0, int int_0)
	{
		return string_0.Split(new char[]
		{
			'\n'
		})[int_0].Replace("\r", string.Empty);
	}

	// Token: 0x06000DF4 RID: 3572 RVA: 0x0003D71C File Offset: 0x0003B91C
	public static bool smethod_2(this string string_0, string string_1)
	{
		return string_0.IndexOf(string_1, StringComparison.OrdinalIgnoreCase) >= 0;
	}

	// Token: 0x06000DF5 RID: 3573 RVA: 0x0003D72C File Offset: 0x0003B92C
	public static string smethod_3(this string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("#=z4K5Kdsw=");
		}
		if (string_0 == string.Empty)
		{
			throw new ArgumentException("input cannot be empty", "#=z4K5Kdsw=");
		}
		return string_0[0].ToString().ToUpper() + string_0.Substring(1);
	}

	// Token: 0x06000DF6 RID: 3574 RVA: 0x0003D78C File Offset: 0x0003B98C
	public static IEnumerable<string> smethod_4(this string string_0, int int_0)
	{
		return new GClass65.Class306(-2)
		{
			string_2 = string_0,
			int_3 = int_0
		};
	}

	// Token: 0x02000255 RID: 597
	private sealed class Class305
	{
		// Token: 0x06000DF8 RID: 3576 RVA: 0x0003D7AC File Offset: 0x0003B9AC
		internal bool method_0(string string_1)
		{
			return string_1.StartsWith(this.string_0);
		}

		// Token: 0x04000893 RID: 2195
		public string string_0;
	}

	// Token: 0x02000256 RID: 598
	private sealed class Class306 : IEnumerator<string>, IEnumerable<string>, IDisposable, IEnumerable, IEnumerator
	{
		// Token: 0x06000DF9 RID: 3577 RVA: 0x0003D7BC File Offset: 0x0003B9BC
		public Class306(int int_5)
		{
			this.int_0 = int_5;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x0003D7D8 File Offset: 0x0003B9D8
		void IDisposable.Dispose()
		{
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x0003D7DC File Offset: 0x0003B9DC
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.int_0 = -1;
				this.int_4 += this.int_2;
			}
			else
			{
				this.int_0 = -1;
				if (this.string_1 == null)
				{
					throw new ArgumentNullException("s");
				}
				if (this.int_2 <= 0)
				{
					throw new ArgumentException("Part length has to be positive.", "partLength");
				}
				this.int_4 = 0;
			}
			if (this.int_4 >= this.string_1.Length)
			{
				return false;
			}
			this.string_0 = this.string_1.Substring(this.int_4, Math.Min(this.int_2, this.string_1.Length - this.int_4));
			this.int_0 = 1;
			return true;
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x0003D8B8 File Offset: 0x0003BAB8
		string IEnumerator<string>.p000001
		{
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x0003D8C0 File Offset: 0x0003BAC0
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x0003D8C8 File Offset: 0x0003BAC8
		object IEnumerator.Current
		{
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x0003D8D0 File Offset: 0x0003BAD0
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			GClass65.Class306 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new GClass65.Class306(0);
			}
			@class.string_1 = this.string_2;
			@class.int_2 = this.int_3;
			return @class;
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x0003D920 File Offset: 0x0003BB20
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000894 RID: 2196
		private int int_0;

		// Token: 0x04000895 RID: 2197
		private string string_0;

		// Token: 0x04000896 RID: 2198
		private int int_1;

		// Token: 0x04000897 RID: 2199
		private string string_1;

		// Token: 0x04000898 RID: 2200
		public string string_2;

		// Token: 0x04000899 RID: 2201
		private int int_2;

		// Token: 0x0400089A RID: 2202
		public int int_3;

		// Token: 0x0400089B RID: 2203
		private int int_4;
	}
}
