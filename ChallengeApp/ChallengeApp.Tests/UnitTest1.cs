namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScores_ThenReturnCorrectResult()
        {
            // arrange
            var user = new User("Adam", "Password123");
            user.AddScore(5);
            user.AddScore(6);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(11, result);
        }
       
    }
}