using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int BizRulesDelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            var custs = new List<Customer>
            {
                new Customer { City = "Phoenix", FirstName = "John", LastName = "Doe", ID = 1},
                new Customer { City = "Phoenix", FirstName = "Jane", LastName = "Doe", ID = 500},
                new Customer { City = "Seattle", FirstName = "Suki", LastName = "Pizzoro", ID = 3},
                new Customer { City = "New York City", FirstName = "Michelle", LastName = "Smith", ID = 4},
            };

            var phxCusts = custs
                .Where(c => c.City == "Phoenix" && c.ID < 500)
                .OrderBy(c => c.FirstName);

            foreach (var cust in phxCusts)
            {
                Console.WriteLine(cust.FirstName);
            }

            BizRulesDelegate addDel = (x, y) => x + y;
            BizRulesDelegate mulDel = (x, y) => x * y;
            var data = new ProcessData();
            data.Process(2, 3, mulDel);
            data.Process(2, 3, addDel);

            Action<int, int> myAction = (x, y) => Console.Write(x + y);
            Action<int, int> myMulAction = (x, y) => Console.Write(x * y);
            data.ProcessAction(5, 3, myAction);
            data.ProcessAction(5, 3, myMulAction);

            Func<int, int, int> funcAddDel = (x, y) => x + y;
            Func<int, int, int> funcMulDel = (x, y) => x * y;

            data.ProcessFunc(4, 7, funcAddDel);
            data.ProcessFunc(4, 7, funcMulDel);

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
