namespace Lab3
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        public static bool checkDoctorData(string login,
                                           string password,
                                           string repPassword)
        {
            if (login == null || login.Length == 0)
            {
                throw new Exception("Логин не может быть пустым.");
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}