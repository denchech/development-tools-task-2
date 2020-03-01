using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DevToolsProject
{
    [DataContract]
    class Answer
    {
        [DataMember]
        public double Value { get; private set; }
        [DataMember]
        public String Date { get; private set; }

        public Answer(double value)
        {
            Value = value;
            Date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

    }
}
