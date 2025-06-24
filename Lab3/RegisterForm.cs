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
            public const string EmptyLogin = "����� �� ����� ���� ������.";
            public const string EmptyPassword1 = "������ ������ �� ����� ���� ������.";
            public const string EmptyPassword2 = "������ ������ �� ����� ���� ������.";
            public const string DifferentPasswords = "������ �� ���������";
            public const string SameLoginPassword = "����� � ������ �� ������ ���������";
            public const string PasswordLess10Chars = "������ �� ����� ��������� ����� 10 ��������.";
            public const string PasswordNoNumber = "������ ������ ��������� ���� �� ���� �����";
            public const string PasswordNoExtraChar = "������ ������ ��������� ���� �� ���� ���������� �� @#$%^&*!\".";
            public const string PasswordNoUpperChar = "������ ������ ��������� ���� �� ���� ����� � ������� ��������";
            public const string LoginForbidden = "����� ������ �������� ������ �� ����, ���� � ������� _.";
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