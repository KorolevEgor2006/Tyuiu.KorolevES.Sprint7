namespace Tyuiu.KorolevES.Sprint7.Project.V5
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            textBoxInfo_KES = new TextBox();
            buttonClose_KES = new Button();
            pictureBoxAvatar_KES = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KES).BeginInit();
            SuspendLayout();
            // 
            // textBoxInfo_KES
            // 
            textBoxInfo_KES.BackColor = SystemColors.Control;
            textBoxInfo_KES.BorderStyle = BorderStyle.None;
            textBoxInfo_KES.Location = new Point(150, 24);
            textBoxInfo_KES.Multiline = true;
            textBoxInfo_KES.Name = "textBoxInfo_KES";
            textBoxInfo_KES.ReadOnly = true;
            textBoxInfo_KES.Size = new Size(319, 146);
            textBoxInfo_KES.TabIndex = 0;
            textBoxInfo_KES.TabStop = false;
            textBoxInfo_KES.Text = resources.GetString("textBoxInfo_KES.Text");
            // 
            // buttonClose_KES
            // 
            buttonClose_KES.Location = new Point(380, 198);
            buttonClose_KES.Name = "buttonClose_KES";
            buttonClose_KES.Size = new Size(75, 23);
            buttonClose_KES.TabIndex = 1;
            buttonClose_KES.Text = "Ok";
            buttonClose_KES.UseVisualStyleBackColor = true;
            buttonClose_KES.Click += buttonClose_KES_Click;
            // 
            // pictureBoxAvatar_KES
            // 
            pictureBoxAvatar_KES.BackgroundImage = Properties.Resources.kandinsky_download_1707307517246;
            pictureBoxAvatar_KES.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxAvatar_KES.Location = new Point(25, 24);
            pictureBoxAvatar_KES.Name = "pictureBoxAvatar_KES";
            pictureBoxAvatar_KES.Size = new Size(119, 146);
            pictureBoxAvatar_KES.TabIndex = 2;
            pictureBoxAvatar_KES.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 233);
            Controls.Add(pictureBoxAvatar_KES);
            Controls.Add(buttonClose_KES);
            Controls.Add(textBoxInfo_KES);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KES).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInfo_KES;
        private Button buttonClose_KES;
        private PictureBox pictureBoxAvatar_KES;
    }
}