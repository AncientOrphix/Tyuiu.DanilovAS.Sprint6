using Tyuiu.DanilovAS.Sprint6.Task1.V17.Lib;

namespace Tyuiu.DanilovAS.Sprint6.Task1.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_DAS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПБ-24-2 Данилов Александр Сергеевич", "Информация");
        }

        DataService ds = new DataService();
        private void buttonDone_DAS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarStart_DAS.Text);
                int stopStep = Convert.ToInt32(textBoxVarStop_DAS.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_DAS.Text = "";
                textBoxResult_DAS.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_DAS.AppendText("+     x    +   f(x)   +" + Environment.NewLine);
                textBoxResult_DAS.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = string.Format("| {0,5:d}    |  {1, 5:f2}   |", startStep, valueArray[i]);
                    textBoxResult_DAS.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_DAS.AppendText("" + Environment.NewLine);
            }

            catch
            {
                MessageBox.Show("Введены неверные данные","Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
