using System.Reflection.Metadata;

namespace Wyzwanie_21.Test
{
    public class UserTests
    {

        [Test]
        public void SumOfTwoScoresTest()
        {
            // arrange
            var user = new User("Adam", "1234");
            user.AddScore(5);
            user.AddScore(6);

            // act
            var result = user.Result;
            // assert
            Assert.AreEqual(11, result);
        }

        [Test]
        public void SumOfThreeScoresTest()
        {
            // arrange
            var user = new User("Adam", "1234");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(7);

            // act
            var result = user.Result;
            // assert
            Assert.AreEqual(18, result);
        }
        [Test]
        public void SumOfFourScoresTest()
        {
            // arrange
            var user = new User("Adam", "1234");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(7);
            user.AddScore(-18);

            // act
            var result = user.Result;
            // assert
            Assert.AreEqual(0, result);
        }
    }
}