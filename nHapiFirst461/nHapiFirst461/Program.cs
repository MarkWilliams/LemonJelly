using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Base.Log;
using NHapi.Base;

using NHapi.Model.V23;
using NHapi.Model.V23.Message;
using NHapi.Model.V23.Segment;
using NHapi.Model.V23.Group;

namespace nHapiFirst461
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string message = @"MSH|^~\&|SENDING|SENDER|RECV|INST|20060228155525||QRY^R02^QRY_R02|1|P|2.3| QRD|20060228155525|R|I||||10^RD&Records&0126|38923^^^^^^^^&INST|||";
                PipeParser parser = new PipeParser();
                IMessage m = parser.Parse(message);
                QRY_R02 qryR02 = m as QRY_R02;

                Console.WriteLine("Hello ... Trying");

                Console.WriteLine(qryR02.GetStructure("MSH"));
                Console.WriteLine(qryR02.GetStructure("QRD"));

                Console.WriteLine("MSH length = " + qryR02.GetAll("MSH").Length);
                Console.WriteLine("QRD length = " + qryR02.GetAll("QRD").Length);
                // int rep;
                int rep = 0;
                qryR02.GetStructure("MSH", rep);

                Console.WriteLine("" +
                    "REP: " + rep);


            }
            catch (HL7Exception e)
            {
                // string mark = "mark";
                Console.WriteLine("Hello ... Catching");
                // HapiLogFactory.GetHapiLog(qryR02: GetType()).Error("Error message", e);
            }
        }
    }
}
