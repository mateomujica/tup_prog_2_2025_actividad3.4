namespace EJ1
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
            rBortoedro = new RadioButton();
            rBcilindro = new RadioButton();
            tbxAncho = new TextBox();
            tbxAltoOrt = new TextBox();
            tbxLargo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbxRadio = new TextBox();
            tbxAltoCil = new TextBox();
            btnCrearFig = new Button();
            lsbInfo = new ListBox();
            btnActualizar = new Button();
            btnOrdenarPArea = new Button();
            btnMasInfo = new Button();
            lsbMasInfo = new ListBox();
            SuspendLayout();
            // 
            // rBortoedro
            // 
            rBortoedro.AutoSize = true;
            rBortoedro.Location = new Point(49, 71);
            rBortoedro.Name = "rBortoedro";
            rBortoedro.Size = new Size(73, 19);
            rBortoedro.TabIndex = 0;
            rBortoedro.TabStop = true;
            rBortoedro.Text = "Ortoedro";
            rBortoedro.UseVisualStyleBackColor = true;
            // 
            // rBcilindro
            // 
            rBcilindro.AutoSize = true;
            rBcilindro.Location = new Point(49, 113);
            rBcilindro.Name = "rBcilindro";
            rBcilindro.Size = new Size(67, 19);
            rBcilindro.TabIndex = 1;
            rBcilindro.TabStop = true;
            rBcilindro.Text = "Cilindro";
            rBcilindro.UseVisualStyleBackColor = true;
            // 
            // tbxAncho
            // 
            tbxAncho.Location = new Point(173, 70);
            tbxAncho.Name = "tbxAncho";
            tbxAncho.Size = new Size(57, 23);
            tbxAncho.TabIndex = 2;
            // 
            // tbxAltoOrt
            // 
            tbxAltoOrt.Location = new Point(250, 70);
            tbxAltoOrt.Name = "tbxAltoOrt";
            tbxAltoOrt.Size = new Size(59, 23);
            tbxAltoOrt.TabIndex = 3;
            // 
            // tbxLargo
            // 
            tbxLargo.Location = new Point(330, 71);
            tbxLargo.Name = "tbxLargo";
            tbxLargo.Size = new Size(58, 23);
            tbxLargo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 53);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 5;
            label1.Text = "Ancho";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 53);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 6;
            label2.Text = "Alto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 53);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 7;
            label3.Text = "Largo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 96);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 8;
            label4.Text = "Radio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 96);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 9;
            label5.Text = "Alto";
            // 
            // tbxRadio
            // 
            tbxRadio.Location = new Point(173, 114);
            tbxRadio.Name = "tbxRadio";
            tbxRadio.Size = new Size(57, 23);
            tbxRadio.TabIndex = 10;
            // 
            // tbxAltoCil
            // 
            tbxAltoCil.Location = new Point(250, 114);
            tbxAltoCil.Name = "tbxAltoCil";
            tbxAltoCil.Size = new Size(59, 23);
            tbxAltoCil.TabIndex = 11;
            // 
            // btnCrearFig
            // 
            btnCrearFig.Location = new Point(418, 70);
            btnCrearFig.Name = "btnCrearFig";
            btnCrearFig.Size = new Size(75, 62);
            btnCrearFig.TabIndex = 12;
            btnCrearFig.Text = "Crear Figura";
            btnCrearFig.UseVisualStyleBackColor = true;
            btnCrearFig.Click += btnCrearFig_Click;
            // 
            // lsbInfo
            // 
            lsbInfo.FormattingEnabled = true;
            lsbInfo.ItemHeight = 15;
            lsbInfo.Location = new Point(49, 165);
            lsbInfo.Name = "lsbInfo";
            lsbInfo.Size = new Size(230, 184);
            lsbInfo.TabIndex = 13;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(293, 173);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 56);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar Listado";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnOrdenarPArea
            // 
            btnOrdenarPArea.Location = new Point(393, 173);
            btnOrdenarPArea.Name = "btnOrdenarPArea";
            btnOrdenarPArea.Size = new Size(75, 56);
            btnOrdenarPArea.TabIndex = 15;
            btnOrdenarPArea.Text = "Ordenar Por Area";
            btnOrdenarPArea.UseVisualStyleBackColor = true;
            btnOrdenarPArea.Click += btnOrdenarPArea_Click;
            // 
            // btnMasInfo
            // 
            btnMasInfo.Location = new Point(293, 247);
            btnMasInfo.Name = "btnMasInfo";
            btnMasInfo.Size = new Size(75, 53);
            btnMasInfo.TabIndex = 16;
            btnMasInfo.Text = "Mostrar mas datos";
            btnMasInfo.UseVisualStyleBackColor = true;
            btnMasInfo.Click += btnMasInfo_Click;
            // 
            // lsbMasInfo
            // 
            lsbMasInfo.BackColor = SystemColors.ActiveCaption;
            lsbMasInfo.FormattingEnabled = true;
            lsbMasInfo.ItemHeight = 15;
            lsbMasInfo.Location = new Point(293, 306);
            lsbMasInfo.Name = "lsbMasInfo";
            lsbMasInfo.Size = new Size(254, 94);
            lsbMasInfo.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lsbMasInfo);
            Controls.Add(btnMasInfo);
            Controls.Add(btnOrdenarPArea);
            Controls.Add(btnActualizar);
            Controls.Add(lsbInfo);
            Controls.Add(btnCrearFig);
            Controls.Add(tbxAltoCil);
            Controls.Add(tbxRadio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxLargo);
            Controls.Add(tbxAltoOrt);
            Controls.Add(tbxAncho);
            Controls.Add(rBcilindro);
            Controls.Add(rBortoedro);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rBortoedro;
        private RadioButton rBcilindro;
        private TextBox tbxAncho;
        private TextBox tbxAltoOrt;
        private TextBox tbxLargo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbxRadio;
        private TextBox tbxAltoCil;
        private Button btnCrearFig;
        public ListBox lsbInfo;
        private Button btnActualizar;
        private Button btnOrdenarPArea;
        private Button btnMasInfo;
        private ListBox lsbMasInfo;
    }
}
