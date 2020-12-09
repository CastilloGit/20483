using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Ejer58
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCounters();
        }

        public static void CreateCounters()
        {
            if (!PerformanceCounterCategory.Exists("Contoso"))
            {
                var counters = new CounterCreationDataCollection();
                var ccdCounter1 = new CounterCreationData
                {
                    CounterName = "Counter1",
                    CounterType = PerformanceCounterType.AverageTimer32
                };
                counters.Add(ccdCounter1);
                try
                {
                    Console.WriteLine("\n\n    A. CounterType = PerformanceCounterType.RawBase");
                    var ccdCounter2 = new CounterCreationData
                    {
                        CounterName = "Counter2",
                        CounterType = PerformanceCounterType.RawBase
                    };
                    counters.Add(ccdCounter2);
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("     El error mostrado es: ", ex);
                }

                try
                {
                    Console.WriteLine("\n\n    B. CounterType = PerformanceCounterType.AverageBase");
                    var ccdCounter2 = new CounterCreationData
                    {
                        CounterName = "Counter2",
                        CounterType = PerformanceCounterType.AverageBase
                    };
                    counters.Add(ccdCounter2);
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("     El error mostrado es: ", ex);
                }

                try
                {
                    Console.WriteLine("\n\n    C. CounterType = PerformanceCounterType.SampleBase");
                    var ccdCounter2 = new CounterCreationData
                    {
                        CounterName = "Counter2",
                        CounterType = PerformanceCounterType.SampleBase
                    };
                    counters.Add(ccdCounter2);
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("     El error mostrado es: ", ex);
                }
                
                try
                {
                    Console.WriteLine("\n\n    D. CounterType = PerformanceCounterType.CounterMultiBase");
                    var ccdCounter2 = new CounterCreationData
                    {
                        CounterName = "Counter2",
                        CounterType = PerformanceCounterType.CounterMultiBase
                    };
                    counters.Add(ccdCounter2);
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("     El error mostrado es: ", ex);
                }                
                PerformanceCounterCategory.Create("Contoso", "Help string",
                PerformanceCounterCategoryType.MultiInstance, counters);
            }
        }
    }
}
