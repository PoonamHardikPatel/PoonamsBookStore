2022-10-28 10:55 am

- Created by : Poonam Hardik Patel
- Student Id : W0790805

- Built the initial default application - ASP .NET Core 3.1 MVC
- Prepended my name = 'PoonamsBookStore'
- Individual Accounnt Authentication
- Added Razor Runtime 

- Hit create and then reviewed the default app.


//----------------------------------------------------------------------------------------


2022-10-28 11:02 am

- Start the Part 1.1 - Review
- Create "README.txt" file and add all the information about project in it.
- Craete a GitHub repository and push all changes.

- Build the application.
- All Good...

- Open and Update the "Startup.cs" file.

- Commit All Changes to GitHub repository.
- Complete the Part 1.1 - Review


//----------------------------------------------------------------------------------------


- Start the Part 1.2 - Debugging
- Rebuild the application - All done
- Test the application - All good
- All tabs like "Home" & "Privacy" are woking good.
- Complete the Part 1.2 - Debugging


//----------------------------------------------------------------------------------------


2022-10-28 11:30 am

- Start the Part 1.3 - Bootstrap
- Go to "Bootstrap.com" 
- Select any theme
- Download the css of selected theme
- Replace that css file with existing file 
- Location : "wwwroot/lib/bootstrap/dist/css/bootstrap.css"

- Open the "Views/Shared/_Layout.cshtml" file
- Update the "bootstarp.css" link in the file - Line no. 7
- Change the nav class from "nav-light" to "nav-dark" and "bg-white" to "bg-primary" - Line no. 12
- Remove the class "text-dark" from - Line no. 23 & 26
- Update the class of footer and add additional classes in that is "text-white-50" and "bg-primary" - Line no. 39

- Open the "Views/Shared/_LoginPartial.cshtml" file
- Update the file and remove all classes named "text-dark"

- Rebuild the application - All done
- Test the apllication - All good

- Commit All Changes to GitHub repository.

- Open the "Views/Shared/_Layout.cshtml" file
- Add additional stylesheets to use - Line no. 11 to 14
- Add additional scripts - Line no. 55 t0 60


//----------------------------------------------------------------------------------------


2022-10-31 12:39 pm

- Rebuild the application - All done
- Test the application - All good

- Open the "Views/Shared/_Layout.cshtml" file
- Add "Dropdown" tab after "Privacy" tab - write dropdown code for dropdown menu
- Can't able to display dropdown menu at this stage. "Dropdown" showing nothing in it.

- So add the property, we must have to wite this "data-toggle" property in "li" tag for dropdown
- In this code, if we don't write "data-toggle" property in "li" tag, then we can'y see the dropdown menu 
- Now, change the "Dropdown" to "Content Management" - the value of "a" tag

- Commit All Changes to GitHub repository.
- Complete the Part 1.3 - Bootstrap


//----------------------------------------------------------------------------------------


2022-10-31 01:25 pm

- Start the Part 1.4 - Add Projects & Modify
- Add 3 new projects (.NET Core Class library) to that application : 
- through "right" click on solution file named - "Solution 'PoonamsBookStore'" > click on "Add" option > select "New Project" option
- select "C#" and "All" for other two dropdown 
	named -
	- PoonamsBooks.DataAccess
	- PoonamsBooks.Models
	- PoonamsBooks.Utility

- Move the "Data" folder from "PoonamsBookStore" to "PoonamsBooks.DataAccess"
- Delete the original "Data" folder from "PoonamsBookStore"

- Rebuild the application "PoonamsBooks.DataAccess" - All done
- Test the apllication - All good


//----------------------------------------------------------------------------------------


2022-11-03 12:34 am

- Install & check the NuGet packages with related version
	- "Microsoft.EntityFrameworkCore.Relational" 
	- "Microsoft.EntityFrameworkCore.SqlServer"

- Delete the "Migrations" folder from "PoonamsBooks.DataAccess/Data/Migrations"

- Open NuGet Package Manager and Install :
	- "Microsoft.AspNEtCore.Identity.EntityFrameworkCore"

- Open the "PoonamsBooks.DataAccess" file
- Modify the namespppace to reflect the project 
	- namespace PoonamsBookStore.DataAccess.Data
	
