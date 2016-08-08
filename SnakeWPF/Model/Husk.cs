using System.Windows;

namespace SnakeWPF.Model
{
    public enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }

    public class Husk
    {
        public Direction Direction;
        public Point Point;

        public Husk(Direction direction, Point point)
        {
            Direction = direction;
            Point = point;
        }
    }
}
