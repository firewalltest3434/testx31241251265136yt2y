using System;
using System.Threading;

// Token: 0x0200023E RID: 574
internal sealed class Class294
{
	// Token: 0x06000D9F RID: 3487 RVA: 0x0003C228 File Offset: 0x0003A428
	public static void smethod_0(Class294.Delegate26 delegate26_1)
	{
		Class294.Delegate26 @delegate = Class294.delegate26_0;
		Class294.Delegate26 delegate2;
		do
		{
			delegate2 = @delegate;
			Class294.Delegate26 value = (Class294.Delegate26)Delegate.Combine(delegate2, delegate26_1);
			@delegate = Interlocked.CompareExchange<Class294.Delegate26>(ref Class294.delegate26_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06000DA0 RID: 3488 RVA: 0x0003C25C File Offset: 0x0003A45C
	public static void smethod_1(Class294.Delegate26 delegate26_1)
	{
		Class294.Delegate26 @delegate = Class294.delegate26_0;
		Class294.Delegate26 delegate2;
		do
		{
			delegate2 = @delegate;
			Class294.Delegate26 value = (Class294.Delegate26)Delegate.Remove(delegate2, delegate26_1);
			@delegate = Interlocked.CompareExchange<Class294.Delegate26>(ref Class294.delegate26_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06000DA1 RID: 3489 RVA: 0x0003C290 File Offset: 0x0003A490
	public static void smethod_2()
	{
		Class294.Delegate26 @delegate = Class294.delegate26_0;
		if (@delegate == null)
		{
			return;
		}
		@delegate();
	}

	// Token: 0x06000DA2 RID: 3490 RVA: 0x0003C2A4 File Offset: 0x0003A4A4
	public static void smethod_3(Class738 class738_0)
	{
		Class185.smethod_22(string.Concat(new string[]
		{
			"Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Games\\",
			class738_0.Name,
			"\" /v \"ExeName\" /t REG_SZ /d \"",
			class738_0.ExeName,
			"\" /f"
		}));
		Class185.smethod_22(string.Concat(new string[]
		{
			"Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Games\\",
			class738_0.Name,
			"\" /v \"GamePath\" /t REG_SZ /d \"",
			class738_0.ExeDir,
			"\" /f"
		}));
		Class185.smethod_22(string.Concat(new string[]
		{
			"Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Games\\",
			class738_0.Name,
			"\" /v \"FoundIn\" /t REG_SZ /d \"",
			class738_0.FoundIn,
			"\" /f"
		}));
		Class185.smethod_22("Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Games\\" + class738_0.Name + "\" /v \"Affinity\" /t REG_SZ /d \"\" /f");
		Class185.smethod_22("Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Games\\" + class738_0.Name + "\" /v \"DisableDWM\" /t REG_SZ /d \"False\" /f");
		Class185.smethod_22("Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Games\\" + class738_0.Name + "\" /v \"DisableExplorer\" /t REG_SZ /d \"False\" /f");
		Class185.smethod_22("Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Games\\" + class738_0.Name + "\" /v \"UseGlobalProfile\" /t REG_SZ /d \"True\" /f");
		Class185.smethod_22("Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Games\\" + class738_0.Name + "\" /v \"ThreadCompatibility\" /t REG_SZ /d \"False\" /f");
		Class185.smethod_22("Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Games\\" + class738_0.Name + "\" /v \"LaunchDelay\" /t REG_SZ /d \"0\" /f");
	}

	// Token: 0x06000DA3 RID: 3491 RVA: 0x0003C3FC File Offset: 0x0003A5FC
	public static void smethod_4(Class742 class742_0)
	{
		Class185.smethod_22("Reg.exe delete \"HKCU\\SOFTWARE\\GameModeX\\Games\\" + class742_0.Name + "\" /f");
	}

	// Token: 0x06000DA4 RID: 3492 RVA: 0x0003C418 File Offset: 0x0003A618
	public static void smethod_5(Class735 class735_0)
	{
		Class185.smethod_22(string.Concat(new string[]
		{
			"Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Apps\\",
			class735_0.Name,
			"\" /v \"ExeName\" /t REG_SZ /d \"",
			class735_0.ExeName,
			"\" /f"
		}));
		Class185.smethod_22(string.Concat(new string[]
		{
			"Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Apps\\",
			class735_0.Name,
			"\" /v \"ExeDir\" /t REG_SZ /d \"",
			class735_0.ExeDir,
			"\" /f"
		}));
	}

	// Token: 0x06000DA5 RID: 3493 RVA: 0x0003C49C File Offset: 0x0003A69C
	public static void smethod_6(Class747 class747_0)
	{
		Class185.smethod_22("Reg.exe delete \"HKCU\\SOFTWARE\\GameModeX\\Apps\\" + class747_0.Name + "\" /f");
	}

	// Token: 0x0400086A RID: 2154
	private static Class294.Delegate26 delegate26_0;

	// Token: 0x0200023F RID: 575
	// (Invoke) Token: 0x06000DA7 RID: 3495
	public delegate void Delegate26();
}
