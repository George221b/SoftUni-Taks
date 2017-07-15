namespace _09.RectangleIntersection
{
    public class Rectangle
    {
        private string id;
        private int width;
        private int height;
        private int topLeftHorizontal;
        private int topLeftVertical;

        public Rectangle(string id, int width, int height, int horizontal, int vertical)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.topLeftHorizontal = horizontal;
            this.topLeftVertical = vertical;
        }

        public string Id { get { return this.id; } }

        public bool IsIntersect(Rectangle rect)
        {
            return rect.topLeftHorizontal + rect.width >= this.topLeftHorizontal &&
                   rect.topLeftHorizontal <= this.topLeftHorizontal + this.width &&
                   rect.topLeftVertical >= this.topLeftVertical - this.height &&
                   rect.topLeftVertical - rect.height <= this.topLeftVertical;
        }
    }
}