- Delete the Original "Class1.cs" files from all projects


//----------------------------------------------------------------------------------------


2022-11-03 07:51 pm

- Move the "Models" folder from "PoonamsBookStore" to "PoonamsBooks.Models"
- Delete the original "Models" folder from "PoonamsBookStore"

- Add Project References in "PoonamsBookStore" through :
	- Right click on main project > Add > Project References 
	- Select the check boxes for "PoonamsBooks.DataAccess" and "PoonamsBooks.Models"
	- Click on add/ok

- Rename the folder "Models" to "ViewModels" folder in "PoonamsBooks.Models"

- Open the "ErrorViewModel.cs" file from "PoonamsBooks.Models > ViewModels > ErrorViewModel.cs"
- Change the namespace and add cretaded "ViewModels" in the last of namespace 
- i.e. new namespace is : "namespace PoonamsBookStore.Models.ViewModels"

- Rebuild the application "PoonamsBooks.Models" - All done
- Test the apllication - All good

- Commit All Changes to GitHub repository.


//----------------------------------------------------------------------------------------


2022-11-03 08:35 pm

- Open and change the "Startup.cs" 
- Modify "Startup.cs" service "AddContext" with the using statement
- Remove the using statement form "startup.cs" file

- Open the "Error.cshtml" file
- Change the first line from "@model ErrorViewModel" to "@model PoonamsBookStore.Models.ViewModels.ErrorViewModel"

- Commit All Changes to GitHub repository with 46 errors.


2022-11-03 09:28 pm

- Tried solving the errors

- In the Utility project
- Create a static details class called "SD.cs" file in "PoonamsBooks.Utility"
- Modify the properties of the class 

- Add Project References in "PoonamsBookStore" through :
	- Right click on main project > Add > Project References 
	- Select the check box for "PoonamsBooks.Utility" 
	- Click on add/ok

- Add Project References in "PoonamsBooks.DataAccess" through :
	- Right click on "PoonamsBooks.DataAccess" > Add > Project References 
	- Select the check boxes for "PoonamsBooks.Models" and "PoonamsBooks.Utility"
	- Click on add/ok

- Add Areas in "PoonamsBooksStore > Areas" through :
	- Right click on "PoonamsBooksStore" > Areas > Add > Area 
	- Select the check boxes for "PoonamsBooks.Models" and "PoonamsBooks.Utility"
	- Click on add/ok


//----------------------------------------------------------------------------------------

2022-11-03 10:58 pm

- Facing errors of Duplication - So "Delete" the repository and project
- Again start with create new project from step 1


//----------------------------------------------------------------------------------------


2022-11-10 06:23 pm

- "Delete" the repository and project
- Solve error - In the first step by unchecking the "Save the project and solution file in the same directory" box.
- Again start with create new project from step 1


//----------------------------------------------------------------------------------------


- Started with the Utility class project as per the pptx.
- move the Homecontrollers.cs file to Area > View > home and delete the "Data" and "Models" folder...
- Save the content and run the application
- After running the web application update the git repo... 0608

- Add Area Admin in the Areas folder.
- Delete the "Data" and "Models" folder from it...
- View the content properly and delete the Controllers folder from the main project !!!
- Update the github repository and save the content...

- Commit All Changes to GitHub repository.
- Complete the Part 1.4 - Add Projects & Modify


//----------------------------------------------------------------------------------------


- END OF PART - 1


//----------------------------------------------------------------------------------------


2022-11-10 08:30 pm - START PART - 2

- Open Visual Studio Community 2019 
- Clone the repository of existing project from GitHub
- Continue with part 2 from pptx

- Start the Part 2.1 - Create the DB
- Build the project ..
- Rebuild the application - All done
- Test the apllication - All good

- Review appsettings.json file 
- Modify the database name and save it.
 
