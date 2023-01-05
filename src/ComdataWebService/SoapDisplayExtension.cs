using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.Services.Protocols;

namespace Comdata
{
    /// <summary>
    /// Summary description for SoapDisplayExtension.
    /// </summary>
    public class SoapDisplayExtension : SoapExtension
    {
        public SoapDisplayExtension()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        // Variables to hold the original stream
        // and the stream that we return
        private Stream originalStream;
        private Stream internalStream;

        // Version called if configured with a config file
        public override object GetInitializer(
        System.Type serviceType)
        {
            // Not used in this example, but it//s
            // declared abstract in the base class
            return null;
        }

        // Called the first time the Web service is used
        // Version called if configured with an attribute
        public override object GetInitializer(
        LogicalMethodInfo methodInfo,
        SoapExtensionAttribute attribute)
        {
            // Not used in this example, but it//s
            // declared abstract in the base class
            return null;
        }

        // Called each time the Web service is used
        // And gets passed the data from
        // GetInitializer() method
        public override void Initialize(
        object initializer)
        {
            // Not used in this example, but it//s
            // declared abstract in the base class
        }

        // The ChainStream() method gives us a chance
        // to grab the SOAP messages as they go by
        public override System.IO.Stream ChainStream(
        System.IO.Stream stream)
        {
            // Save the original stream
            originalStream = stream;
            // Create and return our own in its place
            internalStream = new MemoryStream();
            return internalStream;
        }

        // The ProcessMessage() method is where we do our work
        public override void ProcessMessage(
        System.Web.Services.Protocols.SoapMessage message)
        {
            // Determine the stage and take appropriate action
            switch (message.Stage)
            {
                case SoapMessageStage.BeforeSerialize:
                    // About to prepare a SOAP Response
                    break;

                case SoapMessageStage.AfterSerialize:
                    // SOAP response is all prepared
                    internalStream.Position = 0;
                    // Get a Transform ready
                    XslTransform xslt = new XslTransform();
                    xslt.Load(@"..\..\Identity.xslt");
                    // Load the raw XML into an XML document
                    XmlDocument xd = new XmlDocument();
                    xd.Load(internalStream);
                    // Use the transform to pretty print it
                    MemoryStream ms = new MemoryStream();
                    xslt.Transform(xd, null, ms);
                    // And drop the results
                    // to a TextBox control
                    ms.Position = 0;
                    StreamReader sr = new StreamReader(ms);
                    DisplayMessage f = new DisplayMessage();
                    f.txtMessage.Text = sr.ReadToEnd();
                    f.Show();
                    // Copy the passed message
                    // to the other stream
                    internalStream.Position = 0;
                    CopyStream(
                    internalStream, originalStream);
                    internalStream.Position = 0;
                    break;

                case SoapMessageStage.BeforeDeserialize:
                    // About to handle a SOAP request
                    // Copy the passed message
                    // to the other stream
                    CopyStream(
                    originalStream, internalStream);
                    internalStream.Position = 0;
                    // Get a Transform ready
                    XslTransform xslt1 = new XslTransform();
                    xslt1.Load(@"..\..\Identity.xslt");
                    // Load the raw XML into an XML document
                    XmlDocument xd1 = new XmlDocument();
                    xd1.Load(internalStream);
                    // Use the transform to pretty print it
                    MemoryStream ms1 = new MemoryStream();
                    xslt1.Transform(xd1, null, ms1);
                    // And drop the results
                    // to a TextBox control
                    ms1.Position = 0;
                    StreamReader sr1 = new StreamReader(ms1);
                    DisplayMessage f1 = new DisplayMessage();
                    f1.txtMessage.Text = sr1.ReadToEnd();
                    f1.Show();
                    internalStream.Position = 0;
                    break;

                case SoapMessageStage.AfterDeserialize:
                    // SOAP request has been deserialized
                    break;
            }
        }

        // Helper function to copy one stream to another
        private void CopyStream(Stream fromStream,
        Stream toStream)
        {
            try
            {
                StreamReader sr =
                new StreamReader(fromStream);
                StreamWriter sw =
                new StreamWriter(toStream);
                sw.WriteLine(sr.ReadToEnd());
                sw.Flush();
            }
            catch (Exception ex)
            {
                // Log the exception
            }
        }
    }
}
