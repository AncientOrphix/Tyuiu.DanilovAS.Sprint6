namespace Tyuiu.DanilovAS.Sprint6.Task1.V17
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
            groupBoxTask_DAS = new GroupBox();
            pictureBoxTask_DAS = new PictureBox();
            textBoxTask_DAS = new TextBox();
            groupBoxOutPut_DAS = new GroupBox();
            labelResult_DAS = new Label();
            textBoxResult_DAS = new TextBox();
            groupBoxInPut_DAS = new GroupBox();
            labelStop_DAS = new Label();
            labelStart_DAS = new Label();
            textBoxVarStop_DAS = new TextBox();
            textBoxVarStart_DAS = new TextBox();
            buttonHelp_DAS = new Button();
            buttonDone_DAS = new Button();
            groupBoxTask_DAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_DAS).BeginInit();
            groupBoxOutPut_DAS.SuspendLayout();
            groupBoxInPut_DAS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_DAS
            // 
            groupBoxTask_DAS.Controls.Add(pictureBoxTask_DAS);
            groupBoxTask_DAS.Controls.Add(textBoxTask_DAS);
            groupBoxTask_DAS.Location = new Point(31, 47);
            groupBoxTask_DAS.Name = "groupBoxTask_DAS";
            groupBoxTask_DAS.Size = new Size(528, 257);
            groupBoxTask_DAS.TabIndex = 0;
            groupBoxTask_DAS.TabStop = false;
            groupBoxTask_DAS.Text = "Условие";
            // 
            // pictureBoxTask_DAS
            // 
            pictureBoxTask_DAS.Image = (Image)resources.GetObject("pictureBoxTask_DAS.Image");
            pictureBoxTask_DAS.Location = new Point(290, 191);
            pictureBoxTask_DAS.Name = "pictureBoxTask_DAS";
            pictureBoxTask_DAS.Size = new Size(210, 37);
            pictureBoxTask_DAS.TabIndex = 1;
            pictureBoxTask_DAS.TabStop = false;
            // 
            // textBoxTask_DAS
            // 
            textBoxTask_DAS.Location = new Point(14, 30);
            textBoxTask_DAS.Multiline = true;
            textBoxTask_DAS.Name = "textBoxTask_DAS";
            textBoxTask_DAS.ReadOnly = true;
            textBoxTask_DAS.Size = new Size(508, 226);
            textBoxTask_DAS.TabIndex = 0;
            textBoxTask_DAS.Text = "Написать программу, которая выводит таблицу значений функции и произвести табулирование в диапазоне [-5;5] с шагом 1";
            // 
            // groupBoxOutPut_DAS
            // 
            groupBoxOutPut_DAS.Controls.Add(labelResult_DAS);
            groupBoxOutPut_DAS.Controls.Add(textBoxResult_DAS);
            groupBoxOutPut_DAS.Location = new Point(578, 47);
            groupBoxOutPut_DAS.Name = "groupBoxOutPut_DAS";
            groupBoxOutPut_DAS.Size = new Size(210, 362);
            groupBoxOutPut_DAS.TabIndex = 1;
            groupBoxOutPut_DAS.TabStop = false;
            groupBoxOutPut_DAS.Text = "Вывод данных";
            // 
            // labelResult_DAS
            // 
            labelResult_DAS.AutoSize = true;
            labelResult_DAS.Location = new Point(10, 14);
            labelResult_DAS.Name = "labelResult_DAS";
            labelResult_DAS.Size = new Size(60, 15);
            labelResult_DAS.TabIndex = 1;
            labelResult_DAS.Text = "Результат";
            // 
            // textBoxResult_DAS
            // 
            textBoxResult_DAS.Font = new Font("Consolas", 10F);
            textBoxResult_DAS.Location = new Point(6, 32);
            textBoxResult_DAS.Multiline = true;
            textBoxResult_DAS.Name = "textBoxResult_DAS";
            textBoxResult_DAS.ReadOnly = true;
            textBoxResult_DAS.ScrollBars = ScrollBars.Vertical;
            textBoxResult_DAS.Size = new Size(198, 311);
            textBoxResult_DAS.TabIndex = 0;
            // 
            // groupBoxInPut_DAS
            // 
            groupBoxInPut_DAS.Controls.Add(labelStop_DAS);
            groupBoxInPut_DAS.Controls.Add(labelStart_DAS);
            groupBoxInPut_DAS.Controls.Add(textBoxVarStop_DAS);
            groupBoxInPut_DAS.Controls.Add(textBoxVarStart_DAS);
            groupBoxInPut_DAS.Location = new Point(31, 324);
            groupBoxInPut_DAS.Name = "groupBoxInPut_DAS";
            groupBoxInPut_DAS.Size = new Size(264, 85);
            groupBoxInPut_DAS.TabIndex = 2;
            groupBoxInPut_DAS.TabStop = false;
            groupBoxInPut_DAS.Text = "Ввод данных";
            // 
            // labelStop_DAS
            // 
            labelStop_DAS.AutoSize = true;
            labelStop_DAS.Location = new Point(144, 25);
            labelStop_DAS.Name = "labelStop_DAS";
            labelStop_DAS.Size = new Size(65, 15);
            labelStop_DAS.TabIndex = 3;
            labelStop_DAS.Text = "Стоп шага";
            // 
            // labelStart_DAS
            // 
            labelStart_DAS.AutoSize = true;
            labelStart_DAS.Location = new Point(11, 25);
            labelStart_DAS.Name = "labelStart_DAS";
            labelStart_DAS.Size = new Size(69, 15);
            labelStart_DAS.TabIndex = 2;
            labelStart_DAS.Text = "Старт шага";
            // 
            // textBoxVarStop_DAS
            // 
            textBoxVarStop_DAS.Location = new Point(144, 43);
            textBoxVarStop_DAS.Name = "textBoxVarStop_DAS";
            textBoxVarStop_DAS.Size = new Size(100, 23);
            textBoxVarStop_DAS.TabIndex = 1;
            // 
            // textBoxVarStart_DAS
            // 
            textBoxVarStart_DAS.Location = new Point(11, 43);
            textBoxVarStart_DAS.Name = "textBoxVarStart_DAS";
            textBoxVarStart_DAS.Size = new Size(100, 23);
            textBoxVarStart_DAS.TabIndex = 0;
            // 
            // buttonHelp_DAS
            // 
            buttonHelp_DAS.BackColor = Color.DeepSkyBlue;
            buttonHelp_DAS.Location = new Point(341, 349);
            buttonHelp_DAS.Name = "buttonHelp_DAS";
            buttonHelp_DAS.Size = new Size(68, 60);
            buttonHelp_DAS.TabIndex = 3;
            buttonHelp_DAS.Text = "Справка";
            buttonHelp_DAS.UseVisualStyleBackColor = false;
            buttonHelp_DAS.Click += buttonHelp_DAS_Click;
            // 
            // buttonDone_DAS
            // 
            buttonDone_DAS.BackColor = Color.Lime;
            buttonDone_DAS.Location = new Point(415, 345);
            buttonDone_DAS.Name = "buttonDone_DAS";
            buttonDone_DAS.Size = new Size(157, 64);
            buttonDone_DAS.TabIndex = 4;
            buttonDone_DAS.Text = "Выполнить";
            buttonDone_DAS.UseVisualStyleBackColor = false;
            buttonDone_DAS.Click += buttonDone_DAS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_DAS);
            Controls.Add(buttonHelp_DAS);
            Controls.Add(groupBoxInPut_DAS);
            Controls.Add(groupBoxOutPut_DAS);
            Controls.Add(groupBoxTask_DAS);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 17 | Данилов А.С.";
            groupBoxTask_DAS.ResumeLayout(false);
            groupBoxTask_DAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_DAS).EndInit();
            groupBoxOutPut_DAS.ResumeLayout(false);
            groupBoxOutPut_DAS.PerformLayout();
            groupBoxInPut_DAS.ResumeLayout(false);
            groupBoxInPut_DAS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_DAS;
        private GroupBox groupBoxOutPut_DAS;
        private TextBox textBoxTask_DAS;
        private PictureBox pictureBoxTask_DAS;
        private GroupBox groupBoxInPut_DAS;
        private Label labelStop_DAS;
        private Label labelStart_DAS;
        private TextBox textBoxVarStop_DAS;
        private TextBox textBoxVarStart_DAS;
        private Button buttonHelp_DAS;
        private Button buttonDone_DAS;
        private TextBox textBoxResult_DAS;
        private Label labelResult_DAS;
    }
}
