using System;
using System.Drawing;
using System.Windows.Forms;
using ZGraphTools;

namespace ImageFilters
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        byte[,] ImageMatrix;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open the browsed image and display it
                string OpenedFilePath = openFileDialog1.FileName;
                ImageMatrix = ImageOperations.OpenImage(OpenedFilePath);
                ImageOperations.DisplayImage(ImageMatrix, pictureBox1);

            }
        }

        private void btnZGraph_Click(object sender, EventArgs e)
        {
            int t = 1;
            try{ t = Convert.ToInt32(T_Value.Text); } catch(Exception exx) {  }
            int maxWindowSize = Convert.ToInt32(Max_Graph_Ws.Text);
            int N = maxWindowSize / 2;
            double[] x_values = new double[N];
            double[] y_values_1stAlgo = new double[N];
            double[] y_values_2ndAlgo = new double[N];
            double time1, time2;

            if (Filter_Type.SelectedIndex == 0)
            {
                for (int windowSize = 3, i = 0; windowSize <= maxWindowSize; windowSize += 2, i++)
                {
                    x_values[i] = windowSize;

                    time1 = System.Environment.TickCount;
                    AlphaTrimFilter.alphaTrimFilter(ImageMatrix, windowSize, t, 1);
                    time2 = System.Environment.TickCount;
                    y_values_1stAlgo[i] = (time2 - time1) / 1000;

                    time1 = System.Environment.TickCount;
                    AlphaTrimFilter.alphaTrimFilter(ImageMatrix, windowSize, t, 2);
                    time2 = System.Environment.TickCount;
                    y_values_2ndAlgo[i] = (time2 - time1) / 1000;
                }
                //Create a graph and add two curves to it
                ZGraphForm ZGF = new ZGraphForm("Alpha-Trim Filter", "Window size", "Execution time");
                ZGF.add_curve("Counting sort", x_values, y_values_1stAlgo, Color.Red);
                ZGF.add_curve("K-sort", x_values, y_values_2ndAlgo, Color.Blue);
                ZGF.Show();
            }
            else if(Filter_Type.SelectedIndex == 1)
            {
       
                for (int windowSize = 3, i = 0; windowSize <= maxWindowSize; windowSize += 2, i++)
                {
                    x_values[i] = windowSize;
                    
                    time1 = System.Environment.TickCount;
                    AdaptiveMedianFilter.AdaptivemedianFilter(ImageMatrix, windowSize, false);
                    time2 = System.Environment.TickCount;
                    y_values_1stAlgo[i] = (time2 - time1) / 1000;
                    time1 = System.Environment.TickCount;
                    AdaptiveMedianFilter.AdaptivemedianFilter(ImageMatrix, windowSize, true);
                    time2 = System.Environment.TickCount;
                    y_values_2ndAlgo[i] = (time2 - time1) / 1000;
                }
                //Create a graph and add two curves to it
                ZGraphForm ZGF = new ZGraphForm("Adaptive Median Filter", "Window size", "Execution time");
                ZGF.add_curve("Counting Sort ", x_values, y_values_1stAlgo, Color.Red);
                ZGF.add_curve("Quick Sort ", x_values, y_values_2ndAlgo, Color.Blue);
                ZGF.Show();
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            byte[,] newImageMatrix = { };

            if (Filter_Type.SelectedIndex == 0)
            {
                int t = Convert.ToInt32(T_Value.Text);
                int windowSize = Convert.ToInt32(Ws.Text);
            
                if (Sorting_Algo.SelectedIndex == 0)
                {
                    newImageMatrix = AlphaTrimFilter.alphaTrimFilter(ImageMatrix, windowSize, t, 1);
                }
                else
                {
                    newImageMatrix = AlphaTrimFilter.alphaTrimFilter(ImageMatrix, windowSize, t, 2);
                }
            }
            else if (Filter_Type.SelectedIndex == 1)
            {
                int windowSize = Convert.ToInt32(Ws.Text);

                newImageMatrix = AdaptiveMedianFilter.AdaptivemedianFilter(ImageMatrix, windowSize, Convert.ToBoolean(Sorting_Algo.SelectedIndex));

            }

            ImageOperations.DisplayImage(newImageMatrix, pictureBox2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Filter_Type.Items.Add("Alpha-Trim Filter");
            Filter_Type.Items.Add("Adaptive Med Filter");
        }

        private void Filter_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sorting_Algo.Items.Clear();
            Sorting_Algo.ResetText();


            Sorting_Algo.Items.Add("Counting sort");

            if (Filter_Type.SelectedIndex == 0)
            {
                label4.Visible = true;
                T_Value.Visible = true;
                Sorting_Algo.Items.Add("Select Kth smallest / largest element");
            }
            else
            {
                Sorting_Algo.Items.Add("Quick sort");
                label4.Visible = false;
                T_Value.Visible = false;
            }

        }

    }
}
