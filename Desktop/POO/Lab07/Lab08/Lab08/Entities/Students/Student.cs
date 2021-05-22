namespace Lab08.Entities.Students
{
    public class Student
    {
        public int Id { get; set; }
        
        public string CardId { get; set; }
        
        public string Name { get; set; }
        
        public string LastName { get; set; }
        
        public string Career { get; set; }

        public virtual string FullName => $"${Name} {LastName}";
    }
}