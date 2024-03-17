using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjWinform202344018
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

            //labelText.Text = "202344018";
            labelText.Text += Environment.NewLine;
            labelText.Text += "김대희";
               
        }
    }
}
