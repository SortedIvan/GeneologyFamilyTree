using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nemetschek_Genealogy_Family_Tree
{
    public partial class Form1 : Form
    {
        private PersonManager personManager;
        public Form1()
        {
            InitializeComponent();
            this.personManager = new PersonManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.personManager.AddPerson(tbxFirstName.Text, tbxLastName.Text, cbGender.Checked);
            RefreshPeopleListBox();
        }

        private void RefreshPeopleListBox()
        {
            List<Person> allPeople = this.personManager.GetAllPeople();
            lbxPeople.Items.Clear();
            foreach(var v in allPeople)
            {
                lbxPeople.Items.Add(v);
            }

        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            lbxPeople.Items.Clear();
            lbxPeople.Items.Add(this.personManager.FindPersonByID(Convert.ToInt32(tbxPersonFind.Text)));
        }

        private void btnListAllPeople_Click(object sender, EventArgs e)
        {
            RefreshPeopleListBox();
        }

        private void btnSetMotherID_Click(object sender, EventArgs e)
        {
            this.personManager.SetMotherID(Convert.ToInt32(tbxPersonID.Text), Convert.ToInt32(tbxMotherID.Text));
            lbxPeople.Items.Clear();
            lbxPeople.Items.Add(this.personManager.FindPersonByID(Convert.ToInt32(tbxPersonID.Text)));
        }

        private void btnSetFatherID_Click(object sender, EventArgs e)
        {
            this.personManager.SetFatherID(Convert.ToInt32(tbxPersonID.Text), Convert.ToInt32(tbxFatherID.Text));
            lbxPeople.Items.Clear();
            lbxPeople.Items.Add(this.personManager.FindPersonByID(Convert.ToInt32(tbxPersonID.Text)));
        }
    }
}
