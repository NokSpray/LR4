namespace LR4
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
            btnBuild = new Button();
            lstSteps = new ListBox();
            SuspendLayout();
            // 
            // btnBuild
            // 
            btnBuild.Location = new Point(21, 65);
            btnBuild.Name = "btnBuild";
            btnBuild.Size = new Size(403, 199);
            btnBuild.TabIndex = 0;
            btnBuild.Text = "Build Building";
            btnBuild.UseVisualStyleBackColor = true;
            btnBuild.Click += btnBuild_Click;
            // 
            // lstSteps
            // 
            lstSteps.FormattingEnabled = true;
            lstSteps.ItemHeight = 15;
            lstSteps.Location = new Point(490, 65);
            lstSteps.Name = "lstSteps";
            lstSteps.Size = new Size(280, 199);
            lstSteps.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstSteps);
            Controls.Add(btnBuild);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuild;
        private ListBox lstSteps;
    }
}
