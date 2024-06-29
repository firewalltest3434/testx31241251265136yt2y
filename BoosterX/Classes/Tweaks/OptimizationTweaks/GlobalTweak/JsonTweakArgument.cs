using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BoosterX.Classes.Tweaks.OptimizationTweaks.GlobalTweak
{
	// Token: 0x02000839 RID: 2105
	public class JsonTweakArgument : IEquatable<JsonTweakArgument>
	{
		// Token: 0x06002AE0 RID: 10976 RVA: 0x000B9F80 File Offset: 0x000B8180
		[CompilerGenerated]
		protected JsonTweakArgument([Attribute8(1)] JsonTweakArgument original)
		{
			this.string_0 = original.string_0;
			this.string_1 = original.string_1;
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x000B9FA0 File Offset: 0x000B81A0
		public JsonTweakArgument()
		{
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06002AE2 RID: 10978 RVA: 0x000B9FA8 File Offset: 0x000B81A8
		[Attribute8(1)]
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			[Attribute6(1)]
			get
			{
				return typeof(JsonTweakArgument);
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06002AE3 RID: 10979 RVA: 0x000B9FB4 File Offset: 0x000B81B4
		// (set) Token: 0x06002AE4 RID: 10980 RVA: 0x000B9FBC File Offset: 0x000B81BC
		public string NewTweakStatus
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06002AE5 RID: 10981 RVA: 0x000B9FC8 File Offset: 0x000B81C8
		// (set) Token: 0x06002AE6 RID: 10982 RVA: 0x000B9FD0 File Offset: 0x000B81D0
		public string CustomValue
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x000B9FDC File Offset: 0x000B81DC
		[Attribute6(1)]
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder("JsonTweakArgument");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x000BA024 File Offset: 0x000B8224
		[CompilerGenerated]
		[Attribute6(1)]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("NewTweakStatus = ");
			builder.Append(this.NewTweakStatus);
			builder.Append(", CustomValue = ");
			builder.Append(this.CustomValue);
			return true;
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x000BA060 File Offset: 0x000B8260
		[CompilerGenerated]
		[Attribute6(2)]
		public static bool operator !=(JsonTweakArgument left, JsonTweakArgument right)
		{
			return !(left == right);
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x000BA06C File Offset: 0x000B826C
		[Attribute6(2)]
		[CompilerGenerated]
		public static bool operator ==(JsonTweakArgument left, JsonTweakArgument right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x000BA088 File Offset: 0x000B8288
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.string_0)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.string_1);
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x000BA0C8 File Offset: 0x000B82C8
		[CompilerGenerated]
		[Attribute6(2)]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as JsonTweakArgument);
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x000BA0D8 File Offset: 0x000B82D8
		[CompilerGenerated]
		[Attribute6(2)]
		public virtual bool Equals(JsonTweakArgument other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(this.string_0, other.string_0) && EqualityComparer<string>.Default.Equals(this.string_1, other.string_1));
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x000BA140 File Offset: 0x000B8340
		[Attribute6(1)]
		[CompilerGenerated]
		public virtual JsonTweakArgument m000002()
		{
			return new JsonTweakArgument(this);
		}

		// Token: 0x040020FE RID: 8446
		private string string_0;

		// Token: 0x040020FF RID: 8447
		private string string_1;
	}
}
