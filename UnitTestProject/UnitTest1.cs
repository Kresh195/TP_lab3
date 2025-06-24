using System;
using Lab3;

namespace UnitTestProject
{
    public class Tests
    {
        /// <summary>
        /// Правильные данные для СheckDoctorData.
        /// в функцию переданы данные логина и паролей, соответствующие требованиям.
        /// </summary>
        [TestCase("DoctorSuperBest123!")]
        [TestCase("DoctorSuperBest123$")]
        [TestCase("DoctorSuperBest13@")]
        [TestCase("DoctorSuperBest13#")]
        [TestCase("DoctorSuper$Best13")]
        [TestCase("DoctorSuperbest13%")]
        [TestCase("DoctorSuperBest13^")]
        [TestCase("DoctorSuperBes&t13")]
        [TestCase("Doctorsu*perBest13")]
        public void T_001_СheckDoctorData_BaseFlow(string value)
        {
            // подготовка входных данных модуля
            String login = "myname_doctor";
            String password = value;
            String repPassword = value;
            // ожидаемое значение
            bool expectedReturnValue = true;
            //подготовка переменной для возвращаемого значения
            bool actualReturnValue = false;
            // assert для проверки отсутствия исключения
            Assert.DoesNotThrow(() =>
            { // вызов модуля
                actualReturnValue = RegisterForm.checkDoctorData(login, password, repPassword);
            });
            // assert для проверки ожидаемого и полученного значения
            Assert.AreEqual(expectedReturnValue, actualReturnValue);
        }

