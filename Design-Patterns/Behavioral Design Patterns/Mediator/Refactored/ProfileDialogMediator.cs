using Mediator.Refactored.Components;
using Mediator.Refactored.Dialogs;
using Mediator.Violation.Interfaces;
using Mediator.Violation.Repositories;

namespace Mediator.Refactored;
public class ProfileDialogMediator : IMediator
{
    public IList<IUIComponent<EventArgs>> Components { get; set; } = new List<IUIComponent<EventArgs>>();
    public IList<string> Errors { get; set; } = new List<string>();

    public void Notify(object sender, EventArgs args)
    {
        if(sender is Button button)
        {
            if (button.Label == "Save")
            {
                Profile profile = new Profile();
                Repository<Profile> repository = new Repository<Profile>();

                var nameToText = Components.FirstOrDefault(c => c is TextBox textBox && textBox.Label == "NameTextBox") as TextBox;



                if (nameToText?.Value == null || string.IsNullOrEmpty(nameToText.Value))
                {
                    Errors?.Add("Name cannot be empty.");
                    return;
                }

                //profile.Name = NameTextBox.Value;

                //if (HasPetCheckBox == null && !string.IsNullOrEmpty(PetDescriptionTextBox?.Value))
                //{
                //    Errors?.Add("You must specify if you have a pet.");
                //    return;
                //}

                //profile.PetDescription = PetDescriptionTextBox?.Value;

                //repository.Add(profile);

                // Handle save logic
                Console.WriteLine("Profile saved.");
            }
            else if (button.Label == "Cancel")
            {
                // Handle cancel logic
                Console.WriteLine("Profile changes canceled.");
            }
        }
        else if(sender is TextBox textBox)
        {
            // Handle text box input
            Console.WriteLine($"Input received: {textBox.Value}");
        }       
    }
}
