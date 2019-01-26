namespace MuesuemForm
{
    partial class Form_register
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
            this.label_first_name = new System.Windows.Forms.Label();
            this.text_first_name = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.text_email = new System.Windows.Forms.TextBox();
            this.label_contact_number = new System.Windows.Forms.Label();
            this.text_contact_number = new System.Windows.Forms.TextBox();
            this.label_occupation = new System.Windows.Forms.Label();
            this.combo_box_occupation = new System.Windows.Forms.ComboBox();
            this.button_save = new System.Windows.Forms.Button();
            this.lable_last_name = new System.Windows.Forms.Label();
            this.text_last_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_card_number = new System.Windows.Forms.TextBox();
            this.card_number = new System.Windows.Forms.Label();
            this.group_box_gender = new System.Windows.Forms.GroupBox();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.data_grid_view = new System.Windows.Forms.DataGridView();
            this.card_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entry_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exit_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.group_box_gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label_first_name
            // 
            this.label_first_name.AutoSize = true;
            this.label_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_first_name.Location = new System.Drawing.Point(17, 27);
            this.label_first_name.Name = "label_first_name";
            this.label_first_name.Size = new System.Drawing.Size(67, 15);
            this.label_first_name.TabIndex = 0;
            this.label_first_name.Text = "First Name";
            // 
            // text_first_name
            // 
            this.text_first_name.Location = new System.Drawing.Point(181, 27);
            this.text_first_name.Name = "text_first_name";
            this.text_first_name.Size = new System.Drawing.Size(121, 20);
            this.text_first_name.TabIndex = 1;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(17, 126);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(39, 15);
            this.label_email.TabIndex = 2;
            this.label_email.Text = "Email";
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(181, 121);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(121, 20);
            this.text_email.TabIndex = 3;
            // 
            // label_contact_number
            // 
            this.label_contact_number.AutoSize = true;
            this.label_contact_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contact_number.Location = new System.Drawing.Point(17, 170);
            this.label_contact_number.Name = "label_contact_number";
            this.label_contact_number.Size = new System.Drawing.Size(103, 15);
            this.label_contact_number.TabIndex = 4;
            this.label_contact_number.Text = "Contanct Number";
            // 
            // text_contact_number
            // 
            this.text_contact_number.Location = new System.Drawing.Point(181, 165);
            this.text_contact_number.Name = "text_contact_number";
            this.text_contact_number.Size = new System.Drawing.Size(121, 20);
            this.text_contact_number.TabIndex = 6;
            // 
            // label_occupation
            // 
            this.label_occupation.AutoSize = true;
            this.label_occupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_occupation.Location = new System.Drawing.Point(17, 217);
            this.label_occupation.Name = "label_occupation";
            this.label_occupation.Size = new System.Drawing.Size(69, 15);
            this.label_occupation.TabIndex = 7;
            this.label_occupation.Text = "Occupation";
            // 
            // combo_box_occupation
            // 
            this.combo_box_occupation.FormattingEnabled = true;
            this.combo_box_occupation.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.combo_box_occupation.Location = new System.Drawing.Point(181, 211);
            this.combo_box_occupation.Name = "combo_box_occupation";
            this.combo_box_occupation.Size = new System.Drawing.Size(121, 21);
            this.combo_box_occupation.TabIndex = 8;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(20, 351);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 9;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.Button_save_Click);
            // 
            // lable_last_name
            // 
            this.lable_last_name.AutoSize = true;
            this.lable_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_last_name.Location = new System.Drawing.Point(17, 74);
            this.lable_last_name.Name = "lable_last_name";
            this.lable_last_name.Size = new System.Drawing.Size(67, 15);
            this.lable_last_name.TabIndex = 10;
            this.lable_last_name.Text = "Last Name";
            // 
            // text_last_name
            // 
            this.text_last_name.Location = new System.Drawing.Point(181, 73);
            this.text_last_name.Name = "text_last_name";
            this.text_last_name.Size = new System.Drawing.Size(121, 20);
            this.text_last_name.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.text_card_number);
            this.panel1.Controls.Add(this.card_number);
            this.panel1.Controls.Add(this.group_box_gender);
            this.panel1.Controls.Add(this.label_gender);
            this.panel1.Controls.Add(this.label_first_name);
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Controls.Add(this.text_last_name);
            this.panel1.Controls.Add(this.combo_box_occupation);
            this.panel1.Controls.Add(this.text_first_name);
            this.panel1.Controls.Add(this.label_occupation);
            this.panel1.Controls.Add(this.lable_last_name);
            this.panel1.Controls.Add(this.text_contact_number);
            this.panel1.Controls.Add(this.label_email);
            this.panel1.Controls.Add(this.label_contact_number);
            this.panel1.Controls.Add(this.text_email);
            this.panel1.Location = new System.Drawing.Point(63, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 382);
            this.panel1.TabIndex = 12;
            // 
            // text_card_number
            // 
            this.text_card_number.Location = new System.Drawing.Point(181, 308);
            this.text_card_number.Name = "text_card_number";
            this.text_card_number.Size = new System.Drawing.Size(121, 20);
            this.text_card_number.TabIndex = 17;
            this.text_card_number.Leave += new System.EventHandler(this.Text_card_number_Leave);
            // 
            // card_number
            // 
            this.card_number.AutoSize = true;
            this.card_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_number.Location = new System.Drawing.Point(17, 308);
            this.card_number.Name = "card_number";
            this.card_number.Size = new System.Drawing.Size(81, 15);
            this.card_number.TabIndex = 16;
            this.card_number.Text = "Card Number";
            // 
            // group_box_gender
            // 
            this.group_box_gender.Controls.Add(this.rb_female);
            this.group_box_gender.Controls.Add(this.rb_male);
            this.group_box_gender.Location = new System.Drawing.Point(179, 248);
            this.group_box_gender.Name = "group_box_gender";
            this.group_box_gender.Size = new System.Drawing.Size(121, 37);
            this.group_box_gender.TabIndex = 15;
            this.group_box_gender.TabStop = false;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(56, 14);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(59, 17);
            this.rb_female.TabIndex = 14;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(2, 14);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(48, 17);
            this.rb_male.TabIndex = 13;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.Location = new System.Drawing.Point(17, 260);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(48, 15);
            this.label_gender.TabIndex = 12;
            this.label_gender.Text = "Gender";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(279, 30);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(194, 20);
            this.label_title.TabIndex = 13;
            this.label_title.Text = "Mueseum Member Details";
            // 
            // data_grid_view
            // 
            this.data_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.card_no,
            this.first_name,
            this.last_name,
            this.email,
            this.contact_number,
            this.occupation,
            this.gender,
            this.entry_time,
            this.exit_time});
            this.data_grid_view.Location = new System.Drawing.Point(411, 65);
            this.data_grid_view.Name = "data_grid_view";
            this.data_grid_view.Size = new System.Drawing.Size(377, 382);
            this.data_grid_view.TabIndex = 14;
            // 
            // card_no
            // 
            this.card_no.HeaderText = "Card Number";
            this.card_no.Name = "card_no";
            // 
            // first_name
            // 
            this.first_name.HeaderText = "First Name";
            this.first_name.Name = "first_name";
            // 
            // last_name
            // 
            this.last_name.HeaderText = "Last Name";
            this.last_name.Name = "last_name";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // contact_number
            // 
            this.contact_number.HeaderText = "Contact Number";
            this.contact_number.Name = "contact_number";
            // 
            // occupation
            // 
            this.occupation.HeaderText = "occupation";
            this.occupation.Name = "occupation";
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            // 
            // entry_time
            // 
            this.entry_time.HeaderText = "Entry Time";
            this.entry_time.Name = "entry_time";
            // 
            // exit_time
            // 
            this.exit_time.HeaderText = "Exit Time";
            this.exit_time.Name = "exit_time";
            // 
            // form_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data_grid_view);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel1);
            this.Name = "Form_register";
            this.Text = "Register Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.group_box_gender.ResumeLayout(false);
            this.group_box_gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_first_name;
        private System.Windows.Forms.TextBox text_first_name;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.Label label_contact_number;
        private System.Windows.Forms.TextBox text_contact_number;
        private System.Windows.Forms.Label label_occupation;
        private System.Windows.Forms.ComboBox combo_box_occupation;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label lable_last_name;
        private System.Windows.Forms.TextBox text_last_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.GroupBox group_box_gender;
        private System.Windows.Forms.TextBox text_card_number;
        private System.Windows.Forms.Label card_number;
        private System.Windows.Forms.DataGridView data_grid_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn entry_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn exit_time;
    }
}

