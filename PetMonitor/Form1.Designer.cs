namespace PetMonitor
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.latTutor = new System.Windows.Forms.TextBox();
            this.longTutor = new System.Windows.Forms.TextBox();
            this.longPet = new System.Windows.Forms.TextBox();
            this.latPet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDistancia = new System.Windows.Forms.Label();
            this.botaoCalcular = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.msgResultado = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitude";
            // 
            // latTutor
            // 
            this.latTutor.Location = new System.Drawing.Point(138, 52);
            this.latTutor.Name = "latTutor";
            this.latTutor.Size = new System.Drawing.Size(100, 20);
            this.latTutor.TabIndex = 2;
            this.latTutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.latTutor_KeyPress);
            // 
            // longTutor
            // 
            this.longTutor.Location = new System.Drawing.Point(138, 79);
            this.longTutor.Name = "longTutor";
            this.longTutor.Size = new System.Drawing.Size(100, 20);
            this.longTutor.TabIndex = 3;
            // 
            // longPet
            // 
            this.longPet.Location = new System.Drawing.Point(382, 82);
            this.longPet.Name = "longPet";
            this.longPet.Size = new System.Drawing.Size(100, 20);
            this.longPet.TabIndex = 7;
            // 
            // latPet
            // 
            this.latPet.Location = new System.Drawing.Point(382, 55);
            this.latPet.Name = "latPet";
            this.latPet.Size = new System.Drawing.Size(100, 20);
            this.latPet.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Longitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Latitude";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(62, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tutor";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(304, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Distância:";
            // 
            // labelDistancia
            // 
            this.labelDistancia.AutoSize = true;
            this.labelDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistancia.Location = new System.Drawing.Point(84, 11);
            this.labelDistancia.Name = "labelDistancia";
            this.labelDistancia.Size = new System.Drawing.Size(0, 20);
            this.labelDistancia.TabIndex = 11;
            // 
            // botaoCalcular
            // 
            this.botaoCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCalcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botaoCalcular.Location = new System.Drawing.Point(304, 244);
            this.botaoCalcular.Name = "botaoCalcular";
            this.botaoCalcular.Size = new System.Drawing.Size(93, 36);
            this.botaoCalcular.TabIndex = 12;
            this.botaoCalcular.Text = "Calcular";
            this.botaoCalcular.UseVisualStyleBackColor = true;
            this.botaoCalcular.Click += new System.EventHandler(this.botaoCalcular_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelDistancia);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(62, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 40);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // msgResultado
            // 
            this.msgResultado.AutoSize = true;
            this.msgResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgResultado.Location = new System.Drawing.Point(8, 11);
            this.msgResultado.Name = "msgResultado";
            this.msgResultado.Size = new System.Drawing.Size(0, 20);
            this.msgResultado.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.msgResultado);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(62, 182);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(442, 40);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 10;
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botaoLimpar.Location = new System.Drawing.Point(411, 244);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(93, 36);
            this.botaoLimpar.TabIndex = 15;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 350);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.botaoCalcular);
            this.Controls.Add(this.longPet);
            this.Controls.Add(this.latPet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.longTutor);
            this.Controls.Add(this.latTutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetMonitor";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox latTutor;
        private System.Windows.Forms.TextBox longTutor;
        private System.Windows.Forms.TextBox longPet;
        private System.Windows.Forms.TextBox latPet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDistancia;
        private System.Windows.Forms.Button botaoCalcular;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label msgResultado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button botaoLimpar;
    }
}

