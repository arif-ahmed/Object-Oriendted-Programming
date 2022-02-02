namespace Mediator.Violation.Fields;
public class DecimalField : InputField<decimal>
{
    public DecimalField(string label) : base(label) { }

    protected override bool TryParse(string? input, out decimal result)
    {
        return decimal.TryParse(input, out result) && result > 0;
    }
}

