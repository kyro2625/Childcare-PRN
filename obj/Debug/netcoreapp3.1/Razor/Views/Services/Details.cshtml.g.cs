#pragma checksum "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bccf02184b6aaa5e8d37713b9cc074246b6815d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Details), @"mvc.1.0.view", @"/Views/Services/Details.cshtml")]
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
#nullable restore
#line 1 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\_ViewImports.cshtml"
using Childcare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\_ViewImports.cshtml"
using Childcare.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bccf02184b6aaa5e8d37713b9cc074246b6815d", @"/Views/Services/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6e32bb57870fb2d1b8b1f242a4e348efc280250", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Childcare.Areas.Identity.Data.Service>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Service</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ServiceName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
       Write(Html.DisplayFor(model => model.ServiceName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Thumbnail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
       Write(Html.DisplayFor(model => model.Thumbnail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
       Write(Html.DisplayFor(model => model.Staff.StaffID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Specialty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
       Write(Html.DisplayFor(model => model.Specialty.SpecialtyID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status.StatusID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bccf02184b6aaa5e8d37713b9cc074246b6815d11599", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "F:\Study At FPTU\5. Summer 2021\PRN211 - Basic Cross-Platform Application Programming With .NET - KiemHH\ChildCare\ChildCare\Views\Services\Details.cshtml"
                           WriteLiteral(Model.ServiceID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bccf02184b6aaa5e8d37713b9cc074246b6815d13824", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Childcare.Areas.Identity.Data.Service> Html { get; private set; }
    }
}
#pragma warning restore 1591
