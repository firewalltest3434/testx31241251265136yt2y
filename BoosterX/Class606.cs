using System;
using System.Collections.Generic;
using System.Text;

// Token: 0x0200052A RID: 1322
internal sealed class Class606
{
	// Token: 0x06001CFA RID: 7418 RVA: 0x000790EC File Offset: 0x000772EC
	public static string smethod_0(string string_0)
	{
		int i = 0;
		int num = 0;
		int j = 0;
		int num2 = 0;
		foreach (char c in string_0)
		{
			if (c == '{')
			{
				i++;
			}
			if (c == '}')
			{
				num++;
			}
			if (c == '[')
			{
				j++;
			}
			if (c == ']')
			{
				num2++;
			}
		}
		while (i > num)
		{
			string_0 += "}";
			num++;
		}
		while (j > num2)
		{
			string_0 += "]";
			num2++;
		}
		return string_0;
	}

	// Token: 0x06001CFB RID: 7419 RVA: 0x0007919C File Offset: 0x0007739C
	public static string smethod_1(string string_0)
	{
		Stack<char> stack = new Stack<char>();
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		char c = '\0';
		int i = 0;
		while (i < string_0.Length)
		{
			char c2 = string_0[i];
			if (c2 == '"' && (i == 0 || string_0[i - 1] != '\\'))
			{
				flag = !flag;
			}
			if (flag)
			{
				goto IL_101;
			}
			if (c2 != '{' && c2 != '[')
			{
				if ((c2 == '}' && (stack.Count == 0 || stack.Peek() != '{')) || (c2 == ']' && (stack.Count == 0 || stack.Peek() != '[')))
				{
					goto IL_117;
				}
				if (c2 == '}' || c2 == ']')
				{
					stack.Pop();
				}
			}
			else
			{
				stack.Push(c2);
			}
			if ((c == '}' || c == ']') && (c2 == '{' || c2 == '[' || c2 == '"'))
			{
				stringBuilder.Append(',');
				goto IL_101;
			}
			goto IL_101;
			IL_117:
			i++;
			continue;
			IL_101:
			stringBuilder.Append(c2);
			if (!char.IsWhiteSpace(c2))
			{
				c = c2;
				goto IL_117;
			}
			goto IL_117;
		}
		while (stack.Count > 0)
		{
			char c3 = stack.Pop();
			stringBuilder.Append((c3 == '{') ? '}' : ']');
		}
		return stringBuilder.ToString();
	}
}
