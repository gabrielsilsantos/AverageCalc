using Android.App;
using Android.Widget;
using Android.OS;

namespace CalculadoraMedia
{
    [Activity(Label = "CalculadoraMedia", MainLauncher = true)]
    public class MainActivity : Activity
    {

        TextView mediaTxt;
        EditText notaTxt1;
        EditText notaTxt2;
        EditText notaTxt3;
        EditText notaTxt4;
        Button btnCalculate;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mediaTxt = FindViewById<TextView>(Resource.Id.mediaTxt);
            notaTxt1 = FindViewById<EditText>(Resource.Id.notaTxt1);
            notaTxt2 = FindViewById<EditText>(Resource.Id.notaTxt2);
            notaTxt3 = FindViewById<EditText>(Resource.Id.notaTxt3);
            notaTxt4 = FindViewById<EditText>(Resource.Id.notaTxt3);
            btnCalculate = FindViewById<Button>(Resource.Id.btnCalculate);

            btnCalculate.Click += BtnCalculate_Click;
        }

        private void BtnCalculate_Click(object sender, System.EventArgs e)
        {
            float Valor1 = 0;
            float Valor2 = 0;
            float Valor3 = 0;
            float Valor4 = 0;
            float ValorMedia = 0;

            Valor1 = float.Parse(notaTxt1.Text);
            Valor2 = float.Parse(notaTxt2.Text);
            Valor3 = float.Parse(notaTxt3.Text);
            Valor4 = float.Parse(notaTxt4.Text);

            ValorMedia = (Valor1 + Valor2 + Valor3 + Valor4) / 4;
            mediaTxt.Text = ValorMedia.ToString();
        }
    }
}

