#pragma checksum "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Admin\ArabaDuzenle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72c0445f9e507ed574c3cd207903840cf8bec7ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ArabaDuzenle), @"mvc.1.0.view", @"/Views/Admin/ArabaDuzenle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72c0445f9e507ed574c3cd207903840cf8bec7ec", @"/Views/Admin/ArabaDuzenle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e683be7410fc89869e6b2849cfe61f58e2bbeed7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_ArabaDuzenle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArabalarTurMarkaViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ArabaSil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ArabaUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Admin\ArabaDuzenle.cshtml"
  
    ViewData["Title"] = "Araba Düzenle";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Hayvanlar</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Resim</th>
                            <th>Adı</th>
                            <th>Türü</th>
                            <th>Markası</th>
                            <th>Modeli</th>
                            <th>Hasarlı mı?</th>
                            <th>Ek Açıklama</th>
                            <th>Rezerve Durumu</th>
                            <th>İşlem</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 28 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Admin\ArabaDuzenle.cshtml"
                           int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Admin\ArabaDuzenle.cshtml"
                         foreach (var t in Model.Araba)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td><img");
            BeginWriteAttribute("src", " src=\"", 1204, "\"", 1217, 1);
#nullable restore
#line 33 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Admin\ArabaDuzenle.cshtml"
WriteAttributeValue("", 1210, t.Foto, 1210, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" /></td>\n                            <td>");
#nullable restore
#line 34 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Admin\ArabaDuzenle.cshtml"
                           Write(t.Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 35 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Admin\ArabaDuzenle.cshtml"
                           Write(Model.Tur.Where(x => x.TurId == t.TurId).FirstOrDefault().TurAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 36 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Admin\ArabaDuzenle.cshtml"
                           Write(Model.Marka.Where(x => x.MarkaId == t.MarkaId).FirstOrDefault().MarkaAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 37 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Admin\ArabaDuzenle.cshtml"
                           Write(t.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 38 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Admin\ArabaDuzenle.cshtml"
                             if (t.HasarliMi)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Hasarlı</td>\n");
#nullable restore
#line 41 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Admin\ArabaDuzenle.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Hasarlı Değil</td>\n");
#nullable restore
#line 45 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Admin\ArabaDuzenle.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 46 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Admin\ArabaDuzenle.cshtml"
                           Write(t.EkBilgiler);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 47 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Admin\ArabaDuzenle.cshtml"
                             if (t.RezerveMi)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Rezerve Edildi</td>\n");
#nullable restore
#line 50 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Admin\ArabaDuzenle.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Rezerve Edilmedi</td>\n");
#nullable restore
#line 54 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Admin\ArabaDuzenle.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72c0445f9e507ed574c3cd207903840cf8bec7ec11318", async() => {
                WriteLiteral("Sil");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Admin\ArabaDuzenle.cshtml"
                                                                                                            WriteLiteral(t.ArabaId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72c0445f9e507ed574c3cd207903840cf8bec7ec13897", async() => {
                WriteLiteral("Güncelle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Admin\ArabaDuzenle.cshtml"
                                                                                                             WriteLiteral(t.ArabaId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </td>\n                        </tr>\n");
#nullable restore
#line 60 "C:\Users\slhgl\Desktop\WebProgramlamaProje-master\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Admin\ArabaDuzenle.cshtml"
                            i++;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                    </tbody>\n                </table>\n            </div>\n        </div>\n    </div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArabalarTurMarkaViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591