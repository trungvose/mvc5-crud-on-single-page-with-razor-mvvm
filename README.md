# MVC 5 Project with CRUD on a single page using Razor and MVVM technique.

###Installation
Clone this repository and open MVC.SinglePage.sln with Visual Studio.
Because this project only used the mock data so there are no need to set up any kind of database.
####To view in browser: Right click into MVC.SinglePage and select View -> View in Browser (Ctrl + Shift + W)
####To debug: Set MVC.SinglePage as StartUp project and press F5


###Key Feature
1. Eliminate pages in MVC using only one default view (Index.cshtml) for all action instead of 4 pages scaffolded by MVC.
    * Control the view base on server side code, not all in the client.
    * jQuery on client side handling.
    * Use Model-View-View-Model.
2. Bootstrap 3 for displaying.
3. Reduce code in the controller.
4. Reusable base class.

###Project Structure
```
├───MVC.SinglePage
│   │
│   ├───Controllers
│   │       HomeController.cs
│   │
│   └───Views
│       │
│       ├───Home
│       │       Index.cshtml
│       │
│       └───Shared
│               Error.cshtml
│               _Layout.cshtml
│
├───MVC.SinglePage.Data
    │   TrainingProduct.cs
    │   TrainingProductManager.cs
    │   TrainingProductViewModel.cs
```

####1. TrainingProduct.cs
It is an entity class to hold product data with 5 fields:
- Product ID
- Product Name
- Introduction Date
- URL
- Price

####2. TrainingProductManager.cs
It is a data access class to load mock data and store into a list of training product.

####3. TrainingProductViewModel.cs
It is a view model to hold all the data instead of TrainingProduct class to pass into the view.