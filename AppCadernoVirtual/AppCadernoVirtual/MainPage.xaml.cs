using AppCadernoVirtual.Primeiro; // nome do app e cada pasta que os botões acessarão
using AppCadernoVirtual.Segundo;
using AppCadernoVirtual.Terceiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCadernoVirtual
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            logo2.Source = ImageSource.FromResource("AppCadernoVirtual.Imagem.logo2.png");

           // declarando imagem logo
            
           
           NavigationPage.SetHasNavigationBar(this, false); // esconde a barra de navegação
        }

       
        // manipuladores de eventos criados - cada evento leva a sua página correspondente
        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InicialPrimeiro());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InicialSegundo ());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InicialTerceiro());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InicialTerceiro());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InicialTerceiro());
        }
    }
}
