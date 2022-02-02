using Mediator.Violation.Fields;

namespace Mediator.Violation.Forms;

public class ProfileForm
{
    private StringField Name = new("Enter your name");
    private BooleanField HasPet = new("Do you have a pet (y/n)");
    private StringField PetDescription = new("Describe your pet");

    public void Show()
    {
        Console.WriteLine("=== Profile Form ===\n");

        Name.Render();
        HasPet.Render();

        if (HasPet.Value == true)
            PetDescription.Render();

        Console.WriteLine("\n=== Summary ===");
        Console.WriteLine($"Name: {Name.Value}");
        Console.WriteLine($"Has Pet: {(HasPet.Value == true ? "Yes" : "No")}");

        if (HasPet.Value == true)
            Console.WriteLine($"Pet Description: {PetDescription.Value}");
    }
}

