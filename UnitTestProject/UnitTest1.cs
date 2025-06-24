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
        [Test]
        public void T_001_СheckDoctorData_BaseFlow()
        {
            // подготовка входных данных модуля
            String login = "myname_doctor";
            String password = "DoctorSuperBest123!";
            String repPassword = "DoctorSuperBest123!";
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
            String expectedExceptionMessage = "Логин не может быть пустым.";
            // assert для получения исключения
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert для проверки ожидаемого и полученного значения
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }
    }
}