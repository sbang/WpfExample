﻿// --------------------------------------------------------------------------------------------------------------------
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
    using System.Windows.Input;

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

        [Test(Description = "Verify that clicking the button .")]
        public void TestClickSayHelloButton()
        {
            var runner = new CrossThreadTestRunner();
            runner.RunInSTA(
              delegate
              {
                  var control = new HelloControl();
                  Assert.AreEqual("TextBox", control.DisplayHelloTextBox.Text);
                  Click(control.SayHelloButton);
                  Assert.AreEqual("Hello world!", control.DisplayHelloTextBox.Text);
              });
        }

        private void Click(Button button)
        {
            var e = new MouseButtonEventArgs(Mouse.PrimaryDevice, 0, MouseButton.Left)
                        {
                            RoutedEvent = UIElement.MouseUpEvent
                        };

            button.RaiseEvent(e);
        }
    }
}
