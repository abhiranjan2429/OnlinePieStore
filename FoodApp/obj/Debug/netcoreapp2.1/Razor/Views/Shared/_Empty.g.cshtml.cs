#pragma checksum "C:\Users\z003scmb\source\repos\FoodApp\FoodApp\Views\Shared\_Empty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "509c416aa15f17393c31f0204bc1a20524b4f404"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Empty), @"mvc.1.0.view", @"/Views/Shared/_Empty.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Empty.cshtml", typeof(AspNetCore.Views_Shared__Empty))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\z003scmb\source\repos\FoodApp\FoodApp\Views\_ViewImports.cshtml"
using FoodApp;

#line default
#line hidden
#line 2 "C:\Users\z003scmb\source\repos\FoodApp\FoodApp\Views\_ViewImports.cshtml"
using FoodApp.Models;

#line default
#line hidden
#line 3 "C:\Users\z003scmb\source\repos\FoodApp\FoodApp\Views\_ViewImports.cshtml"
using FoodOrderingApp.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\z003scmb\source\repos\FoodApp\FoodApp\Views\_ViewImports.cshtml"
using FoodOrderingApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"509c416aa15f17393c31f0204bc1a20524b4f404", @"/Views/Shared/_Empty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6658e17709c96eec433b3413b631c3d98a236e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Empty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 118, true);
            WriteLiteral("<div>\r\n    <h2> Your cart is empty, add some items Coffee first</h2>\r\n    <a href=\"/Home/Index\">Home</a>\r\n    \r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
