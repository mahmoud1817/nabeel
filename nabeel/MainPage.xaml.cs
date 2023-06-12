using CommunityToolkit.Maui;

namespace nabeel;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();

		var builder = MauiApp
		  .CreateBuilder()
		  .UseMauiApp<App>()
		  .UseMauiCommunityToolkit();

       List<Data> QA = new List<Data>()
		{
			new Data{Id = 1, Question = "ما قولك في كذا؟" , Answer = "قولي كذا وكذا",Scholar =" جواب " +"فلان"},
			new Data{Id = 2, Question = "ما قولك في كذا؟" , Answer = "قولي كذا وكذا",Scholar =" جواب " +"فلان"},
			new Data{Id = 3, Question = "ما قولك في كذا؟" , Answer = "قولي كذا وكذا", Scholar = " جواب " + "فلان"},
			new Data{Id = 4, Question = "ما قولك في كذا؟" , Answer = "قولي كذا وكذا", Scholar = " جواب " + "فلان"},
		};

		mylist.ItemsSource = QA;
	}

	public class Data
	{
		public int Id { get; set; }
		public string Question { get; set; }
		public string Answer { get; set; }

		public string Scholar { get; set; }
	}
}

