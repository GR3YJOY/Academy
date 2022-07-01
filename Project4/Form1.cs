namespace Project4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Rectangle racket = new Rectangle();
        Rectangle[] blocks = new Rectangle[100];
        bool[] blockVisible = new bool[100];

        Rectangle ball;

        Brush racketColor = new SolidBrush(Color.Red);
        Brush blockColor = new SolidBrush(Color.Orange);
        Brush ballColor = new SolidBrush(Color.Gold);
        Pen pen = new Pen(Color.Black);

        int formW = 300;
        int formH = 500;

        int nBlocks = 20;

        int racketY = 480;
        int racketW = 50;
        int racketH = 10;

        int blockY = 60;
        int blockW = 30;
        int blockH = 20;

        int ballW = 10;
        int ballH = 10;


        double slope; // 기울기
        double vDir;  // 공 위로 아래로 향하는 방향 여부

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            // 폼 사이즈
            this.ClientSize = new Size(formW, formH);
            this.Text = "BlockBreak v1.0";

            // 그래픽 객체 생성
            g = this.CreateGraphics();

            // 블록 초기화(밑에 메서드 생성)
            InitBlocks();

            // 라켓 초기화
            InitRacket();

            // 공 초기화
            InitBall();
        }

        public void InitBlocks()
        {
            for (int i = 0; i < nBlocks; i++)
            {
                blocks[i] = new Rectangle(i % 10 * blockW,
                                          blockY + blockH * (i / 10),
                                          blockW - 1,
                                          blockH - 1);

                blockVisible[i] = true;
            }
            /*
             *blocks[0] = new Rectangle(10, 10, 20, 10); //첫번째블록(x, y, 가로폭, 세로폭)
             *blocks[1] = new Rectangle(35, 10, 20, 10); //두번째블록 ...
             *blocks[2] = new Rectangle(60, 10, 20, 10); 이것들을 for문으로 나타냄.
             *blocks[3] = new Rectangle(85, 10, 20, 10);
             */
        }

        public void InitRacket()
        {
            racket.X = formW / 2 - racketW / 2;       //라켓의 위치가 정중앙이어야함(x축 시작지점 기준)
            racket.Y = racketY;
            racket.Width = racketW;                   //크기
            racket.Height = racketH;
        }

        public void InitBall()
        {
            ball = new Rectangle();
            ball.X = formW / 2 - ballW / 2;
            ball.Y = blockY + nBlocks / 10 * blockH;
            ball.Width = ballW;
            ball.Height = ballH;

            // 기울기값 초기화
            slope = rand.Next(1, 20) / 10.0;   //+ 값 방향
            if (rand.Next(2) % 2 == 1)         //확률 반반
            {
                slope = -slope;
            }
            vDir = 1;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // 벽돌 그리기
            for (int i = 0; i < nBlocks; i++)
            {
                if (blockVisible[i])
                {
                    g.FillRectangle(blockColor, blocks[i]);
                }
            }
            //g.FillRectangle(blockColor, blocks[0]); -> for문으로.
            //g.FillRectangle(blockColor, blocks[1]);
            //g.FillRectangle(blockColor, blocks[2]);
            //g.FillRectangle(blockColor, blocks[3]);

            // 라켓 그리기
            g.FillRectangle(racketColor, racket);


            // 공 그리기
            g.FillEllipse(ballColor, ball);
            g.DrawEllipse(pen, ball);
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine("tick!");
            //ball.Y += 10;
            double dx = 0;
            double unit = ballW;

            dx = unit / slope;

            int x = (int)dx;
            int y = (int)(vDir * slope * dx);

            Console.WriteLine("x : {0}, y : {1}", x, y);

            ball.X += x;
            ball.Y += y;

            // ball이 좌우 벽에 충돌 했는지 체크 (+값이 벽에 부딪히면 -값이 됨)
            if (ball.X < 0 || ball.X > formW - ballW)
            {
                slope = -slope;
            }

            // ball이 라켓에 맞았는지 체크
            if (ball.Y < 0 || racket.IntersectsWith(ball)) //랙탱글개체와의 충돌감지 메서드
            {
                vDir = -vDir;
            }

            // ball이 벽돌을 맞았는지 체크
            for (int i = 0; i < nBlocks; i++)
            {
                if (ball.IntersectsWith(blocks[i]))
                {
                    vDir = -vDir;  // ball을 반사시킴
                    blockVisible[i] = false;
                }
            }

            //ball을 라켓으로 놓쳤을 때
            if (ball.Y > ClientSize.Height) // 볼이 밑으로 떨어진 상황
            {
                myTimer.Stop();

                DialogResult result = MessageBox.Show("다시 시작하시겠습니까?", "확인", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    InitBlocks();
                    InitRacket();
                    InitBall();

                    //게임 다시 시작
                    myTimer.Start();
                }
                else
                {
                    this.Close();
                }
            }

            // 모든 벽돌을 다 깼을 때


            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                racket.X -= 10;
            }
            else if (e.KeyCode == Keys.Right)
            {
                racket.X += 10;
            }

            Invalidate();
        }
    }
}