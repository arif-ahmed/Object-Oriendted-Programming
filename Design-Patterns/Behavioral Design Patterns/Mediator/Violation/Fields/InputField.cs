namespace Mediator.Violation.Fields;
public abstract class InputField<T>
{
    public string Label { get; set; }
    public T? Value { get; protected set; }

    public InputField(string label)
    {
        Label = label;
    }

    public void Render()
    {
        while (true)
        {
            Console.Write($"{Label}: ");
            string? input = Console.ReadLine();

            if (TryParse(input, out T? result))
            {
                Value = result;
                break;
            }

            Console.WriteLine($"Invalid input for {typeof(T).Name}. Try again.");
        }
    }

    protected abstract bool TryParse(string? input, out T? result);
}

