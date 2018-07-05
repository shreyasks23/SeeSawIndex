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
    public partial class Index : System.Web.UI.Page
    {

        static int Clicked = 0;
        SqlConnection Sconnection = new SqlConnection("Data Source=SHREYAS;Initial Catalog=SeeSawIndex;Integrated Security=True;");
        SqlDataAdapter SDA;
        SqlCommand SCmd;
        SqlTransaction ST;
        DataTable DT = new DataTable();
        DataRow DR;

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            int FinalScore = 5;

            try
            {
                Sconnection.Open();

                SCmd = new SqlCommand("SELECT * FROM SeeSawIndexScore", Sconnection);
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
                        DR["EventScore"] = FinalScore;
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
            int SemiFinal = 4;
            try
            {
                Sconnection.Open();

                SCmd = new SqlCommand("SELECT * FROM SeeSawIndexScore", Sconnection);
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
                        DR["EventScore"] = SemiFinal;
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
                //LblScore.Text = SemiFinal.ToString();
                Sconnection.Close();
            }
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            int DerbyMatch = 3;
            try
            {
                Sconnection.Open();

                SCmd = new SqlCommand("SELECT * FROM SeeSawIndexScore", Sconnection);
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
                        DR["EventScore"] = DerbyMatch;
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
                //LblScore.Text = DerbyMatch.ToString();
                Sconnection.Close();
            }
        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            int LeaderBoard = 2;
            try
            {
                Sconnection.Open();

                SCmd = new SqlCommand("SELECT * FROM SeeSawIndexScore", Sconnection);
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
                        DR["EventScore"] = LeaderBoard;
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
                //LblScore.Text = LeaderBoard.ToString();
                Sconnection.Close();
            }
        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            int RegularMatch = 1;
            try
            {
                Sconnection.Open();

                SCmd = new SqlCommand("SELECT * FROM SeeSawIndexScore", Sconnection);
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
                        DR["EventScore"] = RegularMatch;
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
                //LblScore.Text = RegularMatch.ToString();
                Sconnection.Close();
            }
        }

        protected void Unnamed6_Click(object sender, EventArgs e)
        {
            int comeBack = 5;
            try
            {
                Sconnection.Open();

                SCmd = new SqlCommand("SELECT * FROM SeeSawIndexScore", Sconnection);
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
                        DR["EventScore"] = comeBack;
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
                //LblScore.Text = comeBack.ToString();
                Sconnection.Close();
            }
        }

        protected void Unnamed7_Click(object sender, EventArgs e)
        {
            int allOut = 4;

            try
            {
                Sconnection.Open();

                SCmd = new SqlCommand("SELECT * FROM SeeSawIndexScore", Sconnection);
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
                        DR["EventScore"] = allOut;
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
                //LblScore.Text = allOut.ToString();
                Sconnection.Close();
            }
        }

        protected void Unnamed8_Click(object sender, EventArgs e)
        {
            int imprtntPlayer = 3;

            try
            {
                Sconnection.Open();

                SCmd = new SqlCommand("SELECT * FROM SeeSawIndexScore", Sconnection);
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
                        DR["EventScore"] = imprtntPlayer;
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
                //LblScore.Text = imprtntPlayer.ToString();
                Sconnection.Close();
            }
        }

        protected void Unnamed9_Click(object sender, EventArgs e)
        {
            int regularRaid = 2;
            try
            {
                Sconnection.Open();

                SCmd = new SqlCommand("SELECT * FROM SeeSawIndexScore", Sconnection);
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
                        DR["EventScore"] = regularRaid;
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
                //LblScore.Text = regularRaid.ToString();
                Sconnection.Close();
            }
        }

        protected void Unnamed10_Click(object sender, EventArgs e)
        {
            int empty = 1;
            try
            {
                Sconnection.Open();

                SCmd = new SqlCommand("SELECT * FROM SeeSawIndexScore", Sconnection);
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
                        DR["EventScore"] = empty;
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
                //LblScore.Text = empty.ToString();
                Sconnection.Close();
            }
        }

        protected void Chart1_Load(object sender, EventArgs e)
        {
            Chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Chart1.ChartAreas[0].AxisX.Title = "Event";
            Chart1.Series[0].IsValueShownAsLabel = true;
            Chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            Chart1.ChartAreas[0].AxisY.Title = "Score";
            Chart1.Series[0].Palette = System.Web.UI.DataVisualization.Charting.ChartColorPalette.Bright;

            

        }

        protected void Unnamed11_Click(object sender, EventArgs e)
        {
            Response.Redirect("psychologicalAnalysis.aspx");
        }

        protected void Unnamed12_Click(object sender, EventArgs e)
        {
            if (Chart1.Series.Count > 0)
                Chart1.Series.RemoveAt(0);
            try
            {
                Sconnection.Open();

                SCmd = new SqlCommand("DELETE  FROM SeeSawIndexScore", Sconnection);
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

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}