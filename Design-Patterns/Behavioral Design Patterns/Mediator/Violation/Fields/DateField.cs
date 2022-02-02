namespace Mediator.Violation.Fields;
public class DateField : InputField<DateTime>
{
    public DateField(string label) : base(label) { }

    protected override bool TryParse(string? input, out DateTime result)
    {
        return DateTime.TryParse(input, out result);
    }
}

