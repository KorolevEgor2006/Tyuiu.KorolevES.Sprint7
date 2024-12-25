namespace Tyuiu.KorolevES.Sprint7.Project.V5
{
    partial class FormManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManual));
            groupBoxUpInfo_KES = new GroupBox();
            textBoxInfoUpPanel_KES = new TextBox();
            groupBoxInfoCentralPanel_KES = new GroupBox();
            textBoxInfoCentralPanel_KES = new TextBox();
            groupBoxInfoDownPanel_KES = new GroupBox();
            textBoxInfoDownPanel_KES = new TextBox();
            buttonCloseWindow_KES = new Button();
            groupBoxUpInfo_KES.SuspendLayout();
            groupBoxInfoCentralPanel_KES.SuspendLayout();
            groupBoxInfoDownPanel_KES.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUpInfo_KES
            // 
            groupBoxUpInfo_KES.Controls.Add(textBoxInfoUpPanel_KES);
            groupBoxUpInfo_KES.Location = new Point(12, 12);
            groupBoxUpInfo_KES.Name = "groupBoxUpInfo_KES";
            groupBoxUpInfo_KES.Size = new Size(776, 181);
            groupBoxUpInfo_KES.TabIndex = 0;
            groupBoxUpInfo_KES.TabStop = false;
            groupBoxUpInfo_KES.Text = "Информация о верхней части окна:";
            // 
            // textBoxInfoUpPanel_KES
            // 
            textBoxInfoUpPanel_KES.BackColor = SystemColors.Control;
            textBoxInfoUpPanel_KES.BorderStyle = BorderStyle.None;
            textBoxInfoUpPanel_KES.Dock = DockStyle.Fill;
            textBoxInfoUpPanel_KES.Location = new Point(3, 19);
            textBoxInfoUpPanel_KES.Multiline = true;
            textBoxInfoUpPanel_KES.Name = "textBoxInfoUpPanel_KES";
            textBoxInfoUpPanel_KES.ReadOnly = true;
            textBoxInfoUpPanel_KES.Size = new Size(770, 159);
            textBoxInfoUpPanel_KES.TabIndex = 0;
            textBoxInfoUpPanel_KES.TabStop = false;
            textBoxInfoUpPanel_KES.Text = resources.GetString("textBoxInfoUpPanel_KES.Text");
            // 
            // groupBoxInfoCentralPanel_KES
            // 
            groupBoxInfoCentralPanel_KES.Controls.Add(textBoxInfoCentralPanel_KES);
            groupBoxInfoCentralPanel_KES.Location = new Point(12, 199);
            groupBoxInfoCentralPanel_KES.Name = "groupBoxInfoCentralPanel_KES";
            groupBoxInfoCentralPanel_KES.Size = new Size(776, 77);
            groupBoxInfoCentralPanel_KES.TabIndex = 1;
            groupBoxInfoCentralPanel_KES.TabStop = false;
            groupBoxInfoCentralPanel_KES.Text = "Информация о центральной части окна:";
            // 
            // textBoxInfoCentralPanel_KES
            // 
            textBoxInfoCentralPanel_KES.BackColor = SystemColors.Control;
            textBoxInfoCentralPanel_KES.BorderStyle = BorderStyle.None;
            textBoxInfoCentralPanel_KES.Dock = DockStyle.Fill;
            textBoxInfoCentralPanel_KES.Location = new Point(3, 19);
            textBoxInfoCentralPanel_KES.Multiline = true;
            textBoxInfoCentralPanel_KES.Name = "textBoxInfoCentralPanel_KES";
            textBoxInfoCentralPanel_KES.ReadOnly = true;
            textBoxInfoCentralPanel_KES.Size = new Size(770, 55);
            textBoxInfoCentralPanel_KES.TabIndex = 1;
            textBoxInfoCentralPanel_KES.TabStop = false;
            textBoxInfoCentralPanel_KES.Text = resources.GetString("textBoxInfoCentralPanel_KES.Text");
            // 
            // groupBoxInfoDownPanel_KES
            // 
            groupBoxInfoDownPanel_KES.Controls.Add(textBoxInfoDownPanel_KES);
            groupBoxInfoDownPanel_KES.Location = new Point(12, 282);
            groupBoxInfoDownPanel_KES.Name = "groupBoxInfoDownPanel_KES";
            groupBoxInfoDownPanel_KES.Size = new Size(776, 100);
            groupBoxInfoDownPanel_KES.TabIndex = 2;
            groupBoxInfoDownPanel_KES.TabStop = false;
            groupBoxInfoDownPanel_KES.Text = "Информация о нижней части окна:";
            // 
            // textBoxInfoDownPanel_KES
            // 
            textBoxInfoDownPanel_KES.BackColor = SystemColors.Control;
            textBoxInfoDownPanel_KES.BorderStyle = BorderStyle.None;
            textBoxInfoDownPanel_KES.Dock = DockStyle.Fill;
            textBoxInfoDownPanel_KES.Location = new Point(3, 19);
            textBoxInfoDownPanel_KES.Multiline = true;
            textBoxInfoDownPanel_KES.Name = "textBoxInfoDownPanel_KES";
            textBoxInfoDownPanel_KES.ReadOnly = true;
            textBoxInfoDownPanel_KES.Size = new Size(770, 78);
            textBoxInfoDownPanel_KES.TabIndex = 2;
            textBoxInfoDownPanel_KES.TabStop = false;
            textBoxInfoDownPanel_KES.Text = resources.GetString("textBoxInfoDownPanel_KES.Text");
            // 
            // buttonCloseWindow_KES
            // 
            buttonCloseWindow_KES.Location = new Point(713, 399);
            buttonCloseWindow_KES.Name = "buttonCloseWindow_KES";
            buttonCloseWindow_KES.Size = new Size(75, 23);
            buttonCloseWindow_KES.TabIndex = 3;
            buttonCloseWindow_KES.Text = "Ok";
            buttonCloseWindow_KES.UseVisualStyleBackColor = true;
            buttonCloseWindow_KES.Click += buttonCloseWindow_KES_Click;
            // 
            // FormManual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCloseWindow_KES);
            Controls.Add(groupBoxInfoDownPanel_KES);
            Controls.Add(groupBoxInfoCentralPanel_KES);
            Controls.Add(groupBoxUpInfo_KES);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormManual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство по использованию";
            groupBoxUpInfo_KES.ResumeLayout(false);
            groupBoxUpInfo_KES.PerformLayout();
            groupBoxInfoCentralPanel_KES.ResumeLayout(false);
            groupBoxInfoCentralPanel_KES.PerformLayout();
            groupBoxInfoDownPanel_KES.ResumeLayout(false);
            groupBoxInfoDownPanel_KES.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUpInfo_KES;
        private TextBox textBoxInfoUpPanel_KES;
        private GroupBox groupBoxInfoCentralPanel_KES;
        private TextBox textBoxInfoCentralPanel_KES;
        private GroupBox groupBoxInfoDownPanel_KES;
        private TextBox textBoxInfoDownPanel_KES;
        private Button buttonCloseWindow_KES;
    }
}