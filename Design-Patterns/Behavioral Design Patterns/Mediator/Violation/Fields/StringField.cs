namespace Mediator.Violation.Fields;
public class StringField : InputField<string>
{
    public StringField(string label) : base(label) { }

    protected override bool TryParse(string? input, out string? result)
    {
        result = input?.Trim();
        return !string.IsNullOrEmpty(result);
    }
}

