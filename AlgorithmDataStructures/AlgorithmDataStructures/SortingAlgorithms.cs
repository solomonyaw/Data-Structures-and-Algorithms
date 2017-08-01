using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmDataStructures
{
    public partial class SortingAlgorithms : Form
    {
        int[] elements = new int[5];
        List<Label> labels = new List<Label>();
        int len = 5;
        public SortingAlgorithms()
        {
            InitializeComponent();
        }

        private void insertionSort()
        {
            int temp, j;
            for (int i = 1; i < elements.Length; i++)
            {
                temp = elements[i];
                j = i - 1;

                while (j >= 0 && elements[j] > temp)
                {
                    elements[j + 1] = elements[j];
                    j--;
                }

                elements[j + 1] = temp;
            }
        }
        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }


        }

        public void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (elements[left] <= elements[mid])
                    temp[tmp_pos++] = elements[left++];
                else
                    temp[tmp_pos++] = elements[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = elements[left++];

            while (mid <= right)
                temp[tmp_pos++] = elements[mid++];

            for (i = 0; i < num_elements; i++)
            {
                elements[right] = temp[right];
                right--;
            }
        }

         public void MergeSort_Recursive(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(elements, left, mid);
                MergeSort_Recursive(elements, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);
            }
        }

        private void bubbleSort()
        {

            int temp;
            for (int pass = 1; pass <= elements.Length - 2; pass++)
            {
                for (int i = 0; i <= elements.Length - 2; i++)
                {
                    if (elements[i] > elements[i + 1])
                    {
                        temp = elements[i + 1];
                        elements[i + 1] = elements[i];
                        elements[i] = temp;
                    }

                }

            }
        }

        private void ShellSort(int[] elements)
        {

            int n = elements.Length;
            int gap = n / 2;
            int temp;

            while (gap > 0)
            {
                for (int i = 0; i + gap < n; i++)
                {
                    int j = i + gap;
                    temp = elements[j];

                    while (j - gap >= 0 && temp < elements[j - gap])
                    {
                        elements[j] = elements[j - gap];
                        j = j - gap;
                    }

                    elements[j] = temp;
                }

                gap = gap / 2;
            }
        }
           

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           sortingComboBox.Items.Add("Select a sorting algorithm");
           sortingComboBox.Items.Add("Sort elements with shell sort ");
           sortingComboBox.Items.Add("Sort elements with Bubble sort ");
           sortingComboBox.Items.Add("Sort elements with Merge sort ");
           sortingComboBox.Items.Add("Sort elements with Quick sort ");
           sortingComboBox.Items.Add("Sort elements with Insertion sort ");
           sortingComboBox.SelectedIndex = 0;
           labels.Add(index1Label);
           labels.Add(index2Label);
           labels.Add(index3Label);
           labels.Add(index4Label);
           labels.Add(index5Label);
        }

        private void btnAddValue_Click(object sender, EventArgs e)
        {
            int number1,number2,number3,number4,number5;
            if (int.TryParse(txtElement1.Text, out number1))
            {
                if (int.TryParse(txtElement2.Text, out number2))
                {
                    if (int.TryParse(txtElement3.Text, out number3))
                    {
                        if (int.TryParse(txtElement4.Text, out number4))
                        {
                            if (int.TryParse(txtElement5.Text, out number5))
                        {
              for(int i=0;i<elements.Length;i++)
              {
                     
                    number1 = int.Parse(txtElement1.Text);
                    number2 = int.Parse(txtElement2.Text);
                    number3 = int.Parse(txtElement3.Text);
                    number4 = int.Parse(txtElement4.Text);
                    number5 = int.Parse(txtElement5.Text);

                  elements[0] = number1;
                  elements[1] = number2;
                  elements[2] = number3;
                  elements[3] = number4;
                  elements[4] = number5;
                


                  labels[0].Text = elements[0].ToString();
                  labels[1].Text = elements[1].ToString();
                  labels[2].Text = elements[2].ToString();
                  labels[3].Text = elements[3].ToString();
                  labels[4].Text = elements[4].ToString();
                  
               
                 labels[0].Text = elements[0].ToString();
                 labels[1].Text = elements[1].ToString();
                 labels[2].Text = elements[2].ToString();
                 labels[3].Text = elements[3].ToString();
                 labels[4].Text = elements[4].ToString();
              }


                        }
                            else
                            {
                                MessageBox.Show("You entered invalid data");
                            }
                        }
                        else
                        {
                            MessageBox.Show("You entered invalid data");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You entered invalid data");
                    }
                }
                else
                {
                    MessageBox.Show("You entered invalid data");
                }
            }
            else
            {
                MessageBox.Show("You entered invalid data");
            }
    
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (sortingComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Select a sorting Algorithm");
            }
            if (sortingComboBox.SelectedIndex == 1)
            {
                ShellSort(elements);
                for (int i = 0; i < elements.Length; i++)
                {
                    
                    sortedListBox.Items.Add(elements[i]);
                }
                sortingLabel.Text = "Elements sorted with shell Sorting";
            }

            if (sortingComboBox.SelectedIndex == 2)
            {
                bubbleSort();
                for (int i = 0; i < elements.Length; i++)
                {
                   
                    sortedListBox.Items.Add(elements[i]);
                }
                sortingLabel.Text = "Elements sorted with Bubble Sorting"; 
            }

            if (sortingComboBox.SelectedIndex == 3)
            {
                MergeSort_Recursive(elements, 0, len - 1);
                for (int i = 0; i < 5; i++)
                {
                    sortedListBox.Items.Add(elements[i]);
                }
                sortingLabel.Text = "Elements sorted with Merge Sorting";
            }

            if (sortingComboBox.SelectedIndex == 4)
            {
                Quicksort(elements, 0, elements.Length - 1);
                // Print the sorted array
                for (int i = 0; i < elements.Length; i++)
                {
                    sortedListBox.Items.Add(elements[i]);

                }

                sortingLabel.Text = "Elements sorted with Quick Sorting";
            }
            if (sortingComboBox.SelectedIndex == 5)
            {
                insertionSort();
                for (int i = 0; i < elements.Length; i++)
                {

                   sortedListBox.Items.Add(elements[i]);
                }
                sortingLabel.Text = "Elements sorted with Insertion Sorting";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            sortedListBox.Items.Clear();
        }

        private void SortingAlgorithms_Load(object sender, EventArgs e)
        {

        }

        private void btnAddValue_MouseHover(object sender, EventArgs e)
        {
            btnAddValue.UseVisualStyleBackColor = false;
            btnAddValue.BackColor = Color.Red;
            btnAddValue.ForeColor = Color.White;
        }

        private void btnAddValue_MouseLeave(object sender, EventArgs e)
        {
            btnAddValue.UseVisualStyleBackColor = false;
            btnAddValue.BackColor = Color.FromArgb(192, 192, 255);
            btnAddValue.ForeColor = Color.Black;
        }

        private void btnSort_MouseHover(object sender, EventArgs e)
        {
            btnSort.UseVisualStyleBackColor = false;
            btnSort.BackColor = Color.Red;
            btnSort.ForeColor = Color.White;
        }

        private void btnSort_MouseLeave(object sender, EventArgs e)
        {
            btnSort.UseVisualStyleBackColor = false;
            btnSort.BackColor = Color.FromArgb(192, 192, 255);
            btnSort.ForeColor = Color.Black;
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.UseVisualStyleBackColor = false;
            btnClear.BackColor = Color.Red;
            btnClear.ForeColor = Color.White;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.UseVisualStyleBackColor = false;
            btnClear.BackColor = Color.FromArgb(192, 192, 255);
            btnClear.ForeColor = Color.Black;
   
        }
    }
}
