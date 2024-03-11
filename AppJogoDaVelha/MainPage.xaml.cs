using System.Net.NetworkInformation;

namespace AppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "O";

        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Button disparador = (Button)sender;
            if(vez == "O")
            {
                disparador.Text = "O";
                vez = "X";
            }
            else
            {
                disparador.Text = "X";
                vez = "O";
            }
            if(btn10.Text == "X"
                && btn11.Text == "X"
                && btn12.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                
            }
        } 

        private void limpar()
        {
            btn10.Text = "";
            btn10.IsEnabled = true;
        }




         
    }

}
