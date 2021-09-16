
namespace Nemetschek_Genealogy_Family_Tree
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbxPeople = new System.Windows.Forms.ListBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxPersonFind = new System.Windows.Forms.TextBox();
            this.tbxMotherID = new System.Windows.Forms.TextBox();
            this.tbxFatherID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.btnSetMotherID = new System.Windows.Forms.Button();
            this.btnSetFatherID = new System.Windows.Forms.Button();
            this.btnListAllPeople = new System.Windows.Forms.Button();
            this.tbxPersonID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(791, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 69);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 183);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add person";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxPeople
            // 
            this.lbxPeople.FormattingEnabled = true;
            this.lbxPeople.ItemHeight = 22;
            this.lbxPeople.Location = new System.Drawing.Point(604, 116);
            this.lbxPeople.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxPeople.Name = "lbxPeople";
            this.lbxPeople.Size = new System.Drawing.Size(435, 488);
            this.lbxPeople.TabIndex = 2;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(111, 34);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxFirstName.Multiline = true;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(148, 31);
            this.tbxFirstName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last name:";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(111, 86);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxLastName.Multiline = true;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(148, 31);
            this.tbxLastName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gender:";
            // 
            // cbGender
            // 
            this.cbGender.AutoSize = true;
            this.cbGender.Location = new System.Drawing.Point(111, 149);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(61, 26);
            this.cbGender.TabIndex = 10;
            this.cbGender.Text = "Male";
            this.cbGender.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "(Female if unchecked, male if checked)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(797, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "True value - male, false - female";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 310);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Get person by ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 471);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Set Mother ID:";
            // 
            // tbxPersonFind
            // 
            this.tbxPersonFind.Location = new System.Drawing.Point(361, 340);
            this.tbxPersonFind.Name = "tbxPersonFind";
            this.tbxPersonFind.Size = new System.Drawing.Size(100, 26);
            this.tbxPersonFind.TabIndex = 18;
            // 
            // tbxMotherID
            // 
            this.tbxMotherID.Location = new System.Drawing.Point(361, 496);
            this.tbxMotherID.Name = "tbxMotherID";
            this.tbxMotherID.Size = new System.Drawing.Size(100, 26);
            this.tbxMotherID.TabIndex = 19;
            // 
            // tbxFatherID
            // 
            this.tbxFatherID.Location = new System.Drawing.Point(366, 560);
            this.tbxFatherID.Name = "tbxFatherID";
            this.tbxFatherID.Size = new System.Drawing.Size(100, 26);
            this.tbxFatherID.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 535);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "Set Father ID:";
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.Location = new System.Drawing.Point(473, 335);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(119, 38);
            this.btnFindPerson.TabIndex = 22;
            this.btnFindPerson.Text = "Find";
            this.btnFindPerson.UseVisualStyleBackColor = true;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // btnSetMotherID
            // 
            this.btnSetMotherID.Location = new System.Drawing.Point(478, 491);
            this.btnSetMotherID.Name = "btnSetMotherID";
            this.btnSetMotherID.Size = new System.Drawing.Size(119, 38);
            this.btnSetMotherID.TabIndex = 23;
            this.btnSetMotherID.Text = "Set";
            this.btnSetMotherID.UseVisualStyleBackColor = true;
            this.btnSetMotherID.Click += new System.EventHandler(this.btnSetMotherID_Click);
            // 
            // btnSetFatherID
            // 
            this.btnSetFatherID.Location = new System.Drawing.Point(478, 555);
            this.btnSetFatherID.Name = "btnSetFatherID";
            this.btnSetFatherID.Size = new System.Drawing.Size(119, 38);
            this.btnSetFatherID.TabIndex = 24;
            this.btnSetFatherID.Text = "Set";
            this.btnSetFatherID.UseVisualStyleBackColor = true;
            this.btnSetFatherID.Click += new System.EventHandler(this.btnSetFatherID_Click);
            // 
            // btnListAllPeople
            // 
            this.btnListAllPeople.Location = new System.Drawing.Point(478, 116);
            this.btnListAllPeople.Name = "btnListAllPeople";
            this.btnListAllPeople.Size = new System.Drawing.Size(119, 38);
            this.btnListAllPeople.TabIndex = 25;
            this.btnListAllPeople.Text = "List all";
            this.btnListAllPeople.UseVisualStyleBackColor = true;
            this.btnListAllPeople.Click += new System.EventHandler(this.btnListAllPeople_Click);
            // 
            // tbxPersonID
            // 
            this.tbxPersonID.Location = new System.Drawing.Point(216, 520);
            this.tbxPersonID.Name = "tbxPersonID";
            this.tbxPersonID.Size = new System.Drawing.Size(100, 26);
            this.tbxPersonID.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 492);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 22);
            this.label9.TabIndex = 27;
            this.label9.Text = "Enter person ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 636);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxPersonID);
            this.Controls.Add(this.btnListAllPeople);
            this.Controls.Add(this.btnSetFatherID);
            this.Controls.Add(this.btnSetMotherID);
            this.Controls.Add(this.btnFindPerson);
            this.Controls.Add(this.tbxFatherID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxMotherID);
            this.Controls.Add(this.tbxPersonFind);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lbxPeople);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Family tree application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbxPeople;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxPersonFind;
        private System.Windows.Forms.TextBox tbxMotherID;
        private System.Windows.Forms.TextBox tbxFatherID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.Button btnSetMotherID;
        private System.Windows.Forms.Button btnSetFatherID;
        private System.Windows.Forms.Button btnListAllPeople;
        private System.Windows.Forms.TextBox tbxPersonID;
        private System.Windows.Forms.Label label9;
    }
}

