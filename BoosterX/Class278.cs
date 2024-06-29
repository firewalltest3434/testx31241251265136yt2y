using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using BoosterX.Classes.Tweaks.Expert.ServicesTweak;
using ns0;

// Token: 0x0200021A RID: 538
internal sealed class Class278
{
	// Token: 0x06000CE7 RID: 3303 RVA: 0x0003A02C File Offset: 0x0003822C
	public static void smethod_0()
	{
		Class278.Struct122 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class278.Struct122>(ref @struct);
	}

	// Token: 0x04000807 RID: 2055
	public static Class748 class748_0 = new Class748();

	// Token: 0x04000808 RID: 2056
	private static readonly SemaphoreSlim semaphoreSlim_0 = new SemaphoreSlim(1, 1);

	// Token: 0x0200021B RID: 539
	private sealed class Class279
	{
		// Token: 0x06000CE9 RID: 3305 RVA: 0x0003A064 File Offset: 0x00038264
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x04000809 RID: 2057
		public KeyValuePair<string, GClass93.GStruct4> keyValuePair_0;
	}

	// Token: 0x0200021C RID: 540
	private sealed class Class280
	{
		// Token: 0x06000CEB RID: 3307 RVA: 0x0003A080 File Offset: 0x00038280
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x0400080A RID: 2058
		public KeyValuePair<string, GClass93.GStruct4> keyValuePair_0;
	}

	// Token: 0x0200021D RID: 541
	private sealed class Class281
	{
		// Token: 0x06000CED RID: 3309 RVA: 0x0003A09C File Offset: 0x0003829C
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x0400080B RID: 2059
		public KeyValuePair<string, GClass93.GStruct4> keyValuePair_0;
	}

	// Token: 0x0200021E RID: 542
	private sealed class Class282
	{
		// Token: 0x06000CEF RID: 3311 RVA: 0x0003A0B8 File Offset: 0x000382B8
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x0400080C RID: 2060
		public KeyValuePair<string, GClass93.GStruct4> keyValuePair_0;
	}

	// Token: 0x0200021F RID: 543
	private sealed class Class283
	{
		// Token: 0x06000CF1 RID: 3313 RVA: 0x0003A0D4 File Offset: 0x000382D4
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x0400080D RID: 2061
		public KeyValuePair<string, GClass93.GStruct4> keyValuePair_0;
	}

