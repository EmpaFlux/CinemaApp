#pragma checksum "C:\Users\Emil\CinemaApp\CinemaApp\Views\Screenings\BookingConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9c124581955320e4bdb34dffd6d8874a401d006"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Screenings_BookingConfirmation), @"mvc.1.0.view", @"/Views/Screenings/BookingConfirmation.cshtml")]
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
#line 1 "C:\Users\Emil\CinemaApp\CinemaApp\Views\_ViewImports.cshtml"
using CinemaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emil\CinemaApp\CinemaApp\Views\_ViewImports.cshtml"
using CinemaApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9c124581955320e4bdb34dffd6d8874a401d006", @"/Views/Screenings/BookingConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8084176d599023adc56a4b10a115bd11b8f0b29", @"/Views/_ViewImports.cshtml")]
    public class Views_Screenings_BookingConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CinemaApp.Models.Screening>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Emil\CinemaApp\CinemaApp\Views\Screenings\BookingConfirmation.cshtml"
  
    ViewData["Title"] = "Booking Confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Booking Confirmation</h2>\r\n\r\n<div class=\"details\">\r\n    <div class=\"bookTicketImg\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 196, "\"", 244, 1);
#nullable restore
#line 11 "C:\Users\Emil\CinemaApp\CinemaApp\Views\Screenings\BookingConfirmation.cshtml"
WriteAttributeValue("", 202, Html.DisplayFor(model => @model.ImageUrl), 202, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"detailsText\">\r\n        <dl>\r\n            <dt>\r\n                ");
#nullable restore
#line 16 "C:\Users\Emil\CinemaApp\CinemaApp\Views\Screenings\BookingConfirmation.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 19 "C:\Users\Emil\CinemaApp\CinemaApp\Views\Screenings\BookingConfirmation.cshtml"
           Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 22 "C:\Users\Emil\CinemaApp\CinemaApp\Views\Screenings\BookingConfirmation.cshtml"
           Write(Html.DisplayNameFor(model => model.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 25 "C:\Users\Emil\CinemaApp\CinemaApp\Views\Screenings\BookingConfirmation.cshtml"
           Write(Html.DisplayFor(model => model.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 28 "C:\Users\Emil\CinemaApp\CinemaApp\Views\Screenings\BookingConfirmation.cshtml"
           Write(Html.DisplayNameFor(model => model.Auditorium));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 31 "C:\Users\Emil\CinemaApp\CinemaApp\Views\Screenings\BookingConfirmation.cshtml"
           Write(Html.DisplayFor(model => model.Auditorium.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n        <hr />\r\n        <h3>Thank you for the purchase!</h3>\r\n    </div>\r\n</div>\r\n\r\n<hr />\r\n<div class=\"detailsLinks\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9c124581955320e4bdb34dffd6d8874a401d0066270", async() => {
                WriteLiteral("Return to Movies");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CinemaApp.Models.Screening> Html { get; private set; }
    }
}
#pragma warning restore 1591
