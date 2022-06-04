namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
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
        }

        void ResetGame()
        {
            player = 1;
            turns = 0;
            L1.Text = L2.Text = L3.Text = M1.Text = M2.Text = M3.Text = R1.Text = R2.Text = R3.Text = "";
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}