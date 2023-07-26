using System;
using System.Linq;

public class User
{
    public string Username
    {
        get { return username; }
        set
        {
            if (value.Length > 6)
            {
                username = value;
            }
            else
            {
                throw new ArgumentException("Username must be greater than 6 in length");
            }
        }
    }


    public string Password
    {
        get { return password; }
        set
        {
            if (value.Any(char.IsDigit) && value.Any(char.IsUpper))
            {
                password = value;
            }
            else
            {
                throw new ArgumentException("Password must contain at least 1 number and at least 1 uppercase letter");
            }
        }
    }


    private string username;
    private string password;


    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }
}
