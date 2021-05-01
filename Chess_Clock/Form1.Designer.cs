
namespace Chess_Clock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Clock_label1 = new System.Windows.Forms.Label();
            this.Clock_label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tool5min = new System.Windows.Forms.ToolStripMenuItem();
            this.tool2min = new System.Windows.Forms.ToolStripMenuItem();
            this.tool1h = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolHour = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool2Minutes = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool5Minutes = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Clock_label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Clock_label2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 422);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Clock_label1
            // 
            this.Clock_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clock_label1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clock_label1.Location = new System.Drawing.Point(3, 0);
            this.Clock_label1.Name = "Clock_label1";
            this.Clock_label1.Size = new System.Drawing.Size(394, 422);
            this.Clock_label1.TabIndex = 0;
            this.Clock_label1.Text = "label1";
            this.Clock_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Clock_label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clock_label2_MouseClick);
            this.Clock_label1.MouseEnter += new System.EventHandler(this.Clock_label1_MouseEnter);
            // 
            // Clock_label2
            // 
            this.Clock_label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clock_label2.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clock_label2.Location = new System.Drawing.Point(403, 0);
            this.Clock_label2.Name = "Clock_label2";
            this.Clock_label2.Size = new System.Drawing.Size(394, 422);
            this.Clock_label2.TabIndex = 1;
            this.Clock_label2.Text = "label2";
            this.Clock_label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Clock_label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clock_label2_MouseClick);
            this.Clock_label2.MouseEnter += new System.EventHandler(this.Clock_label2_MouseEnter);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolTime});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Запуск времени";
            // 
            // ToolTime
            // 
            this.ToolTime.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool5min,
            this.tool2min,
            this.tool1h});
            this.ToolTime.Name = "ToolTime";
            this.ToolTime.Size = new System.Drawing.Size(150, 24);
            this.ToolTime.Text = "Установить время";
            // 
            // tool5min
            // 
            this.tool5min.Name = "tool5min";
            this.tool5min.Size = new System.Drawing.Size(157, 26);
            this.tool5min.Text = "5 минут";
            this.tool5min.Click += new System.EventHandler(this.tool5min_Click);
            // 
            // tool2min
            // 
            this.tool2min.Name = "tool2min";
            this.tool2min.Size = new System.Drawing.Size(157, 26);
            this.tool2min.Text = "2 минуты";
            this.tool2min.Click += new System.EventHandler(this.tool2min_Click);
            // 
            // tool1h
            // 
            this.tool1h.Name = "tool1h";
            this.tool1h.Size = new System.Drawing.Size(157, 26);
            this.tool1h.Text = "1 час";
            this.tool1h.Click += new System.EventHandler(this.tool1h_Click);
            // 
            // ToolHour
            // 
            this.ToolHour.Name = "ToolHour";
            this.ToolHour.Size = new System.Drawing.Size(157, 26);
            this.ToolHour.Text = "1 час";
            // 
            // Tool2Minutes
            // 
            this.Tool2Minutes.Name = "Tool2Minutes";
            this.Tool2Minutes.Size = new System.Drawing.Size(157, 26);
            this.Tool2Minutes.Text = "2 минуты";
            // 
            // Tool5Minutes
            // 
            this.Tool5Minutes.Name = "Tool5Minutes";
            this.Tool5Minutes.Size = new System.Drawing.Size(157, 26);
            this.Tool5Minutes.Text = "5 минут";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Clock_label1;
        private System.Windows.Forms.Label Clock_label2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolTime;
        private System.Windows.Forms.ToolStripMenuItem ToolHour;
        private System.Windows.Forms.ToolStripMenuItem Tool2Minutes;
        private System.Windows.Forms.ToolStripMenuItem Tool5Minutes;
        private System.Windows.Forms.ToolStripMenuItem tool5min;
        private System.Windows.Forms.ToolStripMenuItem tool2min;
        private System.Windows.Forms.ToolStripMenuItem tool1h;
    }
}

