using Wyzwanie_21;

User user1 = new User("Adam", "1234");
User user2 = new User("Monika", "5678");
User user3 = new User("Zuzia", "9012");
User user4 = new User("Damian", "3456");

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine("Użytkownik " + user1.Login + " z liczbą punktów: " +  result);
