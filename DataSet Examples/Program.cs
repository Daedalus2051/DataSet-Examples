using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataSet_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet("myDataSet");
            DataTable t = new DataTable("table1");
            DataColumn c = new DataColumn("myColumnOfData");
            DataColumn c2 = new DataColumn("MoreData");
            t.Columns.Add(c);
            t.Columns.Add(c2);
            ds.Tables.Add(t);

            
            DataRow r;
            for (int i = 0; i < 20; i++)
            {
                r = t.NewRow();
                r[0] = "Data" + i;
                r[1] = "More_data_" + i;
                t.Rows.Add(r);
            }

            Console.WriteLine("The dataset contains the following: ");
            Console.WriteLine("Dataset name: {0}", ds.DataSetName);
            
            int tabcounter = 0, colcounter = 0;
            
            foreach (DataTable tab in ds.Tables)
            {
                tabcounter++;
                Console.WriteLine("Table[{0}] name: {1}", tabcounter, t.TableName);
                foreach(DataColumn col in tab.Columns)
                {
                    colcounter++;
                    Console.WriteLine("\tColumn[{0}] name: {1}", colcounter, col.ColumnName);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Table data:");
            //Headers
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (DataColumn col in ds.Tables[0].Columns)
            {
                Console.Write("[{0}]\t", col.ColumnName);
            } Console.WriteLine("");
            Console.ResetColor();
            /*
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                {
                    Console.Write("{0}\t", row[i]);
                } Console.WriteLine("");
            }
            */
            
            for (int rownum = 0; rownum < ds.Tables[0].Rows.Count; rownum++)
            {
                for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                {
                    DataRow cur_row = ds.Tables[0].Rows[rownum];
                    Console.Write("{0}\t", cur_row[i]);
                } 
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
