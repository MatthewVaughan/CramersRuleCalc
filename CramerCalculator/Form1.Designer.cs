namespace CramerCalculator
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.grpMatrixA = new System.Windows.Forms.GroupBox();
            this.grpMatrixX = new System.Windows.Forms.GroupBox();
            this.grpMatrixB = new System.Windows.Forms.GroupBox();
            this.txtA11 = new System.Windows.Forms.TextBox();
            this.txtA12 = new System.Windows.Forms.TextBox();
            this.txtA13 = new System.Windows.Forms.TextBox();
            this.txtA21 = new System.Windows.Forms.TextBox();
            this.txtA22 = new System.Windows.Forms.TextBox();
            this.txtA23 = new System.Windows.Forms.TextBox();
            this.txtA31 = new System.Windows.Forms.TextBox();
            this.txtA32 = new System.Windows.Forms.TextBox();
            this.txtA33 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtX3 = new System.Windows.Forms.TextBox();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.txtB2 = new System.Windows.Forms.TextBox();
            this.txtB3 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtResultX = new System.Windows.Forms.TextBox();
            this.txtResultY = new System.Windows.Forms.TextBox();
            this.txtResultZ = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInstruct = new System.Windows.Forms.TextBox();
            this.grpMatrixA.SuspendLayout();
            this.grpMatrixX.SuspendLayout();
            this.grpMatrixB.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMatrixA
            // 
            this.grpMatrixA.Controls.Add(this.txtA33);
            this.grpMatrixA.Controls.Add(this.txtA32);
            this.grpMatrixA.Controls.Add(this.txtA31);
            this.grpMatrixA.Controls.Add(this.txtA23);
            this.grpMatrixA.Controls.Add(this.txtA22);
            this.grpMatrixA.Controls.Add(this.txtA21);
            this.grpMatrixA.Controls.Add(this.txtA13);
            this.grpMatrixA.Controls.Add(this.txtA12);
            this.grpMatrixA.Controls.Add(this.txtA11);
            this.grpMatrixA.Location = new System.Drawing.Point(59, 226);
            this.grpMatrixA.Name = "grpMatrixA";
            this.grpMatrixA.Size = new System.Drawing.Size(220, 186);
            this.grpMatrixA.TabIndex = 0;
            this.grpMatrixA.TabStop = false;
            this.grpMatrixA.Text = "Matrix A";
            // 
            // grpMatrixX
            // 
            this.grpMatrixX.Controls.Add(this.txtX2);
            this.grpMatrixX.Controls.Add(this.txtX3);
            this.grpMatrixX.Controls.Add(this.txtX1);
            this.grpMatrixX.Location = new System.Drawing.Point(285, 226);
            this.grpMatrixX.Name = "grpMatrixX";
            this.grpMatrixX.Size = new System.Drawing.Size(98, 186);
            this.grpMatrixX.TabIndex = 1;
            this.grpMatrixX.TabStop = false;
            this.grpMatrixX.Text = "Matrix X";
            // 
            // grpMatrixB
            // 
            this.grpMatrixB.Controls.Add(this.txtB2);
            this.grpMatrixB.Controls.Add(this.txtB3);
            this.grpMatrixB.Controls.Add(this.txtB1);
            this.grpMatrixB.Location = new System.Drawing.Point(389, 226);
            this.grpMatrixB.Name = "grpMatrixB";
            this.grpMatrixB.Size = new System.Drawing.Size(91, 186);
            this.grpMatrixB.TabIndex = 1;
            this.grpMatrixB.TabStop = false;
            this.grpMatrixB.Text = "Matrix B";
            // 
            // txtA11
            // 
            this.txtA11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA11.Location = new System.Drawing.Point(35, 36);
            this.txtA11.Name = "txtA11";
            this.txtA11.Size = new System.Drawing.Size(46, 38);
            this.txtA11.TabIndex = 0;
            // 
            // txtA12
            // 
            this.txtA12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA12.Location = new System.Drawing.Point(87, 36);
            this.txtA12.Name = "txtA12";
            this.txtA12.Size = new System.Drawing.Size(46, 38);
            this.txtA12.TabIndex = 1;
            // 
            // txtA13
            // 
            this.txtA13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA13.Location = new System.Drawing.Point(139, 35);
            this.txtA13.Name = "txtA13";
            this.txtA13.Size = new System.Drawing.Size(46, 38);
            this.txtA13.TabIndex = 2;
            // 
            // txtA21
            // 
            this.txtA21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA21.Location = new System.Drawing.Point(35, 80);
            this.txtA21.Name = "txtA21";
            this.txtA21.Size = new System.Drawing.Size(46, 38);
            this.txtA21.TabIndex = 3;
            // 
            // txtA22
            // 
            this.txtA22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA22.Location = new System.Drawing.Point(87, 80);
            this.txtA22.Name = "txtA22";
            this.txtA22.Size = new System.Drawing.Size(46, 38);
            this.txtA22.TabIndex = 4;
            // 
            // txtA23
            // 
            this.txtA23.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA23.Location = new System.Drawing.Point(139, 80);
            this.txtA23.Name = "txtA23";
            this.txtA23.Size = new System.Drawing.Size(46, 38);
            this.txtA23.TabIndex = 5;
            // 
            // txtA31
            // 
            this.txtA31.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA31.Location = new System.Drawing.Point(34, 124);
            this.txtA31.Name = "txtA31";
            this.txtA31.Size = new System.Drawing.Size(46, 38);
            this.txtA31.TabIndex = 6;
            // 
            // txtA32
            // 
            this.txtA32.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA32.Location = new System.Drawing.Point(87, 124);
            this.txtA32.Name = "txtA32";
            this.txtA32.Size = new System.Drawing.Size(46, 38);
            this.txtA32.TabIndex = 7;
            // 
            // txtA33
            // 
            this.txtA33.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA33.Location = new System.Drawing.Point(139, 124);
            this.txtA33.Name = "txtA33";
            this.txtA33.Size = new System.Drawing.Size(46, 38);
            this.txtA33.TabIndex = 8;
            // 
            // txtX1
            // 
            this.txtX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX1.Location = new System.Drawing.Point(23, 35);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(54, 38);
            this.txtX1.TabIndex = 2;
            // 
            // txtX2
            // 
            this.txtX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX2.Location = new System.Drawing.Point(23, 80);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(54, 38);
            this.txtX2.TabIndex = 3;
            // 
            // txtX3
            // 
            this.txtX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX3.Location = new System.Drawing.Point(23, 124);
            this.txtX3.Name = "txtX3";
            this.txtX3.Size = new System.Drawing.Size(54, 38);
            this.txtX3.TabIndex = 4;
            // 
            // txtB1
            // 
            this.txtB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB1.Location = new System.Drawing.Point(19, 35);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(52, 38);
            this.txtB1.TabIndex = 2;
            // 
            // txtB2
            // 
            this.txtB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB2.Location = new System.Drawing.Point(19, 80);
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(52, 38);
            this.txtB2.TabIndex = 3;
            // 
            // txtB3
            // 
            this.txtB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB3.Location = new System.Drawing.Point(19, 124);
            this.txtB3.Name = "txtB3";
            this.txtB3.Size = new System.Drawing.Size(52, 38);
            this.txtB3.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(203, 418);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(238, 45);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtResult
            // 
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Location = new System.Drawing.Point(502, 217);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(130, 51);
            this.txtResult.TabIndex = 3;
            // 
            // txtResultX
            // 
            this.txtResultX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultX.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultX.Location = new System.Drawing.Point(516, 274);
            this.txtResultX.Name = "txtResultX";
            this.txtResultX.ReadOnly = true;
            this.txtResultX.Size = new System.Drawing.Size(100, 24);
            this.txtResultX.TabIndex = 4;
            // 
            // txtResultY
            // 
            this.txtResultY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultY.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultY.Location = new System.Drawing.Point(516, 319);
            this.txtResultY.Name = "txtResultY";
            this.txtResultY.ReadOnly = true;
            this.txtResultY.Size = new System.Drawing.Size(100, 24);
            this.txtResultY.TabIndex = 5;
            // 
            // txtResultZ
            // 
            this.txtResultZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultZ.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultZ.Location = new System.Drawing.Point(516, 363);
            this.txtResultZ.Name = "txtResultZ";
            this.txtResultZ.ReadOnly = true;
            this.txtResultZ.Size = new System.Drawing.Size(100, 24);
            this.txtResultZ.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtInstruct
            // 
            this.txtInstruct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInstruct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstruct.Location = new System.Drawing.Point(55, 44);
            this.txtInstruct.Multiline = true;
            this.txtInstruct.Name = "txtInstruct";
            this.txtInstruct.ReadOnly = true;
            this.txtInstruct.Size = new System.Drawing.Size(626, 162);
            this.txtInstruct.TabIndex = 8;
            this.txtInstruct.Text = resources.GetString("txtInstruct.Text");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 551);
            this.Controls.Add(this.txtInstruct);
            this.Controls.Add(this.txtResultZ);
            this.Controls.Add(this.txtResultY);
            this.Controls.Add(this.txtResultX);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpMatrixX);
            this.Controls.Add(this.grpMatrixB);
            this.Controls.Add(this.grpMatrixA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Cramer\'s Calculator";
            this.grpMatrixA.ResumeLayout(false);
            this.grpMatrixA.PerformLayout();
            this.grpMatrixX.ResumeLayout(false);
            this.grpMatrixX.PerformLayout();
            this.grpMatrixB.ResumeLayout(false);
            this.grpMatrixB.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMatrixA;
        private System.Windows.Forms.TextBox txtA33;
        private System.Windows.Forms.TextBox txtA32;
        private System.Windows.Forms.TextBox txtA31;
        private System.Windows.Forms.TextBox txtA23;
        private System.Windows.Forms.TextBox txtA22;
        private System.Windows.Forms.TextBox txtA21;
        private System.Windows.Forms.TextBox txtA13;
        private System.Windows.Forms.TextBox txtA12;
        private System.Windows.Forms.TextBox txtA11;
        private System.Windows.Forms.GroupBox grpMatrixX;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtX3;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.GroupBox grpMatrixB;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.TextBox txtB3;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtResultX;
        private System.Windows.Forms.TextBox txtResultY;
        private System.Windows.Forms.TextBox txtResultZ;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtInstruct;
    }
}

