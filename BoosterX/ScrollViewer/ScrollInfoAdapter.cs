using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace ScrollViewer
{
	// Token: 0x0200084D RID: 2125
	public class ScrollInfoAdapter : UIElement, IScrollInfo
	{
		// Token: 0x06002B2E RID: 11054 RVA: 0x000BAC54 File Offset: 0x000B8E54
		public ScrollInfoAdapter(IScrollInfo child)
		{
			this.iscrollInfo_0 = child;
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06002B30 RID: 11056 RVA: 0x000BACF8 File Offset: 0x000B8EF8
		// (set) Token: 0x06002B31 RID: 11057 RVA: 0x000BAD08 File Offset: 0x000B8F08
		public bool CanVerticallyScroll
		{
			get
			{
				return this.iscrollInfo_0.CanVerticallyScroll;
			}
			set
			{
				this.iscrollInfo_0.CanVerticallyScroll = value;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06002B32 RID: 11058 RVA: 0x000BAD18 File Offset: 0x000B8F18
		// (set) Token: 0x06002B33 RID: 11059 RVA: 0x000BAD28 File Offset: 0x000B8F28
		public bool CanHorizontallyScroll
		{
			get
			{
				return this.iscrollInfo_0.CanHorizontallyScroll;
			}
			set
			{
				this.iscrollInfo_0.CanHorizontallyScroll = value;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06002B34 RID: 11060 RVA: 0x000BAD38 File Offset: 0x000B8F38
		public double ExtentWidth
		{
			get
			{
				return this.iscrollInfo_0.ExtentWidth;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06002B35 RID: 11061 RVA: 0x000BAD48 File Offset: 0x000B8F48
		public double ExtentHeight
		{
			get
			{
				return this.iscrollInfo_0.ExtentHeight;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06002B36 RID: 11062 RVA: 0x000BAD58 File Offset: 0x000B8F58
		public double ViewportWidth
		{
			get
			{
				return this.iscrollInfo_0.ViewportWidth;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06002B37 RID: 11063 RVA: 0x000BAD68 File Offset: 0x000B8F68
		public double ViewportHeight
		{
			get
			{
				return this.iscrollInfo_0.ViewportHeight;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06002B38 RID: 11064 RVA: 0x000BAD78 File Offset: 0x000B8F78
		public double HorizontalOffset
		{
			get
			{
				return this.iscrollInfo_0.HorizontalOffset;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06002B39 RID: 11065 RVA: 0x000BAD88 File Offset: 0x000B8F88
		public double VerticalOffset
		{
			get
			{
				return this.iscrollInfo_0.VerticalOffset;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06002B3A RID: 11066 RVA: 0x000BAD98 File Offset: 0x000B8F98
		// (set) Token: 0x06002B3B RID: 11067 RVA: 0x000BADA8 File Offset: 0x000B8FA8
		public ScrollViewer ScrollOwner
		{
			get
			{
				return this.iscrollInfo_0.ScrollOwner;
			}
			set
			{
				this.iscrollInfo_0.ScrollOwner = value;
			}
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x000BADB8 File Offset: 0x000B8FB8
		public Rect MakeVisible(Visual visual, Rect rectangle)
		{
			return this.iscrollInfo_0.MakeVisible(visual, rectangle);
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x000BADC8 File Offset: 0x000B8FC8
		public void LineUp()
		{
			if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
			{
				this.iscrollInfo_0.LineUp();
				return;
			}
			this.method_1(this.double_0 - 16.0);
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x000BAE00 File Offset: 0x000B9000
		public void LineDown()
		{
			if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
			{
				this.iscrollInfo_0.LineDown();
				return;
			}
			this.method_1(this.double_0 + 16.0);
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x000BAE38 File Offset: 0x000B9038
		public void LineLeft()
		{
			if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
			{
				this.iscrollInfo_0.LineLeft();
				return;
			}
			this.method_2(this.double_1 - 16.0);
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x000BAE70 File Offset: 0x000B9070
		public void LineRight()
		{
			if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
			{
				this.iscrollInfo_0.LineRight();
				return;
			}
			this.method_2(this.double_1 + 16.0);
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x000BAEA8 File Offset: 0x000B90A8
		public void MouseWheelUp()
		{
			if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
			{
				this.iscrollInfo_0.MouseWheelUp();
				return;
			}
			this.method_1(this.double_0 - 100.0);
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x000BAEE0 File Offset: 0x000B90E0
		public void MouseWheelDown()
		{
			if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
			{
				this.iscrollInfo_0.MouseWheelDown();
				return;
			}
			this.method_1(this.double_0 + 100.0);
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x000BAF18 File Offset: 0x000B9118
		public void MouseWheelLeft()
		{
			if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
			{
				this.iscrollInfo_0.MouseWheelLeft();
				return;
			}
			this.method_2(this.double_1 - 100.0);
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x000BAF50 File Offset: 0x000B9150
		public void MouseWheelRight()
		{
			if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
			{
				this.iscrollInfo_0.MouseWheelRight();
				return;
			}
			this.method_2(this.double_1 + 100.0);
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x000BAF88 File Offset: 0x000B9188
		public void PageUp()
		{
			if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
			{
				this.iscrollInfo_0.PageUp();
				return;
			}
			this.method_1(this.double_0 - this.ViewportHeight);
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x000BAFBC File Offset: 0x000B91BC
		public void PageDown()
		{
			if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
			{
				this.iscrollInfo_0.PageDown();
				return;
			}
			this.method_1(this.double_0 + this.ViewportHeight);
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x000BAFF0 File Offset: 0x000B91F0
		public void PageLeft()
		{
			if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
			{
				this.iscrollInfo_0.PageLeft();
				return;
			}
			this.method_2(this.double_1 - this.ViewportWidth);
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x000BB024 File Offset: 0x000B9224
		public void PageRight()
		{
			if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
			{
				this.iscrollInfo_0.PageRight();
				return;
			}
			this.method_2(this.double_1 + this.ViewportWidth);
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x000BB058 File Offset: 0x000B9258
		public void SetHorizontalOffset(double offset)
		{
			if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
			{
				this.iscrollInfo_0.SetHorizontalOffset(offset);
				return;
			}
			this.double_1 = offset;
			this.method_0(ScrollInfoAdapter.dependencyProperty_1, offset, 0);
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x000BB090 File Offset: 0x000B9290
		public void SetVerticalOffset(double offset)
		{
			if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
			{
				this.iscrollInfo_0.SetVerticalOffset(offset);
				return;
			}
			this.double_0 = offset;
			this.method_0(ScrollInfoAdapter.dependencyProperty_0, offset, 0);
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x000BB0C8 File Offset: 0x000B92C8
		private void method_0(DependencyProperty dependencyProperty_2, double double_2, int int_0)
		{
			bool? flag = Class389.class504_0.method_24();
			if (flag.GetValueOrDefault() & flag != null)
			{
				int_0 = 0;
			}
			base.BeginAnimation(dependencyProperty_2, new DoubleAnimationUsingKeyFrames
			{
				Duration = TimeSpan.FromMilliseconds((double)int_0),
				KeyFrames = 
				{
					new SplineDoubleKeyFrame(double_2, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds((double)int_0)), new KeySpline(0.25, 0.1, 0.25, 1.0))
				}
			});
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x000BB160 File Offset: 0x000B9360
		private void method_1(double double_2)
		{
			if (Math.Abs(this.double_0 - this.method_3(double_2)) > 0.1)
			{
				this.double_0 = this.method_3(double_2);
				this.method_0(ScrollInfoAdapter.dependencyProperty_0, this.double_0, 300);
			}
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x000BB1B0 File Offset: 0x000B93B0
		private void method_2(double double_2)
		{
			if (Math.Abs(this.double_1 - this.method_4(double_2)) > 0.1)
			{
				this.double_1 = this.method_4(double_2);
				this.method_0(ScrollInfoAdapter.dependencyProperty_1, this.double_1, 300);
			}
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x000BB200 File Offset: 0x000B9400
		private double method_3(double double_2)
		{
			if (double_2 < 0.0)
			{
				return 0.0;
			}
			if (double_2 > this.iscrollInfo_0.ScrollOwner.ScrollableHeight)
			{
				return this.iscrollInfo_0.ScrollOwner.ScrollableHeight;
			}
			return double_2;
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x000BB240 File Offset: 0x000B9440
		private double method_4(double double_2)
		{
			if (double_2 < 0.0)
			{
				return 0.0;
			}
			if (double_2 > this.iscrollInfo_0.ScrollOwner.ScrollableWidth)
			{
				return this.iscrollInfo_0.ScrollOwner.ScrollableWidth;
			}
			return double_2;
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06002B50 RID: 11088 RVA: 0x000BB280 File Offset: 0x000B9480
		// (set) Token: 0x06002B51 RID: 11089 RVA: 0x000BB294 File Offset: 0x000B9494
		internal double VerticalScrollOffset
		{
			get
			{
				return (double)base.GetValue(ScrollInfoAdapter.dependencyProperty_0);
			}
			set
			{
				base.SetValue(ScrollInfoAdapter.dependencyProperty_0, value);
			}
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x000BB2A8 File Offset: 0x000B94A8
		private static void smethod_0(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			((ScrollInfoAdapter)dependencyObject_0).iscrollInfo_0.SetVerticalOffset((double)dependencyPropertyChangedEventArgs_0.NewValue);
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06002B53 RID: 11091 RVA: 0x000BB2C8 File Offset: 0x000B94C8
		// (set) Token: 0x06002B54 RID: 11092 RVA: 0x000BB2DC File Offset: 0x000B94DC
		internal double HorizontalScrollOffset
		{
			get
			{
				return (double)base.GetValue(ScrollInfoAdapter.dependencyProperty_1);
			}
			set
			{
				base.SetValue(ScrollInfoAdapter.dependencyProperty_1, value);
			}
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x000BB2F0 File Offset: 0x000B94F0
		private static void smethod_1(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			((ScrollInfoAdapter)dependencyObject_0).iscrollInfo_0.SetHorizontalOffset((double)dependencyPropertyChangedEventArgs_0.NewValue);
		}

		// Token: 0x04002194 RID: 8596
		private IScrollInfo iscrollInfo_0;

		// Token: 0x04002195 RID: 8597
		private double double_0;

		// Token: 0x04002196 RID: 8598
		private double double_1;

		// Token: 0x04002197 RID: 8599
		internal static readonly DependencyProperty dependencyProperty_0 = DependencyProperty.Register("VerticalScrollOffset", typeof(double), typeof(ScrollInfoAdapter), new PropertyMetadata(0.0, new PropertyChangedCallback(ScrollInfoAdapter.smethod_0)));

		// Token: 0x04002198 RID: 8600
		internal static readonly DependencyProperty dependencyProperty_1 = DependencyProperty.Register("HorizontalScrollOffset", typeof(double), typeof(ScrollInfoAdapter), new PropertyMetadata(0.0, new PropertyChangedCallback(ScrollInfoAdapter.smethod_1)));
	}
}
