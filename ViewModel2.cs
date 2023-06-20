using CommunityToolkit.Mvvm.Input;

namespace BindingProblem
{
    public partial class ViewModel2
    {
        [RelayCommand]
        async Task UpdateAndClose()
        {
            Data.Sources = "A value is here!";
            await Shell.Current.Navigation.PopModalAsync();
        } 
    }
}
