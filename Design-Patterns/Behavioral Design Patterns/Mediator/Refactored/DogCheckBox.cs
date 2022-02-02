namespace Mediator.Refactored;
public class DogCheckBox
{
    private readonly IFormMediator _mediator;

    public bool IsChecked { get; set; }

    public DogCheckBox(IFormMediator mediator)
    {
        _mediator = mediator;
    }

    public void Toggle()
    {
        IsChecked = !IsChecked;
        _mediator.Notify(this, "DogCheckBoxToggled");

        Console.WriteLine($"[Checkbox] IsChecked: {IsChecked}");
    }
}
