// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HelloControl.xaml.cs" company="Steria AS">
//   Copyright Steria 2013
// </copyright>
// <summary>
//   Interaction logic for HelloControl.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomControls
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
            InitializeComponent();
        }

        // ReSharper disable once InconsistentNaming
        private void SayHelloButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DisplayHelloTextBox.Text = "Hello world!";
        }
    }
}
