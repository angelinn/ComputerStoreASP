using Common;
using DataAccess.Domain;
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

            for (int i = 0; i < files.Count; ++i)
            {
                try
                {
                    if (files[i].ContentLength != 0)
                    {
                        if (System.IO.Path.GetExtension(files[i].FileName) == ".xml")
                        {
                            string serverFileName = BuildServerFileName(files[i].FileName);
                            files[i].SaveAs(serverFileName);

                            XMLValidator validator = new XMLValidator();
                            if (validator.ValidateXML(serverFileName))
                            {
                                message = "Success.";
                                ComputerStoreDO.AddStoreData(serverFileName);
                            }
                            else
                                message = "File not valid by the DTD schema.";

                            System.IO.File.Delete(serverFileName);
                        }
                    }
                }
                catch (HttpException)
                {
                    message = "Failed to upload file.";
                }

                CreateUploadEntryStatus(files[i].FileName, message);
            }
        }

        private void CreateUploadEntryStatus(string fileName, string status)
        {
            TableRow uploadEntry = new TableRow();
            TableCell fileCell = new TableCell();
            fileCell.Text = fileName;
            TableCell statusCell = new TableCell();
            statusCell.Text = status;

            uploadEntry.Cells.Add(fileCell);
            uploadEntry.Cells.Add(statusCell);

            tblResults.Rows.Add(uploadEntry);
        }

        private string BuildServerFileName(string fileName)
        {
            return String.Format("{0}user_uploads\\{1}", HttpRuntime.AppDomainAppPath, fileName);
        }
    }
}