#pragma checksum "C:\Users\DELL\source\Okay Realty\OkayRealty\Pages\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b81d7c879e8f7a25ce0cab98eaf40d7af53916ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OkayRealty.Pages.Pages_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Contact.cshtml", typeof(OkayRealty.Pages.Pages_Contact), null)]
namespace OkayRealty.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\DELL\source\Okay Realty\OkayRealty\Pages\_ViewImports.cshtml"
using OkayRealty;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b81d7c879e8f7a25ce0cab98eaf40d7af53916ed", @"/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8ab99f024c3151b63fa8f072e489988f1fe605b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\DELL\source\Okay Realty\OkayRealty\Pages\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(71, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(76, 17, false);
#line 6 "C:\Users\DELL\source\Okay Realty\OkayRealty\Pages\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(93, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(105, 13, false);
#line 7 "C:\Users\DELL\source\Okay Realty\OkayRealty\Pages\Contact.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(118, 361, true);
            WriteLiteral(@"</h3>

<address>
    Somewhere in Nigeria<br />
    X-Mansion, +234Getat<br />
    <abbr title=""Phone"">P:</abbr>
    MM-XXIX
</address>

<address>
    <strong>Support:</strong> <a href=""mailto:Support@example.com"">water@gmail.com</a><br />
    <strong>Marketing:</strong> <a href=""mailto:Marketing@example.com"">RoguesSquad@gmail.com</a>
</address>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel>)PageContext?.ViewData;
        public ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
