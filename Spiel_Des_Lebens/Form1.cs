﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Spiel_Des_Lebens
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
         var carrer = new EducationPath(Data.Path.Training, Data.Profession.Social);
         var eventgenerator = new Eventgenerator(carrer);
         var test = eventgenerator.loadEvents();
         string output = "";
         foreach (var item in test)
         {
            output += item.id + "\r\n";
            foreach (var timings in item.requirements.timings)
            {
               output += "path: ";
               foreach (var path in timings.path)
               {
                  output += path;
                  output += " ";
               }
               output += "\r\n";

               output += "profession: ";
               foreach (var profession in timings.profession)
               {
                  output += profession;
                  output += " ";
               }
               output += "\r\n";

               output += "phase: ";
               foreach (var phase in timings.phase)
               {
                  output += phase;
                  output += " ";
               }
               output += "\r\n";
               output += "\r\n";


            }

         }
         textBox1.Text = output;
      }

        private void open_next(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Form2 mainForm = new Form2(txt_name.Text, txt_alter.Text, avatar, abschluss, true);
                mainForm.TopLevel = false;
                mainForm.FormBorderStyle = FormBorderStyle.None;
                mainForm.Dock = DockStyle.Fill;
                this.Controls.Add(mainForm);
                this.Tag = mainForm;
                mainForm.BringToFront();
                mainForm.Show();
            }
        }

      private Image avatar;
      private void changeAvatar(object sender, EventArgs e)
      {
         PictureBox img = (PictureBox)sender;
         avatar = img.Image;
      }

        private void load_test(object sender, EventArgs e)
        {
            //für das Bsp werden sie vorher gestzt
            Form2 t = new Form2("Mia Münstermann", "20", pictureBox1.Image, "Testaschlusss", false);
            t.Show();
            this.Hide();
        }


      private string abschluss;
      private void changePath(object sender, EventArgs e)
      {
         Button btn = (Button)sender;
         abschluss = btn.Text;
      }

      private void neues_Spiel_open(Object sender, EventArgs e)
      {
         Button btn = sender as Button;
         if (btn.Text == "Neues Spiel")
         {
            Layout_neues_Spiel.Visible = true;
            panel1.Visible = false;
         }
         else
         {
            textBox_mini_field.Text = btn.Text;
            panel2.Visible = true;
            button_mini_1.Visible = true;
            button_mini_2.Visible = true;
            button_mini_3.Visible = true;
            textBox_mini_field.Visible = true;
         }

      }
      private void open_main_menu(object sender, EventArgs e)
      {
         panel1.Visible = true;
         Layout_neues_Spiel.Visible = false;
      }

      private void txt_alter_KeyPress(object sender, KeyPressEventArgs e)
      {
         e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
      }

      private void Close_option_spiel_start(object sender, EventArgs e)
      {
         panel2.Visible = false;
         button_mini_1.Visible = false;
         button_mini_2.Visible = false;
         button_mini_3.Visible = false;
         textBox_mini_field.Visible = false;
      }

      private void button2_Validating(object sender, CancelEventArgs e)
      {
         if (string.IsNullOrEmpty(abschluss))
         {
            e.Cancel = true;
            errorProvider1.SetError(weiter_button, "Wähle einen Schulabschluss");
         }
         else if (string.IsNullOrEmpty(txt_name.Text))
         {
            e.Cancel = true;
            errorProvider1.SetError(weiter_button, "Bitte gebe einen namen ein");
         }
         else if (string.IsNullOrEmpty(txt_alter.Text) || Convert.ToInt16(txt_alter.Text) > 60 || Convert.ToInt16(txt_alter.Text) < 15)
         {
            e.Cancel = true;
            errorProvider1.SetError(weiter_button, "Wähle ein Alter zwischen 15 und 60");
         }
         else
         {
            e.Cancel = false;
            errorProvider1.SetError(weiter_button, null);
         }
      }
      public void CustomizeLinearGradients(PaintEventArgs e)
      {
         LinearGradientBrush linGrBrush = new LinearGradientBrush(
            new Point(0, 10),
            new Point(200, 10),
            Color.FromArgb(255, 0, 0, 0),     // Opaque black
            Color.FromArgb(255, 255, 0, 0));  // Opaque red

         float[] relativeIntensities = { 0.0f, 0.5f, 1.0f };
         float[] relativePositions = { 0.0f, 0.2f, 1.0f };

         //Create a Blend object and assign it to linGrBrush.
         Blend blend = new Blend();
         blend.Factors = relativeIntensities;
         blend.Positions = relativePositions;
         linGrBrush.Blend = blend;

         e.Graphics.FillEllipse(linGrBrush, 0, 30, 200, 100);
         e.Graphics.FillRectangle(linGrBrush, 0, 155, 500, 30);
      }
      private void accept_fict_btn_Click(object sender, EventArgs e)
      {
         fiction_panel.Visible = false;
      }
        private void education_path_TextChanged(object sender, EventArgs e)
        {
            profession_path.Items.Clear();
            if (education_path.Text == "Ausbildung")
            {
                profession_path.Items.AddRange(new object[] { "Krankenpflege", "Industriekaufmann", "Pharmazeutisch Technische Assistenz", "Fachinformatiker", "Rechtanwaltsfachangestellter" });
            }
            else if (education_path.Text == "Duales Studium")
            {
                profession_path.Items.AddRange(new object[] { "Angewandte Gesundheits- und Pflegewissenschaften", "BWL", "Angewandte Physik", "Angewandtes Informatikstudium", "Steuerwesen" });
            }
            else if (education_path.Text == "Studium")
            {
                profession_path.Items.AddRange(new object[] { "Medizinstudium", "BWL", "Physikstudium", "Informatikstudium", "Jurastudium" });
            }
        }
    }
}
