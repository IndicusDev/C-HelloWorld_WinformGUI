namespace C_HelloWorld_WinformGUI
{
    partial class F_MAIN
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
            this.BTN_HELLO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_HELLO
            // 
            this.BTN_HELLO.Location = new System.Drawing.Point(25, 27);
            this.BTN_HELLO.Name = "BTN_HELLO";
            this.BTN_HELLO.Size = new System.Drawing.Size(144, 57);
            this.BTN_HELLO.TabIndex = 0;
            this.BTN_HELLO.Text = "Test";
            this.BTN_HELLO.UseVisualStyleBackColor = true;
            this.BTN_HELLO.Click += new System.EventHandler(this.BTN_HELLO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test application functionality\r\n(shows a message box with \'Hello World!\')";
            // 
            // F_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 131);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_HELLO);
            this.Name = "F_MAIN";
            this.Text = "IndicusDev | C# Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_HELLO;
        private System.Windows.Forms.Label label1;
    }
}

