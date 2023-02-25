using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


    public partial class Form1 : Form
    {
        // set default font and size
        Font sFont = new Font("Arial", 14);
        Font mFont = new Font("Arial", 18);
        Font lFont = new Font("Arial", 20);
        int point, seconds;
        bool gameState = false;//False = New---True = Running
        bool btnReg = false; //False = Running---True = New
        string path = AppDomain.CurrentDomain.BaseDirectory + "High_Score.csv";//set dynamic path for Score recordings
        String userName;
        public Form1()
        {
            InitializeComponent();
        }

        private void formTimer_Tick(object sender, EventArgs e)
        {
            if (!gameState && btnReg)
            {
                gameState = true;
                seconds = 60; //set timer value
                formTimer.Start();//start a timer
            }
            else if (gameState && btnReg)
            {
                timerBox.Text = seconds--.ToString();//to view remaining time in game
            }

            if (seconds < 0)
            {
                formTimer.Stop();
                gameState = false;
                btnReg = true;
                File.AppendAllText(path, Environment.NewLine + userName + "," + Convert.ToString(point));
                point = 0;
                pointBox.Text = Convert.ToString(point);
                MessageBox.Show("Game Over \r\nCan view records at " + path, "Game Over");//Show user a logging path
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            generateNumber();

            InputBox("User Name Input", "Please input your username, \r\n leave blank for anonymous", ref userName);

            if (!File.Exists(path))//Create a new files if there is no existing files
            {
                File.Create(path).Close();
                File.AppendAllText(path, "Username,Score");
            }


            if (userName == "")// if name blank use anonymous instead of ""
            {
                userName = "Anonymmous";
                label1.Font = sFont;
                label1.Text = "Welcome " + userName;
            }
            else
            {
                if(userName.Length > 9)// In case there is a long name
                {
                    label1.Font = sFont;
                    label1.Text = "Welcome " + userName;
                }
                else
                {
                    label1.Font = mFont;
                    label1.Text = "Welcome " + userName;
                }
                
            }


        }


        private void Submit_Click(object sender, EventArgs e)
        {
            if (!gameState && answerBox.Text != "")
            {
                btnReg = true;
                formTimer.Start();
            }
            if (answerBox.Text != "")
            {
                int answerInt = Convert.ToInt32(answerBox.Text);
                int number1 = Convert.ToInt32(number1Box.Text);
                int number2 = Convert.ToInt32(number2Box.Text);
                int sumCha = number1 + number2;

                if (answerInt == sumCha)
                {
                    point++;
                }
                else
                {
                    point--;
                }

                answerBox.Text = "";
                pointBox.Text = Convert.ToString(point);
                generateNumber();
            }

        }
        public void generateNumber()
        {
            int r1 = (new Random()).Next(10, 100);
            Thread.Sleep(10);//Prevent similar RNG
            int r2 = (new Random()).Next(10, 100);
            number1Box.Text = Convert.ToString(r1);
            number2Box.Text = Convert.ToString(r2);
        }

        

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Font = new Font("Arial", 12);
            label.Text = promptText;
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            label.SetBounds(36, 36, 180, 50);
            textBox.SetBounds(36, 86, 200, 50);
            buttonOk.SetBounds(50, 160, 80, 60);
            buttonCancel.SetBounds(150, 160, 80, 60);
            label.AutoSize = true;
            form.ClientSize = new Size(300, 250);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
            
        }

    }
}
