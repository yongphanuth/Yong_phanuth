using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            /*String[] rr = new string[4];
            ListViewItem itm;
            rr[0] = "Damrith";
            rr[1] = "Male";
            rr[2] = "012345678";
            rr[3] = "phnom penh #271";
            itm = new ListViewItem(rr);
            listView1.Items.Add(itm);*/
        }

        private void add_Click(object sender, EventArgs e)
        {
            String[] storeData = new String [4];
            ListViewItem itm;
            storeData[0] = textName.Text;
            storeData[1] = camboGender.Text;
            storeData[2] = textPhone.Text;
            storeData[3] = textAddress.Text;
            itm = new ListViewItem(storeData);
            listView1.Items.Add(itm);
            textName.Clear();textPhone.Clear();textAddress.Clear();
            camboGender.SelectedIndex = -1;
            textName.Focus();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i += 1)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                    i--;
                }
            }
        }
    }
}
