#pragma checksum "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\Areas\Identity\Pages\Account\Manage\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d58d44de0c014eafe0cc939c07bd1957d2c10dd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage__Layout), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
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
#line 1 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\Areas\Identity\Pages\_ViewImports.cshtml"
using Kalendarz_Telekonferencji.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\Areas\Identity\Pages\_ViewImports.cshtml"
using Kalendarz_Telekonferencji.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Kalendarz_Telekonferencji.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using Kalendarz_Telekonferencji.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d58d44de0c014eafe0cc939c07bd1957d2c10dd1", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d20426e43ae26b8a9796ef7187469bc1c1117f1", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bb13cafca32944804980b1d403c92ac14cf6892", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9861055106d6196946b026534bebbec5555264a4", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
  
    if (ViewData.TryGetValue("ParentLayout", out var parentLayout))
    {
        Layout = (string)parentLayout;
    }
    else
    {
        Layout = "/Areas/Identity/Pages/_Layout.cshtml";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""=col-12""><br /></div>
<div class=""=col-12""><br /></div>
<div class=""=col-12""><br /></div>
<div class=""=col-12""><br /></div>
<div class=""=col-12""><br /></div>

<h2 style=""color:white"">Zarządzaj kontem</h2>

<div>

    <hr style=""background-color: red !important; color: red !important; border: solid 3px red !important;"" />
    <div class=""=col-12""><br /></div>
    <div class=""=col-12""><br /></div>
    <div class=""=col-12""><br /></div>
    <div class=""row"">
        <div class=""col-md-12"">
            ");
#nullable restore
#line 28 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 34 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591