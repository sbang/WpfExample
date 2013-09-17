// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HelloControlTest.cs" company="Steria AS">
//   Copyright Steria 2013
// </copyright>
// <summary>
//   Defines the HelloControlTest type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomControls
{
    using NUnit.Framework;

    [TestFixture(Description = "Tests for the HelloControl class.")]
    public class HelloControlTest
    {
        [Test(Description = "Verify that creating the control doesn't throw an exception.")]
        public void TestCreateControl()
        {
            var runner = new CrossThreadTestRunner();
            runner.RunInSTA(
              delegate
              {
                  var control = new HelloControl();
                  Assert.AreEqual("TextBox", control.DisplayHelloTextBox.Text);
              });
        }
    }
}
