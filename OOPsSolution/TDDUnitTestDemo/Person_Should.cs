using FluentAssertions;
using OOPsReview;

namespace TDDUnitTestDemo
{
    public class Person_Should
    {
        // Attribute title
        // Fact, which does one test and is usually set up and coded within the test
        // Theory, which allows for multiple test data streams to be applied to the same test
        [Fact]
        public void Create_An_Instance_With_First_And_Last_Name()
        {
            // Arrange area (set up)
            string firstName = "Don",
                   lastName = "Welch";

            // Act area (execution) --> SUT, subject under test
            Person sut = new Person(firstName, lastName);

            // Assert (testing of the action)
            sut.FirstName.Should().Be(firstName);
            sut.FirstName.Should().Be(lastName);
        }
    }
}