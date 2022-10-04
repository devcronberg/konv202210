namespace FejlHåndtering
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string a = null;
            //Console.WriteLine(a.ToUpper());

            try
            {
                //int res = LægSammen(-5, 5);
                //Console.WriteLine(res);

                int tal = HentTalFraFil(@"c:\temp\tal.txt");
                Console.WriteLine(tal);
            }
            catch (Exception ex)
            {

                // log
                //if(ex.InnerException!=null)
                //    Console.WriteLine(ex.InnerException.Message);
                //Console.WriteLine(ex.Message);                
                Console.WriteLine(ex.ToString());
            }


        }

        private static int HentTalFraFil(string sti)
        {
            try
            {
                string talSomStreng = System.IO.File.ReadAllText(sti);
                int tal = Convert.ToInt32(talSomStreng);
                return tal;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Kan ikke konvertere tal fra {sti}", ex);
            }
        }

        static int LægSammen(int a, int b) 
        {
            if (a < 0 || b < 0)
            {
                //ApplicationException ex = new ApplicationException("Forkert ....");
                //ArgumentException ex = new ArgumentException("Forkert... ");
                //throw ex;
                throw new ArgumentException("Forkert.... ");
            }

            return a + b;
        }


        static void A() { 
            B();
        }
        static void B() {
            File.ReadAllText(@"c:\temp\sdfsd.txt");
        }
    }
}