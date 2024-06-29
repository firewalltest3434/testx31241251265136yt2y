using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using ns0;

namespace BoosterX.Classes.Tweaks.Expert.ServicesTweak
{
	// Token: 0x02000838 RID: 2104
	public class ServicesTweak : GClass131
	{
		// Token: 0x06002AD4 RID: 10964 RVA: 0x000B9BEC File Offset: 0x000B7DEC
		public ServicesTweak(GClass97 winService)
		{
			this.gclass97_0 = winService;
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x000B9BFC File Offset: 0x000B7DFC
		public string ServiceName
		{
			get
			{
				return this.gclass97_0.ServiceName;
			}
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x000B9C0C File Offset: 0x000B7E0C
		protected override void RunFunction(object argument)
		{
			this.TweakArgument = argument.ToString();
			base.imethod_1(string.Concat(new string[]
			{
				Class364.smethod_0("Changing"),
				" ",
				Class364.smethod_0("Service"),
				" ",
				this.ServiceName
			}), (GEnum93)1);
			if (this.NewStartMode != null)
			{
				string text = GClass188.smethod_3(this.NewStartMode);
				if (this.ServiceName.ToLower() == "rdyboost" && text == "4")
				{
					dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_3.Add("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Class\\{71a27cdd-812a-11d0-bec7-08002be2092f}\" /v \"LowerFilters\" /t REG_MULTI_SZ /d \"fvevol\\0iorate\" /f");
				}
				if (this.ServiceName.ToLower() == "rdyboost" && (text == "0" || text == "1" || text == "2" || text == "3"))
				{
					dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_3.Add("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Class\\{71a27cdd-812a-11d0-bec7-08002be2092f}\" /v \"LowerFilters\" /t REG_MULTI_SZ /d \"fvevol\\0iorate\\0rdyboost\" /f");
				}
				if (this.ServiceName.ToLower() == "KeyIso")
				{
					dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_3.Add("net accounts /maxpwage:unlimited");
				}
				if (this.ServiceName.Contains(Class468.smethod_0().method_0()))
				{
					string text2 = this.ServiceName.Split(new char[]
					{
						'_'
					})[0];
					dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_3.Add(string.Concat(new string[]
					{
						"reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\",
						text2,
						"\" /v \"Start\" /t REG_DWORD /d \"",
						text,
						"\" /f"
					}));
				}
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_3.Add(string.Concat(new string[]
				{
					"reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\",
					this.ServiceName,
					"\" /v \"Start\" /t REG_DWORD /d \"",
					text,
					"\" /f"
				}));
			}
			if (this.method_10() != null)
			{
				string text3 = GClass188.smethod_6(this.method_10());
				dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.list_3.Add(string.Concat(new string[]
				{
					"sc ",
					text3,
					" ",
					this.ServiceName,
					" /y"
				}));
			}
		}

		// Token: 0x170005DF RID: 1503
		// (set) Token: 0x06002AD7 RID: 10967 RVA: 0x000B9E34 File Offset: 0x000B8034
		public string TweakArgument
		{
			set
			{
				if (value != null)
				{
					this.method_7(value.Split(new char[]
					{
						'|'
					}).ElementAtOrDefault(0) ?? string.Empty);
					this.method_9(value.Split(new char[]
					{
						'|'
					}).ElementAtOrDefault(1) ?? string.Empty);
				}
			}
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x000B9E90 File Offset: 0x000B8090
		private string method_6()
		{
			if (this.NewStartMode == null)
			{
				return null;
			}
			ServiceStartMode? serviceStartMode;
			return serviceStartMode.GetValueOrDefault().ToString();
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x000B9EC4 File Offset: 0x000B80C4
		private void method_7(string string_1)
		{
			ServiceStartMode value;
			this.NewStartMode = (Enum.TryParse<ServiceStartMode>(string_1, out value) ? new ServiceStartMode?(value) : null);
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06002ADA RID: 10970 RVA: 0x000B9EF4 File Offset: 0x000B80F4
		// (set) Token: 0x06002ADB RID: 10971 RVA: 0x000B9EFC File Offset: 0x000B80FC
		public ServiceStartMode? NewStartMode
		{
			[CompilerGenerated]
			get
			{
				return this.nullable_0;
			}
			[CompilerGenerated]
			set
			{
				this.nullable_0 = value;
			}
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x000B9F08 File Offset: 0x000B8108
		private string method_8()
		{
			if (this.method_10() == null)
			{
				return null;
			}
			ServiceControllerStatus? serviceControllerStatus;
			return serviceControllerStatus.GetValueOrDefault().ToString();
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x000B9F3C File Offset: 0x000B813C
		private void method_9(string string_1)
		{
			ServiceControllerStatus value;
			this.method_11(Enum.TryParse<ServiceControllerStatus>(string_1, out value) ? new ServiceControllerStatus?(value) : null);
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x000B9F6C File Offset: 0x000B816C
		private ServiceControllerStatus? method_10()
		{
			return this.nullable_1;
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x000B9F74 File Offset: 0x000B8174
		private void method_11(ServiceControllerStatus? nullable_2)
		{
			this.nullable_1 = nullable_2;
		}

		// Token: 0x040020FB RID: 8443
		private GClass97 gclass97_0;

		// Token: 0x040020FC RID: 8444
		private ServiceStartMode? nullable_0;

		// Token: 0x040020FD RID: 8445
		private ServiceControllerStatus? nullable_1;
	}
}
