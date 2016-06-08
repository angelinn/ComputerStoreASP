using Common;
using DataAccess.Models.XML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;

namespace XMLWorker
{
    public partial class ManualInput : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ComputerStore store = new ComputerStore();
            store.Parts = new Parts();
            store.Parts.Processors = new Processor[1];

            store.Parts.Processors[0] = new Processor
            {
                ID = txtCpuID.Text,
                Socket = txtCpuSocket.Text,
                Model = txtCpuModel.Text,
                Manufacturer = txtCpuManufacturer.Text,
                Architecture = txtCpuArchitecture.Text,
                ClockFrequency = txtCpuFrequency.Text,
                Cache = new Cache { Levels = Int32.Parse(txtCacheLevels.Text), Memory = txtCacheMemory.Text },
                Threads = new Threads { Logical = Int32.Parse(txtLogicalThreads.Text), Physical = Int32.Parse(txtPhysicalThreads.Text) },
                Available = Int32.Parse(txtCpuAvailable.Text),
                Price = txtCpuPrice.Text,
                IntegratedVideo = chkCpuVideo.Checked
            };


            XmlSerializer serializer = new XmlSerializer(typeof(ComputerStore));
            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.Indent = true;
            writerSettings.IndentChars = "\t";

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            using (TextWriter textWriter = new StreamWriter("C:\\Users\\betra\\desktop\\res.xml"))
            using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, writerSettings))
            {
                xmlWriter.WriteDocType("computer-store", null, "computer_store.dtd", null);
                serializer.Serialize(xmlWriter, store, ns);
            }
        }
    }
}