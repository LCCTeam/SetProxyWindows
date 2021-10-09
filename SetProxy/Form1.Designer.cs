
namespace SetProxy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSetProxy = new System.Windows.Forms.Button();
            this.txbProxy = new System.Windows.Forms.TextBox();
            this.btnRemoveProxy = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSetProxy
            // 
            this.btnSetProxy.Location = new System.Drawing.Point(46, 121);
            this.btnSetProxy.Name = "btnSetProxy";
            this.btnSetProxy.Size = new System.Drawing.Size(103, 23);
            this.btnSetProxy.TabIndex = 0;
            this.btnSetProxy.Text = "Set Proxy";
            this.btnSetProxy.UseVisualStyleBackColor = true;
            this.btnSetProxy.Click += new System.EventHandler(this.btnSetProxy_Click);
            // 
            // txbProxy
            // 
            this.txbProxy.Location = new System.Drawing.Point(12, 56);
            this.txbProxy.Name = "txbProxy";
            this.txbProxy.Size = new System.Drawing.Size(315, 20);
            this.txbProxy.TabIndex = 1;
            // 
            // btnRemoveProxy
            // 
            this.btnRemoveProxy.Location = new System.Drawing.Point(173, 121);
            this.btnRemoveProxy.Name = "btnRemoveProxy";
            this.btnRemoveProxy.Size = new System.Drawing.Size(103, 23);
            this.btnRemoveProxy.TabIndex = 2;
            this.btnRemoveProxy.Text = "Remove Proxy";
            this.btnRemoveProxy.UseVisualStyleBackColor = true;
            this.btnRemoveProxy.Click += new System.EventHandler(this.btnRemoveProxy_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(62, 89);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(51, 16);
            this.lbResult.TabIndex = 3;
            this.lbResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 182);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnRemoveProxy);
            this.Controls.Add(this.txbProxy);
            this.Controls.Add(this.btnSetProxy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Proxy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetProxy;
        private System.Windows.Forms.TextBox txbProxy;
        private System.Windows.Forms.Button btnRemoveProxy;
        private System.Windows.Forms.Label lbResult;
    }
}

