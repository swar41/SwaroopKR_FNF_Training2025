using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebFormsApp.Hackathon2.Q1
{
    public partial class AddWords : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblWord.Text = Request.QueryString["word"];
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            WordStore.Add(lblWord.Text, txtTranslation.Text);
            Label1.Text = "Translation Added Succesfully";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowAllWords.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchWords.aspx");

        }
    }
}