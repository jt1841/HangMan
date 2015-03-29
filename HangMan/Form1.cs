using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CsvHelper;
using System.Reflection;

namespace HangMan
{
    public partial class MainWindow : Form
    {
        public GameRules Game;
        int guessCount;
        bool gameOver;
        bool win;
        Image hang0 = HangMan.Properties.Resources.hang0;
        Image hang1 = HangMan.Properties.Resources.hang1;
        Image hang2 = HangMan.Properties.Resources.hang2;
        Image hang3 = HangMan.Properties.Resources.hang3;
        Image hang4 = HangMan.Properties.Resources.hang4;
        Image hang5 = HangMan.Properties.Resources.hang5;
        Image hang6 = HangMan.Properties.Resources.hang6;

        public MainWindow()
        {
            Game = new GameRules();
            guessCount = 0;
            gameOver = false;
            win = false;
            InitializeComponent();
            Game.NewGame();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void highScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            menuStrip2.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
            label1.Text = Game.word.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void difficultyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.NewGame();
            guessCount = 0;
            pictureBox1.Image = hang0;
            gameOver = false;
            win = false;
            label1.Text = Game.word.ToString();
            label2.ForeColor = Color.Black;
            charA.ForeColor = Color.White;
            charB.ForeColor = Color.White;
            charC.ForeColor = Color.White;
            charD.ForeColor = Color.White;
            charE.ForeColor = Color.White;
            charF.ForeColor = Color.White;
            charG.ForeColor = Color.White;
            charH.ForeColor = Color.White;
            charI.ForeColor = Color.White;
            charJ.ForeColor = Color.White;
            charK.ForeColor = Color.White;
            charL.ForeColor = Color.White;
            charM.ForeColor = Color.White;
            charN.ForeColor = Color.White;
            charO.ForeColor = Color.White;
            charP.ForeColor = Color.White;
            charQ.ForeColor = Color.White;
            charR.ForeColor = Color.White;
            charS.ForeColor = Color.White;
            charT.ForeColor = Color.White;
            charU.ForeColor = Color.White;
            charV.ForeColor = Color.White;
            charW.ForeColor = Color.White;
            charX.ForeColor = Color.White;
            charY.ForeColor = Color.White;
            charZ.ForeColor = Color.White;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                GuessLetter('N');
                charN.ForeColor = Color.Black;
            }
        }

