namespace IT481_AColeman_Assignment_Unit_7
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
            this.btnBubbleSort10 = new System.Windows.Forms.Button();
            this.btnBubbleSort100 = new System.Windows.Forms.Button();
            this.btnBubbleSort1000 = new System.Windows.Forms.Button();
            this.btnQuickSort10 = new System.Windows.Forms.Button();
            this.btnSelectionSort100 = new System.Windows.Forms.Button();
            this.btnSelectionSort1000 = new System.Windows.Forms.Button();
            this.lblBubbleSort = new System.Windows.Forms.Label();
            this.lblSelectionSort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBubbleSort10
            // 
            this.btnBubbleSort10.Location = new System.Drawing.Point(26, 47);
            this.btnBubbleSort10.Name = "btnBubbleSort10";
            this.btnBubbleSort10.Size = new System.Drawing.Size(106, 26);
            this.btnBubbleSort10.TabIndex = 0;
            this.btnBubbleSort10.Text = "10 ITEMS";
            this.btnBubbleSort10.UseVisualStyleBackColor = true;
            this.btnBubbleSort10.Click += new System.EventHandler(this.btnBubbleSort10_Click);
            // 
            // btnBubbleSort100
            // 
            this.btnBubbleSort100.Location = new System.Drawing.Point(26, 79);
            this.btnBubbleSort100.Name = "btnBubbleSort100";
            this.btnBubbleSort100.Size = new System.Drawing.Size(106, 26);
            this.btnBubbleSort100.TabIndex = 1;
            this.btnBubbleSort100.Text = "100 ITEMS";
            this.btnBubbleSort100.UseVisualStyleBackColor = true;
            this.btnBubbleSort100.Click += new System.EventHandler(this.btnBubbleSort100_Click);
            // 
            // btnBubbleSort1000
            // 
            this.btnBubbleSort1000.Location = new System.Drawing.Point(26, 111);
            this.btnBubbleSort1000.Name = "btnBubbleSort1000";
            this.btnBubbleSort1000.Size = new System.Drawing.Size(106, 26);
            this.btnBubbleSort1000.TabIndex = 2;
            this.btnBubbleSort1000.Text = "10000 ITEMS";
            this.btnBubbleSort1000.UseVisualStyleBackColor = true;
            this.btnBubbleSort1000.Click += new System.EventHandler(this.btnBubbleSort500_Click);
            // 
            // btnQuickSort10
            // 
            this.btnQuickSort10.Location = new System.Drawing.Point(149, 47);
            this.btnQuickSort10.Name = "btnQuickSort10";
            this.btnQuickSort10.Size = new System.Drawing.Size(104, 26);
            this.btnQuickSort10.TabIndex = 3;
            this.btnQuickSort10.Text = "10 ITEMS";
            this.btnQuickSort10.UseVisualStyleBackColor = true;
            this.btnQuickSort10.Click += new System.EventHandler(this.btnQuickSort10_Click);
            // 
            // btnSelectionSort100
            // 
            this.btnSelectionSort100.Location = new System.Drawing.Point(149, 79);
            this.btnSelectionSort100.Name = "btnSelectionSort100";
            this.btnSelectionSort100.Size = new System.Drawing.Size(104, 26);
            this.btnSelectionSort100.TabIndex = 4;
            this.btnSelectionSort100.Text = "100 ITEMS";
            this.btnSelectionSort100.UseVisualStyleBackColor = true;
            this.btnSelectionSort100.Click += new System.EventHandler(this.btnSelectionSort100_Click);
            // 
            // btnSelectionSort1000
            // 
            this.btnSelectionSort1000.Location = new System.Drawing.Point(149, 111);
            this.btnSelectionSort1000.Name = "btnSelectionSort1000";
            this.btnSelectionSort1000.Size = new System.Drawing.Size(104, 26);
            this.btnSelectionSort1000.TabIndex = 5;
            this.btnSelectionSort1000.Text = "10000 ITEMS";
            this.btnSelectionSort1000.UseVisualStyleBackColor = true;
            this.btnSelectionSort1000.Click += new System.EventHandler(this.btnSelectionSort1000_Click);
            // 
            // lblBubbleSort
            // 
            this.lblBubbleSort.AutoSize = true;
            this.lblBubbleSort.Location = new System.Drawing.Point(23, 21);
            this.lblBubbleSort.Name = "lblBubbleSort";
            this.lblBubbleSort.Size = new System.Drawing.Size(62, 13);
            this.lblBubbleSort.TabIndex = 6;
            this.lblBubbleSort.Text = "Bubble Sort";
            // 
            // lblSelectionSort
            // 
            this.lblSelectionSort.AutoSize = true;
            this.lblSelectionSort.Location = new System.Drawing.Point(149, 20);
            this.lblSelectionSort.Name = "lblSelectionSort";
            this.lblSelectionSort.Size = new System.Drawing.Size(73, 13);
            this.lblSelectionSort.TabIndex = 7;
            this.lblSelectionSort.Text = "Selection Sort";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 158);
            this.Controls.Add(this.lblSelectionSort);
            this.Controls.Add(this.lblBubbleSort);
            this.Controls.Add(this.btnSelectionSort1000);
            this.Controls.Add(this.btnSelectionSort100);
            this.Controls.Add(this.btnQuickSort10);
            this.Controls.Add(this.btnBubbleSort1000);
            this.Controls.Add(this.btnBubbleSort100);
            this.Controls.Add(this.btnBubbleSort10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "IT481 Unit 7 Assignment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBubbleSort10;
        private System.Windows.Forms.Button btnBubbleSort100;
        private System.Windows.Forms.Button btnBubbleSort1000;
        private System.Windows.Forms.Button btnQuickSort10;
        private System.Windows.Forms.Button btnSelectionSort100;
        private System.Windows.Forms.Button btnSelectionSort1000;
        private System.Windows.Forms.Label lblBubbleSort;
        private System.Windows.Forms.Label lblSelectionSort;
    }
}

