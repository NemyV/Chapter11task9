using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Chapter11task9
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int workingdays1 = 0;

            Console.Write("Enter end date (YYYY/MM/DD): ");
            DateTime endDate = System.Convert.ToDateTime(Console.ReadLine());
            DateTime now = DateTime.Now;

            string stendDate = endDate.Year.ToString();
            string currentyear = now.Year.ToString();
            string currentday = now.Day.ToString();
            string currentmonth = now.Month.ToString();
            Int32.Parse(currentyear);
            Console.WriteLine(currentday+currentmonth);
            int o = Int32.Parse(stendDate);
            int k = Int32.Parse(currentyear);


            Console.WriteLine(o+"     "+k);
            for (int i = k; i < o; i++)
            {

                DateTime[] holidays = new DateTime[]
                {

                  new DateTime(i, 01, 01),
                  new DateTime(i, 01, 02),
                  new DateTime(i, 03, 02),
                  new DateTime(i, 03, 03),
                  new DateTime(i, 04, 10),
                  new DateTime(i, 04, 13),
                  new DateTime(i, 05, 01),
                  new DateTime(i, 05, 06),
                  new DateTime(i, 09, 21),
                  new DateTime(i, 09, 22),
                  new DateTime(i, 12, 24),
                  new DateTime(i, 12, 25),

                };


                DateTime[] workSaturdays = new DateTime[]
                {
                new DateTime(i, 01, 24),
                new DateTime(i, 03, 21),
                new DateTime(i, 09, 12),
                new DateTime(i, 12, 12),
                };

                int workingDays = 0;

                int x = i + 1;



                DateTime endDate1 = System.Convert.ToDateTime(i  + "/" + currentmonth + "/" + currentday);
                DateTime endDate2 = System.Convert.ToDateTime(x + "/01" + "/01");
                DateTime endDate3 = System.Convert.ToDateTime(i + "/01" + "/01");

                Console.WriteLine(endDate1);
                Console.WriteLine(endDate2);
                Console.WriteLine(now);
                if (i==k)
                {

                
                    do
                    {
                        endDate1 = endDate1.AddDays(1);

                        if ((endDate1.DayOfWeek >= DayOfWeek.Monday) && (endDate1.DayOfWeek <= DayOfWeek.Friday))
                            workingDays++;

                        foreach (var y in holidays)
                            if (y.Date == endDate1.Date)
                                workingDays--;

                        foreach (var y in workSaturdays)
                            if (y.Date == endDate1.Date)
                                workingDays++;

                    } while (endDate1.Date != endDate2.Date);

                }
                else
                {
                    do
                    {
                        endDate3 = endDate3.AddDays(1);

                        if ((endDate3.DayOfWeek >= DayOfWeek.Monday) && (endDate3.DayOfWeek <= DayOfWeek.Friday))
                            workingDays++;

                        foreach (var y in holidays)
                            if (y.Date == endDate3.Date)
                                workingDays--;

                        foreach (var y in workSaturdays)
                            if (y.Date == endDate3.Date)
                                workingDays++;

                    } while (endDate3.Date != endDate2.Date);
                }


                workingdays1 += workingDays;
                Console.WriteLine("{0} working days.", workingDays);
                
            }
            Console.WriteLine("Total working days: "+workingdays1);
        }
    }
    

}




    
