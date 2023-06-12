using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace nabeel.views;

public partial class QuestionPage : ContentPage
{
    public QuestionPage()
    {
        InitializeComponent();
        p.SelectedItem = "Õ”» «·„ «Õ";
        
        
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        String Name = name.Text;
        String Email = email.Text;
        String Subject = subject.Text;
        String Message = message.Text;
        String Target = p.SelectedItem.ToString();
        String gender = rm.IsChecked ? rm.Content.ToString() : rf.Content.ToString();

        if (Name == null || Email == null || Subject == null || Message == null || Target == null)
        {
            DisplayAlert("Œÿ√","Ì—ÃÏ ≈ﬂ„«· «·»Ì«‰« ", "Õ”‰«");

        }
        else
        {
            //CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            //var toast = Toast.Make(" „ «·≈—”«·",ToastDuration.Short,14);
            //toast.Show(cancellationTokenSource.Token);
            
            name.Text = null; email.Text = null; subject.Text = null; message.Text = null;
            DisplayAlert("", " „ «·≈—”«· »‰Ã«Õ", "Õ”‰«");
        }



    }

}