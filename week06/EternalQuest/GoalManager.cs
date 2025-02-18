using System; 
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class GoalManager
{
    private User _user;
    private string _filePath = "user_goals.json";
    private DataManager _dataManager;

    public GoalManager(User user)
    {
        _user = user;
        
    }

    public void Start()
    {
        Console.WriteLine($"Welcome, {_user._username} to your Eternal Quest Goal Manager" );
    }

    public void EnterUsernameAndPassword()
    {
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();

        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        _user = _dataManager.AuthenticateUser(username, password);

        if (_user != null)
        {
            Console.WriteLine($"Hello, {_user._username}. You have successfully logged in.");
            LoadGoals();
        }
        else
        {
            Console.WriteLine("Authentication failed. Please check your username or password.");
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"User: {_user._username}");
        Console.WriteLine($"Score: {_user._score}");
    }

    public void ListGoals()
    {
        int number = 1;
        Console.WriteLine("Your goals are: ");
        foreach (Goal item in _user._goals)
        {
            Console.WriteLine($"{number}.- {item.GetStringRepresentation()}");
            number += 1;
        }
    }

    public void ListName()
    {
        int number = 1;
        Console.WriteLine("Your goals are: ");
        foreach (Goal item in _user._goals)
        {
            Console.WriteLine($"{number}.- {item.GetName()}");
            number += 1;
        }
    }
    public void CreateGoal(Goal newGoal)
    {
        _user._goals.Add(newGoal);
        Console.WriteLine("Your goal was created");
    }
    public void RecordEvent(int index)
    {
        
        if (index < 0 || index >= _user._goals.Count)
        {
            Console.WriteLine("Invalid goal selection. Please try again.");
            return;
        }
        Goal goal = _user._goals[index];
        goal.RecordEvent();
        _user._score += goal.Points;
        SaveGoals();


    }
    public void SaveGoals()
    {
        string json = JsonConvert.SerializeObject(_user._goals, Formatting.Indented);
        File.WriteAllText(_filePath, json);
    }

    public void LoadGoals()
    {
        if (!File.Exists(_filePath))
    {
        _user._goals = new List<Goal>(); 
        return;
    }

    string json = File.ReadAllText(_filePath);
    _user._goals = JsonConvert.DeserializeObject<List<Goal>>(json);
    }
    

}