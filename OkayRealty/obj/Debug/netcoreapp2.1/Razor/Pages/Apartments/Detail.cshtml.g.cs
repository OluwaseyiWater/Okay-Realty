#pragma checksum "C:\Users\DELL\source\Okay Realty\OkayRealty\Pages\Apartments\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcaaec20688a7b86d0481b5d9dee1deca96597c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OkayRealty.Pages.Apartments.Pages_Apartments_Detail), @"mvc.1.0.razor-page", @"/Pages/Apartments/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Apartments/Detail.cshtml", typeof(OkayRealty.Pages.Apartments.Pages_Apartments_Detail), @"{apartmentId:int}")]
namespace OkayRealty.Pages.Apartments
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{apartmentId:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcaaec20688a7b86d0481b5d9dee1deca96597c5", @"/Pages/Apartments/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8ab99f024c3151b63fa8f072e489988f1fe605b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Apartments_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\DELL\source\Okay Realty\OkayRealty\Pages\Apartments\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(119, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(126, 20, false);
#line 8 "C:\Users\DELL\source\Okay Realty\OkayRealty\Pages\Apartments\Detail.cshtml"
Write(Model.Apartment.Name);

#line default
#line hidden
            EndContext();
            BeginContext(146, 22, true);
            WriteLiteral("</h2>\r\n<div>\r\n    Id: ");
            EndContext();
            BeginContext(169, 18, false);
#line 10 "C:\Users\DELL\source\Okay Realty\OkayRealty\Pages\Apartments\Detail.cshtml"
   Write(Model.Apartment.Id);

#line default
#line hidden
            EndContext();
            BeginContext(187, 31, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Location: ");
            EndContext();
            BeginContext(219, 24, false);
#line 13 "C:\Users\DELL\source\Okay Realty\OkayRealty\Pages\Apartments\Detail.cshtml"
         Write(Model.Apartment.Location);

#line default
#line hidden
            EndContext();
            BeginContext(243, 30, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Cuisine: ");
            EndContext();
            BeginContext(274, 24, false);
#line 16 "C:\Users\DELL\source\Okay Realty\OkayRealty\Pages\Apartments\Detail.cshtml"
        Write(Model.Apartment.Building);

#line default
#line hidden
            EndContext();
            BeginContext(298, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
#line 19 "C:\Users\DELL\source\Okay Realty\OkayRealty\Pages\Apartments\Detail.cshtml"
 if (Model.Message != null)
{

#line default
#line hidden
            BeginContext(342, 34, true);
            WriteLiteral("    <div class=\"alert alert-info\">");
            EndContext();
            BeginContext(377, 13, false);
#line 21 "C:\Users\DELL\source\Okay Realty\OkayRealty\Pages\Apartments\Detail.cshtml"
                             Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(390, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 22 "C:\Users\DELL\source\Okay Realty\OkayRealty\Pages\Apartments\Detail.cshtml"
}

#line default
#line hidden
            BeginContext(401, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(403, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b458e71568746a38b02583d5c73ab46", async() => {
                BeginContext(448, 14, true);
                WriteLiteral("All Apartments");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(466, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OkayRealty.Pages.Apartments.DetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OkayRealty.Pages.Apartments.DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OkayRealty.Pages.Apartments.DetailModel>)PageContext?.ViewData;
        public OkayRealty.Pages.Apartments.DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591