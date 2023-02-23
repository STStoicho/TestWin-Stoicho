namespace TestWin_Stoicho
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
            this.txtbox_avtor = new System.Windows.Forms.TextBox();
            this.txtbox_zaglavie = new System.Windows.Forms.TextBox();
            this.gb_janr = new System.Windows.Forms.GroupBox();
            this.rb_hudojestvena = new System.Windows.Forms.RadioButton();
            this.rb_nauchno = new System.Windows.Forms.RadioButton();
            this.rb_spravochna = new System.Windows.Forms.RadioButton();
            this.lbl_avtor = new System.Windows.Forms.Label();
            this.lbl_zaglavie = new System.Windows.Forms.Label();
            this.cmb_izdatelstvo = new System.Windows.Forms.ComboBox();
            this.lbl_izdatelstvo = new System.Windows.Forms.Label();
            this.gb_korica = new System.Windows.Forms.GroupBox();
            this.btn_predavane = new System.Windows.Forms.Button();
            this.btn_otpechatvane = new System.Windows.Forms.Button();
            this.cb_tvurda = new System.Windows.Forms.CheckBox();
            this.gb_janr.SuspendLayout();
            this.gb_korica.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbox_avtor
            // 
            this.txtbox_avtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtbox_avtor.Location = new System.Drawing.Point(36, 61);
            this.txtbox_avtor.Multiline = true;
            this.txtbox_avtor.Name = "txtbox_avtor";
            this.txtbox_avtor.Size = new System.Drawing.Size(260, 46);
            this.txtbox_avtor.TabIndex = 0;
            this.txtbox_avtor.TextChanged += new System.EventHandler(this.txtbox_avtor_TextChanged);
            // 
            // txtbox_zaglavie
            // 
            this.txtbox_zaglavie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtbox_zaglavie.Location = new System.Drawing.Point(421, 61);
            this.txtbox_zaglavie.Multiline = true;
            this.txtbox_zaglavie.Name = "txtbox_zaglavie";
            this.txtbox_zaglavie.Size = new System.Drawing.Size(260, 46);
            this.txtbox_zaglavie.TabIndex = 1;
            // 
            // gb_janr
            // 
            this.gb_janr.Controls.Add(this.rb_spravochna);
            this.gb_janr.Controls.Add(this.rb_nauchno);
            this.gb_janr.Controls.Add(this.rb_hudojestvena);
            this.gb_janr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gb_janr.Location = new System.Drawing.Point(401, 149);
            this.gb_janr.Name = "gb_janr";
            this.gb_janr.Size = new System.Drawing.Size(300, 224);
            this.gb_janr.TabIndex = 2;
            this.gb_janr.TabStop = false;
            this.gb_janr.Text = "Жанр";
            // 
            // rb_hudojestvena
            // 
            this.rb_hudojestvena.AutoSize = true;
            this.rb_hudojestvena.Location = new System.Drawing.Point(37, 53);
            this.rb_hudojestvena.Name = "rb_hudojestvena";
            this.rb_hudojestvena.Size = new System.Drawing.Size(199, 33);
            this.rb_hudojestvena.TabIndex = 3;
            this.rb_hudojestvena.TabStop = true;
            this.rb_hudojestvena.Text = "художествена";
            this.rb_hudojestvena.UseVisualStyleBackColor = true;
            // 
            // rb_nauchno
            // 
            this.rb_nauchno.AutoSize = true;
            this.rb_nauchno.Location = new System.Drawing.Point(37, 106);
            this.rb_nauchno.Name = "rb_nauchno";
            this.rb_nauchno.Size = new System.Drawing.Size(249, 33);
            this.rb_nauchno.TabIndex = 4;
            this.rb_nauchno.TabStop = true;
            this.rb_nauchno.Text = "научно-популярна";
            this.rb_nauchno.UseVisualStyleBackColor = true;
            // 
            // rb_spravochna
            // 
            this.rb_spravochna.AutoSize = true;
            this.rb_spravochna.Location = new System.Drawing.Point(37, 160);
            this.rb_spravochna.Name = "rb_spravochna";
            this.rb_spravochna.Size = new System.Drawing.Size(157, 33);
            this.rb_spravochna.TabIndex = 5;
            this.rb_spravochna.TabStop = true;
            this.rb_spravochna.Text = "справочна";
            this.rb_spravochna.UseVisualStyleBackColor = true;
            // 
            // lbl_avtor
            // 
            this.lbl_avtor.AutoSize = true;
            this.lbl_avtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_avtor.Location = new System.Drawing.Point(109, 29);
            this.lbl_avtor.Name = "lbl_avtor";
            this.lbl_avtor.Size = new System.Drawing.Size(96, 29);
            this.lbl_avtor.TabIndex = 3;
            this.lbl_avtor.Text = "Автор: ";
            // 
            // lbl_zaglavie
            // 
            this.lbl_zaglavie.AutoSize = true;
            this.lbl_zaglavie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_zaglavie.Location = new System.Drawing.Point(479, 29);
            this.lbl_zaglavie.Name = "lbl_zaglavie";
            this.lbl_zaglavie.Size = new System.Drawing.Size(136, 29);
            this.lbl_zaglavie.TabIndex = 4;
            this.lbl_zaglavie.Text = "Заглавие: ";
            // 
            // cmb_izdatelstvo
            // 
            this.cmb_izdatelstvo.FormattingEnabled = true;
            this.cmb_izdatelstvo.Items.AddRange(new object[] {
            "Просвета"});
            this.cmb_izdatelstvo.Location = new System.Drawing.Point(47, 212);
            this.cmb_izdatelstvo.Name = "cmb_izdatelstvo";
            this.cmb_izdatelstvo.Size = new System.Drawing.Size(238, 24);
            this.cmb_izdatelstvo.TabIndex = 5;
            // 
            // lbl_izdatelstvo
            // 
            this.lbl_izdatelstvo.AutoSize = true;
            this.lbl_izdatelstvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_izdatelstvo.Location = new System.Drawing.Point(77, 169);
            this.lbl_izdatelstvo.Name = "lbl_izdatelstvo";
            this.lbl_izdatelstvo.Size = new System.Drawing.Size(177, 29);
            this.lbl_izdatelstvo.TabIndex = 6;
            this.lbl_izdatelstvo.Text = "Издателство: ";
            // 
            // gb_korica
            // 
            this.gb_korica.Controls.Add(this.cb_tvurda);
            this.gb_korica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gb_korica.Location = new System.Drawing.Point(47, 269);
            this.gb_korica.Name = "gb_korica";
            this.gb_korica.Size = new System.Drawing.Size(238, 172);
            this.gb_korica.TabIndex = 6;
            this.gb_korica.TabStop = false;
            this.gb_korica.Text = "Вид на корицата";
            // 
            // btn_predavane
            // 
            this.btn_predavane.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_predavane.Location = new System.Drawing.Point(126, 492);
            this.btn_predavane.Name = "btn_predavane";
            this.btn_predavane.Size = new System.Drawing.Size(170, 62);
            this.btn_predavane.TabIndex = 8;
            this.btn_predavane.Text = "Предаване";
            this.btn_predavane.UseVisualStyleBackColor = true;
            this.btn_predavane.Click += new System.EventHandler(this.btn_predavane_Click);
            // 
            // btn_otpechatvane
            // 
            this.btn_otpechatvane.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_otpechatvane.Location = new System.Drawing.Point(421, 492);
            this.btn_otpechatvane.Name = "btn_otpechatvane";
            this.btn_otpechatvane.Size = new System.Drawing.Size(194, 62);
            this.btn_otpechatvane.TabIndex = 9;
            this.btn_otpechatvane.Text = "Отпечатване";
            this.btn_otpechatvane.UseVisualStyleBackColor = true;
            // 
            // cb_tvurda
            // 
            this.cb_tvurda.AutoSize = true;
            this.cb_tvurda.Location = new System.Drawing.Point(53, 82);
            this.cb_tvurda.Name = "cb_tvurda";
            this.cb_tvurda.Size = new System.Drawing.Size(118, 33);
            this.cb_tvurda.TabIndex = 1;
            this.cb_tvurda.Text = "твърда";
            this.cb_tvurda.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 604);
            this.Controls.Add(this.btn_otpechatvane);
            this.Controls.Add(this.btn_predavane);
            this.Controls.Add(this.gb_korica);
            this.Controls.Add(this.lbl_izdatelstvo);
            this.Controls.Add(this.cmb_izdatelstvo);
            this.Controls.Add(this.lbl_zaglavie);
            this.Controls.Add(this.lbl_avtor);
            this.Controls.Add(this.gb_janr);
            this.Controls.Add(this.txtbox_zaglavie);
            this.Controls.Add(this.txtbox_avtor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Книжарница";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_janr.ResumeLayout(false);
            this.gb_janr.PerformLayout();
            this.gb_korica.ResumeLayout(false);
            this.gb_korica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_avtor;
        private System.Windows.Forms.TextBox txtbox_zaglavie;
        private System.Windows.Forms.GroupBox gb_janr;
        private System.Windows.Forms.RadioButton rb_spravochna;
        private System.Windows.Forms.RadioButton rb_nauchno;
        private System.Windows.Forms.RadioButton rb_hudojestvena;
        private System.Windows.Forms.Label lbl_avtor;
        private System.Windows.Forms.Label lbl_zaglavie;
        private System.Windows.Forms.ComboBox cmb_izdatelstvo;
        private System.Windows.Forms.Label lbl_izdatelstvo;
        private System.Windows.Forms.GroupBox gb_korica;
        private System.Windows.Forms.Button btn_predavane;
        private System.Windows.Forms.Button btn_otpechatvane;
        private System.Windows.Forms.CheckBox cb_tvurda;
    }
}

