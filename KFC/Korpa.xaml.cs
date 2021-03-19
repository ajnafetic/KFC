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
    public partial class Korpa : ContentPage
    {
        public Korpa()
        {
            InitializeComponent();
            BindingContext = this;
            float cijena = 0.0f;
            if (Cart.ProductsInCart.Count==0) lblNaziv.Text = "Vaša korpa je trenutno prazna";
            else
            {
                lblNaziv.Text = "Sadržaj vaše korpe je: ";
                lblHead.Text = "Stavka Cijena Količina";
                
                for(int i=0; i<Cart.ProductsInCart.Count; i++)
                {

                  //  Label label = new Label { Text= Cart.ProductsInCart.ElementAt(i).Naziv + " " + Cart.ProductsInCart.ElementAt(i).Cijena + " " + Cart.ProductsInCart.ElementAt(i).kolicina };
                    //Image image = new Image { Source = Cart.ProductsInCart.ElementAt(i).image };
                    
                 lblOrd.Text = lblOrd.Text+"\n"+ Cart.ProductsInCart.ElementAt(i).Naziv + " " + Cart.ProductsInCart.ElementAt(i).Cijena + " " + Cart.ProductsInCart.ElementAt(i).kolicina;
                cijena = cijena + (Cart.ProductsInCart.ElementAt(i).Cijena * Cart.ProductsInCart.ElementAt(i).kolicina);
                }
                
            }
            lblCijena.Text = cijena + " KM";
        }

        void Button_Clicked(object sender, EventArgs e)

        {
            Cart.ProductsInCart.Clear();
            lblCijena.Text = "0.0 KM";
            lblHead.Text = "";
            lblOrd.Text = "";
            lblNaziv.Text = "Vaša korpa je trenutno prazna";
            Navigation.PushAsync(new Placanje());
        }

      
    }
}