namespace Anketa
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProxyInfo = new System.Windows.Forms.Label();
            this.btnUseProxy = new System.Windows.Forms.Button();
            this.txtProxyInput = new System.Windows.Forms.TextBox();
            this.txtUrlInput = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblCurrentIp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProxyInfo
            // 
            this.lblProxyInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProxyInfo.AutoSize = true;
            this.lblProxyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProxyInfo.Location = new System.Drawing.Point(3, 43);
            this.lblProxyInfo.Name = "lblProxyInfo";
            this.lblProxyInfo.Size = new System.Drawing.Size(260, 18);
            this.lblProxyInfo.TabIndex = 6;
            this.lblProxyInfo.Text = "Proxy (HTTPS only): 0.0.0.0:0000";
            // 
            // btnUseProxy
            // 
            this.btnUseProxy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseProxy.Location = new System.Drawing.Point(6, 173);
            this.btnUseProxy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUseProxy.Name = "btnUseProxy";
            this.btnUseProxy.Size = new System.Drawing.Size(351, 47);
            this.btnUseProxy.TabIndex = 2;
            this.btnUseProxy.Text = "Применить proxy и перейти на сайт";
            this.btnUseProxy.UseVisualStyleBackColor = true;
            this.btnUseProxy.Click += new System.EventHandler(this.btnUseProxy_Click);
            // 
            // txtProxyInput
            // 
            this.txtProxyInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProxyInput.Location = new System.Drawing.Point(6, 69);
            this.txtProxyInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProxyInput.Name = "txtProxyInput";
            this.txtProxyInput.Size = new System.Drawing.Size(348, 22);
            this.txtProxyInput.TabIndex = 1;
            // 
            // txtUrlInput
            // 
            this.txtUrlInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrlInput.Location = new System.Drawing.Point(6, 136);
            this.txtUrlInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrlInput.Name = "txtUrlInput";
            this.txtUrlInput.Size = new System.Drawing.Size(348, 22);
            this.txtUrlInput.TabIndex = 3;
            // 
            // lblUrl
            // 
            this.lblUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUrl.Location = new System.Drawing.Point(85, 106);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(163, 18);
            this.lblUrl.TabIndex = 8;
            this.lblUrl.Text = "Сайт для перехода:";
            // 
            // lblCurrentIp
            // 
            this.lblCurrentIp.AutoSize = true;
            this.lblCurrentIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentIp.Location = new System.Drawing.Point(3, 10);
            this.lblCurrentIp.Name = "lblCurrentIp";
            this.lblCurrentIp.Size = new System.Drawing.Size(151, 18);
            this.lblCurrentIp.TabIndex = 9;
            this.lblCurrentIp.Text = "Текущий IP-адрес:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 227);
            this.Controls.Add(this.lblCurrentIp);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtUrlInput);
            this.Controls.Add(this.txtProxyInput);
            this.Controls.Add(this.btnUseProxy);
            this.Controls.Add(this.lblProxyInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APTD Bot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProxyInfo;
        private System.Windows.Forms.Button btnUseProxy;
        private System.Windows.Forms.TextBox txtProxyInput;
        private System.Windows.Forms.TextBox txtUrlInput;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblCurrentIp;
    }
}

