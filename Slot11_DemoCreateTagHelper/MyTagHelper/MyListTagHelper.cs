
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using System.Collections.Generic;

namespace Slot11_DemoCreateTagHelper.MyTagHelper
{
    [HtmlTargetElement("mylist")]
    public class MyListTagHelper : TagHelper
    {
        public string ListTitle { get; set; }
        public List<String> ListItems { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ul";
            output.TagMode = TagMode.StartTagAndEndTag;

            output.Attributes.SetAttribute("class", "list-group");
            output.PreElement.AppendHtml($"<h2>{ListTitle}</h2>");

            StringBuilder content = new StringBuilder();
            foreach(var item in ListItems)
            {
                content.Append($@"<li class=""list-group-item"">{item}</li>");
            }
            output.Content.SetHtmlContent(content.ToString());
        }
    }
}
