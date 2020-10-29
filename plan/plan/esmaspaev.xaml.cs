using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace plan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class esmaspaev : ContentPage
    {
        public esmaspaev()
        {
            string[] tasks = new string[] { "просыпаемся", "чистим зубы", "завтракаем", "одеваемся", "берем манатки", "забегаем в магаз",  "торопимся в аэрапорт",   "встречаемся с Элей",  "чилим в городе", "обедаем обед чемпионов", "едем но мне", "чилим под пивс и квас", "МЭЙБИ го ту бэд ;)" };
            ListView list = new ListView();
            list.ItemsSource = tasks;
            list.ItemSelected += List_ItemSelected;
            Content = new StackLayout { Children = { list } };

            { Button bb = new Button { Text = "tagasi" };
            bb.Clicked += Bb_Clicked;

            Button bbk = new Button { Text = "edasi" };
            bbk.Clicked += Bbk_Clicked;


            list.ItemSelected += List_ItemSelected;
            Content = new StackLayout { Children = { list, bb, bbk } };
            }
        string kell;
        private async void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null )
            {
                string text = e.SelectedItem.ToString();
                if (e.SelectedItemIndex==0)//просыпаемся
                {
                    kell = "9:00";
                }
                else if (e.SelectedItemIndex == 1)//чистим зубы
                {
                    kell = "9:15";
                }
                 else if (e.SelectedItemIndex == 2)//завтракаем
                {
                    kell = "9:30";
                }
                else if (e.SelectedItemIndex == 3)//одеваемся
                {
                    kell = "10:30";
                }
                else if (e.SelectedItemIndex == 4)//берем манатки
                {
                    kell = "11:30";
                }
                else if (e.SelectedItemIndex == 5)//забегаем в магаз
                {
                    kell = "12:00";
                }
                else if (e.SelectedItemIndex == 6)//торопимся в аэрапорт
                {
                    kell = "12:30";
                }
                else if (e.SelectedItemIndex == 7)//встречаем с Элю
                {
                    kell = "13:20";
                }
                else if (e.SelectedItemIndex == 9)//чилим в городе
                {
                    kell = "13:25";
                }
                else if (e.SelectedItemIndex == 10)//обедаем обед чемпионов
                {
                    kell = "16:00";
                }
                else if (e.SelectedItemIndex == 11)//едем но мне
                {
                    kell = "18:45 сварачиваем в мак";
                }
                else if (e.SelectedItemIndex == 12)//чилим под пивс и квас
                {
                    kell = "20:55";
                }
                else if (e.SelectedItemIndex == 13)//МЭЙБИ го ту бэд ;)
                {
                    kell = "???";
                }
                }

                private async void Bb_Clicked(object sender, EventArgs e)
                {
                    await Navigation.PopAsync();

                }
            }
        }
    }
}
