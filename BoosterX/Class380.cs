using System;
using DiscordRPC;
using DiscordRPC.Logging;

// Token: 0x0200032C RID: 812
internal sealed class Class380
{
	// Token: 0x06001271 RID: 4721 RVA: 0x0004C64C File Offset: 0x0004A84C
	public static void smethod_0()
	{
		Class380.discordRpcClient_0 = new DiscordRpcClient("1146177568672850101");
		Class380.discordRpcClient_0.Logger = new ConsoleLogger
		{
			Level = 3
		};
		Class380.discordRpcClient_0.Initialize();
		Class380.discordRpcClient_0.SetPresence(new RichPresence
		{
			State = Class364.smethod_0("BoostingFPS"),
			Assets = new Assets
			{
				LargeImageKey = "logox"
			},
			Timestamps = new Timestamps(DateTime.UtcNow),
			Buttons = new Button[]
			{
				new Button
				{
					Label = Class364.smethod_0("download"),
					Url = "https://boosterx.org/"
				},
				new Button
				{
					Label = "Discord Server",
					Url = "https://discord.gg/ios1ph"
				}
			}
		});
	}

	// Token: 0x06001272 RID: 4722 RVA: 0x0004C720 File Offset: 0x0004A920
	public static void smethod_1()
	{
		Class380.discordRpcClient_0.Dispose();
	}

	// Token: 0x04000B57 RID: 2903
	public static DiscordRpcClient discordRpcClient_0;
}
