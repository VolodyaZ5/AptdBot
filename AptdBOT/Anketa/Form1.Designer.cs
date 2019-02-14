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
            this.webBrz = new System.Windows.Forms.WebBrowser();
            this.btnToSite = new System.Windows.Forms.Button();
            this.lblProxyInfo = new System.Windows.Forms.Label();
            this.btnUseProxy = new System.Windows.Forms.Button();
            this.txtProxyInput = new System.Windows.Forms.TextBox();
            this.txtUrlInput = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtPortInput = new System.Windows.Forms.TextBox();
            this.lblProxy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrz
            // 
            this.webBrz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrz.Location = new System.Drawing.Point(8, 8);
            this.webBrz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrz.MinimumSize = new System.Drawing.Size(13, 13);
            this.webBrz.Name = "webBrz";
            this.webBrz.Size = new System.Drawing.Size(585, 418);
            this.webBrz.TabIndex = 0;
            // 
            // btnToSite
            // 
            this.btnToSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToSite.Location = new System.Drawing.Point(599, 227);
            this.btnToSite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnToSite.Name = "btnToSite";
            this.btnToSite.Size = new System.Drawing.Size(123, 25);
            this.btnToSite.TabIndex = 5;
            this.btnToSite.Text = "Перейти на сайт";
            this.btnToSite.UseVisualStyleBackColor = true;
            this.btnToSite.Click += new System.EventHandler(this.btnToSite_Click);
            // 
            // lblProxyInfo
            // 
            this.lblProxyInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProxyInfo.AutoSize = true;
            this.lblProxyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProxyInfo.Location = new System.Drawing.Point(597, 8);
            this.lblProxyInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProxyInfo.Name = "lblProxyInfo";
            this.lblProxyInfo.Size = new System.Drawing.Size(130, 15);
            this.lblProxyInfo.TabIndex = 6;
            this.lblProxyInfo.Text = "Proxy: 0.0.0.0:0000";
            // 
            // btnUseProxy
            // 
            this.btnUseProxy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseProxy.Location = new System.Drawing.Point(599, 117);
            this.btnUseProxy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUseProxy.Name = "btnUseProxy";
            this.btnUseProxy.Size = new System.Drawing.Size(123, 25);
            this.btnUseProxy.TabIndex = 2;
            this.btnUseProxy.Text = "Применить proxy";
            this.btnUseProxy.UseVisualStyleBackColor = true;
            this.btnUseProxy.Click += new System.EventHandler(this.btnUseProxy_Click);
            // 
            // txtProxyInput
            // 
            this.txtProxyInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProxyInput.Location = new System.Drawing.Point(599, 29);
            this.txtProxyInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProxyInput.Name = "txtProxyInput";
            this.txtProxyInput.Size = new System.Drawing.Size(122, 20);
            this.txtProxyInput.TabIndex = 1;
            // 
            // txtUrlInput
            // 
            this.txtUrlInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrlInput.Location = new System.Drawing.Point(599, 169);
            this.txtUrlInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUrlInput.Name = "txtUrlInput";
            this.txtUrlInput.Size = new System.Drawing.Size(122, 20);
            this.txtUrlInput.TabIndex = 3;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(599, 190);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(123, 25);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Перейти на URL";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtPortInput
            // 
            this.txtPortInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPortInput.Location = new System.Drawing.Point(599, 83);
            this.txtPortInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtPortInput.Name = "txtPortInput";
            this.txtPortInput.Size = new System.Drawing.Size(122, 20);
            this.txtPortInput.TabIndex = 7;
            // 
            // lblProxy
            // 
            this.lblProxy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProxy.AutoSize = true;
            this.lblProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProxy.Location = new System.Drawing.Point(597, 60);
            this.lblProxy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProxy.Name = "lblProxy";
            this.lblProxy.Size = new System.Drawing.Size(33, 15);
            this.lblProxy.TabIndex = 8;
            this.lblProxy.Text = "Port";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 434);
            this.Controls.Add(this.lblProxy);
            this.Controls.Add(this.txtPortInput);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtUrlInput);
            this.Controls.Add(this.txtProxyInput);
            this.Controls.Add(this.btnUseProxy);
            this.Controls.Add(this.lblProxyInfo);
            this.Controls.Add(this.btnToSite);
            this.Controls.Add(this.webBrz);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APTD Bot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrz;
        private System.Windows.Forms.Button btnToSite;
        private System.Windows.Forms.Label lblProxyInfo;
        private System.Windows.Forms.Button btnUseProxy;
        private System.Windows.Forms.TextBox txtProxyInput;
        private System.Windows.Forms.TextBox txtUrlInput;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtPortInput;
        private System.Windows.Forms.Label lblProxy;
    }
}

