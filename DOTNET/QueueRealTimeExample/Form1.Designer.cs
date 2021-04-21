namespace QueueRealTimeExample
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCounter1 = new System.Windows.Forms.TextBox();
            this.textCounter2 = new System.Windows.Forms.TextBox();
            this.textCounter3 = new System.Windows.Forms.TextBox();
            this.buttonCounter1 = new System.Windows.Forms.Button();
            this.buttonCounter2 = new System.Windows.Forms.Button();
            this.buttonCounter3 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.listBoxCustomerQueue = new System.Windows.Forms.ListBox();
            this.buttonPrintToken = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.lblMessage, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonCounter3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonCounter2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textCounter3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textCounter2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textCounter1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonCounter1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblStatus, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.listBoxCustomerQueue, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonPrintToken, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1019, 663);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Counter 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(339, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "Counter 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(674, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 65);
            this.label3.TabIndex = 2;
            this.label3.Text = "Counter 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textCounter1
            // 
            this.textCounter1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textCounter1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textCounter1.ForeColor = System.Drawing.Color.White;
            this.textCounter1.Location = new System.Drawing.Point(4, 88);
            this.textCounter1.Name = "textCounter1";
            this.textCounter1.Size = new System.Drawing.Size(328, 22);
            this.textCounter1.TabIndex = 3;
            this.textCounter1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textCounter2
            // 
            this.textCounter2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textCounter2.BackColor = System.Drawing.SystemColors.Highlight;
            this.textCounter2.ForeColor = System.Drawing.Color.White;
            this.textCounter2.Location = new System.Drawing.Point(339, 88);
            this.textCounter2.Name = "textCounter2";
            this.textCounter2.Size = new System.Drawing.Size(328, 22);
            this.textCounter2.TabIndex = 4;
            this.textCounter2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textCounter3
            // 
            this.textCounter3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textCounter3.BackColor = System.Drawing.SystemColors.Highlight;
            this.textCounter3.ForeColor = System.Drawing.Color.White;
            this.textCounter3.Location = new System.Drawing.Point(674, 88);
            this.textCounter3.Name = "textCounter3";
            this.textCounter3.Size = new System.Drawing.Size(341, 22);
            this.textCounter3.TabIndex = 5;
            this.textCounter3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCounter1
            // 
            this.buttonCounter1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCounter1.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCounter1.Location = new System.Drawing.Point(4, 154);
            this.buttonCounter1.Name = "buttonCounter1";
            this.buttonCounter1.Size = new System.Drawing.Size(328, 23);
            this.buttonCounter1.TabIndex = 6;
            this.buttonCounter1.Text = "Next";
            this.buttonCounter1.UseVisualStyleBackColor = true;
            this.buttonCounter1.Click += new System.EventHandler(this.buttonCounter1_Click);
            // 
            // buttonCounter2
            // 
            this.buttonCounter2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCounter2.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCounter2.Location = new System.Drawing.Point(339, 154);
            this.buttonCounter2.Name = "buttonCounter2";
            this.buttonCounter2.Size = new System.Drawing.Size(328, 23);
            this.buttonCounter2.TabIndex = 7;
            this.buttonCounter2.Text = "Next";
            this.buttonCounter2.UseVisualStyleBackColor = true;
            this.buttonCounter2.Click += new System.EventHandler(this.buttonCounter2_Click);
            // 
            // buttonCounter3
            // 
            this.buttonCounter3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCounter3.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCounter3.Location = new System.Drawing.Point(674, 154);
            this.buttonCounter3.Name = "buttonCounter3";
            this.buttonCounter3.Size = new System.Drawing.Size(341, 23);
            this.buttonCounter3.TabIndex = 8;
            this.buttonCounter3.Text = "Next";
            this.buttonCounter3.UseVisualStyleBackColor = true;
            this.buttonCounter3.Click += new System.EventHandler(this.buttonCounter3_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.ForestGreen;
            this.tableLayoutPanel1.SetColumnSpan(this.lblStatus, 3);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(4, 199);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1011, 32);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxCustomerQueue
            // 
            this.listBoxCustomerQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCustomerQueue.BackColor = System.Drawing.Color.Silver;
            this.listBoxCustomerQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCustomerQueue.FormattingEnabled = true;
            this.listBoxCustomerQueue.ItemHeight = 16;
            this.listBoxCustomerQueue.Location = new System.Drawing.Point(339, 235);
            this.listBoxCustomerQueue.Name = "listBoxCustomerQueue";
            this.listBoxCustomerQueue.Size = new System.Drawing.Size(328, 244);
            this.listBoxCustomerQueue.TabIndex = 11;
            // 
            // buttonPrintToken
            // 
            this.buttonPrintToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrintToken.ForeColor = System.Drawing.Color.Maroon;
            this.buttonPrintToken.Location = new System.Drawing.Point(339, 516);
            this.buttonPrintToken.Name = "buttonPrintToken";
            this.buttonPrintToken.Size = new System.Drawing.Size(328, 23);
            this.buttonPrintToken.TabIndex = 12;
            this.buttonPrintToken.Text = "Print Token";
            this.buttonPrintToken.UseVisualStyleBackColor = true;
            this.buttonPrintToken.Click += new System.EventHandler(this.buttonPrintToken_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.LawnGreen;
            this.tableLayoutPanel1.SetColumnSpan(this.lblMessage, 3);
            this.lblMessage.Location = new System.Drawing.Point(4, 561);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(1011, 101);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 687);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCounter3;
        private System.Windows.Forms.TextBox textCounter2;
        private System.Windows.Forms.TextBox textCounter1;
        private System.Windows.Forms.Button buttonCounter1;
        private System.Windows.Forms.Button buttonCounter3;
        private System.Windows.Forms.Button buttonCounter2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListBox listBoxCustomerQueue;
        private System.Windows.Forms.Button buttonPrintToken;
        private System.Windows.Forms.Label lblMessage;
    }
}

