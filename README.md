# NotApple

E-commerce web app for purchasing customizable computers using MVC architecture in .NET core.

A selection of computers offer options on OS, RAM, storage, CPU, GPU, and display. 

AJAX and Razor pages used for async loading of page items and running totals. 

Customer management module provides secure login, order management, email authentication and account recovery via MySQL and SendGrid.

## Models:
The model required for this part is the Computer model, which includes getters and setters for the following: Name, Cpu, Ram, Storage, Display, Gpu, OS, and Total(price). This model is used within the views to transfer, store, and display the information in a consistant way.

## Controller:
The HomeController handles all actionrequests and returns the respective view. All of these are straightforward except for the Purchased control. This is activated by a Post request and accepts a computer model argument. The information is parsed to calculate total price, and attach elements in a viewbag to display on a confirmation screen. Also a cookie is created based on the users ip address to store the order details.

## Views:
The main view for this part is the _Layout.cshtml in Shared. It provides a navigation bar with Home and Shop options. It also provides a footer for contact and feedback. The contact view will bring you to an information view, and the feedback will provide a textbox to enter feedback, as well as a confirmation upon submission. Any selection is handled by the HomeController which returns the respective view. The body of the main page calls RenderBody on /Home/Index.cshtml which provides welcome statement and a featured computer. You can select the computer from here to customize, or you can go to the shop tab. In this table a hardcoded list on computers is displayed where you can pick one of them bringing you to the specific customization page. These views are specified by the individual computer. For the specific computer views, they consist of a form which will use Post to present the customized computer model object to the controller. The options are presented in @Html.DropDownListFor selectors to collect the information for the form. Upon any item change, the script will be called to dynamically calculate and display the updated price. Buy will submit the form and transfer the information to the controller and back to the Purchased view for confirmation.


    .net core authentication module is used for registration and signup. Using the Object relational mapper (ORM) MYSQL setup, a table is created to handle secure signup. Confirmation and recovery is handled by SendGrid, in where i set up an account with a key to send confirmation emails. The user and key is set with the secret-manager tool. SendGrind is installed via the package manager, and IEmailSender interface is implemented in /Services/EmailSender.cs. The key is fetched and secured via Services/AuthMessageSenderOptions.cs. Finally the implementation is added to startup configuration services. By using [Authenticate] you can ensure actions such as buying, are restricted to those who are logged in. The users are added to the database user tables upon registration. This database also contains tables for computers, and orders which represent the models used for them. Using ORM and migration, the need for tedious creations are eliminated




