using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Capture;
using Capture.Hook;
using Capture.Hook.Common;
using Capture.Interface;
using Linearstar.Windows.RawInput.Native;
using Newtonsoft.Json;
using ns0;

// Token: 0x020000E9 RID: 233
internal sealed class Class715 : GClass211
{
	// Token: 0x060006C3 RID: 1731 RVA: 0x000208EC File Offset: 0x0001EAEC
	public Class715(dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_1, Class728 class728_1, Class693 class693_0 = null, string string_4 = "")
	{
		Class715.Class143 @class = new Class715.Class143();
		@class.class693_0 = class693_0;
		base..ctor();
		this.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0 = dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_1;
		this.class728_0 = class728_1;
		if (!string_4.smethod_7())
		{
			this.Name = string_4;
		}
		this.Values.CollectionChanged += this.method_3;
		if (@class.class693_0 != null)
		{
			this.Name = @class.class693_0.Name;
			if (this.TestingAreas.Any(new Func<Class710, bool>(@class.method_0)))
			{
				this.ChoosenArea = this.TestingAreas.First(new Func<Class710, bool>(@class.method_1));
			}
			else
			{
				this.ChoosenArea = this.TestingAreas[0];
			}
			this.SelectedClickCount = @class.class693_0.Int32_0;
			this.Date = @class.class693_0.DateTime_0;
			foreach (double item in @class.class693_0.Values)
			{
				this.Values.Add(item);
			}
		}
		base.method_0("Values");
		this.intptr_1 = Class715.GetWindowDC(this.intptr_0);
	}

