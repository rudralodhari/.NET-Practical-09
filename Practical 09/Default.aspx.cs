
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Practical_09
{
    public partial class Default : System.Web.UI.Page
    {
        string cs = ConfigurationManager
            .ConnectionStrings["PlacementDBConnection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSummary();
                LoadStudentDetails();
            }
        }

        // Load Summary
        void LoadSummary()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            // Total students
            SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM Students", con);
            int total = Convert.ToInt32(cmd.ExecuteScalar());

            // Placed students
            cmd = new SqlCommand(
                "SELECT COUNT(*) FROM Students WHERE IsPlaced=1", con);
            int placed = Convert.ToInt32(cmd.ExecuteScalar());

            // Not placed students
            cmd = new SqlCommand(
                "SELECT COUNT(*) FROM Students WHERE IsPlaced=0", con);
            int notPlaced = Convert.ToInt32(cmd.ExecuteScalar());

            // Placement percentage
            double percentage = 0;

            if (total > 0)
            {
                percentage = (placed * 100.0) / total;
            }

            // Maximum LPA
            cmd = new SqlCommand(
                "SELECT MAX(PackageLPA) FROM Placements", con);
            double maxLPA = Convert.ToDouble(cmd.ExecuteScalar());

            // Display values in labels
            lblTotal.Text = total.ToString();
            lblPlaced.Text = placed.ToString();
            lblNotPlaced.Text = notPlaced.ToString();
            lblPercentage.Text = percentage.ToString("0.00") + "%";
            lblMaxLPA.Text = maxLPA.ToString("0.00") + " LPA";

            con.Close();
        }

        // Load Student Details
        void LoadStudentDetails()
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT * FROM Students";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}
