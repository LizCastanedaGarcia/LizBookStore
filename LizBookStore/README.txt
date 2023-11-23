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
11-06-2023 10:36 Modify the line <a class="btn btn-primary" asp-action="Upsert"><i class="fas fa-plus"></i> &nbsp; Create New Category</a>
11-06-2023 10:54 Add @section Scripts {
    <partial name="_ValidationScriptsPartial" />
}

11-06-2023 11:19 Add code to CategoryController, I have problems in SAve method
11-06-2023 11:20 Add tho void Save method to IUnitOfWork.
11-06-2023 11:26 Add code in CategoryController.cs _unitOfWork.Save();
                return RedirectToAction(nameof(Index));  //to see all the categories
11-06-2023 11:33 Add in API section [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Category.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Category.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }
11-06-2023 11:38 Add code to category.js 
<a onclick=Delete("/Admin/Category/Delete/${data}") class="btn btn-danger text-white" style="cursor:pointer">
                                    <i class="fas fa-trash-alt"></i>&nbsp;
</a>
11-06-2023 11:41 Add function Delete 
function Delete(url) {
    swal({
        title: "Are you sure you want to delete?",
        text: "You will not be able to restore the data!",
        icon: "warning",
        buttons: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}
11-06-2023 16:25 I hve problems with Create Category, I am looking for the solution.
1. Double check all the code in Index and Upsert
2. Correct minimun details in the code
3. The problem was that I had 2 files Index and Privacy I haven't deleted them.
4.Finally, I can create new category!!!!!
11-06-2023 16:40 I am inserting new register.



PART # 3  11-15-2023

11-15-2023 17:57 Start to create Cover Type CRUD, first create CoverType.cs.
11-15-2023 17:59 Create CoverTypeRepository class
11-15-2023 18:06 Create ICoverTypeRepository.cs and add new code like ICategory.cs
11-15-2023 18:12 Adapt the code to CoverType in UnitofWork, IUnitofWork, CoverTypeRepository, ICoverTypeRepository.
11-15-2023 18:18 I have error in CoverTypeRepository.cs.
11-15-2023 18:25 I find the solution, I didn't change ApplicationDbContext.cs.
11-15-2023 18:28 Create Migration run the command add-migration AddCoverTypeToDb in CoverType NAME=20231115232927_AddCoverTypeToDb, finally update-database
11-15-2023 18:34 Add CoverType in menu bar <a class="dropdown-item" asp-area="Admin" asp-controller="CoverType" asp-action="Index">CoverType</a>
11-15-2023 18:37 Add CoverTypeController.cs and updte the code.
11-15-2023 18:57 CreateCoverType folder 
11-15-2023 18:58 Create Index and Upsert ffiles and update the code.
11-15-2023 19:01 Update Upsert file.
11-15-2023 19:01 Add covertype.js and update code
11-15-2023 19:01 I have problems with Cover Type creation, double check the code.
11-15-2023 19:30 Create Product.cs and typing the code
11-15-2023 19:32 Modify ApplicationDbContext.cs public DbSet<Product> Products { get; set; }
11-15-2023 19:35 Add migration add-migration AddProductToDb 
11-15-2023 19:36 update-database.
11-15-2023 19:40 NAME MIGRATION = 20231116003637_AddProductToDb
11-15-2023 19:44 Update Product class, title, isbn and author are required
11-15-2023 19:45 New migration and update database NAME= 20231116004705_AddValidationToProduct
11-15-2023 20:03 Create code in ProductRepository.cs
11-17-2023 13:18 I hve problems with Product, I deleted all about Product and I am going to start agian.
11-17-2023 13:30 Create Product.cs
11-17-2023 13:32 Add References to ApplicationDbContext.cs
11-17-2023 13:34 add-migration addProductToDb and update database 20231117183643_addProductToDb.Designer
11-17-2023 13:50 new migration add-migration addValidationToProduct and update 20231117185059_addValidationToProduct
11-17-2023 14:09 Add product to UnitWork and IUnitWork
11-17-2023 14:18  public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
            }
11-17-2023 14:19 Create ProductVM.cs and install Microsoft.AspNetCore.Mvc.ViewFeatures packg
11-17-2023 14:33 reate ProductController.cs add code 
public IActionResult Upsert(int? id)      //action method for Upsert
        {
            ProductVM productVM = new ProductVM()
            {
                Product = new Product(),
                CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),

                CoverTypeList = _unitOfWork.CoverType.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
            };

           if (id == null)
           {
               //this is for create
               return View(productVM);
    }

    //this for edit
    productVM.Product = _unitOfWork.Product.Get(id.GetValueOrDefault());
            if (productVM.Product == null)
            {
                return NotFound();
            }
        return View(productVM);
}
11-17-2023 14:52 Comment  public IActionResult Upsert(Category category)
11-17-2023 14:54 I'll continue later
11-17-2023 15:36 Modify the API call
11-17-2023 15:46 Create Index view
11-17-2023 15:50 Create index.cshtml for product
11-17-2023 15:56 Modify code in product.js 
 "columns": [
            { "data": "title", "width": "15%" },
            { "data": "isbn", "width": "15%" },
            { "data": "price", "width": "15%" },
            { "data": "author", "width": "15%" },
            { "data": "category.Name", "width": "15%" },
11-17-2023 15:58 Modify Layout add  <a class="dropdown-item" href="#">Product</a>
11-17-2023 16:17 Create Upsert.cshtml
11-17-2023 16:22 Stop until here I will continue later

11-20-2023 I start again, I have error in Product-Upsert, I am trying to solve it
11-20-2023 Create an account in tiny.cloud I use the API
11-20-2023 Type function validateInput
11-20-2023 Create folder images/products in wwwroot
11-20-2023 Uncomment function public IActionResult Upsert(Product product) in ProducController.cs
11-20-2023 I have some problems I try to solve them
11-20-2023 I had error in Upsert Prodcut because I missed a }
11-20-2023 In ProductController I commented //var allObj = _unitOfWork.Product.GetAll(includeProperties: "Category, CoverType");
11-20-2023 I have an error but I don't find the solution

*****PART 4*****
11-23-2023 18:30 Start Part4
11-23-2023 18:33 Update the Product Class in order to add new properties (price,price50,price100) 
11-23-2023 18:34 add Migration addPriceToProductDb
11-23-2023 18:45 update-database
11-23-2023 18:49 Update with new properties Upsert.cshtml
11-23-2023 18:51 Update Index.cshtml 
                <th>Price</th>
                <th>Price100</th>
                <th>Price50</th>
11-23-2023 18:53 Update ProductRepository.cs 
 //new
                objFromDb.Price = product.Price;
                objFromDb.Price100 = product.Price100;
                objFromDb.Price50 = product.Price50;
                //****
11-23-2023 18:55



















