using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x020005F4 RID: 1524
public sealed class GClass186
{
	// Token: 0x06002114 RID: 8468 RVA: 0x000862C8 File Offset: 0x000844C8
	public GClass186(string string_2)
	{
		this.method_1(string_2);
	}

	// Token: 0x06002115 RID: 8469 RVA: 0x000862D8 File Offset: 0x000844D8
	public GClass186(string string_2, string string_3)
	{
		this.method_1(string_2);
		this.method_3(string_3);
	}

	// Token: 0x06002116 RID: 8470 RVA: 0x000862F0 File Offset: 0x000844F0
	public string method_0()
	{
		return this.string_0;
	}

	// Token: 0x06002117 RID: 8471 RVA: 0x000862F8 File Offset: 0x000844F8
	public void method_1(string string_2)
	{
		this.string_0 = string_2;
	}

	// Token: 0x06002118 RID: 8472 RVA: 0x00086304 File Offset: 0x00084504
	public string method_2()
	{
		return this.string_1;
	}

	// Token: 0x06002119 RID: 8473 RVA: 0x0008630C File Offset: 0x0008450C
	public void method_3(string string_2)
	{
		this.string_1 = string_2;
	}

	// Token: 0x0600211A RID: 8474 RVA: 0x00086318 File Offset: 0x00084518
	public static implicit operator GClass186(string string_2)
	{
		return new GClass186(string_2);
	}

	// Token: 0x0600211B RID: 8475 RVA: 0x00086320 File Offset: 0x00084520
	public static GClass186 smethod_0()
	{
		if (GClass186.gclass186_0 != null)
		{
			return GClass186.gclass186_0;
		}
		GClass186 gclass = GClass186.smethod_2();
		if (gclass == null)
		{
			gclass = GClass186.smethod_3(null, ".openai", true);
		}
		if (gclass == null)
		{
			gclass = GClass186.smethod_3(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".openai", true);
		}
		GClass186.gclass186_0 = gclass;
		return gclass;
	}

	// Token: 0x0600211C RID: 8476 RVA: 0x00086370 File Offset: 0x00084570
	public static void smethod_1(GClass186 gclass186_1)
	{
		GClass186.gclass186_0 = gclass186_1;
	}

	// Token: 0x0600211D RID: 8477 RVA: 0x00086378 File Offset: 0x00084578
	public static GClass186 smethod_2()
	{
		string environmentVariable = Environment.GetEnvironmentVariable("OPENAI_KEY");
		if (string.IsNullOrEmpty(environmentVariable))
		{
			environmentVariable = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
			if (string.IsNullOrEmpty(environmentVariable))
			{
				return null;
			}
		}
		string environmentVariable2 = Environment.GetEnvironmentVariable("OPENAI_ORGANIZATION");
		return new GClass186(environmentVariable, environmentVariable2);
	}

	// Token: 0x0600211E RID: 8478 RVA: 0x000863C8 File Offset: 0x000845C8
	public static GClass186 smethod_3(string string_2, string string_3, bool bool_0)
	{
		if (string_2 == null)
		{
			string_2 = Environment.CurrentDirectory;
		}
		string text = null;
		string string_4 = null;
		DirectoryInfo directoryInfo = new DirectoryInfo(string_2);
		while (text == null && directoryInfo.Parent != null)
		{
			if (File.Exists(Path.Combine(directoryInfo.FullName, string_3)))
			{
				string[] array = File.ReadAllLines(Path.Combine(directoryInfo.FullName, string_3));
				for (int i = 0; i < array.Length; i++)
				{
					string[] array2 = array[i].Split(new char[]
					{
						'=',
						':'
					});
					if (array2.Length == 2)
					{
						string a = array2[0].ToUpper();
						if (!(a == "OPENAI_KEY"))
						{
							if (!(a == "OPENAI_API_KEY"))
							{
								if (a == "OPENAI_ORGANIZATION")
								{
									string_4 = array2[1].Trim();
								}
							}
							else
							{
								text = array2[1].Trim();
							}
						}
						else
						{
							text = array2[1].Trim();
						}
					}
				}
			}
			if (!bool_0)
			{
				break;
			}
			directoryInfo = directoryInfo.Parent;
		}
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		return new GClass186(text, string_4);
	}

	// Token: 0x0600211F RID: 8479 RVA: 0x000864F0 File Offset: 0x000846F0
	public Task<bool> method_4()
	{
		GClass186.Struct355 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		@struct.gclass186_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass186.Struct355>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x040016CD RID: 5837
	private string string_0;

	// Token: 0x040016CE RID: 5838
	private string string_1;

	// Token: 0x040016CF RID: 5839
	private static GClass186 gclass186_0;

	// Token: 0x020005F5 RID: 1525
	[StructLayout(LayoutKind.Auto)]
	private struct Struct355 : IAsyncStateMachine
	{
		// Token: 0x06002120 RID: 8480 RVA: 0x00086534 File Offset: 0x00084734
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass186 gclass = this.gclass186_0;
			bool result;
			try
			{
				GClass178 gclass2;
				if (num != 0)
				{
					if (string.IsNullOrEmpty(gclass.method_0()))
					{
						result = false;
						goto IL_D8;
					}
					gclass2 = new GClass178(gclass);
				}
				List<GClass89> result2;
				try
				{
					TaskAwaiter<List<GClass89>> awaiter;
					if (num != 0)
					{
						awaiter = gclass2.Models.imethod_2().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<GClass89>>, GClass186.Struct355>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<GClass89>>);
						this.int_0 = -1;
					}
					result2 = awaiter.GetResult();
				}
				catch (Exception)
				{
					result = false;
					goto IL_D8;
				}
				result = (result2.Count > 0);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_D8:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x0008664C File Offset: 0x0008484C
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040016D0 RID: 5840
		public int int_0;

		// Token: 0x040016D1 RID: 5841
		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		// Token: 0x040016D2 RID: 5842
		public GClass186 gclass186_0;

		// Token: 0x040016D3 RID: 5843
		private TaskAwaiter<List<GClass89>> taskAwaiter_0;
	}
}
