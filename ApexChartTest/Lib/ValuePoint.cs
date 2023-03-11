namespace ApexChartTest.Lib
{
    public class ValuePoint
    {
        public string Position { get; set; }
        public decimal Value { get; set; }

        public ValuePoint() { }
        public ValuePoint(string position, double value)
        {
            this.Position = position;
            this.Value = Convert.ToDecimal(value);
        }
        public static List<ValuePoint> ReturnEmpty()
        {
            List<ValuePoint> list = new();

            for (int i = 0; i < 7 * 24; i++)
            {
                var point = new ValuePoint()
                {
                    Position = i.ToString(),
                    Value = 0
                };

                list.Add(point);
            }

            return list;
        }
    }
}
