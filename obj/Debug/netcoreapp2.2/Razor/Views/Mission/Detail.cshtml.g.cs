#pragma checksum "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6397899fc143b3055b202e8272d60bf9da2e0ab0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mission_Detail), @"mvc.1.0.view", @"/Views/Mission/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mission/Detail.cshtml", typeof(AspNetCore.Views_Mission_Detail))]
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
#line 1 "C:\Users\ibr günay\source\repos\TaskManager\Views\_ViewImports.cshtml"
using TaskManager;

#line default
#line hidden
#line 2 "C:\Users\ibr günay\source\repos\TaskManager\Views\_ViewImports.cshtml"
using TaskManager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6397899fc143b3055b202e8272d60bf9da2e0ab0", @"/Views/Mission/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc035caf78427af9c0e6c60ac75693646a0d7e84", @"/Views/_ViewImports.cshtml")]
    public class Views_Mission_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskManager.Models.Mission>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(79, 138, true);
            WriteLiteral("\r\n<h1>Plan Görevi</h1>\r\n<br />\r\n<hr />\r\n<div>\r\n\r\n\t<dl class=\"row\">\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\tResim\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n");
            EndContext();
#line 17 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"
             if (Model.Photo != null)
			{

#line default
#line hidden
            BeginContext(253, 4, true);
            WriteLiteral("\t\t\t\t");
            EndContext();
            BeginContext(257, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6397899fc143b3055b202e8272d60bf9da2e0ab05326", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 267, "~/Photo/", 267, 8, true);
#line 19 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"
AddHtmlAttributeValue("", 275, Model.Photo, 275, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(316, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 20 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"
			}
			else
			{

#line default
#line hidden
            BeginContext(339, 99, true);
            WriteLiteral("\t\t\t\t<img src=\"https://www.clker.com/cliparts/K/0/N/F/h/W/task-md.png\" height=\"150\" width=\"150\" />\r\n");
            EndContext();
#line 24 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"

			}

#line default
#line hidden
            BeginContext(446, 83, true);
            WriteLiteral("\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\tİş Adı\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(530, 40, false);
#line 31 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"
       Write(Html.DisplayFor(model => model.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(570, 90, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\tiş Açıklama\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(661, 43, false);
#line 37 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(704, 96, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\tiş başlama tarihi\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(801, 44, false);
#line 43 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"
       Write(Html.DisplayFor(model => model.StartingDate));

#line default
#line hidden
            EndContext();
            BeginContext(845, 91, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\tbitme tarihi\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(937, 39, false);
#line 49 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"
       Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(976, 90, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\tiş durumu\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(1067, 38, false);
#line 56 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 86, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\töncelik\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(1192, 40, false);
#line 62 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"
       Write(Html.DisplayFor(model => model.Priority));

#line default
#line hidden
            EndContext();
            BeginContext(1232, 39, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
            EndContext();
            BeginContext(1272, 46, false);
#line 65 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 40, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(1359, 38, false);
#line 68 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"
       Write(Model.CreateDate.ToString("dd/MM/yyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1397, 39, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
            EndContext();
            BeginContext(1437, 44, false);
#line 71 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateBy));

#line default
#line hidden
            EndContext();
            BeginContext(1481, 40, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(1522, 40, false);
#line 74 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"
       Write(Html.DisplayFor(model => model.CreateBy));

#line default
#line hidden
            EndContext();
            BeginContext(1562, 39, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
            EndContext();
            BeginContext(1602, 46, false);
#line 77 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdateDate));

#line default
#line hidden
            EndContext();
            BeginContext(1648, 40, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(1689, 38, false);
#line 80 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"
       Write(Model.UpdateDate.ToString("dd/MM/yyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1727, 43, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
            EndContext();
            BeginContext(1771, 45, false);
#line 84 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1816, 40, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(1857, 41, false);
#line 87 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1898, 38, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t</dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1936, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6397899fc143b3055b202e8272d60bf9da2e0ab013671", async() => {
                BeginContext(1982, 7, true);
                WriteLiteral("Düzenle");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 92 "C:\Users\ibr günay\source\repos\TaskManager\Views\Mission\Detail.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1993, 16, true);
            WriteLiteral(" \r\n\t<br />\r\n    ");
            EndContext();
            BeginContext(2009, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6397899fc143b3055b202e8272d60bf9da2e0ab016000", async() => {
                BeginContext(2031, 8, true);
                WriteLiteral("Geri Dön");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2043, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskManager.Models.Mission> Html { get; private set; }
    }
}
#pragma warning restore 1591
