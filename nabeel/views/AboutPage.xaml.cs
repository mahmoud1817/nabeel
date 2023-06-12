namespace nabeel.views;
using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();

		var car = new List<CarData>
		{
			new CarData {Id=1 , Title = "ÑÓÇáÉ ÇáãÔÑæÚ" , Description = "ÑÓÇáÉ ÇáãÔÑæÚ ÑÓÇáÉ äÈíáÉ"},
			new CarData {Id=2 , Title = "ÇáŞÇÆãæä Úáì ÇáãÔÑæÚ" , Description = "áã íÊã ÊÍÏíÏåã ÈÚÏ"},
			new CarData {Id=3 , Title = "ÂáíÉ Úãá ÇáÊØÈíŞ" , Description = "áã íÊã æÖÚ ÇáÂáíÉ ÈÚÏ"}
		};

		carV.ItemsSource = car;
		
	}

	public class CarData
	{
		public int Id { get; set; }
		public string Title { get; set; }

		public string Description { get; set; }

	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("", "", "ok");
    }


}