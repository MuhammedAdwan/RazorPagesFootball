# RazorPagesFootball
 
# WEB315_Summer23_new
 recreated the repository in github as dotnet 5 is not supported on my laptop
 readded Dr. Majid as a collaborator
 created gitIgnore folder containing obj and bin folders
 modified the welcome page as requested in step 6
 added the date annotation
 installed the EF tools as requested in Week 3 
 Scaffolded the football model
 

dotnet-aspnet-codegenerator razorpage -m Football -dc RazorPagesFootballContext -udl -outDir Pages/FootBall --referenceScriptLibraries -sqlite



dotnet ef migrations add BestPlayerShirtNumber
dotnet ef migrations add CoachCountry

dotnet ef database BestPlayerShirtNumber
dotnet ef database BestPlayerShirtNumber

************Assignment 3************

dotnet new blazorserver -o Football -f net5.0

Deleting previous project
Creating my index home page
updating the counter page
creating a new component page
added the link to the side navigation
added empty string
addded the button
displaying the string
