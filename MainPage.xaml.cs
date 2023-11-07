namespace RegistrosdeEstudiante
{
    public partial class MainPage : ContentPage
    {
        public Estudiantes MyEstudiante { get; set; }
        public MainPage()
        {
            InitializeComponent();
            MyEstudiante = new Estudiantes();
            BindingContext = MyEstudiante;
        }

        private void ConfirmarBtn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Registro",MyEstudiante.Nombres +" "+ "Sus datos se ingresaron correctamente","Ok");

        }
    }
}