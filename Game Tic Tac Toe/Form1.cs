using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private ChessBoardManager chessBoard;

        public Form1()
        {
            InitializeComponent();

            chessBoard = new ChessBoardManager(pnlChessBoard);
            chessBoard.DrawChessBoard();
        }
    }
}
