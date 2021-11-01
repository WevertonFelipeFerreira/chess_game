namespace board
{
    class Board
    {
        public int lines { get; set; }
        public int columns { get; set; }
        private Piece[,] pieces;

        public Board(int lines, int columns) 
        {
            this.columns = columns;
            this.lines = lines;
            pieces = new Piece[lines, columns];
        }
    }
}
