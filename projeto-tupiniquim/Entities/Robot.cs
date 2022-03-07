namespace projeto_tupiniquim.Entities
{
    internal class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Compass { get; set; }

        public Robot(int x, int y, char compass)
        {
            X = x;
            Y = y;
            Compass = compass;
        }

        public void MoveToLeft()
        {
            switch (Compass)
            {
                case 'N':
                    Compass = 'O';
                    break;

                case 'S':
                    Compass = 'L';
                    break;

                case 'L':
                    Compass = 'N';
                    break;

                case 'O':
                    Compass = 'S';
                    break;
            }
        }

        public void MoveToRight()
        {
            switch (Compass)
            {
                case 'N':
                    Compass = 'L';
                    break;

                case 'S':
                    Compass = 'O';
                    break;

                case 'L':
                    Compass = 'S';
                    break;

                case 'O':
                    Compass = 'N';
                    break;
            }
        }

        public void MoveForward()
        {
            switch (Compass)
            {
                case 'N':
                    Y++;
                    break;

                case 'S':
                    Y--;
                    break;

                case 'L':
                    X++;
                    break;

                case 'O':
                    X--;
                    break;
            }
        }

        public override string ToString() => $"{X} {Y} {Compass}";
    }
}