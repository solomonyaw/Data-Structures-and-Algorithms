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
    public partial class SearchingAlgorithms : Form
    {
        int[] elements = new int[5];
        List<Label> labels = new List<Label>();
        
        public SearchingAlgorithms()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            searchingComboBox.Items.Add("Select an algorithm");
            searchingComboBox.Items.Add("Search Element with Linear Search");
            searchingComboBox.Items.Add("Search Element with Binary Search");
            searchingComboBox.SelectedIndex = 0;
            labels.Add(index1Label);
            labels.Add(index2Label);
            labels.Add(index3Label);
            labels.Add(index4Label);
            labels.Add(index5Label);
           
        }

        private void searchingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
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

        private void txtElements_Enter(object sender, EventArgs e)
        {
            
        }

        private void SearchingAlgorithms_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (searchingComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Select an algorithm");
            }
            if (searchingComboBox.SelectedIndex == 1)
            {
                int number;
                if (int.TryParse(txtSearch.Text, out number))
                {
                    number = int.Parse(txtSearch.Text);

                    for (int i = 0; i<elements.Length; i++)
                    {
                        if (elements[i] == number)
                        {
                            outputLabel.Text = "Search successful " + "The number " + elements[i] + " is found at index " + i;
                            break;
                        }
                        else
                        {
                            outputLabel.Text = "Search Unsuccessful";
                        }


                    }
                }
                else
                {
                    MessageBox.Show("You eneterd invalid data");
                }
            }
            if (searchingComboBox.SelectedIndex == 2)
            {
                int low = 0;
                int high = elements.Length - 1;

                int number;

                if (int.TryParse(txtSearch.Text, out number))
                {
                    number = int.Parse(txtSearch.Text);
                    while (low <= high)
                    {
                        int middle = (low + high) / 2;

                        if (number < elements[middle])
                        {
                            high = middle - 1;
                        }
                        else if (number > elements[middle])
                        {
                            low = middle + 1;
                        }

                        else if (number == elements[middle])
                        {
                            outputLabel.Text = "Search successful " + "The number " + number + " is found at index ";
                            break;
                        }

                       

                    }

                }
                else
                {
                    MessageBox.Show("You entered invalid data");
                }
            }
        }
    }
}
