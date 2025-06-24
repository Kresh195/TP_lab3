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
            String expectedExceptionMessage = "����� �� ����� ���� ������.";
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