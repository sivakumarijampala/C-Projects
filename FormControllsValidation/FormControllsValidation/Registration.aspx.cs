using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormControllsValidation.FormControllsValidation
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string[] ValidFileTypes = { "pdf", "docx", "jpg", "jpeg" };

            string ext = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName);
            var isValidFile = false;
            for (var i = 0; i < ValidFileTypes.Length; i++)
            {
                if (ext == "." + ValidFileTypes[i])
                {
                    isValidFile = true;
                    break;
                }

            }

            if (!isValidFile)
            {
                lbMessage.Text = "Invalid file please upload valid file with extension:" + string.Join(".", ValidFileTypes);
                lbMessage.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                lbMessage.Text = "file uploaded successfully";
                lbMessage.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}