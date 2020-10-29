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
    public partial class laupaev : ContentPage
    {
        string[] tasks = new string[] { "просыпаемся", "приводим себя в порядок", "что нибудь закидываем в рот", "собираем монатки", "приезжаем в аэрапорт", "летим в Корею", "залетаем на виллу", "идем с Эдей в бар", "случайно попадаем в стриптиз клуб", "оставляем там все деньги сэкономленные в ресторане в Париже", "возвращаемся на виллу", "чилим под пивас и квас в джакузи", "чилим на вилле" };
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
        else if (e.SelectedItemIndex == 5)//летим в китай
        {
            kell = "18:05";
        }
        else if (e.SelectedItemIndex == 6)//залетаем на виллу
        {
            kell = "18:25";
        }
        else if (e.SelectedItemIndex == 7)//идем с элей в бар
        {
            kell = "19:00";
        }
        else if (e.SelectedItemIndex == 9)//случайно попадаем в стриптиз клуб
        {
            kell = "19:13";
        }
        else if (e.SelectedItemIndex == 10)//оставляем там все деньги сэкономленные в ресторане в Париже
        {
            kell = "20:54";
        }
        else if (e.SelectedItemIndex == 11)//возвращаемся на виллу
        {
            kell = "01:00";
        }
        else if (e.SelectedItemIndex == 12)//чилим под пивас и квас в джакузи
            ListView list = new ListView();
        {
            kell = "01:25";
        }
        else if (e.SelectedItemIndex == 13)//чилим на вилле
        {
            kell = "???";
        }
        await DisplayAlert(kell, text, "jah");
    }

}
    }
}