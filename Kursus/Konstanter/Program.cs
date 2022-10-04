using Konstanter;

//double momsPct = .25;
const double momsPct = .25;

const int MAND = 1;


//int personKøn = 0;      // 0 = mand, 1 = kvinde
Køn personKøn = Køn.Mand;

Console.WriteLine(personKøn);
Console.WriteLine(Convert.ToInt32(personKøn));


switch (personKøn)
{
    case Køn.Mand:


        break;
    case Køn.Kvinde:


        break;
    default:
        break;
}

DayOfWeek dag = DayOfWeek.Sunday;
switch (dag)
{
    case DayOfWeek.Sunday:
        break;
    case DayOfWeek.Monday:
        break;
    case DayOfWeek.Tuesday:
        break;
    case DayOfWeek.Wednesday:
        break;
    case DayOfWeek.Thursday:
        break;
    case DayOfWeek.Friday:
        break;
    case DayOfWeek.Saturday:
        break;
    default:
        break;
}

TestPerson(10, Køn.Kvinde);
Køn res = ErPerson(10);
if (res == Køn.Kvinde) { } else { }

//[Obsolete("Denne metode må ikke....", error:true)]
void TestPerson(int alder, Køn køn) { 

}

Køn ErPerson(int alder) {
    return Køn.Mand;
}

namespace Konstanter
{
    // relaterede konstanter
    public enum Køn
    {
        Mand,
        Kvinde
    }

    class Person
    {
        public string Navn;
        public int Alder;
        public Køn Køn;

        public Person()
        {

        }
    }

}