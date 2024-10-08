namespace MainApp.Models;
//one to one
// public class User
// {
//     public int Id { get; set; }
//     public string Name { get; set; } = null!;
//     public Profile Profile { get; set; } = null!;
// }

//
// public class Profile
// {
//     public int Id { get; set; }
//     public string Bio { get; set; } = null!;
//     public int UserId { get; set; }
//     public User User { get; set; } = null!;
// }


// one to many
// public class Author
// {
//     public int Id { get; set; }
//     public string Name { get; set; } = null!;
//     public ICollection<Book> Book { get; set; } = [];
// }
//
// public class Book
// {
//     public int Id { get; set; }
//     public string Title { get; set; } = null!;
//     public int AuthorId { get; set; }
//     public Author Author { get; set; } = null!;
// }



// many to many
public class Mentor
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public ICollection<MentorGroup> MentorGroups { get; set; } = null!;
}

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public ICollection<MentorGroup> MentorGroups { get; set; } = null!;
}

public class MentorGroup
{
    public int Id { get; set; }
    public int MentorId { get; set; }
    public Mentor Mentor { get; set; } = null!;
    public int GroupId { get; set; }
    public Group Group { get; set; } = null!;
}