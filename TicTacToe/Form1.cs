namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        public int player = 1;
        public int turns = 1;

        private void onclick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player % 2 != 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "O";
                    player++;
                    turns++;
                }
            }
            if (Winner() == true)
            {
                if (button.Text == "X")
                {
                    MessageBox.Show("X is the Winner");
                }
                else
                {
                    MessageBox.Show("O is the Winner");
                }
            }

            if (Draw() == true)
            {
                MessageBox.Show("Draw!!");
            }
        }

        void ResetGame()
        {
            player = 1;
            turns = 1;
            L1.Text = L2.Text = L3.Text = M1.Text = M2.Text = M3.Text = R1.Text = R2.Text = R3.Text = "";
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        bool Winner()
        {
            if ((L1.Text == M1.Text) && (M1.Text == R1.Text) && L1.Text != "")
                return true;
            else if ((L2.Text == M2.Text) && (M2.Text == R2.Text) && L2.Text != "")
                return true;
            else if ((L3.Text == M3.Text) && (M3.Text == R3.Text) && L3.Text != "")
                return true;

            if ((L1.Text == L2.Text) && (L2.Text == L3.Text) && L1.Text != "")
                return true;
            else if ((M1.Text == M2.Text) && (M2.Text == M3.Text) && M1.Text != "")
                return true;
            else if ((R1.Text == R2.Text) && (R2.Text == R3.Text) && R1.Text != "")
                return true;

            if ((L1.Text == M2.Text) && (M2.Text == R3.Text) && L1.Text != "")
                return true;
            else if ((R1.Text == M2.Text) && (M2.Text == L3.Text) && R1.Text != "")
                return true;
            else
                return false;
        }
        bool Draw()
        {
            if (turns == 10)
                return true;
            else
                return false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {

        }
    }
}