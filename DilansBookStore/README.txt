Project Name:- Dilans Book Store
Program purpose:- To create a Webapp for book store
Program Author:- Dilankumar Patel
Program Date:- 2022/10/25

----------------------------------------------------------------------------------Part-1------------------------------------------------------------------------------------------------------------------

2022/10/25

0900: Started creating new project and gave project name DilansBookStore
0910: Checked all dependencies are there or not
0920: Successfully build the project
0930: Add a theme for project sketchy
0935: replaced bootstrap.css page 
0940: done changes in _Layout.cshtml
0950: added additional third party tools Jquery UI(Datepicker), Datatables, Sweet alert, Font Awesome, Toastr
1000: added dropdown menu in _Layout.cshtml
1005: then run the application
1006: And it worked dropdownj was build
1010: I changed the dropdown menu name from 'Dropdown' to 'Content Mangement'
1015: Creted 3 new projects :-
      - Dilansbooks.DataAccess
      - Dilansbooks.Models
      - Dilansbooks.Utility
1020: Moved data folder from main folder to .DataAccess
1030: Installed Nuget package
      - Microsoft.EntityFrameworkcore.Relational
      - Microsoft.EntityFrameworkcore.Sqlserver

2022/10/27

0900: Again started doing project and going to finish it.....
0901: Tried building project just for checking but it came error.
0903: I then retried it and it successfully builded.
0905: Now I moved to next step.
0910: Deleted Migration folder permanently
0915: Installed one more Nuget package
      - Identity.EntityFrameworkCore
0924: Modifyed the namesapace in ApplicationDbContext.cs
0928: Deleted default Class1.cs file from all projects 
0930: I tried to build the project
0931: And it successfully build
0935: Moved models folder to Dilansbooks.Models
0940: Added project refrence to .DataAcess and .Models
0945: Then renamed Models folder to View models
0950: change the namespace in ErrorViewModels.cs
1000: Then build the project to check
1001: It was build successfully
1010: Modified Startup.cs
1015: Try to find all errors
1030: Solved all errors
1035: And then tested the application
1040: And it built it successfully
1050: created class in utility project
1055: modified its properties
1100: added its project refrence to main project
1105: Added project refrence to .DataAccess of model and utility
1110: Added a arear in Areas
1115: Changed route in ScaffoldingReadMe.txt
1120: Moved HomeController.cs folder to controller folder
1125: Deleted Data and Models
1130: Edited HomeController.cs
1135: Moved views 
1140: Modified homeController namespace
1145: Tried to run the application
1146: And i found that application was all changed 
1156: Copied _viewImport and_ViewStart to customer>Area
1200: Modified _ViewStart.cshtml
1205: Then i run the application and i found m y last web page again......
1210: Addede new admin area in Areas
1215: Deleted Data, Model and Controller folder
1220: Added view files
1225: checked the application by running it.
1230: And it was running properly.
1235: And i finally completed my project............
      And came to end with part 1

 ------------------------------------------------------------------------------Part-2------------------------------------------------------------------------------------------------------------------------

 Now starting part 2
 2022/11/08

 1125: Started with Part 2 
        First I try to build my application 
 1127: And it successfully build and was running absolutly fine
 1135: Created migrations
       - 20221108165248_AddDefaultIdentityMigration
       - 20221108181607_AddCategoryToDb
 1136: And modified database name 
 1140: by using Nuget Package Manager Console added migration in .DataAccess project
 1150: Reviewed the file After creating
 1200: then updated the migration
 1210: Reviewed the updated database in SQL server Object Explorer
 1214: Try to run the application for checking errors
 1215: application runned successfully and no errors were found
 1225: Added a new table to DB by creating a model
 1230: Added a new class file
 1235: added migration
 1240: updated Application DB context by using satatement
 1250: then I re-run the migration by deleting the previous to avoid duplication
 0100: then updated database with new Categories
 
 2022/11/13

 1000: Added a new folder name 'Repository'.
 1002: Added an 'IRepository' folder inside it.
 1005: Added new item of type interface to the folder named 'IRepository'
 1010: Modified it, so that it can be used on category class.
 1015: Then I fiexed all bugs
 1020: Modified the code for constuctors and dependency(DI)
 1025: Created two Rpos-
        - CategoryRepository.cs
        - ICategoryRepository.cs
1030: Modified CategoryRepository.cs
1035: Modified ICategoryRepository.cs
1040: Then again fixed some errors
1045: Added new interface int the IRepository folder ISP_Calls.cs
1050: Installed Nuget package for Dapper
1055: Added a new class SP_Call.cs in the Repository
1100: added a connection to the database and added additional using statements
1105: updated implementation of ISP_Call interface.

2022/11/14

1030: Added wrapper for Unit of Work
1035: Added new interface IUnitOfWork to the Irepository folder
1040: Modified UnitOfWork.cs
1050: To make it accessible, registered it on Startup.cs
1055: Corrected errors and build it
1100: Some error poped up, but then fixed it while building
1101: Successfully application was builded
1600: Added new MVC Controller - empty inside Areas/Admin
1605: modified it to use the IUnitOfWork from .DataAccess
1610: Added new folder in Areas/View as Controller
1615: added new index view to the folder
1616: Modified it
1620: Saved and runned it
1621: Successfully runned
1625: In _Layout.cshtml moved 'Category' link to the Content Management dropdown
1627: Reviewed the changes to the navigation
1630: Modified Index.cshtml to add icons in the category section
1635: Deleted it after testing
1636: Added category.js in wwwroot/js folder
1640: In Index.cshtml added @section call to category.js sript and run the project
1645: Then checked it by running
1647: And it was running perfectly fine.
1800: Added IAction result to the controller
1805: Modified upsert view
1810: created partial view for Edit | Back
1815: Added partial named:-
       - _CreateAndBackToListButton
       - _EditAndBackToListButton
1820: Added razor code
1825: Modified upsert.cshtml
1830: added asp-action to index.cshtml
1835: Modified Upsert.cshtml
1840: Added @section call to scripts to validate input
1845: then created Upsert Post action method
1850: Added void save method
1855: Removed _db.savechanges()
1900: moved Redirectoaction method
1905: Checked for errors
1910: There were some errors but I fixed
1915: Then try to build
1917: but not able to build
1920: Now I was feeling sleepy..................

2022/11/15
0950: updated upsert.cshtml
1000: Then I try to solve my error and my error was solved finally...........
      I was having problem with my ICategoryRepository.cs
      I have forget to add extension for IRepository<category>
      And I solved it
1010: Finally checked my project.
1015: And it was running successfully..............

--------------------------------------------------------------------------------------------Part-3---------------------------------------------------------------------------------------------------------------------------------------

2022/11/22

1500: Now started with part 3 
1501: first added new class file CoverType.cs in models
1505: then added a migration file
      - 20221122200305_AddCoverTypeToDb.cs
1506: Then update Dbcontext file as new migration was added
1510: Then added CoverTypeRepository class
1515: Then added interface ICoverTypeRepository
1520: Then added CoverType to unitofwork
1525: then added CoverType to IUnitofwork
1530: then pushed it to database
1535: Added Cover Type to navbar
1540: Added Covertype controller 
1545: Added Cover type index view to use data tables
1550: Added cover type upsert view of creating and updating
1555: Delete cover type is done