using Microsoft.AspNetCore.Razor.TagHelpers;

namespace IndependentRealtorApp.Areas.Admin.TagHelpers
{
    // TODO: FIX THIS, Doesn't seem to be working
    [HtmlTargetElement("button", Attributes = "id=delete,name=delete,asp-controller=Property,asp-action=Delete")]
    public class DeleteButton : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", "btn btn-danger btn-sm");
        }
    }
}
