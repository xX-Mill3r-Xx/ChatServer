
namespace ChatServer
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.num_Porta = new System.Windows.Forms.NumericUpDown();
            this.btn_StartServer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lista_Log = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_Porta)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_IP
            // 
            this.txt_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IP.Location = new System.Drawing.Point(14, 23);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(471, 34);
            this.txt_IP.TabIndex = 0;
            this.txt_IP.Text = "127.0.0.1";
            // 
            // num_Porta
            // 
            this.num_Porta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Porta.Location = new System.Drawing.Point(507, 22);
            this.num_Porta.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.num_Porta.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_Porta.Name = "num_Porta";
            this.num_Porta.Size = new System.Drawing.Size(120, 34);
            this.num_Porta.TabIndex = 1;
            this.num_Porta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btn_StartServer
            // 
            this.btn_StartServer.Location = new System.Drawing.Point(645, 21);
            this.btn_StartServer.Name = "btn_StartServer";
            this.btn_StartServer.Size = new System.Drawing.Size(240, 36);
            this.btn_StartServer.TabIndex = 2;
            this.btn_StartServer.Text = "Start Server";
            this.btn_StartServer.UseVisualStyleBackColor = true;
            this.btn_StartServer.Click += new System.EventHandler(this.btn_StartServer_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_IP);
            this.panel1.Controls.Add(this.btn_StartServer);
            this.panel1.Controls.Add(this.num_Porta);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 81);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lista_Log);
            this.panel2.Location = new System.Drawing.Point(12, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 561);
            this.panel2.TabIndex = 4;
            // 
            // lista_Log
            // 
            this.lista_Log.BackColor = System.Drawing.SystemColors.Info;
            this.lista_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_Log.FormattingEnabled = true;
            this.lista_Log.ItemHeight = 25;
            this.lista_Log.Location = new System.Drawing.Point(4, 4);
            this.lista_Log.Name = "lista_Log";
            this.lista_Log.Size = new System.Drawing.Size(890, 529);
            this.lista_Log.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 683);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Server";
            ((System.ComponentModel.ISupportInitialize)(this.num_Porta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.NumericUpDown num_Porta;
        private System.Windows.Forms.Button btn_StartServer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lista_Log;
    }
}

