# TaskTracker
Winforms application for tracking your tasks on different projects/sections.



![select](https://github.com/jusadocode/TaskTracker/assets/77744027/26f63e7f-d5ba-452d-af67-f0f1f9beac41)



Sql server is used to store/load history of created tasks and time.

![task](https://github.com/jusadocode/TaskTracker/assets/77744027/fb827d35-53ff-49c6-8f03-63a944c025d9)

Tracker comes with an (optional) emailing function to notify the user of upcoming tasks which are near the specified deadline.





Can be minimized to system tray.

   ![background](https://github.com/jusadocode/TaskTracker/assets/77744027/48707717-f867-4002-81f1-3f1fe9ca8872)

   


## Demo section
There is a demo window made to check out the application functionality without the need to set up a sql database.
<b>In demo mode, the emailing functionality is disabled.</b>

![start](https://github.com/jusadocode/TaskTracker/assets/77744027/73eb451e-0c6e-4366-b0e4-098681caa354)





## Setting up
In order to set up the TaskTracker for everyday use, there needs to be some general parameters specified:
1. You must have SQL Server Management Studio installed (https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)
2. Load the TaskTracker database tables by opening the file "ttrackerdb.sql" and executing the database creation commands.
3. Inside App.config you must specify the following:
   - <b>Line 9</b>: value of SenderEmail (The email address that <b>sends</b> notifications)
   - <b>Line 13</b>: value of connectionString. More info here (https://www.connectionstrings.com/sql-server/)
   - <b>Line 18</b>: value of userName (The email address that <b>sends</b> notifications), password of the email address.

   
   
Note: the email address that provides notifications should have "Less secure apps" option turned on in order for email notifications to work.

<b>If you encounter any errors regarding email</b>, try rechecking 3rd set up section and make sure you did every step correctly. 



### Properly set up software should look like this:
   
![main](https://github.com/jusadocode/TaskTracker/assets/77744027/9bd12093-cd6f-4a90-bc27-3b01c79ec907)



### Settings window:



![settings](https://github.com/jusadocode/TaskTracker/assets/77744027/08e72aa3-2b85-44c4-a34d-db8565d1b0d5)




