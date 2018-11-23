using System.Windows.Forms;

namespace Lab1
{
    partial class FormHangar
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
            this.pictureBoxHangar = new System.Windows.Forms.PictureBox();
            this.pictureBoxTakeFighter = new System.Windows.Forms.PictureBox();
            this.buttonCreateWarPlaner = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonTakePlane = new System.Windows.Forms.Button();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeFighter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxHangar
            // 
            this.pictureBoxHangar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxHangar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHangar.Name = "pictureBoxHangar";
            this.pictureBoxHangar.Size = new System.Drawing.Size(1065, 590);
            this.pictureBoxHangar.TabIndex = 2;
            this.pictureBoxHangar.TabStop = false;
            // 
            // pictureBoxTakeFighter
            // 
            this.pictureBoxTakeFighter.Location = new System.Drawing.Point(0, 99);
            this.pictureBoxTakeFighter.Name = "pictureBoxTakeFighter";
            this.pictureBoxTakeFighter.Size = new System.Drawing.Size(170, 170);
            this.pictureBoxTakeFighter.TabIndex = 3;
            this.pictureBoxTakeFighter.TabStop = false;
            // 
            // buttonCreateWarPlaner
            // 
            this.buttonCreateWarPlaner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateWarPlaner.Location = new System.Drawing.Point(1073, 26);
            this.buttonCreateWarPlaner.Name = "buttonCreateWarPlaner";
            this.buttonCreateWarPlaner.Size = new System.Drawing.Size(107, 36);
            this.buttonCreateWarPlaner.TabIndex = 6;
            this.buttonCreateWarPlaner.Text = "Create War Planer";
            this.buttonCreateWarPlaner.UseVisualStyleBackColor = true;
            this.buttonCreateWarPlaner.Click += new System.EventHandler(this.buttonCreateWarPlaner_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBoxTakeFighter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.buttonTakePlane);
            this.groupBox1.Location = new System.Drawing.Point(1118, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 271);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Take plane";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "place";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(102, 31);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(50, 22);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // buttonTakePlane
            // 
            this.buttonTakePlane.Location = new System.Drawing.Point(23, 63);
            this.buttonTakePlane.Name = "buttonTakePlane";
            this.buttonTakePlane.Size = new System.Drawing.Size(120, 30);
            this.buttonTakePlane.TabIndex = 0;
            this.buttonTakePlane.Text = "Take";
            this.buttonTakePlane.UseVisualStyleBackColor = true;
            this.buttonTakePlane.Click += new System.EventHandler(this.buttonTakePlane_Click);
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 16;
            this.listBoxLevels.Location = new System.Drawing.Point(1076, 68);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(214, 196);
            this.listBoxLevels.TabIndex = 7;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // FormHangar
            // 
            this.ClientSize = new System.Drawing.Size(1294, 590);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.buttonCreateWarPlaner);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxHangar);
            this.Name = "FormHangar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeFighter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCreateWarPlaner;
        private PictureBox pictureBoxHangar;
        private GroupBox groupBox1;
        private PictureBox pictureBoxTakeFighter;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Button buttonTakePlane;
        private ListBox listBoxLevels;
    }
}

