using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitemaProyecto.Forms
{
    public partial class archivo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (fileExtension.ToLower() != ".pdf" && fileExtension.ToLower() != ".PDF")
                {
                    Label1.Text = "Sólo archivo con pdf";

                }
                else
                {
                    int fileSize = FileUpload1.PostedFile.ContentLength;
                    if (fileSize >= 2097152)/////tamaño del archivo 2mb
                    {
                        Label1.Text = "Archivo Maximo de 2MB";
                    }
                    else
                    {
                        string ass = Server.MapPath("~");

                        ass += "\\Archivos\\" + FileUpload1.FileName;

                        FileUpload1.SaveAs(ass);
                        Label1.Text = "Archivo Subido";
                    }
                }
            }
            else
            {
                Label1.Text = "Seleccione un archivo para cargarlo";
            }
        }
    }
}