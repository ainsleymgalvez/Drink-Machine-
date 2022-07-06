namespace Drink_Vending_Machine
{
    partial class DrinkMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinkMachine));
            this.colaGroupBox = new System.Windows.Forms.GroupBox();
            this.leftCLbl = new System.Windows.Forms.Label();
            this.drinksCLbl = new System.Windows.Forms.Label();
            this.amountCLbl = new System.Windows.Forms.Label();
            this.colaPic = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.rootGroupBox = new System.Windows.Forms.GroupBox();
            this.leftRLbl = new System.Windows.Forms.Label();
            this.drinksRLbl = new System.Windows.Forms.Label();
            this.amountRLbl = new System.Windows.Forms.Label();
            this.rootPic = new System.Windows.Forms.PictureBox();
            this.grapeGroupBox = new System.Windows.Forms.GroupBox();
            this.leftGLbl = new System.Windows.Forms.Label();
            this.drinksGLbl = new System.Windows.Forms.Label();
            this.amountGLbl = new System.Windows.Forms.Label();
            this.grapePic = new System.Windows.Forms.PictureBox();
            this.creamSodaGroupBox = new System.Windows.Forms.GroupBox();
            this.leftCSLbl = new System.Windows.Forms.Label();
            this.drinksCSLbl = new System.Windows.Forms.Label();
            this.amountCSLbl = new System.Windows.Forms.Label();
            this.creamSodaPic = new System.Windows.Forms.PictureBox();
            this.lemonGroupBox = new System.Windows.Forms.GroupBox();
            this.leftLLbl = new System.Windows.Forms.Label();
            this.drinksLLbl = new System.Windows.Forms.Label();
            this.amountLLbl = new System.Windows.Forms.Label();
            this.lemonPic = new System.Windows.Forms.PictureBox();
            this.salesGroupBox = new System.Windows.Forms.GroupBox();
            this.totalLbl = new System.Windows.Forms.Label();
            this.salesLbl = new System.Windows.Forms.Label();
            this.selectLbl = new System.Windows.Forms.Label();
            this.colaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaPic)).BeginInit();
            this.rootGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootPic)).BeginInit();
            this.grapeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grapePic)).BeginInit();
            this.creamSodaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creamSodaPic)).BeginInit();
            this.lemonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lemonPic)).BeginInit();
            this.salesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // colaGroupBox
            // 
            this.colaGroupBox.Controls.Add(this.leftCLbl);
            this.colaGroupBox.Controls.Add(this.drinksCLbl);
            this.colaGroupBox.Controls.Add(this.amountCLbl);
            this.colaGroupBox.Controls.Add(this.colaPic);
            this.colaGroupBox.Location = new System.Drawing.Point(12, 45);
            this.colaGroupBox.Name = "colaGroupBox";
            this.colaGroupBox.Size = new System.Drawing.Size(221, 153);
            this.colaGroupBox.TabIndex = 0;
            this.colaGroupBox.TabStop = false;
            // 
            // leftCLbl
            // 
            this.leftCLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftCLbl.Location = new System.Drawing.Point(122, 91);
            this.leftCLbl.Name = "leftCLbl";
            this.leftCLbl.Size = new System.Drawing.Size(86, 39);
            this.leftCLbl.TabIndex = 3;
            this.leftCLbl.Text = "20";
            this.leftCLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drinksCLbl
            // 
            this.drinksCLbl.AutoSize = true;
            this.drinksCLbl.Location = new System.Drawing.Point(118, 62);
            this.drinksCLbl.Name = "drinksCLbl";
            this.drinksCLbl.Size = new System.Drawing.Size(90, 20);
            this.drinksCLbl.TabIndex = 2;
            this.drinksCLbl.Text = "Drinks Left:";
            // 
            // amountCLbl
            // 
            this.amountCLbl.AutoSize = true;
            this.amountCLbl.Location = new System.Drawing.Point(135, 22);
            this.amountCLbl.Name = "amountCLbl";
            this.amountCLbl.Size = new System.Drawing.Size(49, 20);
            this.amountCLbl.TabIndex = 1;
            this.amountCLbl.Text = "$1.00";
            // 
            // colaPic
            // 
            this.colaPic.Image = ((System.Drawing.Image)(resources.GetObject("colaPic.Image")));
            this.colaPic.Location = new System.Drawing.Point(12, 22);
            this.colaPic.Name = "colaPic";
            this.colaPic.Size = new System.Drawing.Size(100, 108);
            this.colaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colaPic.TabIndex = 0;
            this.colaPic.TabStop = false;
            this.colaPic.Click += new System.EventHandler(this.colaPic_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(308, 387);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 40);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // rootGroupBox
            // 
            this.rootGroupBox.Controls.Add(this.leftRLbl);
            this.rootGroupBox.Controls.Add(this.drinksRLbl);
            this.rootGroupBox.Controls.Add(this.amountRLbl);
            this.rootGroupBox.Controls.Add(this.rootPic);
            this.rootGroupBox.Location = new System.Drawing.Point(239, 45);
            this.rootGroupBox.Name = "rootGroupBox";
            this.rootGroupBox.Size = new System.Drawing.Size(221, 153);
            this.rootGroupBox.TabIndex = 4;
            this.rootGroupBox.TabStop = false;
            // 
            // leftRLbl
            // 
            this.leftRLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftRLbl.Location = new System.Drawing.Point(122, 91);
            this.leftRLbl.Name = "leftRLbl";
            this.leftRLbl.Size = new System.Drawing.Size(86, 39);
            this.leftRLbl.TabIndex = 3;
            this.leftRLbl.Text = "20";
            this.leftRLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drinksRLbl
            // 
            this.drinksRLbl.AutoSize = true;
            this.drinksRLbl.Location = new System.Drawing.Point(118, 62);
            this.drinksRLbl.Name = "drinksRLbl";
            this.drinksRLbl.Size = new System.Drawing.Size(90, 20);
            this.drinksRLbl.TabIndex = 2;
            this.drinksRLbl.Text = "Drinks Left:";
            // 
            // amountRLbl
            // 
            this.amountRLbl.AutoSize = true;
            this.amountRLbl.Location = new System.Drawing.Point(135, 22);
            this.amountRLbl.Name = "amountRLbl";
            this.amountRLbl.Size = new System.Drawing.Size(49, 20);
            this.amountRLbl.TabIndex = 1;
            this.amountRLbl.Text = "$1.00";
            // 
            // rootPic
            // 
            this.rootPic.Image = ((System.Drawing.Image)(resources.GetObject("rootPic.Image")));
            this.rootPic.Location = new System.Drawing.Point(12, 22);
            this.rootPic.Name = "rootPic";
            this.rootPic.Size = new System.Drawing.Size(100, 108);
            this.rootPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rootPic.TabIndex = 0;
            this.rootPic.TabStop = false;
            this.rootPic.Click += new System.EventHandler(this.rootPic_Click);
            // 
            // grapeGroupBox
            // 
            this.grapeGroupBox.Controls.Add(this.leftGLbl);
            this.grapeGroupBox.Controls.Add(this.drinksGLbl);
            this.grapeGroupBox.Controls.Add(this.amountGLbl);
            this.grapeGroupBox.Controls.Add(this.grapePic);
            this.grapeGroupBox.Location = new System.Drawing.Point(12, 204);
            this.grapeGroupBox.Name = "grapeGroupBox";
            this.grapeGroupBox.Size = new System.Drawing.Size(221, 153);
            this.grapeGroupBox.TabIndex = 5;
            this.grapeGroupBox.TabStop = false;
            // 
            // leftGLbl
            // 
            this.leftGLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftGLbl.Location = new System.Drawing.Point(122, 91);
            this.leftGLbl.Name = "leftGLbl";
            this.leftGLbl.Size = new System.Drawing.Size(86, 39);
            this.leftGLbl.TabIndex = 3;
            this.leftGLbl.Text = "20";
            this.leftGLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drinksGLbl
            // 
            this.drinksGLbl.AutoSize = true;
            this.drinksGLbl.Location = new System.Drawing.Point(118, 62);
            this.drinksGLbl.Name = "drinksGLbl";
            this.drinksGLbl.Size = new System.Drawing.Size(90, 20);
            this.drinksGLbl.TabIndex = 2;
            this.drinksGLbl.Text = "Drinks Left:";
            // 
            // amountGLbl
            // 
            this.amountGLbl.AutoSize = true;
            this.amountGLbl.Location = new System.Drawing.Point(135, 22);
            this.amountGLbl.Name = "amountGLbl";
            this.amountGLbl.Size = new System.Drawing.Size(49, 20);
            this.amountGLbl.TabIndex = 1;
            this.amountGLbl.Text = "$1.50";
            // 
            // grapePic
            // 
            this.grapePic.Image = ((System.Drawing.Image)(resources.GetObject("grapePic.Image")));
            this.grapePic.Location = new System.Drawing.Point(12, 22);
            this.grapePic.Name = "grapePic";
            this.grapePic.Size = new System.Drawing.Size(100, 108);
            this.grapePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grapePic.TabIndex = 0;
            this.grapePic.TabStop = false;
            this.grapePic.Click += new System.EventHandler(this.grapePic_Click);
            // 
            // creamSodaGroupBox
            // 
            this.creamSodaGroupBox.Controls.Add(this.leftCSLbl);
            this.creamSodaGroupBox.Controls.Add(this.drinksCSLbl);
            this.creamSodaGroupBox.Controls.Add(this.amountCSLbl);
            this.creamSodaGroupBox.Controls.Add(this.creamSodaPic);
            this.creamSodaGroupBox.Location = new System.Drawing.Point(239, 204);
            this.creamSodaGroupBox.Name = "creamSodaGroupBox";
            this.creamSodaGroupBox.Size = new System.Drawing.Size(221, 153);
            this.creamSodaGroupBox.TabIndex = 6;
            this.creamSodaGroupBox.TabStop = false;
            // 
            // leftCSLbl
            // 
            this.leftCSLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftCSLbl.Location = new System.Drawing.Point(122, 91);
            this.leftCSLbl.Name = "leftCSLbl";
            this.leftCSLbl.Size = new System.Drawing.Size(86, 39);
            this.leftCSLbl.TabIndex = 3;
            this.leftCSLbl.Text = "20";
            this.leftCSLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drinksCSLbl
            // 
            this.drinksCSLbl.AutoSize = true;
            this.drinksCSLbl.Location = new System.Drawing.Point(118, 62);
            this.drinksCSLbl.Name = "drinksCSLbl";
            this.drinksCSLbl.Size = new System.Drawing.Size(90, 20);
            this.drinksCSLbl.TabIndex = 2;
            this.drinksCSLbl.Text = "Drinks Left:";
            // 
            // amountCSLbl
            // 
            this.amountCSLbl.AutoSize = true;
            this.amountCSLbl.Location = new System.Drawing.Point(132, 22);
            this.amountCSLbl.Name = "amountCSLbl";
            this.amountCSLbl.Size = new System.Drawing.Size(49, 20);
            this.amountCSLbl.TabIndex = 1;
            this.amountCSLbl.Text = "$1.50";
            // 
            // creamSodaPic
            // 
            this.creamSodaPic.Image = ((System.Drawing.Image)(resources.GetObject("creamSodaPic.Image")));
            this.creamSodaPic.Location = new System.Drawing.Point(12, 22);
            this.creamSodaPic.Name = "creamSodaPic";
            this.creamSodaPic.Size = new System.Drawing.Size(100, 108);
            this.creamSodaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.creamSodaPic.TabIndex = 0;
            this.creamSodaPic.TabStop = false;
            this.creamSodaPic.Click += new System.EventHandler(this.creamSodaPic_Click);
            // 
            // lemonGroupBox
            // 
            this.lemonGroupBox.Controls.Add(this.leftLLbl);
            this.lemonGroupBox.Controls.Add(this.drinksLLbl);
            this.lemonGroupBox.Controls.Add(this.amountLLbl);
            this.lemonGroupBox.Controls.Add(this.lemonPic);
            this.lemonGroupBox.Location = new System.Drawing.Point(466, 45);
            this.lemonGroupBox.Name = "lemonGroupBox";
            this.lemonGroupBox.Size = new System.Drawing.Size(221, 153);
            this.lemonGroupBox.TabIndex = 7;
            this.lemonGroupBox.TabStop = false;
            // 
            // leftLLbl
            // 
            this.leftLLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftLLbl.Location = new System.Drawing.Point(122, 91);
            this.leftLLbl.Name = "leftLLbl";
            this.leftLLbl.Size = new System.Drawing.Size(86, 39);
            this.leftLLbl.TabIndex = 3;
            this.leftLLbl.Text = "20";
            this.leftLLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drinksLLbl
            // 
            this.drinksLLbl.AutoSize = true;
            this.drinksLLbl.Location = new System.Drawing.Point(118, 62);
            this.drinksLLbl.Name = "drinksLLbl";
            this.drinksLLbl.Size = new System.Drawing.Size(90, 20);
            this.drinksLLbl.TabIndex = 2;
            this.drinksLLbl.Text = "Drinks Left:";
            // 
            // amountLLbl
            // 
            this.amountLLbl.AutoSize = true;
            this.amountLLbl.Location = new System.Drawing.Point(136, 22);
            this.amountLLbl.Name = "amountLLbl";
            this.amountLLbl.Size = new System.Drawing.Size(49, 20);
            this.amountLLbl.TabIndex = 1;
            this.amountLLbl.Text = "$1.00";
            // 
            // lemonPic
            // 
            this.lemonPic.Image = ((System.Drawing.Image)(resources.GetObject("lemonPic.Image")));
            this.lemonPic.Location = new System.Drawing.Point(12, 22);
            this.lemonPic.Name = "lemonPic";
            this.lemonPic.Size = new System.Drawing.Size(100, 108);
            this.lemonPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lemonPic.TabIndex = 0;
            this.lemonPic.TabStop = false;
            this.lemonPic.Click += new System.EventHandler(this.lemonPic_Click);
            // 
            // salesGroupBox
            // 
            this.salesGroupBox.Controls.Add(this.totalLbl);
            this.salesGroupBox.Controls.Add(this.salesLbl);
            this.salesGroupBox.Location = new System.Drawing.Point(466, 204);
            this.salesGroupBox.Name = "salesGroupBox";
            this.salesGroupBox.Size = new System.Drawing.Size(221, 153);
            this.salesGroupBox.TabIndex = 7;
            this.salesGroupBox.TabStop = false;
            // 
            // totalLbl
            // 
            this.totalLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLbl.Location = new System.Drawing.Point(63, 85);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(84, 39);
            this.totalLbl.TabIndex = 3;
            this.totalLbl.Text = "$0.00";
            this.totalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salesLbl
            // 
            this.salesLbl.AutoSize = true;
            this.salesLbl.Location = new System.Drawing.Point(59, 39);
            this.salesLbl.Name = "salesLbl";
            this.salesLbl.Size = new System.Drawing.Size(88, 20);
            this.salesLbl.TabIndex = 2;
            this.salesLbl.Text = "Total Sales";
            // 
            // selectLbl
            // 
            this.selectLbl.AutoSize = true;
            this.selectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLbl.Location = new System.Drawing.Point(244, 5);
            this.selectLbl.Name = "selectLbl";
            this.selectLbl.Size = new System.Drawing.Size(229, 37);
            this.selectLbl.TabIndex = 4;
            this.selectLbl.Text = "Select a Drink";
            // 
            // DrinkMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.selectLbl);
            this.Controls.Add(this.salesGroupBox);
            this.Controls.Add(this.lemonGroupBox);
            this.Controls.Add(this.creamSodaGroupBox);
            this.Controls.Add(this.grapeGroupBox);
            this.Controls.Add(this.rootGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.colaGroupBox);
            this.Name = "DrinkMachine";
            this.Text = "Drink Machine";
            this.Load += new System.EventHandler(this.DrinkMachine_Load);
            this.colaGroupBox.ResumeLayout(false);
            this.colaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaPic)).EndInit();
            this.rootGroupBox.ResumeLayout(false);
            this.rootGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootPic)).EndInit();
            this.grapeGroupBox.ResumeLayout(false);
            this.grapeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grapePic)).EndInit();
            this.creamSodaGroupBox.ResumeLayout(false);
            this.creamSodaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creamSodaPic)).EndInit();
            this.lemonGroupBox.ResumeLayout(false);
            this.lemonGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lemonPic)).EndInit();
            this.salesGroupBox.ResumeLayout(false);
            this.salesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox colaGroupBox;
        private System.Windows.Forms.Label leftCLbl;
        private System.Windows.Forms.Label drinksCLbl;
        private System.Windows.Forms.Label amountCLbl;
        private System.Windows.Forms.PictureBox colaPic;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox rootGroupBox;
        private System.Windows.Forms.Label leftRLbl;
        private System.Windows.Forms.Label drinksRLbl;
        private System.Windows.Forms.Label amountRLbl;
        private System.Windows.Forms.PictureBox rootPic;
        private System.Windows.Forms.GroupBox grapeGroupBox;
        private System.Windows.Forms.Label leftGLbl;
        private System.Windows.Forms.Label drinksGLbl;
        private System.Windows.Forms.Label amountGLbl;
        private System.Windows.Forms.PictureBox grapePic;
        private System.Windows.Forms.GroupBox creamSodaGroupBox;
        private System.Windows.Forms.Label leftCSLbl;
        private System.Windows.Forms.Label drinksCSLbl;
        private System.Windows.Forms.Label amountCSLbl;
        private System.Windows.Forms.PictureBox creamSodaPic;
        private System.Windows.Forms.GroupBox lemonGroupBox;
        private System.Windows.Forms.Label leftLLbl;
        private System.Windows.Forms.Label drinksLLbl;
        private System.Windows.Forms.Label amountLLbl;
        private System.Windows.Forms.PictureBox lemonPic;
        private System.Windows.Forms.GroupBox salesGroupBox;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label salesLbl;
        private System.Windows.Forms.Label selectLbl;
    }
}

