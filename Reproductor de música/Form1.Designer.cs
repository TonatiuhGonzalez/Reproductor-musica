﻿namespace Reproductor_de_música
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
            this.lista_canciones = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_genero = new System.Windows.Forms.Label();
            this.label_año = new System.Windows.Forms.Label();
            this.label_album = new System.Windows.Forms.Label();
            this.label_artista = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botón_inicio = new System.Windows.Forms.Button();
            this.botón_atras = new System.Windows.Forms.Button();
            this.botón_siguiente = new System.Windows.Forms.Button();
            this.botón_fin = new System.Windows.Forms.Button();
            this.botón_stop = new System.Windows.Forms.Button();
            this.botón_play = new System.Windows.Forms.Button();
            this.botón_pausa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lista_canciones
            // 
            this.lista_canciones.FormattingEnabled = true;
            this.lista_canciones.Location = new System.Drawing.Point(9, 3);
            this.lista_canciones.Name = "lista_canciones";
            this.lista_canciones.Size = new System.Drawing.Size(426, 121);
            this.lista_canciones.TabIndex = 0;
            this.lista_canciones.SelectedIndexChanged += new System.EventHandler(this.lista_canciones_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_genero);
            this.groupBox1.Controls.Add(this.label_año);
            this.groupBox1.Controls.Add(this.label_album);
            this.groupBox1.Controls.Add(this.label_artista);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metadatos";
            // 
            // label_genero
            // 
            this.label_genero.AutoSize = true;
            this.label_genero.Location = new System.Drawing.Point(84, 55);
            this.label_genero.Name = "label_genero";
            this.label_genero.Size = new System.Drawing.Size(0, 13);
            this.label_genero.TabIndex = 7;
            // 
            // label_año
            // 
            this.label_año.AutoSize = true;
            this.label_año.Location = new System.Drawing.Point(84, 42);
            this.label_año.Name = "label_año";
            this.label_año.Size = new System.Drawing.Size(0, 13);
            this.label_año.TabIndex = 6;
            // 
            // label_album
            // 
            this.label_album.AutoSize = true;
            this.label_album.Location = new System.Drawing.Point(84, 29);
            this.label_album.Name = "label_album";
            this.label_album.Size = new System.Drawing.Size(0, 13);
            this.label_album.TabIndex = 5;
            // 
            // label_artista
            // 
            this.label_artista.AutoSize = true;
            this.label_artista.Location = new System.Drawing.Point(84, 16);
            this.label_artista.Name = "label_artista";
            this.label_artista.Size = new System.Drawing.Size(0, 13);
            this.label_artista.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Género";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Album";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artista";
            // 
            // botón_inicio
            // 
            this.botón_inicio.Location = new System.Drawing.Point(9, 130);
            this.botón_inicio.Name = "botón_inicio";
            this.botón_inicio.Size = new System.Drawing.Size(39, 23);
            this.botón_inicio.TabIndex = 2;
            this.botón_inicio.Text = "«";
            this.botón_inicio.UseVisualStyleBackColor = true;
            this.botón_inicio.Click += new System.EventHandler(this.botón_inicio_Click);
            // 
            // botón_atras
            // 
            this.botón_atras.Location = new System.Drawing.Point(54, 130);
            this.botón_atras.Name = "botón_atras";
            this.botón_atras.Size = new System.Drawing.Size(39, 23);
            this.botón_atras.TabIndex = 3;
            this.botón_atras.Text = "<";
            this.botón_atras.UseVisualStyleBackColor = true;
            this.botón_atras.Click += new System.EventHandler(this.botón_atras_Click);
            // 
            // botón_siguiente
            // 
            this.botón_siguiente.Location = new System.Drawing.Point(99, 130);
            this.botón_siguiente.Name = "botón_siguiente";
            this.botón_siguiente.Size = new System.Drawing.Size(39, 23);
            this.botón_siguiente.TabIndex = 4;
            this.botón_siguiente.Text = ">";
            this.botón_siguiente.UseVisualStyleBackColor = true;
            this.botón_siguiente.Click += new System.EventHandler(this.botón_siguiente_Click);
            // 
            // botón_fin
            // 
            this.botón_fin.Location = new System.Drawing.Point(144, 130);
            this.botón_fin.Name = "botón_fin";
            this.botón_fin.Size = new System.Drawing.Size(39, 23);
            this.botón_fin.TabIndex = 5;
            this.botón_fin.Text = "»";
            this.botón_fin.UseVisualStyleBackColor = true;
            this.botón_fin.Click += new System.EventHandler(this.botón_fin_Click);
            // 
            // botón_stop
            // 
            this.botón_stop.Location = new System.Drawing.Point(21, 179);
            this.botón_stop.Name = "botón_stop";
            this.botón_stop.Size = new System.Drawing.Size(75, 23);
            this.botón_stop.TabIndex = 6;
            this.botón_stop.Text = "Stop";
            this.botón_stop.UseVisualStyleBackColor = true;
            this.botón_stop.Click += new System.EventHandler(this.botón_stop_Click);
            // 
            // botón_play
            // 
            this.botón_play.Location = new System.Drawing.Point(102, 179);
            this.botón_play.Name = "botón_play";
            this.botón_play.Size = new System.Drawing.Size(75, 23);
            this.botón_play.TabIndex = 7;
            this.botón_play.Text = "Play";
            this.botón_play.UseVisualStyleBackColor = true;
            this.botón_play.Click += new System.EventHandler(this.botón_play_Click);
            // 
            // botón_pausa
            // 
            this.botón_pausa.Location = new System.Drawing.Point(183, 179);
            this.botón_pausa.Name = "botón_pausa";
            this.botón_pausa.Size = new System.Drawing.Size(75, 23);
            this.botón_pausa.TabIndex = 8;
            this.botón_pausa.Text = "Pause";
            this.botón_pausa.UseVisualStyleBackColor = true;
            this.botón_pausa.Click += new System.EventHandler(this.botón_pausa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lista_canciones);
            this.panel1.Controls.Add(this.botón_inicio);
            this.panel1.Controls.Add(this.botón_atras);
            this.panel1.Controls.Add(this.botón_siguiente);
            this.panel1.Controls.Add(this.botón_fin);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 161);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 316);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.botón_pausa);
            this.Controls.Add(this.botón_play);
            this.Controls.Add(this.botón_stop);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lista_canciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_genero;
        private System.Windows.Forms.Label label_año;
        private System.Windows.Forms.Label label_album;
        private System.Windows.Forms.Label label_artista;
        private System.Windows.Forms.Button botón_inicio;
        private System.Windows.Forms.Button botón_atras;
        private System.Windows.Forms.Button botón_siguiente;
        private System.Windows.Forms.Button botón_fin;
        private System.Windows.Forms.Button botón_stop;
        private System.Windows.Forms.Button botón_play;
        private System.Windows.Forms.Button botón_pausa;
        private System.Windows.Forms.Panel panel1;
    }
}

