namespace AppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
     

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);
                //O preço do etanol seja menor do que 70% do preço da gasolina.

                string msg = "";

                if (etanol <= (gasolina * 0.7))
                {
                    msg = "O Etanol está compensando.";
                } else
                {
                    msg = "A Gasolina está compensando.";
                }

                DisplayAlert("Calculado", msg, "Ok.");

            } catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "Fechar");
            }
        }
    }

}
