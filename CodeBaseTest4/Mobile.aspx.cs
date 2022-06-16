using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeBaseTest4
{
    public partial class Mobile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "select", "iphone", "Vivo X50", "vivo", "Xiaomi", "Xifun" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }



        }



        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Images/" + str + ".jfif";



        }




        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {



        }



        protected void Button1_Click1(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "iphone")
            {
                TextBox1.Text = "Rs 50000";
            }
            else if (DropDownList1.Text == "Vivo")
            {
                TextBox1.Text = "Rs 30000";
            }
            else if (DropDownList1.Text == "vivo")
            {
                TextBox1.Text = "Rs 24000";
            }
            else if (DropDownList1.Text == "Xiaomi")
            {
                TextBox1.Text = "Rs 22000";
            }
            else if (DropDownList1.Text == "Xifun")
            {
                TextBox1.Text = "Rs 15000";
            }



            else
            {
                TextBox1.Text = "Rs141000 ";
            }
        }
    }
}
