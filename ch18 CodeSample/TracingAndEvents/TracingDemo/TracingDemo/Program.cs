using System;
using System.Diagnostics;
using System.Threading;

[assembly: Switch("Wrox.ProCSharp.Tracing", typeof(TraceSwitch))]


namespace Wrox.ProCSharp.Tracing
{


    public class Program
    {


        // static TraceSwitch traceSwitch = new TraceSwitch("Wrox.ProCSharp.Tracing", "Sample Trace Switch");
        private static TraceSource trace = new TraceSource("Wrox.ProCSharp.Tracing");

        static void TraceSourceDemo1()
        {

            trace.TraceInformation("Info message");

            trace.TraceEvent(TraceEventType.Error, 3, "Error message");
            trace.TraceData(TraceEventType.Information, 2, "data1", 4, 5);
            trace.Flush();
            trace.Close();

        }

        static void TraceSourceDemo2()
        {

            trace.TraceInformation("Thread Info message");
            trace.TraceEvent(TraceEventType.Error, 3, "Thread Error message");
            trace.TraceData(TraceEventType.Information, 2, "Thread data1", 4, 5);
            trace.Flush();
            trace.Close();

        }


        //    static void TraceSourceDemo()
        //    {
        //       TraceSource source = new TraceSource("Wrox.ProCSharp.Tracing1", SourceLevels.All);
        //       source.TraceInformation("info");
        //       source.TraceEvent(TraceEventType.Error, 33, "error message");

        //    }

        //    static void TraceSwitchDemo()
        //    {
        //       Trace.Indent();

        //       source1.TraceInformation("TraceSwitchDemo enters");
        //       Trace.WriteLineIf(traceSwitch.TraceVerbose, "Verbose message", "Sample Category");
        //       Trace.WriteLineIf(traceSwitch.TraceInfo, "Info message");
        //       Trace.WriteLineIf(traceSwitch.TraceWarning, "Warning message");
        //       Trace.WriteLineIf(traceSwitch.TraceError, "Error message");

        //       source1.TraceInformation("TraceSwitchDemo exits");
        //       source1.TraceEvent(TraceEventType.Error, 33, "TS Error");

        //    }

        //    static void TraceSource1()
        //    {
        //       TraceSource source1 = new TraceSource("Wrox.ProCSharp.Tracing");
        ////       source1.Switch = new SourceSwitch("MySwitch", "Verbose");
        //       source1.TraceInformation("Info message");
        //       source1.TraceEvent(TraceEventType.Error, 3, "Error message");
        //       source1.TraceData(TraceEventType.Information, 2, new int[] { 1, 2, 3 });
        //       source1.Flush();
        //       source1.Close();

        //     //  SourceSwitch sourceSwitch = new SourceSwitch("TracingDemo");

        //    }

        //    static void TraceSource2()
        //    {
        //       TraceSource source2 = new TraceSource("TracingDemo2");
        //       source2.TraceInformation("Info message");
        //       source2.TraceEvent(TraceEventType.Error, 3, "Error message");
        //       source2.TraceData(TraceEventType.Information, 2, new int[] { 1, 2, 3 });
        //       source2.Flush();
        //       source2.Close();   
        //    }

        //    static void Foo(object o)
        //    {
        //       Debug.Assert(o != null, "Expecting an object");
        //       Console.WriteLine(o);
        //    }

        //    static void Bar(int x)
        //    {
        //       Trace.Assert(x > 10 && x < 20, "x should be between 10 and 20");
        //       Console.WriteLine(x);
        //    }

        static void ThreadMethod()
        {
            Trace.CorrelationManager.ActivityId = Guid.NewGuid();
            trace.TraceEvent(TraceEventType.Verbose, 5, "ThreadMethod started");

            trace.TraceEvent(TraceEventType.Verbose, 6, "ThreadMethod ended");
        }

        static void Main()
        {
            Trace.CorrelationManager.ActivityId = Guid.NewGuid();
            trace.TraceEvent(TraceEventType.Verbose, 5, "Main started");
            new Thread(ThreadMethod).Start();
            Trace.CorrelationManager.StartLogicalOperation("Main");

            One();

            trace.TraceEvent(TraceEventType.Verbose, 6, "Main ended");

            Trace.CorrelationManager.StopLogicalOperation();


        }

        private static void One()
        {
            Trace.CorrelationManager.StartLogicalOperation("One");
            trace.TraceEvent(TraceEventType.Verbose, 5, "One started");
            Two();
            Trace.CorrelationManager.StopLogicalOperation();
         }

        private static void Two()
        {
            Trace.CorrelationManager.StartLogicalOperation("Two");
            trace.TraceEvent(TraceEventType.Verbose, 5, "Two started");
            Trace.CorrelationManager.StopLogicalOperation();

        }
    }
}
