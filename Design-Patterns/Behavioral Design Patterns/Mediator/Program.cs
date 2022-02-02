using Mediator.Violation.Components;
using Mediator.Violation.Dialogs;
using Mediator.Violation.Forms;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("🔄 === Mediator Pattern Example ===\n");

var dialog = new ProfileDialog();
dialog.Show();

Console.WriteLine("Press any key to continue");
Console.ReadLine();

/** 
static void ViolationExample()
{
    // Create instances of the classes
    var dogCheckBox = new Mediator.Violation.DogCheckBox();
    var dogNameField = new Mediator.Violation.DogNameTextField();
    var submitButton = new Mediator.Violation.SubmitButton { DogNameField = dogNameField };
    // Simulate user interaction
    dogCheckBox.DogNameField = dogNameField;
    dogCheckBox.Toggle(); // Check the box, should show the text field
    dogNameField.Text = "Buddy"; // Set a name
    submitButton.Click(); // Submit with a valid name
    dogCheckBox.Toggle(); // Uncheck the box, should hide the text field
    submitButton.Click(); // Submit without a name, should not show an error
}

static void RefactoredExample()
{
    // Create an instance of the ProfileForm
    var profileForm = new Mediator.Refactored.ProfileForm();
    // Simulate user interaction
    profileForm.DogCheckBox.Toggle(); // Check the box, should show the text field
    profileForm.DogNameTextField.Text = "Buddy"; // Set a name
    profileForm.SubmitButton.Click(); // Submit with a valid name
    profileForm.DogCheckBox.Toggle(); // Uncheck the box, should hide the text field
    profileForm.SubmitButton.Click(); // Submit without a name, should not show an error
                                      // Display any errors
    if (profileForm.Errors.Count > 0)
    {
        Console.WriteLine("Errors:");
        foreach (var error in profileForm.Errors)
        {
            Console.WriteLine($"- {error}");
        }
    }
}
**/