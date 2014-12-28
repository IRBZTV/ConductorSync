using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ConductorSync
{
    public partial class Form1 : Form
    {
        double Counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Enabled = true;
        }
        protected void Sync()
        {
            richTextBox1.Text = "";
            try
            {
                timer1.Enabled = false;
                timer1.Interval = 3600000;
               
                richTextBox1.Text += "*******************************************************" + "\n";
                richTextBox1.Text += " شروع همگام سازی:" + DateConversion.GD2JD(DateTime.Now) + " - " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "\n";
                richTextBox1.Text += "*******************************************************" + "\n";
                DateTime StartDelete;
                DateTime EndDelete;

                MyDBTableAdapters.CondTableAdapter Cond_Ta = new MyDBTableAdapters.CondTableAdapter();

                SchedulesService.ConductorSoapClient SchSrv = new SchedulesService.ConductorSoapClient();  
                MyDB.CondDataTable Con_Dt = Cond_Ta.Select_Progs(DateConversion.GD2JD(DateTime.Now).Remove(0,2));

                if (Con_Dt.Rows.Count > 0)
                {
                    try
                    {

                        StartDelete = DateTime.Parse(DateConversion.JD2GD("13" + Con_Dt.Rows[0]["date"].ToString()).ToShortDateString() + " " + Con_Dt.Rows[0]["time"].ToString());
                        EndDelete = DateTime.Now.AddDays(1);
                        richTextBox1.Text += "\n" + StartDelete.ToString();
                        richTextBox1.Text += "\n" + EndDelete.ToString();
                       // Sched_Ta.Delete_Schedules(StartDelete, EndDelete);
                        SchSrv.DeleteConductors(StartDelete, EndDelete, "gASutRUwesW+XEmAhA7ruzaSTuswun", "b_w5t5AkUbuZEn-8h65+z#gespuP!#");
                    }
                    catch
                    {
                        richTextBox1.Text += "\n" + "Error in Record  :" + Con_Dt.Rows[0]["caption"].ToString() + "\n";
                    }

                }               

                richTextBox1.Text += "================= کنداکتور  =================" + "\n";
                for (int i = 0; i < Con_Dt.Rows.Count; i++)
                {
                    Counter++;
                    try
                    {
                        DateTime Dt = DateTime.Parse(DateConversion.JD2GD("13" + Con_Dt.Rows[i]["date"].ToString()).ToShortDateString() + " " + Con_Dt.Rows[i]["time"].ToString());
                        string Url = Con_Dt.Rows[i]["Clacket"].ToString().Trim();
                     //   Sched_Ta.Insert_Schedules(Con_Dt.Rows[i]["program"].ToString().Trim(), Dt, "", Url, "", "");
                        SchSrv.InsertConductors(Con_Dt.Rows[i]["caption"].ToString().Trim(),
                            Con_Dt.Rows[i]["Description"].ToString().Trim(),
                            Con_Dt.Rows[i]["Duration"].ToString().Trim(),
                            Dt,
                            Url,
                            "gASutRUwesW+XEmAhA7ruzaSTuswun",
                            "b_w5t5AkUbuZEn-8h65+z#gespuP!#");

                      
                        richTextBox1.Text += Counter + "  ]     " + Con_Dt.Rows[i]["date"].ToString() + " - " + Con_Dt.Rows[i]["time"].ToString() + "  " + Con_Dt.Rows[i]["caption"].ToString().Trim() + "\n";

                        richTextBox1.SelectionStart = richTextBox1.Text.Length;
                        richTextBox1.ScrollToCaret();
                    }
                    catch
                    {
                        richTextBox1.Text += "\n" + "Error in Record  :" + Con_Dt.Rows[0]["caption"].ToString() + "\n";
                    }


                }
              
                richTextBox1.Text += "*******************************************************" + "\n";
                richTextBox1.Text += " اتمام همگام سازی:" + DateConversion.GD2JD(DateTime.Now) + " - " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "\n";
                richTextBox1.Text += "*******************************************************" + "\n";

                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
                timer1.Enabled = true;
            }
            catch (Exception Exp)
            {
                richTextBox1.Text = "\n" + Exp.Message + "\n";
                Counter = 0;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Sync();
        }
    }
}
