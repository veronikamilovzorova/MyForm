using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Windows.Forms;
using System.Drawing;

namespace MyForm
{
    public partial class MyForm : Form
    {
        
        ComboBox comboBox;
        Label label;
        Panel panel;
        TextBox textBox;
        GroupBox groupBox;
        RichTextBox richTextBox;
        ListBox listBox;
        CheckBox checkBox1;
        CheckBox checkBox2;
        RadioButton radioButton;
        Button button;

        public MyForm()
        {
            this.Height = 600;
            this.Width = 800;
            this.Text = "Vorm põhielementidega";
            panel = new Panel();
            panel.Location = new Point(25, 25);
            panel.Size = new Size(10, 10);
            panel.TabIndex = 4;
            panel.BackColor = Color.Orange;
            panel.SendToBack();
            this.Controls.Add(panel);



            button = new Button();
            button.Location = new Point(700, 440);
            button.Height = 50;
            button.Width = 60;
            button.Text = "Выполнить";
            button.Click += Button_Click;
            button.TabIndex = 1;
            button.Visible= true;
            button.BackColor = Color.Yellow; // Устанавливаем желтый цвет фона для кнопки


            comboBox = new ComboBox();
            comboBox.Location = new Point(25, 60);
            comboBox.Width = 150;
            comboBox.TabIndex = 2;
            comboBox.BackColor = Color.LightCyan;

            label = new Label();
            label.Location = new Point(25, 25);
            label.Text = "Метка";
            label.TabIndex = 3;
            label.BackColor = Color.DarkOrange;

            

            textBox = new TextBox();
            textBox.Location = new Point(25, 365);
            textBox.Width = 150;
            textBox.TabIndex = 5;
            textBox.BackColor = Color.Yellow;

            groupBox = new GroupBox();
            groupBox.Location = new Point(25, 400);
            groupBox.Text = "Группа";
            groupBox.TabIndex = 6;
            groupBox.BackColor = Color.Yellow;
            


            richTextBox = new RichTextBox();
            richTextBox.Location = new Point(550, 25);
            richTextBox.Size = new Size(230, 400);
            richTextBox.TabIndex = 7;
            richTextBox.BackColor = Color.Pink;

            listBox = new ListBox();
            listBox.Location = new Point(25, 100);
            listBox.Width = 150;
            listBox.Height = 250;
            listBox.TabIndex = 8;
            listBox.BackColor = Color.Green;

            checkBox1 = new CheckBox();
            checkBox1.Location = new Point(240, 410);
            checkBox1.Text = "CheckBox 1";
            checkBox1.TabIndex = 9;
            checkBox1.BackColor = Color.Black;

            checkBox2 = new CheckBox();
            checkBox2.Location = new Point(240, 440);
            checkBox2.Text = "CheckBox 2";
            checkBox2.TabIndex = 10;
            checkBox2.BackColor = Color.Blue;

            radioButton = new RadioButton();
            radioButton.Location = new Point(550, 500);
            radioButton.Text = "RadioButton";
            radioButton.TabIndex = 11;
            radioButton.BackColor = Color.Red;

            
            this.Controls.Add(comboBox);
            this.Controls.Add(label);
            
            this.Controls.Add(textBox);
            this.Controls.Add(groupBox);
            this.Controls.Add(richTextBox);
            this.Controls.Add(listBox);
            this.Controls.Add(checkBox1);
            this.Controls.Add(checkBox2);
            this.Controls.Add(radioButton);
            this.Controls.Add(button);
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
