using DEINT_DataBindingDemo.Pages;
using BindingMode = DEINT_DataBindingDemo.Pages.BindingMode;

namespace DEINT_DataBindingDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new BindingMode();
	}
}
