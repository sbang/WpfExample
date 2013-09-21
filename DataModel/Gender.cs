// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Gender.cs" company="Steria AS">
//   Copyright Steria 2013
// </copyright>
// <summary>
//   Defines the Gender type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Steria.WpfExample.DataModel
{
    /// <summary>
    /// Enumeration defining the gender of a <see cref="Person"/> object.
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// The default value of the enumeration.
        /// </summary>
        Undefined,

        /// <summary>
        /// The gender of a male <see cref="Person"/>.
        /// </summary>
        Male,

        /// <summary>
        /// The gender of a female <see cref="Person"/>.
        /// </summary>
        Female
    }
}