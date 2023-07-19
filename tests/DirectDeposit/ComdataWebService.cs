using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using System.IO;
using System.Net.Http;

namespace FTP_Test_Client
{
    internal class ComdataWebService
    {
        /*public static void CallWebService()
        {
            var _url = "http://xxxxxxxxx/Service1.asmx";
            var _action = "http://xxxxxxxx/Service1.asmx?op=HelloWorld";

            XmlDocument soapEnvelopeXml = CreateSoapEnvelope();
            HttpWebRequest webRequest = CreateWebRequest(_url, _action);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            // begin async call to web request.
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

            // suspend this thread until call is complete. You might want to
            // do something useful here like update your UI.
            asyncResult.AsyncWaitHandle.WaitOne();

            // get the response from the completed web request.
            string soapResult;
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            using (var sr = new StreamReader(webResponse.GetResponseStream()))
            {
                soapResult = sr.ReadToEnd();
            }
            Console.Write(soapResult);
        }

        private static HttpWebRequest CreateWebRequest(string url, string action)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Headers.Add("SOAPAction", action);
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        private static XmlDocument CreateSoapEnvelope()
        {
            var soapEnvelopeDocument = new XmlDocument();
            soapEnvelopeDocument.LoadXml(
            @"<SOAP-ENV:Envelope xmlns:SOAP-ENV=""http://schemas.xmlsoap.org/soap/envelope/"" 
               xmlns:xsi=""http://www.w3.org/1999/XMLSchema-instance"" 
               xmlns:xsd=""http://www.w3.org/1999/XMLSchema"">
        <SOAP-ENV:Body>
            <HelloWorld xmlns=""http://tempuri.org/"" 
                SOAP-ENV:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
                <int1 xsi:type=""xsd:integer"">12</int1>
                <int2 xsi:type=""xsd:integer"">32</int2>
            </HelloWorld>
        </SOAP-ENV:Body>
    </SOAP-ENV:Envelope>");
            return soapEnvelopeDocument;
        }

        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using Stream stream = webRequest.GetRequestStream();
            soapEnvelopeXml.Save(stream);
        }*/

        public async Task<string> CreateSoapEnvelope(string xmlString, string postUrl)
        {
            string soapString = $@"<?xml version=""1.0"" encoding=""utf-8""?>
          <soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
              <soap:Body>
                  {xmlString}
              </soap:Body>
          </soap:Envelope>";
            /*string soapString = @"<?xml version=""1.0"" encoding=""utf-8""?>
          <soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
              <soap:Body>
                  <HelloWorld xmlns=""http://tempuri.org/"" />
              </soap:Body>
          </soap:Envelope>";*/

            HttpResponseMessage response = await PostXmlRequest(postUrl, soapString);
            string content = await response.Content.ReadAsStringAsync();

            return content;
        }

        public static async Task<HttpResponseMessage> PostXmlRequest(string baseUrl, string xmlString)
        {
            using (var httpClient = new HttpClient())
            {
                var httpContent = new StringContent(xmlString, Encoding.UTF8, "text/xml");
                httpContent.Headers.Add("SOAPAction", "http://tempuri.org/HelloWorld");

                return await httpClient.PostAsync(baseUrl, httpContent);
            }
        }
    }
}
