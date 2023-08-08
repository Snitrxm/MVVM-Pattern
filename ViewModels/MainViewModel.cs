using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM_Pattern.Models;
using System.Collections.ObjectModel;

namespace MVVM_Pattern.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public User? user;

        [ObservableProperty]
        public ObservableCollection<User>? usersDataGrip;

        public MainViewModel()
        {
            ShowUsers();
        }


        [RelayCommand]
        private void ShowUsers()
        {
            var usersList = new User().GetUsers();
            UsersDataGrip = new ObservableCollection<User>(usersList);
        }
    }
}
