using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using vcbmain.Repository;
using vcbmain.Services;

namespace vcbtest.Services
{
    public class BankingRepositoryFake: IBankingRepository
    {
        public double GetLaiSuat(DateTime date)
        {
            return 5d;
        }
    }
    public class BankingServiceTest
    {
        BankingService bankingService;
        public BankingServiceTest()
        {
            //B1
            var mockService = new Mock<IBankingRepository>();
            //B2
            mockService.Setup(m=>m.GetLaiSuat(It.IsAny<DateTime>())).Returns(5d);
            //IBankingRepository bankingRepository =  new BankingRepositoryFake();
            bankingService = new BankingService(mockService.Object);
        }

        [Fact]
        public void Should_return_money_for_3months_priod()
        {
            //Arrange
            int money = 200000000;
            int time = 90;
            double expected = 2465753;

            //Act
            double actual = bankingService.GetOutputMoney(money, time);

            //Assertion
            Assert.Equal(expected, actual);
        }          
    }
}