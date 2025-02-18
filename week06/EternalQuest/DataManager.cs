using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json; // Install with: Install-Package Newtonsoft.Json

public class DataManager
{
    private string _filePath = "users_data.json";

    // Save user data to JSON
    public void SaveUsers(List<User> users)
    {
        string json = JsonConvert.SerializeObject(users, Formatting.Indented);
        File.WriteAllText(_filePath, json);
    }

    // Load user data from JSON
    public List<User> LoadUsers()
    {
        if (!File.Exists(_filePath))
        {
            return new List<User>();
        }

        string json = File.ReadAllText(_filePath);
        var users =JsonConvert.DeserializeObject<List<User>>(json);

        return users ?? new List<User>(); 
    }

     public User AuthenticateUser(string username, string password)
    {
        List<User> users = LoadUsers();

        var user = users.Find(u => u._username == username && u._password == password);
        return user;
    }


    public void AddOrUpdateUser(User user)
    {
        List<User> users = LoadUsers();

        var existingUser = users.Find(u => u._username == user._username);
        if (existingUser != null)
        {
            existingUser._password = user._password;
            existingUser._score = user._score;
            existingUser._goals = user._goals; 
        }
        else
        {
            users.Add(user);
        }

        SaveUsers(users);
    }
}