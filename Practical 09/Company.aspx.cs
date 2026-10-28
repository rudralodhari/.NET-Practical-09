
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Practical_09
{
    public partial class Company : System.Web.UI.Page
    {
        string cs = ConfigurationManager
            .ConnectionStrings["PlacementDBConnection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCompanyTable();
                LoadCompanyDetails();
            }
        }

        // First function: Display table using Repeater
        private void LoadCompanyTable()
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT * FROM Placements";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            rptCompanyTable.DataSource = dr;
            rptCompanyTable.DataBind();

            dr.Close();
            con.Close();
        }

        // Second function: Display details using DataAdapter
        private void LoadCompanyDetails()
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT * FROM Placements";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            rptCompanyDetails.DataSource = dt;
            rptCompanyDetails.DataBind();
        }
    }
}
