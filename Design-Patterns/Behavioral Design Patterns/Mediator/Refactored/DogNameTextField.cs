namespace Mediator.Refactored;
public class DogNameTextField
{
    private readonly IFormMediator _mediator;

    public bool Visible { get; set; }
    public string Text { get; set; } = default!;

    public DogNameTextField(IFormMediator mediator)
    {
        _mediator = mediator;
    }
}
