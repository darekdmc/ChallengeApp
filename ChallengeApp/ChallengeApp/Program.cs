using ChallengeApp;

int[] grades = new int[5];
/*string[] dayOfWeeks = new string[7];
dayOfWeeks[0] = "poniedziałek";
dayOfWeeks[1] = "wtorek";
dayOfWeeks[2] = "środa";
dayOfWeeks[3] = "czwartek";
dayOfWeeks[4] = "piątek";
dayOfWeeks[5] = "sobota";
dayOfWeeks[6] = "niedziela"; */
// Console.WriteLine(dayOfWeeks[2]);

string[] dayOfWeeks2 = { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };
//Console.WriteLine(dayOfWeeks2[0]);

/* for(int i = 0; i < 10; i=i+1) można też i=i+2 aby pobrać dni parzyste
{
    Console.WriteLine(i);
}

for (var i = 0; i < dayOfWeeks2.Length; i++)
{
    Console.WriteLine(dayOfWeeks2[i]);
}
*/
//Listy ---------------------------------------------------------------------
List<string> dayOfWeeks3 = new List<string>();
dayOfWeeks3.Add("poniedziałek");
dayOfWeeks3.Add("wtorek");
dayOfWeeks3.Add("środa");
dayOfWeeks3.Add("czwartek");
dayOfWeeks3.Add("piątek");
dayOfWeeks3.Add("sobota");
dayOfWeeks3.Add("niedziela");

for (var i = 0; i < dayOfWeeks3.Count; i++)
{
    Console.WriteLine(dayOfWeeks3[i]);
}

foreach (var day in dayOfWeeks3)
{ 
    Console.WriteLine(day); 
}

// Klasy -----------------------------------------------------------------------
/*
User user1 = new User();
User user2 = new User("Monika", "Hasło123");
User user3 = new User("Zuzia");
User user4 = new User("Damian");

class User
{
    private string login;
    private string password;
    private string name;

    public User()
    {
        this.login = "-";
        this.password = "-";
        this.name = "-";
    }
    public User(string login)
    {
        this.login = login;
        this.password = "-";
        this.name = "-";

    }
    public User(string login, string password)
    {
        this.login = login;
        this.password = password;
        this.name = "-";
    }
}
*/
/*
User user1 = new User("Darek", "Hasło123");
User user2 = new User("Monika", "Hasło123");
User user3 = new User("Zuzia", "Hasło123");
User user4 = new User("Damian", "Hasło123");

// user1.Login = "Marek"; set jest private i to nie zadziała
var name = user1.Login;

user1.AddScore(5);

class User
{
    private int score;
 

    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
        this.score = 0;
    } 
    
    public string Login { get; private set; }

    public string Password { get; private set; }

    public void AddScore(int number)
    {
        this.score +=number;
        //this.score = this.score + number;
    }
}
*/
/*
User user1 = new User();
User user2 = new User("Monika", "Hasło123");
User user3 = new User("Zuzia");
User user4 = new User("Damian");

class User
{
    private string login;
    private string password;
    private string name;

    public User()
    {
        this.login = "-";
        this.password = "-";
        this.name = "-";
    }
    public User(string login)
    {
        this.login = login;
        this.password = "-";
        this.name = "-";

    }
    public User(string login, string password)
    {
        this.login = login;
        this.password = password;
        this.name = "-";
    }
}
*/

// !!!!!! using ChallengeApp; !!!!!!!!!!! na samej górze !!!!!!!!!!!!!!!!!!!!!!

User user1 = new User("Darek", "Hasło123");
User user2 = new User("Monika", "Hasło123");
User user3 = new User("Zuzia", "Hasło123");
User user4 = new User("Damian", "Hasło123");


//var name = user1.Login;

user1.AddScore(5);
user1.AddScore(2);

var result = user1.Result;
Console.WriteLine(result);
/*
var name = User.GameName;
var pi = Math.PI;
class User
{
    public static string GameName = "Diablo"; // jak static to nie this
    private List<int> score = new List<int>();

    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
    } 
    
    public string Login { get; private set; }

    public string Password { get; private set; }


    public int Result
    {
        get 
        {
            return this.score.Sum();
        } 
    }

    public void AddScore(int number)
    {
        this.score.Add(number);
        
    }
} */