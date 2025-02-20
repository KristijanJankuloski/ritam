namespace TranslationsHelper
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
            treeView = new TreeView();
            txtPathToTranslations = new TextBox();
            label1 = new Label();
            btnLoad = new Button();
            label2 = new Label();
            txtEnTranslations = new TextBox();
            MK = new Label();
            txtMkTranslations = new TextBox();
            lblNodeTitle = new Label();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.Location = new Point(12, 57);
            treeView.Name = "treeView";
            treeView.Size = new Size(397, 384);
            treeView.TabIndex = 0;
            treeView.NodeMouseClick += treeView_NodeMouseClick;
            // 
            // txtPathToTranslations
            // 
            txtPathToTranslations.Location = new Point(12, 28);
            txtPathToTranslations.Name = "txtPathToTranslations";
            txtPathToTranslations.Size = new Size(316, 23);
            txtPathToTranslations.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 2;
            label1.Text = "Path to translations";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(334, 28);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(430, 57);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 4;
            label2.Text = "EN";
            // 
            // txtEnTranslations
            // 
            txtEnTranslations.Location = new Point(430, 75);
            txtEnTranslations.Name = "txtEnTranslations";
            txtEnTranslations.Size = new Size(358, 23);
            txtEnTranslations.TabIndex = 5;
            // 
            // MK
            // 
            MK.AutoSize = true;
            MK.Location = new Point(430, 111);
            MK.Name = "MK";
            MK.Size = new Size(25, 15);
            MK.TabIndex = 6;
            MK.Text = "MK";
            // 
            // txtMkTranslations
            // 
            txtMkTranslations.Location = new Point(430, 129);
            txtMkTranslations.Name = "txtMkTranslations";
            txtMkTranslations.Size = new Size(358, 23);
            txtMkTranslations.TabIndex = 7;
            // 
            // lblNodeTitle
            // 
            lblNodeTitle.AutoSize = true;
            lblNodeTitle.Location = new Point(430, 36);
            lblNodeTitle.Name = "lblNodeTitle";
            lblNodeTitle.Size = new Size(0, 15);
            lblNodeTitle.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
            Controls.Add(lblNodeTitle);
            Controls.Add(txtMkTranslations);
            Controls.Add(MK);
            Controls.Add(txtEnTranslations);
            Controls.Add(label2);
            Controls.Add(btnLoad);
            Controls.Add(label1);
            Controls.Add(txtPathToTranslations);
            Controls.Add(treeView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView;
        private TextBox txtPathToTranslations;
        private Label label1;
        private Button btnLoad;
        private Label label2;
        private TextBox txtEnTranslations;
        private Label MK;
        private TextBox txtMkTranslations;
        private Label lblNodeTitle;
    }
}
