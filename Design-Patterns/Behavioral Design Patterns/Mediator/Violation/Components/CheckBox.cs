using Mediator.Violation.Interfaces;
using System.Reflection.Emit;

namespace Mediator.Violation.Components;
public class CheckBox : BaseComponent<CheckboxEventArgs>
{
    public string Label { get; set; }
    public bool IsChecked { get; set; }

    public CheckBox(string label)
    {
        Label = label;
    }

    //public void Check()
    //{
    //    IsChecked = !IsChecked;
    //    OnEvent(new CheckboxEventArgs { IsChecked = IsChecked });
    //}

    public override void Render()
    {
        Console.Write($"{Label} (y/n): ");
        var input = Console.ReadLine()?.Trim().ToLower();
        IsChecked = input == "y" || input == "yes";
        OnEvent(new CheckboxEventArgs { IsChecked = IsChecked });
    }

    protected override void OnEvent(CheckboxEventArgs args)
    {
        RaiseEvent(args);
    }
}

public class CheckboxEventArgs : EventArgs 
{
    public bool? IsChecked { get; set; }
}
