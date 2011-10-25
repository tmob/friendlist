using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FriendListApp
{
    public partial class _Default : System.Web.UI.Page
    {
        protected static int number = 0;
        protected static List<string> friendslist = new List<string>();

        protected void AddButtonClicked(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" & friendslist.Contains(TextBox1.Text) == false)
            {
                friendslist.Add(TextBox1.Text);
                number++;
                Label1.Text = "Number of Friends: " + number;
                Label2.Text = "Friend '" + TextBox1.Text + "' successfully added";
                TextBox1.Text = "";
            }

            else if (TextBox1.Text != "" & friendslist.Contains(TextBox1.Text) == true)
            {
                Label2.Text = "ERROR: Friend '" + TextBox1.Text + "' is already in your friends list";
                TextBox1.Text = "";
            }
        }

        protected void RemoveButtonClicked(object sender, EventArgs e)
        {
            if (TextBox2.Text != "" & friendslist.Contains(TextBox2.Text) == true)
            {
                friendslist.Remove(TextBox2.Text);
                number--;
                Label1.Text = "Number of Friends: " + number;
                Label2.Text = "Friend '" + TextBox2.Text + "' successfully removed";
                TextBox2.Text = "";
            }

            else if (TextBox2.Text != "" & friendslist.Contains(TextBox2.Text) == false)
            {
                Label2.Text = "ERROR: Friend '" + TextBox2.Text + "' does not exist!";
                TextBox2.Text = "";
            }
        }
    }
}
