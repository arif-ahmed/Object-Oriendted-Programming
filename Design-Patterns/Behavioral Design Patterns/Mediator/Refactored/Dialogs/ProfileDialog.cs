using Mediator.Violation.Components;
using Mediator.Violation.Repositories;

namespace Mediator.Refactored.Dialogs;
public class ProfileDialog
{
    public Components.TextBox NameTextBox { get; set; }
    public CheckBox HasPetCheckBox { get; set; }
    public TextBox? PetDescriptionTextBox { get; set; }
    public Components.Button SaveButton { get; set; }

    public IList<string> Errors { get; set; } = new List<string>();

    public IMediator Mediator { get; set; } = new ProfileDialogMediator();

    public ProfileDialog()
    {
        NameTextBox = new Components.TextBox(Mediator, "Enter your name"); 
        HasPetCheckBox = new CheckBox("Do you have a pet");
        SaveButton = new Components.Button(Mediator, "Save")
        {
            OnClick = () =>
            {
                Mediator.Notify(SaveButton!, new ButtonEventArgs());
            }
        };
    }

    public void Show()
    {
        Console.WriteLine("=== Profile Form ===\n");

        NameTextBox.Render();
        NameTextBox.Event += (s, e) =>
        {
            Mediator.Notify(s!, e);
        };

        HasPetCheckBox.Render();

        if (HasPetCheckBox.IsChecked) 
        {
            PetDescriptionTextBox = new TextBox("Describe your pet");
            PetDescriptionTextBox.Render();
        }

        SaveButton.Render();

        if (Errors.Count > 0)
        {
            Console.WriteLine("\n⚠️  Errors:");
            foreach (var err in Errors)
                Console.WriteLine($" - {err}");
        }
    }
}
