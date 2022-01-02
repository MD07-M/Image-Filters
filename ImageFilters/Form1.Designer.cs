namespace ImageFilters
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submit_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Max_Graph_Ws = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.T_Value = new System.Windows.Forms.TextBox();
            this.Ws = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Sorting_Algo = new System.Windows.Forms.ComboBox();
            this.Filter_Type = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnZGraph = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.Location = new System.Drawing.Point(776, 820);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(6);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(309, 113);
            this.submit_btn.TabIndex = 34;
            this.submit_btn.Text = "Filter Image";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 1580);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(1529, 898);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Max graph window size";
            // 
            // Max_Graph_Ws
            // 
            this.Max_Graph_Ws.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Max_Graph_Ws.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.Max_Graph_Ws.Location = new System.Drawing.Point(1524, 929);
            this.Max_Graph_Ws.Margin = new System.Windows.Forms.Padding(6);
            this.Max_Graph_Ws.Name = "Max_Graph_Ws";
            this.Max_Graph_Ws.Size = new System.Drawing.Size(270, 31);
            this.Max_Graph_Ws.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(341, 886);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Trim value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(1, 886);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Window Size";
            // 
            // T_Value
            // 
            this.T_Value.Location = new System.Drawing.Point(346, 917);
            this.T_Value.Margin = new System.Windows.Forms.Padding(6);
            this.T_Value.Name = "T_Value";
            this.T_Value.Size = new System.Drawing.Size(282, 31);
            this.T_Value.TabIndex = 28;
            // 
            // Ws
            // 
            this.Ws.Location = new System.Drawing.Point(6, 917);
            this.Ws.Margin = new System.Windows.Forms.Padding(6);
            this.Ws.Name = "Ws";
            this.Ws.Size = new System.Drawing.Size(284, 31);
            this.Ws.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1, 801);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Filter ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(341, 801);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Sorting algorithm";
            // 
            // Sorting_Algo
            // 
            this.Sorting_Algo.FormattingEnabled = true;
            this.Sorting_Algo.Location = new System.Drawing.Point(346, 832);
            this.Sorting_Algo.Margin = new System.Windows.Forms.Padding(6);
            this.Sorting_Algo.Name = "Sorting_Algo";
            this.Sorting_Algo.Size = new System.Drawing.Size(346, 33);
            this.Sorting_Algo.TabIndex = 24;
            // 
            // Filter_Type
            // 
            this.Filter_Type.FormattingEnabled = true;
            this.Filter_Type.Location = new System.Drawing.Point(6, 832);
            this.Filter_Type.Margin = new System.Windows.Forms.Padding(6);
            this.Filter_Type.Name = "Filter_Type";
            this.Filter_Type.Size = new System.Drawing.Size(314, 33);
            this.Filter_Type.TabIndex = 23;
            this.Filter_Type.SelectedIndexChanged += new System.EventHandler(this.Filter_Type_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(22, 118);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(844, 644);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(1009, 118);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(813, 644);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // btnZGraph
            // 
            this.btnZGraph.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnZGraph.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZGraph.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnZGraph.Location = new System.Drawing.Point(1505, 801);
            this.btnZGraph.Margin = new System.Windows.Forms.Padding(6);
            this.btnZGraph.Name = "btnZGraph";
            this.btnZGraph.Size = new System.Drawing.Size(303, 82);
            this.btnZGraph.TabIndex = 20;
            this.btnZGraph.Text = "Z Graph Example";
            this.btnZGraph.UseVisualStyleBackColor = false;
            this.btnZGraph.Click += new System.EventHandler(this.btnZGraph_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(776, 15);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(309, 73);
            this.btnOpen.TabIndex = 19;
            this.btnOpen.Text = "Open Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1837, 981);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Max_Graph_Ws);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.T_Value);
            this.Controls.Add(this.Ws);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sorting_Algo);
            this.Controls.Add(this.Filter_Type);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnZGraph);
            this.Controls.Add(this.btnOpen);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Image Filters...";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Max_Graph_Ws;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox T_Value;
        private System.Windows.Forms.TextBox Ws;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Sorting_Algo;
        private System.Windows.Forms.ComboBox Filter_Type;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnZGraph;
        private System.Windows.Forms.Button btnOpen;
    }
}

