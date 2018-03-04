namespace SQL_A03
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
            this.stable = new System.Windows.Forms.TextBox();
            this.CopyData = new System.Windows.Forms.Button();
            this.sstring = new System.Windows.Forms.TextBox();
            this.dstring = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckExistence = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // stable
            // 
            this.stable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stable.Location = new System.Drawing.Point(257, 405);
            this.stable.Multiline = true;
            this.stable.Name = "stable";
            this.stable.Size = new System.Drawing.Size(394, 43);
            this.stable.TabIndex = 0;
            this.stable.Text = "this is a test savage";
            // 
            // CopyData
            // 
            this.CopyData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyData.Location = new System.Drawing.Point(366, 570);
            this.CopyData.Name = "CopyData";
            this.CopyData.Size = new System.Drawing.Size(144, 40);
            this.CopyData.TabIndex = 1;
            this.CopyData.Text = "Copy Data";
            this.CopyData.UseVisualStyleBackColor = true;
            this.CopyData.Click += new System.EventHandler(this.Submit__Click);
            // 
            // sstring
            // 
            this.sstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sstring.Location = new System.Drawing.Point(257, 44);
            this.sstring.Multiline = true;
            this.sstring.Name = "sstring";
            this.sstring.Size = new System.Drawing.Size(637, 53);
            this.sstring.TabIndex = 2;
            this.sstring.Text = "select sum(wprice) as \'summ\' from vehicle where dealerid = 1001;";
            // 
            // dstring
            // 
            this.dstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dstring.Location = new System.Drawing.Point(257, 136);
            this.dstring.Multiline = true;
            this.dstring.Name = "dstring";
            this.dstring.Size = new System.Drawing.Size(637, 53);
            this.dstring.TabIndex = 5;
            this.dstring.Text = "select sum(wprice) as \'summ\' from vehicle where dealerid = 1001;";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "Source DB Connection String :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 49);
            this.label2.TabIndex = 7;
            this.label2.Text = "Destination DB Connection String :";
            // 
            // CheckExistence
            // 
            this.CheckExistence.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckExistence.Location = new System.Drawing.Point(386, 238);
            this.CheckExistence.Name = "CheckExistence";
            this.CheckExistence.Size = new System.Drawing.Size(247, 43);
            this.CheckExistence.TabIndex = 8;
            this.CheckExistence.Text = "Check Existence";
            this.CheckExistence.UseVisualStyleBackColor = true;
            this.CheckExistence.Click += new System.EventHandler(this.CheckExistence_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Destination Table :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Source Table :";
            // 
            // dtable
            // 
            this.dtable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtable.Location = new System.Drawing.Point(257, 486);
            this.dtable.Multiline = true;
            this.dtable.Name = "dtable";
            this.dtable.Size = new System.Drawing.Size(394, 43);
            this.dtable.TabIndex = 11;
            this.dtable.Text = "this is a test savage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 681);
            this.Controls.Add(this.dtable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheckExistence);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dstring);
            this.Controls.Add(this.sstring);
            this.Controls.Add(this.CopyData);
            this.Controls.Add(this.stable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stable;
        private System.Windows.Forms.Button CopyData;
        private System.Windows.Forms.TextBox sstring;
        private System.Windows.Forms.TextBox dstring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CheckExistence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dtable;
    }
}

