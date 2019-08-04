# Euro-Office-Test
Tech Test from Euro Office

## Questions:

### 1) How long did you spend on the coding test?

Four hours.  The first two were spent trying to get the .gitignore file to work as expected in a Windows 10 Visual Studio 2019, so that I could commit the bootstrapped code from a .NET Core project.  The second two were when I actually did anything vaguely meaningful, after swapping development platforms altogether and working in Linux Ubuntu with Monodevelop to build in .NET MVC.  The .gitignore file finally did what it was supposed to here.

### 2) What would you change / implement in your application given more time?

Start in the development environment I know works.  Apparently .NET Core applications are just very difficult to spin up from scratch, in my experience.  The next time I am trying to start a RESTful API Web Application, I will use what I know I can work with.

In terms of meeting the basic requirements of the test, I at least got started with a controller that returned a list of categories under isloated unit testing.  Unfortunately I could not test it manually in the browser successfully due to MVC versioning issues in the Views/Web.config, which I ran out of time attempting to resolve.  Had I not squandered so much time at the beginning of the test trying to get an alternative development environment to run, I would have been able to do more with the application, at least laying out clearer separation of concerns with the Home Page Controller making requests to a Category Controller, which would handle the api routes using the urls specified in the test.  Beyond using an MVC architecture, however, I'm not sure if the application required by the test is large enough to warrant the application of other Design Patterns, e.g. a Factory Pattern or Strategy Pattern.

With more time to work on the application generally, I would have added a database of some sort to the backend and used Entity Framework to manage populating model properties.  I would have added api routes to add items to a category and categories to the category list.  I would have implemented tagging on items, so they could then have multiple categories via their tags.  This would lead to implementing a Repository Pattern as part of the application design.

One thing not clear in this test is how rigid the format of the API endpoint urls is.  I read it as needing to include the protocol and domain as written in the endpoint url, but wonder if this interpration is correct and feel that the relative url on the route should be enough.  It's also unclear if the result needed to be in XML as the example appears to indicate, or if it could have been sent in JSON, which tends to be a lot more common in most Web Apis.  

### 3) Did you use IOC? Please explain your reasons either way.

Perhaps with the exception of using an MVC architecture pattern, I didn't write enough classes in this test to warrant claiming use of Inversion of Control, but believe the application will naturally gravitate to that principle as more dependencies are managed via Dependency Injection and the Entity Framework is introduced.

### 4) How would you debug an issue in production code?

To start with, by viewing it in situ and 

### 5) What improvements would you make to the cat API?

As noted in my answer to question 2, add a database to the backend, use Entity Framework to manage populating model properties, add an api routes to add items to a category and categories to the category list.  Implement tagging on items, so they could then have multiple categories via their tags.

### 6) What are you two favourite frameworks for .Net?

The ones I have developed the most experience with: Entity Framework, for its simplification of SQL commands, and ASP.NET, which I used extensively in my role with Compare The Market.

### 7) What is your favourite new feature in .Net?

Antimalware scanning on network loaded assemblies and a fixed memeory leak on HttpWebRequest HTTPS communications via proxy.

### 8) Describe yourself in JSON.

```{
	"Jeremy Barrass": {
	    "Height": 173,
	    "Weight": 63.5,
	    "Eye colour": "Brown",
	    "Hair colour": "Brown",
	    "Hobbies": [
	        "Pen & Paper RPGs",
	        "Rock climbing",
	        "Cemetary walks"
	    ],
	    "CV": "[https://github.com/Jeremy-Barrass/CV](https://github.com/Jeremy-Barrass/CV)"
    }
}```