#pragma checksum "C:\Users\natal\Desktop\ALKEMY\WarmUpAlkemy\ChallengeBlog\MyBlog\MyBlog\Views\BlogsDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "846bc3f37faf8db1e3eec0bd8a59052b56093e00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BlogsDetails_Index), @"mvc.1.0.view", @"/Views/BlogsDetails/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BlogsDetails/Index.cshtml", typeof(AspNetCore.Views_BlogsDetails_Index))]
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
#line 1 "C:\Users\natal\Desktop\ALKEMY\WarmUpAlkemy\ChallengeBlog\MyBlog\MyBlog\Views\_ViewImports.cshtml"
using MyBlog;

#line default
#line hidden
#line 2 "C:\Users\natal\Desktop\ALKEMY\WarmUpAlkemy\ChallengeBlog\MyBlog\MyBlog\Views\_ViewImports.cshtml"
using MyBlog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"846bc3f37faf8db1e3eec0bd8a59052b56093e00", @"/Views/BlogsDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b889b3f4308041dc292b61010b9c4781c7386c2", @"/Views/_ViewImports.cshtml")]
    public class Views_BlogsDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyBlog.Models.BlogDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("160"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BlogsDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\natal\Desktop\ALKEMY\WarmUpAlkemy\ChallengeBlog\MyBlog\MyBlog\Views\BlogsDetails\Index.cshtml"
  
    ViewData["Title"] = "Lista de Blogs";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(148, 226, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\" >\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <br />\r\n            <h3>Lista de Blogs</h3>\r\n            <br />\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div class=\"row\" >\r\n\r\n");
            EndContext();
#line 25 "C:\Users\natal\Desktop\ALKEMY\WarmUpAlkemy\ChallengeBlog\MyBlog\MyBlog\Views\BlogsDetails\Index.cshtml"
         if(Model.Count() > 0)


         {


        

                

#line default
#line hidden
#line 33 "C:\Users\natal\Desktop\ALKEMY\WarmUpAlkemy\ChallengeBlog\MyBlog\MyBlog\Views\BlogsDetails\Index.cshtml"
                 foreach (var item in Model)

                {

                    


#line default
#line hidden
            BeginContext(531, 469, true);
            WriteLiteral(@"                    <ItemTemplate>
                        <div class=""col-sm-4 col-lg-4 col-md-4"" runat=""server"" >
                            <div class=""thumbnail"" style=""text-align: center; background-color:grey; width:300px; height:400px; "" runat=""server"" >

                                <div>
                                    <br />
                                    <div class=""caption"" runat=""server"">
                                        <H3>");
            EndContext();
            BeginContext(1001, 10, false);
#line 46 "C:\Users\natal\Desktop\ALKEMY\WarmUpAlkemy\ChallengeBlog\MyBlog\MyBlog\Views\BlogsDetails\Index.cshtml"
                                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1011, 51, true);
            WriteLiteral("</H3>\r\n                                        <H4>");
            EndContext();
            BeginContext(1063, 17, false);
#line 47 "C:\Users\natal\Desktop\ALKEMY\WarmUpAlkemy\ChallengeBlog\MyBlog\MyBlog\Views\BlogsDetails\Index.cshtml"
                                       Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(1080, 50, true);
            WriteLiteral("</H4>\r\n                                        <p>");
            EndContext();
            BeginContext(1131, 17, false);
#line 48 "C:\Users\natal\Desktop\ALKEMY\WarmUpAlkemy\ChallengeBlog\MyBlog\MyBlog\Views\BlogsDetails\Index.cshtml"
                                      Write(item.CreationDate);

#line default
#line hidden
            EndContext();
            BeginContext(1148, 132, true);
            WriteLiteral("</p>\r\n\r\n                                    </div>\r\n                                    <br />\r\n                                    ");
            EndContext();
            BeginContext(1280, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e79d6050c2f5402b8093452fa6c49821", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1291, "~/BlogsDetails/Picture?id=", 1291, 26, true);
#line 52 "C:\Users\natal\Desktop\ALKEMY\WarmUpAlkemy\ChallengeBlog\MyBlog\MyBlog\Views\BlogsDetails\Index.cshtml"
AddHtmlAttributeValue("", 1317, item.Id, 1317, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1367, 193, true);
            WriteLiteral("\r\n                                  \r\n                             \r\n                                    <br />\r\n                                    <br />\r\n                                    ");
            EndContext();
            BeginContext(1560, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fa5cde3cef04065944ad57fd01bb9b5", async() => {
                BeginContext(1662, 7, true);
                WriteLiteral("Detalle");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\natal\Desktop\ALKEMY\WarmUpAlkemy\ChallengeBlog\MyBlog\MyBlog\Views\BlogsDetails\Index.cshtml"
                                                                                            WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1673, 239, true);
            WriteLiteral("\r\n                                    <br />\r\n                                    <br />\r\n\r\n                                </div>\r\n\r\n                            </div>\r\n                        </div>\r\n                    </ItemTemplate>\r\n");
            EndContext();
#line 66 "C:\Users\natal\Desktop\ALKEMY\WarmUpAlkemy\ChallengeBlog\MyBlog\MyBlog\Views\BlogsDetails\Index.cshtml"



                                  

}

#line default
#line hidden
#line 71 "C:\Users\natal\Desktop\ALKEMY\WarmUpAlkemy\ChallengeBlog\MyBlog\MyBlog\Views\BlogsDetails\Index.cshtml"
 

         }

        else
        {


#line default
#line hidden
            BeginContext(2002, 52, true);
            WriteLiteral("            <p>No existen Blogs por el momento</p>\r\n");
            EndContext();
#line 79 "C:\Users\natal\Desktop\ALKEMY\WarmUpAlkemy\ChallengeBlog\MyBlog\MyBlog\Views\BlogsDetails\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(2067, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyBlog.Models.BlogDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
