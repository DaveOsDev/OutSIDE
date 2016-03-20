namespace OutSIDE.Forms.Dockable
{
    partial class FrmSolutionExplorer
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
            this.solutionTree = new System.Windows.Forms.TreeView();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.messagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // solutionTree
            // 
            this.solutionTree.BackColor = System.Drawing.Color.Black;
            this.solutionTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionTree.ForeColor = System.Drawing.Color.LightGray;
            this.solutionTree.Location = new System.Drawing.Point(0, 0);
            this.solutionTree.Name = "solutionTree";
            this.solutionTree.Size = new System.Drawing.Size(647, 461);
            this.solutionTree.TabIndex = 0;
            // 
            // messagePanel
            // 
            this.messagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messagePanel.BackColor = System.Drawing.Color.Black;
            this.messagePanel.Controls.Add(this.lblMessage);
            this.messagePanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.messagePanel.Location = new System.Drawing.Point(87, 32);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(446, 397);
            this.messagePanel.TabIndex = 1;
            this.messagePanel.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(13, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(417, 370);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "To create a new solution - go to the File Menu and select New Operating System";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSolutionExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 461);
            this.ControlBox = false;
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.solutionTree);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSolutionExplorer";
            this.ShowInTaskbar = false;
            this.Text = "Solution Explorer";
            this.messagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView solutionTree;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Label lblMessage;
    }
}