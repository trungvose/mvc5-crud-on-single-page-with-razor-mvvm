# MVC 5 Project with CRUD on a single page using Razor and MVVM technique.
This project aims to show how we can build a single page for performing CRUD (Create - Read - Update - Delete) without the need of separating into five different views by scaffolded by [MVC5 Controller](http://www.asp.net/visual-studio/overview/2013/aspnet-scaffolding-overview) but using only one view (Index.cshtml) with help from View Model.

##Key Feature
1. Eliminate pages in MVC using only one default view (Index.cshtml) for all action instead of 4 pages scaffolded by MVC.
    * Control the view base on server side code, not all in the client.
    * jQuery on client side handling.
    * Use Model-View-View-Model.
2. Bootstrap 3 for displaying.
3. Reduce code in the controller.
4. Reusable base class - ViewModelBase class with reusable properties and methods.
5. Data Annotation for simple validation.
6. Custom validation method to check other business rules.

![MVC 5 Project with CRUD on a single page using Razor and MVVM technique](http://trungk18.github.io/img/repo/mvc5-singlepage-razor.png)

##Installation
###Require .NET Framework 4.5
Clone this repository and open MVC.SinglePage.sln with Visual Studio.
Because this project only used the mock data so there are no need to set up any kind of database.

###To view in browser: 
```
Right click into MVC.SinglePage -> View -> View in Browser (Ctrl + Shift + W)
```
###To debug: 
```
Set MVC.SinglePage as StartUp project -> Press F5
```

##Project Structure
```
+---MVC.SinglePage
|   +---Controllers
|   |       HomeController.cs
|   |       
|   \---Views
|       |   
|       +---Home
|       |       Index.cshtml
|       |       
|       \---Shared
|               Error.cshtml
|               _Layout.cshtml
|               
+---MVC.SinglePage.Common
|   |   ViewModelBase.cs
|   |              
+---MVC.SinglePage.Data    
    |-- TrainingProduct.cs
    |-- TrainingProductManager.cs
    |-- TrainingProductViewModel.cs

```

###1. TrainingProduct.cs
It is an entity class to hold product data with 5 fields:
- Product ID
- Product Name
- Introduction Date
- URL
- Price

###2. TrainingProductManager.cs
It is a data access class to load mock data and store into a list of training product.

###3. ViewModelBase.cs
Reusable base class for ViewModel to extend. Including all the virtual method

###4. TrainingProductViewModel.cs
It is a view model to hold all the data instead of TrainingProduct class to pass into the view. Extend ViewModelBase class and call all the base method from here.

###5. Index.cshtml
Including a jQuery method to get data button with data-action attribute and submit the form. Its purpose is to tell view model what to do.

```html
<td class="action-button-column">
    <a href="#" 
        data-action="edit"
        data-val="@item.ProductId" 
        class="btn btn-default btn-sm">
        <i class="glyphicon glyphicon-edit"></i>
    </a>
</td>
``` 

```javascript
$(document).ready(function () {
    $('[data-action]').on('click', function (e) {
        //Prevent submit form
        e.preventDefault();

        $('#EventCommand').val($(this).data('action'));
        $('#EventArgument').val($(this).data('val'));

        $('form').submit();
    })
})
``` 

###6.HomeController.cs
All the handle action is written in ViewModel so controller will handle the HttpGet and HttpPost for the view.
