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
Deleting previous project

