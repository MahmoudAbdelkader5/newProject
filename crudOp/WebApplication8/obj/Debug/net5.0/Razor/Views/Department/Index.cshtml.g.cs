#pragma checksum "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5ca7d2b2180ab7a22a06d173ffdb0c9797e34958ccd441bc94e77ceec1a6e685"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\_ViewImports.cshtml"
using data_Access_layer.model

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5ca7d2b2180ab7a22a06d173ffdb0c9797e34958ccd441bc94e77ceec1a6e685", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b3418d42e692c33c0b78560f1698e6551f3e6881014329c8b9b533349147c7e5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml"
       IEnumerable<Department>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success p-1 w-25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_buttonsPartailView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml"
 if (TempData["message"] != null)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"alert alert-success\">\r\n        ");
            Write(
#nullable restore
#line 9 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml"
         TempData["message"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 11 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("<div class=\"alert alert-success\">\r\n    ");
            Write(
#nullable restore
#line 13 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml"
     ViewBag.message

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</div>\r\n<div class=\"alert alert-success\">\r\n    ");
            Write(
#nullable restore
#line 16 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml"
     ViewData["mess"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</div>\r\n\r\n<h1>All Departments</h1>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ca7d2b2180ab7a22a06d173ffdb0c9797e34958ccd441bc94e77ceec1a6e6856398", async() => {
                WriteLiteral("Add Department");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n\r\n");
#nullable restore
#line 24 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml"
 if (Model != null && Model.Any())
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"table-responsive\">\r\n        <table class=\"table table-dark table-striped\">\r\n            <thead>\r\n                <tr>\r\n                    <th scope=\"col\">");
            Write(
#nullable restore
#line 30 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml"
                                     Html.DisplayNameFor(d => d.First().code)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
            Write(
#nullable restore
#line 31 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml"
                                     Html.DisplayNameFor(d => d.First().name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
            Write(
#nullable restore
#line 32 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml"
                                     Html.DisplayNameFor(d => d.First().dateCreation)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                    <th scope=\"col\">Update</th>\r\n                    <th scope=\"col\">Delete</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml"
                 foreach (var dep in Model)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <tr>\r\n                        <td>");
            Write(
#nullable restore
#line 41 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml"
                             dep.code

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td>");
            Write(
#nullable restore
#line 42 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml"
                             dep.name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td>");
            Write(
#nullable restore
#line 43 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml"
                             dep.dateCreation.ToString("MM/dd/yyyy")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                       \r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5ca7d2b2180ab7a22a06d173ffdb0c9797e34958ccd441bc94e77ceec1a6e68510610", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = 
#nullable restore
#line 45 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml"
                                                                        dep.id

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        \r\n                    </tr>\r\n");
#nullable restore
#line 48 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 52 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <h3>There are no departments.</h3>\r\n");
#nullable restore
#line 56 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Department\Index.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("  ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Department>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
