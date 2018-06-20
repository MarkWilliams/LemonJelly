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

using NHapi.Model.V24;
using NHapi.Model.V24.Segment;
using NHapi.Model.V24.Group;
using NHapi.Model.V24.Message;

using NHapi.Model.V25;
using NHapi.Model.V25.Message;
using NHapi.Model.V25.Segment;
using NHapi.Model.V25.Group;

namespace nHapiFirst461
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //String v25message = "MSH|^~\\&|ULTRA|TML|OLIS|OLIS|200905011130||ORU^R01|20169838-v25|T|2.5\r"
                //+ "PID|||7005728^^^TML^MR||TEST^RACHEL^DIAMOND||19310313|F|||200 ANYWHERE ST^^TORONTO^ON^M6G 2T9||(416)888-8888||||||1014071185^KR\r"
                //+ "PV1|1||OLIS||||OLIST^BLAKE^DONALD^THOR^^^^^921379^^^^OLIST\r"
                //+ "ORC|RE||T09-100442-RET-0^^OLIS_Site_ID^ISO|||||||||OLIST^BLAKE^DONALD^THOR^^^^L^921379\r"
                //+ "OBR|0||T09-100442-RET-0^^OLIS_Site_ID^ISO|RET^RETICULOCYTE COUNT^HL79901 literal|||200905011106|||||||200905011106||OLIST^BLAKE^DONALD^THOR^^^^L^921379||7870279|7870279|T09-100442|MOHLTC|200905011130||B7|F||1^^^200905011106^^R\r"
                //+ "OBX|1|ST|||Test Value";
                            
                //String v24message = "MSH|^~\\&|ULTRA|TML|OLIS|OLIS|200905011130||ORU^R01|20169838-v24|T|2.4\r"
                //+ "PID|||7005728^^^TML^MR||TEST^RACHEL^DIAMOND||19310313|F|||200 ANYWHERE ST^^TORONTO^ON^M6G 2T9||(416)888-8888||||||1014071185^KR\r"
                //+ "PV1|1||OLIS||||OLIST^BLAKE^DONALD^THOR^^^^^921379^^^^OLIST\r"
                //+ "ORC|RE||T09-100442-RET-0^^OLIS_Site_ID^ISO|||||||||OLIST^BLAKE^DONALD^THOR^^^^L^921379\r"
                //+ "OBR|0||T09-100442-RET-0^^OLIS_Site_ID^ISO|RET^RETICULOCYTE COUNT^HL79901 literal|||200905011106|||||||200905011106||OLIST^BLAKE^DONALD^THOR^^^^L^921379||7870279|7870279|T09-100442|MOHLTC|200905011130||B7|F||1^^^200905011106^^R\r"
                //+ "OBX|1|ST|||Test Value";

                string firstMessage = @"MSH|^~\&|SENDING|SENDER|RECV|INST|20060228155525||QRY^R02|1234567890|P|2.3|\r"
                + "QRD|20060228155525|2|3|4|5|6|7|8|9|10|11|12|\r"
                + "QRF||||||||";
               // + "QRD|20060228155525|R|I|x|x|x|x|10^RD&Records&0126|38923^^^^^^^^&INST|x|x|";
               //+"QRD|20060228155525|R|I|||||10^RD&Records&0126|38923^^^^^^^^&INST|||";

                PipeParser parser = new PipeParser();
                IMessage mv23 = parser.Parse(firstMessage);
                NHapi.Model.V23.Message.QRY_R02 qryR02 = mv23 as NHapi.Model.V23.Message.QRY_R02;

                Console.WriteLine("Hello ... Trying");


                // QRD
                //  "Query Date/Time (TS)"
                //  "Query Format Code (ID)"
                //  "Query Priority (ID)"
                //  "Query ID (ST)"
                //  "Deferred Response Type (ID)"
                //  "Deferred Response Date/Time (TS)"
                //  "Quantity Limited Request (CQ)"
                //  "Who Subject Filter (XCN)"
                //  "What Subject Filter (CE)"
                //  "What Department Data Code (CE)"
                //  "What Data Code Value Qualifier (CM_VR)"
                //  "Query Results Level (ID)"



                //Console.WriteLine(qryR02.QRD.QueryDateTime.GetType());
                //Console.WriteLine(qryR02.QRD.QueryDateTime.GetType());

                //.QueryDateTime.GetType()

                //Console.WriteLine("QRD - Query Date/Time (TS)                   " + qryR02.QRD.QueryDateTime.GetType());
                //Console.WriteLine("QRD - Query Format Code (ID)                 " + qryR02.QRD.QueryFormatCode.GetType());
                //Console.WriteLine("QRD - Query Priority (ID)                    " + qryR02.QRD.QueryPriority.GetType());
                //Console.WriteLine("QRD - What Department Data Code (CE)         " + qryR02.QRD.GetWhatDepartmentDataCode(0).GetType());
                //Console.WriteLine("QRD - Query ID (ST)                          " + qryR02.QRD.QueryID.GetType());
                //Console.WriteLine("QRD - Deferred Response Type (ID)            " + qryR02.QRD.DeferredResponseType.GetType());
                //Console.WriteLine("QRD - Deferred Response Date/Time (TS)       " + qryR02.QRD.DeferredResponseDateTime.GetType());
                //Console.WriteLine("QRD - Quantity Limited Request (CQ)          " + qryR02.QRD.QuantityLimitedRequest.GetType());
                //Console.WriteLine("QRD - Who Subject Filter (XCN)               " + qryR02.QRD.GetWhoSubjectFilter(0).GetType());
                //Console.WriteLine("QRD - What Subject Filter (CE)               " + qryR02.QRD.GetWhatSubjectFilter(0).GetType());
                //Console.WriteLine("QRD - What Data Code Value Qualifier (CM_VR) " + qryR02.QRD.GetWhatDataCodeValueQualifier(0).GetType());
                //Console.WriteLine("QRD - Query Results Level (ID)               " + qryR02.QRD.QueryResultsLevel.GetType());


                // +"QRD|20060228155525|R|I||||10^RD&Records&0126|38923^^^^^^^^&INST|||";

                /** QRD|
                    20060228155525|             Query Date/Time (TS) 
                    R|                          Query Format Code (ID)
                    I|                          Query Priority (ID) 
                     |                          What Department Data Code (CE)  
                     |                          Query ID (ST)   
                     |                          Deferred Response Type (ID)  
                     |                          Deferred Response Date/Time (TS)
                    10^RD&Records&0126|         Quantity Limited Request (CQ)
                    38923^^^^^^^^&INST|         Who Subject Filter (XCN)
                     |                         
                     |

                **/

                Console.WriteLine(firstMessage);

               
                Console.WriteLine("MSH      MessageType.MessageType               {0}", qryR02.MSH.MessageType.MessageType.Value);
                Console.WriteLine("MSH      MessageType.TriggerEvent              {0}", qryR02.MSH.MessageType.TriggerEvent.Value);
                Console.WriteLine("MSH      MessageControlID                      {0}", qryR02.MSH.MessageControlID.Value);

                Console.WriteLine("QRD 1 - Query Date/Time (TS)                   {0}", qryR02.QRD.QueryDateTime.TimeOfAnEvent.Value);
                Console.WriteLine("QRD 2 - Query Format Code (ID)                 {0}", qryR02.QRD.QueryFormatCode.Value);
                Console.WriteLine("QRD 3 - Query Priority (ID)                    {0}", qryR02.QRD.QueryPriority.Value);
                Console.WriteLine("QRD 4 - What Department Data Code (CE)         {0}", qryR02.QRD.GetWhatDepartmentDataCode(0).Identifier.Value);
                Console.WriteLine("QRD 5 - Query ID (ST)                          {0}", qryR02.QRD.QueryID.Value);
                Console.WriteLine("QRD 6 - Deferred Response Type (ID)            {0}", qryR02.QRD.DeferredResponseType.Value);
                Console.WriteLine("QRD 7 - Deferred Response Date/Time (TS)       {0}", qryR02.QRD.DeferredResponseDateTime.TimeOfAnEvent.Value);
                Console.WriteLine("QRD 8 - Quantity Limited Request (CQ)          {0}", qryR02.QRD.QuantityLimitedRequest.Quantity.Value);
                Console.WriteLine("QRD 9 - Who Subject Filter (XCN)               {0}", qryR02.QRD.GetWhoSubjectFilter(0).IDNumber.Value);
                Console.WriteLine("QRD 10- What Subject Filter (CE)               {0}", qryR02.QRD.GetWhatSubjectFilter(0).Identifier.Value);
                Console.WriteLine("QRD 11- What Data Code Value Qualifier (CM_VR) {0}", qryR02.QRD.GetWhatDataCodeValueQualifier(0).FirstDataCodeValue.Value);
                Console.WriteLine("QRD 12- Query Results Level (ID)               {0}", qryR02.QRD.QueryResultsLevel.Value);



                //  QRD - Query Date / Time(TS)                 NHapi.Model.V23.Datatype.TS
                //  QRD - Query Format Code(ID)                 NHapi.Model.V23.Datatype.ID
                //  QRD - Query Priority(ID)                    NHapi.Model.V23.Datatype.ID
                //  QRD - What Department Data Code(CE)         System.Int32
                //  QRD - Query ID(ST)                          NHapi.Model.V23.Datatype.ST
                //  QRD - Deferred Response Type(ID)            NHapi.Model.V23.Datatype.ID
                //  QRD - Deferred Response Date/ Time(TS)      NHapi.Model.V23.Datatype.TS
                //  QRD - Quantity Limited Request(CQ)          NHapi.Model.V23.Datatype.CQ
                //  QRD - Who Subject Filter(XCN)               System.Int32
                //  QRD - What Subject Filter(CE)               System.Int32
                //  QRD - What Data Code Value Qualifier(CM_VR) System.Int32
                //  QRD - Query Results Level(ID)               NHapi.Model.V23.Datatype.ID

                // Console.WriteLine(qryR02.GetStructure("MSH"));
                // Console.WriteLine(qryR02.GetStructure("QRD"));
                // Console.WriteLine(qryR02.GetStructure("QRF"));

                // Console.WriteLine("MSH length = " + qryR02.GetAll("MSH").Length);
                // Console.WriteLine("QRD length = " + qryR02.GetAll("QRD").Length);
                // Console.WriteLine("QRF length = " + qryR02.GetAll("QRF").Length);

                // int rep = 0;
                // qryR02.GetStructure("MSH", rep);

                // Console.WriteLine("REP: " + rep);


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
