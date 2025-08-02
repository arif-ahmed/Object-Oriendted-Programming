namespace Mediator.Refactored.Components;
public class TextBox : BaseComponent<TextBoxEventArgs>
{
    public string Label { get; set; } = default!;
    public string? Value { get; set; }

    public TextBox(IMediator mediator, string label) : base(mediator)
    {
        Label = label;
    }

    public override void Render()
    {
        Console.Write($"{Label}: ");
        Value = Console.ReadLine()?.Trim();
        OnEvent(new TextBoxEventArgs { Value = Value });
    }

    protected override void OnEvent(TextBoxEventArgs args)
    {
        RaiseEvent(args);
    }
}

public class TextBoxEventArgs : EventArgs 
{
    public string? Value { get; set; }
}
