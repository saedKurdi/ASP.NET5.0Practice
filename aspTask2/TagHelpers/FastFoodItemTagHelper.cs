using aspTask2.Entities;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace aspTask2.TagHelpers
{
    [HtmlTargetElement("fast-food")]
    public class FastFoodItemTagHelper : TagHelper
    {
        const string fastFood = "fastfood";

        [HtmlAttributeName(fastFood)]
        public FastFood FastFood { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "li";
            output.Attributes.SetAttribute("style", "padding:15px 20px;width:250px;height:480px;text-align:center;display:flex;flex-direction:column;gap:10px;justify-content:center;align-items:center;border-radius:12px;border:1px solid springgreen;");
            var content = $@"
<img width='150' height='100' src='{FastFood.ImagePath}' alt='{FastFood.Name}'/>
<h2 style='font-weight:bolder'>{FastFood.Name}</h2>
<p>Description : {FastFood.Description}</p>
<p style='color : green'>Discounted Price : ${FastFood.GetDiscountedPrice(FastFood.Discount,FastFood.Price)}</p>
<p style='color:mediumspringgreen'>Discount : {FastFood.Discount}%</p>
<a href='FastFood/Delete/{FastFood.Id}'>Delete</a>
<a href='FastFood/Edit/{FastFood.Id}'>Edit</a>
";
            output.Content.SetHtmlContent(content);
        }
    }
}
