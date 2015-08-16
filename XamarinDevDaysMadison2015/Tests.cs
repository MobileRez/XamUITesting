using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace LoginWithMasterDetail.UITest
{
    [TestFixture (Platform.Android)] //supports android for testing
    [TestFixture (Platform.iOS)]// supports ios for testing
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests (Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest ()
        {
            app = AppInitializer.StartApp (platform);
        }

        [Test]
        public void AppLaunches ()
        {
            app.Screenshot ("First screen.");
        }

        [Test]
        public void EnterAcctInfo()
        {
            app.EnterText ("Email", "test@test.com");
            app.Screenshot ("Enterd Email)");

            app.PressEnter ();
            app.EnterText ("Password", "1234567890");
            app.Screenshot ("Entered Password");
        }
    }
}