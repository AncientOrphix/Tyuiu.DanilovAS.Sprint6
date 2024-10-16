namespace Tyuiu.DanilovAS.Sprint6.Task0.V27
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCondition_DAS = new GroupBox();
            textBoxTask0_DAS = new TextBox();
            pictureBoxFormula_DAS = new PictureBox();
            groupBox1 = new GroupBox();
            labelVarX_DAS = new Label();
            textBoxVarX_DAS = new TextBox();
            groupBoxResult_DAS = new GroupBox();
            labelResult_DAS = new Label();
            textBoxResult_DAS = new TextBox();
            buttonDone_DAS = new Button();
            buttonHelp_DAS = new Button();
            groupBoxCondition_DAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_DAS).BeginInit();
            groupBox1.SuspendLayout();
            groupBoxResult_DAS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_DAS
            // 
            groupBoxCondition_DAS.Controls.Add(textBoxTask0_DAS);
            groupBoxCondition_DAS.Location = new Point(34, 49);
            groupBoxCondition_DAS.Name = "groupBoxCondition_DAS";
            groupBoxCondition_DAS.Size = new Size(512, 199);
            groupBoxCondition_DAS.TabIndex = 0;
            groupBoxCondition_DAS.TabStop = false;
            groupBoxCondition_DAS.Text = "Условие";
            // 
            // textBoxTask0_DAS
            // 
            textBoxTask0_DAS.BackColor = SystemColors.Menu;
            textBoxTask0_DAS.BorderStyle = BorderStyle.None;
            textBoxTask0_DAS.Cursor = Cursors.IBeam;
            textBoxTask0_DAS.Font = new Font("Segoe UI", 9F);
            textBoxTask0_DAS.Location = new Point(11, 26);
            textBoxTask0_DAS.Multiline = true;
            textBoxTask0_DAS.Name = "textBoxTask0_DAS";
            textBoxTask0_DAS.ReadOnly = true;
            textBoxTask0_DAS.Size = new Size(479, 147);
            textBoxTask0_DAS.TabIndex = 0;
            textBoxTask0_DAS.Text = "Вычислить выражение по формуле, при х = 4";
            // 
            // pictureBoxFormula_DAS
            // 
            pictureBoxFormula_DAS.Image = (Image)resources.GetObject("pictureBoxFormula_DAS.Image");
            pictureBoxFormula_DAS.Location = new Point(552, 59);
            pictureBoxFormula_DAS.Name = "pictureBoxFormula_DAS";
            pictureBoxFormula_DAS.Size = new Size(224, 37);
            pictureBoxFormula_DAS.TabIndex = 1;
            pictureBoxFormula_DAS.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelVarX_DAS);
            groupBox1.Controls.Add(textBoxVarX_DAS);
            groupBox1.Location = new Point(34, 268);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(130, 98);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // labelVarX_DAS
            // 
            labelVarX_DAS.AutoSize = true;
            labelVarX_DAS.Location = new Point(14, 33);
            labelVarX_DAS.Name = "labelVarX_DAS";
            labelVarX_DAS.Size = new Size(86, 15);
            labelVarX_DAS.TabIndex = 3;
            labelVarX_DAS.Text = "Переменная X";
            // 
            // textBoxVarX_DAS
            // 
            textBoxVarX_DAS.Location = new Point(14, 51);
            textBoxVarX_DAS.Name = "textBoxVarX_DAS";
            textBoxVarX_DAS.Size = new Size(100, 23);
            textBoxVarX_DAS.TabIndex = 0;
            textBoxVarX_DAS.KeyPress += textBoxVarX_DAS_KeyPress;
            // 
            // groupBoxResult_DAS
            // 
            groupBoxResult_DAS.Controls.Add(labelResult_DAS);
            groupBoxResult_DAS.Controls.Add(textBoxResult_DAS);
            groupBoxResult_DAS.Location = new Point(564, 268);
            groupBoxResult_DAS.Name = "groupBoxResult_DAS";
            groupBoxResult_DAS.Size = new Size(207, 98);
            groupBoxResult_DAS.TabIndex = 3;
            groupBoxResult_DAS.TabStop = false;
            groupBoxResult_DAS.Text = "Вывод данных";
            // 
            // labelResult_DAS
            // 
            labelResult_DAS.AutoSize = true;
            labelResult_DAS.Location = new Point(11, 28);
            labelResult_DAS.Name = "labelResult_DAS";
            labelResult_DAS.Size = new Size(63, 15);
            labelResult_DAS.TabIndex = 1;
            labelResult_DAS.Text = "Результат:";
            // 
            // textBoxResult_DAS
            // 
            textBoxResult_DAS.BackColor = SystemColors.Control;
            textBoxResult_DAS.Location = new Point(11, 46);
            textBoxResult_DAS.Name = "textBoxResult_DAS";
            textBoxResult_DAS.ReadOnly = true;
            textBoxResult_DAS.Size = new Size(174, 23);
            textBoxResult_DAS.TabIndex = 0;
            // 
            // buttonDone_DAS
            // 
            buttonDone_DAS.Location = new Point(618, 372);
            buttonDone_DAS.Name = "buttonDone_DAS";
            buttonDone_DAS.Size = new Size(153, 36);
            buttonDone_DAS.TabIndex = 4;
            buttonDone_DAS.Text = "Выполнить";
            buttonDone_DAS.UseVisualStyleBackColor = true;
            buttonDone_DAS.Click += buttonDone_DAS_Click;
            // 
            // buttonHelp_DAS
            // 
            buttonHelp_DAS.FlatStyle = FlatStyle.Flat;
            buttonHelp_DAS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonHelp_DAS.Location = new Point(564, 372);
            buttonHelp_DAS.Name = "buttonHelp_DAS";
            buttonHelp_DAS.Size = new Size(48, 41);
            buttonHelp_DAS.TabIndex = 5;
            buttonHelp_DAS.Text = "?";
            buttonHelp_DAS.UseVisualStyleBackColor = true;
            buttonHelp_DAS.Click += buttonHelp_DAS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 425);
            Controls.Add(buttonHelp_DAS);
            Controls.Add(buttonDone_DAS);
            Controls.Add(groupBoxResult_DAS);
            Controls.Add(groupBox1);
            Controls.Add(pictureBoxFormula_DAS);
            Controls.Add(groupBoxCondition_DAS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 27 | Данилов А.С. ";
            groupBoxCondition_DAS.ResumeLayout(false);
            groupBoxCondition_DAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_DAS).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxResult_DAS.ResumeLayout(false);
            groupBoxResult_DAS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_DAS;
        private PictureBox pictureBoxFormula_DAS;
        private GroupBox groupBox1;
        private Label labelVarX_DAS;
        private TextBox textBoxVarX_DAS;
        private GroupBox groupBoxResult_DAS;
        private Label labelResult_DAS;
        private TextBox textBoxResult_DAS;
        private Button buttonDone_DAS;
        private Button buttonHelp_DAS;
        private TextBox textBoxTask0_DAS;
    }
}
