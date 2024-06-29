using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using ns0;

// Token: 0x020004D7 RID: 1239
internal sealed class Class580
{
	// Token: 0x06001B31 RID: 6961 RVA: 0x0006FC34 File Offset: 0x0006DE34
	public Class580(dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_1)
	{
		this.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0 = dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_1;
		this.list_0 = Class183.smethod_0();
		this.method_2(true);
	}

	// Token: 0x17000425 RID: 1061
	// (get) Token: 0x06001B32 RID: 6962 RVA: 0x0006FC70 File Offset: 0x0006DE70
	public GClass134 RedButton
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_0) == null)
			{
				result = (this.gclass134_0 = new GClass134(new Action<object>(this.method_15), null));
			}
			return result;
		}
	}

	// Token: 0x17000426 RID: 1062
	// (get) Token: 0x06001B33 RID: 6963 RVA: 0x0006FCA4 File Offset: 0x0006DEA4
	public GClass134 MainButton
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_1) == null)
			{
				result = (this.gclass134_1 = new GClass134(new Action<object>(this.method_16), null));
			}
			return result;
		}
	}

	// Token: 0x17000427 RID: 1063
	// (get) Token: 0x06001B34 RID: 6964 RVA: 0x0006FCD8 File Offset: 0x0006DED8
	public GClass134 BackButton
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_2) == null)
			{
				result = (this.gclass134_2 = new GClass134(new Action<object>(this.method_17), null));
			}
			return result;
		}
	}

	// Token: 0x06001B35 RID: 6965 RVA: 0x0006FD0C File Offset: 0x0006DF0C
	public Image method_0()
	{
		if (this.image_0 == null)
		{
			this.image_0 = this.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.image_0;
		}
		Image result = this.image_0;
		this.bool_0 = !this.bool_0;
		this.image_0 = (this.bool_0 ? this.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.image_1 : this.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.image_0);
		return result;
	}

	// Token: 0x06001B36 RID: 6966 RVA: 0x0006FD70 File Offset: 0x0006DF70
	public Image method_1()
	{
		if (this.image_1 == null)
		{
			this.image_1 = this.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.image_0;
		}
		Image result = this.image_1;
		this.bool_1 = !this.bool_1;
		this.image_1 = (this.bool_1 ? this.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.image_1 : this.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.image_0);
		return result;
	}

	// Token: 0x06001B37 RID: 6967 RVA: 0x0006FDD4 File Offset: 0x0006DFD4
	private void method_2(bool bool_3)
	{
		Class580.Struct274 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class580_0 = this;
		@struct.bool_0 = bool_3;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class580.Struct274>(ref @struct);
	}

	// Token: 0x06001B38 RID: 6968 RVA: 0x0006FE14 File Offset: 0x0006E014
	private void method_3()
	{
		Class580.Struct273 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class580_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class580.Struct273>(ref @struct);
	}

	// Token: 0x06001B39 RID: 6969 RVA: 0x0006FE4C File Offset: 0x0006E04C
	private void method_4()
	{
		Class580.Struct269 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class580_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class580.Struct269>(ref @struct);
	}

	// Token: 0x06001B3A RID: 6970 RVA: 0x0006FE84 File Offset: 0x0006E084
	private void method_5()
	{
		Class580.Struct265 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class580_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class580.Struct265>(ref @struct);
	}

	// Token: 0x06001B3B RID: 6971 RVA: 0x0006FEBC File Offset: 0x0006E0BC
	private void method_6()
	{
		dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_10(this.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.textBlock_4, this.list_0[this.int_0].MainButton, this.timeSpan_0);
		dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_10(this.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.textBlock_3, this.list_0[this.int_0].RedButton, this.timeSpan_0);
	}

	// Token: 0x06001B3C RID: 6972 RVA: 0x0006FF24 File Offset: 0x0006E124
	private void method_7()
	{
		Class580.Struct271 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class580.Struct271>(ref @struct);
	}

	// Token: 0x06001B3D RID: 6973 RVA: 0x0006FF54 File Offset: 0x0006E154
	private void method_8()
	{
		Class580.Struct272 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class580.Struct272>(ref @struct);
	}

	// Token: 0x06001B3E RID: 6974 RVA: 0x0006FF84 File Offset: 0x0006E184
	private void method_9()
	{
		Class580.Struct267 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class580_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class580.Struct267>(ref @struct);
	}

	// Token: 0x06001B3F RID: 6975 RVA: 0x0006FFBC File Offset: 0x0006E1BC
	private void method_10()
	{
		Class580.Struct268 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class580_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class580.Struct268>(ref @struct);
	}

	// Token: 0x06001B40 RID: 6976 RVA: 0x0006FFF4 File Offset: 0x0006E1F4
	private void method_11()
	{
		Class580.Struct270 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class580_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class580.Struct270>(ref @struct);
	}

	// Token: 0x06001B41 RID: 6977 RVA: 0x0007002C File Offset: 0x0006E22C
	private void method_12()
	{
		Class580.Struct266 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class580_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class580.Struct266>(ref @struct);
	}

	// Token: 0x06001B42 RID: 6978 RVA: 0x00070064 File Offset: 0x0006E264
	private void method_13()
	{
		Class704.class580_0 = this;
		Class704.bool_0 = true;
	}

	// Token: 0x06001B43 RID: 6979 RVA: 0x00070074 File Offset: 0x0006E274
	public Class724 method_14(string string_0)
	{
		Class580.Class581 @class = new Class580.Class581();
		@class.string_0 = string_0;
		return this.list_0.Find(new Predicate<Class724>(@class.method_0));
	}

	// Token: 0x06001B44 RID: 6980 RVA: 0x000700A8 File Offset: 0x0006E2A8
	private void method_15(object object_0)
	{
		if (this.bool_2)
		{
			return;
		}
		this.method_2(false);
	}

	// Token: 0x06001B45 RID: 6981 RVA: 0x000700BC File Offset: 0x0006E2BC
	private void method_16(object object_0)
	{
		if (this.bool_2)
		{
			return;
		}
		this.method_2(true);
	}

	// Token: 0x06001B46 RID: 6982 RVA: 0x000700D0 File Offset: 0x0006E2D0
	private void method_17(object object_0)
	{
		if (this.bool_2)
		{
			return;
		}
		this.method_3();
	}

	// Token: 0x06001B47 RID: 6983 RVA: 0x000700E4 File Offset: 0x0006E2E4
	private void method_18()
	{
		Application.Current.Dispatcher.Invoke(new Action(this.method_19));
	}

	// Token: 0x06001B48 RID: 6984 RVA: 0x00070104 File Offset: 0x0006E304
	private void method_19()
	{
		Image image = this.method_1();
		image.Source = new BitmapImage(new Uri("pack://application:,,," + this.list_0[this.int_0].Image));
		dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_35(image, TimeSpan.FromSeconds(0.25), new Thickness(320.0, 0.0, 0.0, 0.0), new Thickness(0.0, 0.0, 0.0, 0.0));
		dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_17(image, TimeSpan.FromSeconds(0.25));
		dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(image, TimeSpan.FromSeconds(0.25), FrameworkElement.WidthProperty, 300.0);
	}

	// Token: 0x06001B49 RID: 6985 RVA: 0x000701EC File Offset: 0x0006E3EC
	private void method_20()
	{
		Image uielement_ = this.method_0();
		dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_35(uielement_, TimeSpan.FromSeconds(0.25), new Thickness(0.0, 0.0, 0.0, 0.0), new Thickness(0.0, 0.0, 320.0, 0.0));
		dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_12(uielement_, TimeSpan.FromSeconds(0.25));
		dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(uielement_, TimeSpan.FromSeconds(0.25), FrameworkElement.WidthProperty, 100.0);
	}

	// Token: 0x06001B4A RID: 6986 RVA: 0x000702A4 File Offset: 0x0006E4A4
	private void method_21()
	{
		Application.Current.Dispatcher.Invoke(new Action(this.method_22));
	}

	// Token: 0x06001B4B RID: 6987 RVA: 0x000702C4 File Offset: 0x0006E4C4
	private void method_22()
	{
		Image image = this.method_1();
		image.Source = new BitmapImage(new Uri("pack://application:,,," + this.list_0[this.int_0].Image));
		dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_35(image, TimeSpan.FromSeconds(0.25), new Thickness(0.0, 0.0, 320.0, 0.0), new Thickness(0.0, 0.0, 0.0, 0.0));
		dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_17(image, TimeSpan.FromSeconds(0.25));
		dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(image, TimeSpan.FromSeconds(0.25), FrameworkElement.WidthProperty, 300.0);
	}

	// Token: 0x06001B4C RID: 6988 RVA: 0x000703AC File Offset: 0x0006E5AC
	private void method_23()
	{
		Image uielement_ = this.method_0();
		dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_35(uielement_, TimeSpan.FromSeconds(0.25), new Thickness(0.0, 0.0, 0.0, 0.0), new Thickness(320.0, 0.0, 0.0, 0.0));
		dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_12(uielement_, TimeSpan.FromSeconds(0.25));
		dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_31(uielement_, TimeSpan.FromSeconds(0.25), FrameworkElement.WidthProperty, 100.0);
	}

	// Token: 0x04001314 RID: 4884
	private dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0;

	// Token: 0x04001315 RID: 4885
	private List<Class724> list_0;

	// Token: 0x04001316 RID: 4886
	private GClass134 gclass134_0;

	// Token: 0x04001317 RID: 4887
	private GClass134 gclass134_1;

	// Token: 0x04001318 RID: 4888
	private GClass134 gclass134_2;

	// Token: 0x04001319 RID: 4889
	private int int_0 = -1;

	// Token: 0x0400131A RID: 4890
	private bool bool_0;

	// Token: 0x0400131B RID: 4891
	private Image image_0;

	// Token: 0x0400131C RID: 4892
	private bool bool_1;

	// Token: 0x0400131D RID: 4893
	private Image image_1;

	// Token: 0x0400131E RID: 4894
	private bool bool_2;

	// Token: 0x0400131F RID: 4895
	private TimeSpan timeSpan_0 = TimeSpan.FromSeconds(0.2);

	// Token: 0x020004D8 RID: 1240
	private sealed class Class581
	{
		// Token: 0x06001B4E RID: 6990 RVA: 0x0007046C File Offset: 0x0006E66C
		internal bool method_0(Class724 class724_0)
		{
			return class724_0.Name == this.string_0;
		}

		// Token: 0x04001320 RID: 4896
		public string string_0;
	}

	// Token: 0x020004D9 RID: 1241
	[StructLayout(LayoutKind.Auto)]
	private struct Struct265 : IAsyncStateMachine
	{
		// Token: 0x06001B4F RID: 6991 RVA: 0x00070480 File Offset: 0x0006E680
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class580 @class = this.class580_0;
			try
			{
				TaskAwaiter awaiter;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					break;
				case 1:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_103;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_188;
				default:
					@class.method_6();
					awaiter = Task.Delay(50).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class580.Struct265>(ref awaiter, ref this);
						return;
					}
					break;
				}
				awaiter.GetResult();
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_10(@class.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.textBlock_2, @class.list_0[@class.int_0].Nuance, @class.timeSpan_0);
				awaiter = Task.Delay(50).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class580.Struct265>(ref awaiter, ref this);
					return;
				}
				IL_103:
				awaiter.GetResult();
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_10(@class.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.textBlock_1, @class.list_0[@class.int_0].Description, @class.timeSpan_0);
				awaiter = Task.Delay(50).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class580.Struct265>(ref awaiter, ref this);
					return;
				}
				IL_188:
				awaiter.GetResult();
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_10(@class.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.textBlock_0, @class.list_0[@class.int_0].Question, @class.timeSpan_0);
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

		// Token: 0x06001B50 RID: 6992 RVA: 0x00070690 File Offset: 0x0006E890
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001321 RID: 4897
		public int int_0;

		// Token: 0x04001322 RID: 4898
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001323 RID: 4899
		public Class580 class580_0;

		// Token: 0x04001324 RID: 4900
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004DA RID: 1242
	[StructLayout(LayoutKind.Auto)]
	private struct Struct266 : IAsyncStateMachine
	{
		// Token: 0x06001B51 RID: 6993 RVA: 0x000706A0 File Offset: 0x0006E8A0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class580 @object = this.class580_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_23)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class580.Struct266>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
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

		// Token: 0x06001B52 RID: 6994 RVA: 0x00070760 File Offset: 0x0006E960
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001325 RID: 4901
		public int int_0;

		// Token: 0x04001326 RID: 4902
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001327 RID: 4903
		public Class580 class580_0;

		// Token: 0x04001328 RID: 4904
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004DB RID: 1243
	[StructLayout(LayoutKind.Auto)]
	private struct Struct267 : IAsyncStateMachine
	{
		// Token: 0x06001B53 RID: 6995 RVA: 0x00070770 File Offset: 0x0006E970
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class580 @object = this.class580_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_18)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class580.Struct267>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
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

		// Token: 0x06001B54 RID: 6996 RVA: 0x00070830 File Offset: 0x0006EA30
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001329 RID: 4905
		public int int_0;

		// Token: 0x0400132A RID: 4906
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400132B RID: 4907
		public Class580 class580_0;

		// Token: 0x0400132C RID: 4908
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004DC RID: 1244
	[StructLayout(LayoutKind.Auto)]
	private struct Struct268 : IAsyncStateMachine
	{
		// Token: 0x06001B55 RID: 6997 RVA: 0x00070840 File Offset: 0x0006EA40
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class580 @object = this.class580_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_20)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class580.Struct268>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
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

		// Token: 0x06001B56 RID: 6998 RVA: 0x00070900 File Offset: 0x0006EB00
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400132D RID: 4909
		public int int_0;

		// Token: 0x0400132E RID: 4910
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400132F RID: 4911
		public Class580 class580_0;

		// Token: 0x04001330 RID: 4912
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004DD RID: 1245
	[StructLayout(LayoutKind.Auto)]
	private struct Struct269 : IAsyncStateMachine
	{
		// Token: 0x06001B57 RID: 6999 RVA: 0x00070910 File Offset: 0x0006EB10
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class580 @class = this.class580_0;
			try
			{
				TaskAwaiter awaiter;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					break;
				case 1:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_129;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_1AE;
				default:
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_10(@class.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.textBlock_0, @class.list_0[@class.int_0].Question, @class.timeSpan_0);
					awaiter = Task.Delay(50).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class580.Struct269>(ref awaiter, ref this);
						return;
					}
					break;
				}
				awaiter.GetResult();
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_10(@class.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.textBlock_1, @class.list_0[@class.int_0].Description, @class.timeSpan_0);
				awaiter = Task.Delay(50).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class580.Struct269>(ref awaiter, ref this);
					return;
				}
				IL_129:
				awaiter.GetResult();
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_10(@class.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.textBlock_2, @class.list_0[@class.int_0].Nuance, @class.timeSpan_0);
				awaiter = Task.Delay(50).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class580.Struct269>(ref awaiter, ref this);
					return;
				}
				IL_1AE:
				awaiter.GetResult();
				@class.method_6();
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

		// Token: 0x06001B58 RID: 7000 RVA: 0x00070B20 File Offset: 0x0006ED20
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001331 RID: 4913
		public int int_0;

		// Token: 0x04001332 RID: 4914
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001333 RID: 4915
		public Class580 class580_0;

		// Token: 0x04001334 RID: 4916
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004DE RID: 1246
	[StructLayout(LayoutKind.Auto)]
	private struct Struct270 : IAsyncStateMachine
	{
		// Token: 0x06001B59 RID: 7001 RVA: 0x00070B30 File Offset: 0x0006ED30
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class580 @object = this.class580_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_21)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class580.Struct270>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
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

		// Token: 0x06001B5A RID: 7002 RVA: 0x00070BF0 File Offset: 0x0006EDF0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001335 RID: 4917
		public int int_0;

		// Token: 0x04001336 RID: 4918
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001337 RID: 4919
		public Class580 class580_0;

		// Token: 0x04001338 RID: 4920
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004DF RID: 1247
	[StructLayout(LayoutKind.Auto)]
	private struct Struct271 : IAsyncStateMachine
	{
		// Token: 0x06001B5B RID: 7003 RVA: 0x00070C00 File Offset: 0x0006EE00
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class580.Class582.class582_0.method_2)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class580.Struct271>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
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

		// Token: 0x06001B5C RID: 7004 RVA: 0x00070CCC File Offset: 0x0006EECC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001339 RID: 4921
		public int int_0;

		// Token: 0x0400133A RID: 4922
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400133B RID: 4923
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004E0 RID: 1248
	[StructLayout(LayoutKind.Auto)]
	private struct Struct272 : IAsyncStateMachine
	{
		// Token: 0x06001B5D RID: 7005 RVA: 0x00070CDC File Offset: 0x0006EEDC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class580.Class582.class582_0.method_3)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class580.Struct272>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
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

		// Token: 0x06001B5E RID: 7006 RVA: 0x00070DA8 File Offset: 0x0006EFA8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400133C RID: 4924
		public int int_0;

		// Token: 0x0400133D RID: 4925
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400133E RID: 4926
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004E1 RID: 1249
	[Serializable]
	private sealed class Class582
	{
		// Token: 0x06001B61 RID: 7009 RVA: 0x00070DCC File Offset: 0x0006EFCC
		internal void method_0()
		{
			Class358.smethod_0().method_3(typeof(dje_z8RXGHS5B6UN39WJZNDM7UN2PX42WQY2PPYSQ6C496KLRB6Q_ejd), Class358.smethod_0().frame_0);
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x00070DEC File Offset: 0x0006EFEC
		internal void method_1()
		{
			Class358.smethod_0().method_3(typeof(dje_zQY9BNU6QWSXMEC3Y3Z9MX674M42YS2UN42DQDFQQZX68KU2_ejd), Class358.smethod_0().frame_0);
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x00070E0C File Offset: 0x0006F00C
		internal void method_2()
		{
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x00070E10 File Offset: 0x0006F010
		internal void method_3()
		{
		}

		// Token: 0x0400133F RID: 4927
		public static readonly Class580.Class582 class582_0 = new Class580.Class582();

		// Token: 0x04001340 RID: 4928
		public static Action action_0;

		// Token: 0x04001341 RID: 4929
		public static Action action_1;

		// Token: 0x04001342 RID: 4930
		public static Action action_2;

		// Token: 0x04001343 RID: 4931
		public static Action action_3;
	}

	// Token: 0x020004E2 RID: 1250
	[StructLayout(LayoutKind.Auto)]
	private struct Struct273 : IAsyncStateMachine
	{
		// Token: 0x06001B65 RID: 7013 RVA: 0x00070E14 File Offset: 0x0006F014
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class580 @class = this.class580_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.bool_2 = true;
					@class.int_0--;
					if (@class.int_0 == -1)
					{
						Application.Current.Dispatcher.Invoke(new Action(Class580.Class582.class582_0.method_1));
						goto IL_12C;
					}
					if (!@class.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.button_1.IsEnabled)
					{
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_19(@class.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.button_1);
						@class.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.button_1.IsEnabled = true;
					}
					@class.method_12();
					@class.method_5();
					@class.method_11();
					@class.method_8();
					awaiter = Task.Delay(400).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class580.Struct273>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
				@class.bool_2 = false;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_12C:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x00070F7C File Offset: 0x0006F17C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001344 RID: 4932
		public int int_0;

		// Token: 0x04001345 RID: 4933
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001346 RID: 4934
		public Class580 class580_0;

		// Token: 0x04001347 RID: 4935
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004E3 RID: 1251
	[StructLayout(LayoutKind.Auto)]
	private struct Struct274 : IAsyncStateMachine
	{
		// Token: 0x06001B67 RID: 7015 RVA: 0x00070F8C File Offset: 0x0006F18C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class580 @class = this.class580_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.bool_2 = true;
					if (@class.int_0 == @class.list_0.Count<Class724>() - 1)
					{
						Application.Current.Dispatcher.Invoke(new Action(Class580.Class582.class582_0.method_0));
						goto IL_1E4;
					}
					if (@class.int_0 != -1)
					{
						@class.list_0[@class.int_0].IsChecked = this.bool_0;
					}
					@class.int_0++;
					if (@class.int_0 != @class.list_0.Count<Class724>() - 1 && @class.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.button_1.Opacity == 0.0)
					{
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_19(@class.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.button_1);
						@class.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.button_1.IsEnabled = true;
					}
					if (@class.int_0 == @class.list_0.Count<Class724>() - 1)
					{
						dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_18(@class.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.button_1);
						@class.dje_z3EUTF9ZYNK3XM7V6DVKTXBLJ5L5NNAC2SNPTRSDZ7QH9BZ3EDTVWKPK748KSN7KY53_ejd_0.button_1.IsEnabled = false;
						@class.method_13();
					}
					if (@class.int_0 != 0)
					{
						@class.method_10();
					}
					@class.method_4();
					@class.method_9();
					@class.method_7();
					awaiter = Task.Delay(400).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class580.Struct274>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
				@class.bool_2 = false;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1E4:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x000711AC File Offset: 0x0006F3AC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001348 RID: 4936
		public int int_0;

		// Token: 0x04001349 RID: 4937
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400134A RID: 4938
		public Class580 class580_0;

		// Token: 0x0400134B RID: 4939
		public bool bool_0;

		// Token: 0x0400134C RID: 4940
		private TaskAwaiter taskAwaiter_0;
	}
}
