using Microsoft.AspNetCore.Mvc;
using WORLDSKILLS.AVIA.Models;

namespace WORLDSKILLS.AVIA.Services;

using Models;
using Services;

public class Entrance
{
    public IList<Credentials> Data = new List<Credentials>();
    public static Credentials NewData = new Credentials();
    public string d { get; set; }


    public void Checking()
    {
        var itemLogin = Registration.UserData.FirstOrDefault(x => x.LoginUser == NewData.Login);
        var itemPass = Registration.UserData.FirstOrDefault(o => o.PasswordUser == NewData.Password);
        if (Registration.UserData.Contains(itemLogin) && Registration.UserData.Contains(itemPass))
        {
            d = "Вы вошли";
        }
        else
        {
            d = "Неправильный логин или пароль";
        }

        if (NewData.Login == "Admin" && NewData.Password == "123")
        {
            d = "Вы вошли как администратор";
        }

        Data.Add(NewData);
        NewData = new Credentials();
    }
}