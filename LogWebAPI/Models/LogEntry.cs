using System;

namespace LogWebAPI.Models
{
    public class LogEntry{

        public string Message { get; set; }
        public DateTime MyProperty { get; set; }
        public object[] ExtraInfo { get; set; }
        public LogLevel Level {get;set;}
    }
}