# TaskTracker
Winforms application for tracking your tasks on different projects/sections.

Sql server is used to store/load history of created tasks and time.
Tracker comes with an (optional) emailing function to notify the user of upcoming tasks which are near the specified deadline.
Can be minimized to system tray.

Demo section:
There is a demo window made to check out the application functionality without the need to set up a sql database.
In demo mode, the emailing functionality is also disabled.


Setting up:
In order to set up the TaskTracker for everyday use, there needs to be some general parameters specified.
1. You must have SQL Server Management Studio installed (https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)
2. Load the TaskTracker database tables by opening the file "ttrackerdb.sql".
3. Inside App.config you must specify the following:
   Line 9: value of SenderEmail (The email address that SENDS notifications)
   Line 13: value of connectionString. More info here (https://www.connectionstrings.com/sql-server/)
   Line 18: value of userName (The email address that SENDS notifications), password of the email address;

If you encounter any errors regarding email, try rechecking 3rd set up section and make sure you did every step correctly. Note: the email address that provides notifications should have "Less secure apps" option turned on in order for email notifications to work.
   



