using DEINT_DataBindingDemo.Model;

namespace DEINT_DataBindingDemo;

public partial class MainPage : ContentPage
{

    Person person;

    public MainPage()
	{
		InitializeComponent();

        person = new Person
        {
            Nombre = "Manuel Jesus",
            Direccion = "Larga",
            Edad = 3
        };

        BindingContext = person;

    }

	private void Button_Clicked(object sender, EventArgs e)
	{

        //person = new Person
        //{
        //	Nombre = "Pepe",
        //	Direccion = "Ancha",
        //	Edad = 26
        //};

        //NombreTxt.BindingContext = person;
        //NombreTxt.SetBinding(Label.TextProperty, "Nombre");

        //Enlace de la clase con todos los componentes
        //BindingContext = person;

        person.Nombre = "Pepe";
        person.Direccion = "Ancha";
        person.Edad = 26;
    }

}

