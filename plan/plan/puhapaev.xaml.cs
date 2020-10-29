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
    public partial class puhapaev : ContentPage
    {
        string[] tasks = new string[] { "просыпаемся", "приводим себя в порядок", "что нибудь закидываем в рот", "собираем монатки", "приезжаем в аэрапорт", "летим домой", "залетаем домой", "кидаем вещи у порога", "идем в душ", "го ту бэд" };
        ListView list = new ListView();
        list.ItemsSource = tasks;
            list.ItemSelected += List_ItemSelected;
            Content = new StackLayout { Children = { list
    }
};
        }
 {
    Button bb = new Button { Text = "tagasi" };
    bb.Clicked += Bb_Clicked;

    Button bbk = new Button { Text = "edasi" };
    bbk.Clicked += Bbk_Clicked;


    list.ItemSelected += List_ItemSelected;
    Content = new StackLayout { Children = { list, bb, bbk } };
}
string kell;
private async void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
{
    if (e.SelectedItem != null)
    {
        string text = e.SelectedItem.ToString();
        if (e.SelectedItemIndex == 0)//просыпаемся
        {
            kell = "13:05";
        }
        else if (e.SelectedItemIndex == 1)//приводим себя в порядок
        {
            kell = "13:12";
        }
        else if (e.SelectedItemIndex == 2)//что нибудь закидываем в рот
        {
            kell = "13:45";
        }
        else if (e.SelectedItemIndex == 3)//собираем монатки
        {
            kell = "14:25";
        }
        else if (e.SelectedItemIndex == 4)//приезжаем в аэрапорт
        {
            kell = "14:55";
        }
        else if (e.SelectedItemIndex == 5)//летим домой
        {
            kell = "18:05";
        }
        else if (e.SelectedItemIndex == 6)//залетаем домой
        {
            kell = "18:25";
        }
        else if (e.SelectedItemIndex == 7)//кидаем вещи у порого
        {
            kell = "19:00";
        }
        else if (e.SelectedItemIndex == 9)//идем в душ
        {
            kell = "19:13";
        }
        else if (e.SelectedItemIndex == 10)//го ту бэд
        {
            kell = "20:54";
        }
        await DisplayAlert(kell, text, "jah");
    }

}
    }
}