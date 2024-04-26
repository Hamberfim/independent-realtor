using Microsoft.AspNetCore.Razor.TagHelpers;

namespace IndependentRealtorApp.Areas.Admin.TagHelpers
{
    [HtmlTargetElement("button", Attributes = "id,name,asp-controller,asp-action")]
    public class DeleteButton : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (context.AllAttributes["id"].Value.ToString() == "delete" &&
                context.AllAttributes["name"].Value.ToString() == "delete" &&
                context.AllAttributes["asp-controller"].Value.ToString() == "Property" &&
                context.AllAttributes["asp-action"].Value.ToString() == "Delete")
            {
                output.Attributes.SetAttribute("class", "btn btn-outline-danger btn-sm");
            }
        }
    }
}