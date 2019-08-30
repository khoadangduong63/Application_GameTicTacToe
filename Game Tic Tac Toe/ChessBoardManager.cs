using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Tic_Tac_Toe
{
    public class ChessBoardManager
    {
        private Panel chessBoard;

        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }

        public ChessBoardManager(Panel chessBoard)
        {
            this.ChessBoard = chessBoard;
        }

        public void DrawChessBoard()
        {
            Button prevButton = new Button()
            {
                Width = 0,
                Location = new Point(0, 0)
            };

            for (int row = 0; row < ConstantVariables.CHESS_BOARD_ROW; row++)
            {
                for (int col = 0; col < ConstantVariables.CHESS_BOARD_COLUMN; col++)
                {
                    Button nowButton = new Button()
                    {
                        Width = ConstantVariables.CHESS_BOX_WIDTH,
                        Height = ConstantVariables.CHESS_BOX_HEIGHT,
                        Location = new Point(prevButton.Location.X + prevButton.Width, prevButton.Location.Y)
                    };


                    chessBoard.Controls.Add(nowButton);
                    prevButton = nowButton;
                }
                prevButton.Location = new Point(0, prevButton.Location.Y + ConstantVariables.CHESS_BOX_HEIGHT);
                prevButton.Width = 0;
                prevButton.Height = 0;
            }
        }
    }
}
