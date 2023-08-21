using ChallengeApp;

namespace ChallengeApp
{
    internal class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
           this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);   
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics; //metoda zwraca obiekt z wypełnionymi statystykami (w praktyce jest to referencja).
        }

    }
}
/* Jeżeli chcemy nadpisać referencję co praktycznie nie jest wykorzystywane należy użyć "ref" lub "out". Ref oznacza, że parametr ma już przypisaną wartość w przeciwieństwie do out-a.
 W ref-ie  parametr ma już przypisaną wartość i ta może być odczytana lub zmieniona w funkcji.
  SetSth(ref statistics);
void SetSth(ref Statistics statistics)
{
   // statistiscs = new Statistics();

}

Dla "out musimy od razu nadpisać wartość
 SetSth(out statistics);
void SetSth(out Statistics statistics)
{
statistiscs = new Statistics(); //musimy tutaj nadpisać parametr ponieważ wartość parametru nie jest w oucie przekazywana.
}
*/
