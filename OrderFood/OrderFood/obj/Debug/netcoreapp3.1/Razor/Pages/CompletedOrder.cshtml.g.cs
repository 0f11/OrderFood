#pragma checksum "C:\Users\eparrom\OrderFood\OrderFood\OrderFood\Pages\CompletedOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51726a81739391c6c6c602c0dc606e46cda74466"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OrderFood.Pages.Pages_CompletedOrder), @"mvc.1.0.razor-page", @"/Pages/CompletedOrder.cshtml")]
namespace OrderFood.Pages
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
#line 1 "C:\Users\eparrom\OrderFood\OrderFood\OrderFood\Pages\_ViewImports.cshtml"
using OrderFood;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51726a81739391c6c6c602c0dc606e46cda74466", @"/Pages/CompletedOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be9a961722afe7a5c1235af89f21ff27de37985d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CompletedOrder : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<table class=\"table table-bordered\" style=\"width: initial;\">\r\n    <hr>\r\n    <h1>Completed order</h1>\r\n    <hr>\r\n    Thank you for your order ");
#nullable restore
#line 7 "C:\Users\eparrom\OrderFood\OrderFood\OrderFood\Pages\CompletedOrder.cshtml"
                        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" !\r\n    <hr>\r\n    <tr>\r\n        <th>Meal</th>\r\n        <th>Price</th>\r\n    </tr>\r\n");
#nullable restore
#line 13 "C:\Users\eparrom\OrderFood\OrderFood\OrderFood\Pages\CompletedOrder.cshtml"
     foreach (var item in Model.OrderedItems2)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 17 "C:\Users\eparrom\OrderFood\OrderFood\OrderFood\Pages\CompletedOrder.cshtml"
           Write(Html.DisplayFor(modelItem => item.FoodItem.FoodItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 20 "C:\Users\eparrom\OrderFood\OrderFood\OrderFood\Pages\CompletedOrder.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sum));

#line default
#line hidden
#nullable disable
            WriteLiteral("EUR\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 23 "C:\Users\eparrom\OrderFood\OrderFood\OrderFood\Pages\CompletedOrder.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<hr>\r\nTotal amount = ");
#nullable restore
#line 26 "C:\Users\eparrom\OrderFood\OrderFood\OrderFood\Pages\CompletedOrder.cshtml"
          Write(Model.Sum);

#line default
#line hidden
#nullable disable
            WriteLiteral(" EUR\r\n<hr>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51726a81739391c6c6c602c0dc606e46cda744665410", async() => {
                WriteLiteral("Exit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderFood.CompletedOrder> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OrderFood.CompletedOrder> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OrderFood.CompletedOrder>)PageContext?.ViewData;
        public OrderFood.CompletedOrder Model => ViewData.Model;
    }
}
#pragma warning restore 1591
