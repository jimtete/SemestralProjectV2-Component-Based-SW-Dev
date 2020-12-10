
namespace SemestralProjectV2
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxGeography = new System.Windows.Forms.CheckBox();
            this.checkBoxFilms = new System.Windows.Forms.CheckBox();
            this.checkBoxEveryday = new System.Windows.Forms.CheckBox();
            this.checkBoxHistory = new System.Windows.Forms.CheckBox();
            this.checkBoxTechnology = new System.Windows.Forms.CheckBox();
            this.generateQuestionBtn = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAns = new System.Windows.Forms.TextBox();
            this.rightAnswersDGV = new System.Windows.Forms.DataGridView();
            this.checkBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rightAnswersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORIES";
            // 
            // checkBoxGeography
            // 
            this.checkBoxGeography.AutoSize = true;
            this.checkBoxGeography.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGeography.Location = new System.Drawing.Point(41, 71);
            this.checkBoxGeography.Name = "checkBoxGeography";
            this.checkBoxGeography.Size = new System.Drawing.Size(107, 24);
            this.checkBoxGeography.TabIndex = 1;
            this.checkBoxGeography.Text = "Geography";
            this.checkBoxGeography.UseVisualStyleBackColor = true;
            this.checkBoxGeography.CheckedChanged += new System.EventHandler(this.checkBoxGeography_CheckedChanged);
            // 
            // checkBoxFilms
            // 
            this.checkBoxFilms.AutoSize = true;
            this.checkBoxFilms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFilms.Location = new System.Drawing.Point(260, 71);
            this.checkBoxFilms.Name = "checkBoxFilms";
            this.checkBoxFilms.Size = new System.Drawing.Size(120, 24);
            this.checkBoxFilms.TabIndex = 2;
            this.checkBoxFilms.Text = "Films and TV";
            this.checkBoxFilms.UseVisualStyleBackColor = true;
            this.checkBoxFilms.CheckedChanged += new System.EventHandler(this.checkBoxFilms_CheckedChanged);
            // 
            // checkBoxEveryday
            // 
            this.checkBoxEveryday.AutoSize = true;
            this.checkBoxEveryday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEveryday.Location = new System.Drawing.Point(466, 71);
            this.checkBoxEveryday.Name = "checkBoxEveryday";
            this.checkBoxEveryday.Size = new System.Drawing.Size(92, 24);
            this.checkBoxEveryday.TabIndex = 3;
            this.checkBoxEveryday.Text = "Everyday";
            this.checkBoxEveryday.UseVisualStyleBackColor = true;
            this.checkBoxEveryday.CheckedChanged += new System.EventHandler(this.checkBoxEveryday_CheckedChanged);
            // 
            // checkBoxHistory
            // 
            this.checkBoxHistory.AutoSize = true;
            this.checkBoxHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHistory.Location = new System.Drawing.Point(41, 143);
            this.checkBoxHistory.Name = "checkBoxHistory";
            this.checkBoxHistory.Size = new System.Drawing.Size(77, 24);
            this.checkBoxHistory.TabIndex = 4;
            this.checkBoxHistory.Text = "History";
            this.checkBoxHistory.UseVisualStyleBackColor = true;
            this.checkBoxHistory.CheckedChanged += new System.EventHandler(this.checkBoxHistory_CheckedChanged);
            // 
            // checkBoxTechnology
            // 
            this.checkBoxTechnology.AutoSize = true;
            this.checkBoxTechnology.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTechnology.Location = new System.Drawing.Point(466, 143);
            this.checkBoxTechnology.Name = "checkBoxTechnology";
            this.checkBoxTechnology.Size = new System.Drawing.Size(109, 24);
            this.checkBoxTechnology.TabIndex = 5;
            this.checkBoxTechnology.Text = "Technology";
            this.checkBoxTechnology.UseVisualStyleBackColor = true;
            this.checkBoxTechnology.CheckedChanged += new System.EventHandler(this.checkBoxTechnology_CheckedChanged);
            // 
            // generateQuestionBtn
            // 
            this.generateQuestionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateQuestionBtn.Location = new System.Drawing.Point(235, 130);
            this.generateQuestionBtn.Name = "generateQuestionBtn";
            this.generateQuestionBtn.Size = new System.Drawing.Size(166, 51);
            this.generateQuestionBtn.TabIndex = 6;
            this.generateQuestionBtn.Text = "Generate Question";
            this.generateQuestionBtn.UseVisualStyleBackColor = true;
            this.generateQuestionBtn.Click += new System.EventHandler(this.generateQuestionBtn_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer.Location = new System.Drawing.Point(41, 229);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ReadOnly = true;
            this.textBoxAnswer.Size = new System.Drawing.Size(534, 26);
            this.textBoxAnswer.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "ANSWER: ";
            
            // 
            // textBoxAns
            // 
            this.textBoxAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAns.Location = new System.Drawing.Point(137, 285);
            this.textBoxAns.Name = "textBoxAns";
            this.textBoxAns.Size = new System.Drawing.Size(313, 26);
            this.textBoxAns.TabIndex = 9;
            // 
            // rightAnswersDGV
            // 
            this.rightAnswersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rightAnswersDGV.Location = new System.Drawing.Point(44, 361);
            this.rightAnswersDGV.Name = "rightAnswersDGV";
            this.rightAnswersDGV.Size = new System.Drawing.Size(530, 248);
            this.rightAnswersDGV.TabIndex = 10;
            // 
            // checkBtn
            // 
            this.checkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBtn.Location = new System.Drawing.Point(466, 270);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(108, 26);
            this.checkBtn.TabIndex = 11;
            this.checkBtn.Text = "CHECK";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "POINTS:";
            
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.Location = new System.Drawing.Point(574, 310);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(0, 18);
            this.pointsLabel.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 640);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.rightAnswersDGV);
            this.Controls.Add(this.textBoxAns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.generateQuestionBtn);
            this.Controls.Add(this.checkBoxTechnology);
            this.Controls.Add(this.checkBoxHistory);
            this.Controls.Add(this.checkBoxEveryday);
            this.Controls.Add(this.checkBoxFilms);
            this.Controls.Add(this.checkBoxGeography);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PES VRES";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rightAnswersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxGeography;
        private System.Windows.Forms.CheckBox checkBoxFilms;
        private System.Windows.Forms.CheckBox checkBoxEveryday;
        private System.Windows.Forms.CheckBox checkBoxHistory;
        private System.Windows.Forms.CheckBox checkBoxTechnology;
        private System.Windows.Forms.Button generateQuestionBtn;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAns;
        private System.Windows.Forms.DataGridView rightAnswersDGV;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pointsLabel;
    }
}

