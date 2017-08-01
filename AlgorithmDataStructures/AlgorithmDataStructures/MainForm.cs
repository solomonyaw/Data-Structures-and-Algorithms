using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinaryTree;


namespace AlgorithmDataStructures
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchingAlgorithms searching = new SearchingAlgorithms();
            searching.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SortingAlgorithms sorting = new SortingAlgorithms();
            sorting.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Trees trees = new Trees();
            trees.ShowDialog();
            
            
            
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.UseVisualStyleBackColor = false;
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.UseVisualStyleBackColor = false;
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.ForeColor = Color.Black;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.UseVisualStyleBackColor = false;
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.UseVisualStyleBackColor = false;
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button3.ForeColor = Color.Black;
        }

        

        private void button4_MouseLeave(object sender, EventArgs e)
        {
        button4.UseVisualStyleBackColor = false;
            button4.BackColor = Color.FromArgb(192, 192, 255);
            button4.ForeColor = Color.Black;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.UseVisualStyleBackColor = false;
            button4.BackColor = Color.Red;
            button4.ForeColor = Color.White;
            double currentSize = button4.Font.Size;
            currentSize *= 3;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.UseVisualStyleBackColor = false;
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
            double currentSize = button1.Font.Size;
            currentSize *= 3;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.UseVisualStyleBackColor = false;
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StackandQueus stacks = new StackandQueus();
            stacks.ShowDialog();
        }
        
    }
}
