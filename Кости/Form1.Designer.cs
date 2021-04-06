namespace Кости
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxFeld = new System.Windows.Forms.PictureBox();
            this.pictureBoxDrop = new System.Windows.Forms.PictureBox();
            this.pictureBoxStep = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelHumanAll = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBotAll = new System.Windows.Forms.Label();
            this.labelHumanNow = new System.Windows.Forms.Label();
            this.labelBotNow = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStep)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxFeld
            // 
            this.pictureBoxFeld.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFeld.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBoxFeld.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxFeld.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBoxFeld.Location = new System.Drawing.Point(483, 55);
            this.pictureBoxFeld.Name = "pictureBoxFeld";
            this.pictureBoxFeld.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxFeld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFeld.TabIndex = 0;
            this.pictureBoxFeld.TabStop = false;
            // 
            // pictureBoxDrop
            // 
            this.pictureBoxDrop.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBoxDrop.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDrop.InitialImage")));
            this.pictureBoxDrop.Location = new System.Drawing.Point(122, 240);
            this.pictureBoxDrop.Name = "pictureBoxDrop";
            this.pictureBoxDrop.Size = new System.Drawing.Size(65, 65);
            this.pictureBoxDrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDrop.TabIndex = 1;
            this.pictureBoxDrop.TabStop = false;
            this.pictureBoxDrop.Click += new System.EventHandler(this.pictureBoxDrop_Click);
            // 
            // pictureBoxStep
            // 
            this.pictureBoxStep.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBoxStep.Location = new System.Drawing.Point(264, 240);
            this.pictureBoxStep.Name = "pictureBoxStep";
            this.pictureBoxStep.Size = new System.Drawing.Size(65, 65);
            this.pictureBoxStep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStep.TabIndex = 2;
            this.pictureBoxStep.TabStop = false;
            this.pictureBoxStep.Click += new System.EventHandler(this.pictureBoxStep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Roll a bone\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pass the turn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.новаяИграToolStripMenuItem.Text = "New game";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.НоваяиграToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.выходToolStripMenuItem.Text = "Exit";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.Controls.Add(this.labelHumanAll, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelBotAll, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelHumanNow, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelBotNow, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(75, 311);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(674, 127);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // labelHumanAll
            // 
            this.labelHumanAll.AutoSize = true;
            this.labelHumanAll.Location = new System.Drawing.Point(220, 42);
            this.labelHumanAll.Name = "labelHumanAll";
            this.labelHumanAll.Size = new System.Drawing.Size(33, 17);
            this.labelHumanAll.TabIndex = 7;
            this.labelHumanAll.Text = "*****";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "For now";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "At All";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "BOT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Human";
            // 
            // labelBotAll
            // 
            this.labelBotAll.AutoSize = true;
            this.labelBotAll.Location = new System.Drawing.Point(435, 42);
            this.labelBotAll.Name = "labelBotAll";
            this.labelBotAll.Size = new System.Drawing.Size(33, 17);
            this.labelBotAll.TabIndex = 8;
            this.labelBotAll.Text = "*****";
            // 
            // labelHumanNow
            // 
            this.labelHumanNow.AutoSize = true;
            this.labelHumanNow.Location = new System.Drawing.Point(220, 82);
            this.labelHumanNow.Name = "labelHumanNow";
            this.labelHumanNow.Size = new System.Drawing.Size(33, 17);
            this.labelHumanNow.TabIndex = 9;
            this.labelHumanNow.Text = "*****";
            // 
            // labelBotNow
            // 
            this.labelBotNow.AutoSize = true;
            this.labelBotNow.Location = new System.Drawing.Point(435, 82);
            this.labelBotNow.Name = "labelBotNow";
            this.labelBotNow.Size = new System.Drawing.Size(33, 17);
            this.labelBotNow.TabIndex = 10;
            this.labelBotNow.Text = "*****";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 102);
            this.label7.TabIndex = 7;
            this.label7.Text = "Rules:\r\n-roll a bone as much as u want\r\n-if u take one - u lose all wat u have fo" +
    "r now\r\n-pass the turn to the bot, to save points what u took.\r\n-win thoise, who " +
    "will take 100 points first\r\ngood luck!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxStep);
            this.Controls.Add(this.pictureBoxDrop);
            this.Controls.Add(this.pictureBoxFeld);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStep)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFeld;
        private System.Windows.Forms.PictureBox pictureBoxDrop;
        private System.Windows.Forms.PictureBox pictureBoxStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelHumanAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBotAll;
        private System.Windows.Forms.Label labelHumanNow;
        private System.Windows.Forms.Label labelBotNow;
        private System.Windows.Forms.Label label7;
    }
}

