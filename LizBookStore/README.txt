11-01-2023 12:07 Download and add the new bootstrap file with the theme Minty
11-01-2023 12:11 Replace site.css for new file in BB
11-01-2023 12:13 Change the name href="~/lib/bootstrap/dist/css/bootstrap.min.css" to bootstrap.css
11-01-2023 12:15 Remove text-dark 
11-01-2023 12:20 Remove text-dark in LoginParttial file
11-01-2023 12:22 Add additional CSS and JS files
11-01-2023 12:25 Add drop down menu
11-01-2023 12:26 Change drop menu to Content Management
11-01-2023 12:37 Create 3 new project class
11-01-2023 12:42 Install Microsoft.EntityFrameworkCore.Relational 5.0.17  and Microsoft.EntityFrameworkCore.SqlServer 5.0.17
11-01-2023 12:45 Delet Migration folder
11-01-2023 12:48 Install Microsoft Identity.Entity Framework Core
11-01-2023 12:50 namespace LizBookStore.DataAccess.Data
11-01-2023 12:52 Delete 3 class
11-01-2023 12:53 Move Models to LizBook.Models and Delete Models
11-01-2023 12:59 Add References to DataAccess and Model
11-01-2023 13:00 Rename Models folder to ViewModels
11-01-2023 13:03 Rename namespace to namespace LizBookStore.Models.ViewModels
11-01-2023 13:08 Add using LizBookStore.DataAccess.Data;
11-01-2023 13:13 Create SD class in Utility Project
11-01-2023 13:15 Change the properties public static class SD
11-01-2023 13:17 Add 3 references to Utility project
11-01-2023 13:19 In DataAccess project add models and utility references
11-01-2023 13:21 Add Customer area to Areas
11-01-2023 13:24 Add {area=Customer} to pattern in Startup.cs
11-01-2023 13:27 Move HomeController.cs and delete Data and Models
11-01-2023 13:29 Add [Area("Customer")] to HomeController.cs
11-01-2023 13:30 Move View/Home to Area
11-01-2023 13:32 Modify the namespace to namespace LizBookStore.Area.Customer.Controllers
11-01-2023 13:35 Modify ViewStart.cshtml Layout = "~/Views/Shared/_Layout.cshtml";
11-01-2023 13:43 Delete Controllers folder
11-01-2023 13:47 Finish Part #1 11-01-2023  13:47pm

11-03-2023 11:58 Start Part#2
11-03-2023 12:00 Build the application 
11-03-2023 12:05 Create the migration,Modify the database name 
11-03-2023 12:07 add-migration AddDefaultIdentityMigration
11-03-2023 12:24 Change .DataAccess... I get error
11-03-2023 13:04 I can solve the error, delete data_old and Models_old. Clean and REbuilt the solution and remove migration and I again run the command 
11-03-2023 13:06 Migration FILE:20231103170317_AddDefaultIdentityMigration.Designer and 20231103170317_AddDefaultIdentityMigration
11-03-2023 13:10 update-database
11-03-2023 13:12 Check error and run the app
11-03-2023 13:19 Create Class Category
11-03-2023 13:20 Run Command add-migration AddCategoryToDb
11-03-2023 13:44 Add Category in DbContext
11-03-2023 13:48 Create Repository folder and IRepository
11-03-2023 13:54 Add a new interface with the name IRepository.cs
11-03-2023 14:02 Modify IRepository to I can be used  on the Category class to do all the CRUD
11-03-2023 14:15 Add new code in IRepository.cs 
11-03-2023 14:33 Copy the code in BB to Repository.cs file
11-03-2023 14:37 Create ICategoryRepository and CategoryRepository.cs
11-03-2023 14:51 Typing code in CategoryRepository.cs
11-03-2023 15:54 I correct a namespace in Repository.cs
11-03-2023 16:00 Typing code in CategoryRepository.cs
11-03-2023 16:13 Install NugetPackage for Dapper
11-03-2023 16:20 Create code in ISP_Call.cs
11-03-2023 17:01 Typing code SP_CAll.cs
11-03-2023 17:14 Update the code in IUnitOfWork.cs
11-03-2023 17:17 Create UnitOfWork in Repository
11-03-2023 17:22 update code in UnitOfWork.cs
11-03-2023 17:31 Update code in startup.cs

11-06-2023 8:26 Start Part 2.3 Category CRUD
11-06-2023 8:55 Add a new folder in Areas/View with the name Category
11-06-2023 8:56 Add a new Index view to the folder.
11-06-2023 8:59 Update the code copy and paste BB code
11-06-2023 9:00 Run the app and I got the same screen
11-06-2023 9:04 Update the code in _Layout <a class="nav-link" asp-area="Admin" asp-controller="Category" asp-action="Index">Category</a>
11-06-2023 9:08 Update the code <a class="dropdown-item" asp-area="Admin" asp-controller="Category" asp-action="Index">Category</a>
11-06-2023 9:09 Revie the changes in the navigation
11-06-2023 9:19 Add the code <div class="text-center">
    <a href="/Admin/Category/Upsert/id" class="btn-check btn-success text-white" style="cursor:pointer">
        <i class="fas fa-edit"></i>&nbsp;
    </a>
    <a class="btn btn-danger text-white" style="cursor:pointer">
        <i class="fas fa-trash-alt"></i>&nbsp;
    </a>
</div>
inside Index.cshtml
11-06-2023 9:27 Create category.js and add the code in BB
11-06-2023 9:37 Add Scripts section in Index @section Scripts{ 

    <script src="~/js/category.js"></script>
}

11-06-2023 9:52 Add the code for action method for Upsert
11-06-2023 10:00 Add Razor View to Upsert
11-06-2023 10:02 Add code iin Upsert.cshtml
<form method="post">
    <div class="row p-3 border">
        <div class="col-12 border-bottom">
            <h2 class="text-primary">TITLE</h2>
        </div>
        <div class="col-8 pt-4">
            <div class="form-group row">
                <div class="col-4">
                    NAME
                </div>
                <div class="col-8">
                    TEXTBOX FOR NAME
                </div>
            </div>
            <div class="form-group row">
                <div class="col-8 offset-4">
                   EDIT | BACK
                </div>
            </div>
        </div>
    </div>
</form>
11-06-2023 10:11 Create a new  partial view for the Edit-Back
11-06-2023 10:15 Add code in _CreateAndBackToListButton.cshtml 
<div class="row">
    <div class="col">
        <button type="submit" class="btn btn-primary form-control">Create</button>
    </div>
    <div class="col">
        <a asp-action="Index" class="btn btn-success form-control">Back to List</a>
    </div>
</div>

11-06-2023 10:18 Create Partial View _EditAndBackToListButton
11-06-2023 10:22 Add the code in _EditAndBackToListButton.cshtml
@model int
<div class="row">
    <div class="col">
        <button type="submit" class="btn btn-primary form-control" asp-route-id="@model">Update</button>
    </div>
    <div class="col">
        <a asp-action="Index" class="btn btn-success form-control">Back to List</a>
    </div>
</div>
11-06-2023 10:31 Add some code in Upsert.cshtml
11-06-2023 10:34 Add code to Uperst.cshtml
 @if(Model.Id != 0)
            {
                <partial name="_EditAndBackToListButton" model="Model.Id" /> 
                    }
                    else
            {
                <partial name="_CreateAndBackToListButton" />
            }
11-06-2023 10:36 













