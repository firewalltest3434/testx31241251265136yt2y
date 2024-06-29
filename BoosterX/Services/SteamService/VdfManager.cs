using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Gameloop.Vdf;
using Gameloop.Vdf.Linq;
using Microsoft.CSharp.RuntimeBinder;

namespace BoosterX.Services.SteamService
{
	// Token: 0x02000841 RID: 2113
	public class VdfManager
	{
		// Token: 0x06002B06 RID: 11014 RVA: 0x000BA60C File Offset: 0x000B880C
		public VdfManager(string filePath)
		{
			this.string_0 = filePath;
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06002B07 RID: 11015 RVA: 0x000BA61C File Offset: 0x000B881C
		public string GetFilePath
		{
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x000BA624 File Offset: 0x000B8824
		public VdfManager Read()
		{
			VdfSerializerSettings vdfSerializerSettings = new VdfSerializerSettings
			{
				UsesEscapeSequences = true,
				UsesConditionals = true,
				MaximumTokenSize = 8192
			};
			string text = File.ReadAllText(this.string_0);
			this.vproperty_0 = VdfConvert.Deserialize(text, vdfSerializerSettings);
			return this;
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x000BA66C File Offset: 0x000B886C
		public VToken GetVTokenByPath(List<string> path)
		{
			VToken vtoken = null;
			if (path.Count < 1)
			{
				return this.vproperty_0;
			}
			if (path == null)
			{
				throw new ArgumentException("argument count must be more than 0");
			}
			foreach (string text in path)
			{
				if (vtoken == null)
				{
					vtoken = this.vproperty_0.Value[text];
				}
				else
				{
					vtoken = vtoken[text];
				}
				if (vtoken == null)
				{
					return null;
				}
			}
			return vtoken;
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x000BA700 File Offset: 0x000B8900
		public string GetValueByPath(List<string> path, string key)
		{
			if (path.Count < 1)
			{
				VToken vtokenByPath = this.GetVTokenByPath(new List<string>
				{
					key
				});
				if (vtokenByPath == null)
				{
					return null;
				}
				return vtokenByPath.ToString();
			}
			else
			{
				VToken vtokenByPath2 = this.GetVTokenByPath(path);
				if (vtokenByPath2 == null)
				{
					return null;
				}
				return vtokenByPath2.Value<string>(key);
			}
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x000BA73C File Offset: 0x000B893C
		public VdfManager SetValueByPath(List<string> path, string key, string value)
		{
			if (path.Count < 1)
			{
				object vtokenByPath = this.GetVTokenByPath(path);
				if (VdfManager.Class865.callSite_1 == null)
				{
					VdfManager.Class865.callSite_1 = CallSite<Func<CallSite, object, string, VValue, object>>.Create(Binder.SetIndex(CSharpBinderFlags.None, typeof(VdfManager), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, string, VValue, object> target = VdfManager.Class865.callSite_1.Target;
				CallSite callSite_ = VdfManager.Class865.callSite_1;
				if (VdfManager.Class865.callSite_0 == null)
				{
					VdfManager.Class865.callSite_0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.ResultIndexed, "Value", typeof(VdfManager), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				target(callSite_, VdfManager.Class865.callSite_0.Target(VdfManager.Class865.callSite_0, vtokenByPath), key, new VValue(value));
			}
			else
			{
				object vtokenByPath = this.GetVTokenByPath(path);
				if (VdfManager.Class865.callSite_2 == null)
				{
					VdfManager.Class865.callSite_2 = CallSite<Func<CallSite, object, string, VValue, object>>.Create(Binder.SetIndex(CSharpBinderFlags.None, typeof(VdfManager), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				VdfManager.Class865.callSite_2.Target(VdfManager.Class865.callSite_2, vtokenByPath, key, new VValue(value));
			}
			return this;
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x000BA87C File Offset: 0x000B8A7C
		public void Write()
		{
			File.WriteAllText(this.string_0, VdfConvert.Serialize(this.vproperty_0));
		}

		// Token: 0x0400210A RID: 8458
		private readonly string string_0;

		// Token: 0x0400210B RID: 8459
		private VProperty vproperty_0;

		// Token: 0x02000842 RID: 2114
		private static class Class865
		{
			// Token: 0x0400210C RID: 8460
			public static CallSite<Func<CallSite, object, object>> callSite_0;

			// Token: 0x0400210D RID: 8461
			public static CallSite<Func<CallSite, object, string, VValue, object>> callSite_1;

			// Token: 0x0400210E RID: 8462
			public static CallSite<Func<CallSite, object, string, VValue, object>> callSite_2;
		}
	}
}
