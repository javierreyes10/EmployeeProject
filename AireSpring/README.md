# Employee Project

Employee project used for adding, updating and getting employees in an easy way

## Libraries and Framework
 - [Automapper](https://automapper.org/)
 - [Dapper](https://dapper-tutorial.net/dapper) for Data Access
 - [Bootstrap](https://getbootstrap.com/)
 - [JQuery UI DatePicker ](https://jqueryui.com/datepicker/)
 - [JQuery Datatable](https://datatables.net/)
 - [jQuery Inputmask](https://plugins.jquery.com/jquery.inputmask/)
 - [ASP.NET Framework 4.8 WebForms](https://devblogs.microsoft.com/dotnet/announcing-the-net-framework-4-8/)
 - [AspNet.WebFormsDependencyInjection.Unity](https://devblogs.microsoft.com/aspnet/use-dependency-injection-in-webforms-application/)

## Patterns
- Repository Pattern
- [MVP Pattern](https://docs.microsoft.com/en-us/archive/msdn-magazine/2006/august/design-patterns-model-view-presenter)
- [Factory Method](https://www.dofactory.com/net/factory-method-design-pattern)
- [Interface segregation principle](http://butunclebob.com/ArticleS.UncleBob.PrinciplesOfOod)
- [Dependency Inversion Principle](http://butunclebob.com/ArticleS.UncleBob.PrinciplesOfOod)

## Project Structure
- Index.aspx. Used to show a table with the list of all the employees. A "add employee" button has been added to add a new employee.
- EmployeView.aspx. User to edit or add an employee according to the requirement.
- EmployeView.aspx.cs implements the IEmployeeView for accessing the control values from the presenter through an abstraction.
 The presenter is injected.
- View\IEmployeeView.cs is used for passing/inserting the values from the view to the presenter and vice-versa.
- Presenter\IEmployeePresenter.cs and EmployeePresenter.cs. In charge of accessing the data and populate/access the view values. Here the repository is injected. in that way the code is more testable.
- Model\Employee.cs Domain model
- Repository. In this folder, all the access to the database is handled. This is injected, in that way, we can easily another source like an oracle database, excel file, cache, etc, without impact the entire code.
In the same way, the Factory method pattern has been implemented to follow the DRY principle.
- EmployeeHanlder.ashx. This is called with Ajax on the Index.aspx page to populate the table of the employees. The repository is injected.
- Global.asax.cs It is used to define the dependency container, here we can change the data source if it is required.
- App_Start\MappingProfile.cs Automapper configuration.a
- Scripts\Custom. Here are the JS file made for this project
- The Database used is in the mdf file. Also the script has been added to the solution.

## Project Structure
- In the home page, go the "Employee Section" next to "Home" for accesssing the employe page