#pragma checksum "C:\Users\Muhkarom\Documents\GitHub\PerusahaanSepakbola\WebTest\Views\Transaksi\JadwalPertandingan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df218b2e48a729a78c1a1c7c231fc6aafcebb75b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaksi_JadwalPertandingan), @"mvc.1.0.view", @"/Views/Transaksi/JadwalPertandingan.cshtml")]
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
#line 1 "C:\Users\Muhkarom\Documents\GitHub\PerusahaanSepakbola\WebTest\Views\_ViewImports.cshtml"
using WebTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Muhkarom\Documents\GitHub\PerusahaanSepakbola\WebTest\Views\_ViewImports.cshtml"
using WebTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df218b2e48a729a78c1a1c7c231fc6aafcebb75b", @"/Views/Transaksi/JadwalPertandingan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd0367e1ab19b265a544dc18b55df4c8735f4ed4", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaksi_JadwalPertandingan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-12\">\r\n        <h2>");
#nullable restore
#line 4 "C:\Users\Muhkarom\Documents\GitHub\PerusahaanSepakbola\WebTest\Views\Transaksi\JadwalPertandingan.cshtml"
       Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item active\">\r\n                <strong>");
#nullable restore
#line 7 "C:\Users\Muhkarom\Documents\GitHub\PerusahaanSepakbola\WebTest\Views\Transaksi\JadwalPertandingan.cshtml"
                   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
            </li>
        </ol>
    </div>
</div>
<div ng-controller=""JadwalCtrl"">
    <div class=""wrapper wrapper-content  animated fadeInRight"" ng-init=""initLoad()"">
        <div class=""row"">
            <div class=""col-md-12"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df218b2e48a729a78c1a1c7c231fc6aafcebb75b4687", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-lg-3"">
                            <label for=""Id"">Id</label>
                            <input disabled type=""text"" ng-model=""jadwal.id_jadwal"" name=""jadwal"" class=""form-control"" id=""Id_pemain"" placeholder=""Id"">
                        </div>
                        <div class=""col-lg-3"">
                            <label for=""Jadwal"">Tanggal Pertandingan</label>
                            <input type=""datetime-local"" ng-model=""jadwal.tanggalPertandingan"" class=""form-control"" name=""jadwal"" id=""TanggalPertandingan"" placeholder=""Waktu Pertandingan"">
                        </div>
                        <div class=""col-lg-3"">
                            <label for=""Jadwal"">Tim Tuan Rumah</label>
                            <select class=""form-control"" title=""Jadwal"" ng-model=""jadwal.timTuanRumahId_tim"" ng-options=""item.id_tim as item.namaTim for item in listTim""></select>
                        </div>
             ");
                WriteLiteral(@"           <div class=""col-lg-3"">
                            <label for=""Jadwal"">Tim Tamu</label>
                            <select class=""form-control"" title=""Jadwal"" ng-model=""jadwal.timTamuId_tim"" ng-options=""item.id_tim as item.namaTim for item in listTim""></select>
                        </div>

                        <div class=""col-lg-3"">
                            <input type=""checkbox"" ng-model=""jadwal.flag"" name=""flag"" class=""i-checks"" id=""Flag"" ng-checked=true>
                            <label for=""Flag"">Status Aktif</label>
                        </div>
                    </div>
                    <div class=""row"" style=""margin-top:25px;"">
                        <div class=""col-lg-12"">
                            <div class=""col-lg-3"">
                                <button style=""width:100px;"" class=""btn btn-primary"" ng-click=""Simpan()"">Simpan</button>
                                <button style=""width:100px;"" class=""btn btn-primary"" ng-click=""Hapus()"">Hapus</button>");
                WriteLiteral("\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""col-md-12"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th hidden>Id </th>
                            <th>Tanggal Pertandingan</th>
                            <th>Waktu Pertandingan</th>
                            <th>Tim Tuan Rumah</th>
                            <th>Tim Tamu</th>
                            <th>Status Aktif</th>
                            <th>Lihat Hasil</th>
                        </tr>
                    </thead>
                    <tbody ng-repeat=""item in listJadwal"">
                        <tr class=""clickableRow"" ng-click=""selectTableRow($index, item)"" ng-class=""{selected : item.id_jadwal === selectedIdJadwal}"">
                            <td hidden>
                                {{item.id_jadwal}}
                            </td>
                            <td>
                                {{formatDate(item.tan");
            WriteLiteral(@"ggalPertandingan)}}
                            </td>
                            <td>
                                {{item.waktuPertandingan}}
                            </td>
                            <td>
                                {{item.timTuanRumah.namaTim}}
                            </td>
                            <td>
                                {{item.timTamu.namaTim}}
                            </td>
                            <td>
                                {{item.flag}}
                            </td>
                            <td>
                                <button style=""width:100px;"" class=""btn btn-primary"" ng-click=""Hasil(item)"">Hasil</button>
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
