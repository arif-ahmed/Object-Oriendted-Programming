namespace Mediator.Refactored.Components;

public class Button : BaseComponent<ButtonEventArgs>
{
    public string Label { get; set; }
    public Action? OnClick { get; set; }

    public Button(IMediator mediator, string label) : base(mediator)
    {
        Label = label;
    }

    public void Click()
    {
        OnEvent(new ButtonEventArgs());
    }

    public override void Render()
    {
        Console.WriteLine($"\nPress ENTER to {Label}...");
        Console.ReadLine();
        OnClick?.Invoke();
    }

    protected override void OnEvent(ButtonEventArgs args)
    {
        RaiseEvent(args);
    }
}

public class ButtonEventArgs : EventArgs
{

}
