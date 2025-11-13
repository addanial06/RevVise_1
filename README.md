# RevVise
RevVise is a lightweight desktop application designed to help users and administrators manage vehicle repair records effectively. It provides a simple system for users to track, sort, and update vehicle cases while keeping logs for accountability. This app aims to streamline vehicle maintenance tracking for individual users and administrators, providing an efficient tool for everyday use.

### Key Functions:
#### Vehicle Catalog Management:
  - Add, update, delete vehicle entries with details like Vehicle Model, Owner, Plate Number, Status, and Repair Dates.
#### Search and Sort:
  - Filter vehicle entries by ID, Model, Owner, Plate Number, or Status
#### Dashboard:
  - Visualize recent activities, vehicle repairs, and total vehicle entries, and a pie chart comparing resolved repairs to unresolved.
#### User Logs:
  - Maintains an action log per user, detailing changes, actions and timestamps for tracking.
#### User-Specific Notes:
  - Each user can keep a personal note that persist across sessions.
#### Settings & Administration:
  - A user can choose to reset/clear vehicle database, change password, and delete user account if needed.
  - Admin users have additional privileges to clear, export records, change user data while monitoring user statistics.









# Installations
- Install Visual Studio
- Install XAMPP on C:\ :
  https://www.apachefriends.org/download.html   

## How to create database **(IMPORTANT)**
You have to **create the database** before running the program as most of the program code implements connection with the database. Running the program without the database won't ensure that the program will run without any errors.
1. Open XAMPP control panel.
3. Start both **Apache** and **MySQL** modules.
4. Click MySQL **Admin button** to get redirected to phpMyAdmin website
5. Import db by creating a new database with the name "db_revapp", then importing the .sql file included in the project repository.
- Example of working database:
<img width="661" height="428" alt="image" src="https://github.com/user-attachments/assets/4922cfaf-88f4-4543-b28d-b98368b779b6" />
<img width="1917" height="944" alt="image" src="https://github.com/user-attachments/assets/2acb705c-0233-41d1-8686-1ca04634e296" />


## Running The Application
Before running/starting the program, **ensure the database exists** and the required XAMPP modules are running.
### If you want to run via the standalone file
1. Download and export the release zip file.
2. Run the program.

### If you want to run via Visual Studio
1. Open Visual Studio
2. Open the .sln of the repository
3. Build and run the program.
