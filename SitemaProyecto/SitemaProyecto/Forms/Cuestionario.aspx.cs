using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitemaProyecto.Forms
{
    public partial class Cuestionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)  //Si es la primera vez que se carga
            {
                if (Session["Usuario"] == null)
                {
                    Response.Redirect("..\\default.aspx");
                }
                else
                {
                    try
                    {
                        if (Session["idusuario"].ToString().Trim() != "")
                        {
                            Clases.ValoresGlobales VGlobal = new Clases.ValoresGlobales();
                            DataSet DatRegistros = new DataSet();
                            string Sentencia;

                            //Rellena Zona
                            Sentencia = "SELECT * FROM `prefuntas` where face=" + Session["face"].ToString().Trim() + " and  idcategoria=" + Session["idcategoria"].ToString().Trim() + "";
                            DatRegistros = VGlobal.BDatos.Lectura(Sentencia);
                            try
                            {
                                if (DatRegistros != null)
                                {
                                    if (DatRegistros.Tables[0].Rows.Count > 0)
                                    {
                                        Session["cuestionario"] = DatRegistros;
                                    }
                                }
                            }
                            catch (Exception)
                            {
                            }
                            Sentencia = "SELECT count(*) as num FROM `prefuntas` where face=" + Session["face"].ToString().Trim() + " and  idcategoria=" + Session["idcategoria"].ToString().Trim() + "";
                            DatRegistros = VGlobal.BDatos.Lectura(Sentencia);
                            try
                            {
                                if (DatRegistros != null)
                                {
                                    if (DatRegistros.Tables[0].Rows.Count > 0)
                                    {
                                        Session["num"] = DatRegistros.Tables[0].Rows[0]["num"].ToString().Trim();
                                        DataSet RegisActual = new DataSet();
                                        RegisActual = (DataSet)(Session["cuestionario"]);

                                    }
                                }
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                    catch (Exception)
                    {
                        
                    }
                }
            }

        }

        private void reguntas()
        {
            DataSet RegisActual = new DataSet();
            RegisActual = (DataSet)(Session["cuestionario"]);
            int x= Int32.Parse(Session["num"].ToString().Trim());
            for (int i = 0; i < x; i++)
            {

            }

        }



        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}