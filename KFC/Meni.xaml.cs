using KFC.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KFC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Meni : TabbedPage
    {
      
        public Meni()
        {
            InitializeComponent();
            this.BarBackgroundColor = Color.FromHex("Bf0205");
            ToolbarItem korpa = new ToolbarItem
            {
                
                Icon = "cart.png",
                Name = "facebook",
                Priority = 0
            };

            ToolbarItems.Add(korpa);
            korpa.Clicked += Clicked;
          

        }
         void Clicked(object sender, EventArgs e)

        {
            Navigation.PushAsync(new Korpa());
        }

        private async void  ImageButton_Clicked(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(0)))
            {
              int ind=  Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(0));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(0).kolicina = MainPage.products.ElementAt(0).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(0));
            }
            await DisplayAlert("Korpa","Stavka dodana u korpu.","OK");
        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(1)))
            {
                int ind = Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(1));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(1).kolicina = MainPage.products.ElementAt(1).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(1));
            }
            await DisplayAlert("Korpa", "Stavka dodana u korpu.", "OK");
        }

        private async void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(2)))
            {
                int ind = Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(2));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(2).kolicina = MainPage.products.ElementAt(2).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(2));
            }
            await DisplayAlert("Korpa", "Stavka dodana u korpu.", "OK");
        }

        private async void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(3)))
            {
                int ind = Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(3));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(3).kolicina = MainPage.products.ElementAt(3).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(3));
            }
            await DisplayAlert("Korpa", "Stavka dodana u korpu.", "OK");
        }

        private async void ImageButton_Clicked_4(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(4)))
            {
                int ind = Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(4));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(4).kolicina = MainPage.products.ElementAt(4).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(4));
            }
            await DisplayAlert("Korpa", "Stavka dodana u korpu.", "OK");

        }

        private async void ImageButton_Clicked_5(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(5)))
            {
                int ind = Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(5));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(5).kolicina = MainPage.products.ElementAt(5).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(5));
            }
            await DisplayAlert("Korpa", "Stavka dodana u korpu.", "OK");
        }

        private async void ImageButton_Clicked_6(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(6)))
            {
                int ind = Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(6));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(6).kolicina = MainPage.products.ElementAt(6).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(6));
            }
            await DisplayAlert("Korpa", "Stavka dodana u korpu.", "OK");
        }

        private async void ImageButton_Clicked_7(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(7)))
            {
                int ind = Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(7));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(7).kolicina = MainPage.products.ElementAt(7).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(7));
            }
            await DisplayAlert("Korpa", "Stavka dodana u korpu.", "OK");
        }

        private async void ImageButton_Clicked_8(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(8)))
            {
                int ind = Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(8));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(8).kolicina = MainPage.products.ElementAt(8).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(8));
            }
            await DisplayAlert("Korpa", "Stavka dodana u korpu.", "OK");
        }

        private async void ImageButton_Clicked_9(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(9)))
            {
                int ind = Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(9));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(9).kolicina = MainPage.products.ElementAt(9).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(9));
            }
            await DisplayAlert("Korpa", "Stavka dodana u korpu.", "OK");
        }

        private async void ImageButton_Clicked_10(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(10)))
            {
                int ind = Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(10));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(10).kolicina = MainPage.products.ElementAt(10).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(10));
            }
            await DisplayAlert("Korpa", "Stavka dodana u korpu.", "OK");
        }

        private async void ImageButton_Clicked_11(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(11)))
            {
                int ind = Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(11));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(11).kolicina = MainPage.products.ElementAt(11).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(11));
            }
            await DisplayAlert("Korpa", "Stavka dodana u korpu.", "OK");
        }

        private async void ImageButton_Clicked_12(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(12)))
            {
                int ind = Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(12));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(12).kolicina = MainPage.products.ElementAt(12).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(2));
            }
            await DisplayAlert("Korpa", "Stavka dodana u korpu.", "OK");
        }

        private async void ImageButton_Clicked_13(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(13)))
            {
                int ind = Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(13));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(13).kolicina = MainPage.products.ElementAt(13).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(13));
            }
            await DisplayAlert("Korpa", "Stavka dodana u korpu.", "OK");
        }

        private async void ImageButton_Clicked_14(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(14)))
            {
                int ind = Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(14));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(14).kolicina = MainPage.products.ElementAt(14).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(14));
            }
            await DisplayAlert("Korpa", "Stavka dodana u korpu.", "OK");
        }

        private async void ImageButton_Clicked_15(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(15)))
            {
                int ind = Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(15));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(15).kolicina = MainPage.products.ElementAt(15).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(15));
            }
            await DisplayAlert("Korpa", "Stavka dodana u korpu.", "OK");
        }

        private async void ImageButton_Clicked_16(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(16)))
            {
                int ind = Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(16));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(16).kolicina = MainPage.products.ElementAt(16).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(16));
            }
            await DisplayAlert("Korpa", "Stavka dodana u korpu.", "OK");
        }

        private async void ImageButton_Clicked_17(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(17)))
            {
                int ind = Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(17));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(17).kolicina = MainPage.products.ElementAt(17).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(17));
            }
            await DisplayAlert("Korpa", "Stavka dodana u korpu.", "OK");
        }

        private async void ImageButton_Clicked_18(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(18)))
            {
                int ind = Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(18));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(18).kolicina = MainPage.products.ElementAt(18).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(18));
            }
            await DisplayAlert("Korpa", "Stavka dodana u korpu.", "OK");
        }

        private async void ImageButton_Clicked_19(object sender, EventArgs e)
        {
            if (Cart.ProductsInCart.Contains(MainPage.products.ElementAt(19)))
            {
                int ind = Cart.ProductsInCart.IndexOf(MainPage.products.ElementAt(19));
                Cart.ProductsInCart.ElementAt(ind).kolicina = Cart.ProductsInCart.ElementAt(ind).kolicina + 1;
            }
            else
            {
                MainPage.products.ElementAt(19).kolicina = MainPage.products.ElementAt(19).kolicina + 1;
                Cart.ProductsInCart.Add(MainPage.products.ElementAt(19));
            }
            await DisplayAlert("Korpa", "Stavka dodana u korpu.", "OK");
        }
    }
}