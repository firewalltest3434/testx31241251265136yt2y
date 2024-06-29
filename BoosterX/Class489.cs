using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

// Token: 0x02000430 RID: 1072
internal static class Class489
{
	// Token: 0x06001790 RID: 6032 RVA: 0x00062A84 File Offset: 0x00060C84
	public static string smethod_0(this string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return string_1;
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		for (int i = string_1.Length - 1; i >= 0; i--)
		{
			num++;
			stringBuilder.Insert(0, string_1[i]);
			if (num % 3 == 0 && i != 0)
			{
				stringBuilder.Insert(0, " ");
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06001791 RID: 6033 RVA: 0x00062AE4 File Offset: 0x00060CE4
	public static bool smethod_1(this string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return true;
		}
		char c = string_1[0];
		for (int i = 1; i < string_1.Length; i++)
		{
			if (string_1[i] != c)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06001792 RID: 6034 RVA: 0x00062B34 File Offset: 0x00060D34
	public static string smethod_2(this string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return string_1;
		}
		string_1 = string_1.Trim();
		if (string_1.StartsWith("\"") && string_1.EndsWith("\""))
		{
			string_1 = string_1.Substring(1, string_1.Length - 2);
		}
		int num = string_1.IndexOf(" --");
		if (num == -1)
		{
			num = string_1.IndexOf(" -");
		}
		if (num != -1)
		{
			string_1 = string_1.Substring(0, num);
		}
		return string_1;
	}

	// Token: 0x06001793 RID: 6035 RVA: 0x00062BC0 File Offset: 0x00060DC0
	public static bool smethod_3(this string string_1)
	{
		string source = "0123456789";
		if (string.IsNullOrEmpty(string_1))
		{
			return true;
		}
		for (int i = 1; i < string_1.Length; i++)
		{
			if (!source.Contains(string_1[i]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06001794 RID: 6036 RVA: 0x00062C10 File Offset: 0x00060E10
	public static bool smethod_4(this string string_1)
	{
		string source = "0123456789abcdefABCDEF";
		if (string.IsNullOrEmpty(string_1))
		{
			return true;
		}
		for (int i = 1; i < string_1.Length; i++)
		{
			if (!source.Contains(string_1[i]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06001795 RID: 6037 RVA: 0x00062C60 File Offset: 0x00060E60
	public static string smethod_5(this string string_1)
	{
		if (string_1.smethod_2("S-1-5-21-3909295115-2706604896-3339360243-500"))
		{
			return string_1.Replace("S-1-5-21-3909295115-2706604896-3339360243-500", string.Empty);
		}
		string pattern = "_[0-9A-Fa-f]{32}";
		string_1 = Regex.Replace(string_1, "\\{\\b[A-Fa-f0-9]{8}(?:-[A-Fa-f0-9]{4}){3}-[A-Fa-f0-9]{12}\\b\\}", string.Empty);
		string_1 = Regex.Replace(string_1, pattern, string.Empty);
		return string_1;
	}

	// Token: 0x06001796 RID: 6038 RVA: 0x00062CBC File Offset: 0x00060EBC
	public static bool smethod_6(this string string_1)
	{
		return new Regex("^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$").IsMatch(string_1);
	}

	// Token: 0x06001797 RID: 6039 RVA: 0x00062CD0 File Offset: 0x00060ED0
	public static bool smethod_7(this string string_1)
	{
		return string_1 == null || !string_1.Any<char>() || string_1 == "null";
	}

	// Token: 0x06001798 RID: 6040 RVA: 0x00062CEC File Offset: 0x00060EEC
	public static bool smethod_8(this string string_1, string string_2)
	{
		List<string> list = string_1.ToLower().Split(new char[]
		{
			' '
		}).ToList<string>();
		for (int i = 0; i < list.Count; i++)
		{
			List<int> list2 = new List<int>();
			for (int j = i; j < list.Count; j++)
			{
				list2.Add(j);
				List<string> list3 = new List<string>();
				foreach (int index in list2)
				{
					list3.Add(list[index]);
				}
				string string_3 = string.Join(" ", list3);
				if (string_2.smethod_9(string_3) <= 2)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001799 RID: 6041 RVA: 0x00062DD0 File Offset: 0x00060FD0
	public static int smethod_9(this string string_1, string string_2)
	{
		return Class489.smethod_10(string_1, string_2);
	}

	// Token: 0x0600179A RID: 6042 RVA: 0x00062DDC File Offset: 0x00060FDC
	public static int smethod_10(string string_1, string string_2)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			if (!string.IsNullOrEmpty(string_2))
			{
				return string_2.Length;
			}
			return 0;
		}
		else
		{
			if (!string.IsNullOrEmpty(string_2))
			{
				int length = string_1.Length;
				int length2 = string_2.Length;
				int[,] array = new int[length + 1, length2 + 1];
				for (int i = 0; i <= array.GetUpperBound(0); i++)
				{
					array[i, 0] = i;
				}
				for (int j = 0; j <= array.GetUpperBound(1); j++)
				{
					array[0, j] = j;
				}
				for (int k = 1; k <= array.GetUpperBound(0); k++)
				{
					for (int l = 1; l <= array.GetUpperBound(1); l++)
					{
						int num;
						if (string_1[k - 1] == string_2[l - 1])
						{
							num = 0;
						}
						else
						{
							num = 1;
						}
						int val = array[k - 1, l] + 1;
						int val2 = array[k, l - 1] + 1;
						int val3 = array[k - 1, l - 1] + num;
						array[k, l] = Math.Min(val, Math.Min(val2, val3));
						if (k > 1 && l > 1 && string_1[k - 1] == string_2[l - 2] && string_1[k - 2] == string_2[l - 1])
						{
							array[k, l] = Math.Min(array[k, l], array[k - 2, l - 2] + num);
						}
					}
				}
				return array[array.GetUpperBound(0), array.GetUpperBound(1)];
			}
			if (!string.IsNullOrEmpty(string_1))
			{
				return string_1.Length;
			}
			return 0;
		}
	}

	// Token: 0x0600179B RID: 6043 RVA: 0x00062F6C File Offset: 0x0006116C
	public static string[] smethod_11(this object object_0, string[] string_1)
	{
		List<string> list = new List<string>();
		foreach (string text in object_0 as string[])
		{
			for (int j = 0; j < string_1.Length; j++)
			{
				if (string_1[j] != text)
				{
					list.Add(text);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600179C RID: 6044 RVA: 0x00062FDC File Offset: 0x000611DC
	public static string smethod_12(this object object_0)
	{
		return object_0.ToString().Split(new char[]
		{
			','
		})[0];
	}

	// Token: 0x0600179D RID: 6045 RVA: 0x00062FF8 File Offset: 0x000611F8
	public static string smethod_13(string string_1, int int_0, char char_0)
	{
		if (string_1.Length >= int_0)
		{
			return string_1;
		}
		string text = string_1;
		for (int i = 0; i < int_0 - string_1.Length; i++)
		{
			text += char_0.ToString();
		}
		return text;
	}

	// Token: 0x0600179E RID: 6046 RVA: 0x00063044 File Offset: 0x00061244
	public static string smethod_14(string string_1, int int_0)
	{
		string text = string_1.Replace('.', ',');
		if (!text.Contains(","))
		{
			return text;
		}
		char[] array = text.Split(new char[]
		{
			','
		})[1].ToCharArray();
		if (array.Length == 0)
		{
			return text.Replace(",", string.Empty);
		}
		if (array.Length > 1)
		{
			string text2 = text.Split(new char[]
			{
				','
			})[0] + ",";
			for (int i = 0; i < int_0; i++)
			{
				text2 += array[i].ToString();
			}
			return text2;
		}
		return text;
	}

	// Token: 0x0600179F RID: 6047 RVA: 0x000630F0 File Offset: 0x000612F0
	public static string smethod_15(this string string_1, int int_0)
	{
		string text = string_1.Replace('.', ',');
		if (!text.Contains(","))
		{
			return text;
		}
		char[] array = text.Split(new char[]
		{
			','
		})[1].ToCharArray();
		if (array.Length == 0)
		{
			return text.Replace(",", string.Empty);
		}
		if (array.Length > 1)
		{
			string text2 = text.Split(new char[]
			{
				','
			})[0] + ",";
			for (int i = 0; i < int_0; i++)
			{
				text2 += array[i].ToString();
			}
			return text2;
		}
		return text;
	}

	// Token: 0x060017A0 RID: 6048 RVA: 0x0006319C File Offset: 0x0006139C
	public static string smethod_16(string string_1)
	{
		string[] array = string_1.Split(new char[]
		{
			' ',
			',',
			';',
			'.',
			'\n',
			'\r',
			'\t'
		}, StringSplitOptions.RemoveEmptyEntries);
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		string[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			string text = array2[i].ToLowerInvariant();
			if (!Class489.string_0.Contains(text) && text.Length > 2)
			{
				if (dictionary.ContainsKey(text))
				{
					Dictionary<string, int> dictionary2 = dictionary;
					string key = text;
					int num = dictionary2[key];
					dictionary2[key] = num + 1;
				}
				else
				{
					dictionary.Add(text, 1);
				}
			}
		}
		return dictionary.OrderByDescending(new Func<KeyValuePair<string, int>, int>(Class489.Class490.class490_0.method_0)).FirstOrDefault<KeyValuePair<string, int>>().Key;
	}

	// Token: 0x060017A1 RID: 6049 RVA: 0x0006326C File Offset: 0x0006146C
	public static bool smethod_17(this string string_1)
	{
		return string_1.Split(new char[]
		{
			' ',
			'\n',
			'\r',
			'\t'
		}, StringSplitOptions.RemoveEmptyEntries).Length == 1;
	}

	// Token: 0x040010C3 RID: 4291
	private static string[] string_0 = new string[]
	{
		"a",
		"an",
		"the",
		"in",
		"on",
		"is",
		"are",
		"and",
		"or",
		"not"
	};

	// Token: 0x02000431 RID: 1073
	[Serializable]
	private sealed class Class490
	{
		// Token: 0x060017A4 RID: 6052 RVA: 0x000632A0 File Offset: 0x000614A0
		internal int method_0(KeyValuePair<string, int> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}

		// Token: 0x040010C4 RID: 4292
		public static readonly Class489.Class490 class490_0 = new Class489.Class490();

		// Token: 0x040010C5 RID: 4293
		public static Func<KeyValuePair<string, int>, int> func_0;
	}
}
