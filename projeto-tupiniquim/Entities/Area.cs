namespace projeto_tupiniquim.Entities
{
    internal struct Area
    {
        public int MinX { get; set; }
        public int MinY { get; set; }
        public int MaxX { get; set; }
        public int MaxY { get; set; }

        public Area(int x, int y)
        {
            MinX = 0;
            MinY = 0;
            MaxX = x;
            MaxY = y;
        }
    }
}