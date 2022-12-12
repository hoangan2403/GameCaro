using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_GAME_1
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoard Chess;
        #endregion
        public Form1()
        {
            InitializeComponent();
            Chess = new ChessBoard(banco, NamePlayer, PicPlayer);
            Chess.DrawChessBoard2();
            
            
            
        }
        

        private void testgame_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void avata_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Chess.A == 1)
            {
                Chess.NewGame();
            }
            else
            {
                Chess.NewGame2();
            }
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void banco_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hAINGƯỜICHƠIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chess.DrawChessBoard();
            int a = 1;
        }

        private void cHƠIVỚIMAYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chess.DrawChessBoard2();
            int a = 2;
        }

        private void tHOATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
