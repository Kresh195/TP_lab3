using System;
using Lab3;

namespace UnitTestProject
{
    public class Tests
    {
        /// <summary>
        /// ���������� ������ ��� �heckDoctorData.
        /// � ������� �������� ������ ������ � �������, ��������������� �����������.
        /// </summary>
        [Test]
        public void T_001_�heckDoctorData_BaseFlow()
        {
            // ���������� ������� ������ ������
            String login = "myname_doctor";
            String password = "DoctorSuperBest123!";
            String repPassword = "DoctorSuperBest123!";
            // ��������� ��������
            bool expectedReturnValue = true;
            //���������� ���������� ��� ������������� ��������
            bool actualReturnValue = false;
            // assert ��� �������� ���������� ����������
            Assert.DoesNotThrow(() =>
            { // ����� ������
                actualReturnValue = RegisterForm.checkDoctorData(login, password, repPassword);
            });
            // assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedReturnValue, actualReturnValue);
        }

        /// <summary>
        /// ������ �����.
        /// ������������ ������� ���� ����� ������ ������.
        /// </summary>
        [Test]
        public void T_002_�heckDoctorData_EmptyLogin()
        {
            //���������� ������� ������
            String login = "";
            String password = "DoctorSuperBest123!";
            String repPassword = "DoctorSuperBest123!";
            // ��������� ��������
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.EmptyLogin;
            // assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// ������ ������ ������.
        /// ������������ ������� ������ ���� ����� ������ ������.
        /// </summary>
        [Test]
        public void T_003_�heckDoctorData_EmptyPassword1()
        {
            //���������� ������� ������
            String login = "myname_doctor";
            String password = "";
            String repPassword = "DoctorSuperBest123!";
            // ��������� ��������
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.EmptyPassword1;
            // assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// ������ ������ ������.
        /// ������������ ������� ������ ���� ����� ������ ������.
        /// </summary>
        [Test]
        public void T_004_�heckDoctorData_EmptyPassword2()
        {
            //���������� ������� ������
            String login = "myname_doctor";
            String password = "DoctorSuperBest123!";
            String repPassword = "";
            // ��������� ��������
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.EmptyPassword2;
            // assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// ������ ����������.
        /// ������������ ��� ������������ ������.
        /// </summary>
        [Test]
        public void T_005_�heckDoctorData_DifferentPasswords()
        {
            //���������� ������� ������
            String login = "myname_doctor";
            String password = "DoctorSuperBest123!";
            String repPassword = "DoctorBest321!";
            // ��������� ��������
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.DifferentPasswords;
            // assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// ����� � ������ ���������.
        /// ������������ ��� ���������� ����� � ������.
        /// </summary>
        [Test]
        public void T_006_�heckDoctorData_SameLoginPassword()
        {
            //���������� ������� ������
            String login = "myname_doctor";
            String password = "myname_doctor";
            String repPassword = "myname_doctor";
            // ��������� ��������
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.SameLoginPassword;
            // assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// ������ ����� 10 ��������.
        /// ������������ ��� ������� �������� ������ (������ 10 ����.).
        /// </summary>
        [Test]
        public void T_007_�heckDoctorData_PasswordLess10Chars()
        {
            //���������� ������� ������
            String login = "myname_doctor";
            String password = "Doc123!";
            String repPassword = "Doc123!";
            // ��������� ��������
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.PasswordLess10Chars;
            // assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// ������ �� �������� ����.
        /// ������������ ��� ������, �� ���������� �����.
        /// </summary>
        [Test]
        public void T_008_�heckDoctorData_PasswordNoNumber()
        {
            //���������� ������� ������
            String login = "myname_doctor";
            String password = "DoctorSuperBest!";
            String repPassword = "DoctorSuperBest!";
            // ��������� ��������
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.PasswordNoNumber;
            // assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// ������ ��� �����������.
        /// ������������ ��� ������, �� ���������� ���������� ("@#$%^&*!").
        /// </summary>
        [Test]
        public void T_009_�heckDoctorData_PasswordNoExtraChar()
        {
            //���������� ������� ������
            String login = "myname_doctor";
            String password = "DoctorSuperBest123";
            String repPassword = "DoctorSuperBest123";
            // ��������� ��������
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.PasswordNoExtraChar;
            // assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// ������ �� �������� ����� � ������� ��������.
        /// ������������ ��� ������, �� ���������� ���� � ������� ��������.
        /// </summary>
        [Test]
        public void T_010_�heckDoctorData_PasswordNoUpperChar()
        {
            //���������� ������� ������
            String login = "myname_doctor";
            String password = "doctorsuperbest123!";
            String repPassword = "doctorsuperbest123!";
            // ��������� ��������
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.PasswordNoUpperChar;
            // assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// ����������� ������ ������.
        /// ����� �������� ����������� �������.
        /// </summary>
        [Test]
        public void T_011_�heckDoctorData_LoginForbidden()
        {
            //���������� ������� ������
            String login = "myname_doctor!";
            String password = "DoctorSuperBest123!";
            String repPassword = "DoctorSuperBest123!";
            // ��������� ��������
            String expectedExceptionMessage = RegisterForm.ExceptionStrings.LoginForbidden;
            // assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            // assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }
    }
}