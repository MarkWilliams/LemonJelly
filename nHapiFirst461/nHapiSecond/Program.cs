using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Base.Log;
using NHapi.Base;

using NHapi.Model.V24;
using NHapi.Model.V24.Segment;
using NHapi.Model.V24.Group;
using NHapi.Model.V24.Message;


namespace nHapiSecond
{
    class Program
    {
        static void Main(string[] args)

        {

            string ADTMessage = @"MSH|^~\&|Medway PAS V3|Christie|Christie Clinicals|Christie Dev|20180510130123||ADT^A31^ADT_A05|RBV_5533969|P|2.4|||AL|NE
EVN|A31|20180510130123||||20180510130123
PID|||201800014^^^RBV^HOSP~3369628198^^^NHS^NHS~^^^RBV^DIST~^^^RBV^UNIT||Proton^Patient5^^^Sir||19671106|1|||18 Union Road^^^ASHTON-UNDER-LYNE^OL6 9JE^GB^HOME^Lancashire~^^^^^^TEMP||01618761029^^HOME~075402341423^^MOB|01617985342^^WORK||P|C13|||||C||||||||N||NSTS02
PD1|||Stamford House^^P89609|G3384167^Shah^PR^^^Dr^^^^^^^GP
NK1|1|Grandmother Patient5|Grandmother|18 Union Road,ASHTON-UNDER-LYNE,Lancashire,OL6 9JE|10161876102|20754054637|NK
NK1|2|""|Not Set||||EC";


            //string hl7message = Convert.ToChar(11).ToString() + ADTMessage + Convert.ToChar(28).ToString() + Convert.ToChar(13).ToString();
            //PipeParser parser = new PipeParser();
            //IMessage mv23 = parser.Parse(firstMessage);
            //NHapi.Model.V23.Message.QRY_R02 qryR02 = mv23 as NHapi.Model.V23.Message.QRY_R02;


            //string EVNseg = "EVN|A31|20180510130123||||20180510130123";
            //PipeParser parser = new PipeParser();
            //IMessage evn = parser.Parse(EVNseg);
            //// NHapi.Model.V24.Message.ADT_A01 adtA01 = m as NHapi.Model.V24.Message.ADT_A01;
            //EVN mEVN = evn as EVN;

            //Console.WriteLine("EVN      {0}", mEVN.RecordedDateTime);

            //Console.WriteLine("A HL7 message of the type {0} and version {1} is received.", hl7Message.GetStructureName(), hl7Message.Version);
            //if (!hl7Message.GetStructureName().StartsWith("ADT_"))
            //{
            //    errorMessage = "This message structure is not supported.";
            //    return false;
            //}

            // switch (hl7Message.Version)
            PipeParser parser = new PipeParser();
            IMessage mm = parser.Parse(ADTMessage);
            // NHapi.Model.V24.Message.ADT_A01 adtA01 = m as NHapi.Model.V24.Message.ADT_A01;
            ADT_A05 adtA05 = mm as ADT_A05;


            //adtA05 = EVNseg;
            //var setId = adtA05.PD1..Value;
            //var patientClass = adtA05.PV1.PatientClass.Value;
            //var AssignedPatientLocation = adtA05.PV1.AssignedPatientLocation.PointOfCare.Value;
            //var Admission_Type = adtA05.PV1.AdmissionType.Value;
            //var Pre_Admit_Number = adtA05.PV1.PreadmitNumber.ID.Value;
            //var Prior_Patient_Location = adtA05.PV1.PriorPatientLocation.PointOfCare.Value;
            //var Attending_Doctor_Id = adtA05.PV1.AttendingDoctor.IDNumber.Value;
            //var Attending_Doctor_Name = adtA05.PV1.AttendingDoctor.FamilyName.Value;
            //var Referring_Doctor_Id = adtA05.PV1.ReferringDoctor.IDNumber.Value;
            //var Referring_Doctor_Name = adtA05.PV1.ReferringDoctor.FamilyName.Value;

            Console.WriteLine("Hello ... Second Trying this:\n {0}", ADTMessage);

            //Console.WriteLine(adtA01.GetStructure("MSH"));

            if (adtA05 != null)
            {
                Console.WriteLine(adtA05);
                Console.WriteLine("--");
                // adtA05.Message.Names.ToArray();
                Console.WriteLine("--");
                Console.WriteLine(adtA05.Version);
                Console.WriteLine(adtA05.ValidationContext);
                Console.WriteLine("ec: " + adtA05.MSH.EncodingCharacters);
                Console.WriteLine("Here");

                Console.WriteLine(adtA05.GetStructureName().StartsWith("ADT_"));
                Console.WriteLine(adtA05.Version);
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine(adtA05.GetAll("NK1"));
                Console.WriteLine("-------------------------------------------");
            }
            if (adtA05 is null)
            {
                Console.WriteLine(adtA05);
                Console.WriteLine("wHere");
            }
            Console.WriteLine(adtA05.GetStructure("EVN"));
            Console.WriteLine(adtA05.GetStructure("PID"));

            Console.WriteLine("MSH:{0}", adtA05.MSH.NumFields());
            Console.WriteLine("EVN:{0}", adtA05.EVN.NumFields());
            Console.WriteLine("PID:{0}", adtA05.PID.NumFields());
            //Console.WriteLine("PV1:{0}", adtA05.PV1.NumFields());
            //Console.WriteLine("NK1:{0}", adtA05.GetNK1().NumFields());
            

            Console.WriteLine("MSH length = " + adtA05.GetAll("MSH").Length);
            Console.WriteLine("EVN length = " + adtA05.GetAll("EVN").Length);
            Console.WriteLine("PID length = " + adtA05.GetAll("PID").Length);
            

            Console.WriteLine("MSH      MessageType.MessageType               {0}", adtA05.MSH.MessageType.MessageType.Value);
            Console.WriteLine("MSH      MessageType.TriggerEvent              {0}", adtA05.MSH.MessageType.TriggerEvent.Value);
            Console.WriteLine("MSH      MessageControlID                      {0}", adtA05.MSH.MessageControlID.Value);
            Console.WriteLine("EVN      adtA05.EVN.RecordedDateTime           {0}", adtA05.EVN.RecordedDateTime.TimeOfAnEvent);

            Console.WriteLine("PID 1 - adtA05.PID.Patient ID                  {0}", adtA05.PID.DateTimeOfBirth.TimeOfAnEvent);
            //Console.WriteLine("QRD 2 - Query Format Code (ID)                 {0}", adtA01.PID.QueryFormatCode.Value);
            //Console.WriteLine("QRD 3 - Query Priority (ID)                    {0}", adtA01.PID.QueryPriority.Value);
            //Console.WriteLine("QRD 4 - What Department Data Code (CE)         {0}", adtA01.PID.GetWhatDepartmentDataCode(0).Identifier.Value);
            //Console.WriteLine("QRD 5 - Query ID (ST)                          {0}", adtA01.PID.QueryID.Value);
            //Console.WriteLine("QRD 6 - Deferred Response Type (ID)            {0}", adtA01.PID.DeferredResponseType.Value);
            //Console.WriteLine("QRD 7 - Deferred Response Date/Time (TS)       {0}", adtA01.PID.DeferredResponseDateTime.TimeOfAnEvent.Value);
            //Console.WriteLine("QRD 8 - Quantity Limited Request (CQ)          {0}", adtA01.PID.QuantityLimitedRequest.Quantity.Value);
            //Console.WriteLine("QRD 9 - Who Subject Filter (XCN)               {0}", adtA01.PID.GetWhoSubjectFilter(0).IDNumber.Value);
            //Console.WriteLine("QRD 10- What Subject Filter (CE)               {0}", adtA01.PID.GetWhatSubjectFilter(0).Identifier.Value);
            //Console.WriteLine("QRD 11- What Data Code Value Qualifier (CM_VR) {0}", adtA01.PID.GetWhatDataCodeValueQualifier(0).FirstDataCodeValue.Value);
            //Console.WriteLine("QRD 12- Query Results Level (ID)               {0}", adtA01.PID.QueryResultsLevel.Value);
        }
    }
}
