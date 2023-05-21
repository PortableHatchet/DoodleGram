# Overview

DoodleGram is a social media web app that allows you to create simple doodles and post them. To run the app on your own computer to host the server, ensure you have .Net SDK and C# downloaded in VSCode/Rider(thats what I used. You may need other things for different IDE's). Then run the command 'dotnet run'. The program will build and then you can go to the LOCALHOST route provided in the terminal.

My main purpose for writing this software was to help me understand web applications better as well as Model View Controller (MVC) and its implementation in software. 

[DoodleGram](https://youtu.be/trneWMW9-uk)

# Web Pages

HomePage- This is where users will see their feed of doodles made by their friends (currently still in development as there is no feed.)

Profile- This page is where users can create new doodles as well as view their previous doodles made.

Sign Up- Create a new account with DoodleGram. Currently email and password is saved to a text file but will eventually be saved in a database. 

Login- Enter user credentials and then if entered correctly, be redirected back to the homepage.

# Development Environment

I used Jetbrains Rider For this project. The C# implementation for coding is very smooth with Rider. 

I used Microsofts ASP.Net Core MVC Framework for this project. html pages are technically written in cshtml and there is some JavaScript implementation for the doodle function when creating doodles. 
# Useful Websites

{Make a list of websites that you found helpful in this project}
* [Microsoft](https://learn.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-7.0)
* [YouTube(IAmTimCorey)](https://www.youtube.com/watch?v=1ck9LIBxO14)

# Future Work

* Users able to post their doodles
* Save data to a database 
* Better authentication system
* More colors and brushes to doodle-maker
