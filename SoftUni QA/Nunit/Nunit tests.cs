using NUnit.Framework;
using System;

namespace Bank.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount account;

        [SetUp]
        public void TestInit()
        {
            this.account = new BankAccount(2000M);
        }

        [Test]
        public void AcountInitializeWithPositiveValue()
        {
            Assert.AreEqual(2000M, account.Amount);
        }


        [Test]

        public void ShouldNOTWithdrawMoreMoneyThanAvailable()
        {
            account.Withdraw(2100);
            Assert.Throws<ArgumentException>(() => account.Withdraw(2100));
        }

        [Test]

        public void ShouldWithdrawMoreThanThousand()
        {
            account.Withdraw(1500);
            Assert.AreEqual(470, account.Amount,);
        }

        [Test]

        public void ShouldWithdrawLessThanThousand()
        {
            account.Withdraw(500);
            Assert.AreEqual(1475, account.Amount;
        }

        [Test]

        public void ShouldCheckIfAccountIsEqaulToDepositedMoney()
        {
            account.Deposit(3000);
            Assert.That(account.Amount, Is.EqualTo(5000), “Amount value”);
        }




