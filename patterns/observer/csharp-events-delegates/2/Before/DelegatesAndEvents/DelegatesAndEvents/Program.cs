using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{

    class Program
    {
        static void Main(string[] args)
        {
            //var del1 = new WorkPerformedHandler(WorkPerformed1);
            //var del2 = new WorkPerformedHandler(WorkPerformed2);
            //var del3 = new WorkPerformedHandler(WorkPerformed3);

            //del1 += del2 + del3;
            //int finalHours = del1(10, WorkType.GenerateReports);
            //Console.WriteLine(finalHours);

            var worker = new Worker();
            //worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(Worker_WorkPerformed);
            //worker.WorkCompleted += new EventHandler(Worker_WorkCompleted);
            //worker.WorkPerformed += Worker_WorkPerformed;
            //worker.WorkPerformed += delegate (object sender, WorkPerformedEventArgs e)
            //{
            //    Console.WriteLine(e.Hours + " " + e.WorkType);
            //};
            worker.WorkPerformed += (s, e) => Console.WriteLine(e.Hours + " " + e.WorkType);
            //worker.WorkCompleted += Worker_WorkCompleted;
            worker.WorkCompleted += (s, e) => Console.WriteLine("Work is completed");
            worker.DoWork(8, WorkType.GenerateReports);
            Console.ReadLine();
        }

        //private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        //{
        //    Console.WriteLine(e.Hours + " " + e.WorkType);
        //}
        //private static void Worker_WorkCompleted(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Work is done");
        //}
        //static void DoWork(WorkPerformedHandler del)
        //{
        //    del(5, WorkType.GoToMeetings);
        //}

        //static int WorkPerformed1(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed1 called " + hours.ToString());
        //    return hours + 1;
        //}

        //static int WorkPerformed2(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed2 called " + hours.ToString());
        //    return hours + 2;
        //}

        //static int WorkPerformed3(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed3 called " + hours.ToString());
        //    return hours + 3;
        //}
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
