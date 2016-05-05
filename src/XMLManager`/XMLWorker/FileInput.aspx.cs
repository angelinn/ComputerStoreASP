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

            for (int i = 0; i < files.Count; ++i)
            {
                files[i].SaveAs(String.Format("{0}user_uploads\\{1}", HttpRuntime.AppDomainAppPath, files[i].FileName));
            }
        }
    }
}