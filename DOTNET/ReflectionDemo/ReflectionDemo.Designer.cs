namespace ReflectionDemo
{
    partial class ReflectionDemo
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MyTable = new System.Windows.Forms.TableLayoutPanel();
            this.listMethods = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.listConstructors = new System.Windows.Forms.ListBox();
            this.listProperties = new System.Windows.Forms.ListBox();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.MyTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainPanel.Controls.Add(this.MyTable);
            this.MainPanel.Location = new System.Drawing.Point(16, 15);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1035, 524);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Tag = "";
            // 
            // MyTable
            // 
            this.MyTable.ColumnCount = 3;
            this.MyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.MyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.MyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MyTable.Controls.Add(this.listMethods, 2, 2);
            this.MyTable.Controls.Add(this.label4, 0, 1);
            this.MyTable.Controls.Add(this.label3, 0, 1);
            this.MyTable.Controls.Add(this.label2, 0, 1);
            this.MyTable.Controls.Add(this.label1, 0, 0);
            this.MyTable.Controls.Add(this.btnDiscover, 2, 0);
            this.MyTable.Controls.Add(this.listConstructors, 0, 2);
            this.MyTable.Controls.Add(this.listProperties, 1, 2);
            this.MyTable.Controls.Add(this.txtSearchKey, 1, 0);
            this.MyTable.Location = new System.Drawing.Point(24, 31);
            this.MyTable.Margin = new System.Windows.Forms.Padding(4);
            this.MyTable.Name = "MyTable";
            this.MyTable.RowCount = 3;
            this.MyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.MyTable.Size = new System.Drawing.Size(991, 490);
            this.MyTable.TabIndex = 0;
            // 
            // listMethods
            // 
            this.listMethods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listMethods.FormattingEnabled = true;
            this.listMethods.HorizontalScrollbar = true;
            this.listMethods.ItemHeight = 16;
            this.listMethods.Location = new System.Drawing.Point(615, 102);
            this.listMethods.Margin = new System.Windows.Forms.Padding(4);
            this.listMethods.Name = "listMethods";
            this.listMethods.Size = new System.Drawing.Size(355, 372);
            this.listMethods.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Location = new System.Drawing.Point(408, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(1);
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Properties";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Location = new System.Drawing.Point(116, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(1);
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Methods";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Location = new System.Drawing.Point(747, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(1);
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Constructors";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(289, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDiscover
            // 
            this.btnDiscover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDiscover.AutoSize = true;
            this.btnDiscover.Location = new System.Drawing.Point(656, 4);
            this.btnDiscover.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiscover.Name = "btnDiscover";
            this.btnDiscover.Size = new System.Drawing.Size(273, 41);
            this.btnDiscover.TabIndex = 2;
            this.btnDiscover.Text = "Discover Type Information";
            this.btnDiscover.UseVisualStyleBackColor = true;
            this.btnDiscover.Click += new System.EventHandler(this.btnDiscover_Click);
            // 
            // listConstructors
            // 
            this.listConstructors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listConstructors.FormattingEnabled = true;
            this.listConstructors.HorizontalScrollbar = true;
            this.listConstructors.ItemHeight = 16;
            this.listConstructors.Location = new System.Drawing.Point(21, 102);
            this.listConstructors.Margin = new System.Windows.Forms.Padding(4);
            this.listConstructors.Name = "listConstructors";
            this.listConstructors.Size = new System.Drawing.Size(255, 372);
            this.listConstructors.TabIndex = 6;
            // 
            // listProperties
            // 
            this.listProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listProperties.FormattingEnabled = true;
            this.listProperties.HorizontalScrollbar = true;
            this.listProperties.ItemHeight = 16;
            this.listProperties.Location = new System.Drawing.Point(318, 102);
            this.listProperties.Margin = new System.Windows.Forms.Padding(4);
            this.listProperties.Name = "listProperties";
            this.listProperties.Size = new System.Drawing.Size(255, 372);
            this.listProperties.TabIndex = 7;
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchKey.Location = new System.Drawing.Point(300, 13);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(291, 22);
            this.txtSearchKey.TabIndex = 9;
            this.txtSearchKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReflectionDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReflectionDemo";
            this.Text = "Reflection Demo";
            this.MainPanel.ResumeLayout(false);
            this.MyTable.ResumeLayout(false);
            this.MyTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TableLayoutPanel MyTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDiscover;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listMethods;
        private System.Windows.Forms.ListBox listProperties;
        private System.Windows.Forms.ListBox listConstructors;
        private System.Windows.Forms.TextBox txtSearchKey;
    }
}