        /// <summary>
        /// Пустой логин.
        /// Пользователь оставил поле ввода логина пустым.
        /// </summary>
        [Test]
        public void T_002_СheckDoctorData_EmptyLogin()
        {
            //подготовка входных данных
            String login = "";
            String password = "DoctorSuperBest123!";
            String repPassword = "DoctorSuperBest123!";
            // ожидаемое значение
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.EmptyLogin;
            // assert для получения исключения
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert для проверки ожидаемого и полученного значения
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// Пустой первый пароль.
        /// Пользователь оставил первое поле ввода пароля пустым.
        /// </summary>
        [Test]
        public void T_003_СheckDoctorData_EmptyPassword1()
        {
            //подготовка входных данных
            String login = "myname_doctor";
            String password = "";
            String repPassword = "DoctorSuperBest123!";
            // ожидаемое значение
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.EmptyPassword1;
            // assert для получения исключения
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert для проверки ожидаемого и полученного значения
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// Пустой второй пароль.
        /// Пользователь оставил второе поле ввода пароля пустым.
        /// </summary>
        [Test]
        public void T_004_СheckDoctorData_EmptyPassword2()
        {
            //подготовка входных данных
            String login = "myname_doctor";
            String password = "DoctorSuperBest123!";
            String repPassword = "";
            // ожидаемое значение
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.EmptyPassword2;
            // assert для получения исключения
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert для проверки ожидаемого и полученного значения
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// Пароли отличаются.
        /// Пользователь ввёл отличающиеся пароли.
        /// </summary>
        [Test]
        public void T_005_СheckDoctorData_DifferentPasswords()
        {
            //подготовка входных данных
            String login = "myname_doctor";
            String password = "DoctorSuperBest123!";
            String repPassword = "DoctorBest321!";
            // ожидаемое значение
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.DifferentPasswords;
            // assert для получения исключения
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert для проверки ожидаемого и полученного значения
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// Логин и пароль совпадают.
        /// Пользователь ввёл одинаковые логин и пароль.
        /// </summary>
        [Test]
        public void T_006_СheckDoctorData_SameLoginPassword()
        {
            //подготовка входных данных
            String login = "myname_doctor";
            String password = "myname_doctor";
            String repPassword = "myname_doctor";
            // ожидаемое значение
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.SameLoginPassword;
            // assert для получения исключения
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert для проверки ожидаемого и полученного значения
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// Пароль менее 10 символов.
        /// Пользователь ввёл слишком короткий пароль (меньше 10 симв.).
        /// </summary>
        [Test]
        public void T_007_СheckDoctorData_PasswordLess10Chars()
        {
            //подготовка входных данных
            String login = "myname_doctor";
            String password = "Doc123!";
            String repPassword = "Doc123!";
            // ожидаемое значение
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.PasswordLess10Chars;
            // assert для получения исключения
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert для проверки ожидаемого и полученного значения
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// Пароль не содержит цифр.
        /// Пользователь ввёл пароль, не содержащий цифру.
        /// </summary>
        [Test]
        public void T_008_СheckDoctorData_PasswordNoNumber()
        {
            //подготовка входных данных
            String login = "myname_doctor";
            String password = "DoctorSuperBest!";
            String repPassword = "DoctorSuperBest!";
            // ожидаемое значение
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.PasswordNoNumber;
            // assert для получения исключения
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert для проверки ожидаемого и полученного значения
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// Пароль без спецсимвола.
        /// Пользователь ввёл пароль, не содержащий спецсимвол ("@#$%^&*!").
        /// </summary>
        [Test]
        public void T_009_СheckDoctorData_PasswordNoExtraChar()
        {
            //подготовка входных данных
            String login = "myname_doctor";
            String password = "DoctorSuperBest123";
            String repPassword = "DoctorSuperBest123";
            // ожидаемое значение
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.PasswordNoExtraChar;
            // assert для получения исключения
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert для проверки ожидаемого и полученного значения
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// Пароль не содержит букву в верхнем регистре.
        /// Пользователь ввёл пароль, не содержащий букв в верхнем регистре.
        /// </summary>
        [Test]
        public void T_010_СheckDoctorData_PasswordNoUpperChar()
        {
            //подготовка входных данных
            String login = "myname_doctor";
            String password = "doctorsuperbest123!";
            String repPassword = "doctorsuperbest123!";
            // ожидаемое значение
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.PasswordNoUpperChar;
            // assert для получения исключения
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert для проверки ожидаемого и полученного значения
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// Запрещённый формат логина.
        /// Логин содержит запрещенные символы.
        /// </summary>
        [Test]
        public void T_011_СheckDoctorData_LoginForbidden()
        {
            //подготовка входных данных
            String login = "myname_doctor!";
            String password = "DoctorSuperBest123!";
            String repPassword = "DoctorSuperBest123!";
            // ожидаемое значение
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.LoginForbidden;
            // assert для получения исключения
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert для проверки ожидаемого и полученного значения
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// Регистрация успешна. Процесс регистрации успешный.
        /// </summary>
        [Test]
        public void T_012_onRegisterClick_BasicFlow()
        {
            // подготовка входных данных
            String login = "myname_doctor";
            String password = "DoctorSuperBest123!";
            String repPassword = "DoctorSuperBest123!";
            // подготовка модуля
            RegisterForm registerForm = new RegisterForm();
            registerForm.controller = new DummyDatabaseController_OK();
            IDoctorEntry doctorEntry = null;
            // Assert для проверки отсутствия выброса исключения
            Assert.DoesNotThrow(() =>
            {
                doctorEntry = registerForm.onRegisterClick(login, password, repPassword);
            });
            // Assert для проверки ожидаемого и полученного значения
            Assert.IsNotNull(doctorEntry);
            Assert.AreEqual(doctorEntry.Login, login);
            Assert.AreEqual(doctorEntry.Password, password);
        }

        /// <summary>
        /// Невозможно подключится к БД.
        /// Нет доступа к базе данных, поэтому не можем зарегистрироваться.
        /// </summary>
        [Test]
        public void T_013_onRegisterClick_NoConnectionDB()
        {
            //подготовка входных данных
            String login = "myname_doctor";
            String password = "DoctorSuperBest123!";
            String repPassword = "DoctorSuperBest123!";
            //ожидаемое значение
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.NoConnectionDB;
            // подготовка модуля
            RegisterForm registerForm = new RegisterForm();
            registerForm.controller = new DummyDatabaseController_NoConnection();
            // Assert для получения исключения
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                registerForm.onRegisterClick(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // Assert для проверки ожидаемого и полученного значения
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// Невозможно подключится к БД.
        /// Нет доступа к базе данных, поэтому не можем зарегистрироваться.
        /// </summary>
        [Test]
        public void T_014_onRegisterClick_LoginAlreadyExists()
        {
            //подготовка данных
            String login = "myname_doctor";
            String password = "DoctorSuperBest123!";
            String repPassword = "DoctorSuperBest123!";
            //ожидаемое значение
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.LoginAlreadyExists;
            // подготовка модуля
            RegisterForm registerForm = new RegisterForm();
            registerForm.controller = new DummyDatabaseController_LoginExists();
            // Assert для получения исключения
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                registerForm.onRegisterClick(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // Assert для проверки ожидаемого и полученного значения
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

    }
}