using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SemestralProjectV2
{
    public partial class Form1 : Form
    {

        //Creating an empty binding list
        BindingList<Question> selectedQuestions = new BindingList<Question>();
        
        public Form1()
        {
            InitializeComponent();
            generateQuestionBtn.Enabled = false;

            rightAnswersDGV.AutoGenerateColumns = false;
            SetUpGrid();

            //sets points to 0
            points = 0;
        }

        //Sets up the dgv
        private void SetUpGrid()
        {
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();

            SetUpCollumn(c1,"Answer","text");
            SetUpCollumn(c2,"Points","points");
            AddItemToGrid(c1); AddItemToGrid(c2);
        }
        
        //Sets up the dgv's collumn
        private void SetUpCollumn(DataGridViewTextBoxColumn c, String header, String dataPropertyName)
        {
            c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            c.HeaderText=header;
            c.DataPropertyName = dataPropertyName;
        }

        //Adds collumns to the grid
        private void AddItemToGrid(DataGridViewTextBoxColumn c)
        {
            rightAnswersDGV.Columns.Add(c);
        }
        
        private void checkBtn_Click(object sender, EventArgs e)
        {
            String answer = textBoxAns.Text.ToString();
            if (Equals(answer,"NA")) return;
            bool found = false;
            int savedI = -1;
            for (int i = 0; i < j; i++)
            {
                found = CheckAnswer(answer.ToLower(), selectedQuestions[rando].Answers[i]);
                if (found) savedI = i;
            }

            
            if (savedI==-1) return;

            
            points += selectedQuestions[rando].Answers[savedI].points;
            pointsLabel.Text = points.ToString();
            rightAnswers.Add(selectedQuestions[rando].Answers[savedI]);
            rightAnswersDGV.DataSource = rightAnswers;
            selectedQuestions[rando].Answers.RemoveAt(savedI);
            j--;
            
            
        }

        //makes the variables universal
        int points;
        int j;
        bool CheckAnswer(String key, Answer answer)
        {

            
            if (Equals(key, answer.text.ToLower())) return true;
            if (Equals(key, answer.backupText.ToLower())) return true;
            return false;
        }

        //This list is used for the data grid view
        BindingList<Answer> rightAnswers;

        //It generates a random question of the selected checkbox's caregories.
        private void generateQuestionBtn_Click(object sender, EventArgs e)
        {
            
            pointsLabel.Text = points.ToString();
            j = 10;
            rightAnswersDGV.DataSource = null;
            rightAnswers = new BindingList<Answer>();
            selectedQuestions.Clear();


            if (checkBoxGeography.Checked)
            {
                addQuestion(0, 4);

            }
            if (checkBoxFilms.Checked)
            {
                addQuestion(5, 9);
            }
            if (checkBoxEveryday.Checked)
            {
                addQuestion(10, 14);
            }
            if (checkBoxHistory.Checked)
            {
                addQuestion(15, 19);
            }
            if (checkBoxTechnology.Checked)
            {
                addQuestion(20, 24);
            }

            rando = new Random().Next(0, selectedQuestions.Count);

            textBoxAnswer.Text = selectedQuestions[rando].question;
        }


        int rando;

        //It adds a category's question to the selected questions
        public void addQuestion(int a,int b)
        {
            for (int i = a; i <= b; i++)
            {
                selectedQuestions.Add(Database.Questions[i]);
            }
        }

        //It calls the button enabler when the state of a checkbox is changed
        bool geoChecked = false;
        private void checkBoxGeography_CheckedChanged(object sender, EventArgs e)
        {
            geoChecked = !geoChecked;
            buttonEnabler();
        }

        bool filmChecked = false;
        private void checkBoxFilms_CheckedChanged(object sender, EventArgs e)
        {
            filmChecked = !filmChecked;
            buttonEnabler();
        }

        bool everyChecked = false;
        private void checkBoxEveryday_CheckedChanged(object sender, EventArgs e)
        {
            everyChecked = !everyChecked;
            buttonEnabler();
        }

        bool historyChecked = false;
        private void checkBoxHistory_CheckedChanged(object sender, EventArgs e)
        {
            historyChecked = !historyChecked;
            buttonEnabler();
        }

        bool techChecked = false;
        private void checkBoxTechnology_CheckedChanged(object sender, EventArgs e)
        {
            techChecked = !techChecked;
            buttonEnabler();
        }

        //It checks if any box is checked and enables the generate question button
        private void buttonEnabler()
        {
            if (geoChecked || techChecked || historyChecked || everyChecked || filmChecked)
            {
                generateQuestionBtn.Enabled = true;
            }
            else
            {
                generateQuestionBtn.Enabled = false;
            }
        }

        
        
        

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
