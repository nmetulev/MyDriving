using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Xamarin.UITest.Android;

namespace MyDriving.UITests.Tests
{
    [TestFixture]
    public class SimpleTest
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            app = ConfigureApp.Android.ApkFile("../../MyDriving.Android/bin/Release/com.microsoft.mydriving-Signed").StartApp();
        }
        
    }
}
