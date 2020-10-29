using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace plan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class teisipaev : ContentPage
    {
        public teisipaev()
        {
            string[] tasks = new string[] { "встаем", "пудрим носик", "пьем Borjomi", "собираем монатки", "едем в аэрапорт", "летим в Лондон", "бросаем монатки в люкс", "тусуемсмя в клуюе с Элей", "хаваем на халяву", "сбегаем с клуба", "бегаем от работник куба из-за неоплаченного счета", "прячемся в номере", "чилим под пивас и квас" };
    ListView list = new ListView();
    list.ItemsSource = tasks;
    list.ItemSelected += List_ItemSelected;
    Content = new StackLayout { Children = { list } };


        }
         { Button bb = new Button { Text = "tagasi" };
        bb.Clicked += Bb_Clicked;

            Button bbk = new Button { Text = "edasi" };
        bbk.Clicked += Bbk_Clicked;


            list.ItemSelected += List_ItemSelected;
            Content = new StackLayout { Children = { list, bb, bbk
    }
};
            }
string kell;
private async void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
{
    if (e.SelectedItem != null)
    {
        string text = e.SelectedItem.ToString();
        if (e.SelectedItemIndex == 0)//встаем
                {
            kell = "10:30";
        }
        else if (e.SelectedItemIndex == 1)//пудрим носик
                {
            kell = "10:37";
        }
        else if (e.SelectedItemIndex == 2)//пьем Borjomi
                {
            kell = "11:25";
        }
        else if (e.SelectedItemIndex == 3)//собираем монатки
                {
            kell = "11:30";
        }
        else if (e.SelectedItemIndex == 4)//едем в ажапорт
                {
            kell = "12:35";
        }
        else if (e.SelectedItemIndex == 5)//летим в Лондон
                {
            kell = "17:15";
        }
        else if (e.SelectedItemIndex == 6)//бросаем монатки в люкс
                {
            kell = "17:45";
        }
        else if (e.SelectedItemIndex == 7)//тусуемсмя в клуюе с Элей
                {
            kell = "18:22";
        }
        else if (e.SelectedItemIndex == 9)//хаваем на халяву
                {
            kell = "23.35";
        }
        else if (e.SelectedItemIndex == 10)//сбегаем с клуба
                {
            kell = "00:54";
        }
        else if (e.SelectedItemIndex == 11)//бегаем от работник куба из-за неоплаченного счета
                {
            kell = "01:00";
        }
        else if (e.SelectedItemIndex == 12)//прячемся в номере
                {
            kell = "03.21";
        }
        else if (e.SelectedItemIndex == 13)//чилим под пивас и квас
                {
            kell = "03.55";
        }
        await DisplayAlert(kell, text, "jah");
    }

}
}
    }
    

