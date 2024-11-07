using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid5
{
    public class MyService
    {
        private ILogger logger;

        public MyService(ILogger logger)
        {
            this.logger = logger;
        }

        public void DoWork()
        {
            logger.Log("Выполняется работа в MyService.");
        }
    }

}
