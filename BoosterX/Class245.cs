using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ns0;

// Token: 0x020001C1 RID: 449
internal sealed class Class245
{
	// Token: 0x06000AC0 RID: 2752 RVA: 0x0003198C File Offset: 0x0002FB8C
	public static Task<string> smethod_0(string string_0)
	{
		Class245.Struct93 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class245.Struct93>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000AC1 RID: 2753 RVA: 0x000319D0 File Offset: 0x0002FBD0
	public static Task<List<string>> smethod_1()
	{
		Class245.Struct92 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<string>>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class245.Struct92>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0400067F RID: 1663
	public static bool bool_0 = false;

	// Token: 0x04000680 RID: 1664
	public static List<string> list_0 = new List<string>();

	// Token: 0x020001C2 RID: 450
	[StructLayout(LayoutKind.Auto)]
	private struct Struct92 : IAsyncStateMachine
	{
		// Token: 0x06000AC2 RID: 2754 RVA: 0x00031A0C File Offset: 0x0002FC0C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<string> list_;
			try
			{
				TaskAwaiter<ObservableCollection<Class745>> awaiter;
				switch (num)
				{
				case 0:
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
					break;
				}
				case 1:
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
					goto IL_199;
				}
				case 2:
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
					int num4 = -1;
					num = -1;
					this.int_0 = num4;
					goto IL_29E;
				}
				case 3:
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
					int num5 = -1;
					num = -1;
					this.int_0 = num5;
					goto IL_3A3;
				}
				default:
					if (Class245.list_0.Count<string>() > 0)
					{
						list_ = Class245.list_0;
						goto IL_77F;
					}
					awaiter = Class588.smethod_2(typeof(dje_zTGEPDZPEXBPCNC7GHSZYZV868XZCRS2VHUBBLX2NGBMBUBPFKXX7KVDJJJJPWEWFPS_ejd), false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num6 = 0;
						num = 0;
						this.int_0 = num6;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class245.Struct92>(ref awaiter, ref this);
						return;
					}
					break;
				}
				IEnumerator<Class745> enumerator = awaiter.GetResult().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class745 @class = enumerator.Current;
						Class245.list_0.Add(string.Concat(new string[]
						{
							Class364.smethod_0("Vkladka"),
							" \"",
							Class364.smethod_0("registrytweaksexp"),
							"\" (",
							Class364.smethod_0("Vkladka2"),
							"): ",
							@class.Name,
							" * ",
							@class.Description
						}));
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				awaiter = Class588.smethod_2(typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd), false).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num7 = 1;
					num = 1;
					this.int_0 = num7;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class245.Struct92>(ref awaiter, ref this);
					return;
				}
				IL_199:
				enumerator = awaiter.GetResult().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class745 class2 = enumerator.Current;
						Class245.list_0.Add(string.Concat(new string[]
						{
							Class364.smethod_0("Vkladka"),
							" \"",
							Class364.smethod_0("settingsexp"),
							"\" (",
							Class364.smethod_0("Vkladka2"),
							"): ",
							class2.Name,
							" * ",
							class2.Description
						}));
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				awaiter = Class588.smethod_2(typeof(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd), false).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num8 = 2;
					num = 2;
					this.int_0 = num8;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class245.Struct92>(ref awaiter, ref this);
					return;
				}
				IL_29E:
				enumerator = awaiter.GetResult().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class745 class3 = enumerator.Current;
						Class245.list_0.Add(string.Concat(new string[]
						{
							Class364.smethod_0("Vkladka"),
							" \"",
							Class364.smethod_0("powermgmtexp"),
							"\" (",
							Class364.smethod_0("Vkladka2"),
							"): ",
							class3.Name,
							" * ",
							class3.Description
						}));
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				awaiter = Class588.smethod_2(typeof(dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd), false).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num9 = 3;
					num = 3;
					this.int_0 = num9;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class245.Struct92>(ref awaiter, ref this);
					return;
				}
				IL_3A3:
				enumerator = awaiter.GetResult().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class745 class4 = enumerator.Current;
						Class245.list_0.Add(string.Concat(new string[]
						{
							Class364.smethod_0("Vkladka"),
							" \"",
							Class364.smethod_0("Tasks"),
							"\" (",
							Class364.smethod_0("Vkladka2"),
							"): ",
							class4.Name,
							" * ",
							class4.Description
						}));
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				Class245.list_0.Add(string.Concat(new string[]
				{
					Class364.smethod_0("Vkladka"),
					" \"",
					Class364.smethod_0("powermgmtexp"),
					"\" ",
					Class364.smethod_0("PowerAddition")
				}));
				Class245.list_0.Add(string.Concat(new string[]
				{
					Class364.smethod_0("Vkladka"),
					" \"",
					Class364.smethod_0("uwpappsexp"),
					"\" ",
					Class364.smethod_0("DebloadAddition")
				}));
				Class605.list_11.ForEach(new Action<string>(Class245.Class246.class246_0.method_0));
				Class245.list_0.Add(string.Concat(new string[]
				{
					Class364.smethod_0("Vkladka"),
					" \"",
					Class364.smethod_0("uwpappsexp"),
					"\" ",
					Class364.smethod_0("ServisesAdditon")
				}));
				Class664.smethod_4(false).ToList<Class739>().ForEach(new Action<Class739>(Class245.Class246.class246_0.method_1));
				Class245.list_0.Add(string.Concat(new string[]
				{
					Class364.smethod_0("Vkladka"),
					" \"",
					Class364.smethod_0("affinityexp"),
					"\" ",
					Class364.smethod_0("InterruptAddition")
				}));
				Class245.list_0.Add(string.Concat(new string[]
				{
					Class364.smethod_0("Vkladka"),
					" \"",
					Class364.smethod_0("autorunsexp"),
					"\" ",
					Class364.smethod_0("AutorunsAddition")
				}));
				Class245.list_0.Add(string.Concat(new string[]
				{
					Class364.smethod_0("Vkladka"),
					" \"",
					Class364.smethod_0("SevicesManager"),
					"\" ",
					Class364.smethod_0("ServicesManagerAddition")
				}));
				Dictionary<string, GClass155>.Enumerator enumerator2 = GClass139.smethod_0().method_0().GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						KeyValuePair<string, GClass155> keyValuePair = enumerator2.Current;
						if (keyValuePair.Value.List_0[0] != string.Empty)
						{
							Class245.Class249 class5 = new Class245.Class249();
							class5.list_0 = new List<string>();
							keyValuePair.Value.List_0.ForEach(new Action<string>(class5.method_0));
							Class245.list_0.Add(string.Concat(new string[]
							{
								Class364.smethod_0("Vkladka4"),
								" \"",
								keyValuePair.Key,
								"\" ",
								Class364.smethod_0("Vkladka5"),
								" ",
								string.Join(", ", class5.list_0)
							}));
						}
					}
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)enumerator2).Dispose();
					}
				}
				list_ = Class245.list_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_77F:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(list_);
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00032244 File Offset: 0x00030444
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000681 RID: 1665
		public int int_0;

		// Token: 0x04000682 RID: 1666
		public AsyncTaskMethodBuilder<List<string>> asyncTaskMethodBuilder_0;

		// Token: 0x04000683 RID: 1667
		private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
	}

	// Token: 0x020001C3 RID: 451
	[StructLayout(LayoutKind.Auto)]
	private struct Struct93 : IAsyncStateMachine
	{
		// Token: 0x06000AC4 RID: 2756 RVA: 0x00032254 File Offset: 0x00030454
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			string result;
			try
			{
				TaskAwaiter<List<string>> awaiter;
				if (num != 0)
				{
					Class245.Class248 @class = new Class245.Class248();
					@class.string_0 = this.string_0.ToLower();
					this.ienumerable_0 = Class605.list_12.Where(new Func<string, bool>(@class.method_0));
					if (this.ienumerable_0.Count<string>() == 0)
					{
						result = string.Empty;
						goto IL_1C8;
					}
					if (Class245.list_0.Count != 0)
					{
						goto IL_CE;
					}
					awaiter = Class245.smethod_1().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<string>>, Class245.Struct93>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<List<string>>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				IL_CE:
				List<string> list = new List<string>();
				List<string>.Enumerator enumerator = Class245.list_0.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class245.Class247 class2 = new Class245.Class247();
						class2.string_0 = enumerator.Current;
						if (this.ienumerable_0.Where(new Func<string, bool>(class2.method_0)).Count<string>() > 0)
						{
							list.Add(class2.string_0);
						}
					}
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)enumerator).Dispose();
					}
				}
				List<string> list2 = list.Distinct<string>().ToList<string>();
				if (list2.Count == 0)
				{
					result = string.Empty;
				}
				else
				{
					string text = string.Join(" | ", list2);
					if (text.Length > 2000)
					{
						text = text.Substring(0, 2000);
					}
					result = text;
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.ienumerable_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1C8:
			this.int_0 = -2;
			this.ienumerable_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00032478 File Offset: 0x00030678
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000684 RID: 1668
		public int int_0;

		// Token: 0x04000685 RID: 1669
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04000686 RID: 1670
		public string string_0;

		// Token: 0x04000687 RID: 1671
		private IEnumerable<string> ienumerable_0;

		// Token: 0x04000688 RID: 1672
		private TaskAwaiter<List<string>> taskAwaiter_0;
	}

	// Token: 0x020001C4 RID: 452
	[Serializable]
	private sealed class Class246
	{
		// Token: 0x06000AC8 RID: 2760 RVA: 0x0003249C File Offset: 0x0003069C
		internal void method_0(string string_0)
		{
			Class245.list_0.Add(string.Concat(new string[]
			{
				Class364.smethod_0("Vkladka"),
				" \"",
				Class364.smethod_0("servicesexp"),
				"\" (",
				Class364.smethod_0("Vkladka3"),
				"): ",
				Class364.smethod_0(string_0),
				" * ",
				Class364.smethod_0(string_0 + "Desc")
			}));
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00032524 File Offset: 0x00030724
		internal void method_1(Class739 class739_0)
		{
			Class245.list_0.Add(string.Concat(new string[]
			{
				Class364.smethod_0("Vkladka"),
				" \"",
				Class364.smethod_0("cleanupexp"),
				"\" (",
				Class364.smethod_0("Vkladka3"),
				"): ",
				class739_0.Name,
				" * ",
				class739_0.Description
			}));
		}

		// Token: 0x04000689 RID: 1673
		public static readonly Class245.Class246 class246_0 = new Class245.Class246();

		// Token: 0x0400068A RID: 1674
		public static Action<string> action_0;

		// Token: 0x0400068B RID: 1675
		public static Action<Class739> action_1;
	}

	// Token: 0x020001C5 RID: 453
	private sealed class Class247
	{
		// Token: 0x06000ACB RID: 2763 RVA: 0x000325A8 File Offset: 0x000307A8
		internal bool method_0(string string_1)
		{
			return Regex.IsMatch(this.string_0, "(^|\\s)" + string_1, RegexOptions.IgnoreCase);
		}

		// Token: 0x0400068C RID: 1676
		public string string_0;
	}

	// Token: 0x020001C6 RID: 454
	private sealed class Class248
	{
		// Token: 0x06000ACD RID: 2765 RVA: 0x000325CC File Offset: 0x000307CC
		internal bool method_0(string string_1)
		{
			return Regex.IsMatch(this.string_0, "(^|\\s)" + string_1, RegexOptions.IgnoreCase);
		}

		// Token: 0x0400068D RID: 1677
		public string string_0;
	}

	// Token: 0x020001C7 RID: 455
	private sealed class Class249
	{
		// Token: 0x06000ACF RID: 2767 RVA: 0x000325F0 File Offset: 0x000307F0
		internal void method_0(string string_0)
		{
			this.list_0.Add(Class364.smethod_0(string_0));
		}

		// Token: 0x0400068E RID: 1678
		public List<string> list_0;
	}
}
