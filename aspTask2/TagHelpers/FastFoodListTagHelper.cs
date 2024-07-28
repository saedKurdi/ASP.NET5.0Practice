using aspTask2.Entities;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;

namespace aspTask2.TagHelpers
{
    [HtmlTargetElement("fastfood-list")]
    public class FastFoodListTagHelper : TagHelper
    {
        const string fastFoodList = "fast-foods";

        [HtmlAttributeName(fastFoodList)]
        public List<FastFood> FastFoods { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ul";
            output.Attributes.SetAttribute("style", "display:flex;flex-wrap:wrap;gap:35px;align-items:center;justify-content:center;");
        }
    }
}
