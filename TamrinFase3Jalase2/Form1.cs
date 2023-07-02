namespace TamrinFase3Jalase2
{
    public partial class Form1 : Form
    {
        string _fileName = string.Empty; 

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFileBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                _fileName = openFileDialog1.FileName;
                string text = File.ReadAllText(_fileName);

                ShowText(text);
            }
        }

        private void ShowText(string text)
        {
            ShowTextTextBox.Text = text;
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(_fileName))
            {
                File.WriteAllText(_fileName, ShowTextTextBox.Text);
            }
        }
    }
}