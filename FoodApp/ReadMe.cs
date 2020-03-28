using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingApp
{
    public class ReadMe
    {
        ///<_Layout.cshtml>
        ///  Asp .netcore MVC will automatically search for a file called  _ViewStart.cshtml when a view is rendered.
        ///  In View start file we typically place a code we want to execute just when any view is called in there and then specify
        ///  which layout file shoul be used . Note:- we donot use Layout.cshtml we just use _Layout.    
        ///</_Layout.cshtml>

        ///<ViewImports.cshtml>
        ///ViewImport file this file is used to include types with an @ using statements. These types will then automatically be known
        ///when we added view 
        ///
        /// Example "@using FoodOrderingApp.ViewModels" this was added in the ViewImport file
        ///</ViewImports.cshtml>

        ///<app.UseStaticFiles()>
        ///this looks for static files in wwwroot folder
        ///</app.UseStaticFiles>

        ///<Routing>
        /// ASP.NET Core comes with two types of routing built in, namely convention-based routing and attribute-based routing.
        /// Convention-based routing is most commonly used for MVC web applications, 
        /// and that is also what we are going to be using here as well. Attribute-based routing is mostly used for APIs, 
        /// but we're not covering that in this course. If you have been using ASP.NET Core before, you'll notice that
        /// some things have changed in the routing space. Among others, the name of the middleware components 
        /// that we need to add to enable routing has changed
        ///</Routing>

        ///<Multiple Routing>
        ///basically, all requests that have this pattern can now be matched using this pattern and the controller
        ///and action will be extracted from the request URI, and then forwarded onto the controller and its action to have it handled.
        ///Most applications will have multiple routes defined. The matching system will sequentially run to all defined patterns
        ///and the first match will be used. If you have multiple routes therefore defined, it's important to ensure that you 
        ///have them in the correct order with the most specific ones at the top. As I already said,
        ///ASP.NET Core 2.1 uses a slightly different way of configuring the application. 
        ///Here we use UseMvc and pass the route using the MapRoute method.
        /// </Multiple>

        ///<TagHelper>
        ///create a link in our view code, we'll use tag helpers, a feature added with the first release of ASP.NET Core MVC.
        ///A tag helper consists out of markup code that will execute server side. When we use it in our markup code,
        ///it will trigger the execution of code. In this case, the generation of the correct link. This way, 
        ///for Razor code we can thus trigger certain functionality to happen. MVC comes with quite a few tag helpers built in,
        ///and we'll see some already in this module. It's also possible to create custom tag helpers
        ///
        /// 
        /// <a asp-contrller="Pie" asp-action="List"> View Pie List </a>
        /// 
        /// I am generating a link using a plain anchor tag, an a tag. 
        /// I want to have ASP.NET Core MVC generate the correct link based on the route or routes I have in my application defined.
        /// I can do this using a tag helper. In fact, using two attribute tag helpers. 
        /// The asp-controller tag is set to pie and the asp-action tag helper is set to list. 
        /// As mentioned, tag helpers trigger the execution of code. So when this view code will run, 
        /// it will trigger code that will look at routes we have in our application and based on these generate the correct outgoing link
        /// 
        /// Example @addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers in _ViewImport.cshtml
        /// </TagHelper>

        ///<PartialView>
        /// Partial views will encourage reuse of code, and that's always a good thing. 
        /// Imagine that you have two different views in your application.
        ///  It's a convention in ASP.NET Core MVC to give all partial views a name that starts with
        ///  an underscore. This will allow us to distinguish between a regular view and a partial
        ///  view. Where we now want to use our partial view, we can again use a tag helper.
        ///  A tag helper will execute code and render HTML. 
        ///  We already saw that in the previous module. 
        ///  Here the tag helper will expect the name property as the bare minimum.
        ///  The name points to the partial view, typically starting with an underscore.
        ///  Notice, there's no extension, so no cshtml being used
        ///  While it's possible to put partial views directly in one of the controller folders, 
        ///  typically they will be shared, and it's therefore also common to place partial views
        ///  in the Shared folder. When the Razor now encounters the partial tag helper,
        ///  it will by default search in that Shared folder. Since the ID of a partial view 
        ///  is indeed sharing a view between other views, the Shared folder seems to be a good place.
        ///  The Shared folder is a known folder for ASP.NET Core MVC. And if you ask it to show 
        ///  a partial view, it will first look in the Controllers folder and then always in this
        ///  Shared folder.
        ///  Partial View is just a rezorview from web section
        /// Example:-
        /// </PartialView>

        ///<Session>
        ///The GetCart method is a very important one, and notice that it now gets an IServiceProvider
        ///called services. That is basically going to give us access in this method to the services 
        ///collection, basically, the collection of services managed in the dependency injection container.
        ///Now before I explain you the code, let me give you some background on how I'm going to work
        ///with my shopping cart. When the user comes to my site, I'm going to check if he or 
        ///she already has an active shopping cart. A shopping cart, I'm going to represent in memory 
        ///using a GUID, a string that is. And that string I'm going to be storing in the session.
        ///So in other words, when the user comes to my site, I'm going to check if there is
        ///already an active session containing a cart ID. If not, I create a new one. 
        ///Then I'm going to create an instance of a shopping cart, passing in that cart ID.
        ///That's exactly what I'm doing in this code here. Let me show you. 
        ///I'm going to have to bring in support for sessions. 
        ///Sessions allow me to store information on the server side between the request and 
        ///to an underlying mechanism of cookies, ASP.NET can this way remember basically,
        ///keep state information on the server about a certain active session. 
        ///Now to bring in support for sessions, I actually need something called the IHttpContextAccessor.
        ///We have access to the sessions directly in a controller, but we do not in a regular class,
        ///and that is why I'm going to use the services collection here and ask it for a required service
        ///called the IHttpContextAccessor. We need to bring in support for that. In the Startup class,
        ///we'll do that very soon. Through the IHttpContextAccessor 
        ///I get access to the HttpContext that gives me access to all information about the request.
        ///And that way, I can also get access to the session.
        ///</Session>
    }
}
