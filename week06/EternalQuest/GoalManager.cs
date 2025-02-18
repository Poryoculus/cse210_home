using System; 
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class GoalManager
{
    private User _user;
    private DataManager _dataManager;

    public GoalManager(User user)
    {
        _user = user  ;
        _dataManager = new DataManager();
    }

    public void Start()
    {
        Console.WriteLine($"Welcome, {_user._username} to your Eternal Quest Goal Manager" );
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
        _dataManager.AddOrUpdateUser(_user);
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
        _dataManager.AddOrUpdateUser(_user);
    }

}