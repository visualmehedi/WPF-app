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

namespace Assignment4
{   
    /// <summary>
    /// initialize form
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        ///  initialization form 
        /// </summary>
        private void InitializeGUI()
        {
            timer.Start();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(dateTimePicker, "Click to open calender for date, write in time here.");
            timerlabel.Text = DateTime.Now.ToString("HH:mm:ss");
            comboBoxPrio.Items.Add(PriorityTypes.prType.Less_Important.ToString());
            comboBoxPrio.Items.Add(PriorityTypes.prType.Normal.ToString());
            comboBoxPrio.Items.Add(PriorityTypes.prType.Important.ToString());
            comboBoxPrio.Items.Add(PriorityTypes.prType.Very_Important.ToString());
            comboBoxPrio.SelectedIndex = 0;
            TodoListBox.Items.Clear();
            TodoListBox.Update();
            TodoListBox.Refresh();
        }

       /// <summary>
       /// adding data to ListBox
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            String dt = dateTimePicker.Value.ToString();
            dateTimePicker.ResetText();
            String dis = DescriptionBox.Text.ToString();
            DescriptionBox.ResetText();
            String priority = comboBoxPrio.Text.ToString();
            comboBoxPrio.SelectedIndex = 0;
            Task currTask = new Task(DateTime.Now);
            currTask.setDes(dis);
            currTask.setTime(dt);
            currTask.setPriority(priority);
            String row = currTask.getTime() + "\t" + currTask.getPriority() + "\t" + currTask.getDes();
            
            TodoListBox.Items.Add(row);
        }
        /// <summary>
        /// showing current date time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label8_Click(object sender, EventArgs e)
        {
            timerlabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        
        /// <summary>
        /// read data from text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String fileName = Application.StartupPath + "Task.txt";
            StreamReader reader = null;

            TodoListBox.Items.Clear();

            try 
            {
                String textin;
                reader = new StreamReader(fileName);
                while(!reader.EndOfStream)
                {
                    textin = reader.ReadLine();
                    TodoListBox.Items.Add(textin);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problem reading data from file!" + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
                
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close_d();
        }

        /// <summary>
        /// closing program
        /// </summary>
        private void close_d()
        {
            DialogResult buttonClicked = MessageBox.Show("Sure to exit program?", "Think Twice", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            switch (buttonClicked)
            {
                case DialogResult.OK:       
                
                //window will close here
                    Application.Exit();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }
        
        /// <summary>
        /// showing data on About menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();
        }
        
        private void comboBoxPrio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Save data into file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            String fileName = Application.StartupPath + "Task.txt";
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(fileName);

                for (int i = 0; i < TodoListBox.Items.Count; i++)
                {
                    writer.WriteLine(TodoListBox.Items[i].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem saving data to file!" + ex.Message);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// keeping the timer running on the program window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            timerlabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }        
    }
}
