// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WrappedDataGridControlTest.cs" company="Steria AS">
//   Copyright Steria 2013
// </copyright>
// <summary>
//   Defines the WrappedDataGridControlTest type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomControls
{
    using NUnit.Framework;

    [TestFixture(Description = "Tests for the WrappedDataGridControl class.")]
    [RequiresSTA]
    public class WrappedDataGridControlTest
    {
        [Test(Description = "The basic test: try to create a WrappedDataGridControl without it blowing up.")]
        public void TestContstructor()
        {
            var control = new WrappedDataGridControl();
            Assert.IsNull(control);
        }
    }
}
