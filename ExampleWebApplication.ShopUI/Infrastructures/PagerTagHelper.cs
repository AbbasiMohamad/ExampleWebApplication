using ExampleWebApplication.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ExampleWebApplication.ShopUI.Infrastructures;

//اینجا میگوییم هدف ما چه المانی در صفحه با چه خصیصه ای است
[HtmlTargetElement("div", Attributes = "paged-model")] 
public class PagerTagHelper: TagHelper
{
    private readonly IUrlHelperFactory _urlHelperFactory;

    public PagerTagHelper(IUrlHelperFactory urlHelperFactory)
    {
        _urlHelperFactory = urlHelperFactory;
    }

    [ViewContext]
    [HtmlAttributeNotBound]
    public ViewContext ViewContext { get; set; }
    public PageInfo PagedModel { get; set; }
    public string PageAction { get; set; }
    public string PageClass { get; set; }
    public string PageClassSelected { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        IUrlHelper urlHelper = _urlHelperFactory.GetUrlHelper(ViewContext);
        TagBuilder finalTag = new TagBuilder("div");
        for (int i = 1; i <= PagedModel.PageCount; i++)
        {
            TagBuilder linkTag = new("a");
            linkTag.Attributes["href"] = urlHelper.Action(PageAction, new { pageNumber = i });
            
            linkTag.AddCssClass(PageClass);
            if (i == PagedModel.PageNumber)
                linkTag.AddCssClass(PageClassSelected);

            linkTag.InnerHtml.Append(i.ToString());
            finalTag.InnerHtml.AppendHtml(linkTag);
        }
        output.Content.AppendHtml(finalTag.InnerHtml);

    }
}
