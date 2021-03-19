
using KFC.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KFC
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    
    public partial class MainPage : ContentPage
    {
        public static IList<Product> products { get; set; }
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            products = new List<Product>();
            Cart.ProductsInCart= new List<Product>();
            products.Add(new Product(
                Id:1,
                Naziv: "Wrapper Sandwich",
                Cijena:3.0f,
                kolicina:0,
                image: "Wrapper.jpg"
                ));
            products.Add(new Product(
              Id: 2,
              Naziv: "Tostada",
              Cijena: 5.0f,
              kolicina: 0,
              image: "tostada.jpg"
              ));
            products.Add(new Product(
              Id: 3,
              Naziv: "Zinger sandwich",
              Cijena: 5.0f,
              kolicina: 0,
              image: "zinger.jpg"
              ));
            products.Add(new Product(
              Id: 4,
              Naziv: "Twister sandwich",
              Cijena: 6.0f,
              kolicina: 0,
              image: "twister.jpg"
              ));
            products.Add(new Product(
              Id: 5,
              Naziv: "CheeseBurger",
              Cijena: 5.0f,
              kolicina: 0,
              image: "cheseburger.png"
              ));
            products.Add(new Product(
              Id: 6,
              Naziv: "20 krilca",
              Cijena: 8.0f,
              kolicina: 0,
              image:"krilca.png"
              ));
            products.Add(new Product(
              Id: 7,
              Naziv: "30 krilca",
              Cijena: 12.0f,
              kolicina: 0,
              image:"krilca.png"
              ));
            products.Add(new Product(
              Id: 8,
              Naziv: "Kentucky Bucket",
              Cijena: 15.0f,
              kolicina: 0,
              image: "kentucky.jpg"
              ));
            products.Add(new Product(
              Id: 9,
              Naziv: "Strpis bucket",
              Cijena: 13.0f,
              kolicina: 0,
              image: "strips.jpg"
              ));
            products.Add(new Product(
              Id: 10,
              Naziv: "Classic bucket",
              Cijena: 15.0f,
              kolicina: 0,
              image: "classic.jpg"
              ));
            products.Add(new Product(
             Id: 11,
             Naziv: "Jagoda Shake",
             Cijena: 4.0f,
             kolicina: 0,
             image: "shake_2.png"
             ));
            products.Add(new Product(
             Id: 12,
             Naziv: "Orange Shake",
             Cijena: 4.0f,
             kolicina: 0,
             image: "shake_1.png"
             ));
            products.Add(new Product(
             Id: 13,
             Naziv: "Frozen Shake",
             Cijena: 6.0f,
             kolicina: 0,
             image: "shake_3.png"
             ));
            products.Add(new Product(
             Id: 14,
             Naziv: "Oreo Shake",
             Cijena: 5.0f,
             kolicina: 0,
             image: "shake_4.png"
             ));
            products.Add(new Product(
             Id: 15,
             Naziv: "Caffe Americano",
             Cijena: 3.0f,
             kolicina: 0,
             image: "shake_5.png"
             ));
            products.Add(new Product(
             Id: 16,
             Naziv: "Pomfrit",
             Cijena: 2.0f,
             kolicina: 0,
             image: "prilozi1.jpg"
             ));
            products.Add(new Product(
             Id: 17,
             Naziv: "Chilli sos",
             Cijena: 1.0f,
             kolicina: 0,
             image: "prilozi2.jpg"
             ));
            products.Add(new Product(
             Id: 18,
             Naziv: "Kečap",
             Cijena: 1.0f,
             kolicina: 0,
             image: "prilozi3.jpg"
             ));
            products.Add(new Product(
             Id: 19,
             Naziv: "Majoneza",
             Cijena: 1.0f,
             kolicina: 0,
             image: "prilozi4.jpg"
             ));
            products.Add(new Product(
             Id: 20,
             Naziv: "Kukuruz",
             Cijena: 2.0f,
             kolicina: 0,
             image: "prilozi5.jpg"
             ));
        }



        private void GuestTapped(object sender, EventArgs e)

        {
            Navigation.PushAsync(new Gost());
        }
        private void LoginTapped(object sender, EventArgs e)

        {
            Navigation.PushAsync(new LoginPage());
        }
        private void RegTapped(object sender, EventArgs e)

        {
            Navigation.PushAsync(new Registracija());
        }
    }
}
