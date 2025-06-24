namespace Lab3
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        public static class ExceptionStrings
        {
            public const string EmptyLogin = "Логин не может быть пустым.";
            public const string EmptyPassword1 = "Первый пароль не может быть пустым.";
            public const string EmptyPassword2 = "Второй пароль не может быть пустым.";
            public const string DifferentPasswords = "Пароли не совпадают";
            public const string SameLoginPassword = "Логин и пароль не должны совпадать";
            public const string PasswordLess10Chars = "Пароль не может содержать менее 10 символов.";
            public const string PasswordNoNumber = "Пароль должен содержать хотя бы одну цифру";
            public const string PasswordNoExtraChar = "Пароль доджен содержать хотя бы один спецсимвол из @#$%^&*!\".";
            public const string PasswordNoUpperChar = "Пароль должен содержать хотя бы одну букву в верхнем регистре";
            public const string LoginForbidden = "Логин должен состоять только из цифр, букв и символа _.";
        }

        public static bool checkDoctorData(string login,
                                           string password,
                                           string repPassword)
        {
            if (login == null || login.Length == 0)
            {
                throw new Exception(ExceptionStrings.EmptyLogin);
            }
            if (password == null || password.Length == 0)
            {
                throw new Exception(ExceptionStrings.EmptyPassword1);
            }
            if (repPassword == null || repPassword.Length == 0)
            {
                throw new Exception(ExceptionStrings.EmptyPassword2);
            }

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}