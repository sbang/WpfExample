// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Person.cs" company="Steria AS">
//   Copyright Steria 2013
// </copyright>
// <summary>
//   Defines the Person type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Steria.WpfExample.DataModel
{
    /// <summary>
    /// A data structure holding information about a person.
    /// </summary>
    public class Person
    {
        private string name;

        private int age;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="name">
        /// The name of the person.
        /// </param>
        /// <param name="gender">
        /// The gender of the person.
        /// </param>
        /// <param name="age">
        /// The age of the person.
        /// </param>
        public Person(string name, Gender gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }

        /// <summary>
        /// Gets or sets the name of a person.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value != this.name)
                {
                    this.name = value ?? string.Empty;
                }
            }
        }

        /// <summary>
        /// Gets or sets the gender of a person.
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets or sets the age of a person.
        /// </summary>
        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value != this.age)
                {
                    this.age = value < 0 ? 0 : value;
                }
            }
        }
    }
}