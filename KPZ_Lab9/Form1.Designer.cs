namespace KPZ_Lab9
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
            this.tvComponents = new System.Windows.Forms.TreeView();
            this.AddComponent = new System.Windows.Forms.Button();
            this.rbRoom = new System.Windows.Forms.RadioButton();
            this.rbPuzzle = new System.Windows.Forms.RadioButton();
            this.rbItem = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tvComponents
            // 
            this.tvComponents.Location = new System.Drawing.Point(12, 26);
            this.tvComponents.Name = "tvComponents";
            this.tvComponents.Size = new System.Drawing.Size(238, 381);
            this.tvComponents.TabIndex = 0;
            // 
            // AddComponent
            // 
            this.AddComponent.Location = new System.Drawing.Point(285, 130);
            this.AddComponent.Name = "AddComponent";
            this.AddComponent.Size = new System.Drawing.Size(117, 25);
            this.AddComponent.TabIndex = 1;
            this.AddComponent.Text = "AddComponent";
            this.AddComponent.UseVisualStyleBackColor = true;
            this.AddComponent.Click += new System.EventHandler(this.AddComponent_Click);
            // 
            // rbRoom
            // 
            this.rbRoom.AutoSize = true;
            this.rbRoom.Location = new System.Drawing.Point(285, 26);
            this.rbRoom.Name = "rbRoom";
            this.rbRoom.Size = new System.Drawing.Size(61, 21);
            this.rbRoom.TabIndex = 3;
            this.rbRoom.TabStop = true;
            this.rbRoom.Text = "Room";
            this.rbRoom.UseVisualStyleBackColor = true;
            // 
            // rbPuzzle
            // 
            this.rbPuzzle.AutoSize = true;
            this.rbPuzzle.Location = new System.Drawing.Point(285, 53);
            this.rbPuzzle.Name = "rbPuzzle";
            this.rbPuzzle.Size = new System.Drawing.Size(62, 21);
            this.rbPuzzle.TabIndex = 4;
            this.rbPuzzle.TabStop = true;
            this.rbPuzzle.Text = "Puzzle";
            this.rbPuzzle.UseVisualStyleBackColor = true;
            // 
            // rbItem
            // 
            this.rbItem.AutoSize = true;
            this.rbItem.Location = new System.Drawing.Point(285, 80);
            this.rbItem.Name = "rbItem";
            this.rbItem.Size = new System.Drawing.Size(51, 21);
            this.rbItem.TabIndex = 5;
            this.rbItem.TabStop = true;
            this.rbItem.Text = "Item";
            this.rbItem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.rbItem);
            this.Controls.Add(this.rbPuzzle);
            this.Controls.Add(this.rbRoom);
            this.Controls.Add(this.AddComponent);
            this.Controls.Add(this.tvComponents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView tvComponents;
        private Button AddComponent;
        private RadioButton rbRoom;
        private RadioButton rbPuzzle;
        private RadioButton rbItem;
    }
}