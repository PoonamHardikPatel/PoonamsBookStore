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

- Save all changes till this point.
- Commit All Changes to GitHub repository.

- Open and update this newly created file "Repository.cs" as pe rthe pptx
- Include the using statement in the top of the file "using PoonamsBooks.DataAccess.Repository.IRepository;"
- View the potential fixes and "implement interface"
- Update the class defination and do all step and code
- Modify the code to create the constructors and dependency injection (DI)
- Replace the given code from the folder "Assignment 2 Files > Repository.cs" with our "Repository.cs" file
- Change the class defination and using statements : from "Andrews" to "Poonams".

- Save all changes till this point.
- Commit All Changes to GitHub repository.


//----------------------------------------------------------------------------------------


2022-11-12 2:50 pm

- Create individual repos for Category and all potential models to be added in the future 
	- CategoryRepository.cs
	- ICategoryRepository.cs
- Create the file in "Repository" folder named "CategoryRepository.cs"
- Also create the file in "IRepository" folder named "ICategoryRepository.cs"

- Modify "CategoryRepository.cs" 
	- note the using statements and the message for formal parameters
	- review in "Repository.cs" the method pointing to the ApplicationDbContext
- Modify "ICategoryRepository.cs" interface
- Review and modify the error now in "CategoryRepository.cs" 
	- Implement the interface to update 

- Go back to "CategoryRepository.cs" file 
- Rectify the error line - select the dropdown option on "ICategoryRepository"
- Through this step - automatic generate the "Update" method
- Complete the remaining modifications and write the comments

- After completing step till here ...
- I got one error in "FirstOrDefault" in "CategoryRepository.cs" file
	- Because I forgot to add one using statement "using System.Linq;"
	- After adding this using statement, error is recify.

- Build the project ..
- Rebuild the application - All done
- Test the apllication - All good

- Save all changes till this point.
- Commit All Changes to GitHub repository.


//----------------------------------------------------------------------------------------


2022-11-12 5:24 pm

- Implement a stored procedure repository and map multiple repositories in a Unit of Work 
- Add a new interface in the folder "IRepository" named "ISP_Call.cs" - that extends "IDisposable"
- Include the methods shown (note the comments) and install the NuGet package for "Dapper"
- Alter + Enter on "DynamicParameters" in "ISP_Call.cs" file 
	- Select last option "Install package 'Dapper'"
	- Select first option "Find and install latest version" for using statement "using Dapper;"

- Now implement this with a new class in the "Repository" folder.

- Add a new class "SP_Call.cs" in the "Repository" folder 
- Select the appropriate using statement and implement the "ISP_Call" interface

- Alter + Enter on implemented "ISP_Call" 
	- Select first option and it's generate bydefault code for that file 
	- Implements interface 

- Add a connection to the database and using statements 
- Update the implementation of the "ISP_Call.cs" interface

- Open the file "SP_Call.cs" and update/changes all the code as per pptx

- Now add the wrapper for Unit of Work
- Add a new interface "IUnitOfWork.cs" to the folder "IRepository" and update the code.

- Now implement a new interface inside the folder "Repository" named "UnitOfWork.cs" and update the code.
- Modify the code (make sure the public class implements the interface - UnitOfWork : IUnitOfWork)
- Open the file "UnitOfWork.cs" and update the code and include using statements.

