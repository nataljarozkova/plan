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
    public partial class neljapaev : ContentPage
    {
        public neljapaev()
        {
            string[] tasks = new string[] { "рота подьем","умываемся","грабим еду Эрика, пока он спит в джакузи","монатки берем","едем в аэрапорт","летим в Гонконг","заселяемся в папику-Артему","мутим тусу","закупаемся","готовимся к тусе","ТУСИМ-ТУСИМ,ТЫЦ-ДРЫЦ","заканчиваем тусу","Артем напимает уборщиц",""
            ListView list = new ListView();
            list.ItemsSource = tasks;
            list.ItemSelected += List_ItemSelected;
            Content = new StackLayout { Children = { list } };
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
                else if (e.SelectedItemIndex == 1)//используем ВЕРНУЮ косметичку
                {
                    kell = "13:12";
                }
                else if (e.SelectedItemIndex == 2)//завтракаем в Люксе
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
                else if (e.SelectedItemIndex == 5)//летис в Рио-де Жанейро
                {
                    kell = "18:05";
                }
                else if (e.SelectedItemIndex == 6)//залетаем в дом Эрика
                {
                    kell = "18:25";
                }
                else if (e.SelectedItemIndex == 7)//тусим с Элей и Эриком на параде
                {
                    kell = "19:00";
                }
                else if (e.SelectedItemIndex == 9)//случайно принимаем участие в параде
                {
                    kell = "19:13";
                }
                else if (e.SelectedItemIndex == 10)//ужинаем с участниками парада
                {
                    kell = "20:54";
                }
                else if (e.SelectedItemIndex == 11)//возвращаемся к Эрику
                {
                    kell = "01:00";
                }
                else if (e.SelectedItemIndex == 12)//чилим под пивас и квас-ТОЛЬКО С ЭЛЕЙ
                {
                    kell = "01:25";
                }
                else if (e.SelectedItemIndex == 13)//го ту бэд
                {
                    kell = "???";
                }
                await DisplayAlert(kell, text, "jah");
            }

        }
    }
}