#pragma checksum "C:\Nursan\WebTest\WebTest\Views\Transaksi\SkorHasil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e51234e0e9c2e060172380900c6cae96002e5fcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaksi_SkorHasil), @"mvc.1.0.view", @"/Views/Transaksi/SkorHasil.cshtml")]
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
#line 1 "C:\Nursan\WebTest\WebTest\Views\_ViewImports.cshtml"
using WebTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Nursan\WebTest\WebTest\Views\_ViewImports.cshtml"
using WebTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e51234e0e9c2e060172380900c6cae96002e5fcc", @"/Views/Transaksi/SkorHasil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd0367e1ab19b265a544dc18b55df4c8735f4ed4", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaksi_SkorHasil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-12\">\r\n        <h2>");
#nullable restore
#line 4 "C:\Nursan\WebTest\WebTest\Views\Transaksi\SkorHasil.cshtml"
       Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item active\">\r\n                <strong>");
#nullable restore
#line 7 "C:\Nursan\WebTest\WebTest\Views\Transaksi\SkorHasil.cshtml"
                   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
            </li>
        </ol>
    </div>
</div>
<div ng-controller=""SkorhasilCtrl"">
    <div class=""wrapper wrapper-content  animated fadeInRight"" ng-init=""initLoad()"">
        <div class=""row"">
            <div class=""col-md-12"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th hidden>Id </th>
                            <th>Skor Tim Tamu</th>
                            <th>Skor Tuan Rumah</th>
                            <th>Pencetak Gol</th>
                            <th>Waktu Cetak</th>
                            <th>Status Aktif</th>
                        </tr>
                    </thead>
                    <tbody ng-repeat=""item in listDetail"">
                        <tr class=""clickableRow"" ng-click=""selectTableRow($index, item)"" ng-class=""{selected : item.id === selectedIdDetail}"">
                            <td hidden>
                                {{item.id}}
  ");
            WriteLiteral(@"                          </td>
                            <td>
                                {{item.tim}}
                            </td>
                            <td>
                                {{item.pemain}}
                            </td>
                            <td>
                                {{item.skor}}
                            </td>
                            <td>
                                {{item.menitSkor}}
                            </td>
                            <td>
                                {{item.flag}}
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>
");
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
