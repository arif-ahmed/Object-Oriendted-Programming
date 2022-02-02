namespace Mediator.Refactored;

public class SubmitButton
{
    private readonly IFormMediator _mediator;

    public bool Enabled { get; set; } = true;

    public SubmitButton(IFormMediator mediator)
    {
        _mediator = mediator;
    }
    public void Click()
    {
        _mediator.Notify(this, "SubmitButtonClicked");
    }
}
