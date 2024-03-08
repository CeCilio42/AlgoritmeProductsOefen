namespace AlgoritmeProducts
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
            this.buttonAvgPrice = new System.Windows.Forms.Button();
            this.buttonMaxPrice = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.labeltext = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.buttonSortAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAvgPrice
            // 
            this.buttonAvgPrice.Location = new System.Drawing.Point(586, 49);
            this.buttonAvgPrice.Name = "buttonAvgPrice";
            this.buttonAvgPrice.Size = new System.Drawing.Size(127, 76);
            this.buttonAvgPrice.TabIndex = 0;
            this.buttonAvgPrice.Text = "Average Price";
            this.buttonAvgPrice.UseVisualStyleBackColor = true;
            this.buttonAvgPrice.Click += new System.EventHandler(this.buttonAvgPrice_Click);
            // 
            // buttonMaxPrice
            // 
            this.buttonMaxPrice.Location = new System.Drawing.Point(586, 154);
            this.buttonMaxPrice.Name = "buttonMaxPrice";
            this.buttonMaxPrice.Size = new System.Drawing.Size(127, 76);
            this.buttonMaxPrice.TabIndex = 2;
            this.buttonMaxPrice.Text = "Max Price";
            this.buttonMaxPrice.UseVisualStyleBackColor = true;
            this.buttonMaxPrice.Click += new System.EventHandler(this.buttonMaxPrice_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(133, 49);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(127, 32);
            this.buttonAddProduct.TabIndex = 3;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // labeltext
            // 
            this.labeltext.AutoSize = true;
            this.labeltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltext.Location = new System.Drawing.Point(36, 101);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(91, 36);
            this.labeltext.TabIndex = 5;
            this.labeltext.Text = "Price:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(142, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "0.99";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(142, 131);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(53, 20);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "1.99";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(142, 157);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(53, 20);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "2.99";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(142, 183);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(53, 20);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "3.99";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // listBoxResult
            // 
            this.listBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 36;
            this.listBoxResult.Location = new System.Drawing.Point(325, 49);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(232, 256);
            this.listBoxResult.TabIndex = 10;
            // 
            // buttonSortAll
            // 
            this.buttonSortAll.Location = new System.Drawing.Point(586, 249);
            this.buttonSortAll.Name = "buttonSortAll";
            this.buttonSortAll.Size = new System.Drawing.Size(127, 76);
            this.buttonSortAll.TabIndex = 11;
            this.buttonSortAll.Text = "Sort All";
            this.buttonSortAll.UseVisualStyleBackColor = true;
            this.buttonSortAll.Click += new System.EventHandler(this.buttonSortAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSortAll);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labeltext);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.buttonMaxPrice);
            this.Controls.Add(this.buttonAvgPrice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAvgPrice;
        private System.Windows.Forms.Button buttonMaxPrice;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Label labeltext;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonSortAll;
    }
}

