#pragma checksum "D:\Users\bialaporcelana\Desktop\szkola\net\WebApplication1\WebApplication1\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "658c89801928855ac5b558e2ca069535e22bd428"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 2 "D:\Users\bialaporcelana\Desktop\szkola\net\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#line 3 "D:\Users\bialaporcelana\Desktop\szkola\net\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"658c89801928855ac5b558e2ca069535e22bd428", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1bad0631b87d57982f79cc6d19d6596bc677ac4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(19, 10, false);
#line 3 "D:\Users\bialaporcelana\Desktop\szkola\net\WebApplication1\WebApplication1\Views\Home\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(29, 40, true);
            WriteLiteral("</h2>\r\n<div class=\"thumbnail\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 69, "\"", 90, 1);
#line 5 "D:\Users\bialaporcelana\Desktop\szkola\net\WebApplication1\WebApplication1\Views\Home\Details.cshtml"
WriteAttributeValue("", 75, Model.ImageUrl, 75, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 91, "\"", 108, 1);
#line 5 "D:\Users\bialaporcelana\Desktop\szkola\net\WebApplication1\WebApplication1\Views\Home\Details.cshtml"
WriteAttributeValue("", 97, Model.Name, 97, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(109, 49, true);
            WriteLiteral(" />\r\n    <div class=\"caption-full\">\r\n        <h3>");
            EndContext();
            BeginContext(159, 11, false);
#line 7 "D:\Users\bialaporcelana\Desktop\szkola\net\WebApplication1\WebApplication1\Views\Home\Details.cshtml"
       Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(170, 31, true);
            WriteLiteral("</h3>\r\n        <h3><a href=\"#\">");
            EndContext();
            BeginContext(202, 10, false);
#line 8 "D:\Users\bialaporcelana\Desktop\szkola\net\WebApplication1\WebApplication1\Views\Home\Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(212, 23, true);
            WriteLiteral("</a></h3>\r\n        <h4>");
            EndContext();
            BeginContext(236, 22, false);
#line 9 "D:\Users\bialaporcelana\Desktop\szkola\net\WebApplication1\WebApplication1\Views\Home\Details.cshtml"
       Write(Model.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(258, 18, true);
            WriteLiteral("</h4>\r\n        <p>");
            EndContext();
            BeginContext(277, 21, false);
#line 10 "D:\Users\bialaporcelana\Desktop\szkola\net\WebApplication1\WebApplication1\Views\Home\Details.cshtml"
      Write(Model.LongDescription);

#line default
#line hidden
            EndContext();
            BeginContext(298, 28, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pie> Html { get; private set; }
    }
}
#pragma warning restore 1591
