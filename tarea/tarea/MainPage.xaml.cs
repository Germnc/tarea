using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using tarea.Models;

namespace tarea
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnsumar_Clicked(object sender, EventArgs e)
        {
            double resultado;

            int a, b;

            a = Convert.ToInt32(txtn1.Text);

            b = Convert.ToInt32(txtn2.Text);

            resultado = a + b;

            txtresultado.Text = Convert.ToString(resultado);

            var operaciones = new Models.operaciones
            {
                resultado = resultado,
            };

            var page = new Views.Page2();
            page.BindingContext = operaciones;
            await Navigation.PushAsync(page);
        }

        private async void btnresta_Clicked(object sender, EventArgs e)
        {
            double resultado;

            int a, b;

            a = Convert.ToInt32(txtn1.Text);

            b = Convert.ToInt32(txtn2.Text);

            resultado = a - b;

            txtresultado.Text = Convert.ToString(resultado);

            var operaciones = new Models.operaciones
            {
                resultado = resultado,
            };

            var page = new Views.Page2();
            page.BindingContext = operaciones;
            await Navigation.PushAsync(page);
        }

        private async void btndividir_Clicked(object sender, EventArgs e)
        {
            double resultado;

            int a, b;

            a = Convert.ToInt32(txtn1.Text);

            b = Convert.ToInt32(txtn2.Text);

            resultado = a / b;

            txtresultado.Text = Convert.ToString(resultado);

            var operaciones = new Models.operaciones
            {
                resultado = resultado,
            };

            var page = new Views.Page2();
            page.BindingContext = operaciones;
            await Navigation.PushAsync(page);
        }

        private async void btnmultiplicacion_Clicked(object sender, EventArgs e)
        {
            double resultado;

            int a, b;

            a = Convert.ToInt32(txtn1.Text);

            b = Convert.ToInt32(txtn2.Text);

            resultado = a * b;

            txtresultado.Text = Convert.ToString(resultado);

            var operaciones = new Models.operaciones
            {
                resultado = resultado,
            };

            var page = new Views.Page2();
            page.BindingContext = operaciones;
            await Navigation.PushAsync(page);
        }
    }
}
