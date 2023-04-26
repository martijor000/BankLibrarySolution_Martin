using BankLibrary;

namespace BankLibraryTests
{
    [TestClass]
    public class BankUnitTest
    {
        [TestMethod]
        public void TestBankConstructor_ValidParams()
        {
            string customer = "Jordan";
            double balance = 5000;

            Bank bank = new Bank(customer, balance);

            Assert.AreEqual(customer, bank.Customer);
            Assert.AreEqual(balance, bank.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBankConstructor_InvalidParams()
        {
            string customer = "Jordan";
            double balance = 15000;

            Bank bank = new Bank(customer, balance);

            Assert.AreEqual(customer, bank.Customer);
            Assert.AreEqual(balance, bank.Balance);
        }

        [TestMethod]
        public void TestBankWithdraw_ValidParams()
        {
            string customer = "Jordan";
            double balance = 200;
            double withdraw = 200;

            Bank bank = new Bank(customer, balance);

            Assert.AreEqual(balance - withdraw, bank.Withdraw(withdraw));

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBankWithdraw_InvalidParamsZero()
        {
            string customer = "Jordan";
            double balance = 0;
            double withdraw = 0;

            Bank bank = new Bank(customer, balance);

            Assert.AreEqual(balance - withdraw, bank.Withdraw(withdraw));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBankWithdraw_InvalidParamsOverDraft()
        {
            string customer = "Jordan";
            double balance = 0;
            double withdraw = 200;

            Bank bank = new Bank(customer, balance);

            Assert.AreEqual(balance - withdraw, bank.Withdraw(withdraw));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBankWithdraw_InvalidParamsNegativeWithdraw()
        {
            string customer = "Jordan";
            double balance = 200;
            double withdraw = -200;

            Bank bank = new Bank(customer, balance);

            Assert.AreEqual(balance - withdraw, bank.Withdraw(withdraw));
        }

        [TestMethod]
        public void TestBankWithdraw_AmountOver500()
        {
            string customer = "Jordan";
            double balance = 800;
            double withdraw = 600;

            Bank bank = new Bank(customer, balance);

            Assert.AreEqual(balance - 500, bank.Withdraw(withdraw));
        }



        [TestMethod]
        public void TestBankDeposit_ValidParams()
        {
            string customer = "Jordan";
            double balance = 200;
            double deposit = 200;

            Bank bank = new Bank(customer, balance);

            Assert.AreEqual(balance + deposit, bank.Deposit(deposit));

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBankDeposit_InvalidParams()
        {
            string customer = "Jordan";
            double balance = 0;
            double deposit = 0;

            Bank bank = new Bank(customer, balance);

            Assert.AreEqual(balance + deposit, bank.Deposit(deposit));
        }
    }
}