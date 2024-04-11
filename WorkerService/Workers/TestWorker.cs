using System.ComponentModel;

namespace Workers
{
    public class TestWorker
    {

        public void Log()
        {
            string dir = Directory.GetCurrentDirectory() + @"\Log\";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            File.Create(dir + DateTime.Now.ToString("HHmmss") + ".txt");

        }

    }
}
