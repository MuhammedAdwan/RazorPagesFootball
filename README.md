# WEB315_Summer23_new_Assignment 4

Creating Chat application using a Hosted Blazor WebAssembly app


Deleted my assignment 3 branch and started new one


Created a new Blazor WebAssembly app using the following command -> dotnet new blazorwasm -ho -o BlazorWebAssemblySignalRApp


Added the following NuGet packages to the project -> Microsoft.AspNetCore.SignalR.Client

Added the following code to the Program.cs file to register the SignalR client service: -> dotnet add package Microsoft.AspNetCore.SignalR.Client --version 5.*

used dotnet watch and run to check the app

Wasnt working and i found out that i need to change my location to the server folder and run the server app.

** Committed to github

Created new page called ChatPage

makde the page accessible from the front page.

Added a link to the navigation side bar and moved the contents of the index page to the chat page, and added my name to the chat page.

**Committed to github

added the method to only send a message to a connected user.

Added UserTyping method to warn other users that a user is typing.

Added anonymous message feature so that users can send messages without having a username

**Committed to github

Setted the maximum number of username input to 63 characters.

Disabled the username and message input fields when the user is not connected to the server.

**Committed to github

Adding "User is typing" feature"