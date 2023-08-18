using System.Reflection.Metadata.Ecma335;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TEST()
        {
            // arrange
            string number1 = "1";
            string number2 = "2";


            // act
            

            // assert
            Assert.AreNotEqual(number1, number2);
        }
        private User GetUser(string name) 
        {
            return new User(name);
        }
    }
}

/*
 namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TEST()
        {
            // arrange
            var user1 = GetUser("Darek");
            var user2 = GetUser("Darek");


            // act
            

            // assert
            Assert.AreEqual(user1.Login, user2.Login);
        }
        private User GetUser(string name) 
        {
            return new User(name);
        }
    }
}

 */
