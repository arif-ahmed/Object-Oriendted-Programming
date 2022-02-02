namespace Mediator.Violation.Fields;
public class BooleanField : InputField<bool>
{
    public BooleanField(string label) : base(label) { }

    protected override bool TryParse(string? input, out bool result)
    {
        result = input?.ToLower() switch
        {
            "y" or "yes" => true,
            "n" or "no" => false,
            _ => false
        };
        return input == "y" || input == "yes" || input == "n" || input == "no";
    }
}
