using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

public class User
{
    public string _username;
    public string _password;

    public List<Goal> _goals;
    public int _score;

    public User(string username, string password)
    {
        _username = username;
        _password = password;
        _goals = new List<Goal>();
        _score = 0;
    }

    
}