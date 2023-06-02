using PollProject.Models;
using static PollProject.Models.Json;
namespace PollProject
{
    public partial class Form1 : Form
    {

        List<Poll> polls = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Poll poll = ReadData<Poll>(openFileDialog1.FileName)!;
                polls.Add(poll);
                Polls.Items.Add(poll.Name!);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Gender gender = new();
            if (MaleRadioButton.Checked == true)
            {
                gender = Gender.Male;
            }
            else gender = Gender.Female;

            Poll poll = new(nameBox.Text, surnameBox.Text, emailBox.Text, phoneBox.Text, Birthday.Text, gender);
            polls.Add(poll);
            Polls.Items.Add(poll.Name!);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (Poll poll in polls)
                {
                    if (poll.Name == fileNameBox.Text)
                    {
                        WriteData<Poll>(poll, folderBrowserDialog1.SelectedPath + "\\" + fileNameBox.Text + ".json");
                    }
                }
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            Poll poll = polls[Polls.SelectedIndex];
            nameBox.Text = poll.Name;
            surnameBox.Text = poll.Surname;
            emailBox.Text = poll.Email;
            phoneBox.Text = poll.Phone;
            Birthday.Text = poll.DateTime;
            if (poll.Gender == Gender.Male) MaleRadioButton.Checked = true;
            else FemaleRadioButton.Checked = true;
        }
    }
}