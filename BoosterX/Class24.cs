using System;
using System.Collections.Generic;

// Token: 0x02000026 RID: 38
internal sealed class Class24
{
	// Token: 0x060000E6 RID: 230 RVA: 0x00004840 File Offset: 0x00002A40
	public Class24(Class12 class12_1)
	{
		this.class12_0 = class12_1;
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x0000485C File Offset: 0x00002A5C
	private void method_0()
	{
		if (this.bool_0)
		{
			return;
		}
		object obj = this.object_0;
		lock (obj)
		{
			if (!this.bool_0)
			{
				this.class21_0 = new Class21[this.class12_0.method_4()];
				for (int i = 0; i < this.class12_0.method_4(); i++)
				{
					this.class21_0[i] = new Class21();
				}
				this.dictionary_0 = new Dictionary<int, Class21>();
				this.dictionary_1 = new Dictionary<int, WeakReference>();
				this.object_1 = new object();
				this.int_0 = this.class12_0.method_6();
				this.object_2 = new object[this.class12_0.method_8()];
				this.bool_0 = true;
			}
		}
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x00004948 File Offset: 0x00002B48
	public void method_1(Class21 class21_1)
	{
		this.method_0();
		object obj = this.object_0;
		lock (obj)
		{
			Class21 @class;
			if (this.dictionary_0.TryGetValue(class21_1.int_0, out @class) && @class != null)
			{
				@class.dateTime_0 = class21_1.dateTime_0;
			}
			else
			{
				int num = 0;
				DateTime dateTime_ = this.class21_0[0].dateTime_0;
				for (int i = 1; i < this.class12_0.method_4(); i++)
				{
					if (this.class21_0[i].dateTime_0 < dateTime_)
					{
						num = i;
					}
				}
				@class = this.class21_0[num];
				if (@class.byte_0 == null)
				{
					@class.byte_0 = new byte[this.class12_0.method_0()];
				}
				else
				{
					this.dictionary_0[@class.int_0] = null;
				}
				this.method_4(class21_1, @class);
				this.dictionary_0[@class.int_0] = @class;
				if (this.dictionary_0.Count > this.class12_0.method_4() * 2)
				{
					this.method_2();
				}
			}
		}
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00004A94 File Offset: 0x00002C94
	private void method_2()
	{
		Dictionary<int, Class21> dictionary = this.dictionary_0;
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, Class21> keyValuePair in dictionary)
		{
			if (keyValuePair.Value == null)
			{
				list.Add(keyValuePair.Key);
			}
		}
		foreach (int key in list)
		{
			dictionary.Remove(key);
		}
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00004B40 File Offset: 0x00002D40
	public bool method_3(int int_2, ref Class21 class21_1)
	{
		if (!this.bool_0)
		{
			return false;
		}
		object obj = this.object_0;
		lock (obj)
		{
			Class21 @class;
			if (this.dictionary_0.TryGetValue(int_2, out @class) && @class != null)
			{
				this.method_4(@class, class21_1);
				return true;
			}
		}
		return false;
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00004BA4 File Offset: 0x00002DA4
	private void method_4(Class21 class21_1, Class21 class21_2)
	{
		class21_1.dateTime_0 = DateTime.UtcNow;
		class21_2.int_0 = class21_1.int_0;
		class21_2.int_1 = class21_1.int_1;
		class21_2.dateTime_0 = class21_1.dateTime_0;
		Buffer.BlockCopy(class21_1.byte_0, 0, class21_2.byte_0, 0, this.class12_0.method_0());
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00004C00 File Offset: 0x00002E00
	private void method_5(object object_3)
	{
		for (int i = 0; i < this.object_2.Length; i++)
		{
			if (this.object_2[i] == object_3)
			{
				return;
			}
		}
		this.object_2[this.int_1] = object_3;
		this.int_1++;
		if (this.int_1 == this.object_2.Length)
		{
			this.int_1 = 0;
		}
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00004C70 File Offset: 0x00002E70
	private void method_6()
	{
		if (this.dictionary_1.Count >= this.int_0)
		{
			Dictionary<int, WeakReference> dictionary = new Dictionary<int, WeakReference>();
			foreach (KeyValuePair<int, WeakReference> keyValuePair in this.dictionary_1)
			{
				if (keyValuePair.Value.IsAlive)
				{
					dictionary.Add(keyValuePair.Key, keyValuePair.Value);
				}
			}
			this.dictionary_1 = dictionary;
			this.int_0 = Math.Max(dictionary.Count * 2, 10);
		}
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00004D28 File Offset: 0x00002F28
	public void method_7(int int_2, byte[] byte_0, int int_3, int int_4, bool bool_1)
	{
		this.method_0();
		object obj = this.object_1;
		lock (obj)
		{
			WeakReference weakReference;
			Class24.Class25 @class;
			if (this.dictionary_1.TryGetValue(int_2, out weakReference))
			{
				@class = (weakReference.Target as Class24.Class25);
				if (@class != null)
				{
					if (@class.byte_0.Length < int_4)
					{
						@class.method_0(byte_0, int_3, int_4, bool_1);
						goto IL_70;
					}
					goto IL_70;
				}
			}
			this.method_6();
			@class = new Class24.Class25(byte_0, int_3, int_4, bool_1);
			this.dictionary_1[int_2] = new WeakReference(@class);
			IL_70:
			this.method_5(@class);
		}
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00004DC8 File Offset: 0x00002FC8
	public bool method_8(int int_2, byte[] byte_0, int int_3, int int_4, out int int_5)
	{
		int_5 = 0;
		if (!this.bool_0)
		{
			return false;
		}
		object obj = this.object_1;
		bool result;
		lock (obj)
		{
			WeakReference weakReference;
			if (!this.dictionary_1.TryGetValue(int_2, out weakReference))
			{
				result = false;
			}
			else
			{
				Class24.Class25 @class = weakReference.Target as Class24.Class25;
				if (@class == null)
				{
					result = false;
				}
				else
				{
					int num = @class.byte_0.Length;
					int_5 = int_4;
					if (num < int_4)
					{
						if (!@class.bool_0)
						{
							return false;
						}
						int_5 = num;
					}
					Buffer.BlockCopy(@class.byte_0, 0, byte_0, int_3, int_5);
					this.method_5(@class);
					result = true;
				}
			}
		}
		return result;
	}

	// Token: 0x0400003D RID: 61
	private readonly object object_0 = new object();

	// Token: 0x0400003E RID: 62
	private Class21[] class21_0;

	// Token: 0x0400003F RID: 63
	private Dictionary<int, Class21> dictionary_0;

	// Token: 0x04000040 RID: 64
	private volatile bool bool_0;

	// Token: 0x04000041 RID: 65
	private Class12 class12_0;

	// Token: 0x04000042 RID: 66
	private Dictionary<int, WeakReference> dictionary_1;

	// Token: 0x04000043 RID: 67
	private object object_1;

	// Token: 0x04000044 RID: 68
	private int int_0;

	// Token: 0x04000045 RID: 69
	private object[] object_2;

	// Token: 0x04000046 RID: 70
	private int int_1;

	// Token: 0x02000027 RID: 39
	private sealed class Class25
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x00004E74 File Offset: 0x00003074
		public Class25()
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00004E7C File Offset: 0x0000307C
		public Class25(byte[] byte_1, int int_0, int int_1, bool bool_1)
		{
			this.method_0(byte_1, int_0, int_1, bool_1);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00004E90 File Offset: 0x00003090
		public void method_0(byte[] byte_1, int int_0, int int_1, bool bool_1)
		{
			this.byte_0 = new byte[int_1];
			Buffer.BlockCopy(byte_1, int_0, this.byte_0, 0, int_1);
			this.bool_0 = bool_1;
		}

		// Token: 0x04000047 RID: 71
		public byte[] byte_0;

		// Token: 0x04000048 RID: 72
		public bool bool_0;
	}
}
