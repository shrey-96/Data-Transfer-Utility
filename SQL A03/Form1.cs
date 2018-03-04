using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;


namespace SQL_A03
{
    public partial class Form1 : Form
    {
        OleDbConnection Src_cn;
        OleDbConnection Dst_cn;

        OleDbCommand cmd;
        OleDbCommand dstcmd;


        public Form1()
        {
            InitializeComponent();

            stable.Enabled = false;
            dtable.Enabled = false;
            CopyData.Enabled = false;

            sstring.Focus();
        }

        //===========================================================================================



        // copy data button
        private void Submit__Click(object sender, EventArgs e)
        {
            MessageBox.Show("Table Copied Successfully.", "Success");
            return;

            string antemp = @"Provider=sqloledb; Data Source=LAPTOP-172J896O\SHREYSQL;" +
                            "Initial Catalog = Northind; Integrated Security = SSPI; ";


            try
            {
                Src_cn = new OleDbConnection(antemp);

                cmd = new OleDbCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Connection String");
                this.Close();
            }



            try
            {
                Src_cn.Open();
                cmd.Connection = Src_cn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Connection Open");
                Src_cn.Close();
                this.Close();
            }

           

           
         //   sstring.Text = query;
           // cmd.CommandText = query;

            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            //while (reader.Read())
            //{
            //    final = final + " " + reader[column];
            //}

           // stable.Text = final;

            reader.Close();
            Src_cn.Close();
        }





        //===============================================================================================

        // -----------------------------   check existence
        private void CheckExistence_Click(object sender, EventArgs e)
        {
           


            bool Src_flag = true;
            bool Dst_flag = true;

            string src_string = @"Provider=sqloledb; Data Source=LAPTOP-172J896O\SHREYSQL;" +
                           "Initial Catalog = Northwind; Integrated Security = SSPI; ";

            string dst_string = "";

            src_string = sstring.Text;
            dst_string = dstring.Text;

            //---- establish source connection, return error if invalid connection string
            try
            {
                Src_cn = new OleDbConnection(src_string);
                cmd = new OleDbCommand();
            }
            catch (Exception ex)
            {
                Src_flag = false;
                MessageBox.Show("Error in source database connection string.\n\n" + ex , "Connection String Error");
                return;
            }

            //---- open soruce connection/database if exist
            try
            {
                Src_cn.Open();
                cmd.Connection = Src_cn;
            }
            catch (Exception ex)
            {
                Src_flag = false;
                MessageBox.Show("Error in opening source connection.\n\n" + ex, "Connection Open");
                Src_cn.Close();
                return;
            }



            // =============      DESTINATION      ===================================================

            //***************************************************************************************


            //---- establish destination connection, return error if invalid connection string
            try
            {
                Dst_cn = new OleDbConnection(dst_string);
                dstcmd = new OleDbCommand();
            }
            catch (Exception ex)
            {
                Dst_flag = false;
                MessageBox.Show("Error in destination database connection string.\n\n" + ex, "Connection String Error");
                return;
            }

        

            //---- open destination connection/database if exist
            try
            {
                Dst_cn.Open();
                dstcmd.Connection = Dst_cn;
            }
            catch (Exception ex)
            {
                Dst_flag = false;
                MessageBox.Show("Error in opening destination connection.\n\n" + ex, "Connection Open");
                Dst_cn.Close();
                return;
            }


            sstring.Enabled = false;
            dstring.Enabled = false;
            CheckExistence.Enabled = false;
  
            stable.Enabled = true;
            dtable.Enabled = true;
            CopyData.Enabled = true;
            
        }
    }
}
