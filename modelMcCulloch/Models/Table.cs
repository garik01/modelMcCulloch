using System.Collections.Generic;

namespace modelMcCulloch.Models
{
    class Table
    {
        public int experience { get; set; }
        public double x1 { get; set; }
        public double w1 { get; set; }
        public double x2 { get; set; }
        public double w2 { get; set; }
        public double x3 { get; set; }
        public double w3 { get; set; }
        public double u { get; set; }
        public double y { get; set; }
        public double d { get; set; }

        public static List<Table> getDebugData()
        {
            List<Table> table = new List<Table>();

            table.Add(new Table() { experience = 1, x1 = 0, w1 = 1, x2 = 0, w2 = 0, x3 = 0, w3 = 0, d = 0});
            table.Add(new Table() { experience = 2, x1 = 0, w1 = 1, x2 = 0, w2 = 0, x3 = 1, w3 = 0, d = 1 });
            table.Add(new Table() { experience = 3, x1 = 0, w1 = 1, x2 = 1, w2 = 0, x3 = 0, w3 = 0, d = 1 });
            table.Add(new Table() { experience = 4, x1 = 0, w1 = 1, x2 = 1, w2 = 0, x3 = 1, w3 = 0, d = 1 });
            table.Add(new Table() { experience = 5, x1 = 1, w1 = 1, x2 = 0, w2 = 0, x3 = 0, w3 = 0, d = 1 });
            table.Add(new Table() { experience = 6, x1 = 1, w1 = 1, x2 = 0, w2 = 0, x3 = 1, w3 = 0, d = 1 });
            table.Add(new Table() { experience = 7, x1 = 1, w1 = 1, x2 = 1, w2 = 0, x3 = 0, w3 = 0, d = 1 });
            table.Add(new Table() { experience = 8, x1 = 1, w1 = 1, x2 = 1, w2 = 0, x3 = 1, w3 = 0, d = 1 });

            return table;
        }
    }
}
