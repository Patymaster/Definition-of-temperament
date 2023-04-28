
namespace WindowsFormsApp1
{
    partial class Test
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
            this.Yes = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.Question = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Label();
            this.Ques = new System.Windows.Forms.Label();
            this.Temp = new System.Windows.Forms.Label();
            this.Retry = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.HonestyTxt = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Yes
            // 
            this.Yes.BackColor = System.Drawing.Color.Cyan;
            this.Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yes.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yes.Location = new System.Drawing.Point(56, 239);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(140, 40);
            this.Yes.TabIndex = 2;
            this.Yes.Text = "Так";
            this.Yes.UseVisualStyleBackColor = false;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(5)))));
            this.Panel.Controls.Add(this.HonestyTxt);
            this.Panel.Controls.Add(this.Exit);
            this.Panel.Controls.Add(this.Retry);
            this.Panel.Controls.Add(this.Temp);
            this.Panel.Controls.Add(this.Question);
            this.Panel.Controls.Add(this.No);
            this.Panel.Controls.Add(this.close);
            this.Panel.Controls.Add(this.Yes);
            this.Panel.Controls.Add(this.Ques);
            this.Panel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel.Location = new System.Drawing.Point(2, 3);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(530, 388);
            this.Panel.TabIndex = 1;
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // Question
            // 
            this.Question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(46)))));
            this.Question.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Question.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Question.Location = new System.Drawing.Point(12, 80);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(506, 139);
            this.Question.TabIndex = 5;
            this.Question.Text = "1. Вам подобається гамір, жвавість, енергійність у Вашому оточенні?";
            this.Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // No
            // 
            this.No.BackColor = System.Drawing.Color.Cyan;
            this.No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.No.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No.Location = new System.Drawing.Point(341, 239);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(140, 40);
            this.No.TabIndex = 4;
            this.No.Text = "Ні";
            this.No.UseVisualStyleBackColor = false;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.AliceBlue;
            this.close.Location = new System.Drawing.Point(501, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.TabIndex = 3;
            this.close.Text = "X";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Ques
            // 
            this.Ques.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(5)))));
            this.Ques.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ques.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Ques.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Ques.Location = new System.Drawing.Point(150, 14);
            this.Ques.Name = "Ques";
            this.Ques.Size = new System.Drawing.Size(232, 41);
            this.Ques.TabIndex = 0;
            this.Ques.Text = "Питання: 1/60";
            this.Ques.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Temp
            // 
            this.Temp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Temp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(46)))));
            this.Temp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Temp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Temp.Location = new System.Drawing.Point(12, 69);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(506, 210);
            this.Temp.TabIndex = 6;
            this.Temp.Text = "text";
            this.Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Retry
            // 
            this.Retry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.Retry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retry.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retry.Location = new System.Drawing.Point(83, 331);
            this.Retry.Name = "Retry";
            this.Retry.Size = new System.Drawing.Size(140, 40);
            this.Retry.TabIndex = 7;
            this.Retry.Text = "Ще раз";
            this.Retry.UseVisualStyleBackColor = false;
            this.Retry.Click += new System.EventHandler(this.Retry_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(308, 331);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(140, 40);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Вихід";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.close_Click);
            // 
            // HonestyTxt
            // 
            this.HonestyTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HonestyTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(46)))));
            this.HonestyTxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HonestyTxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HonestyTxt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HonestyTxt.Location = new System.Drawing.Point(12, 289);
            this.HonestyTxt.Name = "HonestyTxt";
            this.HonestyTxt.Size = new System.Drawing.Size(506, 29);
            this.HonestyTxt.TabIndex = 9;
            this.HonestyTxt.Text = "honesty";
            this.HonestyTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(534, 394);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label Ques;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label Temp;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Retry;
        private System.Windows.Forms.Label HonestyTxt;
    }
}