        private void charA_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                charA.ForeColor = Color.Black;
                GuessLetter('A');
            }
        }

        private void charB_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                charB.ForeColor = Color.Black;
                GuessLetter('B');
            }
        }

        private void charC_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                charC.ForeColor = Color.Black;
                GuessLetter('C');
            }
        }

        private void charD_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                charD.ForeColor = Color.Black;
                GuessLetter('D');
            }
        }

        private void charE_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                charE.ForeColor = Color.Black;
                GuessLetter('E');
            }
        }

        private void charF_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                charF.ForeColor = Color.Black;
                GuessLetter('F');
            }
        }

        private void charG_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                charG.ForeColor = Color.Black;
                GuessLetter('G');
            }
        }

        private void charH_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                charH.ForeColor = Color.Black;
                GuessLetter('H');
            }
        }

        private void charI_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                charI.ForeColor = Color.Black;
                GuessLetter('I');
            }
        }

        private void charJ_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                charJ.ForeColor = Color.Black;
                GuessLetter('J');
            }
        }

        private void charK_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                charK.ForeColor = Color.Black;
                GuessLetter('K');
            }
        }

        private void charL_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                charL.ForeColor = Color.Black;
                GuessLetter('L');
            }
        }

        private void charM_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                charM.ForeColor = Color.Black;
                GuessLetter('M');
            }
        }

        private void charO_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                charO.ForeColor = Color.Black;
                GuessLetter('O');
            }
        }

        private void charP_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                GuessLetter('P');
                charP.ForeColor = Color.Black;
            }
        }

        private void charQ_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                GuessLetter('Q');
                charQ.ForeColor = Color.Black;
            }
        }

        private void charR_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                GuessLetter('R');
                charR.ForeColor = Color.Black;
            }
        }

        private void charS_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                GuessLetter('S');
                charS.ForeColor = Color.Black;
            }
        }

        private void charT_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                GuessLetter('T');
                charT.ForeColor = Color.Black;
            }
        }

        private void charU_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                GuessLetter('U');
                charU.ForeColor = Color.Black;
            }
        }

        private void charV_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                GuessLetter('V');
                charV.ForeColor = Color.Black;
            }
        }

        private void charW_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                GuessLetter('W');
                charW.ForeColor = Color.Black;
            }
        }

        private void charX_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                GuessLetter('X');
                charX.ForeColor = Color.Black;
            }
        }

        private void charY_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                GuessLetter('Y');
                charY.ForeColor = Color.Black;
            }
        }

        private void charZ_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                GuessLetter('Z');
                charZ.ForeColor = Color.Black;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        public void GuessLetter(char c)
        {

            if (!Game.solvedWord.Contains(c))
            {
                guessCount++;
                if (guessCount > 5)
                {
                    gameOver = true;
                    win = false;
                    label2.Text = "Game Over!";
                    label2.ForeColor = Color.White;
                    UpdateWord('!');
                }


                DrawHangman(guessCount);
            }
            else
            {
                UpdateWord(c);
                if (win)
                {
                    gameOver = true;
                    win = true;
                    label2.Text = "You Win!";
                    label2.ForeColor = Color.White;

                }
            }

        }
        private void DrawHangman(int count)
        {
            //update picture
            switch (count)
            {
                case 1:
                    pictureBox1.Image = hang1;
                    break;
                case 2:
                    pictureBox1.Image = hang2;
                    break;
                case 3:
                    pictureBox1.Image = hang3;
                    break;
                case 4:
                    pictureBox1.Image = hang4;
                    break;
                case 5:
                    pictureBox1.Image = hang5;
                    break;
                case 6:
                    pictureBox1.Image = hang6;
                    break;
            }

            if (count == 7)
            {
                win = false;
                gameOver = true;
            }

        }

        private void UpdateWord(char c)
        {


            if (!gameOver)
            {
                for (int i = 0; i < Game.solvedWord.Length; i++)
                {

                    if (Game.solvedWord[i] == c)
                    {
                        Game.word.Remove(i * 2, 2);
                        Game.word.Insert(i * 2, Game.solvedWord[i] + " ");
                    }

                }


                for (int i = 0; i < Game.solvedWord.Length; i++)
                {
                    if (Game.word.ToString()[2 * i] == Game.solvedWord[i])
                    {
                        win = true;
                        gameOver = true;
                    }
                    else
                    {
                        win = false;
                        gameOver = false;
                        break;
                    }
                }
            }

            if (c == '!')
            {
                Game.word.Clear();

                for (int i = 0; i < Game.solvedWord.Length; i++)
                {
                    Game.word.Append(Game.solvedWord[i] + " ");
                }
            }

            label1.Text = Game.word.ToString();
        }

        private void GameStatus_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }

    // Class for colors of Menu Strip

    public class TestColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.Transparent; }
        }

        public override Color MenuBorder  //added for changing the menu border
        {
            get { return Color.Black; }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return Color.Black;
            }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return Color.Black;
            }
        }


        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.Transparent; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.Transparent; }
        }
    }

    // Class to control game mechanics

    public class GameRules
    {
        enum Level { easy, medium, hard };
        public StringBuilder word = new StringBuilder();
        public string solvedWord;
        public int difficulty;


        public GameRules()
        {
            word.Append("_ _ _ _ _ _");
            solvedWord = "SUPERMAN";
            difficulty = (int)Level.easy;
        }

        public void NewGame()
        {
            // Create New Word
            using (var stream = Assembly
                                .GetExecutingAssembly()
                                .GetManifestResourceStream("HangMan.Resources.wordbank.csv"))
            using (var csv = new StreamReader(stream))
            {
                //string csv = reader.ReadToEnd();
                solvedWord = readCSV(csv).ToUpper();
            }
            
            word.Clear();

            for (int i = 0; i < solvedWord.Length; i++)
            {
                word.Append("_ ");                 
            }


        }

        public void SaveGame()
        {

        }

        public void LoadGame()
        {

        }

        private string readCSV(StreamReader csv)
        {
            
                string newWord = "";
                var reader = new CsvReader(csv);
                Random randNum = new Random();

                IEnumerable<WordBank> records = reader.GetRecords<WordBank>();
                foreach (WordBank record in records.Take(randNum.Next(4000) + 1))
                {
                    newWord = record.Word;
                }

                return newWord;
            

        }

    }


    public class UpdateBoard : MainWindow
    {


    }

    public class WordBank
    {
        public String Word { get; set; }
        public String Level { get; set; }
    }

}

