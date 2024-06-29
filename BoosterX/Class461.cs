using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

// Token: 0x020003EF RID: 1007
internal sealed class Class461
{
	// Token: 0x060015FA RID: 5626 RVA: 0x0005C544 File Offset: 0x0005A744
	public static IPAddress smethod_0()
	{
		foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up)
			{
				foreach (GatewayIPAddressInformation gatewayIPAddressInformation in networkInterface.GetIPProperties().GatewayAddresses)
				{
					if (gatewayIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
					{
						return gatewayIPAddressInformation.Address;
					}
				}
			}
		}
		return null;
	}
}
