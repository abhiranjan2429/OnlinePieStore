#pragma checksum "C:\Users\Admin\Downloads\Learning.net-master\Learning.net-master\FoodApp\FoodApp\Views\Shared\_ItemCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45ff059168a58e4f5501706ca735c76b9a96c1cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ItemCard), @"mvc.1.0.view", @"/Views/Shared/_ItemCard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ItemCard.cshtml", typeof(AspNetCore.Views_Shared__ItemCard))]
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
#line 1 "C:\Users\Admin\Downloads\Learning.net-master\Learning.net-master\FoodApp\FoodApp\Views\_ViewImports.cshtml"
using FoodApp;

#line default
#line hidden
#line 2 "C:\Users\Admin\Downloads\Learning.net-master\Learning.net-master\FoodApp\FoodApp\Views\_ViewImports.cshtml"
using FoodApp.Models;

#line default
#line hidden
#line 3 "C:\Users\Admin\Downloads\Learning.net-master\Learning.net-master\FoodApp\FoodApp\Views\_ViewImports.cshtml"
using FoodOrderingApp.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\Admin\Downloads\Learning.net-master\Learning.net-master\FoodApp\FoodApp\Views\_ViewImports.cshtml"
using FoodOrderingApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45ff059168a58e4f5501706ca735c76b9a96c1cd", @"/Views/Shared/_ItemCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6658e17709c96eec433b3413b631c3d98a236e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ItemCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MenuItem>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 136, true);
            WriteLiteral("\r\n\r\n<div class=\"col-sm-4 col-lg-4 col-md-4 uicorrect\" style=\"float: left; margin-left: 14px\">\r\n    <div class=\"thumbnail\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 153, "\"", 183, 1);
#line 6 "C:\Users\Admin\Downloads\Learning.net-master\Learning.net-master\FoodApp\FoodApp\Views\Shared\_ItemCard.cshtml"
WriteAttributeValue("", 159, Model.ImageThumbnailUrl, 159, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(184, 76, true);
            WriteLiteral(" alt=\"\">\r\n        <div class=\"caption\">\r\n            <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(261, 25, false);
#line 8 "C:\Users\Admin\Downloads\Learning.net-master\Learning.net-master\FoodApp\FoodApp\Views\Shared\_ItemCard.cshtml"
                              Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(286, 44, true);
            WriteLiteral("</h3>\r\n            <h3>\r\n                <a>");
            EndContext();
            BeginContext(331, 10, false);
#line 10 "C:\Users\Admin\Downloads\Learning.net-master\Learning.net-master\FoodApp\FoodApp\Views\Shared\_ItemCard.cshtml"
              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(341, 40, true);
            WriteLiteral("</a>\r\n            </h3>\r\n            <p>");
            EndContext();
            BeginContext(382, 22, false);
#line 12 "C:\Users\Admin\Downloads\Learning.net-master\Learning.net-master\FoodApp\FoodApp\Views\Shared\_ItemCard.cshtml"
          Write(Model.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(404, 103, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"addToCart\">\r\n            <p class=\"button\">\r\n                ");
            EndContext();
            BeginContext(507, 196, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "902a257612e44a238e2164ae6524e3e4", async() => {
                BeginContext(688, 11, true);
                WriteLiteral("Add to cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "C:\Users\Admin\Downloads\Learning.net-master\Learning.net-master\FoodApp\FoodApp\Views\Shared\_ItemCard.cshtml"
                         WriteLiteral(Model.ItemId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-itemId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(703, 54, true);
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuItem> Html { get; private set; }
    }
}
#pragma warning restore 1591
