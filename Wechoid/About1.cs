using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Wechoid
{
    public partial class About1 : Telerik.WinControls.UI.RadForm
    {
        public About1()
        {
            InitializeComponent();
        }
        static About1 my_about;
       static DialogResult result = DialogResult.OK;
        public static DialogResult showAbout()
        {
            my_about = new About1();
            my_about.ShowDialog();
            return result;
        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            my_about.Close();
        }

    }
}
