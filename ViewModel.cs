using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BindingProblem
{
    public partial class ViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _sources;

        public ViewModel()
        {
            Sources = string.Empty;
        }

        public void Refresh()
        {
            Sources = Data.Sources;
        }

        [RelayCommand]
        Task NextPage()
        {
            Shell.Current.Navigation.PushModalAsync(new Page2());
            return Task.CompletedTask;
        }
    }
}
