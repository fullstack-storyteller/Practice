namespace MultiThreadinginCSharp
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDoTimeConsumingWork = new System.Windows.Forms.Button();
            this.btnPrintNumbers = new System.Windows.Forms.Button();
            this.listBoxNumbers = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnPrintNumbers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDoTimeConsumingWork, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxNumbers, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(267, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 406);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDoTimeConsumingWork
            // 
            this.btnDoTimeConsumingWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoTimeConsumingWork.Location = new System.Drawing.Point(3, 49);
            this.btnDoTimeConsumingWork.Name = "btnDoTimeConsumingWork";
            this.btnDoTimeConsumingWork.Size = new System.Drawing.Size(194, 23);
            this.btnDoTimeConsumingWork.TabIndex = 0;
            this.btnDoTimeConsumingWork.Text = "Do Time Consuming Work";
            this.btnDoTimeConsumingWork.UseVisualStyleBackColor = true;
            this.btnDoTimeConsumingWork.Click += new System.EventHandler(this.btnDoTimeConsumingWork_Click);
            // 
            // btnPrintNumbers
            // 
            this.btnPrintNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintNumbers.Location = new System.Drawing.Point(3, 170);
            this.btnPrintNumbers.Name = "btnPrintNumbers";
            this.btnPrintNumbers.Size = new System.Drawing.Size(194, 23);
            this.btnPrintNumbers.TabIndex = 1;
            this.btnPrintNumbers.Text = "Print Numbers";
            this.btnPrintNumbers.UseVisualStyleBackColor = true;
            this.btnPrintNumbers.Click += new System.EventHandler(this.btnPrintNumbers_Click);
            // 
            // listBoxNumbers
            // 
            this.listBoxNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxNumbers.FormattingEnabled = true;
            this.listBoxNumbers.ItemHeight = 16;
            this.listBoxNumbers.Location = new System.Drawing.Point(3, 245);
            this.listBoxNumbers.Name = "listBoxNumbers";
            this.listBoxNumbers.Size = new System.Drawing.Size(194, 148);
            this.listBoxNumbers.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPrintNumbers;
        private System.Windows.Forms.Button btnDoTimeConsumingWork;
        private System.Windows.Forms.ListBox listBoxNumbers;
    }
}

