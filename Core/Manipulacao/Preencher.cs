using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace Core
{
    public class Preencher
    {
        public static void Panel(Panel panel, DataRow dataRow, int startAt = 0)
        {
            foreach (Control c in panel.Controls)
            {
                if (startAt < dataRow.ItemArray.Length)
                {
                    if (c is TextBox || c is MaskedTextBox || c is DateTimePicker)
                    {
                        c.Text = dataRow[startAt++].ToString().Trim();
                    }
                    else if (c is ComboBox)
                    {
                        (c as ComboBox).SelectedValue = dataRow[startAt++];
                    }
                }
            }
        }

        public static void ComboBox(ComboBox comboBox, DataTable table, string display, string value = null)
        {
            if (!table.Rows.Count.Equals(0))
            {
                comboBox.DataSource = table;
                comboBox.DisplayMember = display;
                comboBox.ValueMember = value ?? display;
                comboBox.SelectedIndex = 0;
            }
        }

        public static void ListBox(ListBox listBox, DataTable table, string display, string value = null)
        {
            if (!table.Rows.Count.Equals(0))
            {
                listBox.DataSource = table;
                listBox.DisplayMember = display;
                listBox.ValueMember = value ?? display;
                listBox.SelectedIndex = 0;
            }
        }

        public static void GridView(DataGridView dataGrid, DataTable table, string[] headerText, int[] fillWeight, bool lida)
        {
            dataGrid.DataSource = table;

            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ColumnHeadersDefaultCellStyle = Colors.HeaderStyle;
            dataGrid.DefaultCellStyle = Colors.CellStyle;

            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                dataGrid.Columns[i].Visible = false;
            }

            for (int i = 0; i < fillWeight.Length; i++)
            {
                dataGrid.Columns[i].Visible = true;
                dataGrid.Columns[i].HeaderText = headerText[i];
                dataGrid.Columns[i].FillWeight = fillWeight[i];
            }
        }

        public static void List(List<object> list, object source, int currentControl = 0, string column = null)
        {
            if (Buscar.Editor.IsMensagem)
            {
                list.Add(Buscar.Editor.ID);
                list.Add(Buscar.Usuario.ID);
                list.Add(Buscar.Usuario.Classe);

                Buscar.Editor.IsMensagem = false;
            }

            if (source is Panel)
            {
                foreach (Control c in (source as Control).Controls)
                {
                    if (c is TextBox || c is MaskedTextBox)
                    {
                        list.Add(c.Text.ToLower().Trim());
                    }

                    if (c is DateTimePicker)
                    {
                        list.Add(Convert.ToDateTime(c.Text.ToLower().Trim()));
                    }

                    if (c is ComboBox)
                    {
                        list.Add((c as ComboBox).SelectedValue);
                    }
                }
            }
            else if (source is DataTable)
            {
                while (!currentControl.Equals((source as DataTable).Rows.Count))
                {
                    list.Add((source as DataTable).Rows[currentControl++][column].ToString().ToLower().Trim());
                }
            }
            else
            {
                while (!currentControl.Equals((source as NameValueCollection).Count))
                {
                    list.Add((source as NameValueCollection)[currentControl++]);
                }
            }
        }

        public static void DropDownList(System.Web.UI.WebControls.DropDownList dropDownList, DataTable table, string display)
        {
            for (int currentControl = 0; currentControl < table.Rows.Count; currentControl++)
            {
                dropDownList.Items.Add(table.Rows[currentControl][display].ToString().Trim());
            }
        }

        public static void HtmlForm(HtmlControl control, DataRow dataRow, int currentControl = 0)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                for (int j = 0; j < control.Controls[i].Controls.Count; j++)
                {
                    if (control.Controls[i].Controls[j] is System.Web.UI.WebControls.TextBox)
                    {
                        (control.Controls[i].Controls[j] as System.Web.UI.WebControls.TextBox).Text = dataRow[currentControl++].ToString().Trim();
                    }
                }
            }
        }
    }
}
