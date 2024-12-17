using Microsoft.Maui.ApplicationModel.Communication;
using MyContacts.Model;

namespace MyContacts.Views;

public partial class ContactsPage : ContentPage
{
    

    public ContactsPage()
    {
		InitializeComponent();

        
    }
ContactsRepository contactsRepository = new ContactsRepository();
    protected async override  void OnAppearing()
    {
        base.OnAppearing();
        
        
        ContactsList.ItemsSource = await contactsRepository.GetContacts(); ;
    }
    private void AddContactButton_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(AddContactPage));
    }

    private void ContactsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var selectedContact = e.SelectedItem as ContactInfo;
        if(selectedContact != null) {
            Shell.Current.GoToAsync(nameof(EditContactPage)+"?id="+selectedContact.Id);

        }
    }
}