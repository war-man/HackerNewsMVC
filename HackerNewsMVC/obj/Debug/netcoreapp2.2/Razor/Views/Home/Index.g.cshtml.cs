#pragma checksum "C:\Users\Sean\source\repos\HackerNewsMVC\HackerNewsMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54333bafe2562325494e95237259d451ac849124"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Sean\source\repos\HackerNewsMVC\HackerNewsMVC\Views\_ViewImports.cshtml"
using HackerNewsMVC;

#line default
#line hidden
#line 2 "C:\Users\Sean\source\repos\HackerNewsMVC\HackerNewsMVC\Views\_ViewImports.cshtml"
using HackerNewsMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54333bafe2562325494e95237259d451ac849124", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87d684d6e44c837201531172b9b66cfb0219ff6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HackerNewsMVC.Models.StoryModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Sean\source\repos\HackerNewsMVC\HackerNewsMVC\Views\Home\Index.cshtml"
  
        ViewData["Title"] = "Home Page";
    

#line default
#line hidden
            BeginContext(108, 61, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(170, 38, false);
#line 10 "C:\Users\Sean\source\repos\HackerNewsMVC\HackerNewsMVC\Views\Home\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.by));

#line default
#line hidden
            EndContext();
            BeginContext(208, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(252, 41, false);
#line 13 "C:\Users\Sean\source\repos\HackerNewsMVC\HackerNewsMVC\Views\Home\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.title));

#line default
#line hidden
            EndContext();
            BeginContext(293, 47, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n");
            EndContext();
#line 17 "C:\Users\Sean\source\repos\HackerNewsMVC\HackerNewsMVC\Views\Home\Index.cshtml"
     foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(377, 36, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(414, 37, false);
#line 21 "C:\Users\Sean\source\repos\HackerNewsMVC\HackerNewsMVC\Views\Home\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.by));

#line default
#line hidden
            EndContext();
            BeginContext(451, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(495, 60, false);
#line 24 "C:\Users\Sean\source\repos\HackerNewsMVC\HackerNewsMVC\Views\Home\Index.cshtml"
       Write(Html.ActionLink(item.title, "Details", new { id = item.id }));

#line default
#line hidden
            EndContext();
            BeginContext(555, 28, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 27 "C:\Users\Sean\source\repos\HackerNewsMVC\HackerNewsMVC\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(590, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HackerNewsMVC.Models.StoryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
