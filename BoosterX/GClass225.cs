using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using BoosterX.Classes.Tweaks.Expert.ServicesTweak;
using Material.Icons;
using ns0;

// Token: 0x020005B8 RID: 1464
public sealed class GClass225 : GClass211
{
	// Token: 0x06001FB0 RID: 8112 RVA: 0x000821A4 File Offset: 0x000803A4
	public GClass225(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_1)
	{
		this.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0 = dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_1;
	}

	// Token: 0x170004F0 RID: 1264
	// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x00082204 File Offset: 0x00080404
	// (set) Token: 0x06001FB2 RID: 8114 RVA: 0x0008220C File Offset: 0x0008040C
	public string WhatWillBrake
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

	// Token: 0x170004F1 RID: 1265
	// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x00082218 File Offset: 0x00080418
	// (set) Token: 0x06001FB4 RID: 8116 RVA: 0x00082220 File Offset: 0x00080420
	public string WhatWillBrakeEng
	{
		[CompilerGenerated]
		get
		{
			return this.string_1;
		}
		[CompilerGenerated]
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x170004F2 RID: 1266
	// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x0008222C File Offset: 0x0008042C
	// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x00082234 File Offset: 0x00080434
	public List<string> ServicesNames
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

	// Token: 0x170004F3 RID: 1267
	// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x00082240 File Offset: 0x00080440
	// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x00082248 File Offset: 0x00080448
	public List<string> TweaksNames
	{
		[CompilerGenerated]
		get
		{
			return this.list_1;
		}
		[CompilerGenerated]
		set
		{
			this.list_1 = value;
		}
	}

	// Token: 0x170004F4 RID: 1268
	// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x00082254 File Offset: 0x00080454
	// (set) Token: 0x06001FBA RID: 8122 RVA: 0x0008225C File Offset: 0x0008045C
	public List<string> DevicesNames
	{
		[CompilerGenerated]
		get
		{
			return this.list_2;
		}
		[CompilerGenerated]
		set
		{
			this.list_2 = value;
		}
	}

	// Token: 0x06001FBB RID: 8123 RVA: 0x00082268 File Offset: 0x00080468
	public void method_1()
	{
		if (this.Visibility == Visibility.Collapsed)
		{
			return;
		}
		List<string> list = new List<string>();
		foreach (string text in this.ServicesNames)
		{
			foreach (KeyValuePair<Type, Dictionary<string, GClass93.GStruct4>> keyValuePair in GClass93.smethod_0().method_19())
			{
				if (!(keyValuePair.Key == null) && !(keyValuePair.Key != typeof(ServicesTweak)) && !keyValuePair.Value.ContainsKey(text))
				{
					list.Add(text);
				}
			}
		}
		list.ForEach(new Action<string>(this.method_5));
		base.method_0("DisablingServicesName");
		if (this.ServicesNames.Count == 0 && this.TweaksNames.Count == 0 && this.DevicesNames.Count == 0)
		{
			this.method_3();
		}
	}

	// Token: 0x170004F5 RID: 1269
	// (get) Token: 0x06001FBC RID: 8124 RVA: 0x000823B0 File Offset: 0x000805B0
	public string DisablingServicesName
	{
		get
		{
			List<string> list = new List<string>();
			foreach (string text in this.ServicesNames)
			{
				list.Add(Class364.smethod_0("Service") + " " + GClass188.smethod_0(text));
			}
			foreach (string text2 in this.TweaksNames)
			{
				list.Add(Class364.smethod_0("Setting") + " " + Class364.smethod_0(text2));
			}
			foreach (string str in this.DevicesNames)
			{
				list.Add(Class364.smethod_0("Device") + " " + str);
			}
			return string.Join("\n", list);
		}
	}

	// Token: 0x170004F6 RID: 1270
	// (get) Token: 0x06001FBD RID: 8125 RVA: 0x000824E4 File Offset: 0x000806E4
	public GClass134 Cancel
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_0) == null)
			{
				result = (this.gclass134_0 = new GClass134(new Action<object>(this.method_6), null));
			}
			return result;
		}
	}

	// Token: 0x170004F7 RID: 1271
	// (get) Token: 0x06001FBE RID: 8126 RVA: 0x00082518 File Offset: 0x00080718
	public MaterialIconKind Icon
	{
		get
		{
			return this.method_2();
		}
	}

	// Token: 0x06001FBF RID: 8127 RVA: 0x00082520 File Offset: 0x00080720
	private MaterialIconKind method_2()
	{
		MaterialIconKind materialIconKind = Class397.smethod_2(this.WhatWillBrakeEng);
		if (materialIconKind == null)
		{
			return 2009;
		}
		return materialIconKind;
	}

	// Token: 0x170004F8 RID: 1272
	// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x00082544 File Offset: 0x00080744
	// (set) Token: 0x06001FC1 RID: 8129 RVA: 0x0008254C File Offset: 0x0008074C
	public double Opacity
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
			base.method_0("Opacity");
		}
	}

	// Token: 0x170004F9 RID: 1273
	// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x00082560 File Offset: 0x00080760
	// (set) Token: 0x06001FC3 RID: 8131 RVA: 0x00082568 File Offset: 0x00080768
	public Visibility Visibility
	{
		get
		{
			return this.visibility_0;
		}
		set
		{
			this.visibility_0 = value;
			base.method_0("Visibility");
		}
	}

	// Token: 0x06001FC4 RID: 8132 RVA: 0x0008257C File Offset: 0x0008077C
	private void method_3()
	{
		GClass225.Struct341 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass225_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass225.Struct341>(ref @struct);
	}

	// Token: 0x170004FA RID: 1274
	// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x000825B4 File Offset: 0x000807B4
	// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x000825BC File Offset: 0x000807BC
	public string StatusText
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x170004FB RID: 1275
	// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x000825D0 File Offset: 0x000807D0
	// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x000825D8 File Offset: 0x000807D8
	public SolidColorBrush StatusColor
	{
		get
		{
			return this.solidColorBrush_0;
		}
		set
		{
			this.solidColorBrush_0 = value;
			base.method_0("StatusColor");
		}
	}

	// Token: 0x170004FC RID: 1276
	// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x000825EC File Offset: 0x000807EC
	// (set) Token: 0x06001FCA RID: 8138 RVA: 0x000825F4 File Offset: 0x000807F4
	public double StatusOpacity
	{
		get
		{
			return this.double_1;
		}
		set
		{
			this.double_1 = value;
			base.method_0("StatusOpacity");
		}
	}

	// Token: 0x06001FCB RID: 8139 RVA: 0x00082608 File Offset: 0x00080808
	private void method_4(string string_3, SolidColorBrush solidColorBrush_1)
	{
		GClass225.Struct343 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass225_0 = this;
		@struct.string_0 = string_3;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass225.Struct343>(ref @struct);
	}

	// Token: 0x06001FCC RID: 8140 RVA: 0x00082650 File Offset: 0x00080850
	private void method_5(string string_3)
	{
		this.ServicesNames.Remove(string_3);
	}

	// Token: 0x06001FCD RID: 8141 RVA: 0x00082660 File Offset: 0x00080860
	private void method_6(object object_0)
	{
		GClass225.Struct342 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass225_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass225.Struct342>(ref @struct);
	}

	// Token: 0x04001604 RID: 5636
	private dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0;

	// Token: 0x04001605 RID: 5637
	private string string_0;

	// Token: 0x04001606 RID: 5638
	private string string_1;

	// Token: 0x04001607 RID: 5639
	private List<string> list_0 = new List<string>();

	// Token: 0x04001608 RID: 5640
	private List<string> list_1 = new List<string>();

	// Token: 0x04001609 RID: 5641
	private List<string> list_2 = new List<string>();

	// Token: 0x0400160A RID: 5642
	private GClass134 gclass134_0;

	// Token: 0x0400160B RID: 5643
	private double double_0 = 1.0;

	// Token: 0x0400160C RID: 5644
	private Visibility visibility_0;

	// Token: 0x0400160D RID: 5645
	private string string_2 = string.Empty;

	// Token: 0x0400160E RID: 5646
	private SolidColorBrush solidColorBrush_0 = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd;

	// Token: 0x0400160F RID: 5647
	private double double_1;

	// Token: 0x020005B9 RID: 1465
	[StructLayout(LayoutKind.Auto)]
	private struct Struct341 : IAsyncStateMachine
	{
		// Token: 0x06001FCE RID: 8142 RVA: 0x00082698 File Offset: 0x00080898
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass225 gclass = this.gclass225_0;
			try
			{
				if (num != 0)
				{
					goto IL_8E;
				}
				TaskAwaiter awaiter = this.taskAwaiter_0;
				this.taskAwaiter_0 = default(TaskAwaiter);
				this.int_0 = -1;
				IL_87:
				awaiter.GetResult();
				IL_8E:
				if (gclass.Opacity == 0.0)
				{
					gclass.Visibility = Visibility.Collapsed;
				}
				else
				{
					gclass.Opacity -= 0.1;
					if (gclass.Opacity < 0.05)
					{
						gclass.Opacity = 0.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_87;
					}
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass225.Struct341>(ref awaiter, ref this);
					return;
				}
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

		// Token: 0x06001FCF RID: 8143 RVA: 0x000827B4 File Offset: 0x000809B4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001610 RID: 5648
		public int int_0;

		// Token: 0x04001611 RID: 5649
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001612 RID: 5650
		public GClass225 gclass225_0;

		// Token: 0x04001613 RID: 5651
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005BA RID: 1466
	[StructLayout(LayoutKind.Auto)]
	private struct Struct342 : IAsyncStateMachine
	{
		// Token: 0x06001FD0 RID: 8144 RVA: 0x000827C4 File Offset: 0x000809C4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass225 gclass = this.gclass225_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
					goto IL_29A;
				}
				if (num != 1)
				{
					gclass.method_4(Class364.smethod_0("Removing"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_z2NVHWHQTTE97LGZ_ejd);
					List<string>.Enumerator enumerator = gclass.ServicesNames.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							string text = enumerator.Current;
							GClass93.smethod_0().method_15(typeof(ServicesTweak), text);
							List<GClass151>.Enumerator enumerator2 = Class683.smethod_1(false).AllServices.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									GClass151 gclass2 = enumerator2.Current;
									if (text == gclass2.ServiceName)
									{
										gclass2.DependOn.ForEach(new Action<GClass110>(GClass225.Class653.class653_0.method_0));
										break;
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
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					enumerator = gclass.TweaksNames.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							string string_ = enumerator.Current;
							GClass93.smethod_0().method_15(typeof(Class525), Class364.smethod_0(string_));
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					enumerator = gclass.DevicesNames.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							string string_2 = enumerator.Current;
							GClass93.smethod_0().method_15(typeof(Class520), string_2);
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					List<GClass225>.Enumerator enumerator3 = gclass.dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd_0.list_0.GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							GClass225 gclass3 = enumerator3.Current;
							gclass3.method_1();
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator3).Dispose();
						}
					}
					awaiter = Task.Delay(1000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num3 = 0;
						num = 0;
						this.int_0 = num3;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass225.Struct342>(ref awaiter, ref this);
						return;
					}
					goto IL_29A;
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num4 = -1;
					num = -1;
					this.int_0 = num4;
				}
				IL_26C:
				awaiter.GetResult();
				gclass.method_3();
				goto IL_311;
				IL_29A:
				awaiter.GetResult();
				gclass.method_4(Class364.smethod_0("success"), dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.dje_zND5EHYZY_ejd);
				awaiter = Task.Delay(500).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num5 = 1;
					num = 1;
					this.int_0 = num5;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass225.Struct342>(ref awaiter, ref this);
					return;
				}
				goto IL_26C;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_311:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x00082B8C File Offset: 0x00080D8C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001614 RID: 5652
		public int int_0;

		// Token: 0x04001615 RID: 5653
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001616 RID: 5654
		public GClass225 gclass225_0;

		// Token: 0x04001617 RID: 5655
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005BB RID: 1467
	[Serializable]
	private sealed class Class653
	{
		// Token: 0x06001FD4 RID: 8148 RVA: 0x00082BB0 File Offset: 0x00080DB0
		internal void method_0(GClass110 gclass110_0)
		{
			GClass93.smethod_0().method_15(typeof(ServicesTweak), gclass110_0.ServiceName);
		}

		// Token: 0x04001618 RID: 5656
		public static readonly GClass225.Class653 class653_0 = new GClass225.Class653();

		// Token: 0x04001619 RID: 5657
		public static Action<GClass110> action_0;
	}

	// Token: 0x020005BC RID: 1468
	[StructLayout(LayoutKind.Auto)]
	private struct Struct343 : IAsyncStateMachine
	{
		// Token: 0x06001FD5 RID: 8149 RVA: 0x00082BD0 File Offset: 0x00080DD0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass225 gclass = this.gclass225_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_E2;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_140;
				}
				IL_1D:
				if (gclass.StatusOpacity == 0.0)
				{
					gclass.StatusColor = this.solidColorBrush_0;
					gclass.StatusText = this.string_0;
					goto IL_147;
				}
				gclass.StatusOpacity -= 0.1;
				if (gclass.StatusOpacity < 0.05)
				{
					gclass.StatusOpacity = 0.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass225.Struct343>(ref awaiter, ref this);
					return;
				}
				IL_E2:
				awaiter.GetResult();
				goto IL_1D;
				IL_140:
				awaiter.GetResult();
				IL_147:
				if (gclass.StatusOpacity != 1.0)
				{
					gclass.StatusOpacity += 0.13333333333333333;
					if (gclass.StatusOpacity > 0.95)
					{
						gclass.StatusOpacity = 1.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_140;
					}
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass225.Struct343>(ref awaiter, ref this);
					return;
				}
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

		// Token: 0x06001FD6 RID: 8150 RVA: 0x00082DCC File Offset: 0x00080FCC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400161A RID: 5658
		public int int_0;

		// Token: 0x0400161B RID: 5659
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400161C RID: 5660
		public GClass225 gclass225_0;

		// Token: 0x0400161D RID: 5661
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x0400161E RID: 5662
		public string string_0;

		// Token: 0x0400161F RID: 5663
		private TaskAwaiter taskAwaiter_0;
	}
}
