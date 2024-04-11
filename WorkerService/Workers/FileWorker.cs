using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    public class FileWorker
    {
        private static int _DelaySeconds = 20;
        private DateTime _Current = DateTime.Now;
        private DateTime _Next = DateTime.Now.AddSeconds(_DelaySeconds);

        public void Execute()
        {

            Task.Run(Log);

        }

        private void Log()
        {
            _Current = DateTime.Now;
            if (_Current >= _Next)
            {
                _Next = _Current.AddSeconds(_DelaySeconds);
                string dir = Directory.GetCurrentDirectory() + @"\Log\";

                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                File.Create(dir + DateTime.Now.ToString("HH mm ss") + "File.txt");
            }

        }
    }
}
