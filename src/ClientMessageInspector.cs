using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;

namespace Comdata
{
    public class SoapMessageInspector : IClientMessageInspector
    {
        public string LastRequestXml { get; private set; } = String.Empty;
        public string LastResponseXml { get; private set; } = String.Empty;

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            LastRequestXml = request.ToString();
            return request;
        }

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            LastResponseXml = reply.ToString();
        }
    }

    public class SoapInspectorBehavior : IEndpointBehavior
    {
        private readonly SoapMessageInspector _inspector = new SoapMessageInspector();

        public string LastRequestXml => _inspector.LastRequestXml;
        public string LastResponseXml => _inspector.LastResponseXml;

        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
        }

        public void Validate(ServiceEndpoint endpoint)
        {
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.ClientMessageInspectors.Add(_inspector);
        }
    }



    /*public class ClientMessageInspector : System.ServiceModel.Dispatcher.IClientMessageInspector
    {
        #region IClientMessageInspector Members

        public string LastRequestXml { get; private set; }

        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {

        }

        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel)
        {
            string requestHeaderName = request.Headers.Action.Replace("urn:#", string.Empty);
            LastRequestXml = request.ToString();
            string serializedRequestFile = string.Format(requestHeaderName + "_request_{0}.xml", DateTime.Now.ToString("yyyyMMddHHmmss"));
            string exportedFolder = ConfigurationManager.AppSettings["SubmittedRequestXmLocation"];
            printSoapRequest(request, exportedFolder, serializedRequestFile);

            return request;
        }

        public void printSoapRequest(System.ServiceModel.Channels.Message request, string exportedFolder, string fileName)
        {
            if (exportedFolder.Equals(string.Empty))
                return;

            if (!Directory.Exists(exportedFolder))
            {
                Directory.CreateDirectory(exportedFolder);
            }
            string exportedFile = string.Format("{0}\\{1}", exportedFolder, fileName);
            if (File.Exists(exportedFile))
            {
                File.Delete(exportedFile);
            }

            string strRequestXML = request.ToString();
            XDocument xDoc = XDocument.Parse(strRequestXML);
            XmlWriter xw = XmlWriter.Create(exportedFile);
            xDoc.Save(xw);
            xw.Flush();
            xw.Close();
            LogOutput("Request file exported: " + exportedFile);
        }
    }*/

    /*public class CustomInspectorBehavior : IEndpointBehavior
    {
        private readonly ClientMessageInspector clientMessageInspector = new ClientMessageInspector();

        public string LastRequestXml
        {
            get { return clientMessageInspector.LastRequestXml; }
        }

        public string LastResponseXml
        {
            get { return clientMessageInspector.LastRequestXml; }
        }

        public void AddBindingParameters(
            ServiceEndpoint endpoint,
            System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
        }

        public void Validate(ServiceEndpoint endpoint)
        {
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.MessageInspectors.Add(clientMessageInspector);
        }
    }*/
}
