namespace _02.CoursePlanning
{
    public class Course
    {
        public Course(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public string Exercise { get; set; }

        public void AddExercise()
        {
            this.Exercise = $"{this.Name}-Exercise";
        }
    }
}
