using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace plan
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            StackLayout st = new StackLayout();
            Button esm_btm = new Button { Text = "esmaspäev", ImageSource = "4.JPG", BackgroundColor=Color.LightPink };
            Button teis_btm = new Button { Text = "teisipäev", ImageSource = "4.JPG", BackgroundColor=Color.LightGreen};
            Button kolm_btm = new Button { Text = "kolmapäev", ImageSource = "4.JPG", BackgroundColor=Color.LightGray};
            Button nel_btm = new Button { Text = "neljapäev", ImageSource = "4.JPG", BackgroundColor=Color.LightSalmon};
            Button red_btm = new Button { Text = "rede", ImageSource = "4.JPG", BackgroundColor=Color.LightYellow};
            Button lau_btm = new Button { Text = "laupäev", ImageSource = "4.JPG" };
            Button puh_btm = new Button { Text = "pühapäev", ImageSource = "4.JPG" };



            st.Children.Add(esm_btm);
            esm_btm.Clicked += new EventHandler(btns_clicked);

            st.Children.Add(teis_btm);
            teis_btm.Clicked += new EventHandler(btns_clicked);

            st.Children.Add(kolm_btm);
            kolm_btm.Clicked += new EventHandler(btns_clicked);

            st.Children.Add(nel_btm);
            nel_btm.Clicked += new EventHandler(btns_clicked);

            st.Children.Add(red_btm);
            red_btm.Clicked += new EventHandler(btns_clicked);

            st.Children.Add(lau_btm);
            lau_btm.Clicked += new EventHandler(btns_clicked);

            st.Children.Add(puh_btm);
            puh_btm.Clicked += new EventHandler(btns_clicked);

            Content = st;
        }

        private async void btns_clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Text)//проверяем текст на кнопке
            {

                case "esmaspäev":
                    await Navigation.PopAsync();//закрываем страницу
                    await Navigation.PushAsync(new esmaspaev());//открываем
                    break;

                case "teisipäev":
                    await Navigation.PopAsync();//закрываем страницу
                    await Navigation.PushAsync(new esmaspaev());//открываем
                    break;

                case "kolmapäev":
                    await Navigation.PopAsync();//закрываем страницу
                    await Navigation.PushAsync(new esmaspaev());//открываем
                    break;

                case "neljapäev":
                    await Navigation.PopAsync();//закрываем страницу
                    await Navigation.PushAsync(new esmaspaev());//открываем
                    break;

                case "rede":
                    await Navigation.PopAsync();//закрываем страницу
                    await Navigation.PushAsync(new esmaspaev());//открываем
                    break;

                case "laupäev":
                    await Navigation.PopAsync();//закрываем страницу
                    await Navigation.PushAsync(new esmaspaev());//открываем
                    break;

                case "pühapäev":
                    await Navigation.PopAsync();//закрываем страницу
                    await Navigation.PushAsync(new esmaspaev());//открываем
                    break;
            }
        }
    }
}
