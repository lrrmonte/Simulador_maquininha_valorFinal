namespace Simulador_maquininha_valor_final
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_Calcular = new System.Windows.Forms.Button();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.tb_valor_venda = new System.Windows.Forms.TextBox();
            this.tb_prazo = new System.Windows.Forms.TextBox();
            this.tb_taxa = new System.Windows.Forms.TextBox();
            this.lb_vlr_receber = new System.Windows.Forms.Label();
            this.lb_pmt_cliente = new System.Windows.Forms.Label();
            this.lb_valor_taxa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Simulador maquininha de cartão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "valor final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digite o valor da venda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Digite o prazo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Digite a taxa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(399, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor final a receber";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(411, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Parcela cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(431, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Taxa R$";
            // 
            // bt_Calcular
            // 
            this.bt_Calcular.BackColor = System.Drawing.Color.Silver;
            this.bt_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Calcular.Location = new System.Drawing.Point(646, 143);
            this.bt_Calcular.Name = "bt_Calcular";
            this.bt_Calcular.Size = new System.Drawing.Size(95, 53);
            this.bt_Calcular.TabIndex = 9;
            this.bt_Calcular.Text = "Calcular";
            this.bt_Calcular.UseVisualStyleBackColor = false;
            this.bt_Calcular.Click += new System.EventHandler(this.bt_Calcular_Click);
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.BackColor = System.Drawing.Color.Silver;
            this.bt_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Limpar.Location = new System.Drawing.Point(646, 246);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(95, 56);
            this.bt_Limpar.TabIndex = 10;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = false;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.Color.Silver;
            this.bt_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sair.Location = new System.Drawing.Point(646, 353);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(95, 58);
            this.bt_Sair.TabIndex = 11;
            this.bt_Sair.Text = "Sair";
            this.bt_Sair.UseVisualStyleBackColor = false;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // tb_valor_venda
            // 
            this.tb_valor_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_venda.Location = new System.Drawing.Point(126, 143);
            this.tb_valor_venda.Name = "tb_valor_venda";
            this.tb_valor_venda.Size = new System.Drawing.Size(140, 24);
            this.tb_valor_venda.TabIndex = 12;
            // 
            // tb_prazo
            // 
            this.tb_prazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_prazo.Location = new System.Drawing.Point(126, 236);
            this.tb_prazo.Name = "tb_prazo";
            this.tb_prazo.Size = new System.Drawing.Size(140, 24);
            this.tb_prazo.TabIndex = 13;
            // 
            // tb_taxa
            // 
            this.tb_taxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_taxa.Location = new System.Drawing.Point(126, 338);
            this.tb_taxa.Name = "tb_taxa";
            this.tb_taxa.Size = new System.Drawing.Size(140, 24);
            this.tb_taxa.TabIndex = 14;
            // 
            // lb_vlr_receber
            // 
            this.lb_vlr_receber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_vlr_receber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vlr_receber.Location = new System.Drawing.Point(402, 143);
            this.lb_vlr_receber.Name = "lb_vlr_receber";
            this.lb_vlr_receber.Size = new System.Drawing.Size(123, 23);
            this.lb_vlr_receber.TabIndex = 15;
            // 
            // lb_pmt_cliente
            // 
            this.lb_pmt_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_pmt_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pmt_cliente.Location = new System.Drawing.Point(402, 236);
            this.lb_pmt_cliente.Name = "lb_pmt_cliente";
            this.lb_pmt_cliente.Size = new System.Drawing.Size(123, 23);
            this.lb_pmt_cliente.TabIndex = 16;
            // 
            // lb_valor_taxa
            // 
            this.lb_valor_taxa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_valor_taxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valor_taxa.Location = new System.Drawing.Point(402, 338);
            this.lb_valor_taxa.Name = "lb_valor_taxa";
            this.lb_valor_taxa.Size = new System.Drawing.Size(123, 23);
            this.lb_valor_taxa.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Image = global::Simulador_maquininha_valor_final.Properties.Resources.maq_cartao1;
            this.label1.Location = new System.Drawing.Point(643, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 98);
            this.label1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_valor_taxa);
            this.Controls.Add(this.lb_pmt_cliente);
            this.Controls.Add(this.lb_vlr_receber);
            this.Controls.Add(this.tb_taxa);
            this.Controls.Add(this.tb_prazo);
            this.Controls.Add(this.tb_valor_venda);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.bt_Calcular);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador maquininha valor final";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_Calcular;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.TextBox tb_valor_venda;
        private System.Windows.Forms.TextBox tb_prazo;
        private System.Windows.Forms.TextBox tb_taxa;
        private System.Windows.Forms.Label lb_vlr_receber;
        private System.Windows.Forms.Label lb_pmt_cliente;
        private System.Windows.Forms.Label lb_valor_taxa;
        private System.Windows.Forms.Label label1;
    }
}

