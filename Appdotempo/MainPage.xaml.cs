namespace Appdotempo;

public partial class MainPage : ContentPage
{

	Results results = new Results();
	

	public MainPage()
	{
		InitializeComponent();
		PreencherTela();
		TestaLayout();
	}

	void TestaLayout()
	{
		results.temp= 23;
		results.description="Tempo Nublado";
		results.city="Apucarana, PR";
		results.rain= 88;
		results.humidity= 1;
		results.wind_speedy= "3";
		results.wind_direction= 397;
		results.sunset= "06:1";
		results.sunrise= "18:20 ";
		results.moon_phase= "Nova";
	}

	void PreencherTela()
	{
		
		labeltemp.Text = results.temp.ToString();
		labelclima.Text = results.description;
		labelcidade.Text = results.city;
		labeldachuva.Text = results.rain.ToString();
		labeldaumidade.Text = results.humidity.ToString();
		labeldaforcadovento.Text = results.wind_speedy;
		labeldadirecaodovento.Text = results.wind_direction.ToString();
		labeldonascerdosol.Text = results.sunrise;
		labeldopordosol.Text = results.sunset;
		labeldafasedalua.Text = results.moon_phase;
	
	}

	

	
	
}

