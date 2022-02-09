namespace BugTrackerUI.Pages;

using Microsoft.AspNetCore.Components;

public partial class NewBug
{
    [Inject]
    public IBugService BugService { get; set; }
    [Inject]
    public NavigationManager NavService { get; set; }
    public Bug AddBug { get; set; } = new ();

    protected void HandleValidSubmit()
    {
        BugService.AddBug(AddBug);
    }

}
