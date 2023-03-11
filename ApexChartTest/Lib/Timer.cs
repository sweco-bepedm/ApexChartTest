namespace ApexChartTest.Lib
{
    public class Timer
    {
        readonly DateTime t0;
        readonly string unit;
        DateTime tN;
        public Timer(string unit = "seconds")
        {
            t0 = tN = DateTime.Now;
            this.unit = unit;
        }
        public void Elapsed(string name)
        {
            if (unit == "seconds")
                Console.WriteLine(name + " executed in " + (DateTime.Now - tN).TotalSeconds.ToString("0.0 s"));
            else
                Console.WriteLine(name + " executed in " + (DateTime.Now - tN).TotalMilliseconds.ToString("0 ms"));

            tN = DateTime.Now;
        }
        public string End()
        {
            string msg = "Total execution time: " + (DateTime.Now - t0).TotalSeconds.ToString("0.0 s");

            Console.WriteLine(msg);

            return msg;
        }
    }
}
