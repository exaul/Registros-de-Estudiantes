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
            if (IsValid())
            {
                //DisplayAlert("Registro",MyEstudiante.Nombres +" "+ "Sus datos se ingresaron correctamente","Ok");
                var mensaje = $"{MyEstudiante.Nombres} sus datos se ingresaron correctamente";
                var titulo = "Registro";
                DisplayAlert(titulo, mensaje, "oK");
            }
            
        }
        private bool IsValid()
        {
            if(string.IsNullOrEmpty(MyEstudiante.Nombres))
            {
                DisplayAlert("Registro Fallido", "el campo Nombre esta vacio", "ok");  
                return false; 
            }
            if (string.IsNullOrEmpty(MyEstudiante.Apellidos))
            {
                DisplayAlert("Registro Fallido", "el campo Apellidos esta vacio", "ok");
                return false;
            }
            if (string.IsNullOrEmpty(MyEstudiante.Materia))
            {
                DisplayAlert("Registro Fallido", "el campo Materia esta vacio", "ok");
                return false;
            }
            return true;
        }
    }
}