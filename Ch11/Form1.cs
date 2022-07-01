
/*
 * 날짜: 2022/06/22
 * 이름: 조귀애
 * 내용: Window From에서 버튼, 텍스트박스, 체크박스, 라디오버튼 컨트롤 연습 (p.413 참고)
 */

namespace Ch11
{
    public partial class btnForm3 : Form
    {
        public btnForm3()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메세지박스1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제목과 내용이 있는 메세지박스");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("두개의 버튼을 갖는 메세지박스", "메세지박스3", MessageBoxButtons.YesNo);
        }


        private void btnUid_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;  //txtUid가 어딘가에 선언이 되어있기때문에 빨간색 밑줄 에러가 안뜨는 것 분할(partial) 클래스인 form1(Form1.Designer)에 있는것(하나의 클래스)
            lbUid.Text = "결과 : " + uid;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            lbName.Text = "결과 : " + txtName.Text;
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            lbHp.Text = "결과 : " + txtHp.Text;
        }


        private void btnFruit_Click(object sender, EventArgs e)
        {
            CheckBox[] chbFruits = { chbFruit1, chbFruit2, chbFruit3, chbFruit4, chbFruit5 };

            List<string> fruits = new List<string>();

            foreach (CheckBox chb in chbFruits)
            {
                if (chb.Checked)
                {
                    fruits.Add(chb.Text);
                }
            }

            lbResultFruit.Text = "선택한 과일 : "+String.Join(",", fruits);
        }

        private void btnGender_Click(object sender, EventArgs e)
        {
            if (rdMale.Checked)
            {
                lbResultGender.Text = "결과 : 남자";
            }
            else
            {
                lbResultGender.Text = "결과 : 여자";
            }
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            if (rdYear1.Checked)
            {
                lbResultYear.Text = "결과 : 1학년";
            }
            else if (rdYear2.Checked)
            {
                lbResultYear.Text = "결과 : 2학년";
            }
            else if (rdYear3.Checked)
            {
                lbResultYear.Text = "결과 : 3학년";
            }
            else if (rdYear4.Checked)
            {
                lbResultYear.Text = "결과 : 4학년";
            }
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }
    }
}