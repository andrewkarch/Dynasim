namespace DynaSimControlLibrary
{
    partial class GraphControl
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
            this.pbxGraphPictureBox = new System.Windows.Forms.PictureBox();
            this.lstGraphVariableList = new System.Windows.Forms.ListView();
            this.Variables = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pbxGraphPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxGraphPictureBox
            // 
            this.pbxGraphPictureBox.BackColor = System.Drawing.Color.Silver;
            this.pbxGraphPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxGraphPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxGraphPictureBox.Location = new System.Drawing.Point(121, 0);
            this.pbxGraphPictureBox.Name = "pbxGraphPictureBox";
            this.pbxGraphPictureBox.Size = new System.Drawing.Size(396, 359);
            this.pbxGraphPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGraphPictureBox.TabIndex = 0;
            this.pbxGraphPictureBox.TabStop = false;
            // 
            // lstGraphVariableList
            // 
            this.lstGraphVariableList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Variables});
            this.lstGraphVariableList.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstGraphVariableList.Location = new System.Drawing.Point(0, 0);
            this.lstGraphVariableList.Name = "lstGraphVariableList";
            this.lstGraphVariableList.Size = new System.Drawing.Size(121, 359);
            this.lstGraphVariableList.TabIndex = 0;
            this.lstGraphVariableList.UseCompatibleStateImageBehavior = false;
            this.lstGraphVariableList.View = System.Windows.Forms.View.SmallIcon;
            // 
            // GraphControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbxGraphPictureBox);
            this.Controls.Add(this.lstGraphVariableList);
            this.DoubleBuffered = true;
            this.Name = "GraphControl";
            this.Size = new System.Drawing.Size(517, 359);
            this.Resize += new System.EventHandler(this.GraphControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGraphPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxGraphPictureBox;
        private System.Windows.Forms.ListView lstGraphVariableList;
        private System.Windows.Forms.ColumnHeader Variables;
    }
}
