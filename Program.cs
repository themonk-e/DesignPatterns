﻿// See https://aka.ms/new-console-template for more information
using designPattern.Builder;
using designPattern.Factory;
using designPatterns;
using designPatterns.problem;

Console.WriteLine("Hello, World!");

//EagerLoading
// Singleton obj1 = Singleton.getInstance();
// Singleton obj2 = Singleton.getInstance();


// //lazy loading

// SingletonLazy lzSingleton = SingletonLazy.INSTANCE;
// SingletonLazy lzSingleton2 = SingletonLazy.INSTANCE;

// Console.WriteLine(lzSingleton.incrementCount());
// Console.WriteLine(lzSingleton2.incrementCount());

// Logger service1 = Logger.getInstance();
// Logger service2 = Logger.getInstance();

// service1.AddToLog("Instance created for the firstTime");
// var listOfLogs=service2.AddToLog("Already created instance has been returned");

// foreach (string log in listOfLogs)
// {
//     Console.WriteLine(log);
// }


// //Factory

// var factory = new NotificationFactory();

// INotificationService email = factory.CreateNotification(Channel.email);
// email.SendNotification("Welcome to the system!");

// INotificationService sms = factory.CreateNotification(Channel.sms);
// sms.SendNotification("Your OTP is 123456");



//Builder

User userObj = new User.UserBuilder("John", "Doe")
.WithEmail("johndoe@gmail.com")
.WithPhone("9199199991").Build();

Console.WriteLine(userObj.FirstName);
Console.WriteLine(userObj.LastName);
Console.WriteLine(userObj.Email);
Console.WriteLine(userObj.Phone);