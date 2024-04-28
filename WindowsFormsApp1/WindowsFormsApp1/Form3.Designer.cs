namespace projectfile
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.search = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.seeall = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bookid = new System.Windows.Forms.TextBox();
            this.bookname = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search.BackgroundImage")));
            this.search.Location = new System.Drawing.Point(1288, 135);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(224, 228);
            this.search.TabIndex = 0;
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // add
            // 
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.Location = new System.Drawing.Point(1124, 307);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(234, 236);
            this.add.TabIndex = 1;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.Location = new System.Drawing.Point(1288, 478);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(234, 233);
            this.delete.TabIndex = 2;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // seeall
            // 
            this.seeall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seeall.BackgroundImage")));
            this.seeall.Location = new System.Drawing.Point(1178, 669);
            this.seeall.Name = "seeall";
            this.seeall.Size = new System.Drawing.Size(240, 236);
            this.seeall.TabIndex = 3;
            this.seeall.UseVisualStyleBackColor = true;
            this.seeall.Click += new System.EventHandler(this.seeall_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Location = new System.Drawing.Point(61, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(328, 246);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bookid
            // 
            this.bookid.BackColor = System.Drawing.Color.Linen;
            this.bookid.Location = new System.Drawing.Point(557, 392);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(405, 22);
            this.bookid.TabIndex = 5;
            // 
            // bookname
            // 
            this.bookname.BackColor = System.Drawing.Color.Linen;
            this.bookname.Location = new System.Drawing.Point(558, 521);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(404, 22);
            this.bookname.TabIndex = 6;
            // 
            // author
            // 
            this.author.BackColor = System.Drawing.Color.Linen;
            this.author.Location = new System.Drawing.Point(558, 656);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(404, 22);
            this.author.TabIndex = 7;
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.Linen;
            this.price.Location = new System.Drawing.Point(557, 776);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(405, 22);
            this.price.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1520, 1055);
            this.Controls.Add(this.price);
            this.Controls.Add(this.author);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.bookid);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.seeall);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.search);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button seeall;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox bookid;
        private System.Windows.Forms.TextBox bookname;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox price;
    }
}