#pragma checksum "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5826f9944b46eaacd75195455715c44444572dab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HotelDetails_HotelPage), @"mvc.1.0.view", @"/Views/HotelDetails/HotelPage.cshtml")]
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
#line 1 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\_ViewImports.cshtml"
using BookingWepApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\_ViewImports.cshtml"
using BookingWepApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
using BookingWepApp.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
using BookingWepApp.Models.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5826f9944b46eaacd75195455715c44444572dab", @"/Views/HotelDetails/HotelPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"127c65ebf908ec1052244ab1e89016241efc2e52", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_HotelDetails_HotelPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookingWepApp.Models.Hotel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HotelDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchRooms", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("collapse"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookRoom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: rgb(35, 110, 170)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
  
    var imageUrl = Model.ImageUrl;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    <div class=\"card mb-4 border-0\">\n        <h2>\n            ");
#nullable restore
#line 11 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
       Write(Model.Stars);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - звёздочный отель ");
#nullable restore
#line 11 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
                                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </h2>\n    </div>\n</div>\n\n<div class=\"card-deck\">\n            <div class=\"card mt-4\">\n                <p class=\"card-body text-justify\">\n                    ");
#nullable restore
#line 19 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
               Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </p>\n            </div>\n        </div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5826f9944b46eaacd75195455715c44444572dab8304", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5826f9944b46eaacd75195455715c44444572dab8564", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 25 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <div class=\"form-group\">\n        <div class=\"form-group\">\n            <div class=\"input-group mb-1\">\n                <input type=\"date\" id=\"checkInDate\" name=\"checkInDate\" placeholder=\"Дата заселения\"");
                BeginWriteAttribute("min", " min=\"", 891, "\"", 935, 1);
#nullable restore
#line 29 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
WriteAttributeValue("", 897, DateTime.Today.ToString("yyyy-MM-dd"), 897, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n                <input type=\"date\" id=\"checkOutDate\" name=\"checkOutDate\" placeholder=\"Дата выселения\"");
                BeginWriteAttribute("min", " min=\"", 1040, "\"", 1084, 1);
#nullable restore
#line 30 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
WriteAttributeValue("", 1046, DateTime.Today.ToString("yyyy-MM-dd"), 1046, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n                <button type=\"submit\" class=\"btn btn-success\" id=\"submit-btn\" style=\"background-color: rgb(35, 110, 170)\">Найти свободные номера</button>\n            </div>\n            <p>\r\n");
#nullable restore
#line 34 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
                 if (!string.IsNullOrEmpty(ViewBag.Error))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
               Write(Html.Label("error", (string)ViewBag.Error, new { @class = "alert alert-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
                                                                                                      
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </p>\n        </div>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
#nullable restore
#line 43 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
 if (ViewBag.DataInfo == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Задайте даты заселения и выселения, чтобы найти свободные номера.</h2>\n");
#nullable restore
#line 46 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
}
else if (ViewBag.RoomsAvailable == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>К сожалению, свободных номеров в выбранный период нет.</h2>\n");
#nullable restore
#line 50 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""d-flex container-hotel"">
    <div class=""carousel-container"">
        <div class=""border p-3 mt-3"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>Тип номера</th>
                        <th>Стоимость за ночь</th>
                        <th>Свободно номеров</th>
                        <th></th>
                    </tr>
");
#nullable restore
#line 64 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
                     foreach (var pair in ViewBag.RoomsAvailable as List<RoomItem>)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>\n                                ");
#nullable restore
#line 68 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
                           Write(RoomTypeDecoder.GetRoomTypeName(pair.RoomType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td class=\"mobile-room\">\n                                ");
#nullable restore
#line 71 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
                            Write(pair.AvailableRooms);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 71 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
                                                   Write(pair.TotalRooms);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n");
#nullable restore
#line 74 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
                                     if (pair.AvailableRooms == 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p class=\"text-danger\">Свободных номеров данного типа нет</p>\n");
#nullable restore
#line 77 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5826f9944b46eaacd75195455715c44444572dab17704", async() => {
                WriteLiteral("Забронировать");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-roomType", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
                                                                                                                                                   WriteLiteral(pair.RoomType);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomType"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-roomType", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomType"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
                                                                                                                                                                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 81 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\n                        </tr>\n");
#nullable restore
#line 84 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </thead>\n            </table>\n        </div>\n    </div>\n</div>\n");
#nullable restore
#line 90 "C:\Users\Nick\Documents\App\App\Source\BookingWepApp\Views\HotelDetails\HotelPage.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookingWepApp.Models.Hotel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591