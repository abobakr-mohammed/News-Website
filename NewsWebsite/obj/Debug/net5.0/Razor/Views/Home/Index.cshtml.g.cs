#pragma checksum "C:\Users\bebom\source\repos\FullStackProjects\NewsWebsite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55c2d4ae543bd4ebff04deca8640f402dcbaa487"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\bebom\source\repos\FullStackProjects\NewsWebsite\Views\_ViewImports.cshtml"
using CoreLogic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c2d4ae543bd4ebff04deca8640f402dcbaa487", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f21601677a32d04aff15eadd5990b858549e6ba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\bebom\source\repos\FullStackProjects\NewsWebsite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- ======= Featured Services Section ======= -->\r\n<section id=\"featured-services\" class=\"featured-services\">\r\n    <div class=\"container\" data-aos=\"fade-up\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\bebom\source\repos\FullStackProjects\NewsWebsite\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {
          


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-6 col-lg-3 d-flex align-items-stretch mb-5 mb-lg-0"">
                        <div class=""icon-box"" data-aos=""fade-up"" style=""width:100% "" data-aos-delay=""100"">
                            <center>
                                <div class=""icon""><i class=""fas fa-heartbeat""></i></div>
                                <h4 class=""title"">");
#nullable restore
#line 18 "C:\Users\bebom\source\repos\FullStackProjects\NewsWebsite\Views\Home\Index.cshtml"
                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p class=\"description\"><a");
            BeginWriteAttribute("href", " href=\"", 777, "\"", 802, 2);
            WriteAttributeValue("", 784, "Home/News/", 784, 10, true);
#nullable restore
#line 19 "C:\Users\bebom\source\repos\FullStackProjects\NewsWebsite\Views\Home\Index.cshtml"
WriteAttributeValue("", 794, item.ID, 794, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\Users\bebom\source\repos\FullStackProjects\NewsWebsite\Views\Home\Index.cshtml"
                                                                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                                <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 889, "\"", 914, 2);
            WriteAttributeValue("", 896, "Home/News/", 896, 10, true);
#nullable restore
#line 20 "C:\Users\bebom\source\repos\FullStackProjects\NewsWebsite\Views\Home\Index.cshtml"
WriteAttributeValue("", 906, item.ID, 906, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">المزيد </a>\r\n                            </center>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 24 "C:\Users\bebom\source\repos\FullStackProjects\NewsWebsite\Views\Home\Index.cshtml"
               
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</section><!-- End Featured Services Section -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591