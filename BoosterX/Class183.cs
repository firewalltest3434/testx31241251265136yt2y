using System;
using System.Collections.Generic;
using System.Windows.Media;
using ns0;

// Token: 0x02000158 RID: 344
internal sealed class Class183
{
	// Token: 0x060008FF RID: 2303 RVA: 0x000296F4 File Offset: 0x000278F4
	public static List<Class724> smethod_0()
	{
		List<Class724> list = new List<Class724>
		{
			new Class724
			{
				Name = "QVisuals",
				Grad1 = (Color)ColorConverter.ConvertFromString("#231463"),
				Grad2 = (Color)ColorConverter.ConvertFromString("#48359B"),
				Grad3 = (Color)ColorConverter.ConvertFromString("#6E58D5"),
				MainButton = "IDontCare",
				RedButton = "ICare",
				Image = "/Resources/Images/Questions/Visuals.png"
			},
			new Class724
			{
				Name = "QUpdates",
				Grad1 = (Color)ColorConverter.ConvertFromString("#531463"),
				Grad2 = (Color)ColorConverter.ConvertFromString("#62359B"),
				Grad3 = (Color)ColorConverter.ConvertFromString("#7958D5"),
				MainButton = "dodisable",
				RedButton = "Dont",
				Image = "/Resources/Images/Questions/Update.png"
			},
			new Class724
			{
				Name = "QBluetooth",
				Grad1 = (Color)ColorConverter.ConvertFromString("#141C63"),
				Grad2 = (Color)ColorConverter.ConvertFromString("#35399B"),
				Grad3 = (Color)ColorConverter.ConvertFromString("#5874D5"),
				MainButton = "NotUsing",
				RedButton = "IUse",
				Image = "/Resources/Images/Questions/Bluetooth.png"
			},
			new Class724
			{
				Name = "QAlttab",
				Grad1 = (Color)ColorConverter.ConvertFromString("#231463"),
				Grad2 = (Color)ColorConverter.ConvertFromString("#48359B"),
				Grad3 = (Color)ColorConverter.ConvertFromString("#6E58D5"),
				MainButton = "IDontMind",
				RedButton = "IDoMind",
				Image = "/Resources/Images/Questions/AltTab.png"
			},
			new Class724
			{
				Name = "QXBOX",
				Grad1 = (Color)ColorConverter.ConvertFromString("#531463"),
				Grad2 = (Color)ColorConverter.ConvertFromString("#62359B"),
				Grad3 = (Color)ColorConverter.ConvertFromString("#7958D5"),
				MainButton = "IDontPlay",
				RedButton = "IDoPlay",
				Image = "/Resources/Images/Questions/XBOX.png"
			},
			new Class724
			{
				Name = "QGameBar",
				Grad1 = (Color)ColorConverter.ConvertFromString("#141C63"),
				Grad2 = (Color)ColorConverter.ConvertFromString("#35399B"),
				Grad3 = (Color)ColorConverter.ConvertFromString("#5874D5"),
				MainButton = "no",
				RedButton = "yes",
				Image = "/Resources/Images/Questions/GameBar.png"
			},
			new Class724
			{
				Name = "QPrinter",
				Grad1 = (Color)ColorConverter.ConvertFromString("#231463"),
				Grad2 = (Color)ColorConverter.ConvertFromString("#48359B"),
				Grad3 = (Color)ColorConverter.ConvertFromString("#6E58D5"),
				MainButton = "NotUsing",
				RedButton = "IUse",
				Image = "/Resources/Images/Questions/Printer.png"
			},
			new Class724
			{
				Name = "QDefender",
				Grad1 = (Color)ColorConverter.ConvertFromString("#531463"),
				Grad2 = (Color)ColorConverter.ConvertFromString("#62359B"),
				Grad3 = (Color)ColorConverter.ConvertFromString("#7958D5"),
				MainButton = "DoStop",
				RedButton = "Dont",
				Image = "/Resources/Images/Questions/Defender.png"
			}
		};
		if (dje_zYUCSSLBZ9FAZZHRHHNXXLGQN4TTA_ejd.bool_3)
		{
			list.Add(new Class724
			{
				Name = "QNvidia",
				Grad1 = (Color)ColorConverter.ConvertFromString("#141C63"),
				Grad2 = (Color)ColorConverter.ConvertFromString("#35399B"),
				Grad3 = (Color)ColorConverter.ConvertFromString("#5874D5"),
				MainButton = "DoSetUp",
				RedButton = "Dont",
				Image = "/Resources/Images/Questions/Nvidia.png"
			});
		}
		list.Add(new Class724
		{
			Name = "QFinal",
			Grad1 = (Color)ColorConverter.ConvertFromString("#231463"),
			Grad2 = (Color)ColorConverter.ConvertFromString("#48359B"),
			Grad3 = (Color)ColorConverter.ConvertFromString("#6E58D5"),
			MainButton = "apply",
			RedButton = string.Empty,
			Image = "/Resources/Images/Questions/Final.png"
		});
		return list;
	}
}
