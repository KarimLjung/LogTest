using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogTest
{
    public class AsyncLogImproved : ILog
    {
        private string path;

        public AsyncLogImproved(string path)
        {
            this.path = path;
        }

        public void StopWithFlush()
        {
            throw new NotImplementedException();
        }

        public void StopWithoutFlush()
        {
            throw new NotImplementedException();
        }

        public void Write(string text)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
               
            }
        }

        //public async Task FileWriteAsync(string filePath, string line, bool append = true)
        //{
        //    using (FileStream stream = new FileStream(filePath, append ? FileMode.Append : FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
        //    using (StreamWriter sw = new StreamWriter(stream))
        //    {
               
        //    }
        //}
    }
}
