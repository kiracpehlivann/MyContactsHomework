using MyContacts.Model;

namespace MyContacts.Views;



[QueryProperty(nameof(id), "id")]
public partial class EditContactPage : ContentPage
{
    ContactsRepository repository = new ContactsRepository();

    public string id { get; set; }
	public EditContactPage()
	{
        
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        var contact = repository.GetContact(Int32.Parse(id));
        if (contact != null) 
        {
            NameEntry.Text = contact.NameSurname;
            PhoneEntry.Text = contact.PhoneNumber;
            EmailEntry.Text = contact.Email;
            selectedContact.Text = id + " " + contact.NameSurname;
        }
    }

   private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        var updatedContact = new ContactInfo
        {
            Id = Int32.Parse(id),
            NameSurname = NameEntry.Text,
            PhoneNumber = PhoneEntry.Text,
            Email = EmailEntry.Text
        }
        await repository.UpdateContact(updatedContact);
        await Shell.Current.GoToAsync