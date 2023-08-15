public enum UserRole {
    User,
    Admin
}

public class TheUser {
    public string Username {get; set;}
    public UserRole Role {get; set;}
    public string Password {get; set; }
}
