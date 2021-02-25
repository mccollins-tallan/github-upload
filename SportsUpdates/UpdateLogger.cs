using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SportsUpdates
{
    class UpdateLogger
    {
        private TextWriter file;
        private static UpdateLogger instance = null;

        public static UpdateLogger getInstance()
        {
            if (instance == null)
            {
                instance = new UpdateLogger();
            }
            return instance;
        }

        private UpdateLogger()
        {
            file = TextWriter.Synchronized(new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\log.txt"));
        }

        public void LogUpdate(string update, Publisher p)
        {
            file.WriteLine($"received message \"{update}\" from publisher {p.getSport()}");
            file.Flush();
            Console.WriteLine($"received message \"{update}\" from publisher {p.getSport()}");
        }

        public void LogReception(Subscriber s)
        {
            file.WriteLine($"Subscriber {s.getName()}");
            Console.WriteLine($"Subscriber {s.getName()}");
        }

        public void LogNewSubscription(Publisher p, Subscriber s)
        {
            file.WriteLine($"Subscriber {s.getName()} just subscribed to publisher {p.getSport()}");
        }
    }
}
