using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeeSawIndexApp
{
    public partial class psychologicalAnalysis : System.Web.UI.Page
    {
        static int Clicked = 0;
        SqlConnection Sconnection = new SqlConnection("Data Source=SHREYAS;Initial Catalog=SeeSawIndex;Integrated Security=True;");
        SqlDataAdapter SDA;
        SqlCommand SCmd;
        SqlTransaction ST;
        DataTable DT = new DataTable();
        DataRow DR;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            int AlphaScore = 5;

            try
            {
                Sconnection.Open();

                SCmd = new SqlCommand("SELECT * FROM PsychologicalIndex", Sconnection);
                ST = Sconnection.BeginTransaction(IsolationLevel.ReadCommitted);
                SCmd.CommandType = CommandType.Text;
                SCmd.Transaction = ST;
                SCmd.CommandTimeout = 0;

                using (SDA = new SqlDataAdapter(SCmd))
                {
                    new SqlCommandBuilder(SDA);
                    SDA.Fill(DT);

                    if (DT.Rows.Count >= 0)
                    {
                        Clicked++;

                        DR = DT.NewRow();

                        DR["EventID"] = Clicked;
                        DR["Score"] = AlphaScore;
                        DT.Rows.Add(DR);
                        SDA.Update(DT);
                        ST.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                Sconnection.Close();
                //LblScore.Text = FinalScore.ToString();
            }
            
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            int VictoryScore = 4;

            try
            {
                Sconnection.Open();

                SCmd = new SqlCommand("SELECT * FROM PsychologicalIndex", Sconnection);
                ST = Sconnection.BeginTransaction(IsolationLevel.ReadCommitted);
                SCmd.CommandType = CommandType.Text;
                SCmd.Transaction = ST;
                SCmd.CommandTimeout = 0;

                using (SDA = new SqlDataAdapter(SCmd))
                {
                    new SqlCommandBuilder(SDA);
                    SDA.Fill(DT);

                    if (DT.Rows.Count >= 0)
                    {
                        Clicked++;

                        DR = DT.NewRow();

                        DR["EventID"] = Clicked;
                        DR["Score"] = VictoryScore;
                        DT.Rows.Add(DR);
                        SDA.Update(DT);
                        ST.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                Sconnection.Close();
                //LblScore.Text = FinalScore.ToString();
            }
            
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            int NeutralScore = 3;

            try
            {
                Sconnection.Open();

                SCmd = new SqlCommand("SELECT * FROM PsychologicalIndex", Sconnection);
                ST = Sconnection.BeginTransaction(IsolationLevel.ReadCommitted);
                SCmd.CommandType = CommandType.Text;
                SCmd.Transaction = ST;
                SCmd.CommandTimeout = 0;

                using (SDA = new SqlDataAdapter(SCmd))
                {
                    new SqlCommandBuilder(SDA);
                    SDA.Fill(DT);

                    if (DT.Rows.Count >= 0)
                    {
                        Clicked++;

                        DR = DT.NewRow();

                        DR["EventID"] = Clicked;
                        DR["Score"] = NeutralScore;
                        DT.Rows.Add(DR);
                        SDA.Update(DT);
                        ST.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                Sconnection.Close();
                //LblScore.Text = FinalScore.ToString();
            }
           
        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {

            int AshamedScore = 2;

            try
            {
                Sconnection.Open();

                SCmd = new SqlCommand("SELECT * FROM PsychologicalIndex", Sconnection);
                ST = Sconnection.BeginTransaction(IsolationLevel.ReadCommitted);
                SCmd.CommandType = CommandType.Text;
                SCmd.Transaction = ST;
                SCmd.CommandTimeout = 0;

                using (SDA = new SqlDataAdapter(SCmd))
                {
                    new SqlCommandBuilder(SDA);
                    SDA.Fill(DT);

                    if (DT.Rows.Count >= 0)
                    {
                        Clicked++;

                        DR = DT.NewRow();

                        DR["EventID"] = Clicked;
                        DR["Score"] = AshamedScore;
                        DT.Rows.Add(DR);
                        SDA.Update(DT);
                        ST.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                Sconnection.Close();
                //LblScore.Text = FinalScore.ToString();
            }            
        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            int DefeatScore = 1;

            try
            {
                Sconnection.Open();

                SCmd = new SqlCommand("SELECT * FROM PsychologicalIndex", Sconnection);
                ST = Sconnection.BeginTransaction(IsolationLevel.ReadCommitted);
                SCmd.CommandType = CommandType.Text;
                SCmd.Transaction = ST;
                SCmd.CommandTimeout = 0;

                using (SDA = new SqlDataAdapter(SCmd))
                {
                    new SqlCommandBuilder(SDA);
                    SDA.Fill(DT);

                    if (DT.Rows.Count >= 0)
                    {
                        Clicked++;

                        DR = DT.NewRow();

                        DR["EventID"] = Clicked;
                        DR["Score"] = DefeatScore;
                        DT.Rows.Add(DR);
                        SDA.Update(DT);
                        ST.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                Sconnection.Close();
                //LblScore.Text = FinalScore.ToString();
            }
        }

        protected void Chart1_Load(object sender, EventArgs e)
        {
            Chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        protected void Unnamed6_Click(object sender, EventArgs e)
        {
            if (Chart1.Series.Count > 0)
                Chart1.Series.RemoveAt(0);
            try
            {
                Sconnection.Open();

                SCmd = new SqlCommand("DELETE  FROM PsychologicalIndex", Sconnection);
                SCmd.ExecuteNonQuery();
                ST = Sconnection.BeginTransaction(IsolationLevel.ReadCommitted);
                SCmd.CommandType = CommandType.Text;
                SCmd.Transaction = ST;
                SCmd.CommandTimeout = 0;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                //LblScore.Text = empty.ToString();
                Sconnection.Close();
                Clicked = 0;
            }
        }
    }
}