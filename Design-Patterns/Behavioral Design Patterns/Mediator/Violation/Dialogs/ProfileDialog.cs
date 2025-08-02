using Mediator.Violation.Components;
using Mediator.Violation.Repositories;

namespace Mediator.Violation.Dialogs;
public class ProfileDialog
{
    public TextBox NameTextBox { get; set; }
    public CheckBox HasPetCheckBox { get; set; }
    public TextBox? PetDescriptionTextBox { get; set; }
    public Button SaveButton { get; set; }

    public IList<string> Errors { get; set; } = new List<string>();

    public ProfileDialog()
    {
        NameTextBox = new TextBox("Enter your name"); 
        HasPetCheckBox = new CheckBox("Do you have a pet");
        SaveButton = new Button("Save")
        {
            // OnClick = Save
            OnClick = () =>
            {
                Profile profile = new Profile();
                Repository<Profile> repository = new Repository<Profile>();

                if (NameTextBox?.Value == null || string.IsNullOrEmpty(NameTextBox.Value))
                {
                    Errors?.Add("Name cannot be empty.");
                    return;
                }

                profile.Name = NameTextBox.Value;

                if (HasPetCheckBox == null && !string.IsNullOrEmpty(PetDescriptionTextBox?.Value))
                {
                    Errors?.Add("You must specify if you have a pet.");
                    return;
                }

                profile.PetDescription = PetDescriptionTextBox?.Value;

                repository.Add(profile);
                // Console.WriteLine($"Profile saved: {NameTextBox.Value}, Pet: {HasPetCheckBox?.IsChecked}, Description: {PetDescriptionTextBox?.Value}");
            }
        };
    }

    public void Show()
    {
        Console.WriteLine("=== Profile Form ===\n");

        NameTextBox.Render();
        NameTextBox.Event += (s, e) =>
        {
            //if (string.IsNullOrEmpty(NameTextBox.Value))
            //{
            //    Errors.Add("Name cannot be empty.");
            //}

            
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
