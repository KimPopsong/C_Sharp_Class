using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12_과제
{
    public partial class Exe_1 : Form
    {
        static class Const
        {
            public const int QSIZE = 5;
        }

        GroupBox[] GB = new GroupBox[Const.QSIZE]; // 그룹 박스 
        RadioButton[,] Bogi = new RadioButton[Const.QSIZE, 5];  // 보기 
        Label[] Quiz = new Label[Const.QSIZE];            //문제
        Label lbScore = new Label();     // 점수 표시 Label  
        Button button = new Button();  // Button 
        int Score = 0;                          // 점수 변수
        int[] t = new int[3];
        int[] k = new int[4];

        public Exe_1()
        {
            InitializeComponent();

            this.ClientSize = new System.Drawing.Size(450, 900);

            Random r = new Random();

            for (int i = 0; i < 3; i++)
            {
                t[i] = r.Next(0, 5);

                for (int j = 0; j < i; j++)
                    if (t[j] == t[i])
                    {
                        i--;
                        continue;
                    }
            }

            string aa = "[문제 ";   // 1]  은 소스에서 추가 해야 함
            string[,] Question = new string[5, 6] {
            {"다음중 1+1 = ?" ,"일", "이", "삼","사", "이"},
            { "인천에 있는 산은 ?", "한라산", "백두산", "계양산", "금강산", "계양산"},
            {"우리나라에 가장 많은 성씨는?", "김", "나", "박", "이", "김" },
            {"문제 제작자가 나온 고등학교는?", "계양고", "가좌고", "렛잇고", "동산고", "계양고" },
            {"13 + 3 * 5는?", "16", "80", "28", "66", "28"}
           };

            this.lbScore.AutoSize = true;
            this.lbScore.Location = new System.Drawing.Point(10, 500);
            this.lbScore.Text = "Score : ";
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new Size(38, 12);
            this.Controls.Add(lbScore);

            this.button.Location = new System.Drawing.Point(150, 500);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 1;
            this.button.Text = "채점";
            this.button.UseVisualStyleBackColor = true;
            this.Controls.Add(button);
            this.button.Click += new EventHandler(button_Click);

            for (int n = 0; n < 3; n++)
            {
                GB[t[n]] = new GroupBox();
                this.GB[t[n]].AutoSize = true;
                this.GB[t[n]].Location = new System.Drawing.Point(10, 10 + (n * 150));
                this.GB[t[n]].Size = new System.Drawing.Size(350, 120);
                this.GB[t[n]].TabIndex = 0;
                this.GB[t[n]].TabStop = false;
                this.GB[t[n]].Text = aa + (n + 1) + "] " + Question[t[n], 0];
                this.Controls.Add(GB[t[n]]);

                for (int i = 0; i < 5; i++)
                {
                    Bogi[t[n], i] = new RadioButton();
                    this.Bogi[t[n], i].Location = new System.Drawing.Point(30, 30 + (i * 20));
                    this.Bogi[t[n], i].Size = new System.Drawing.Size(100, 20);
                    this.Bogi[t[n], i].Text = Question[t[n], i + 1];
                    if (i == 4)
                        this.Bogi[t[n], i].Visible = false;
                    this.Controls.Add(Bogi[t[n], i]);
                    this.GB[t[n]].Controls.Add(this.Bogi[t[n], i]);
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Score = 0;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    if (Bogi[t[i], j].Checked == true && (Bogi[t[i], j].Text == Bogi[t[i], 4].Text))
                        Score++;

            lbScore.Text = "Score : " + Score;
        }
    }
}
