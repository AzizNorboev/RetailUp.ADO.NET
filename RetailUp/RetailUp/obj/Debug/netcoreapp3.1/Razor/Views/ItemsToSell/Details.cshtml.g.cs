#pragma checksum "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4bc7be7b18765f589c3efa93a35e5ef128dc0ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ItemsToSell_Details), @"mvc.1.0.view", @"/Views/ItemsToSell/Details.cshtml")]
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
#line 1 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\_ViewImports.cshtml"
using RetailUp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\_ViewImports.cshtml"
using RetailUp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4bc7be7b18765f589c3efa93a35e5ef128dc0ca", @"/Views/ItemsToSell/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3865a8e729db543b1d111914a43a2b6fb2380c4a", @"/Views/_ViewImports.cshtml")]
    public class Views_ItemsToSell_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RetailUp.Models.ItemToSell>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>ItemToSell</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemToSellId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemToSellId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemBrand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemBrand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemAddedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemAddedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemCategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemCategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemRemained));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemRemained));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemLeft));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemLeft));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 82 "C:\Users\Admin\Documents\GitHub\RetailUp.ADO.NET\RetailUp\RetailUp\Views\ItemsToSell\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.ItemToSellId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4bc7be7b18765f589c3efa93a35e5ef128dc0ca11718", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RetailUp.Models.ItemToSell> Html { get; private set; }
    }
}
#pragma warning restore 1591
