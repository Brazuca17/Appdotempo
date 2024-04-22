using System.Text.Json;

namespace Appdotempo;

public partial class MainPage : ContentPage
{

	Resposta resposta;

	const string Url="https://api.hgbrasil.com/weather?woeid=455927&key=ac98ccd4";

	public MainPage()
	{
		InitializeComponent();
		
		AtualizaTempo();
	}

	async void AtualizaTempo() 
	{
		try
		{
			var httpClient = new HttpClient();
			var response = await httpClient.GetAsync(Url);
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				resposta = JsonSerializer.Deserialize<Resposta>(content);
			}
			PreencherTela();
		}
		catch (Exception e)	
		{
			//ERRO
		}
	}

	

	void PreencherTela()
	{
		
		labeltemp.Text = resposta.results.temp.ToString();
		labelclima.Text = resposta.results.description;
		labelcidade.Text = resposta.results.city;
		labeldachuva.Text = resposta.results.rain.ToString();
		labeldaumidade.Text = resposta.results.humidity.ToString();
		labeldaforcadovento.Text = resposta.results.wind_speedy;
		labeldadirecaodovento.Text = resposta.results.wind_direction.ToString();
		labeldonascerdosol.Text = resposta.results.sunrise;
		labeldopordosol.Text = resposta.results.sunset;
		if(resposta.results.moon_phase=="full")
			labeldafasedalua.Text = "Cheia";
		else if(resposta.results.moon_phase=="new")
			labeldafasedalua.Text = "Nova";
	
	}

}

