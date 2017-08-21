namespace _12.Threeuple
{
    public class Threeuple<T, K, Z>
    {
        private T item1;
        private K item2;
        private Z item3;

        public Threeuple()
        {
        }

        public Threeuple(T item1, K item2, Z item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }

        public T Item1
        {
            get { return this.item1; }
            set { this.item1 = value; }
        }
        public K Item2
        {
            get { return this.item2; }
            set { this.item2 = value; }
        }
        public Z Item3
        {
            get { return this.item3; }
            set { this.item3 = value; }
        }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2} -> {this.Item3}";
        }
    }
}
