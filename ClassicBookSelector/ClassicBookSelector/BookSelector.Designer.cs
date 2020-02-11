namespace ClassicBookSelector
{
    partial class BookSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookSelector));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.readingLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.desLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Great Expectation",
            "1984",
            "To Kill a Mockingbird",
            "Animal Farm",
            "The Great Gatsby"});
            this.listBox1.Location = new System.Drawing.Point(47, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // readingLabel
            // 
            this.readingLabel.AutoSize = true;
            this.readingLabel.Location = new System.Drawing.Point(44, 287);
            this.readingLabel.Name = "readingLabel";
            this.readingLabel.Size = new System.Drawing.Size(412, 52);
            this.readingLabel.TabIndex = 1;
            this.readingLabel.Text = resources.GetString("readingLabel.Text");
            this.readingLabel.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.titleLabel.Location = new System.Drawing.Point(184, 36);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(369, 27);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Classic Book Selector";
            // 
            // desLabel
            // 
            this.desLabel.AutoSize = true;
            this.desLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desLabel.Location = new System.Drawing.Point(228, 127);
            this.desLabel.Name = "desLabel";
            this.desLabel.Size = new System.Drawing.Size(51, 16);
            this.desLabel.TabIndex = 3;
            this.desLabel.Text = "label1";
            this.desLabel.Click += new System.EventHandler(this.desLabel_Click);
            // 
            // BookSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.desLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.readingLabel);
            this.Controls.Add(this.listBox1);
            this.Name = "BookSelector";
            this.Text = "Classic Book Selector";
            this.Load += new System.EventHandler(this.BookSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label readingLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label desLabel;
    }
}

