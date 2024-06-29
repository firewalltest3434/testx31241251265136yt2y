using System;
using System.Collections.Generic;

// Token: 0x0200004D RID: 77
internal sealed class Class35
{
	// Token: 0x060002E8 RID: 744 RVA: 0x00011AD4 File Offset: 0x0000FCD4
	internal Class24 method_0(Class12 class12_0)
	{
		if (class12_0 == null)
		{
			throw new ArgumentNullException();
		}
		object obj = this.object_0;
		Class24 result;
		lock (obj)
		{
			if (this.dictionary_0 == null)
			{
				this.dictionary_0 = new Dictionary<Class12, Class24>();
			}
			Class24 @class;
			if (!this.dictionary_0.TryGetValue(class12_0, out @class))
			{
				@class = new Class24(class12_0);
				this.dictionary_0[class12_0] = @class;
			}
			result = @class;
		}
		return result;
	}

	// Token: 0x0400008A RID: 138
	private object object_0 = new object();

	// Token: 0x0400008B RID: 139
	private Dictionary<Class12, Class24> dictionary_0;
}
