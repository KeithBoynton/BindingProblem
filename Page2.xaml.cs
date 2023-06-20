namespace BindingProblem;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();

		BindingContext = new ViewModel2();
	}
}