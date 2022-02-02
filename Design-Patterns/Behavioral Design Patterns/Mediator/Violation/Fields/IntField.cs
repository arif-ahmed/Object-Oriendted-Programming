namespace Mediator.Violation.Fields;
public class IntField : InputField<int>
{
    public IntField(string label) : base(label) { }

    protected override bool TryParse(string? input, out int result)
    {
        return int.TryParse(input, out result) && result > 0;
    }
}

