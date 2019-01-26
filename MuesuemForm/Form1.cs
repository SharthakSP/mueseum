using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MuesuemForm

{
    public partial class Form_register : Form
    {
        List<Visitor> list = new List<Visitor>();
        public Form_register()
        {
            InitializeComponent();
            Load_from_csv();
            Fill_data();
        }

       
        private void Button_save_Click(object sender, EventArgs e)
        {
            Visitor v = new Visitor();

            v.First_name = text_first_name.Text;
            v.Last_name = text_last_name.Text;
            v.Email = text_email.Text;
            v.Contact_number = text_contact_number.Text;

            v.Occupation = combo_box_occupation.Text;
            if (rb_male.Checked)
            {
                v.Gender = "Male";
            }
            else
            {
                v.Gender = "Female";
            }

            v.Entry_time = DateTime.Now;
           
            //to generate card_number
            Random rand = new Random();
            v.Text_card_number = rand.Next(1000, 9999);

            string data = v.Text_card_number + "," + v.First_name + "," + v.Last_name + "," + v.Email + "," + v.Contact_number + "," + v.Occupation + "," + v.Gender + "," + v.Entry_time + "," + v.Exit_time + ";";
            Save_to_csv(data);
            list.Add(v);
            Fill_data();
            Console.WriteLine(list[0]);
        }

        private void Save_to_csv(String data)
        {
            string path = @"mueseum.csv";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            using(var write = File.AppendText(path))
            {
                write.WriteLine(data);
                //File.AppendAllText(path, data);
            }
        }
        
        private void Load_from_csv()
        {
            string path = @"mueseum.csv";
            using (var read = new StreamReader(path))
            {
                string lines;
                    while((lines = read.ReadLine())!= null)
                {
                    var split_lines = lines.Split(';');
                    var split_data = split_lines[0].Split(',');
                    //Console.WriteLine(split_data);
                    Visitor v = new Visitor();
                    v.Text_card_number = Convert.ToInt32(split_data[0]);
                    v.First_name = split_data[1];
                    v.Last_name = split_data[2];
                    v.Email = split_data[3];
                    v.Contact_number = split_data[4];
                    v.Occupation = split_data[5];
                    v.Gender = split_data[6];
                    v.Entry_time = DateTime.Parse(split_data[7]);
                    v.Exit_time = DateTime.Parse(split_data[8]);
                    list.Add(v);
                }
                  
            }
        }

        private void Fill_data()
        {
            data_grid_view.Rows.Clear();
            foreach(Visitor visitor in list)
            {
                data_grid_view.Rows.Add(
                    visitor.Text_card_number,
                    visitor.First_name,
                    visitor.Last_name,
                    visitor.Email,
                    visitor.Contact_number,
                    visitor.Occupation,
                    visitor.Gender,
                    visitor.Entry_time,
                    visitor.Exit_time
                    );
            }

        }

        private void Text_card_number_Leave(object sender, EventArgs e)
        {
            int num = int.Parse(text_card_number.Text);
            try
            {
                var data = list.First(v => v.Text_card_number == num);
                if (data != null)
                {
                    text_first_name.Text = data.First_name;
                    text_last_name.Text = data.Last_name;
                    text_email.Text = data.Email;
                    text_contact_number.Text = data.Contact_number;
                    combo_box_occupation.Text = data.Occupation;
                    //gender.Selected = data.gender;
                }
            }
            catch (InvalidOperationException)
            {
                System.Windows.Forms.MessageBox.Show("The card number does not match any member");
                
            }
       }
    }
}
