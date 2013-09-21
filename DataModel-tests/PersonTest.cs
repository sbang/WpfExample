namespace Steria.WpfExample.DataModel
{
    using NUnit.Framework;

    [TestFixture(Description = "Unit tests for the Person class")]
    public class PersonTest
    {
        [Test(Description = "Test the Person.Name property.")]
        public void TestName()
        {
            var person = new Person("Lars", Gender.Male, 20);
            Assert.AreEqual("Lars", person.Name);
            person.Name = "Martin";
            Assert.AreEqual("Martin", person.Name);
            person.Name = null;
            Assert.AreEqual(string.Empty, person.Name, "Expected the property value to be the emtpy string if set to a null");
        }

        [Test(Description = "Test the Person.Gender property.")]
        public void TestGender()
        {
            var person = new Person("Kari", Gender.Male, 19);
            Assert.AreEqual(Gender.Male, person.Gender);
            person.Gender = Gender.Female;
            Assert.AreEqual(Gender.Female, person.Gender);
        }

        [Test(Description = "Test the Person.Age property.")]
        public void Age()
        {
            var person = new Person("Kari", Gender.Female, 10);
            Assert.AreEqual(10, person.Age);
            person.Age = 20;
            Assert.AreEqual(20, person.Age);
            person.Age = -1;
            Assert.AreEqual(0, person.Age);
        }
    }
}
