using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TicTacToe
{
    /* this is struct for the available moves to Ai
     * having the row (x) and the colum (y) of the move in the board 
     * and the move score (10 , -10 , 0 ) 
     */          
    struct AiMove 
    {
        public void SetScore(int score)
        {
            this.score = score;
        }
        public int x;
        public int y;
        public int score;  
    }
    class Ai
    {
        private const int NO_VALUE = 0;
        private const int X_VALUE = 1;
        private const int O_VALUE = 2;
        private const int TIE = -1;
        private const int X_WIN = 1;
        private const int O_WIN = 2;
        private const int NO_WIN = 4;

        // make the comp plays with O and the player with X 
        public void init(int aiplayer)
        {
            _aiplayer = aiplayer;
            _humanplayer = X_VALUE;
        }
        // after we get the best move (button) we return this button to perform click
        public Button performMove(int[,]board)
        {
            AiMove bestMove = getBestMove(board, _aiplayer);
            board[bestMove.x, bestMove.y] = _aiplayer;
            Button bt = new Button() ;
            bt.Text = "O";
            bt.Name = "b" + bestMove.x.ToString() + bestMove.y.ToString();
            return bt;
        }
        // apply minimax algorithm
        private AiMove getBestMove(int[,] board, int player)
        {
            // base case --> check for end state (win,lose,draw)
            int result = iswinner(board);
            
            if(result == _aiplayer)
            {
                AiMove temp = new AiMove();
                temp.SetScore(10);
                return temp ;
            }
            else if(result == _humanplayer)
            {
                AiMove temp = new AiMove();
                temp.SetScore(-10);
                return temp;
            }
            else if(result == TIE)
            {
                AiMove temp = new AiMove();
                temp.SetScore(0);
                return temp;
            }

            List <AiMove> moves = new List<AiMove>(); 
            // Do the recursive function calls and construct the moves list (all availabe moves)
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (board[i, j] == NO_VALUE)
                    {
                        AiMove move = new AiMove();
                        move.x = i;
                        move.y = j;
                        board[i, j] = player;
                        if(player == _aiplayer)
                        {
                            move.score = getBestMove(board, _humanplayer).score;
                        }
                        else
                        {
                            move.score = getBestMove(board, _aiplayer).score;
                        }
                        moves.Add(move);
                        board[i, j] = NO_VALUE; 
                    }
                }
            }
            // get the best move for the current player 
            int bestMove = 0;
            if(player == _aiplayer)
            {
                int bestScore = -100000;
                for(int i = 0; i < moves.Count; i++)
                {
                    if(moves[i].score > bestScore)
                    {
                        bestScore = moves[i].score;
                        bestMove = i;                       
                    }
                }
            }
            else
            {
                int bestScore = 100000;
                for (int i = 0; i < moves.Count; i++)
                {
                    if (moves[i].score < bestScore)
                    {
                        bestScore = moves[i].score;
                        bestMove = i;
                    }
                }
            }
            // return the best move 
            return moves[bestMove];
        }
        // check for end state 
        private int iswinner(int[,] board)
        {
            // horizontal checks 
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 2] == X_VALUE)
                {
                    return X_WIN;
                }
                else if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 2] == O_VALUE)
                {
                    return O_WIN;
                }
            }
            // vertical checks 
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == board[1, j] && board[1, j] == board[2, j] && board[2, j] == X_VALUE)
                {
                    return X_WIN;
                }
                else if (board[0, j] == board[1, j] && board[1, j] == board[2, j] && board[2, j] == O_VALUE)
                {
                    return O_WIN;
                }
            }
            // diagonal checks 
            if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
            {
                
                if (board[0, 0] == X_VALUE)
                    return X_WIN;
                else if (board[0, 0] == O_VALUE)
                    return O_WIN;            
            }
            if (board[2, 0] == board[1, 1] && board[2, 0] == board[0, 2])
            {
                if (board[2, 0] == X_VALUE)
                    return X_WIN;
                else if (board[2, 0] == O_VALUE)
                    return O_WIN;
            }
            // draw check
            int nButtons = 0;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (board[i, j] != NO_VALUE)
                        nButtons++;
                }
            }
            if(nButtons == 9)
            {
                return TIE;
            }
            return NO_WIN;
        }
        private int _aiplayer;
        private int _humanplayer;
    }
}
