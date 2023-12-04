namespace UnklabReservation
{
    partial class UserControlGK
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlGK));
            this.RoomName = new System.Windows.Forms.Label();
            this.DescGk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RoomName
            // 
            this.RoomName.BackColor = System.Drawing.Color.Yellow;
            this.RoomName.Dock = System.Windows.Forms.DockStyle.Top;
            this.RoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomName.Location = new System.Drawing.Point(0, 0);
            this.RoomName.Name = "RoomName";
            this.RoomName.Size = new System.Drawing.Size(120, 25);
            this.RoomName.TabIndex = 1;
            this.RoomName.Text = "Temporary";
            this.RoomName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescGk
            // 
            this.DescGk.BackColor = System.Drawing.Color.Magenta;
            this.DescGk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescGk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescGk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DescGk.Image = ((System.Drawing.Image)(resources.GetObject("DescGk.Image")));
            this.DescGk.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.DescGk.Location = new System.Drawing.Point(0, 25);
            this.DescGk.Name = "DescGk";
            this.DescGk.Size = new System.Drawing.Size(120, 95);
            this.DescGk.TabIndex = 2;
            this.DescGk.Text = "Temporary Desc";
            this.DescGk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DescGk.Click += new System.EventHandler(this.Desc_Click);
            // 
            // UserControlGK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.DescGk);
            this.Controls.Add(this.RoomName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UserControlGK";
            this.Size = new System.Drawing.Size(120, 120);
            this.Load += new System.EventHandler(this.UserControlGK_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label RoomName;
        private System.Windows.Forms.Label DescGk;
    }
}
