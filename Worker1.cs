namespace ClassLibrary6
{
    public class Worker1 : Worker
    {
      public Worker1(int Hours)
        {
            hours = Hours;
        }
        public override int Calc() {
            pay = hours* 100;
            return pay;
        }
 }
}

