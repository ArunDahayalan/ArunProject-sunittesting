using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace interview1.test.Controller
{
    class Homecontroler
    {

        [TestFixture]
        class HomeControllerTest
        {
            private Homecontroler _homeController = null;

            [TestFixtureSetUp]
            public void Setup()
            {
                _homeController = new Homecontroler();
            }

            [TestFixtureTearDown]
            public void TearDown()
            {
            }

            [SetUp]
            public void TestMethodSetup()
            {
                _homeController = new Homecontroler();
            }

            [TearDown]
            public void TestMethodTearDown()
            {
                _homeController = null;
            }

        }
    }
}
