using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebFormsApp.Hackathon2.Q1
{
    public partial class ShowAllWords : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            gvWords.DataSource = WordStore.GetAll();
            gvWords.DataBind();
        }
    }
}