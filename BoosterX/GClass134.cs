using System;
using System.Windows.Input;

// Token: 0x0200045D RID: 1117
public sealed class GClass134 : ICommand
{
	// Token: 0x060018C7 RID: 6343 RVA: 0x000669C8 File Offset: 0x00064BC8
	public GClass134(Action<object> action_1, Func<object, bool> func_1 = null)
	{
		this.action_0 = action_1;
		this.func_0 = func_1;
	}

	// Token: 0x060018C8 RID: 6344 RVA: 0x000669E0 File Offset: 0x00064BE0
	public GClass134()
	{
	}

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x060018C9 RID: 6345 RVA: 0x000669E8 File Offset: 0x00064BE8
	// (remove) Token: 0x060018CA RID: 6346 RVA: 0x000669F0 File Offset: 0x00064BF0
	public event EventHandler CanExecuteChanged
	{
		add
		{
			CommandManager.RequerySuggested += value;
		}
		remove
		{
			CommandManager.RequerySuggested -= value;
		}
	}

	// Token: 0x060018CB RID: 6347 RVA: 0x000669F8 File Offset: 0x00064BF8
	public bool CanExecute(object parameter)
	{
		return this.func_0 == null || this.func_0(parameter);
	}

	// Token: 0x060018CC RID: 6348 RVA: 0x00066A10 File Offset: 0x00064C10
	public void Execute(object parameter)
	{
		this.action_0(parameter);
	}

	// Token: 0x0400114C RID: 4428
	private readonly Action<object> action_0;

	// Token: 0x0400114D RID: 4429
	private readonly Func<object, bool> func_0;
}
