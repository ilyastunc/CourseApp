#pragma checksum "/Users/tunc/Documents/C#/CourseApp/Views/Shared/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc28323975fa8a16e8ece5475bea137c683c408a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "/Users/tunc/Documents/C#/CourseApp/Views/_ViewImports.cshtml"
using CourseApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/tunc/Documents/C#/CourseApp/Views/_ViewImports.cshtml"
using CourseApp.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc28323975fa8a16e8ece5475bea137c683c408a", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d439710b751a808d068130485a5a6cd4c08537c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsCategoriesViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/tunc/Documents/C#/CourseApp/Views/Shared/_Layout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc28323975fa8a16e8ece5475bea137c683c408a3335", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Index2</title>
    <style>
        #header {
            width: 900px;
            height: 100px;
            border-radius: 20px;
            background: red;
            padding: 20px;
            margin-bottom: 10px;
        }
        .banner {
            width: 900px;
            height: 100px;
            border-radius: 20px;
            padding: 20px;
            margin-bottom: 10px;
        }
        .topbanner {
            background: green;
        }
        .bottombanner {
            background: red;
        }
        .defaultbanner {
            background: yellow;
        }
        #menu {
            width: 200px;
            height: 300px;
            border-radius: 20px;
            background: blue;
            padding: 20px;
            float: left;
        }
        #content {
            width: 650px;
            heigh");
                WriteLiteral(@"t: 300px;
            border-radius: 20px;
            background: blue;
            padding: 20px;
            margin-left: 10px;
            float: left;
        }
        #footer {
            width: 900px;
            height: 90px;
            border-radius: 20px;
            background: blue;
            padding: 20px;
            margin-top: 10px;
        }
        ul {
            list-style-type: none;   
        }
        a {
            background-color: blue;
            color: white;
            text-decoration: none;
        }
    </style>
");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc28323975fa8a16e8ece5475bea137c683c408a5910", async() => {
                WriteLiteral("\n    <div id=\"header\">\n        Layout 1\n    </div>\n\n    ");
#nullable restore
#line 77 "/Users/tunc/Documents/C#/CourseApp/Views/Shared/_Layout.cshtml"
Write(RenderSection("TopBanner", false));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
                WriteLiteral("\n\n");
                WriteLiteral("    ");
#nullable restore
#line 80 "/Users/tunc/Documents/C#/CourseApp/Views/Shared/_Layout.cshtml"
Write(await Component.InvokeAsync("Menu"));

#line default
#line hidden
#nullable disable
                WriteLiteral("    \n\n    <div id=\"content\">\n        ");
#nullable restore
#line 83 "/Users/tunc/Documents/C#/CourseApp/Views/Shared/_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n    <div style=\"clear:both;\"></div>\n\n");
#nullable restore
#line 87 "/Users/tunc/Documents/C#/CourseApp/Views/Shared/_Layout.cshtml"
     if (IsSectionDefined("BottomBanner"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "/Users/tunc/Documents/C#/CourseApp/Views/Shared/_Layout.cshtml"
   Write(RenderSection("BottomBanner"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "/Users/tunc/Documents/C#/CourseApp/Views/Shared/_Layout.cshtml"
                                          
    }
    else 
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"banner defaultbanner\">\n            Default Banner\n        </div>\n");
#nullable restore
#line 96 "/Users/tunc/Documents/C#/CourseApp/Views/Shared/_Layout.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <div id=\"footer\">\n        Footer\n    </div>\n");
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
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsCategoriesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
