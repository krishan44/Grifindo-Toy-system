namespace Programming_2
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOver = new System.Windows.Forms.Button();
            this.btnRange = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report";
            // 
            // btnOver
            // 
            this.btnOver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOver.FlatAppearance.BorderSize = 3;
            this.btnOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOver.Location = new System.Drawing.Point(100, 175);
            this.btnOver.Name = "btnOver";
            this.btnOver.Size = new System.Drawing.Size(148, 116);
            this.btnOver.TabIndex = 1;
            this.btnOver.Text = "Overall Summary";
            this.btnOver.UseVisualStyleBackColor = false;
            this.btnOver.Click += new System.EventHandler(this.btnOver_Click);
            // 
            // btnRange
            // 
            this.btnRange.BackColor = System.Drawing.SystemColors.Info;
            this.btnRange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRange.FlatAppearance.BorderSize = 3;
            this.btnRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRange.Location = new System.Drawing.Point(368, 175);
            this.btnRange.Name = "btnRange";
            this.btnRange.Size = new System.Drawing.Size(148, 116);
            this.btnRange.TabIndex = 2;
            this.btnRange.Text = "Month";
            this.btnRange.UseVisualStyleBackColor = false;
            this.btnRange.Click += new System.EventHandler(this.btnRange_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAll.FlatAppearance.BorderSize = 3;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Location = new System.Drawing.Point(606, 175);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(161, 116);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "All Employee";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Programming_2.Properties.Resources.Graphicloads_100_Flat_2_Arrow_back4;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 82);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Programming_2.Properties.Resources.v546batch3_mynt_34_badgewatercolor_1;
            this.ClientSize = new System.Drawing.Size(868, 497);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnRange);
            this.Controls.Add(this.btnOver);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOver;
        private System.Windows.Forms.Button btnRange;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button button1;
    }
}