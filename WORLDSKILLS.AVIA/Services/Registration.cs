namespace WORLDSKILLS.AVIA.Services;

using Models;

public class Registration
{
    public static IList<User> UserData = new List<User>();
    public static User NewUserData = new User();
    public string AdminLogin { get; set; } = "Admin";
    public string AdminPassword { get; set; } = "123";

    public void AddUser()
    {
        if (NewUserData.LoginUser != AdminLogin || NewUserData.PasswordUser != AdminPassword)
        {
            NewUserData.Roles = Roles.User;
        }
        else
        {
            NewUserData.Roles = Roles.Admin;
        }

        UserData.Add(NewUserData);
        NewUserData = new User();
    }
}