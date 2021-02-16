using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
   public class Starter
    {
        public Logger Logger { get; set; }

        public void Run()
        {
            Random random = new Random();
            Result result = new Result();
            Logger = Logger.GetInstance();

            for (int i = 0; i < 100; i++)
            {
                int value = random.Next(1, 4);
                switch (value)
                {
                    case 1:
                        result = Action.StartMethod();
                        break;
                    case 2:
                        result = Action.SkippedLogic();
                        break;
                    case 3:
                        result = Action.BrokeLogic();
                        Logger.Save(result);
                        break;
                    default:
                        result = Action.BrokeLogic();
                        Logger.Save(result);
                        break;
                }

                Logger.Display(result);
            }

            Logger.FileSave();
        }
    }
}
