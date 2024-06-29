using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;

// Token: 0x02000300 RID: 768
public sealed class GClass89
{
	// Token: 0x06001161 RID: 4449 RVA: 0x000496BC File Offset: 0x000478BC
	public GClass89(string string_5)
	{
		this.String_0 = string_5;
	}

	// Token: 0x06001162 RID: 4450 RVA: 0x000496D8 File Offset: 0x000478D8
	public GClass89()
	{
	}

	// Token: 0x17000210 RID: 528
	// (get) Token: 0x06001164 RID: 4452 RVA: 0x00049718 File Offset: 0x00047918
	// (set) Token: 0x06001165 RID: 4453 RVA: 0x00049720 File Offset: 0x00047920
	[JsonProperty("id")]
	public string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x17000211 RID: 529
	// (get) Token: 0x06001166 RID: 4454 RVA: 0x0004972C File Offset: 0x0004792C
	// (set) Token: 0x06001167 RID: 4455 RVA: 0x00049734 File Offset: 0x00047934
	[JsonProperty("owned_by")]
	public string String_1
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x17000212 RID: 530
	// (get) Token: 0x06001168 RID: 4456 RVA: 0x00049740 File Offset: 0x00047940
	// (set) Token: 0x06001169 RID: 4457 RVA: 0x00049748 File Offset: 0x00047948
	[JsonProperty("object")]
	public string String_2
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x17000213 RID: 531
	// (get) Token: 0x0600116A RID: 4458 RVA: 0x00049754 File Offset: 0x00047954
	[JsonIgnore]
	public DateTime? Nullable_0
	{
		get
		{
			if (this.Nullable_1 == null)
			{
				return null;
			}
			return new DateTime?(DateTimeOffset.FromUnixTimeSeconds(this.Nullable_1.Value).DateTime);
		}
	}

	// Token: 0x17000214 RID: 532
	// (get) Token: 0x0600116B RID: 4459 RVA: 0x0004979C File Offset: 0x0004799C
	// (set) Token: 0x0600116C RID: 4460 RVA: 0x000497A4 File Offset: 0x000479A4
	[JsonProperty("created")]
	public long? Nullable_1
	{
		get
		{
			return this.nullable_0;
		}
		set
		{
			this.nullable_0 = value;
		}
	}

