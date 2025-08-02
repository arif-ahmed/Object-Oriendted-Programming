namespace Mediator.Refactored.Components;
public class CheckBox : BaseComponent<CheckboxEventArgs>
{
    public string Label { get; set; }
    public bool IsChecked { get; set; }

    public CheckBox(IMediator mediator, string label) : base(mediator)
    {
        Label = label;
    }

    public override void Render()
    {
        Console.Write($"{Label} (y/n): ");
        var input = Console.ReadLine()?.Trim().ToLower();
        IsChecked = input == "y" || input == "yes";
        OnEvent(new CheckboxEventArgs { IsChecked = IsChecked });
    }

    protected override void OnEvent(CheckboxEventArgs args)
    {
        RaiseEvent(args);
    }
}

public class CheckboxEventArgs : EventArgs 
{
    public bool? IsChecked { get; set; }
}
