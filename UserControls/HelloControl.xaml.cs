// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HelloControl.xaml.cs" company="Steria AS">
//   Copyright Steria 2013
// </copyright>
// <summary>
//   Interaction logic for HelloControl.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Steria.WpfExample.CustomControls
{
    /// <summary>
    /// Interaction logic for HelloControl.xaml
    /// </summary>
    public partial class HelloControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HelloControl"/> class.
        /// </summary>
        public HelloControl()
        {
            this.InitializeComponent();
        }

        // ReSharper disable once InconsistentNaming
        private void SayHelloButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.DisplayHelloTextBox.Text = "Hello world!";
        }
    }
}
