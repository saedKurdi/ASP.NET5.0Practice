#pragma checksum "C:\Users\Asus\OneDrive\Рабочий стол\IT STEP\My Drive\ASP.NET\ELVIN CAMALZADE\Tasks\aspTask2\aspTask2\Views\FastFood\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a96ae80c58f09a9d379aa3f5e63b1cda6fee1584eec553779d02f00191c5c5da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FastFood_Index), @"mvc.1.0.view", @"/Views/FastFood/Index.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\Asus\OneDrive\Рабочий стол\IT STEP\My Drive\ASP.NET\ELVIN CAMALZADE\Tasks\aspTask2\aspTask2\Views\_ViewImports.cshtml"
using aspTask2.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a96ae80c58f09a9d379aa3f5e63b1cda6fee1584eec553779d02f00191c5c5da", @"/Views/FastFood/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"603f0eb2a84e458ac21bfae0b88d04e27e2231478066aca9c89405f415c8bc3b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_FastFood_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FastFoodsViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FastFood", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::aspTask2.TagHelpers.FastFoodListTagHelper __aspTask2_TagHelpers_FastFoodListTagHelper;
        private global::aspTask2.TagHelpers.FastFoodItemTagHelper __aspTask2_TagHelpers_FastFoodItemTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("fastfood-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a96ae80c58f09a9d379aa3f5e63b1cda6fee1584eec553779d02f00191c5c5da3984", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Asus\OneDrive\Рабочий стол\IT STEP\My Drive\ASP.NET\ELVIN CAMALZADE\Tasks\aspTask2\aspTask2\Views\FastFood\Index.cshtml"
     foreach (var fastFood in Model.FastFoods)
    {

#line default
#line hidden
#nullable disable

                WriteLiteral("       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("fast-food", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a96ae80c58f09a9d379aa3f5e63b1cda6fee1584eec553779d02f00191c5c5da4583", async() => {
                    WriteLiteral("\r\n       ");
                }
                );
                __aspTask2_TagHelpers_FastFoodItemTagHelper = CreateTagHelper<global::aspTask2.TagHelpers.FastFoodItemTagHelper>();
                __tagHelperExecutionContext.Add(__aspTask2_TagHelpers_FastFoodItemTagHelper);
                __aspTask2_TagHelpers_FastFoodItemTagHelper.FastFood = 
#nullable restore
#line 5 "C:\Users\Asus\OneDrive\Рабочий стол\IT STEP\My Drive\ASP.NET\ELVIN CAMALZADE\Tasks\aspTask2\aspTask2\Views\FastFood\Index.cshtml"
                             fastFood

#line default
#line hidden
#nullable disable
                ;
                __tagHelperExecutionContext.AddTagHelperAttribute("fastfood", __aspTask2_TagHelpers_FastFoodItemTagHelper.FastFood, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Asus\OneDrive\Рабочий стол\IT STEP\My Drive\ASP.NET\ELVIN CAMALZADE\Tasks\aspTask2\aspTask2\Views\FastFood\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            }
            );
            __aspTask2_TagHelpers_FastFoodListTagHelper = CreateTagHelper<global::aspTask2.TagHelpers.FastFoodListTagHelper>();
            __tagHelperExecutionContext.Add(__aspTask2_TagHelpers_FastFoodListTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a96ae80c58f09a9d379aa3f5e63b1cda6fee1584eec553779d02f00191c5c5da7041", async() => {
                WriteLiteral("Add New Product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FastFoodsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
