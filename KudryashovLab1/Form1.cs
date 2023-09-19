namespace KudryashovLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RunPrompt.Enabled = false;
            textboxTarget.Enabled = false;
            buttonTarget.Enabled = false;
            AnswerPrompt.Enabled = false;
            buttonReset.Enabled = false;
            dataArray.ReadOnly = true;
        }
        int[] arr;
        private void buttonNo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
        private void buttonYes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static int Binary(int[] arr, int min, int max, int target)
        {
            int ind = (min + max) / 2;
            int output;
            if (max < min)
            { output = -1; }
            else
            {
                if (arr[ind] == target)
                { output = ind; }
                else if (arr[ind] > target)
                { output = Binary(arr, min, ind - 1, target); }
                else
                { output = Binary(arr, ind + 1, max, target); }
            }
            return output;
        }
        public static int[] ShellSort(int[] arr)
        {
            for (int interval = arr.Length / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < arr.Length; i++)
                {
                    int current = arr[i];
                    int ind = i;
                    while (ind >= interval && arr[ind - interval] > current)
                    {
                        arr[ind] = arr[ind - interval];
                        ind -= interval;
                    }
                    arr[ind] = current;
                }
            }
            return arr;
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            LengthPrompt.Enabled = false;
            textboxLength.Enabled = false;
            buttonGenerate.Enabled = false;
            arr = new int[int.Parse(textboxLength.Text)];
            dataArray.ColumnCount = arr.Length;
            dataArray.RowCount = 1;
            RunPrompt.Enabled = true;
            textboxTarget.Enabled = true;
            buttonTarget.Enabled = true;
            buttonReset.Enabled = true;
            dataArray.ReadOnly = false;
        }
        private void buttonTarget_Click(object sender, EventArgs e)
        {
            RunPrompt.Enabled = false;
            textboxTarget.Enabled = false;
            buttonTarget.Enabled = false;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(dataArray.Rows[0].Cells[i].Value.ToString());
            }
            ShellSort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                dataArray.Rows[0].Cells[i].Value = arr[i];
            }
            AnswerPrompt.Enabled = true;
            AnswerPrompt.Text = "Индекс искомого элемента: " + Binary(arr, 0, arr.Length - 1, int.Parse(textboxTarget.Text));
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            RunPrompt.Enabled = false;
            textboxTarget.Enabled = false;
            buttonTarget.Enabled = false;
            AnswerPrompt.Enabled = false;
            buttonReset.Enabled = false;
            LengthPrompt.Enabled = true;
            textboxLength.Enabled = true;
            buttonGenerate.Enabled = true;
            textboxLength.Text = "";
            textboxTarget.Text = "";
            AnswerPrompt.Text = "Индекс искомого элемента:";
            dataArray.Rows.Clear();
            dataArray.ReadOnly = true;
        }
        private void tabPage2_Enter(object sender, EventArgs e)
        {
            RunPrompt.Enabled = false;
            textboxTarget.Enabled = false;
            buttonTarget.Enabled = false;
            AnswerPrompt.Enabled = false;
            buttonReset.Enabled = false;
            LengthPrompt.Enabled = true;
            textboxLength.Enabled = true;
            buttonGenerate.Enabled = true;
            textboxLength.Text = "";
            textboxTarget.Text = "";
            AnswerPrompt.Text = "Индекс искомого элемента:";
            dataArray.Rows.Clear();
            dataArray.ReadOnly = true;
        }

        private void textboxLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar))) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
        private void textboxTarget_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar))) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
    }
}