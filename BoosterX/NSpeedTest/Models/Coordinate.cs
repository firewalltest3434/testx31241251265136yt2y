using System;
using System.Runtime.CompilerServices;

namespace NSpeedTest.Models
{
	// Token: 0x02000844 RID: 2116
	public sealed class Coordinate
	{
		// Token: 0x06002B0D RID: 11021 RVA: 0x000BA894 File Offset: 0x000B8A94
		public Coordinate(double double_2, double double_3)
		{
			this.Latitude = double_2;
			this.Longitude = double_3;
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06002B0E RID: 11022 RVA: 0x000BA8AC File Offset: 0x000B8AAC
		// (set) Token: 0x06002B0F RID: 11023 RVA: 0x000BA8B4 File Offset: 0x000B8AB4
		public double Latitude
		{
			[CompilerGenerated]
			get
			{
				return this.double_0;
			}
			[CompilerGenerated]
			private set
			{
				this.double_0 = value;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06002B10 RID: 11024 RVA: 0x000BA8C0 File Offset: 0x000B8AC0
		// (set) Token: 0x06002B11 RID: 11025 RVA: 0x000BA8C8 File Offset: 0x000B8AC8
		public double Longitude
		{
			[CompilerGenerated]
			get
			{
				return this.double_1;
			}
			[CompilerGenerated]
			private set
			{
				this.double_1 = value;
			}
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x000BA8D4 File Offset: 0x000B8AD4
		public double method_0(Coordinate coordinate_0)
		{
			if (double.IsNaN(this.Latitude) || double.IsNaN(this.Longitude) || double.IsNaN(coordinate_0.Latitude) || double.IsNaN(coordinate_0.Longitude))
			{
				throw new ArgumentException("Argument latitude or longitude is not a number");
			}
			double num = this.Latitude * 0.017453292519943295;
			double num2 = this.Longitude * 0.017453292519943295;
			double num3 = coordinate_0.Latitude * 0.017453292519943295;
			double num4 = coordinate_0.Longitude * 0.017453292519943295 - num2;
			double num5 = Math.Pow(Math.Sin((num3 - num) / 2.0), 2.0) + Math.Cos(num) * Math.Cos(num3) * Math.Pow(Math.Sin(num4 / 2.0), 2.0);
			return 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(num5), Math.Sqrt(1.0 - num5)));
		}

		// Token: 0x04002113 RID: 8467
		private double double_0;

		// Token: 0x04002114 RID: 8468
		private double double_1;
	}
}
