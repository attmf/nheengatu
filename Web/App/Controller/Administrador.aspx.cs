using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using Core;

namespace Web_app
{
    public class Administrador : Page
    {
        public void Page_Load()
        {
            DataTable table;
            List<object> list;
            string url, json, term;

            Response.ContentType = "application/json";

            try
            {
                url = Request["u"];

                switch (url)
                {
                    case "listar":
                        json = string.Empty;
                        table = Listar.Administradores.All;

                        if (!table.Rows.Count.Equals(0))
                        {
                            json += "[";

                            foreach (DataRow row in table.Rows)
                            {
                                term = "{'id':'{id}','cpf':'{cpf}','senha':'{senha}'},";
                                term = term.Replace("{id}", row["id"].ToString());
                                term = term.Replace("{cpf}", row["cpf"].ToString());
                                term = term.Replace("{senha}", row["senha"].ToString());
                                term = term.Replace("\'", "\"");

                                json += term;
                            }

                            json += "]";
                            json = json.Replace(",]", "]");
                        }

                        Response.Write(json);
                        break;

                    case "alterar":
                        list = new List<object>();

                        list.Add(Request["id"]);
                        list.Add(Request["senha"]);

                        try
                        {
                            Alterar.Administrador.Login(list);
                        }
                        catch (Exception ex)
                        {
                            Response.Write(ex.Message);
                        }

                        break;
                }
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}