	// Token: 0x17000215 RID: 533
	// (get) Token: 0x0600116D RID: 4461 RVA: 0x000497B0 File Offset: 0x000479B0
	// (set) Token: 0x0600116E RID: 4462 RVA: 0x000497B8 File Offset: 0x000479B8
	[JsonProperty("permission")]
	public List<GClass142> List_0
	{
		get
		{
			return this.list_0;
		}
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x17000216 RID: 534
	// (get) Token: 0x0600116F RID: 4463 RVA: 0x000497C4 File Offset: 0x000479C4
	// (set) Token: 0x06001170 RID: 4464 RVA: 0x000497CC File Offset: 0x000479CC
	[JsonProperty("root")]
	public string String_3
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x17000217 RID: 535
	// (get) Token: 0x06001171 RID: 4465 RVA: 0x000497D8 File Offset: 0x000479D8
	// (set) Token: 0x06001172 RID: 4466 RVA: 0x000497E0 File Offset: 0x000479E0
	[JsonProperty("parent")]
	public string String_4
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x06001173 RID: 4467 RVA: 0x000497EC File Offset: 0x000479EC
	public static implicit operator string(GClass89 gclass89_4)
	{
		if (gclass89_4 == null)
		{
			return null;
		}
		return gclass89_4.String_0;
	}

	// Token: 0x06001174 RID: 4468 RVA: 0x000497FC File Offset: 0x000479FC
	public static implicit operator GClass89(string string_5)
	{
		return new GClass89(string_5);
	}

	// Token: 0x06001175 RID: 4469 RVA: 0x00049804 File Offset: 0x00047A04
	public static GClass89 smethod_0()
	{
		return GClass89.gclass89_0;
	}

	// Token: 0x06001176 RID: 4470 RVA: 0x0004980C File Offset: 0x00047A0C
	public static void smethod_1(GClass89 gclass89_4)
	{
		GClass89.gclass89_0 = gclass89_4;
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x00049814 File Offset: 0x00047A14
	public static GClass89 smethod_2()
	{
		return GClass89.gclass89_1;
	}

	// Token: 0x06001178 RID: 4472 RVA: 0x0004981C File Offset: 0x00047A1C
	public static void smethod_3(GClass89 gclass89_4)
	{
		GClass89.gclass89_1 = gclass89_4;
	}

	// Token: 0x06001179 RID: 4473 RVA: 0x00049824 File Offset: 0x00047A24
	public static GClass89 smethod_4()
	{
		return GClass89.gclass89_2;
	}

	// Token: 0x0600117A RID: 4474 RVA: 0x0004982C File Offset: 0x00047A2C
	public static void smethod_5(GClass89 gclass89_4)
	{
		GClass89.gclass89_2 = gclass89_4;
	}

	// Token: 0x0600117B RID: 4475 RVA: 0x00049834 File Offset: 0x00047A34
	public static GClass89 smethod_6()
	{
		return GClass89.gclass89_3;
	}

	// Token: 0x0600117C RID: 4476 RVA: 0x0004983C File Offset: 0x00047A3C
	public static void smethod_7(GClass89 gclass89_4)
	{
		GClass89.gclass89_3 = gclass89_4;
	}

	// Token: 0x0600117D RID: 4477 RVA: 0x00049844 File Offset: 0x00047A44
	public Task<GClass89> method_0(GClass178 gclass178_0)
	{
		GClass89.Struct158 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass89>.Create();
		@struct.gclass89_0 = this;
		@struct.gclass178_0 = gclass178_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass89.Struct158>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600117E RID: 4478 RVA: 0x00049890 File Offset: 0x00047A90
	public static GClass89 smethod_8()
	{
		return new GClass89("gpt-4")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x0600117F RID: 4479 RVA: 0x000498A8 File Offset: 0x00047AA8
	public static GClass89 smethod_9()
	{
		return new GClass89("gpt-4-32k")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06001180 RID: 4480 RVA: 0x000498C0 File Offset: 0x00047AC0
	public static GClass89 smethod_10()
	{
		return new GClass89("gpt-4-vision-preview")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06001181 RID: 4481 RVA: 0x000498D8 File Offset: 0x00047AD8
	public static GClass89 smethod_11()
	{
		return new GClass89("gpt-4-1106-preview")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06001182 RID: 4482 RVA: 0x000498F0 File Offset: 0x00047AF0
	public static GClass89 smethod_12()
	{
		return new GClass89("gpt-4-0125-preview")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06001183 RID: 4483 RVA: 0x00049908 File Offset: 0x00047B08
	public static GClass89 smethod_13()
	{
		return new GClass89("gpt-3.5-turbo")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06001184 RID: 4484 RVA: 0x00049920 File Offset: 0x00047B20
	public static GClass89 smethod_14()
	{
		return new GClass89("gpt-3.5-turbo-1106")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06001185 RID: 4485 RVA: 0x00049938 File Offset: 0x00047B38
	public static GClass89 smethod_15()
	{
		return new GClass89("gpt-3.5-turbo-16k")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06001186 RID: 4486 RVA: 0x00049950 File Offset: 0x00047B50
	public static GClass89 smethod_16()
	{
		return new GClass89("gpt-3.5-turbo-instruct")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06001187 RID: 4487 RVA: 0x00049968 File Offset: 0x00047B68
	public static GClass89 smethod_17()
	{
		return new GClass89("babbage-002")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06001188 RID: 4488 RVA: 0x00049980 File Offset: 0x00047B80
	public static GClass89 smethod_18()
	{
		return new GClass89("davinci-002")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06001189 RID: 4489 RVA: 0x00049998 File Offset: 0x00047B98
	public static GClass89 smethod_19()
	{
		return new GClass89("text-ada-001")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x0600118A RID: 4490 RVA: 0x000499B0 File Offset: 0x00047BB0
	public static GClass89 smethod_20()
	{
		return new GClass89("text-babbage-001")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x0600118B RID: 4491 RVA: 0x000499C8 File Offset: 0x00047BC8
	public static GClass89 smethod_21()
	{
		return new GClass89("text-curie-001")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x0600118C RID: 4492 RVA: 0x000499E0 File Offset: 0x00047BE0
	public static GClass89 smethod_22()
	{
		return new GClass89("text-davinci-003")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x0600118D RID: 4493 RVA: 0x000499F8 File Offset: 0x00047BF8
	public static GClass89 smethod_23()
	{
		return new GClass89("code-cushman-001")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x0600118E RID: 4494 RVA: 0x00049A10 File Offset: 0x00047C10
	public static GClass89 smethod_24()
	{
		return new GClass89("code-davinci-002")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x00049A28 File Offset: 0x00047C28
	public static GClass89 smethod_25()
	{
		return new GClass89("text-embedding-ada-002")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06001190 RID: 4496 RVA: 0x00049A40 File Offset: 0x00047C40
	public static GClass89 smethod_26()
	{
		return new GClass89("text-moderation-stable")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06001191 RID: 4497 RVA: 0x00049A58 File Offset: 0x00047C58
	public static GClass89 smethod_27()
	{
		return new GClass89("text-moderation-latest")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06001192 RID: 4498 RVA: 0x00049A70 File Offset: 0x00047C70
	public static GClass89 smethod_28()
	{
		return new GClass89("dall-e-2")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06001193 RID: 4499 RVA: 0x00049A88 File Offset: 0x00047C88
	public static GClass89 smethod_29()
	{
		return new GClass89("dall-e-3")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06001194 RID: 4500 RVA: 0x00049AA0 File Offset: 0x00047CA0
	public static GClass89 smethod_30()
	{
		return new GClass89("tts-1")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x00049AB8 File Offset: 0x00047CB8
	public static GClass89 smethod_31()
	{
		return new GClass89("tts-1-hd")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x00049AD0 File Offset: 0x00047CD0
	public static GClass89 smethod_32()
	{
		return new GClass89("whisper-1")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x04000A96 RID: 2710
	private string string_0;

	// Token: 0x04000A97 RID: 2711
	private string string_1;

	// Token: 0x04000A98 RID: 2712
	private string string_2;

	// Token: 0x04000A99 RID: 2713
	private long? nullable_0;

	// Token: 0x04000A9A RID: 2714
	private List<GClass142> list_0 = new List<GClass142>();

	// Token: 0x04000A9B RID: 2715
	private string string_3;

	// Token: 0x04000A9C RID: 2716
	private string string_4;

	// Token: 0x04000A9D RID: 2717
	private static GClass89 gclass89_0 = GClass89.smethod_16();

	// Token: 0x04000A9E RID: 2718
	private static GClass89 gclass89_1 = GClass89.smethod_13();

	// Token: 0x04000A9F RID: 2719
	private static GClass89 gclass89_2 = GClass89.smethod_30();

	// Token: 0x04000AA0 RID: 2720
	private static GClass89 gclass89_3 = GClass89.smethod_32();

	// Token: 0x02000301 RID: 769
	[StructLayout(LayoutKind.Auto)]
	private struct Struct158 : IAsyncStateMachine
	{
		// Token: 0x06001197 RID: 4503 RVA: 0x00049AE8 File Offset: 0x00047CE8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass89 gclass = this.gclass89_0;
			GClass89 result;
			try
			{
				TaskAwaiter<GClass89> awaiter;
				if (num != 0)
				{
					awaiter = this.gclass178_0.Models.imethod_0(gclass.String_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass89>, GClass89.Struct158>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass89>);
					this.int_0 = -1;
				}
				result = awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00049BB0 File Offset: 0x00047DB0
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000AA1 RID: 2721
		public int int_0;

		// Token: 0x04000AA2 RID: 2722
		public AsyncTaskMethodBuilder<GClass89> asyncTaskMethodBuilder_0;

		// Token: 0x04000AA3 RID: 2723
		public GClass178 gclass178_0;

		// Token: 0x04000AA4 RID: 2724
		public GClass89 gclass89_0;

		// Token: 0x04000AA5 RID: 2725
		private TaskAwaiter<GClass89> taskAwaiter_0;
	}
}
