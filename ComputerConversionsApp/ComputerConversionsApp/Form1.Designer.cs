namespace ComputerConversionsApp
{
    partial class Form1
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
            this.fromListBox = new System.Windows.Forms.ComboBox();
            this.fromText = new System.Windows.Forms.Label();
            this.toText = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.Label();
            this.toListBox = new System.Windows.Forms.ComboBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputPannel = new System.Windows.Forms.Panel();
            this.outputTextBox = new System.Windows.Forms.Label();
            this.copiedText = new System.Windows.Forms.Label();
            this.inputPanel.SuspendLayout();
            this.outputPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromListBox
            // 
            this.fromListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.fromListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromListBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fromListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.fromListBox.ForeColor = System.Drawing.Color.White;
            this.fromListBox.FormattingEnabled = true;
            this.fromListBox.Items.AddRange(new object[] {
            "Decimal",
            "Binary",
            "Hexadecimal"});
            this.fromListBox.Location = new System.Drawing.Point(19, 62);
            this.fromListBox.Name = "fromListBox";
            this.fromListBox.Size = new System.Drawing.Size(158, 28);
            this.fromListBox.TabIndex = 0;
            this.fromListBox.SelectedIndexChanged += new System.EventHandler(this.fromListBox_SelectedIndexChanged);
            // 
            // fromText
            // 
            this.fromText.AutoSize = true;
            this.fromText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.fromText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.fromText.Location = new System.Drawing.Point(15, 37);
            this.fromText.Name = "fromText";
            this.fromText.Size = new System.Drawing.Size(51, 22);
            this.fromText.TabIndex = 2;
            this.fromText.Text = "From";
            // 
            // toText
            // 
            this.toText.AutoSize = true;
            this.toText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.toText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.toText.Location = new System.Drawing.Point(248, 37);
            this.toText.Name = "toText";
            this.toText.Size = new System.Drawing.Size(32, 22);
            this.toText.TabIndex = 3;
            this.toText.Text = "To";
            // 
            // inputText
            // 
            this.inputText.AutoSize = true;
            this.inputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.inputText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputText.Location = new System.Drawing.Point(15, 126);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(49, 22);
            this.inputText.TabIndex = 4;
            this.inputText.Text = "Input";
            // 
            // outputText
            // 
            this.outputText.AutoSize = true;
            this.outputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.outputText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.outputText.Location = new System.Drawing.Point(15, 245);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(64, 22);
            this.outputText.TabIndex = 5;
            this.outputText.Text = "Output";
            // 
            // toListBox
            // 
            this.toListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.toListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toListBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.toListBox.ForeColor = System.Drawing.Color.White;
            this.toListBox.FormattingEnabled = true;
            this.toListBox.Items.AddRange(new object[] {
            "Decimal",
            "Binary",
            "Hexadecimal"});
            this.toListBox.Location = new System.Drawing.Point(252, 62);
            this.toListBox.Name = "toListBox";
            this.toListBox.Size = new System.Drawing.Size(158, 28);
            this.toListBox.TabIndex = 7;
            this.toListBox.SelectedIndexChanged += new System.EventHandler(this.toListBox_SelectedIndexChanged);
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.ForeColor = System.Drawing.Color.White;
            this.inputBox.Location = new System.Drawing.Point(3, 6);
            this.inputBox.MaxLength = 31;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(387, 22);
            this.inputBox.TabIndex = 8;
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.inputPanel.Controls.Add(this.inputBox);
            this.inputPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.inputPanel.Location = new System.Drawing.Point(19, 151);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(391, 34);
            this.inputPanel.TabIndex = 9;
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.convertButton.ForeColor = System.Drawing.Color.White;
            this.convertButton.Location = new System.Drawing.Point(19, 194);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(84, 38);
            this.convertButton.TabIndex = 10;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // outputPannel
            // 
            this.outputPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.outputPannel.Controls.Add(this.outputTextBox);
            this.outputPannel.Location = new System.Drawing.Point(19, 270);
            this.outputPannel.Name = "outputPannel";
            this.outputPannel.Size = new System.Drawing.Size(391, 34);
            this.outputPannel.TabIndex = 11;
            // 
            // outputTextBox
            // 
            this.outputTextBox.AutoSize = true;
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.outputTextBox.ForeColor = System.Drawing.Color.White;
            this.outputTextBox.Location = new System.Drawing.Point(2, 6);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(64, 22);
            this.outputTextBox.TabIndex = 12;
            this.outputTextBox.Text = "Output";
            this.outputTextBox.Click += new System.EventHandler(this.outputTextBox_Click);
            // 
            // copiedText
            // 
            this.copiedText.AutoSize = true;
            this.copiedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiedText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.copiedText.Location = new System.Drawing.Point(20, 311);
            this.copiedText.Name = "copiedText";
            this.copiedText.Size = new System.Drawing.Size(58, 16);
            this.copiedText.TabIndex = 12;
            this.copiedText.Text = "Copied !";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(428, 338);
            this.Controls.Add(this.copiedText);
            this.Controls.Add(this.outputPannel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.toListBox);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.toText);
            this.Controls.Add(this.fromText);
            this.Controls.Add(this.fromListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Computer Conversion";
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.outputPannel.ResumeLayout(false);
            this.outputPannel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fromListBox;
        private System.Windows.Forms.Label fromText;
        private System.Windows.Forms.Label toText;
        private System.Windows.Forms.Label inputText;
        private System.Windows.Forms.Label outputText;
        private System.Windows.Forms.ComboBox toListBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Panel outputPannel;
        private System.Windows.Forms.Label outputTextBox;
        private System.Windows.Forms.Label copiedText;
    }
}

