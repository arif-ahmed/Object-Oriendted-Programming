namespace Mediator.Refactored;

public class ProfileForm : IFormMediator
{
    public readonly DogCheckBox DogCheckBox;
    public readonly DogNameTextField DogNameTextField;
    public readonly SubmitButton SubmitButton;

    private bool _isFormValid;

    public IList<string> Errors { get; } = new List<string>();


    public ProfileForm()
    {
        DogCheckBox = new DogCheckBox(this);
        DogNameTextField = new DogNameTextField(this);
        SubmitButton = new SubmitButton(this);
    }

    public void Notify(object sender, string eventCode)
    {
        if(sender is DogCheckBox && eventCode == "DogCheckBoxToggled")
        {
            if (DogCheckBox.IsChecked)
            {
                DogNameTextField.Visible = true;
            }
        }

        if (sender is SubmitButton && eventCode == "SubmitButtonClicked")
        {
            if (DogCheckBox.IsChecked && string.IsNullOrEmpty(DogNameTextField.Text))
            {
                Errors.Add("Dog name is required when dog checkbox is checked.");
            }
            else 
            {
                _isFormValid = false;
                DogCheckBox.IsChecked = false;
                DogNameTextField.Text = string.Empty;   
            }
        }
    }
}
