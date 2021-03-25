using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace REad_Excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DataSet dataSetCyl      = new DataSet(),
                        dataSet2Create  = new DataSet(),
                        ds_cbInputs     = new DataSet(),
                        ds_cbOutputs    = new DataSet();
        int Input_H     = 0,
            Input_W     = 0,
            Output_H    = 0,
            Output_W    = 0;
        
        // Create a new DataTable.
        DataColumn column;
        DataRow row;

        string fname = "";
        OpenFileDialog fdlg = new OpenFileDialog();
        SaveFileDialog Sflg = new SaveFileDialog();

        private void _bAdd_HSensor_Click(object sender, EventArgs e)
        {
            if(_cbInputs.SelectedIndex != -1)
            {
                _lInput_H.Text  = ds_cbInputs.Tables[0].Rows[_cbInputs.SelectedIndex]["IOName"].ToString();
                Input_H         = Convert.ToInt32(ds_cbInputs.Tables[0].Rows[_cbInputs.SelectedIndex]["IOAddress"].ToString());
            }
        }

        private void _bAdd_WSensor_Click(object sender, EventArgs e)
        {
            if (_cbInputs.SelectedIndex != -1)
            {
                _lInput_W.Text  = ds_cbInputs.Tables[0].Rows[_cbInputs.SelectedIndex]["IOName"].ToString();
                Input_W         = Convert.ToInt32(ds_cbInputs.Tables[0].Rows[_cbInputs.SelectedIndex]["IOAddress"].ToString());
            }
        }

        private void _bAdd_HAct_Click(object sender, EventArgs e)
        {
            if (_cbOutputs.SelectedIndex != -1)
            {
                _lOutput_H.Text = ds_cbOutputs.Tables[0].Rows[_cbOutputs.SelectedIndex]["IOName"].ToString();
                Output_H = Convert.ToInt32(ds_cbOutputs.Tables[0].Rows[_cbOutputs.SelectedIndex]["IOAddress"].ToString());
            }
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Width = 90;
            dataGridView1.Columns[1].Width = 65;
            dataGridView1.Columns[2].Width = 65;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[6].Width = 70;

        }

        private void _bAdd_WAct_Click(object sender, EventArgs e)
        {
            if (_cbOutputs.SelectedIndex != -1)
            {
                _lOutput_W.Text = ds_cbOutputs.Tables[0].Rows[_cbOutputs.SelectedIndex]["IOName"].ToString();
                Output_W = Convert.ToInt32(ds_cbOutputs.Tables[0].Rows[_cbOutputs.SelectedIndex]["IOAddress"].ToString());
            }
        }

        private void _bAdd_Cyl_Click(object sender, EventArgs e)
        {
            if (_tbTipo_Cyl.Text    != null &&
                _lCylName.Text      != null &&
                Input_H             != 0    &&
                Input_W             != 0    &&
                Output_H            != 0    &&
                Output_W            != 0    &&
                _tbTimeout.Text     != null      )
            {
                row = dataSetCyl.Tables[0].NewRow();
                row[0]  = _lCylName.Text;
                row[1] = Input_H;
                row[2] = Input_W;
                row[3] = Output_H;
                row[4] = Output_W;
                row[5] = _tbTimeout.Text;
                row[6] = _tbTipo_Cyl.Text;
                dataSetCyl.Tables[0].Rows.Add(row);
                dataGridView1.Update();
            }
            else
                TextBox_feedback.Text = "Objecto cilindro mal preenchido";
        }

        private void _bCreateCylXML_Click(object sender, EventArgs e)
        {
            dataSetCyl.WriteXml("Cylinders.xml");
            TextBox_feedback.Text = "XML Cylinders Created";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox_feedback.Text   = "Preparing File";
            fdlg.Title              = "Excel File Dialog";
            fdlg.InitialDirectory   = @"C: \Users\filipesilva\Documents\Projectos\";
            fdlg.Filter             = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex        = 2;
            fdlg.RestoreDirectory   = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fname = fdlg.FileName;


                Microsoft.Office.Interop.Excel.Application xlApp        = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook      = xlApp.Workbooks.Open(fname);
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet   = xlWorkbook.Sheets[1];
                Microsoft.Office.Interop.Excel.Range xlRange            = xlWorksheet.UsedRange;

                TextBox_feedback.Text = "Reading File";
                int rowCount        = xlRange.Rows.Count;
                int colCount        = xlRange.Columns.Count;

                // dt.Column = colCount;  
                //dataGridView1.ColumnCount = colCount;
                //dataGridView1.RowCount = rowCount + 1;

                //Read DI From Exel Table
                int j  = Convert.ToInt32(xlRange.Cells[1, 1].Value2.ToString());
                
                for (int i =j ; i >=4; i++)
                {
                    row = dataSet2Create.Tables[0].NewRow();
                    if (i == j + 16)
                        j = i;
                    //write the value to the Grid  
                    if (xlRange.Cells[i, 9] != null && !xlRange.Cells[i, 9].Value2.ToString().Contains("End_IO"))
                    {
                        row["IOName"]       = xlRange.Cells[i, 9].Value2.ToString();
                        row["IOType"]       = "DI";
                        row["IOAddress"]    = xlRange.Cells[i, 8].Value2.ToString();
                        row["IOText"]       = xlRange.Cells[i, 9].Value2.ToString();
                        row["IOTag"]        = xlRange.Cells[i, 4].Value2.ToString();
                        row["ModuleType"]   = xlRange.Cells[j, 3].Value2.ToString();
                        dataSet2Create.Tables[0].Rows.Add(row);
                    }
                    else
                        i = 0;
                }
                //Read DO From Exel Table
                j = Convert.ToInt32(xlRange.Cells[1, 1].Value2.ToString());
                for (int i = j; i >= 4; i++)
                {
                    row = dataSet2Create.Tables[0].NewRow();
                    if (i == j + 16)
                        j = i;
                    //write the value to the Grid  
                    if (xlRange.Cells[i, 18] != null && !xlRange.Cells[i, 18].Value2.ToString().Contains("End_IO"))
                    {
                        row["IOName"]       = xlRange.Cells[i, 18].Value2.ToString();
                        row["IOType"]       = "DO";
                        row["IOAddress"]    = xlRange.Cells[i, 17].Value2.ToString();
                        row["IOText"]       = xlRange.Cells[i, 18].Value2.ToString();
                        row["IOTag"]        = xlRange.Cells[i, 15].Value2.ToString();
                        row["ModuleType"]   = xlRange.Cells[j, 14].Value2.ToString();
                        dataSet2Create.Tables[0].Rows.Add(row);
                    }
                    else
                        i = 0;
                }

                //Read AI From Exel Table
                j = Convert.ToInt32(xlRange.Cells[1, 2].Value2.ToString());
                for (int i =j; i >= 4; i++)
                {
                    row = dataSet2Create.Tables[0].NewRow();
                    if (i == j + 16)
                        j = i;
                    //write the value to the Grid  
                    if (xlRange.Cells[i, 9] != null && !xlRange.Cells[i, 9].Value2.ToString().Contains("End_IO"))
                    {
                        row["IOName"]       = xlRange.Cells[i, 9].Value2.ToString();
                        row["IOType"]       = "AI";
                        row["IOAddress"]    = xlRange.Cells[i, 8].Value2.ToString();
                        row["IOText"]       = xlRange.Cells[i, 9].Value2.ToString();
                        row["IOTag"]        = xlRange.Cells[i, 4].Value2.ToString();
                        row["ModuleType"]   = xlRange.Cells[j, 3].Value2.ToString();
                        dataSet2Create.Tables[0].Rows.Add(row);
                    }
                    else
                        i = 0;
                }
                //Read AO From Exel Table
                j = Convert.ToInt32(xlRange.Cells[1, 1].Value2.ToString());
                for (int i = j; i >= 4; i++)
                {
                    row = dataSet2Create.Tables[0].NewRow();
                    if (i == j + 16)
                        j = i;
                    //write the value to the Grid  
                    if (xlRange.Cells[i, 18] != null && !xlRange.Cells[i, 18].Value2.ToString().Contains("End_IO"))
                    {
                        row["IOName"]       = xlRange.Cells[i, 18].Value2.ToString();
                        row["IOType"]       = "AO";
                        row["IOAddress"]    = xlRange.Cells[i, 17].Value2.ToString();
                        row["IOText"]       = xlRange.Cells[i, 18].Value2.ToString();
                        row["IOTag"]        = xlRange.Cells[i, 15].Value2.ToString();
                        row["ModuleType"]   = xlRange.Cells[j, 14].Value2.ToString();
                        dataSet2Create.Tables[0].Rows.Add(row);
                    }
                    else
                        i = 0;
                }

                //cleanup  
                GC.Collect();
                GC.WaitForPendingFinalizers();

                //rule of thumb for releasing com objects:  
                //  never use two dots, all COM objects must be referenced and released individually  
                //  ex: [somthing].[something].[something] is bad  

                //release com objects to fully kill excel process from running in the background  
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                //close and release  
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                //quit and release  
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);

                //create dataset for inputs combobox
                ds_cbInputs  = dataSet2Create.Clone();
                ds_cbOutputs = dataSet2Create.Clone();
                ds_cbInputs.Clear();
                ds_cbOutputs.Clear();

                foreach (DataRow item in dataSet2Create.Tables[0].Rows)
                {
                    if (item["IOType"].ToString() == "DI")
                    {
                        ds_cbInputs.Tables[0].Rows.Add(item.ItemArray);
                    }
                    if (item["IOType"].ToString() == "DO")
                    {
                        ds_cbOutputs.Tables[0].Rows.Add(item.ItemArray);
                    }
                }

                _cbInputs.DataSource = ds_cbInputs.Tables[0].DefaultView;
                _cbInputs.DisplayMember = "IOName";
                _cbInputs.SelectedIndex = -1;

                _cbOutputs.DataSource = ds_cbOutputs.Tables[0].DefaultView;
                _cbOutputs.DisplayMember = "IOName";
                _cbOutputs.SelectedIndex = -1;

                TextBox_feedback.Text = "Read Done";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataSet2Create.WriteXml("IO.xml");
            TextBox_feedback.Text = "XML IOs Created";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataSet2Create.ReadXmlSchema("IOSchema.xsl");
            dataSetCyl.ReadXmlSchema("CylindersSchema.xsl");
            dataGridView1.DataSource = dataSetCyl.Tables[0].DefaultView;
        }

    }
}

