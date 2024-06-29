using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using ns0;

// Token: 0x020004F4 RID: 1268
internal sealed class Class588
{
	// Token: 0x06001C01 RID: 7169 RVA: 0x000726D4 File Offset: 0x000708D4
	public static void smethod_0(Class588.Delegate30 delegate30_1)
	{
		Class588.Delegate30 @delegate = Class588.delegate30_0;
		Class588.Delegate30 delegate2;
		do
		{
			delegate2 = @delegate;
			Class588.Delegate30 value = (Class588.Delegate30)Delegate.Combine(delegate2, delegate30_1);
			@delegate = Interlocked.CompareExchange<Class588.Delegate30>(ref Class588.delegate30_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06001C02 RID: 7170 RVA: 0x00072708 File Offset: 0x00070908
	public static void smethod_1(Class588.Delegate30 delegate30_1)
	{
		Class588.Delegate30 @delegate = Class588.delegate30_0;
		Class588.Delegate30 delegate2;
		do
		{
			delegate2 = @delegate;
			Class588.Delegate30 value = (Class588.Delegate30)Delegate.Remove(delegate2, delegate30_1);
			@delegate = Interlocked.CompareExchange<Class588.Delegate30>(ref Class588.delegate30_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06001C03 RID: 7171 RVA: 0x0007273C File Offset: 0x0007093C
	public static Task<ObservableCollection<Class745>> smethod_2(Type type_0, bool bool_0)
	{
		Class588.Struct283 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<ObservableCollection<Class745>>.Create();
		@struct.type_0 = type_0;
		@struct.bool_0 = bool_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class588.Struct283>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001C04 RID: 7172 RVA: 0x00072788 File Offset: 0x00070988
	private static void smethod_3(Class588.Class753 class753_0, List<GClass179> list_2)
	{
		Class588.Class593 @class = new Class588.Class593();
		@class.class753_0 = class753_0;
		@class.list_0 = list_2;
		Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
	}

	// Token: 0x06001C05 RID: 7173 RVA: 0x000727C4 File Offset: 0x000709C4
	public static Task smethod_4()
	{
		Class588.Struct280 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class588.Struct280>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001C06 RID: 7174 RVA: 0x00072800 File Offset: 0x00070A00
	public static int smethod_5(Type type_0)
	{
		Class588.Class591 @class = new Class588.Class591();
		@class.type_0 = type_0;
		Class588.Class753 class2 = Class588.list_1.First(new Func<Class588.Class753, bool>(@class.method_0));
		if (class2 == null)
		{
			return 0;
		}
		return class2.Settings.Count<string>();
	}

	// Token: 0x06001C07 RID: 7175 RVA: 0x00072844 File Offset: 0x00070A44
	public static List<string> smethod_6(Type type_0)
	{
		Class588.Class590 @class = new Class588.Class590();
		@class.type_0 = type_0;
		Class588.Class753 class2 = Class588.list_1.First(new Func<Class588.Class753, bool>(@class.method_0));
		if (class2 == null)
		{
			return new List<string>();
		}
		return class2.Settings;
	}

	// Token: 0x06001C08 RID: 7176 RVA: 0x00072884 File Offset: 0x00070A84
	public static Task smethod_7()
	{
		Class588.Struct291 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class588.Struct291>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001C09 RID: 7177 RVA: 0x000728C0 File Offset: 0x00070AC0
	public static Task<Class745> smethod_8(string string_0)
	{
		Class588.Struct285 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<Class745>.Create();
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class588.Struct285>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001C0A RID: 7178 RVA: 0x00072904 File Offset: 0x00070B04
	public static Task<List<Class745>> smethod_9()
	{
		Class588.Struct281 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class745>>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class588.Struct281>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001C0B RID: 7179 RVA: 0x00072940 File Offset: 0x00070B40
	public static Task<bool> smethod_10()
	{
		Class588.Struct286 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class588.Struct286>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001C0C RID: 7180 RVA: 0x0007297C File Offset: 0x00070B7C
	public static void smethod_11(Type type_0)
	{
		Class588.Struct290 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.type_0 = type_0;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class588.Struct290>(ref @struct);
	}

	// Token: 0x06001C0D RID: 7181 RVA: 0x000729B4 File Offset: 0x00070BB4
	public static void smethod_12(Type type_0)
	{
		Class588.Struct284 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.type_0 = type_0;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class588.Struct284>(ref @struct);
	}

	// Token: 0x06001C0E RID: 7182 RVA: 0x000729EC File Offset: 0x00070BEC
	public static void smethod_13(Type type_0)
	{
		Class588.Struct289 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.type_0 = type_0;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class588.Struct289>(ref @struct);
	}

	// Token: 0x06001C0F RID: 7183 RVA: 0x00072A24 File Offset: 0x00070C24
	public static Task<List<Class188>> smethod_14()
	{
		Class588.Struct282 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class188>>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class588.Struct282>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0400138F RID: 5007
	private static readonly SemaphoreSlim semaphoreSlim_0 = new SemaphoreSlim(1, 1);

	// Token: 0x04001390 RID: 5008
	private static Class588.Delegate30 delegate30_0;

	// Token: 0x04001391 RID: 5009
	private static GClass207 gclass207_0 = new GClass207();

	// Token: 0x04001392 RID: 5010
	public static List<Class588.Class753> list_0 = new List<Class588.Class753>
	{
		new Class588.Class753(typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd), "BoosterX.Resources.Json.BasicSettingsTweaks.json"),
		new Class588.Class753(typeof(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd), "BoosterX.Resources.Json.PowerSettings.json"),
		new Class588.Class753(typeof(dje_zTGEPDZPEXBPCNC7GHSZYZV868XZCRS2VHUBBLX2NGBMBUBPFKXX7KVDJJJJPWEWFPS_ejd), "BoosterX.Resources.Json.RegistryTweaks.json"),
		new Class588.Class753(typeof(dje_z627PU6QDPF5L5L22PZKAYL8VEPS25LWV7TFR5U5JH6MNTERGA6VSXSKBF49Q_ejd), "BoosterX.Resources.Json.CleanUp.json"),
		new Class588.Class753(typeof(dje_z4EFBE23NRXT78H3EAL45CK9M5K537HLZVTED9PC5FL6WLE8YYJD3VFKL5QNA_ejd), "BoosterX.Resources.Json.Debloat.json"),
		new Class588.Class753(typeof(dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd), "BoosterX.Resources.Json.TelemetryJsons.WindowsTelemetry.json"),
		new Class588.Class753(typeof(dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd), "BoosterX.Resources.Json.Tasks.json"),
		new Class588.Class753(typeof(dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd), "BoosterX.Resources.Json.Customization.json")
	};

	// Token: 0x04001393 RID: 5011
	public static List<Class588.Class753> list_1 = new List<Class588.Class753>
	{
		new Class588.Class753(typeof(dje_zJFFKLS3YMYEZQLX279MQ8LGSC4DPGMBDJ3W9Q9ZTRJ9V3NXK76BWGE67ZQGQ_ejd), "BoosterX.Resources.Json.BasicSettingsTweaks.json"),
		new Class588.Class753(typeof(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd), "BoosterX.Resources.Json.PowerSettings.json"),
		new Class588.Class753(typeof(dje_zTGEPDZPEXBPCNC7GHSZYZV868XZCRS2VHUBBLX2NGBMBUBPFKXX7KVDJJJJPWEWFPS_ejd), "BoosterX.Resources.Json.RegistryTweaks.json"),
		new Class588.Class753(typeof(dje_z4EFBE23NRXT78H3EAL45CK9M5K537HLZVTED9PC5FL6WLE8YYJD3VFKL5QNA_ejd), "BoosterX.Resources.Json.Debloat.json"),
		new Class588.Class753(typeof(dje_zBSWA2ZJKD5F4D5W8YM9SKBBY3LLENP3YPEC74XTN3HR2RXWHUBY2F_ejd), "BoosterX.Resources.Json.TelemetryJsons.WindowsTelemetry.json"),
		new Class588.Class753(typeof(dje_zGDFA8WVVLZSZSDM258QJNAFXUGAGRSQM4DBLWQPZVFGN6XEDP8GPD_ejd), "BoosterX.Resources.Json.Tasks.json"),
		new Class588.Class753(typeof(dje_zJ7XPSWXRQGQWT8XE3M4S74LZP8SLE6XNW9QSSS3KP9SD73X6BLA2R_ejd), "BoosterX.Resources.Json.Customization.json")
	};

	// Token: 0x020004F5 RID: 1269
	[StructLayout(LayoutKind.Auto)]
	private struct Struct280 : IAsyncStateMachine
	{
		// Token: 0x06001C10 RID: 7184 RVA: 0x00072A60 File Offset: 0x00070C60
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				if (num != 0)
				{
					this.enumerator_0 = Class588.list_1.GetEnumerator();
				}
				try
				{
					TaskAwaiter<ObservableCollection<Class745>> awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						goto IL_81;
					}
					IL_89:
					while (this.enumerator_0.MoveNext())
					{
						Class588.Class753 @class = this.enumerator_0.Current;
						if (@class.DataContext.Count > 0)
						{
							awaiter = Class588.smethod_2(@class.Type, true).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_81;
							}
							int num3 = 0;
							num = 0;
							this.int_0 = num3;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class588.Struct280>(ref awaiter, ref this);
							return;
						}
					}
					goto IL_DA;
					IL_81:
					awaiter.GetResult();
					goto IL_89;
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)this.enumerator_0).Dispose();
					}
				}
				IL_DA:
				this.enumerator_0 = default(List<Class588.Class753>.Enumerator);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x00072BA4 File Offset: 0x00070DA4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001394 RID: 5012
		public int int_0;

		// Token: 0x04001395 RID: 5013
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001396 RID: 5014
		private List<Class588.Class753>.Enumerator enumerator_0;

		// Token: 0x04001397 RID: 5015
		private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
	}

	// Token: 0x020004F6 RID: 1270
	// (Invoke) Token: 0x06001C13 RID: 7187
	public delegate void Delegate30();

	// Token: 0x020004F7 RID: 1271
	[StructLayout(LayoutKind.Auto)]
	private struct Struct281 : IAsyncStateMachine
	{
		// Token: 0x06001C16 RID: 7190 RVA: 0x00072BB4 File Offset: 0x00070DB4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<Class745> list_;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					this.class589_0 = new Class588.Class589();
					this.class589_0.list_0 = new List<Class745>();
					Class588.list_1.ForEach(new Action<Class588.Class753>(Class588.Class594.class594_0.method_1));
					awaiter = Class588.smethod_10().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Class588.Struct281>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<bool>);
					this.int_0 = -1;
				}
				awaiter.GetResult();
				Class588.list_1.ForEach(new Action<Class588.Class753>(this.class589_0.method_0));
				list_ = this.class589_0.list_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class589_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class589_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(list_);
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x00072CDC File Offset: 0x00070EDC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001398 RID: 5016
		public int int_0;

		// Token: 0x04001399 RID: 5017
		public AsyncTaskMethodBuilder<List<Class745>> asyncTaskMethodBuilder_0;

		// Token: 0x0400139A RID: 5018
		private Class588.Class589 class589_0;

		// Token: 0x0400139B RID: 5019
		private TaskAwaiter<bool> taskAwaiter_0;
	}

	// Token: 0x020004F8 RID: 1272
	[StructLayout(LayoutKind.Auto)]
	private struct Struct282 : IAsyncStateMachine
	{
		// Token: 0x06001C18 RID: 7192 RVA: 0x00072CEC File Offset: 0x00070EEC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<Class188> result;
			try
			{
				if (num != 0)
				{
					this.list_0 = new List<Class188>();
					this.enumerator_0 = Class588.list_1.GetEnumerator();
				}
				try
				{
					TaskAwaiter<ObservableCollection<Class745>> awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						goto IL_12A;
					}
					IL_D6:
					if (!this.enumerator_0.MoveNext())
					{
						goto IL_189;
					}
					this.class753_0 = this.enumerator_0.Current;
					if (this.class753_0.DataContext != null)
					{
						goto IL_132;
					}
					awaiter = Class588.smethod_2(this.class753_0.Type, false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num3 = 0;
						num = 0;
						this.int_0 = num3;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class588.Struct282>(ref awaiter, ref this);
						return;
					}
					IL_12A:
					awaiter.GetResult();
					IL_132:
					IEnumerator<Class745> enumerator = this.class753_0.DataContext.GetEnumerator();
					goto IL_AB;
					try
					{
						do
						{
							Class745 @class = enumerator.Current;
							this.list_0.Add(new Class188
							{
								Type = dje_zV6MRTXWVV6V6RK2Y64AXH57AZZH26RNKGQE5JYT4_ejd.Json,
								Name = @class.NameRaw,
								State = ((@class.CurrentValueType != "CUSTOM") ? @class.CurrentValueType : @class.CurrentCustomValue)
							});
							IL_AB:;
						}
						while (enumerator.MoveNext());
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					this.class753_0 = null;
					goto IL_D6;
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)this.enumerator_0).Dispose();
					}
				}
				IL_189:
				this.enumerator_0 = default(List<Class588.Class753>.Enumerator);
				result = this.list_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.list_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.list_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x00072F28 File Offset: 0x00071128
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400139C RID: 5020
		public int int_0;

		// Token: 0x0400139D RID: 5021
		public AsyncTaskMethodBuilder<List<Class188>> asyncTaskMethodBuilder_0;

		// Token: 0x0400139E RID: 5022
		private List<Class188> list_0;

		// Token: 0x0400139F RID: 5023
		private List<Class588.Class753>.Enumerator enumerator_0;

		// Token: 0x040013A0 RID: 5024
		private Class588.Class753 class753_0;

		// Token: 0x040013A1 RID: 5025
		private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
	}

	// Token: 0x020004F9 RID: 1273
	private sealed class Class589
	{
		// Token: 0x06001C1B RID: 7195 RVA: 0x00072F40 File Offset: 0x00071140
		internal void method_0(Class588.Class753 class753_0)
		{
			this.list_0.AddRange(class753_0.DataContext.ToList<Class745>());
		}

		// Token: 0x040013A2 RID: 5026
		public List<Class745> list_0;
	}

	// Token: 0x020004FA RID: 1274
	private sealed class Class590
	{
		// Token: 0x06001C1D RID: 7197 RVA: 0x00072F60 File Offset: 0x00071160
		internal bool method_0(Class588.Class753 class753_0)
		{
			return class753_0.Type == this.type_0;
		}

		// Token: 0x040013A3 RID: 5027
		public Type type_0;
	}

	// Token: 0x020004FB RID: 1275
	private sealed class Class591
	{
		// Token: 0x06001C1F RID: 7199 RVA: 0x00072F7C File Offset: 0x0007117C
		internal bool method_0(Class588.Class753 class753_0)
		{
			return class753_0.Type == this.type_0;
		}

		// Token: 0x040013A4 RID: 5028
		public Type type_0;
	}

	// Token: 0x020004FC RID: 1276
	private sealed class Class592
	{
		// Token: 0x06001C21 RID: 7201 RVA: 0x00072F98 File Offset: 0x00071198
		internal bool method_0(Class588.Class753 class753_0)
		{
			return class753_0.Type == this.type_0;
		}

		// Token: 0x040013A5 RID: 5029
		public Type type_0;
	}

	// Token: 0x020004FD RID: 1277
	private sealed class Class593
	{
		// Token: 0x06001C23 RID: 7203 RVA: 0x00072FB4 File Offset: 0x000711B4
		internal void method_0()
		{
			this.class753_0.DataContext.Clear();
			this.class753_0.Settings.Clear();
			foreach (GClass179 gclass in this.list_0)
			{
				if (Class453.smethod_0(gclass))
				{
					this.class753_0.DataContext.Add(new Class745(gclass, new Class525(gclass), false, false));
					this.class753_0.Settings.Add(Class364.smethod_0(gclass.Name));
				}
			}
		}

		// Token: 0x040013A6 RID: 5030
		public Class588.Class753 class753_0;

		// Token: 0x040013A7 RID: 5031
		public List<GClass179> list_0;
	}

	// Token: 0x020004FE RID: 1278
	public sealed class Class753 : GClass211
	{
		// Token: 0x06001C24 RID: 7204 RVA: 0x00073064 File Offset: 0x00071264
		public Class753(Type type_1, string string_1)
		{
			this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
			this.Type = type_1;
			this.JsonPath = string_1;
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x000730B4 File Offset: 0x000712B4
		private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs p1)
		{
			base.method_0("ColChanged");
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x000730C4 File Offset: 0x000712C4
		// (set) Token: 0x06001C27 RID: 7207 RVA: 0x000730CC File Offset: 0x000712CC
		public ObservableCollection<Class745> DataContext
		{
			get
			{
				return this.observableCollection_0;
			}
			set
			{
				this.observableCollection_0 = value;
				base.method_0("DataContext");
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x000730E0 File Offset: 0x000712E0
		// (set) Token: 0x06001C29 RID: 7209 RVA: 0x000730E8 File Offset: 0x000712E8
		public Type Type
		{
			[CompilerGenerated]
			get
			{
				return this.type_0;
			}
			[CompilerGenerated]
			set
			{
				this.type_0 = value;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x000730F4 File Offset: 0x000712F4
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x000730FC File Offset: 0x000712FC
		public string JsonPath
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x00073108 File Offset: 0x00071308
		// (set) Token: 0x06001C2D RID: 7213 RVA: 0x00073110 File Offset: 0x00071310
		public bool DataContextReady
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				this.bool_0 = value;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x0007311C File Offset: 0x0007131C
		// (set) Token: 0x06001C2F RID: 7215 RVA: 0x00073124 File Offset: 0x00071324
		public List<string> Settings
		{
			[CompilerGenerated]
			get
			{
				return this.list_0;
			}
			[CompilerGenerated]
			set
			{
				this.list_0 = value;
			}
		}

		// Token: 0x040013A8 RID: 5032
		public ObservableCollection<Class745> observableCollection_0 = new ObservableCollection<Class745>();

		// Token: 0x040013A9 RID: 5033
		private Type type_0;

		// Token: 0x040013AA RID: 5034
		private string string_0;

		// Token: 0x040013AB RID: 5035
		private bool bool_0;

		// Token: 0x040013AC RID: 5036
		private List<string> list_0 = new List<string>();
	}

	// Token: 0x020004FF RID: 1279
	[StructLayout(LayoutKind.Auto)]
	private struct Struct283 : IAsyncStateMachine
	{
		// Token: 0x06001C30 RID: 7216 RVA: 0x00073130 File Offset: 0x00071330
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			ObservableCollection<Class745> result;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					this.class598_0 = new Class588.Class598();
					this.class598_0.type_0 = this.type_0;
					awaiter = Class588.semaphoreSlim_0.WaitAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class588.Struct283>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				try
				{
					Class588.Class753 @class = Class588.list_1.First(new Func<Class588.Class753, bool>(this.class598_0.method_0));
					if (@class == null)
					{
						result = null;
					}
					else
					{
						if (!@class.DataContextReady | this.bool_0)
						{
							if (this.class598_0.type_0 == typeof(dje_zTXYZ9JB9T5TKZLZCFXHFW2S3G86K5RT43TSWGL7W82LC7FYEWQ6B6DMMNK2Q_ejd))
							{
								Class588.Delegate30 delegate30_ = Class588.delegate30_0;
								if (delegate30_ != null)
								{
									delegate30_();
								}
							}
							GClass93.smethod_0().method_16(Class588.smethod_6(this.class598_0.type_0));
							List<GClass179> list_ = Class588.gclass207_0.method_2<List<GClass179>>(@class.JsonPath);
							Class588.smethod_3(@class, list_);
							@class.DataContextReady = true;
						}
						result = @class.DataContext;
					}
				}
				catch
				{
					result = new ObservableCollection<Class745>();
				}
				finally
				{
					if (num < 0)
					{
						Class588.semaphoreSlim_0.Release();
					}
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class598_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class598_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x0007332C File Offset: 0x0007152C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040013AD RID: 5037
		public int int_0;

		// Token: 0x040013AE RID: 5038
		public AsyncTaskMethodBuilder<ObservableCollection<Class745>> asyncTaskMethodBuilder_0;

		// Token: 0x040013AF RID: 5039
		public Type type_0;

		// Token: 0x040013B0 RID: 5040
		private Class588.Class598 class598_0;

		// Token: 0x040013B1 RID: 5041
		public bool bool_0;

		// Token: 0x040013B2 RID: 5042
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000500 RID: 1280
	[StructLayout(LayoutKind.Auto)]
	private struct Struct284 : IAsyncStateMachine
	{
		// Token: 0x06001C32 RID: 7218 RVA: 0x0007333C File Offset: 0x0007153C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter<ObservableCollection<Class745>> awaiter;
				if (num != 0)
				{
					Class588.Class596 @class = new Class588.Class596();
					@class.type_0 = this.type_0;
					this.class753_0 = Class588.list_1.First(new Func<Class588.Class753, bool>(@class.method_0));
					if (this.class753_0.DataContext != null)
					{
						goto IL_A7;
					}
					awaiter = Class588.smethod_2(@class.type_0, false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class588.Struct284>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				IL_A7:
				IEnumerator<Class745> enumerator = this.class753_0.DataContext.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class745 class2 = enumerator.Current;
						class2.method_15();
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class753_0 = null;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class753_0 = null;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00073480 File Offset: 0x00071680
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040013B3 RID: 5043
		public int int_0;

		// Token: 0x040013B4 RID: 5044
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040013B5 RID: 5045
		public Type type_0;

		// Token: 0x040013B6 RID: 5046
		private Class588.Class753 class753_0;

		// Token: 0x040013B7 RID: 5047
		private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
	}

	// Token: 0x02000501 RID: 1281
	[StructLayout(LayoutKind.Auto)]
	private struct Struct285 : IAsyncStateMachine
	{
		// Token: 0x06001C34 RID: 7220 RVA: 0x00073490 File Offset: 0x00071690
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class745 class745_;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					this.class597_0 = new Class588.Class597();
					this.class597_0.string_0 = Class364.smethod_0(this.string_0);
					this.class597_0.class745_0 = null;
					Class588.list_1.ForEach(new Action<Class588.Class753>(Class588.Class594.class594_0.method_0));
					awaiter = Class588.smethod_10().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Class588.Struct285>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<bool>);
					this.int_0 = -1;
				}
				awaiter.GetResult();
				Class588.list_1.ForEach(new Action<Class588.Class753>(this.class597_0.method_0));
				class745_ = this.class597_0.class745_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class597_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class597_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(class745_);
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x000735D0 File Offset: 0x000717D0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040013B8 RID: 5048
		public int int_0;

		// Token: 0x040013B9 RID: 5049
		public AsyncTaskMethodBuilder<Class745> asyncTaskMethodBuilder_0;

		// Token: 0x040013BA RID: 5050
		public string string_0;

		// Token: 0x040013BB RID: 5051
		private Class588.Class597 class597_0;

		// Token: 0x040013BC RID: 5052
		private TaskAwaiter<bool> taskAwaiter_0;
	}

	// Token: 0x02000502 RID: 1282
	[StructLayout(LayoutKind.Auto)]
	private struct Struct286 : IAsyncStateMachine
	{
		// Token: 0x06001C36 RID: 7222 RVA: 0x000735E0 File Offset: 0x000717E0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			bool result;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_82;
				}
				this.int_1 = 0;
				IL_41:
				if (!Class588.list_1.Any(new Func<Class588.Class753, bool>(Class588.Class594.class594_0.method_2)))
				{
					result = true;
					goto IL_D7;
				}
				awaiter = Task.Delay(20).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class588.Struct286>(ref awaiter, ref this);
					return;
				}
				IL_82:
				awaiter.GetResult();
				if (this.int_1 <= 1000)
				{
					int num2 = this.int_1;
					this.int_1 = num2 + 1;
					goto IL_41;
				}
				result = false;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_D7:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x000736E8 File Offset: 0x000718E8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040013BD RID: 5053
		public int int_0;

		// Token: 0x040013BE RID: 5054
		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		// Token: 0x040013BF RID: 5055
		private int int_1;

		// Token: 0x040013C0 RID: 5056
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000503 RID: 1283
	[Serializable]
	private sealed class Class594
	{
		// Token: 0x06001C3A RID: 7226 RVA: 0x0007370C File Offset: 0x0007190C
		internal void method_0(Class588.Class753 class753_0)
		{
			Class588.Class594.Struct287 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.class753_0 = class753_0;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class588.Class594.Struct287>(ref @struct);
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x00073744 File Offset: 0x00071944
		internal void method_1(Class588.Class753 class753_0)
		{
			Class588.Class594.Struct288 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.class753_0 = class753_0;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class588.Class594.Struct288>(ref @struct);
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x0007377C File Offset: 0x0007197C
		internal bool method_2(Class588.Class753 class753_0)
		{
			if (class753_0.DataContextReady)
			{
				return class753_0.DataContext.Any(new Func<Class745, bool>(Class588.Class594.class594_0.method_3));
			}
			return true;
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x000737B4 File Offset: 0x000719B4
		internal bool method_3(Class745 class745_0)
		{
			return !class745_0.bool_0;
		}

		// Token: 0x040013C1 RID: 5057
		public static readonly Class588.Class594 class594_0 = new Class588.Class594();

		// Token: 0x040013C2 RID: 5058
		public static Action<Class588.Class753> action_0;

		// Token: 0x040013C3 RID: 5059
		public static Action<Class588.Class753> action_1;

		// Token: 0x040013C4 RID: 5060
		public static Func<Class745, bool> func_0;

		// Token: 0x040013C5 RID: 5061
		public static Func<Class588.Class753, bool> func_1;

		// Token: 0x02000504 RID: 1284
		[StructLayout(LayoutKind.Auto)]
		private struct Struct287 : IAsyncStateMachine
		{
			// Token: 0x06001C3E RID: 7230 RVA: 0x000737C0 File Offset: 0x000719C0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class745>> awaiter;
					if (num != 0)
					{
						awaiter = Class588.smethod_2(this.class753_0.Type, false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class588.Class594.Struct287>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
						this.int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06001C3F RID: 7231 RVA: 0x00073878 File Offset: 0x00071A78
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040013C6 RID: 5062
			public int int_0;

			// Token: 0x040013C7 RID: 5063
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040013C8 RID: 5064
			public Class588.Class753 class753_0;

			// Token: 0x040013C9 RID: 5065
			private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
		}

		// Token: 0x02000505 RID: 1285
		[StructLayout(LayoutKind.Auto)]
		private struct Struct288 : IAsyncStateMachine
		{
			// Token: 0x06001C40 RID: 7232 RVA: 0x00073888 File Offset: 0x00071A88
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class745>> awaiter;
					if (num != 0)
					{
						awaiter = Class588.smethod_2(this.class753_0.Type, false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class588.Class594.Struct288>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
						this.int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06001C41 RID: 7233 RVA: 0x00073940 File Offset: 0x00071B40
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040013CA RID: 5066
			public int int_0;

			// Token: 0x040013CB RID: 5067
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040013CC RID: 5068
			public Class588.Class753 class753_0;

			// Token: 0x040013CD RID: 5069
			private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
		}
	}

	// Token: 0x02000506 RID: 1286
	[StructLayout(LayoutKind.Auto)]
	private struct Struct289 : IAsyncStateMachine
	{
		// Token: 0x06001C42 RID: 7234 RVA: 0x00073950 File Offset: 0x00071B50
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter<ObservableCollection<Class745>> awaiter;
				if (num != 0)
				{
					Class588.Class592 @class = new Class588.Class592();
					@class.type_0 = this.type_0;
					this.class753_0 = Class588.list_1.First(new Func<Class588.Class753, bool>(@class.method_0));
					if (this.class753_0.DataContext != null)
					{
						goto IL_A7;
					}
					awaiter = Class588.smethod_2(@class.type_0, false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class588.Struct289>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				IL_A7:
				IEnumerator<Class745> enumerator = this.class753_0.DataContext.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class745 class2 = enumerator.Current;
						class2.method_16();
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class753_0 = null;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class753_0 = null;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x00073A94 File Offset: 0x00071C94
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040013CE RID: 5070
		public int int_0;

		// Token: 0x040013CF RID: 5071
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040013D0 RID: 5072
		public Type type_0;

		// Token: 0x040013D1 RID: 5073
		private Class588.Class753 class753_0;

		// Token: 0x040013D2 RID: 5074
		private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
	}

	// Token: 0x02000507 RID: 1287
	[StructLayout(LayoutKind.Auto)]
	private struct Struct290 : IAsyncStateMachine
	{
		// Token: 0x06001C44 RID: 7236 RVA: 0x00073AA4 File Offset: 0x00071CA4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter<ObservableCollection<Class745>> awaiter;
				if (num != 0)
				{
					Class588.Class595 @class = new Class588.Class595();
					@class.type_0 = this.type_0;
					this.class753_0 = Class588.list_1.First(new Func<Class588.Class753, bool>(@class.method_0));
					if (this.class753_0.DataContext != null)
					{
						goto IL_A7;
					}
					awaiter = Class588.smethod_2(@class.type_0, false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class588.Struct290>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				IL_A7:
				IEnumerator<Class745> enumerator = this.class753_0.DataContext.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class745 class2 = enumerator.Current;
						class2.method_14();
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class753_0 = null;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class753_0 = null;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x00073BE8 File Offset: 0x00071DE8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040013D3 RID: 5075
		public int int_0;

		// Token: 0x040013D4 RID: 5076
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040013D5 RID: 5077
		public Type type_0;

		// Token: 0x040013D6 RID: 5078
		private Class588.Class753 class753_0;

		// Token: 0x040013D7 RID: 5079
		private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
	}

	// Token: 0x02000508 RID: 1288
	private sealed class Class595
	{
		// Token: 0x06001C47 RID: 7239 RVA: 0x00073C00 File Offset: 0x00071E00
		internal bool method_0(Class588.Class753 class753_0)
		{
			return class753_0.Type == this.type_0;
		}

		// Token: 0x040013D8 RID: 5080
		public Type type_0;
	}

	// Token: 0x02000509 RID: 1289
	[StructLayout(LayoutKind.Auto)]
	private struct Struct291 : IAsyncStateMachine
	{
		// Token: 0x06001C48 RID: 7240 RVA: 0x00073C14 File Offset: 0x00071E14
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				if (num != 0)
				{
					this.enumerator_0 = Class588.list_1.GetEnumerator();
				}
				try
				{
					TaskAwaiter<ObservableCollection<Class745>> awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class745>>);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						goto IL_7C;
					}
					IL_44:
					if (!this.enumerator_0.MoveNext())
					{
						goto IL_CA;
					}
					awaiter = Class588.smethod_2(this.enumerator_0.Current.Type, true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num3 = 0;
						num = 0;
						this.int_0 = num3;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class745>>, Class588.Struct291>(ref awaiter, ref this);
						return;
					}
					IL_7C:
					awaiter.GetResult();
					goto IL_44;
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)this.enumerator_0).Dispose();
					}
				}
				IL_CA:
				this.enumerator_0 = default(List<Class588.Class753>.Enumerator);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x00073D48 File Offset: 0x00071F48
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040013D9 RID: 5081
		public int int_0;

		// Token: 0x040013DA RID: 5082
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040013DB RID: 5083
		private List<Class588.Class753>.Enumerator enumerator_0;

		// Token: 0x040013DC RID: 5084
		private TaskAwaiter<ObservableCollection<Class745>> taskAwaiter_0;
	}

	// Token: 0x0200050A RID: 1290
	private sealed class Class596
	{
		// Token: 0x06001C4B RID: 7243 RVA: 0x00073D60 File Offset: 0x00071F60
		internal bool method_0(Class588.Class753 class753_0)
		{
			return class753_0.Type == this.type_0;
		}

		// Token: 0x040013DD RID: 5085
		public Type type_0;
	}

	// Token: 0x0200050B RID: 1291
	private sealed class Class597
	{
		// Token: 0x06001C4D RID: 7245 RVA: 0x00073D7C File Offset: 0x00071F7C
		internal void method_0(Class588.Class753 class753_0)
		{
			foreach (Class745 @class in class753_0.DataContext)
			{
				if (@class.Name == this.string_0)
				{
					this.class745_0 = @class;
					break;
				}
			}
		}

		// Token: 0x040013DE RID: 5086
		public string string_0;

		// Token: 0x040013DF RID: 5087
		public Class745 class745_0;
	}

	// Token: 0x0200050C RID: 1292
	private sealed class Class598
	{
		// Token: 0x06001C4F RID: 7247 RVA: 0x00073DE8 File Offset: 0x00071FE8
		internal bool method_0(Class588.Class753 class753_0)
		{
			return class753_0.Type == this.type_0;
		}

		// Token: 0x040013E0 RID: 5088
		public Type type_0;
	}
}
