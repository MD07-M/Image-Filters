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
            // Make up some data points from the N, N log(N) functions
            int N = 40;
            double[] x_values = new double[N];
            double[] y_values_N = new double[N];
            double[] y_values_NLogN = new double[N];

            for (int i = 0; i < N; i++)
            {
                x_values[i] = i;
                y_values_N[i] = i;
                y_values_NLogN[i] = i * Math.Log(i);
            }

            //Create a graph and add two curves to it
             ZGraphForm ZGF = new ZGraphForm("Sample Graph", "N", "f(N)");
            ZGF.add_curve("f(N) = N", x_values, y_values_N,Color.Red);
            ZGF.add_curve("f(N) = N Log(N)", x_values, y_values_NLogN, Color.Blue);
            ZGF.Show();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(T_Value.Text);
            int windowSize = Convert.ToInt32(Ws.Text);
            byte[,] newImageMatrix = AlphaTrimFilter.alphaTrimFilter(ImageMatrix, windowSize, t);
            pictureBox2.Image = null;
            pictureBox2.Update();
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

            if (Filter_Type.SelectedItem.ToString() == "Alpha-Trim Filter")
                Sorting_Algo.Items.Add("Select Kth smallest / largest element");
            else
                Sorting_Algo.Items.Add("Quick sort");
        }

    }
}
