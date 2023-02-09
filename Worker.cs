namespace ClassLibrary6
{
    public abstract class Worker 
    {
        protected int hours { get; set; }
        protected int tasks { get; set; }
        protected int pay { get; set; }

        public abstract int Calc();
    }
}