- Open the NuGet Package manager Console 
- Add the migration with the command : Add-Migration AddDefaultIdentityMigration
- Build succeeded but target project is not correct and show below error :
	- Output :
		-Build started...
		- Build succeeded.
		- Your target project 'PoonamsBookStore' doesn't match your migrations assembly 'PoonamsBooks.DataAccess'. Either change your target project or change your migrations assembly.
		- Change your migrations assembly by using DbContextOptionsBuilder. E.g. options.UseSqlServer(connection, b => b.MigrationsAssembly("PoonamsBookStore")). By default, the migrations assembly is the assembly containing the DbContext.
		- Change your target project to the migrations project by using the Package Manager Console's Default project drop-down list, or by executing "dotnet ef" from the directory containing the migrations project.
 
- Change to the correct default project : 
- Created migration file in "PoonamsBooks.DataAccess > Migrations" named : "20221111015106_AddDefaultIdentityMigration.cs"

- Review this new created migration file
- Update the ASP.NET Identity 

- Once all changes are done in migration file then 
- Open the NuGet Package manager Console
- Update the database with the command : Update-Database
- Build succeeded with target project :
	- Output :
		-Build started...
		- Build succeeded.
		- Done

- Review the updated database in the SQL Server Object Explorer from "View" menu through menu bar 
- Open "SQL Server Object Explorer > (localdb)... > Database > PoonamsBookStore > Tables"

- Build the project ..
- Rebuild the application - All done
- Test the apllication - All good

- Add a new table to the DB by creating a Category model and push it to the DB :
- Add new class file in "PoonamsBooks.Models" through
	- Right click on "PoonamsBooks.Models > Add > Class" 
	- named : "Category.cs"

- Open the NuGet Package manager Console 
- Add the migration with the command : Add-Migration AddCategoryToDb
- Build succeeded :
	- Output :
		-Build started...
		- Build succeeded.

- Modify the code in "Category.cs" file.
- Add properties in cs file "Id & Name"

- Update the "ApplicationDbContext.cs" file 
- Add "using PoonamsBooks.Models;" namespace
- And add getter and setter for "Category"

- Re-run the "Add-Migration AddCategoryToDb" command in NuGet Package manager console
- Then run the "Update-Database" command in Package console
- Build succeeded :
	- Output :
		-Build started...
		- Build succeeded.

- Build the project ..
- Rebuild the application - All done
- Test the apllication - All good

- Commit All Changes to GitHub repository.

- End time : 10:09 pm


//----------------------------------------------------------------------------------------


2022-11-11 5:15 pm 

- Open Visual Studio Community 2019 
- Clone the repository of existing project from GitHub

- But "Categories" table is not showing in SQL Server Database
- So trying again with the migration and update steps for Category.

- Delete the "AddCategoryToDb.cs" fiel form the Migration folder and try again.
- Re-run the "Add-Migration AddCategoryToDb" command 
- And then run again "Update-Database"

- After this step - now it's showing "Categories" table in the SQL Server Object Explorer tables.

- Build the project ..
- Rebuild the application - All done
- Test the apllication - All good

- Commit All Changes to GitHub repository.
- Complete the Part 2.1 - Create the DB


//----------------------------------------------------------------------------------------


2022-11-12 12:50 pm

- Open Visual Studio Community 2019 
- Clone the repository of existing project from GitHub
- Continue with part 2 from pptx

- Start the Part 2.2 - Repository
- Build the project ..
- Rebuild the application - All done
- Test the apllication - All good

- After creating the "Categoy.cs" and adding it to the ApplicationDBContext.
- Now it's time to implement the "Repository",
	a generic way of accessing common functionality (e.g. getting a record), in the .DataAccess project.

- Add a new folder name it "Repository" (for class implementations of interfaces) in PoonamsBooks.DataAccess project
- And add an "IRepository" (for the interfaces) folder inside the "Repository" folder

- Add a new item of type interface to the folder and name it "IRepository.cs"
- Open the file "IRepository.cs" and update the code as per the pptx.
- Add using statements..
- Modify this file, so it can be used on the Category class to do all the CRUD operations.
- Methods to use for CRUD : 
	- Get item from the DB
	- List of Categories
	- Add objects
	- Remove objects

- Implement the class that implements the repository.
- Add new class file named "Repository.cs" in "PoonamsBooks.DataAccess > Repository" path
	- through right click on "Repository" folder, choose the options : "Add > Class"
- Open and update this newly created file "Repository.cs" as pe rthe pptx

- Save all changes till this point.
- Commit All Changes to GitHub repository.

