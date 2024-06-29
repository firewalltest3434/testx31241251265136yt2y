using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000678 RID: 1656
public class GClass211 : INotifyPropertyChanged
{
	// Token: 0x14000006 RID: 6
	// (add) Token: 0x06002394 RID: 9108 RVA: 0x0008D800 File Offset: 0x0008BA00
	// (remove) Token: 0x06002395 RID: 9109 RVA: 0x0008D838 File Offset: 0x0008BA38
	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
			}
			while (propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
			}
			while (propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	// Token: 0x06002396 RID: 9110 RVA: 0x0008D870 File Offset: 0x0008BA70
	protected void method_0([CallerMemberName] string string_0)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
		if (propertyChangedEventHandler == null)
		{
			return;
		}
		propertyChangedEventHandler(this, new PropertyChangedEventArgs(string_0));
	}

	// Token: 0x0400183A RID: 6202
	private PropertyChangedEventHandler propertyChangedEventHandler_0;
}
