#pragma checksum "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\BeltExam\Views\Home\ActInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ecb2513061335ad35176cd58828b7d79195e880"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ActInfo), @"mvc.1.0.view", @"/Views/Home/ActInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ActInfo.cshtml", typeof(AspNetCore.Views_Home_ActInfo))]
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
#line 1 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\BeltExam\Views\_ViewImports.cshtml"
using BeltExam;

#line default
#line hidden
#line 2 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\BeltExam\Views\_ViewImports.cshtml"
using BeltExam.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ecb2513061335ad35176cd58828b7d79195e880", @"/Views/Home/ActInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a84119000702c45f5036e3e300b27d647b6aca13", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ActInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Activities>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ecb2513061335ad35176cd58828b7d79195e8803383", async() => {
                BeginContext(41, 194, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    <title>Document</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(242, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(244, 1086, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ecb2513061335ad35176cd58828b7d79195e8804776", async() => {
                BeginContext(250, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(275, 51, true);
                WriteLiteral("    <div>\r\n        Dojo Activity Center\r\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 326, "\"", 350, 2);
                WriteAttributeValue("", 333, "/home/", 333, 6, true);
#line 13 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\BeltExam\Views\Home\ActInfo.cshtml"
WriteAttributeValue("", 339, ViewBag.id, 339, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(351, 92, true);
                WriteLiteral(">Home</a>\r\n        <a href=\"/logout\">Log Out</a>\r\n    </div>\r\n    <div>\r\n        <h1>Event: ");
                EndContext();
                BeginContext(444, 11, false);
#line 17 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\BeltExam\Views\Home\ActInfo.cshtml"
              Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(455, 7, true);
                WriteLiteral("</h1>\r\n");
                EndContext();
#line 18 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\BeltExam\Views\Home\ActInfo.cshtml"
         if(ViewBag.id == Model.UserId)
                        {

#line default
#line hidden
                BeginContext(530, 30, true);
                WriteLiteral("                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 560, "\"", 592, 2);
                WriteAttributeValue("", 567, "/delete/", 567, 8, true);
#line 20 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\BeltExam\Views\Home\ActInfo.cshtml"
WriteAttributeValue("", 575, Model.ActivityId, 575, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(593, 13, true);
                WriteLiteral(">Delete</a>\r\n");
                EndContext();
#line 21 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\BeltExam\Views\Home\ActInfo.cshtml"
                        }
                        else if(Model.Guests.Any(a => a.UserId == ViewBag.id))
                        {

#line default
#line hidden
                BeginContext(740, 34, true);
                WriteLiteral("                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 774, "\"", 805, 2);
                WriteAttributeValue("", 781, "/leave/", 781, 7, true);
#line 24 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\BeltExam\Views\Home\ActInfo.cshtml"
WriteAttributeValue("", 788, Model.ActivityId, 788, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(806, 12, true);
                WriteLiteral(">Leave</a>\r\n");
                EndContext();
#line 25 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\BeltExam\Views\Home\ActInfo.cshtml"
                            
                        }
                        else{

#line default
#line hidden
                BeginContext(906, 30, true);
                WriteLiteral("                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 936, "\"", 966, 2);
                WriteAttributeValue("", 943, "/join/", 943, 6, true);
#line 28 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\BeltExam\Views\Home\ActInfo.cshtml"
WriteAttributeValue("", 949, Model.ActivityId, 949, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(967, 12, true);
                WriteLiteral(">Join</a> \r\n");
                EndContext();
#line 29 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\BeltExam\Views\Home\ActInfo.cshtml"
                        }

#line default
#line hidden
                BeginContext(1006, 31, true);
                WriteLiteral("        <h2>Event Coordinator: ");
                EndContext();
                BeginContext(1038, 23, false);
#line 30 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\BeltExam\Views\Home\ActInfo.cshtml"
                          Write(ViewBag.coord.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1061, 32, true);
                WriteLiteral("</h2>\r\n        <h2>Description: ");
                EndContext();
                BeginContext(1094, 17, false);
#line 31 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\BeltExam\Views\Home\ActInfo.cshtml"
                    Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(1111, 38, true);
                WriteLiteral("</h2>\r\n        <h4>Participants</h4>\r\n");
                EndContext();
#line 33 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\BeltExam\Views\Home\ActInfo.cshtml"
         for(int i =0; i< @Model.Guests.Count; i++)
        {

#line default
#line hidden
                BeginContext(1213, 30, true);
                WriteLiteral("        <ul>\r\n            <li>");
                EndContext();
                BeginContext(1244, 34, false);
#line 36 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\BeltExam\Views\Home\ActInfo.cshtml"
           Write(Model.Guests[i].Attendee.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1278, 22, true);
                WriteLiteral("</li>\r\n        </ul>\r\n");
                EndContext();
#line 38 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\BeltExam\Views\Home\ActInfo.cshtml"
        }

#line default
#line hidden
                BeginContext(1311, 12, true);
                WriteLiteral("    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1330, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Activities> Html { get; private set; }
    }
}
#pragma warning restore 1591
