#pragma checksum "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "232decb7870367fcaa51276a5829465aa10bbf61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Raports_Details), @"mvc.1.0.view", @"/Views/Raports/Details.cshtml")]
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
#line 1 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"232decb7870367fcaa51276a5829465aa10bbf61", @"/Views/Raports/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Raports_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcMovie.Models.SzczegolyRaportu>
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
#nullable restore
#line 2 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"up-det\">\r\n    <div class=\"up-det-left\">\r\n        <h2>Details</h2>\r\n    </div>\r\n    \r\n    <div class=\"up-det-right\">\r\n        <h3>\r\n            ");
#nullable restore
#line 13 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.produkt.typBadania));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            -\r\n            ");
#nullable restore
#line 15 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
       Write(Html.DisplayFor(model => model.produkt.typBadania));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>\r\n    </div>\r\n</div>\r\n<div class=\"lft-det\">\r\n    <div>   \r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class = \"dt-rap  det-rap2\">\r\n                ");
#nullable restore
#line 24 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.raport.NrRaportu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10 det-rap2\">\r\n                ");
#nullable restore
#line 27 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
           Write(Html.DisplayFor(model => model.raport.NrRaportu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <hr />\r\n            <dt class = \"dt-rap  det-rap2\">\r\n                ");
#nullable restore
#line 31 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.raport.DataRaportu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10 det-rap2\">\r\n                ");
#nullable restore
#line 34 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
           Write(Html.DisplayFor(model => model.raport.DataRaportu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <hr />\r\n            <dt class = \"dt-rap  det-rap2\">\r\n                ");
#nullable restore
#line 38 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.raport.Produkt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10 det-rap2\">\r\n                ");
#nullable restore
#line 41 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
           Write(Html.DisplayFor(model => model.raport.Produkt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <hr />\r\n            <dt class = \"dt-rap  det-rap2\">\r\n                ");
#nullable restore
#line 45 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.raport.Seria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10 det-rap2\">\r\n                ");
#nullable restore
#line 48 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
           Write(Html.DisplayFor(model => model.raport.Seria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "232decb7870367fcaa51276a5829465aa10bbf617775", async() => {
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
#line 53 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
                               WriteLiteral(Model.raport.id);

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
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "232decb7870367fcaa51276a5829465aa10bbf619937", async() => {
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
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"rht-det\">\r\n    <div class=\"dw-det\">\r\n        <hr/>\r\n        <table>\r\n            <thead>\r\n                <th class=\"det-rap\">\r\n                    ");
#nullable restore
#line 63 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.raport.Odczyt1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"det-rap\">\r\n                    ");
#nullable restore
#line 66 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.raport.Odczyt2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"det-rap\">\r\n                    ");
#nullable restore
#line 69 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.raport.Odczyt3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"det-rap\">\r\n                    ");
#nullable restore
#line 72 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.produkt.normaLow));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"det-rap\">\r\n                    ");
#nullable restore
#line 75 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.produkt.normaHigh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </thead>\r\n            <tbody>\r\n                <td class=\"wynik1 det-rap\"");
            BeginWriteAttribute("style", " style=\"", 2657, "\"", 2707, 2);
#nullable restore
#line 79 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
WriteAttributeValue("", 2665, Model.styl.TxtColor1, 2665, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
WriteAttributeValue(" ", 2686, Model.styl.BgColor1, 2687, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 80 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
               Write(Html.DisplayFor(model => model.raport.Odczyt1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"wynik2 det-rap\"");
            BeginWriteAttribute("style", " style=\"", 2845, "\"", 2895, 2);
#nullable restore
#line 82 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
WriteAttributeValue("", 2853, Model.styl.TxtColor2, 2853, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
WriteAttributeValue(" ", 2874, Model.styl.BgColor2, 2875, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 83 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
               Write(Html.DisplayFor(model => model.raport.Odczyt2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"wynik3 det-rap\"");
            BeginWriteAttribute("style", " style=\"", 3033, "\"", 3083, 2);
#nullable restore
#line 85 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
WriteAttributeValue("", 3041, Model.styl.TxtColor3, 3041, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
WriteAttributeValue(" ", 3062, Model.styl.BgColor3, 3063, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 86 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
               Write(Html.DisplayFor(model => model.raport.Odczyt3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"det-rap\">\r\n                    ");
#nullable restore
#line 89 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
               Write(Html.DisplayFor(model => model.produkt.normaLow));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"det-rap\">\r\n                    ");
#nullable restore
#line 92 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
               Write(Html.DisplayFor(model => model.produkt.normaHigh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"deltarap\"");
            BeginWriteAttribute("style", " style=\"", 3480, "\"", 3511, 1);
#nullable restore
#line 94 "D:\VSCODE-portable\Projekty\WebDev\MVC_Project\MvcMovie\Views\Raports\Details.cshtml"
WriteAttributeValue("", 3488, Model.styl.StatusNormy, 3488, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <b>\r\n                        Normy Przekroczone!!!\r\n                    </b>\r\n                </td>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcMovie.Models.SzczegolyRaportu> Html { get; private set; }
    }
}
#pragma warning restore 1591
