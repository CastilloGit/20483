using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;

namespace _120
{

    /*Pregunta 120
    You need to ensure that xcepten ocurs the exception will be logged
    Which code should you inert at one 287
    */

    public class Program
    {
        private static System.Diagnostics.Stopwatch _execTimer =
            new System.Diagnostics.Stopwatch();
        public static void Delay(int delay)
        {
            Thread.Sleep(delay);
        }
        public static void LogLongExec(string msg)
        {
            if (_execTimer.Elapsed.Seconds >= 5)
                throw new Exception(
                    string.Format("Execution is too long > {0} > {1}",
                    msg, _execTimer.Elapsed.TotalMilliseconds));
        }



        public static void Main()
        {
            _execTimer.Start();
            try
            {
                Delay(10);
                LogLongExec("Delay (100)");
                Delay(5000);
                LogLongExec("Delay(50000)");
            }
            catch (Exception ex)
            {
                using (System.Diagnostics.XmlWriterTraceListener log1 =
                    new XmlWriterTraceListener("./Error.log"))
                {
                    log1.TraceEvent(
                        new TraceEventCache(), ex.Message, TraceEventType.Error, ex.HResult);
                    log1.Flush();
                }
            }
        }

    }
}
/*

Explanation/Reference:

Explanation:

· XmlWriterTraceListener
     Directs tracing or debugging output as XML-encoded data to a TextWriter or to a Stream, such as a
     FileStream.

     Dirige la salida de seguimiento o depuración como datos codificados en XML a TextWriter o Stream, como un
     FileStream.

· TraceListener.TraceEvent Method (TraceEventCache, String, TraceEventType, Int32)
     Writes trace and event information to the listener specific output.
     Escribe una traza con informacion de evento a través de un escuchador de salida.

*/
