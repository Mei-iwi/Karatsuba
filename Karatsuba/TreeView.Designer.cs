namespace Karatsuba
{
    partial class TreeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeView));
            treeView1 = new System.Windows.Forms.TreeView();
            btn_Back = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            treeView1.Location = new Point(0, 0);
            treeView1.Margin = new Padding(3, 4, 3, 4);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(716, 599);
            treeView1.TabIndex = 0;
            // 
            // btn_Back
            // 
            btn_Back.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Back.BackColor = Color.Red;
            btn_Back.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = Color.Yellow;
            btn_Back.Location = new Point(786, 525);
            btn_Back.Margin = new Padding(3, 4, 3, 4);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(116, 52);
            btn_Back.TabIndex = 1;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // TreeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btn_Back);
            Controls.Add(treeView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "TreeView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TreeView";
            Load += TreeView_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private Button btn_Back;
    }
}