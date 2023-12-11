namespace examtask.MVC.Models
{
    public class Profession:BaseEntity
    {
        public string FullName { get; set; }
        public int Teamid { get; set; }
        public Team? Team { get; set; }
        

    }
}
