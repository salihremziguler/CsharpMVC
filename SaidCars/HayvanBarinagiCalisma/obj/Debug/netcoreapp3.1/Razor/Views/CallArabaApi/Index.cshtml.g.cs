#pragma checksum "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\CallArabaApi\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ec1504dfa841c3037e0b308f52f5e9f0b8eace6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CallArabaApi_Index), @"mvc.1.0.view", @"/Views/CallArabaApi/Index.cshtml")]
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
#line 1 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\_ViewImports.cshtml"
using HayvanBarinagiCalisma;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\_ViewImports.cshtml"
using HayvanBarinagiCalisma.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\_ViewImports.cshtml"
using HayvanBarinagiCalisma.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec1504dfa841c3037e0b308f52f5e9f0b8eace6", @"/Views/CallArabaApi/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e683be7410fc89869e6b2849cfe61f58e2bbeed7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CallArabaApi_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HayvanBarinagiCalisma.Models.Araba>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\CallArabaApi\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Modeli 2010\'dan Büyük Araçlar</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\CallArabaApi\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Adi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\CallArabaApi\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n           \r\n            \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 30 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\CallArabaApi\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\CallArabaApi\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Adi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                \r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\CallArabaApi\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n               \r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\CallArabaApi\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HayvanBarinagiCalisma.Models.Araba>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
