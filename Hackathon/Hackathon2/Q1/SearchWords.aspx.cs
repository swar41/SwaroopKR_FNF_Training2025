using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebFormsApp.Hackathon2.Q1
{
    public partial class SearchWords : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            var word = txtWord.Text.Trim();
            var result = WordStore.Find(word);

            if (result != null)
            {
                lblResult.Text = $"Translation: {result.Translation}";
                btnShowAll.Visible = true;
                btnAdd.Visible = false;
            }
            else
            {
                lblResult.Text = "Word not found.";
                btnAdd.Visible = true;
                btnShowAll.Visible = false;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect($"AddWords.aspx?word={txtWord.Text}");
        }

        protected void btnShowAll_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowAllWords.aspx");
        }

    }
}