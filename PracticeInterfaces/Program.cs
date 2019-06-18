using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterfaces
{
    class Program
    {
        //Fields
        static Engine _engine;
        static Workflow _workflow;

        static Program()
        {
            _engine = new Engine();
            _workflow = new Workflow();
        }

        public static void Main(string[] args)
        {
            _engine.Run(_workflow);
        }
    }

    public class Engine
    {
        public Engine()
        {
            //not used
        }

        public void Run(Workflow workflow)
        {
            foreach(var activity in workflow.GetActivities())
            {
                activity.Execute();
            }
        }
    }

    public class Workflow
    {
        List<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>
            {
                { new SportActivity{Message = "Running..."} },
                { new SportActivity{Message = "Batting..."} },
                { new SportActivity{Message = "Kicking..."} },
                { new SportActivity{Message = "Dribbling..."} },
                { new OutdoorActivity{Message = "Fishing..."} },
                { new OutdoorActivity{Message = "Camping..."} },
                { new OutdoorActivity{Message = "Grilling..."} }
            };
        } 

        public List<IActivity> GetActivities()
        {
            return _activities;
        }
    }
 
    public class SportActivity : IActivity
    {
        public string Message { get; set; }

        public SportActivity()
        {
            //not used
        }

        public void Execute()
        {
            Console.WriteLine("Performing Sport Activity: {0}", Message);
        }
    }

    public class OutdoorActivity : IActivity
    {
        public string Message { get; set; }

        public void Execute()
        {
            Console.WriteLine("Performing Outdoor Activity {0}", Message);
        }
    }

    public interface IActivity
    {
        string Message { get; set; }

        void Execute();
    }
}
