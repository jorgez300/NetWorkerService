namespace Workers
{
    public class LogWorker
    {
        private static int _DelaySeconds = 10;
        private DateTime _Current = DateTime.Now;
        private DateTime _Next = DateTime.Now.AddSeconds(_DelaySeconds);

        public void Execute()
        {

            Task.Run(Log);

        }

        private void Log() {
            _Current = DateTime.Now;
            if (_Current >= _Next)
            {
                _Next = _Current.AddSeconds(_DelaySeconds);
                string dir = Directory.GetCurrentDirectory() + @"\Log\";

                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                File.Create(dir + DateTime.Now.ToString("HH mm ss") + "Log.txt");
            }

        }

    }
}