	// Token: 0x060006C5 RID: 1733 RVA: 0x00020B4C File Offset: 0x0001ED4C
	private void method_1()
	{
		this.thread_0 = new Thread(new ThreadStart(this.method_36));
		this.thread_0.IsBackground = true;
		this.thread_0.Priority = ThreadPriority.Highest;
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x00020B80 File Offset: 0x0001ED80
	private void method_2()
	{
		Class715.Struct42 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class715_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class715.Struct42>(ref @struct);
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00020BB8 File Offset: 0x0001EDB8
	public List<Class710> TestingAreas
	{
		get
		{
			if (this.list_0 == null)
			{
				this.list_0 = new List<Class710>
				{
					new Class710
					{
						Name = "Auto",
						Icon = Class650.smethod_7()
					},
					new Class710
					{
						Name = "Click",
						Icon = Class650.smethod_7()
					}
				};
			}
			return this.list_0;
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x060006C8 RID: 1736 RVA: 0x00020C20 File Offset: 0x0001EE20
	// (set) Token: 0x060006C9 RID: 1737 RVA: 0x00020C58 File Offset: 0x0001EE58
	public Class710 ChoosenArea
	{
		get
		{
			if (this.class710_0 == null)
			{
				this.class710_0 = this.TestingAreas[Convert.ToInt32(Class389.class504_0.method_10())];
			}
			return this.class710_0;
		}
		set
		{
			for (int i = 0; i < 3; i++)
			{
				if (this.TestingAreas[i] == value)
				{
					Class389.class504_0.method_11(new int?(i));
					IL_3D:
					this.class710_0 = value;
					base.method_0("ChoosenArea");
					return;
				}
			}
			goto IL_3D;
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x060006CA RID: 1738 RVA: 0x00020CB4 File Offset: 0x0001EEB4
	// (set) Token: 0x060006CB RID: 1739 RVA: 0x00020CBC File Offset: 0x0001EEBC
	public bool IsChoosen
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			if (!value)
			{
				if (this.class728_0.Models.Where(new Func<Class715, bool>(Class715.Class142.class142_0.method_0)).Count<Class715>() > 1)
				{
					this.bool_0 = value;
					if (this.class728_0.byte_0 == 1)
					{
						this.class728_0.method_4(this);
					}
				}
			}
			if (value)
			{
				this.bool_0 = value;
				if (this.class728_0.byte_0 == 0)
				{
					foreach (Class715 @class in this.class728_0.Models)
					{
						if (@class != this)
						{
							@class.IsChoosen = false;
						}
					}
					this.class728_0.Choosen = this;
					this.method_2();
				}
				if (this.class728_0.byte_0 == 1)
				{
					this.class728_0.method_3(this);
				}
			}
			this.BorderOpacity = 0.6;
			base.method_0("IsChoosen");
			base.method_0("Values");
		}
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x00020DFC File Offset: 0x0001EFFC
	private void method_3(object sender, NotifyCollectionChangedEventArgs p1)
	{
		base.method_0("HasValues");
		base.method_0("AverageS");
		base.method_0("CountS");
		base.method_0("LastValueS");
		base.method_0("MinS");
		base.method_0("MaxS");
		base.method_0("StdDevS");
		base.method_0("StdDevS");
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x060006CD RID: 1741 RVA: 0x00020E64 File Offset: 0x0001F064
	// (set) Token: 0x060006CE RID: 1742 RVA: 0x00020E6C File Offset: 0x0001F06C
	public string Name
	{
		get
		{
			return this.string_1;
		}
		set
		{
			if (this.string_0 == null)
			{
				this.string_0 = value;
			}
			this.string_1 = value;
			base.method_0("Name");
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x060006CF RID: 1743 RVA: 0x00020E90 File Offset: 0x0001F090
	// (set) Token: 0x060006D0 RID: 1744 RVA: 0x00020E98 File Offset: 0x0001F098
	public DateTime Date
	{
		[CompilerGenerated]
		get
		{
			return this.dateTime_0;
		}
		[CompilerGenerated]
		set
		{
			this.dateTime_0 = value;
		}
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x060006D1 RID: 1745 RVA: 0x00020EA4 File Offset: 0x0001F0A4
	public string DateString
	{
		get
		{
			return this.Date.ToString("dd.MM.yyyy HH:mm");
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x060006D2 RID: 1746 RVA: 0x00020EC4 File Offset: 0x0001F0C4
	// (set) Token: 0x060006D3 RID: 1747 RVA: 0x00020ECC File Offset: 0x0001F0CC
	public ObservableCollection<double> Values
	{
		[CompilerGenerated]
		get
		{
			return this.observableCollection_0;
		}
		[CompilerGenerated]
		set
		{
			this.observableCollection_0 = value;
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00020ED8 File Offset: 0x0001F0D8
	public bool HasValues
	{
		get
		{
			return this.Values.Count > 0;
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x060006D5 RID: 1749 RVA: 0x00020EE8 File Offset: 0x0001F0E8
	public double Average
	{
		get
		{
			if (this.Values.Count<double>() == 0)
			{
				return 0.0;
			}
			return this.Values.Sum(new Func<double, double>(Class715.Class142.class142_0.method_1)) / (double)this.Values.Count<double>();
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00020F44 File Offset: 0x0001F144
	public double LastValue
	{
		get
		{
			if (this.Values.Count<double>() == 0)
			{
				return 0.0;
			}
			return this.Values.Last<double>();
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00020F68 File Offset: 0x0001F168
	public double Min
	{
		get
		{
			if (this.Values.Count<double>() == 0)
			{
				return 0.0;
			}
			return this.Values.Min();
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00020F8C File Offset: 0x0001F18C
	public double Max
	{
		get
		{
			if (this.Values.Count<double>() == 0)
			{
				return 0.0;
			}
			return this.Values.Max();
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00020FB0 File Offset: 0x0001F1B0
	public double StdDev
	{
		get
		{
			Class715.Class140 @class = new Class715.Class140();
			if (this.Values.Count<double>() == 0)
			{
				return 0.0;
			}
			@class.double_0 = this.Values.Average();
			return Math.Sqrt(this.Values.Sum(new Func<double, double>(@class.method_0)) / (double)this.Values.Count);
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x060006DA RID: 1754 RVA: 0x00021014 File Offset: 0x0001F214
	public string AverageS
	{
		get
		{
			return this.Average.ToString().smethod_15(2);
		}
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x060006DB RID: 1755 RVA: 0x00021038 File Offset: 0x0001F238
	public string LastValueS
	{
		get
		{
			return this.LastValue.ToString().smethod_15(2);
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x060006DC RID: 1756 RVA: 0x0002105C File Offset: 0x0001F25C
	public string MinS
	{
		get
		{
			return this.Min.ToString().smethod_15(2);
		}
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x060006DD RID: 1757 RVA: 0x00021080 File Offset: 0x0001F280
	public string MaxS
	{
		get
		{
			return this.Max.ToString().smethod_15(2);
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x060006DE RID: 1758 RVA: 0x000210A4 File Offset: 0x0001F2A4
	public string StdDevS
	{
		get
		{
			return this.StdDev.ToString().smethod_15(2);
		}
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x060006DF RID: 1759 RVA: 0x000210C8 File Offset: 0x0001F2C8
	public string CountS
	{
		get
		{
			return this.Values.Count<double>().ToString();
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x060006E0 RID: 1760 RVA: 0x000210E8 File Offset: 0x0001F2E8
	// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00021114 File Offset: 0x0001F314
	public int SelectedClickCount
	{
		get
		{
			if (this.int_0 == 0)
			{
				this.int_0 = Convert.ToInt32(Class389.class504_0.method_4());
			}
			return this.int_0;
		}
		set
		{
			Class389.class504_0.method_5(new int?(value));
			this.int_0 = value;
			base.method_0("SelectedClickCount");
		}
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00021138 File Offset: 0x0001F338
	public List<int> ClickCounts
	{
		get
		{
			if (this.list_1 == null)
			{
				this.list_1 = new List<int>
				{
					10,
					20,
					50,
					100,
					200,
					300,
					500
				};
			}
			return this.list_1;
		}
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x060006E3 RID: 1763 RVA: 0x000211A0 File Offset: 0x0001F3A0
	public int ClickCount
	{
		get
		{
			return this.SelectedClickCount;
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x060006E4 RID: 1764 RVA: 0x000211A8 File Offset: 0x0001F3A8
	// (set) Token: 0x060006E5 RID: 1765 RVA: 0x000211B0 File Offset: 0x0001F3B0
	public int ClickCountLeft
	{
		get
		{
			return this.int_1;
		}
		set
		{
			this.int_1 = value;
			base.method_0("ClickCountLeftText");
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x060006E6 RID: 1766 RVA: 0x000211C4 File Offset: 0x0001F3C4
	// (set) Token: 0x060006E7 RID: 1767 RVA: 0x000211CC File Offset: 0x0001F3CC
	public string CS2Status
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			base.method_0("CS2Status");
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x060006E8 RID: 1768 RVA: 0x000211E0 File Offset: 0x0001F3E0
	// (set) Token: 0x060006E9 RID: 1769 RVA: 0x000211E8 File Offset: 0x0001F3E8
	public string ClickText1
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
			base.method_0("ClickText1");
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x060006EA RID: 1770 RVA: 0x000211FC File Offset: 0x0001F3FC
	public string ClickCountLeftText
	{
		get
		{
			return this.ClickCountLeft.ToString();
		}
	}

	// Token: 0x060006EB RID: 1771
	[DllImport("gdi32.dll")]
	private static extern int BitBlt(IntPtr intptr_3, int int_8, int int_9, int int_10, int int_11, IntPtr intptr_4, int int_12, int int_13, int int_14);

	// Token: 0x060006EC RID: 1772
	[DllImport("user32.dll")]
	private static extern bool ReleaseDC(IntPtr intptr_3, IntPtr intptr_4);

	// Token: 0x060006ED RID: 1773
	[DllImport("gdi32.dll")]
	private static extern uint GetPixel(IntPtr intptr_3, int int_8, int int_9);

	// Token: 0x060006EE RID: 1774
	[DllImport("user32.dll")]
	private static extern IntPtr GetDC(IntPtr intptr_3);

	// Token: 0x060006EF RID: 1775
	[DllImport("user32.dll")]
	private static extern IntPtr GetWindowDC(IntPtr intptr_3);

	// Token: 0x060006F0 RID: 1776
	[DllImport("gdi32.dll", SetLastError = true)]
	private static extern IntPtr CreateCompatibleDC(IntPtr intptr_3);

	// Token: 0x060006F1 RID: 1777
	[DllImport("user32.dll")]
	private static extern IntPtr GetDesktopWindow();

	// Token: 0x060006F2 RID: 1778
	[DllImport("gdi32.dll")]
	private static extern IntPtr CreateCompatibleBitmap(IntPtr intptr_3, int int_8, int int_9);

	// Token: 0x060006F3 RID: 1779
	[DllImport("gdi32.dll")]
	private static extern IntPtr SelectObject(IntPtr intptr_3, IntPtr intptr_4);

	// Token: 0x060006F4 RID: 1780
	[DllImport("gdi32.dll")]
	private static extern bool BitBlt(IntPtr intptr_3, int int_8, int int_9, int int_10, int int_11, IntPtr intptr_4, int int_12, int int_13, uint uint_0);

	// Token: 0x060006F5 RID: 1781
	[DllImport("gdi32.dll")]
	private static extern bool DeleteObject(IntPtr intptr_3);

	// Token: 0x060006F6 RID: 1782
	[DllImport("user32.dll")]
	public static extern int GetSystemMetrics(int int_8);

	// Token: 0x060006F7 RID: 1783 RVA: 0x00021218 File Offset: 0x0001F418
	private int method_4()
	{
		if (this.process_0 == null)
		{
			return 0;
		}
		if (Class389.class504_0.method_6() != null)
		{
			int? num = Class389.class504_0.method_6();
			if (!(num.GetValueOrDefault() == 0 & num != null))
			{
				num = Class389.class504_0.method_6();
				int num2 = this.int_6;
				if (!(num.GetValueOrDefault() > num2 & num != null))
				{
					goto IL_7F;
				}
			}
		}
		Class389.class504_0.method_7(new int?(this.int_6 / 2 - 100));
		IL_7F:
		return Convert.ToInt32(Class389.class504_0.method_6());
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x000212B8 File Offset: 0x0001F4B8
	private void method_5(int int_8)
	{
		Class389.class504_0.method_7(new int?(int_8));
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x000212CC File Offset: 0x0001F4CC
	private int method_6()
	{
		if (this.process_0 == null)
		{
			return 0;
		}
		if (Class389.class504_0.method_8() != null)
		{
			int? num = Class389.class504_0.method_8();
			if (!(num.GetValueOrDefault() == 0 & num != null))
			{
				num = Class389.class504_0.method_8();
				int num2 = this.int_7;
				if (!(num.GetValueOrDefault() > num2 & num != null))
				{
					goto IL_7F;
				}
			}
		}
		Class389.class504_0.method_9(new int?(this.int_7 / 2 - 100));
		IL_7F:
		return Convert.ToInt32(Class389.class504_0.method_8());
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x0002136C File Offset: 0x0001F56C
	private void method_7(int int_8)
	{
		Class389.class504_0.method_9(new int?(int_8));
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00021380 File Offset: 0x0001F580
	private void method_8()
	{
		this.rectangle_0 = new Rectangle(this.method_10(), this.method_11(), 1, 1);
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x0002139C File Offset: 0x0001F59C
	public bool method_9(Bitmap bitmap_2)
	{
		for (int i = 0; i < bitmap_2.Width; i++)
		{
			for (int j = 0; j < bitmap_2.Height; j++)
			{
				if (bitmap_2.GetPixel(i, j) != Color.Black)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x000213F8 File Offset: 0x0001F5F8
	private int method_10()
	{
		return this.method_4() + 100;
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x00021404 File Offset: 0x0001F604
	private int method_11()
	{
		return this.method_6() + 100;
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x00021410 File Offset: 0x0001F610
	public static void smethod_0(Class715.Delegate23 delegate23_1)
	{
		Class715.Delegate23 @delegate = Class715.delegate23_0;
		Class715.Delegate23 delegate2;
		do
		{
			delegate2 = @delegate;
			Class715.Delegate23 value = (Class715.Delegate23)Delegate.Combine(delegate2, delegate23_1);
			@delegate = Interlocked.CompareExchange<Class715.Delegate23>(ref Class715.delegate23_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x00021444 File Offset: 0x0001F644
	public static void smethod_1(Class715.Delegate23 delegate23_1)
	{
		Class715.Delegate23 @delegate = Class715.delegate23_0;
		Class715.Delegate23 delegate2;
		do
		{
			delegate2 = @delegate;
			Class715.Delegate23 value = (Class715.Delegate23)Delegate.Remove(delegate2, delegate23_1);
			@delegate = Interlocked.CompareExchange<Class715.Delegate23>(ref Class715.delegate23_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00021478 File Offset: 0x0001F678
	private void method_12()
	{
		Class715.Struct40 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class715_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class715.Struct40>(ref @struct);
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x000214B0 File Offset: 0x0001F6B0
	private void method_13()
	{
		Class715.Struct39 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class715_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class715.Struct39>(ref @struct);
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x000214E8 File Offset: 0x0001F6E8
	private void method_14()
	{
		this.captureProcess_0.CaptureInterface.BeginGetScreenshot(this.rectangle_0, this.timeSpan_1, new AsyncCallback(this.method_15), null, 0);
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x00021528 File Offset: 0x0001F728
	private void method_15(IAsyncResult iasyncResult_0)
	{
		using (Screenshot screenshot = this.captureProcess_0.CaptureInterface.EndGetScreenshot(iasyncResult_0))
		{
			try
			{
				this.color_0 = ScreenshotExtensions.ToBitmap(screenshot).GetPixel(0, 0);
				if (this.color_0.R > 50 || this.color_0.G > 50 || this.color_0.B > 70)
				{
					this.method_16();
					this.bool_2 = false;
				}
			}
			catch (object obj)
			{
			}
			finally
			{
				if (this.bool_2)
				{
					this.thread_1 = new Thread(new ThreadStart(this.method_14));
					this.thread_1.Start();
				}
			}
		}
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x00021610 File Offset: 0x0001F810
	private void method_16()
	{
		Class715.Struct36 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class715_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class715.Struct36>(ref @struct);
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x00021648 File Offset: 0x0001F848
	private Task method_17()
	{
		Class715.Struct43 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class715_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class715.Struct43>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x0002168C File Offset: 0x0001F88C
	private void method_18()
	{
		Class631.smethod_1(new Class631.Delegate31(this.method_21));
	}

	// Token: 0x06000708 RID: 1800 RVA: 0x000216A0 File Offset: 0x0001F8A0
	private void method_19()
	{
		Class715.Struct37 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class715_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class715.Struct37>(ref @struct);
	}

	// Token: 0x06000709 RID: 1801 RVA: 0x000216D8 File Offset: 0x0001F8D8
	private void method_20()
	{
		if (this.bool_1)
		{
			return;
		}
		this.bool_1 = true;
		this.timeSpan_0 = this.stopwatch_0.Elapsed;
		this.method_22();
	}

	// Token: 0x0600070A RID: 1802 RVA: 0x00021704 File Offset: 0x0001F904
	private void method_21()
	{
		Class715.Struct38 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class715_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class715.Struct38>(ref @struct);
	}

	// Token: 0x0600070B RID: 1803 RVA: 0x0002173C File Offset: 0x0001F93C
	private void method_22()
	{
		Class715.Struct35 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class715_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class715.Struct35>(ref @struct);
	}

	// Token: 0x0600070C RID: 1804 RVA: 0x00021774 File Offset: 0x0001F974
	private void method_23(Process[] process_1)
	{
		Class715.Struct34 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class715_0 = this;
		@struct.process_0 = process_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class715.Struct34>(ref @struct);
	}

	// Token: 0x0600070D RID: 1805 RVA: 0x000217B4 File Offset: 0x0001F9B4
	private void method_24(IAsyncResult iasyncResult_0)
	{
		using (Screenshot screenshot = this.captureProcess_0.CaptureInterface.EndGetScreenshot(iasyncResult_0))
		{
			try
			{
				this.bitmap_1 = ScreenshotExtensions.ToBitmap(screenshot);
				this.int_6 = this.bitmap_1.Width;
				this.int_7 = this.bitmap_1.Height;
			}
			catch (object obj)
			{
			}
		}
		this.bool_3 = true;
	}

	// Token: 0x0600070E RID: 1806 RVA: 0x00021834 File Offset: 0x0001FA34
	private string method_25()
	{
		return string.Concat(new string[]
		{
			this.CountS,
			"\n",
			this.LastValueS,
			"\n",
			this.AverageS,
			"\n",
			this.MinS,
			"\n",
			this.MaxS,
			"\n",
			this.StdDevS
		});
	}

	// Token: 0x0600070F RID: 1807 RVA: 0x000218B0 File Offset: 0x0001FAB0
	private void method_26()
	{
		Class715.Struct30 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class715_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class715.Struct30>(ref @struct);
	}

	// Token: 0x06000710 RID: 1808 RVA: 0x000218E8 File Offset: 0x0001FAE8
	private void method_27()
	{
		this.overlay_0.Elements = this.list_2;
		this.overlay_0.Elements.Clear();
		this.imageElement_0.Image = Class267.smethod_1("pack://application:,,,/Resources/Images/LatencyPics/CS1" + Class364.smethod_0("CurrentLocalization") + ".png");
		this.imageElement_0.Location = this.point_0;
		this.list_2.Add(this.imageElement_0);
		this.list_2.Add(this.method_30());
		this.method_26();
	}

	// Token: 0x06000711 RID: 1809 RVA: 0x00021978 File Offset: 0x0001FB78
	private void method_28()
	{
		this.overlay_0.Elements = this.list_2;
		this.overlay_0.Elements.Clear();
		this.imageElement_0.Image = Class267.smethod_1("pack://application:,,,/Resources/Images/LatencyPics/Game1" + Class364.smethod_0("CurrentLocalization") + ".png");
		this.imageElement_0.Location = this.point_0;
		this.list_2.Add(this.imageElement_0);
		this.list_2.Add(this.method_30());
		this.method_26();
	}

	// Token: 0x06000712 RID: 1810 RVA: 0x00021A08 File Offset: 0x0001FC08
	private void method_29()
	{
		this.overlay_0.Elements.Clear();
		this.imageElement_0.Location = this.point_0;
		this.imageElement_0.Image = Class267.smethod_1("pack://application:,,,/Resources/Images/LatencyPics/Results" + Class364.smethod_0("CurrentLocalization") + ".png");
		this.list_2.Add(this.imageElement_0);
		this.list_2.Add(new TextElement
		{
			AntiAliased = true,
			Color = Color.White,
			Location = new System.Drawing.Point(270, 50),
			Font = new Font("Consolas", 20f, System.Drawing.FontStyle.Bold),
			Text = this.method_25()
		});
		this.list_2.Add(this.method_30());
		this.overlay_0.Elements = this.list_2;
		this.method_26();
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x00021AF0 File Offset: 0x0001FCF0
	private ImageElement method_30()
	{
		this.imageElement_1.Image = Class267.smethod_1("pack://application:,,,/Resources/Images/LatencyPics/Pointer.png");
		this.point_1.X = this.method_4();
		this.point_1.Y = this.method_6();
		this.imageElement_1.Location = this.point_1;
		return this.imageElement_1;
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x00021B4C File Offset: 0x0001FD4C
	private void method_31(RawKeyboard rawKeyboard_0)
	{
		Class715.Struct31 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class715_0 = this;
		@struct.rawKeyboard_0 = rawKeyboard_0;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class715.Struct31>(ref @struct);
	}

	// Token: 0x06000715 RID: 1813 RVA: 0x00021B8C File Offset: 0x0001FD8C
	private void method_32()
	{
		if (this.list_3.Contains(17) && this.list_3.Contains(75) && (this.enum4_0 == (Class715.Enum4)2 || this.enum4_0 == (Class715.Enum4)0))
		{
			this.list_3.Clear();
			this.method_19();
		}
		if (this.process_0 != null)
		{
			if (this.list_3.Contains(39))
			{
				this.method_5(this.method_4() + 4);
				this.method_42();
			}
			if (this.list_3.Contains(37))
			{
				this.method_5(this.method_4() - 4);
				this.method_42();
			}
			if (this.list_3.Contains(40))
			{
				this.method_7(this.method_6() + 4);
				this.method_42();
			}
			if (this.list_3.Contains(38))
			{
				this.method_7(this.method_6() - 4);
				this.method_42();
			}
		}
		if (this.list_3.Contains(17) && this.list_3.Contains(76) && this.process_0 != null && (this.enum4_0 == (Class715.Enum4)0 || this.enum4_0 == (Class715.Enum4)1))
		{
			this.enum4_0 = (Class715.Enum4)2;
			Class631.smethod_0(new Class631.Delegate31(this.method_21));
			this.method_29();
		}
		if (this.list_3.Contains(17) && this.list_3.Contains(74) && this.process_0 != null && (this.enum4_0 == (Class715.Enum4)2 || this.enum4_0 == (Class715.Enum4)1))
		{
			this.Values.Clear();
			this.ClickCountLeft = this.ClickCount;
			this.stopwatch_0.Reset();
			this.stopwatch_0.Start();
			this.bool_2 = false;
			Class631.smethod_0(new Class631.Delegate31(this.method_21));
			this.method_29();
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x06000716 RID: 1814 RVA: 0x00021D84 File Offset: 0x0001FF84
	public GClass134 Start
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_0) == null)
			{
				result = (this.gclass134_0 = new GClass134(new Action<object>(this.method_43), null));
			}
			return result;
		}
	}

	// Token: 0x06000717 RID: 1815 RVA: 0x00021DB8 File Offset: 0x0001FFB8
	private void method_33()
	{
		Class715.Struct29 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class715_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class715.Struct29>(ref @struct);
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x06000718 RID: 1816 RVA: 0x00021DF0 File Offset: 0x0001FFF0
	public GClass134 ReloadCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_1) == null)
			{
				result = (this.gclass134_1 = new GClass134(new Action<object>(this.method_46), null));
			}
			return result;
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x06000719 RID: 1817 RVA: 0x00021E24 File Offset: 0x00020024
	public GClass134 DeleteCommand
	{
		get
		{
			GClass134 result;
			if ((result = this.gclass134_2) == null)
			{
				result = (this.gclass134_2 = new GClass134(new Action<object>(this.method_47), null));
			}
			return result;
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x0600071A RID: 1818 RVA: 0x00021E58 File Offset: 0x00020058
	public GClass134 Rename
	{
		get
		{
			return new GClass134(new Action<object>(this.method_48), null);
		}
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x00021E6C File Offset: 0x0002006C
	private void method_34()
	{
		if (File.Exists(Path.Combine(Class186.string_8, this.string_0 + ".lx")))
		{
			File.Delete(Path.Combine(Class186.string_8, this.string_0 + ".lx"));
			this.string_0 = this.Name;
		}
		Class693 @class = new Class693
		{
			Name = this.Name,
			ChoosenArea = this.ChoosenArea.Name,
			DateTime_0 = this.Date,
			Int32_0 = this.ClickCount
		};
		foreach (double item in this.Values)
		{
			@class.Values.Add(item);
		}
		string contents = Class376.smethod_0(JsonConvert.SerializeObject(@class, 1));
		File.WriteAllText(Path.Combine(Class186.string_8, this.Name + ".lx"), contents);
	}

	// Token: 0x0600071C RID: 1820 RVA: 0x00021F74 File Offset: 0x00020174
	private void method_35()
	{
		File.Delete(Path.Combine(Class186.string_8, this.Name + ".lx"));
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x0600071D RID: 1821 RVA: 0x00021F98 File Offset: 0x00020198
	// (set) Token: 0x0600071E RID: 1822 RVA: 0x00021FA0 File Offset: 0x000201A0
	public double BorderOpacity
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
			base.method_0("BorderOpacity");
		}
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x00021FB4 File Offset: 0x000201B4
	private void method_36()
	{
		while (this.bool_1)
		{
			this.int_4 = (int)Class715.GetPixel(this.intptr_1, this.int_2, this.int_3);
			this.color_0 = Color.FromArgb(255, this.int_4 & 255, this.int_4 >> 8 & 255, this.int_4 >> 16 & 255);
			if (this.color_0.Name == "ff000000")
			{
				this.bool_1 = false;
				this.method_13();
				this.method_16();
				return;
			}
		}
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x0002204C File Offset: 0x0002024C
	private void method_37()
	{
		this.BorderOpacity = 1.0;
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x00022060 File Offset: 0x00020260
	private void method_38()
	{
		this.BorderOpacity = 0.6;
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x00022074 File Offset: 0x00020274
	private void method_39()
	{
		do
		{
			this.int_4 = (int)Class715.GetPixel(this.intptr_1, this.int_2, this.int_3);
			this.color_0 = Color.FromArgb(255, this.int_4 & 255, this.int_4 >> 8 & 255, this.int_4 >> 16 & 255);
		}
		while (!(this.color_0.Name != "ff000000"));
	}

	// Token: 0x06000723 RID: 1827 RVA: 0x000220F0 File Offset: 0x000202F0
	private void method_40()
	{
		if (this.bool_2)
		{
			return;
		}
		this.bool_2 = true;
		this.timeSpan_0 = this.stopwatch_0.Elapsed;
		int clickCountLeft = this.ClickCountLeft;
		this.ClickCountLeft = clickCountLeft - 1;
		this.thread_1.Start();
	}

	// Token: 0x06000724 RID: 1828 RVA: 0x0002213C File Offset: 0x0002033C
	private void method_41()
	{
		while (this.bool_1)
		{
			this.int_4 = (int)Class715.GetPixel(this.intptr_1, this.int_2, this.int_3);
			this.color_0 = Color.FromArgb(255, this.int_4 & 255, this.int_4 >> 8 & 255, this.int_4 >> 16 & 255);
			if (this.color_0.Name == "ff000000")
			{
				this.bool_1 = false;
				this.method_13();
				this.method_16();
				return;
			}
		}
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x000221D4 File Offset: 0x000203D4
	private void method_42()
	{
		if (this.enum4_0 == (Class715.Enum4)0)
		{
			this.method_27();
		}
		if (this.enum4_0 == (Class715.Enum4)1)
		{
			this.method_28();
		}
		if (this.enum4_0 == (Class715.Enum4)2 || this.enum4_0 == (Class715.Enum4)1)
		{
			this.method_29();
		}
		this.method_8();
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x0002222C File Offset: 0x0002042C
	private void method_43(object object_0)
	{
		Class715.Struct32 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class715_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class715.Struct32>(ref @struct);
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x00022264 File Offset: 0x00020464
	private void method_44()
	{
		dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd = Class358.smethod_0().method_5(typeof(dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd)) as dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd;
		dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.bool_0 = false;
		dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.WindowState = WindowState.Normal;
		dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Width = 1072.0;
		dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Height = 754.0;
		dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.method_2();
		dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Topmost = true;
		dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.IsEnabled = false;
		dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.method_20(0.0);
		int num = Convert.ToInt32(dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.ActualWidth);
		int num2 = Convert.ToInt32(dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.ActualHeight);
		this.int_2 = num - 50;
		this.int_3 = num2 - 50;
		this.bitmap_0 = new Bitmap(1, 1);
		this.color_0 = Color.Black;
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x0002231C File Offset: 0x0002051C
	private Task method_45()
	{
		Class715.Struct41 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class715_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class715.Struct41>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x00022360 File Offset: 0x00020560
	private void method_46(object object_0)
	{
		Class715.Struct33 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class715_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class715.Struct33>(ref @struct);
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x00022398 File Offset: 0x00020598
	private void method_47(object object_0)
	{
		this.method_35();
		this.class728_0.method_4(this);
		this.Values.Clear();
		this.class728_0.Models.Remove(this);
		if (this.class728_0.Models.Count<Class715>() == 0)
		{
			this.class728_0.NewTestCommand.Execute(null);
			return;
		}
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x000223F8 File Offset: 0x000205F8
	private void method_48(object object_0)
	{
		this.method_34();
	}

	// Token: 0x04000358 RID: 856
	private Class728 class728_0;

	// Token: 0x04000359 RID: 857
	private dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0;

	// Token: 0x0400035A RID: 858
	private List<Class710> list_0;

	// Token: 0x0400035B RID: 859
	private Class710 class710_0;

	// Token: 0x0400035C RID: 860
	public bool bool_0;

	// Token: 0x0400035D RID: 861
	private string string_0;

	// Token: 0x0400035E RID: 862
	private string string_1;

	// Token: 0x0400035F RID: 863
	private DateTime dateTime_0 = DateTime.Now;

	// Token: 0x04000360 RID: 864
	private ObservableCollection<double> observableCollection_0 = new ObservableCollection<double>();

	// Token: 0x04000361 RID: 865
	private int int_0;

	// Token: 0x04000362 RID: 866
	private List<int> list_1;

	// Token: 0x04000363 RID: 867
	private int int_1;

	// Token: 0x04000364 RID: 868
	private string string_2 = Class364.smethod_0("FollowInGameRules");

	// Token: 0x04000365 RID: 869
	private string string_3 = Class364.smethod_0("ClickLMB");

	// Token: 0x04000366 RID: 870
	public Stopwatch stopwatch_0 = new Stopwatch();

	// Token: 0x04000367 RID: 871
	private Bitmap bitmap_0;

	// Token: 0x04000368 RID: 872
	private Color color_0;

	// Token: 0x04000369 RID: 873
	private Thread thread_0;

	// Token: 0x0400036A RID: 874
	private Thread thread_1;

	// Token: 0x0400036B RID: 875
	private bool bool_1;

	// Token: 0x0400036C RID: 876
	private bool bool_2;

	// Token: 0x0400036D RID: 877
	private int int_2;

	// Token: 0x0400036E RID: 878
	private int int_3;

	// Token: 0x0400036F RID: 879
	private TimeSpan timeSpan_0 = TimeSpan.Zero;

	// Token: 0x04000370 RID: 880
	private IntPtr intptr_0 = Process.GetCurrentProcess().MainWindowHandle;

	// Token: 0x04000371 RID: 881
	private IntPtr intptr_1 = Class715.GetWindowDC(Process.GetCurrentProcess().MainWindowHandle);

	// Token: 0x04000372 RID: 882
	private IntPtr intptr_2 = Class715.GetDC(IntPtr.Zero);

	// Token: 0x04000373 RID: 883
	private int int_4;

	// Token: 0x04000374 RID: 884
	private int int_5;

	// Token: 0x04000375 RID: 885
	private Process process_0;

	// Token: 0x04000376 RID: 886
	private CaptureProcess captureProcess_0;

	// Token: 0x04000377 RID: 887
	private bool bool_3;

	// Token: 0x04000378 RID: 888
	private int int_6;

	// Token: 0x04000379 RID: 889
	private int int_7;

	// Token: 0x0400037A RID: 890
	private Bitmap bitmap_1;

	// Token: 0x0400037B RID: 891
	private Class715.Enum4 enum4_0 = (Class715.Enum4)1;

	// Token: 0x0400037C RID: 892
	private Rectangle rectangle_0;

	// Token: 0x0400037D RID: 893
	private TimeSpan timeSpan_1 = new TimeSpan(0, 0, 0, 1);

	// Token: 0x0400037E RID: 894
	private static Class715.Delegate23 delegate23_0;

	// Token: 0x0400037F RID: 895
	private List<IOverlayElement> list_2 = new List<IOverlayElement>();

	// Token: 0x04000380 RID: 896
	private Overlay overlay_0 = new Overlay
	{
		Hidden = false
	};

	// Token: 0x04000381 RID: 897
	private ImageElement imageElement_0 = new ImageElement();

	// Token: 0x04000382 RID: 898
	private ImageElement imageElement_1 = new ImageElement();

	// Token: 0x04000383 RID: 899
	private System.Drawing.Point point_0 = new System.Drawing.Point(20, 20);

	// Token: 0x04000384 RID: 900
	private System.Drawing.Point point_1 = new System.Drawing.Point(20, 20);

	// Token: 0x04000385 RID: 901
	private static SemaphoreSlim semaphoreSlim_0 = new SemaphoreSlim(1, 1);

	// Token: 0x04000386 RID: 902
	private List<int> list_3 = new List<int>();

	// Token: 0x04000387 RID: 903
	private bool bool_4;

	// Token: 0x04000388 RID: 904
	private GClass134 gclass134_0;

	// Token: 0x04000389 RID: 905
	private GClass134 gclass134_1;

	// Token: 0x0400038A RID: 906
	private GClass134 gclass134_2;

	// Token: 0x0400038B RID: 907
	private double double_0 = 0.6;

	// Token: 0x020000EA RID: 234
	[StructLayout(LayoutKind.Auto)]
	private struct Struct29 : IAsyncStateMachine
	{
		// Token: 0x0600072C RID: 1836 RVA: 0x00022400 File Offset: 0x00020600
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class715 @object = this.class715_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(@object.method_45)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct29>(ref awaiter, ref this);
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

		// Token: 0x0600072D RID: 1837 RVA: 0x000224C0 File Offset: 0x000206C0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400038C RID: 908
		public int int_0;

		// Token: 0x0400038D RID: 909
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400038E RID: 910
		public Class715 class715_0;

		// Token: 0x0400038F RID: 911
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000EB RID: 235
	private sealed class Class140
	{
		// Token: 0x0600072F RID: 1839 RVA: 0x000224D8 File Offset: 0x000206D8
		internal double method_0(double double_1)
		{
			return Math.Pow(double_1 - this.double_0, 2.0);
		}

		// Token: 0x04000390 RID: 912
		public double double_0;
	}

	// Token: 0x020000EC RID: 236
	private sealed class Class141
	{
		// Token: 0x06000731 RID: 1841 RVA: 0x000224F8 File Offset: 0x000206F8
		internal bool method_0(string string_0)
		{
			return string_0 == this.process_0.ProcessName;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0002250C File Offset: 0x0002070C
		internal bool method_1(Process process_1)
		{
			return process_1.ProcessName == this.process_0.ProcessName;
		}

		// Token: 0x04000391 RID: 913
		public Process process_0;
	}

	// Token: 0x020000ED RID: 237
	[StructLayout(LayoutKind.Auto)]
	private struct Struct30 : IAsyncStateMachine
	{
		// Token: 0x06000733 RID: 1843 RVA: 0x00022524 File Offset: 0x00020724
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class715 @class = this.class715_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_AB;
				}
				if (num != 1)
				{
					awaiter = Class715.semaphoreSlim_0.WaitAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct30>(ref awaiter, ref this);
						return;
					}
					goto IL_AB;
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				IL_78:
				awaiter.GetResult();
				Class715.semaphoreSlim_0.Release();
				goto IL_11E;
				IL_AB:
				awaiter.GetResult();
				@class.captureProcess_0.CaptureInterface.DrawOverlayInGame(@class.overlay_0);
				awaiter = Task.Delay(100).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct30>(ref awaiter, ref this);
					return;
				}
				goto IL_78;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_11E:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00022674 File Offset: 0x00020874
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000392 RID: 914
		public int int_0;

		// Token: 0x04000393 RID: 915
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000394 RID: 916
		public Class715 class715_0;

		// Token: 0x04000395 RID: 917
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000EE RID: 238
	[StructLayout(LayoutKind.Auto)]
	private struct Struct31 : IAsyncStateMachine
	{
		// Token: 0x06000735 RID: 1845 RVA: 0x00022684 File Offset: 0x00020884
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(new Class715.Class144
					{
						rawKeyboard_0 = this.rawKeyboard_0,
						class715_0 = this.class715_0
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct31>(ref awaiter, ref this);
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

		// Token: 0x06000736 RID: 1846 RVA: 0x00022758 File Offset: 0x00020958
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000396 RID: 918
		public int int_0;

		// Token: 0x04000397 RID: 919
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000398 RID: 920
		public RawKeyboard rawKeyboard_0;

		// Token: 0x04000399 RID: 921
		public Class715 class715_0;

		// Token: 0x0400039A RID: 922
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000EF RID: 239
	[StructLayout(LayoutKind.Auto)]
	private struct Struct32 : IAsyncStateMachine
	{
		// Token: 0x06000737 RID: 1847 RVA: 0x00022768 File Offset: 0x00020968
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class715 @class = this.class715_0;
			try
			{
				TaskAwaiter awaiter;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_D3;
				case 1:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_199;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_20B;
				case 3:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_26D;
				default:
					if (@class.bool_4)
					{
						goto IL_3A3;
					}
					@class.bool_4 = true;
					@class.ClickCountLeft = @class.ClickCount;
					@class.stopwatch_0.Reset();
					@class.stopwatch_0.Start();
					Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
					@class.method_13();
					Application.Current.Dispatcher.Invoke(new Action(@class.method_44));
					if (!dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_5)
					{
						goto IL_110;
					}
					this.int_1 = 0;
					break;
				}
				IL_9E:
				if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_5)
				{
					goto IL_110;
				}
				if (this.int_1 > 2000)
				{
					goto IL_3A3;
				}
				awaiter = Task.Delay(100).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct32>(ref awaiter, ref this);
					return;
				}
				IL_D3:
				awaiter.GetResult();
				int num2 = this.int_1;
				this.int_1 = num2 + 1;
				goto IL_9E;
				IL_110:
				awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(@class.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0.grid_0).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct32>(ref awaiter, ref this);
					return;
				}
				IL_199:
				awaiter.GetResult();
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_20(@class.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0.grid_2);
				awaiter = Class358.smethod_0().method_6().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct32>(ref awaiter, ref this);
					return;
				}
				IL_20B:
				awaiter.GetResult();
				awaiter = Task.Delay(2000).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 3;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct32>(ref awaiter, ref this);
					return;
				}
				IL_26D:
				awaiter.GetResult();
				if (@class.ChoosenArea == @class.TestingAreas[0])
				{
					@class.ClickText1 = Class364.smethod_0("WaitPlease");
					Class631.smethod_4();
					Class631.smethod_2(new Class631.Delegate32(@class.method_31));
					Class631.smethod_0(new Class631.Delegate31(@class.method_20));
					Class631.smethod_0(new Class631.Delegate31(@class.method_12));
					@class.enum4_0 = (Class715.Enum4)2;
					Class715.smethod_0(new Class715.Delegate23(@class.method_20));
					Class715.smethod_0(new Class715.Delegate23(@class.method_12));
					Class715.Delegate23 delegate23_ = Class715.delegate23_0;
					if (delegate23_ != null)
					{
						delegate23_();
					}
				}
				else if (@class.ChoosenArea == @class.TestingAreas[1])
				{
					@class.ClickText1 = Class364.smethod_0("ClickLMB");
					Class631.smethod_4();
					Class631.smethod_2(new Class631.Delegate32(@class.method_31));
					Class631.smethod_0(new Class631.Delegate31(@class.method_20));
					Class631.smethod_0(new Class631.Delegate31(@class.method_12));
					@class.enum4_0 = (Class715.Enum4)2;
					Class631.smethod_4();
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_3A3:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00022B48 File Offset: 0x00020D48
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400039B RID: 923
		public int int_0;

		// Token: 0x0400039C RID: 924
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400039D RID: 925
		public Class715 class715_0;

		// Token: 0x0400039E RID: 926
		private int int_1;

		// Token: 0x0400039F RID: 927
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000F0 RID: 240
	[StructLayout(LayoutKind.Auto)]
	private struct Struct33 : IAsyncStateMachine
	{
		// Token: 0x06000739 RID: 1849 RVA: 0x00022B58 File Offset: 0x00020D58
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class715 @class = this.class715_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_C7;
				}
				if (num != 1)
				{
					@class.method_35();
					@class.Values.Clear();
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(@class.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0.grid_3).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct33>(ref awaiter, ref this);
						return;
					}
					goto IL_C7;
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				IL_8F:
				awaiter.GetResult();
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_20(@class.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0.grid_0);
				goto IL_12D;
				IL_C7:
				awaiter.GetResult();
				awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(@class.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0.grid_1).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct33>(ref awaiter, ref this);
					return;
				}
				goto IL_8F;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_12D:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00022CC4 File Offset: 0x00020EC4
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040003A0 RID: 928
		public int int_0;

		// Token: 0x040003A1 RID: 929
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040003A2 RID: 930
		public Class715 class715_0;

		// Token: 0x040003A3 RID: 931
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000F1 RID: 241
	private enum Enum4
	{

	}

	// Token: 0x020000F2 RID: 242
	[StructLayout(LayoutKind.Auto)]
	private struct Struct34 : IAsyncStateMachine
	{
		// Token: 0x0600073B RID: 1851 RVA: 0x00022CD4 File Offset: 0x00020ED4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class715 @class = this.class715_0;
			try
			{
				TaskAwaiter awaiter;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_DE;
				case 1:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_1B4;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_22E;
				default:
					foreach (Process process in this.process_0)
					{
						if (!(process.MainWindowHandle == IntPtr.Zero) && !HookManager.IsHooked(process.Id))
						{
							CaptureConfig captureConfig = new CaptureConfig
							{
								Direct3DVersion = 1,
								ShowOverlay = true
							};
							@class.int_5 = process.Id;
							@class.process_0 = process;
							CaptureInterface captureInterface = new CaptureInterface();
							@class.captureProcess_0 = new CaptureProcess(process, captureConfig, captureInterface);
							IL_B3:
							this.int_1 = 0;
							goto IL_BA;
						}
					}
					goto IL_B3;
				}
				IL_BA:
				if (@class.captureProcess_0 == null)
				{
					awaiter = Task.Delay(60).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct34>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = Task.Delay(3000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct34>(ref awaiter, ref this);
						return;
					}
					goto IL_1B4;
				}
				IL_DE:
				awaiter.GetResult();
				int i = this.int_1;
				this.int_1 = i + 1;
				if (i > 1000)
				{
					@class.CS2Status = Class364.smethod_0("unknownerror");
					goto IL_31C;
				}
				goto IL_BA;
				IL_1B4:
				awaiter.GetResult();
				@class.captureProcess_0.BringProcessWindowToFront();
				@class.captureProcess_0.CaptureInterface.BeginGetScreenshot(new Rectangle(0, 0, 0, 0), new TimeSpan(0, 0, 2000), new AsyncCallback(@class.method_24), null, 0);
				this.int_2 = 0;
				IL_20A:
				if (@class.bool_3)
				{
					@class.method_8();
					Class631.smethod_4();
					Class631.smethod_2(new Class631.Delegate32(@class.method_31));
					if (@class.ChoosenArea == @class.TestingAreas[1])
					{
						@class.enum4_0 = (Class715.Enum4)0;
						@class.method_27();
					}
					else
					{
						@class.enum4_0 = (Class715.Enum4)1;
						@class.method_28();
					}
					goto IL_31C;
				}
				awaiter = Task.Delay(20).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct34>(ref awaiter, ref this);
					return;
				}
				IL_22E:
				awaiter.GetResult();
				i = this.int_2;
				this.int_2 = i + 1;
				if (i <= 1000)
				{
					goto IL_20A;
				}
				@class.CS2Status = Class364.smethod_0("unknownerror");
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_31C:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0002302C File Offset: 0x0002122C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040003A5 RID: 933
		public int int_0;

		// Token: 0x040003A6 RID: 934
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040003A7 RID: 935
		public Process[] process_0;

		// Token: 0x040003A8 RID: 936
		public Class715 class715_0;

		// Token: 0x040003A9 RID: 937
		private int int_1;

		// Token: 0x040003AA RID: 938
		private int int_2;

		// Token: 0x040003AB RID: 939
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000F3 RID: 243
	[StructLayout(LayoutKind.Auto)]
	private struct Struct35 : IAsyncStateMachine
	{
		// Token: 0x0600073D RID: 1853 RVA: 0x0002303C File Offset: 0x0002123C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class715 @object = this.class715_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_41)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct35>(ref awaiter, ref this);
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

		// Token: 0x0600073E RID: 1854 RVA: 0x000230FC File Offset: 0x000212FC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040003AC RID: 940
		public int int_0;

		// Token: 0x040003AD RID: 941
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040003AE RID: 942
		public Class715 class715_0;

		// Token: 0x040003AF RID: 943
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000F4 RID: 244
	[StructLayout(LayoutKind.Auto)]
	private struct Struct36 : IAsyncStateMachine
	{
		// Token: 0x0600073F RID: 1855 RVA: 0x0002310C File Offset: 0x0002130C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class715 @class = this.class715_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					double totalMilliseconds = (@class.stopwatch_0.Elapsed - @class.timeSpan_0).TotalMilliseconds;
					@class.Values.Add(totalMilliseconds);
					int num2 = @class.ClickCountLeft - 1;
					@class.ClickCountLeft = num2;
					if (num2 <= 0)
					{
						@class.method_19();
						goto IL_FB;
					}
					awaiter = @class.method_17().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct36>(ref awaiter, ref this);
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
				Class715.Delegate23 delegate23_ = Class715.delegate23_0;
				if (delegate23_ != null)
				{
					delegate23_();
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_FB:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00023238 File Offset: 0x00021438
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040003B0 RID: 944
		public int int_0;

		// Token: 0x040003B1 RID: 945
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040003B2 RID: 946
		public Class715 class715_0;

		// Token: 0x040003B3 RID: 947
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000F5 RID: 245
	[StructLayout(LayoutKind.Auto)]
	private struct Struct37 : IAsyncStateMachine
	{
		// Token: 0x06000741 RID: 1857 RVA: 0x00023248 File Offset: 0x00021448
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class715 @class = this.class715_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_1D6;
				}
				if (num != 1)
				{
					@class.bool_4 = false;
					@class.bool_2 = false;
					@class.bool_1 = false;
					@class.method_13();
					Class631.smethod_3(new Class631.Delegate32(@class.method_31));
					Class631.smethod_5();
					Class631.smethod_1(new Class631.Delegate31(@class.method_20));
					Class631.smethod_1(new Class631.Delegate31(@class.method_21));
					Class715.smethod_1(new Class715.Delegate23(@class.method_20));
					Class715.smethod_1(new Class715.Delegate23(@class.method_12));
					Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.Normal;
					if (@class.ChoosenArea != @class.TestingAreas[0] && @class.ChoosenArea != @class.TestingAreas[1])
					{
						HookManager.RemoveHookedProcess(@class.captureProcess_0.Process.Id);
						@class.captureProcess_0.CaptureInterface.Disconnect();
						@class.captureProcess_0 = null;
						Class627.smethod_1();
					}
					else
					{
						Application.Current.Dispatcher.Invoke(new Action(Class715.Class142.class142_0.method_2));
					}
					@class.method_34();
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(@class.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0.grid_2).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct37>(ref awaiter, ref this);
						return;
					}
					goto IL_1D6;
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				IL_19E:
				awaiter.GetResult();
				dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_20(@class.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0.grid_3);
				goto IL_23C;
				IL_1D6:
				awaiter.GetResult();
				awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(@class.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0.grid_1).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct37>(ref awaiter, ref this);
					return;
				}
				goto IL_19E;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_23C:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000234C0 File Offset: 0x000216C0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040003B4 RID: 948
		public int int_0;

		// Token: 0x040003B5 RID: 949
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040003B6 RID: 950
		public Class715 class715_0;

		// Token: 0x040003B7 RID: 951
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000F6 RID: 246
	[Serializable]
	private sealed class Class142
	{
		// Token: 0x06000745 RID: 1861 RVA: 0x000234E4 File Offset: 0x000216E4
		internal bool method_0(Class715 class715_0)
		{
			return class715_0.IsChoosen;
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x000234EC File Offset: 0x000216EC
		internal double method_1(double double_0)
		{
			return double_0;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x000234F0 File Offset: 0x000216F0
		internal void method_2()
		{
			dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd = Class358.smethod_0().method_5(typeof(dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd)) as dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd;
			dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.Topmost = false;
			dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.IsEnabled = true;
			dje_z2P4FJNPVBF8EHKX26TVFDNCNG7DQ_ejd.method_21();
		}

		// Token: 0x040003B8 RID: 952
		public static readonly Class715.Class142 class142_0 = new Class715.Class142();

		// Token: 0x040003B9 RID: 953
		public static Func<Class715, bool> func_0;

		// Token: 0x040003BA RID: 954
		public static Func<double, double> func_1;

		// Token: 0x040003BB RID: 955
		public static Action action_0;
	}

	// Token: 0x020000F7 RID: 247
	[StructLayout(LayoutKind.Auto)]
	private struct Struct38 : IAsyncStateMachine
	{
		// Token: 0x06000748 RID: 1864 RVA: 0x00023520 File Offset: 0x00021720
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class715 @object = this.class715_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_40)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct38>(ref awaiter, ref this);
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

		// Token: 0x06000749 RID: 1865 RVA: 0x000235E0 File Offset: 0x000217E0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040003BC RID: 956
		public int int_0;

		// Token: 0x040003BD RID: 957
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040003BE RID: 958
		public Class715 class715_0;

		// Token: 0x040003BF RID: 959
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000F8 RID: 248
	[StructLayout(LayoutKind.Auto)]
	private struct Struct39 : IAsyncStateMachine
	{
		// Token: 0x0600074A RID: 1866 RVA: 0x000235F0 File Offset: 0x000217F0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class715 @object = this.class715_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(@object.method_38)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct39>(ref awaiter, ref this);
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

		// Token: 0x0600074B RID: 1867 RVA: 0x000236B8 File Offset: 0x000218B8
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040003C0 RID: 960
		public int int_0;

		// Token: 0x040003C1 RID: 961
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040003C2 RID: 962
		public Class715 class715_0;

		// Token: 0x040003C3 RID: 963
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000F9 RID: 249
	[StructLayout(LayoutKind.Auto)]
	private struct Struct40 : IAsyncStateMachine
	{
		// Token: 0x0600074C RID: 1868 RVA: 0x000236C8 File Offset: 0x000218C8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class715 @object = this.class715_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(@object.method_37)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct40>(ref awaiter, ref this);
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

		// Token: 0x0600074D RID: 1869 RVA: 0x00023790 File Offset: 0x00021990
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040003C4 RID: 964
		public int int_0;

		// Token: 0x040003C5 RID: 965
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040003C6 RID: 966
		public Class715 class715_0;

		// Token: 0x040003C7 RID: 967
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000FA RID: 250
	[StructLayout(LayoutKind.Auto)]
	private struct Struct41 : IAsyncStateMachine
	{
		// Token: 0x0600074E RID: 1870 RVA: 0x000237A0 File Offset: 0x000219A0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class715 @class = this.class715_0;
			try
			{
				if (num != 0)
				{
					goto IL_96;
				}
				TaskAwaiter awaiter = this.taskAwaiter_0;
				this.taskAwaiter_0 = default(TaskAwaiter);
				this.int_0 = -1;
				IL_8F:
				awaiter.GetResult();
				IL_96:
				Process[] processes = Process.GetProcesses();
				Process[] array = processes;
				for (int i = 0; i < array.Length; i++)
				{
					Class715.Class141 class2 = new Class715.Class141();
					class2.process_0 = array[i];
					if (Class605.list_0.Any(new Func<string, bool>(class2.method_0)))
					{
						@class.method_23(processes.Where(new Func<Process, bool>(class2.method_1)).ToArray<Process>());
						goto IL_109;
					}
				}
				awaiter = Task.Delay(1000).GetAwaiter();
				if (awaiter.IsCompleted)
				{
					goto IL_8F;
				}
				this.int_0 = 0;
				this.taskAwaiter_0 = awaiter;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct41>(ref awaiter, ref this);
				return;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_109:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000238DC File Offset: 0x00021ADC
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040003C8 RID: 968
		public int int_0;

		// Token: 0x040003C9 RID: 969
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040003CA RID: 970
		public Class715 class715_0;

		// Token: 0x040003CB RID: 971
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000FB RID: 251
	// (Invoke) Token: 0x06000751 RID: 1873
	public delegate void Delegate23();

	// Token: 0x020000FC RID: 252
	private sealed class Class143
	{
		// Token: 0x06000755 RID: 1877 RVA: 0x000238F4 File Offset: 0x00021AF4
		internal bool method_0(Class710 class710_0)
		{
			return class710_0.Name == this.class693_0.ChoosenArea;
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0002390C File Offset: 0x00021B0C
		internal bool method_1(Class710 class710_0)
		{
			return class710_0.Name == this.class693_0.ChoosenArea;
		}

		// Token: 0x040003CC RID: 972
		public Class693 class693_0;
	}

	// Token: 0x020000FD RID: 253
	private sealed class Class144
	{
		// Token: 0x06000758 RID: 1880 RVA: 0x0002392C File Offset: 0x00021B2C
		internal void method_0()
		{
			if ((this.rawKeyboard_0.Flags & 1) == null)
			{
				if (!this.class715_0.list_3.Contains(this.rawKeyboard_0.VirutalKey))
				{
					this.class715_0.list_3.Add(this.rawKeyboard_0.VirutalKey);
				}
			}
			else if (this.class715_0.list_3.Contains(this.rawKeyboard_0.VirutalKey))
			{
				this.class715_0.list_3.Remove(this.rawKeyboard_0.VirutalKey);
			}
			this.class715_0.method_32();
		}

		// Token: 0x040003CD RID: 973
		public RawKeyboard rawKeyboard_0;

		// Token: 0x040003CE RID: 974
		public Class715 class715_0;
	}

	// Token: 0x020000FE RID: 254
	[StructLayout(LayoutKind.Auto)]
	private struct Struct42 : IAsyncStateMachine
	{
		// Token: 0x06000759 RID: 1881 RVA: 0x000239C8 File Offset: 0x00021BC8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class715 @class = this.class715_0;
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
					goto IL_E3;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_145;
				default:
					awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(@class.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0.grid_3).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct42>(ref awaiter, ref this);
						return;
					}
					break;
				}
				awaiter.GetResult();
				awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(@class.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0.grid_0).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct42>(ref awaiter, ref this);
					return;
				}
				IL_E3:
				awaiter.GetResult();
				awaiter = dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_21(@class.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0.grid_2).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct42>(ref awaiter, ref this);
					return;
				}
				IL_145:
				awaiter.GetResult();
				if (@class.Values.Count<double>() > 0)
				{
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_20(@class.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0.grid_3);
				}
				else
				{
					dje_zAC4TX89ZVPCH88W4JWD8PJWRTHJ3DUZHMW_ejd.smethod_20(@class.dje_zUWR9UJ7MZQFZME75QB6A3KDJ9YETH3ACZVXE78X2ARX7D6N4LFRD56WEPJ24EPWB73_ejd_0.grid_0);
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

		// Token: 0x0600075A RID: 1882 RVA: 0x00023B9C File Offset: 0x00021D9C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040003CF RID: 975
		public int int_0;

		// Token: 0x040003D0 RID: 976
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040003D1 RID: 977
		public Class715 class715_0;

		// Token: 0x040003D2 RID: 978
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000FF RID: 255
	[StructLayout(LayoutKind.Auto)]
	private struct Struct43 : IAsyncStateMachine
	{
		// Token: 0x0600075B RID: 1883 RVA: 0x00023BAC File Offset: 0x00021DAC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class715 @object = this.class715_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_A7;
				}
				if (num != 1)
				{
					awaiter = Task.Run(new Action(@object.method_39)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct43>(ref awaiter, ref this);
						return;
					}
					goto IL_A7;
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				IL_7F:
				awaiter.GetResult();
				goto IL_104;
				IL_A7:
				awaiter.GetResult();
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class715.Struct43>(ref awaiter, ref this);
					return;
				}
				goto IL_7F;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_104:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00023CE0 File Offset: 0x00021EE0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040003D3 RID: 979
		public int int_0;

		// Token: 0x040003D4 RID: 980
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040003D5 RID: 981
		public Class715 class715_0;

		// Token: 0x040003D6 RID: 982
		private TaskAwaiter taskAwaiter_0;
	}
}
