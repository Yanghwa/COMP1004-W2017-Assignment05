namespace SharpAutoForm
{
    partial class LoadingForm
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
            this.components = new System.ComponentModel.Container();
            this.NowLoading = new System.Windows.Forms.PictureBox();
            this.LoadingTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NowLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // NowLoading
            // 
            this.NowLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NowLoading.Image = global::SharpAutoForm.Properties.Resources.loading;
            this.NowLoading.Location = new System.Drawing.Point(0, 0);
            this.NowLoading.Name = "NowLoading";
            this.NowLoading.Size = new System.Drawing.Size(300, 200);
            this.NowLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NowLoading.TabIndex = 0;
            this.NowLoading.TabStop = false;
            // 
            // LoadingTime
            // 
            this.LoadingTime.Enabled = true;
            this.LoadingTime.Interval = 2000;
            this.LoadingTime.Tick += new System.EventHandler(this.LoadingTime_Tick);
            // 
            // LoadingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.NowLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            ((System.ComponentModel.ISupportInitialize)(this.NowLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox NowLoading;
        private System.Windows.Forms.Timer LoadingTime;
    }
}