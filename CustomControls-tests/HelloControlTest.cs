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
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Controls.Primitives;

    using NUnit.Framework;

    [TestFixture(Description = "Tests for the HelloControl class.")]
    [RequiresSTA]
    public class HelloControlTest
    {
        [Test(Description = "Verify that creating the control doesn't throw an exception.")]
        public void TestCreateControl()
        {
            var control = new HelloControl();
            Assert.AreEqual("TextBox", control.DisplayHelloTextBox.Text);
        }

        [Test(Description = "Verify that clicking the button .")]
        public void TestClickSayHelloButton()
        {
            var control = new HelloControl();
            Assert.AreEqual("TextBox", control.DisplayHelloTextBox.Text);
            Click(control.SayHelloButton);
            Assert.AreEqual("Hello world!", control.DisplayHelloTextBox.Text);
        }

        private void Click(Button button)
        {
            button.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
        }
    }
}
