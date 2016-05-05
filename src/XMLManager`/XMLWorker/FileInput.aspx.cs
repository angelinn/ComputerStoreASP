using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XMLWorker
{
    public partial class FileInput : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpFileCollection files = Request.Files;
            string message = "File extension is not XML.";
            string serverFileName = String.Empty;

            for (int i = 0; i < files.Count; ++i)
            {
                try
                {
                    if (files[i].ContentLength == 0)
                        continue;

                    if (System.IO.Path.GetExtension(files[i].FileName) == ".xml")
                    {
                        serverFileName = String.Format("{0}user_uploads\\{1}", HttpRuntime.AppDomainAppPath, files[i].FileName);
                        files[i].SaveAs(serverFileName);

                        if (new XMLValidator().ValidateXML(serverFileName))
                            message = "Success.";
                        else
                            message = "File not valid by the DTD schema.";

                        System.IO.File.Delete(serverFileName);
                    }
                }
                catch (HttpException)
                {
                    message = "Failed to upload file.";
                }

                TableRow uploadEntry = new TableRow();
                TableCell fileName = new TableCell();
                fileName.Text = files[i].FileName;
                TableCell status = new TableCell();
                status.Text = message;

                uploadEntry.Cells.Add(fileName);
                uploadEntry.Cells.Add(status);

                tblResults.Rows.Add(uploadEntry);
            }
        }
    }
}