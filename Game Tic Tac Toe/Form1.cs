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
        public Form1()
        {
            InitializeComponent();
            DrawChessBoard();
        }

        void DrawChessBoard()
        {
            Button prevButton = new Button()
            {
                Width = 0,
                Location = new Point(0, 0)
            };

            for (int row = 0; row < 15; row++)
            {
                for (int col = 0; col < 20; col++)
                {
                    Button nowButton = new Button()
                    {
                        Width = ConstantVariables.CHESS_BOX_WIDTH,
                        Height = ConstantVariables.CHESS_BOX_HEIGHT,
                        Location = new Point(prevButton.Location.X + prevButton.Width, prevButton.Location.Y)
                    };


                    pnlChessBoard.Controls.Add(nowButton);
                    prevButton = nowButton;
                }
                prevButton.Location = new Point(0, prevButton.Location.Y + ConstantVariables.CHESS_BOX_HEIGHT);
                prevButton.Width = 0;
                prevButton.Height = 0;
            }
        }
    }
}