- To make it accessible by the project, register it in "Startup.cs" file in the "ConfigureServices()" method 
	(don't forget the using statement)

- Build the project ..
- Rebuild the application - All done
- Test the apllication - All good

- Save all changes till this point.
- Commit All Changes to GitHub repository.
- Complete the Part 2.2 - Repository

- End time : 8:48 pm


//----------------------------------------------------------------------------------------


- Take a break for dinner ...........


//----------------------------------------------------------------------------------------


2022-11-12 11:30 pm

- Open Visual Studio Community 2019 
- Clone the repository of existing project from GitHub
- Continue with part 2 from pptx

- Start the Part 2.3 - Category CRUD
- Build the project ..
- Rebuild the application - All done
- Test the apllication - All good

- With the addition of UnitOfWork in Startup.cs, it will be accessible with DI by any Controller.

- Close all currently opened tabs.

- Add a new MVC Controller - Emplty inside "Areas > Admin > Controller"
- Named it "CategoryController.cs"
- Modify the code and include using statements in Controller file.

- Open the file "CategoryController.cs" and update the code as per pptx.
- Add "region" code in that file.

- Add a new folder in the folder "Areas > Admin > View" named "Category".
- Add a new "Index" view to the folder (note the template)
- And modify with the generic HTML code from the "Category Index View.txt" found in the "Assignment 2 Files".

- Save all changes till this point.

- Build the project ..
- Rebuild the application - All done
- Test the apllication - All good

- Open the file "_Layout.cshtml" and add the "Category" tab in the "Content MAnagement" dropdown.
- Make sure that code is working or not with that link.

- Review the changes to the navigation.
- Test the application - All good

- Save all changes till this point.
- Commit All Changes to GitHub repository.


//----------------------------------------------------------------------------------------


2022-11-13 12:23 am

- Open and Modify the "Index.cshtml" file to add the icons in the Category section from "Font Awesome"
- And then "Confirm"

- Delete it and add the JAvaScript file from the "Assignment 2 Files" folder in to the folder "wwwroot > js" named "category.js"
- Update the file "Index.cshtml" - add the @section call to the "category.js" script

- Test the application - All good

- Now it's time to apply the code to activate the "Edit" and "Delete" buttons 
- and "Create New Category" using "Upsert" action

- Add "IActionResult" for "Upsert" in controller and add "View" for that from controller action
- Copy and add the html from the "Category Upsert View.txt" from "Assignment 2 Files" 

- Create a "partial view" for the "Create | BACK" named "_CreateAndBackToListButton.cshtml"
- Through - right click on the folder "general Views > Shared > Add > View" 
- Change the name as per given name and select the check box for partial view 
- Update the code in "_CreateAndBackToListButton.cshtml" file

- Save all changes till this point.
- Commit All Changes to GitHub repository.

- Create a "partial view" for the "EDIT | BACK" named "_EditAndBackToListButton.cshtml"
- Through - right click on the folder "general Views > Shared > Add > View" 
- Change the name as per given name and select the check box for partial view 
- Update the code in "_EditAndBackToListButton.cshtml" file

- Open and Update the file "Upsert.cs" as per the given "Assignment 2 Files".
- Add the "asp-action" to the "Index.cshtml" page.

- Navigate to Category > Create New Category
- Modify "Upsert.cshtml" - so TITLE now uses the "@title" variable.
- Add the "@section" call to "Scripts" to validate input (or lack of) on the client-side.

- Now it's time to create an "Upsert POST" action method in "CategoryController.cs" file.
- Save method is not available, now add the "void Save()" method to the "IUnitOfWork.cs" interface.
- Update all changes as per pptx in "CategoryRepository.cs".
- Remove the "_db.SaveChanges()" method in the "CategoryRepository.cs"
- And Move the "_unitOfWork.Save()" method with the return "RedirectToAction" method.

- Save all changes till this point.

- Build the project ..
- Rebuild the application - All done
- Test the apllication - All good

- Commit All Changes to GitHub repository.

- End time : 3:45 am


//----------------------------------------------------------------------------------------


2022-11-13 8:46 am 

- Good Morning........

- Open Visual Studio Community 2019 
- Clone the repository of existing project from GitHub
- Continue with part 2 from pptx

- Build the project ..
- Rebuild the application - All done
- Test the apllication - All good

- Now it's time to add the API(Application Programming Interface) Call 
	- for "HTTPDelete" in "CategoryController.cs" file
- Open the file "Areas > Admin > Controllers > CategoryController.cs" file 
	- and add the "Delete" method in this file
	- Code as per the pptx

- Then implement the "HTTPDelete" with a "Delete" method
	- in "category.js" file to add functionality to the application and call the API
- Open the file "category.js" file 
	- Add the "Delete" functionality in this file with "onclick" event to the "Delete" function.
	- Add the "Delete(url)" function code in same file
	- Uses "Sweet Alert" for sucess and error messages
	- Uses "Toastr" for notifications

- Save all changes till this point.

- Build the project ..
- Rebuild the application - All done
- Test the apllication
	- "Delete" is not woking i.e. pop-up for "Delete" is not showing on browser

- Commit All Changes to GitHub repository.


//----------------------------------------------------------------------------------------


2022-11-13 6:50 pm

- Open Visual Studio Community 2019 
- Clone the repository of existing project from GitHub
- Continue with part 2 from pptx

- Build the project ..
- Rebuild the application - All done
- Test the apllication
	- "Delete" is not woking i.e. pop-up for "Delete" is not showing on "Chrome" browser

- Solve the error by changing the pop-up settings to enable for "Chrome" browser

- After pop-up enable - "Delete" pop-up is showing in browser.

- Save all changes till this point.

- Build the project ..
- Rebuild the application - All done
- Test the apllication - All done

- Commit All Changes to GitHub repository.

- End time : 8:30 pm

//----------------------------------------------------------------------------------------


- END OF PART - 2


//----------------------------------------------------------------------------------------