	// Token: 0x02000220 RID: 544
	[StructLayout(LayoutKind.Auto)]
	private struct Struct122 : IAsyncStateMachine
	{
		// Token: 0x06000CF2 RID: 3314 RVA: 0x0003A0E8 File Offset: 0x000382E8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_A4;
				}
				if (num != 1)
				{
					awaiter = Class278.semaphoreSlim_0.WaitAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class278.Struct122>(ref awaiter, ref this);
						return;
					}
					goto IL_A4;
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				IL_71:
				awaiter.GetResult();
				Class278.semaphoreSlim_0.Release();
				goto IL_12B;
				IL_A4:
				awaiter.GetResult();
				awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(Class278.Class284.class284_0.method_0)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class278.Struct122>(ref awaiter, ref this);
					return;
				}
				goto IL_71;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_12B:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0003A250 File Offset: 0x00038450
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400080E RID: 2062
		public int int_0;

		// Token: 0x0400080F RID: 2063
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000810 RID: 2064
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000221 RID: 545
	[Serializable]
	private sealed class Class284
	{
		// Token: 0x06000CF6 RID: 3318 RVA: 0x0003A274 File Offset: 0x00038474
		internal void method_0()
		{
			object object_ = GClass93.smethod_0().object_1;
			lock (object_)
			{
				Class278.class748_0.method_1();
				Class278.class748_0.NvidiaSettings = dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.int_0.ToString();
				Dictionary<Type, Dictionary<string, GClass93.GStruct4>> dictionary = GClass93.smethod_0().method_19();
				Class278.class748_0.Affinity = (dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool>(Class278.Class284.class284_0.method_1)) ? dictionary[typeof(Class524)].Count<KeyValuePair<string, GClass93.GStruct4>>().ToString() : "0");
				Class278.class748_0.Devices = (dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool>(Class278.Class284.class284_0.method_2)) ? dictionary[typeof(Class520)].Count<KeyValuePair<string, GClass93.GStruct4>>().ToString() : "0");
				Class278.class748_0.Autoruns = (dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool>(Class278.Class284.class284_0.method_3)) ? dictionary[typeof(Class521)].Count<KeyValuePair<string, GClass93.GStruct4>>().ToString() : "0");
				if (dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool>(Class278.Class284.class284_0.method_4)))
				{
					Class748 class748_ = Class278.class748_0;
					Dictionary<string, GClass93.GStruct4> dictionary2 = dictionary[typeof(Class525)];
					string basicSettings;
					if (dictionary2 == null)
					{
						basicSettings = null;
					}
					else
					{
						basicSettings = dictionary2.Where(new Func<KeyValuePair<string, GClass93.GStruct4>, bool>(Class278.Class284.class284_0.method_5)).Count<KeyValuePair<string, GClass93.GStruct4>>().ToString();
					}
					class748_.BasicSettings = basicSettings;
					Class748 class748_2 = Class278.class748_0;
					Dictionary<string, GClass93.GStruct4> dictionary3 = dictionary[typeof(Class525)];
					string customization;
					if (dictionary3 == null)
					{
						customization = null;
					}
					else
					{
						customization = dictionary3.Where(new Func<KeyValuePair<string, GClass93.GStruct4>, bool>(Class278.Class284.class284_0.method_6)).Count<KeyValuePair<string, GClass93.GStruct4>>().ToString();
					}
					class748_2.Customization = customization;
					Class748 class748_3 = Class278.class748_0;
					Dictionary<string, GClass93.GStruct4> dictionary4 = dictionary[typeof(Class525)];
					string registryTweaks;
					if (dictionary4 == null)
					{
						registryTweaks = null;
					}
					else
					{
						registryTweaks = dictionary4.Where(new Func<KeyValuePair<string, GClass93.GStruct4>, bool>(Class278.Class284.class284_0.method_7)).Count<KeyValuePair<string, GClass93.GStruct4>>().ToString();
					}
					class748_3.RegistryTweaks = registryTweaks;
					Class748 class748_4 = Class278.class748_0;
					Dictionary<string, GClass93.GStruct4> dictionary5 = dictionary[typeof(Class525)];
					string privacy;
					if (dictionary5 == null)
					{
						privacy = null;
					}
					else
					{
						privacy = dictionary5.Where(new Func<KeyValuePair<string, GClass93.GStruct4>, bool>(Class278.Class284.class284_0.method_8)).Count<KeyValuePair<string, GClass93.GStruct4>>().ToString();
					}
					class748_4.Privacy = privacy;
					Class748 class748_5 = Class278.class748_0;
					Dictionary<string, GClass93.GStruct4> dictionary6 = dictionary[typeof(Class525)];
					string tasks;
					if (dictionary6 == null)
					{
						tasks = null;
					}
					else
					{
						tasks = dictionary6.Where(new Func<KeyValuePair<string, GClass93.GStruct4>, bool>(Class278.Class284.class284_0.method_9)).Count<KeyValuePair<string, GClass93.GStruct4>>().ToString();
					}
					class748_5.Tasks = tasks;
					Class748 class748_6 = Class278.class748_0;
					Dictionary<string, GClass93.GStruct4> dictionary7 = dictionary[typeof(Class525)];
					string myTweaks;
					if (dictionary7 == null)
					{
						myTweaks = null;
					}
					else
					{
						myTweaks = dictionary7.Where(new Func<KeyValuePair<string, GClass93.GStruct4>, bool>(Class278.Class284.class284_0.method_10)).Count<KeyValuePair<string, GClass93.GStruct4>>().ToString();
					}
					class748_6.MyTweaks = myTweaks;
					Class748 class748_7 = Class278.class748_0;
					Dictionary<string, GClass93.GStruct4> dictionary8 = dictionary[typeof(Class525)];
					string features;
					if (dictionary8 == null)
					{
						features = null;
					}
					else
					{
						features = dictionary8.Where(new Func<KeyValuePair<string, GClass93.GStruct4>, bool>(Class278.Class284.class284_0.method_11)).Count<KeyValuePair<string, GClass93.GStruct4>>().ToString();
					}
					class748_7.Features = features;
				}
				else
				{
					Class278.class748_0.BasicSettings = "0";
					Class278.class748_0.Customization = "0";
					Class278.class748_0.RegistryTweaks = "0";
					Class278.class748_0.Privacy = "0";
					Class278.class748_0.Tasks = "0";
					Class278.class748_0.MyTweaks = "0";
					Class278.class748_0.Features = "0";
				}
				int num = 0 + (dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool>(Class278.Class284.class284_0.method_12)) ? dictionary[typeof(Class523)].Count<KeyValuePair<string, GClass93.GStruct4>>() : 0);
				int num2 = num;
				int num3;
				if (!dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool>(Class278.Class284.class284_0.method_13)))
				{
					num3 = 0;
				}
				else
				{
					num3 = dictionary[typeof(Class525)].Where(new Func<KeyValuePair<string, GClass93.GStruct4>, bool>(Class278.Class284.class284_0.method_14)).Count<KeyValuePair<string, GClass93.GStruct4>>();
				}
				num = num2 + num3;
				Class278.class748_0.Debloat = num.ToString();
				int num4 = 0;
				foreach (Class683.Class761 @class in Class683.class760_0.GroupServices)
				{
					foreach (GClass61 gclass in @class.ServicesViewGroupModels)
					{
						num4 += ((gclass.HasChanges > false) ? 1 : 0);
					}
				}
				Class278.class748_0.Services = num4.ToString();
				Class278.class748_0.ServicesManager = (dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool>(Class278.Class284.class284_0.method_15)) ? dictionary[typeof(ServicesTweak)].Count<KeyValuePair<string, GClass93.GStruct4>>().ToString() : "0");
				int num5;
				if (!dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool>(Class278.Class284.class284_0.method_16)))
				{
					num5 = 0;
				}
				else
				{
					num5 = dictionary[typeof(Class525)].Where(new Func<KeyValuePair<string, GClass93.GStruct4>, bool>(Class278.Class284.class284_0.method_17)).Count<KeyValuePair<string, GClass93.GStruct4>>();
				}
				int num6 = num5;
				num6 += (((dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.string_1 != string.Empty) > false) ? 1 : 0);
				num6 += dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_2.Count<string>();
				Class278.class748_0.PowerSettings = num6.ToString();
				Class278.class748_0.CleanUp = (dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool>(Class278.Class284.class284_0.method_18)) ? dictionary[typeof(Class526)].Count<KeyValuePair<string, GClass93.GStruct4>>().ToString() : "0");
				Class178.int_0 = Convert.ToInt32(Class278.class748_0.BasicSettings) + Convert.ToInt32(Class278.class748_0.PowerSettings) + Convert.ToInt32(Class278.class748_0.Debloat) + Convert.ToInt32(Class278.class748_0.Services) + Convert.ToInt32(Class278.class748_0.ServicesManager) + Convert.ToInt32(Class278.class748_0.CleanUp) + Convert.ToInt32(Class278.class748_0.Privacy) + Convert.ToInt32(Class278.class748_0.RegistryTweaks) + Convert.ToInt32(Class278.class748_0.Autoruns) + Convert.ToInt32(Class278.class748_0.Affinity) + Convert.ToInt32(Class278.class748_0.Devices);
				Class278.class748_0.Everything = ((Class178.int_0 > 0) ? Visibility.Visible : Visibility.Collapsed);
			}
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0003AAF0 File Offset: 0x00038CF0
		internal bool method_1(KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(Class524);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x0003AB08 File Offset: 0x00038D08
		internal bool method_2(KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(Class520);
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0003AB20 File Offset: 0x00038D20
		internal bool method_3(KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(Class521);
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0003AB38 File Offset: 0x00038D38
		internal bool method_4(KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(Class525);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0003AB50 File Offset: 0x00038D50
		internal bool method_5(KeyValuePair<string, GClass93.GStruct4> keyValuePair_0)
		{
			Class278.Class286 @class = new Class278.Class286();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class588.smethod_6(typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd)).Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x0003AB8C File Offset: 0x00038D8C
		internal bool method_6(KeyValuePair<string, GClass93.GStruct4> keyValuePair_0)
		{
			Class278.Class285 @class = new Class278.Class285();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class588.smethod_6(typeof(dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd)).Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0003ABC8 File Offset: 0x00038DC8
		internal bool method_7(KeyValuePair<string, GClass93.GStruct4> keyValuePair_0)
		{
			Class278.Class283 @class = new Class278.Class283();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class588.smethod_6(typeof(dje_zTGEPDZPEXBPCNC7GHSZYZV868XZCRS2VHUBBLX2NGBMBUBPFKXX7KVDJJJJPWEWFPS_ejd)).Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x0003AC04 File Offset: 0x00038E04
		internal bool method_8(KeyValuePair<string, GClass93.GStruct4> keyValuePair_0)
		{
			Class278.Class279 @class = new Class278.Class279();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class588.smethod_6(typeof(dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd)).Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0003AC40 File Offset: 0x00038E40
		internal bool method_9(KeyValuePair<string, GClass93.GStruct4> keyValuePair_0)
		{
			Class278.Class281 @class = new Class278.Class281();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class588.smethod_6(typeof(dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd)).Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x0003AC7C File Offset: 0x00038E7C
		internal bool method_10(KeyValuePair<string, GClass93.GStruct4> keyValuePair_0)
		{
			Class278.Class282 @class = new Class278.Class282();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class147.smethod_6().Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x0003ACAC File Offset: 0x00038EAC
		internal bool method_11(KeyValuePair<string, GClass93.GStruct4> keyValuePair_0)
		{
			Class278.Class287 @class = new Class278.Class287();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class271.smethod_5().Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x0003ACDC File Offset: 0x00038EDC
		internal bool method_12(KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(Class523);
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x0003ACF4 File Offset: 0x00038EF4
		internal bool method_13(KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(Class525);
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0003AD0C File Offset: 0x00038F0C
		internal bool method_14(KeyValuePair<string, GClass93.GStruct4> keyValuePair_0)
		{
			Class278.Class288 @class = new Class278.Class288();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class588.smethod_6(typeof(dje_z4EFBE23NRXT78H3EAL45CK9M5K537HLZVTED9PC5FL6WLE8YYJD3VFKL5QNA_ejd)).Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0003AD48 File Offset: 0x00038F48
		internal bool method_15(KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(ServicesTweak);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0003AD60 File Offset: 0x00038F60
		internal bool method_16(KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(Class525);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0003AD78 File Offset: 0x00038F78
		internal bool method_17(KeyValuePair<string, GClass93.GStruct4> keyValuePair_0)
		{
			Class278.Class280 @class = new Class278.Class280();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class588.smethod_6(typeof(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd)).Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0003ADB4 File Offset: 0x00038FB4
		internal bool method_18(KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(Class526);
		}

		// Token: 0x04000811 RID: 2065
		public static readonly Class278.Class284 class284_0 = new Class278.Class284();

		// Token: 0x04000812 RID: 2066
		public static Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool> func_0;

		// Token: 0x04000813 RID: 2067
		public static Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool> func_1;

		// Token: 0x04000814 RID: 2068
		public static Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool> func_2;

		// Token: 0x04000815 RID: 2069
		public static Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool> func_3;

		// Token: 0x04000816 RID: 2070
		public static Func<KeyValuePair<string, GClass93.GStruct4>, bool> func_4;

		// Token: 0x04000817 RID: 2071
		public static Func<KeyValuePair<string, GClass93.GStruct4>, bool> func_5;

		// Token: 0x04000818 RID: 2072
		public static Func<KeyValuePair<string, GClass93.GStruct4>, bool> func_6;

		// Token: 0x04000819 RID: 2073
		public static Func<KeyValuePair<string, GClass93.GStruct4>, bool> func_7;

		// Token: 0x0400081A RID: 2074
		public static Func<KeyValuePair<string, GClass93.GStruct4>, bool> func_8;

		// Token: 0x0400081B RID: 2075
		public static Func<KeyValuePair<string, GClass93.GStruct4>, bool> func_9;

		// Token: 0x0400081C RID: 2076
		public static Func<KeyValuePair<string, GClass93.GStruct4>, bool> func_10;

		// Token: 0x0400081D RID: 2077
		public static Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool> func_11;

		// Token: 0x0400081E RID: 2078
		public static Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool> func_12;

		// Token: 0x0400081F RID: 2079
		public static Func<KeyValuePair<string, GClass93.GStruct4>, bool> func_13;

		// Token: 0x04000820 RID: 2080
		public static Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool> func_14;

		// Token: 0x04000821 RID: 2081
		public static Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool> func_15;

		// Token: 0x04000822 RID: 2082
		public static Func<KeyValuePair<string, GClass93.GStruct4>, bool> func_16;

		// Token: 0x04000823 RID: 2083
		public static Func<KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>>, bool> func_17;

		// Token: 0x04000824 RID: 2084
		public static Action action_0;
	}

	// Token: 0x02000222 RID: 546
	private sealed class Class285
	{
		// Token: 0x06000D0A RID: 3338 RVA: 0x0003ADD4 File Offset: 0x00038FD4
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x04000825 RID: 2085
		public KeyValuePair<string, GClass93.GStruct4> keyValuePair_0;
	}

	// Token: 0x02000223 RID: 547
	private sealed class Class286
	{
		// Token: 0x06000D0C RID: 3340 RVA: 0x0003ADF0 File Offset: 0x00038FF0
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x04000826 RID: 2086
		public KeyValuePair<string, GClass93.GStruct4> keyValuePair_0;
	}

	// Token: 0x02000224 RID: 548
	private sealed class Class287
	{
		// Token: 0x06000D0E RID: 3342 RVA: 0x0003AE0C File Offset: 0x0003900C
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x04000827 RID: 2087
		public KeyValuePair<string, GClass93.GStruct4> keyValuePair_0;
	}

	// Token: 0x02000225 RID: 549
	private sealed class Class288
	{
		// Token: 0x06000D10 RID: 3344 RVA: 0x0003AE28 File Offset: 0x00039028
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x04000828 RID: 2088
		public KeyValuePair<string, GClass93.GStruct4> keyValuePair_0;
	}
}
