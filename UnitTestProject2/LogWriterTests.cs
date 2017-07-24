using LogTest;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using Xunit;

namespace UnitTestProject2
{
    public class LogWriterTests
    {
        private ILog asyncLogger;
        private string logPath = "C:\\LogTest";

        [Fact]
        private void TestAsyncLog()
        {
            Given_An_AsyncLog_With_Flush();
            When_AsyncLog_With_Flush_Writes();
            Then_AsyncLog_With_Flush_Is_Valid();

        }

        public static FileInfo GetNewestFile(DirectoryInfo directory)
        {
            var latestFile =
            directory.GetFiles("*", SearchOption.AllDirectories)
                .OrderByDescending(f => (f == null ? DateTime.MinValue : f.LastWriteTime))
                .FirstOrDefault();

            return latestFile;
        }

        private void Given_A_StreamWriter()
        {
            var file = GetNewestFile(new DirectoryInfo(logPath));

            using (StreamReader reader = new StreamReader(Path.GetFullPath(file.FullName)))
            {
                
            }
        }

        private void Then_AsyncLog_With_Flush_Is_Valid()
        {
            throw new NotImplementedException();
        }

        private void When_AsyncLog_With_Flush_Writes()
        {
            WriteNEntriesToLog(15, asyncLogger);
        }

        private void Given_An_AsyncLog_With_Flush()
        {
            asyncLogger = new AsyncLog();
        }

        private void WriteNEntriesToLog(int n, ILog logger)
        {
            for (int i = 0; i < n; i++)
            {
                logger.Write("Number with Flush: " + i.ToString());
                Thread.Sleep(50);
            }
            logger.StopWithFlush();
        }
    }
}
