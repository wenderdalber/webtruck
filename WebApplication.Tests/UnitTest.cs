using NUnit.Framework;
using WebApplication.Models;

namespace WebApplication.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void When_Data_Is_Ok_Return_True()
        {
            var repository = new RepositoryTruck();
            var retorno = repository.Add(2021, "2020", 1);
            Assert.Pass();
        }

        [Test]
        public void When_Data_Is_NotOk_Return_False()
        {
            var repository = new RepositoryTruck();
            var retorno = repository.Add(-1, "doismil", 200);
            if(retorno == "error")
            {
                Assert.Fail();
            }
            else
            {
                Assert.Pass();
            }
        }
    }
}