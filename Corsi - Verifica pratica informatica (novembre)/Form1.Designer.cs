namespace Corsi___Verifica_pratica_informatica__novembre_
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            aggiunta = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            fabbricabile = new CheckBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            terrenoButton = new RadioButton();
            abitazioneButton = new RadioButton();
            atticoButton = new RadioButton();
            listView1 = new ListView();
            button2 = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 48);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 23);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 48);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(352, 23);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 48);
            textBox3.TabIndex = 2;
            // 
            // aggiunta
            // 
            aggiunta.Location = new Point(24, 505);
            aggiunta.Name = "aggiunta";
            aggiunta.Size = new Size(112, 48);
            aggiunta.TabIndex = 3;
            aggiunta.Text = "Aggiungi";
            aggiunta.UseVisualStyleBackColor = true;
            aggiunta.Click += aggiunta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 93);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "Superficie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 93);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Particella";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 93);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Categoria";
            // 
            // fabbricabile
            // 
            fabbricabile.AutoSize = true;
            fabbricabile.Location = new Point(25, 29);
            fabbricabile.Name = "fabbricabile";
            fabbricabile.Size = new Size(90, 19);
            fabbricabile.TabIndex = 7;
            fabbricabile.Text = "Fabbricabile";
            fabbricabile.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 132);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 9;
            label4.Text = "Numero Vani";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(24, 62);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(139, 48);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 117);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 11;
            label5.Text = "Superficie Terrazzo";
            label5.Click += label5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(30, 47);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(139, 48);
            textBox5.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fabbricabile);
            groupBox1.Location = new Point(520, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 171);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Terreni";
            groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(805, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(208, 171);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Abitazioni";
            // 
            // terrenoButton
            // 
            terrenoButton.AutoSize = true;
            terrenoButton.Location = new Point(428, 300);
            terrenoButton.Name = "terrenoButton";
            terrenoButton.Size = new Size(64, 19);
            terrenoButton.TabIndex = 14;
            terrenoButton.TabStop = true;
            terrenoButton.Text = "Terreno";
            terrenoButton.UseVisualStyleBackColor = true;
            terrenoButton.CheckedChanged += terrenoButton_CheckedChanged;
            // 
            // abitazioneButton
            // 
            abitazioneButton.AutoSize = true;
            abitazioneButton.Location = new Point(428, 325);
            abitazioneButton.Name = "abitazioneButton";
            abitazioneButton.Size = new Size(81, 19);
            abitazioneButton.TabIndex = 15;
            abitazioneButton.TabStop = true;
            abitazioneButton.Text = "Abitazione";
            abitazioneButton.UseVisualStyleBackColor = true;
            abitazioneButton.CheckedChanged += abitazioneButton_CheckedChanged;
            // 
            // atticoButton
            // 
            atticoButton.AutoSize = true;
            atticoButton.Location = new Point(428, 350);
            atticoButton.Name = "atticoButton";
            atticoButton.Size = new Size(57, 19);
            atticoButton.TabIndex = 16;
            atticoButton.TabStop = true;
            atticoButton.Text = "Attico";
            atticoButton.UseVisualStyleBackColor = true;
            atticoButton.CheckedChanged += atticoButton_CheckedChanged;
            // 
            // listView1
            // 
            listView1.Location = new Point(528, 300);
            listView1.Name = "listView1";
            listView1.Size = new Size(904, 302);
            listView1.TabIndex = 17;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // button2
            // 
            button2.Location = new Point(165, 505);
            button2.Name = "button2";
            button2.Size = new Size(112, 48);
            button2.TabIndex = 18;
            button2.Text = "Visualizza";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(1048, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 171);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "Attici";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 627);
            Controls.Add(groupBox3);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(atticoButton);
            Controls.Add(abitazioneButton);
            Controls.Add(terrenoButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(aggiunta);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button aggiunta;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox fabbricabile;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton terrenoButton;
        private RadioButton abitazioneButton;
        private RadioButton atticoButton;
        private ListView listView1;
        private Button button2;
        private GroupBox groupBox3;
    }
}