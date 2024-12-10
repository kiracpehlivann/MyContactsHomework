using MyContacts.Model;

namespace MyContacts.Views;

public partial class AddContactPage : ContentPage
{
	public AddContactPage()
	{
		InitializeComponent();


    }

    private void BackButton_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        ContactInfo contact = new ContactInfo();
    
        contact.NameSurname = NameEntry.Text;
        contact.PhoneNumber = PhoneEntry.Text;
        contact.Email = EmailEntry.Text;

        ContactsRepository repository = new ContactsRepository();
        repository.AddContact(contact);
        Shell.Current.GoToAsync("..");

    }
}