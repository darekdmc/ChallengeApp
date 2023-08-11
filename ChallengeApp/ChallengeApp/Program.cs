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
//Listy
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