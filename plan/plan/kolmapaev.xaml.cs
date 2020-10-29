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
    public partial class kolmapaev : ContentPage
    {
        public kolmapaev()
        {
            string[] tasks = new string[] { "просыпаемся", "используем ВЕРНУЮ косметичку", "завтракаем в Люксе", "собираем монатки", "приезжаем в аэрапорт", "летис в Рио-де Жанейро", "залетаем в дом Эрика", "тусим с Элей и Эриком на параде", "случайно принимаем участие в параде", "ужинаем с участниками парада", "возвращаемся к Эрику", "чилим под пивас и квас-ТОЛЬКО С ЭЛЕЙ", "го ту бэд" };
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
            Content = new StackLayout { Children = { list, bb, bbk }};
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