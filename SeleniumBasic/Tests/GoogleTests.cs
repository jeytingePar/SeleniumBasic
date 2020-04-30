using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumBasic
{
    class GoogleTests : SeleniumTestBase
    {
        GooglePage googlePage;

        [OneTimeSetUp]
        public void SetupOnce()
        {
            googlePage = new GooglePage(driver);
        }

        [Test]
        public void SearchForNothing()
        {
            //arrange
            googlePage.GoToPage();

            //act
            googlePage.SearchFor("nothing");            

            //assert
            Assert.IsTrue(googlePage.IsOnResultsPage());
        }
    }
}
