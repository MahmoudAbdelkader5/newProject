#pragma checksum "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c37aeb66c44f2dfbb1393a12b746c9be1e40ed7ca5d36d1bca17297fb238e300"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Employee_Details), @"mvc.1.0.view", @"/Views/Employee/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c37aeb66c44f2dfbb1393a12b746c9be1e40ed7ca5d36d1bca17297fb238e300", @"/Views/Employee/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b3418d42e692c33c0b78560f1698e6551f3e6881014329c8b9b533349147c7e5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Employee_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
       Employee

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>Create New Employee</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c37aeb66c44f2dfbb1393a12b746c9be1e40ed7ca5d36d1bca17297fb238e3005427", async() => {
                WriteLiteral("\r\n\r\n\r\n    <div class=\"form-group\">\r\n        ");
                Write(
#nullable restore
#line 12 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.LabelFor(m => m.Name)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n        ");
                Write(
#nullable restore
#line 13 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.TextBoxFor(m => m.Name, new { @class = "form-control mb-3", placeholder = "Enter employee name" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n        ");
                Write(
#nullable restore
#line 14 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.DisplayFor(m => m.Name, "", new { @class = "text-danger" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
                Write(
#nullable restore
#line 17 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.LabelFor(m => m.Age)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n        ");
                Write(
#nullable restore
#line 18 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.TextBoxFor(m => m.Age, new { @class = "form-control mb-3", placeholder = "Enter employee name" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n        ");
                Write(
#nullable restore
#line 19 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.DisplayFor(m => m.Age, "", new { @class = "text-danger" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
                Write(
#nullable restore
#line 22 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.LabelFor(m => m.Email)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n        ");
                Write(
#nullable restore
#line 23 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.TextBoxFor(m => m.Email, new { @class = "form-control mb-3", placeholder = "Enter employee email" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n        ");
                Write(
#nullable restore
#line 24 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.DisplayFor(m => m.Email, "", new { @class = "text-danger" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
                Write(
#nullable restore
#line 27 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.LabelFor(m => m.Address)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n        ");
                Write(
#nullable restore
#line 28 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.TextBoxFor(m => m.Address, new { @class = "form-control mb-3", placeholder = "Enter employee address" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n        ");
                Write(
#nullable restore
#line 29 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.DisplayFor(m => m.Address, "", new { @class = "text-danger" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
                Write(
#nullable restore
#line 32 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.LabelFor(m => m.Phone)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n        ");
                Write(
#nullable restore
#line 33 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.TextBoxFor(m => m.Phone, new { @class = "form-control mb-3", placeholder = "Enter employee phone number" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n        ");
                Write(
#nullable restore
#line 34 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.DisplayFor(m => m.Phone, "", new { @class = "text-danger" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
                Write(
#nullable restore
#line 37 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.LabelFor(m => m.Salary)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n        ");
                Write(
#nullable restore
#line 38 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.TextBoxFor(m => m.Salary, new { @class = "form-control mb-3", placeholder = "Enter employee salary" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n        ");
                Write(
#nullable restore
#line 39 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.DisplayFor(m => m.Salary, "", new { @class = "text-danger" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
                Write(
#nullable restore
#line 42 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.LabelFor(m => m.CreationDate)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n        ");
                Write(
#nullable restore
#line 43 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.TextBoxFor(m => m.CreationDate, "{0:yyyy-MM-dd}", new { @class = "form-control mb-3", type = "date" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n        ");
                Write(
#nullable restore
#line 44 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.DisplayFor(m => m.CreationDate, "", new { @class = "text-danger" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
                Write(
#nullable restore
#line 47 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.LabelFor(m => m.HireTime)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n        ");
                Write(
#nullable restore
#line 48 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.TextBoxFor(m => m.HireTime, "{0:yyyy-MM-dd}", new { @class = "form-control mb-3", type = "date" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n        ");
                Write(
#nullable restore
#line 49 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.DisplayFor(m => m.HireTime, "", new { @class = "text-danger" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
                Write(
#nullable restore
#line 52 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.LabelFor(m => m.IsActive)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n        ");
                Write(
#nullable restore
#line 53 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.CheckBoxFor(m => m.IsActive, new { @class = "form-check-input mb-3" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n        ");
                Write(
#nullable restore
#line 54 "C:\Users\master\source\repos\crudOp\WebApplication8\Views\Employee\Details.cshtml"
         Html.DisplayFor(m => m.IsActive, "", new { @class = "text-danger" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n    </div>\r\n    <div class=\"col-12\">\r\n        <button class=\"btn btn-primary\" type=\"submit\">Submit</button>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c37aeb66c44f2dfbb1393a12b746c9be1e40ed7ca5d36d1bca17297fb238e30015196", async() => {
                    WriteLiteral("Cancel");
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
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
