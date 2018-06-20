using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Model.V23;
using NHapi.Model.V23.Message;
using NHapi.Model.V23.Segment;

namespace nHapiFirstN35
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = @"MSH|^~\&|SENDING|SENDER|RECV|INST|20060228155525||QRY^R02^QRY_R02|1|P|2.3| QRD|20060228155525|R|I||||10^RD&Records&0126|38923^^^^^^^^&INST|||";
            PipeParser parser = new PipeParser();
            IMessage m = parser.Parse(message);
            QRY_R02 qryR02 = m as QRY_R02;
            Console.WriteLine(qryR02.QRD.QueryID.ToString());
        }
    }
}
