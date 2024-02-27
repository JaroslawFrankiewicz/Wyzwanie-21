namespace Wyzwanie_21.Test
{
    public class TypeTests
    {
        [Test]
        public void GetUserShouldReturnDifferentObject()
        {
            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            // act


            // assert
            Assert.AreNotEqual(user1, user2);

        }

        [Test]
        public void TwoIntTest()
        {
            // arrange
            var user1 = GetUser("Adam");
            user1.AddScore(5);
            user1.AddScore(6);

            var user2 = GetUser("Monika");
            user2.AddScore(6);
            user2.AddScore(4);

            // act
            int score1 = user1.Result / 2;
            int score2 = user2.Result / 2;
            // assert
            Assert.AreEqual(score1, score2);
        }

        [Test]
        public void TwoStringTest()
        {
            // arrange
            string name1 = "Adam";
            string name2 = "Monika";

            // act

            // assert
            Assert.AreNotEqual(name1, name2);
        }

        [Test]
        public void TwoFloatTest()
        {
            // arrange
            var user1 = new User("Adam");
            user1.AddScore(5);
            user1.AddScore(6);

            var user2 = new User("Monika");
            user2.AddScore(8);
            user2.AddScore(3);

            // act
            float average1 = user1.Result / 2;
            float average2 = user2.Result / 2;

            // assert
            Assert.AreEqual(average1, average2);
        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
