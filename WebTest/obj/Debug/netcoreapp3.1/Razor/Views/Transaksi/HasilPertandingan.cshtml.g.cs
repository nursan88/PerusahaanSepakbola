#pragma checksum "C:\Users\Muhkarom\Documents\GitHub\PerusahaanSepakbola\WebTest\Views\Transaksi\HasilPertandingan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dac94d410ee51df1535812a6cbdbde4c2706028"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaksi_HasilPertandingan), @"mvc.1.0.view", @"/Views/Transaksi/HasilPertandingan.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dac94d410ee51df1535812a6cbdbde4c2706028", @"/Views/Transaksi/HasilPertandingan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd0367e1ab19b265a544dc18b55df4c8735f4ed4", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaksi_HasilPertandingan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 4 "C:\Users\Muhkarom\Documents\GitHub\PerusahaanSepakbola\WebTest\Views\Transaksi\HasilPertandingan.cshtml"
       Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item active\">\r\n                <strong>");
#nullable restore
#line 7 "C:\Users\Muhkarom\Documents\GitHub\PerusahaanSepakbola\WebTest\Views\Transaksi\HasilPertandingan.cshtml"
                   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
            </li>
        </ol>
    </div>
</div>
<div ng-controller=""HasilCtrl"">
    <div class=""wrapper wrapper-content  animated fadeInRight"" ng-init=""initLoad()"">
        <div class=""row"">
            <div class=""col-md-12"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dac94d410ee51df1535812a6cbdbde4c27060284679", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-lg-3"">
                            <label for=""Id"">Id</label>
                            <input disabled type=""text"" ng-model=""hasil.id_hasil"" name=""id_hasilpertandingan"" class=""form-control"" id=""id_hasilpertandingan"" placeholder=""Id"">
                        </div>
                        <div class=""col-lg-3"">
                            <label for=""Hasil"">Skor Tim Tuan Rumah</label>
                            <input type=""number"" ng-model=""hasil.skorTimTuanRumah"" class=""form-control"" name=""hasil"" id=""TotalSkor"" placeholder=""Total Skor"">
                        </div>

                        <div class=""col-lg-3"">
                            <label for=""Hasil"">Skot Tim Tamu</label>
                            <input type=""number"" ng-model=""hasil.skorTimTamu"" class=""form-control"" name=""hasil"" id=""id_pemain_cetak_skor"" placeholder=""Pencetak Gol"">
                        </div>

                        <div class=");
                WriteLiteral(@"""col-lg-3"">
                            <input type=""checkbox"" ng-model=""hasil.flag"" name=""flag"" class=""i-checks"" id=""Flag"" ng-checked=true>
                            <label for=""Flag"">Status Aktif</label>
                        </div>
                    </div>
                    <div class=""col-lg-12"" style=""margin-top:10px"">
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <button style=""width:100%;"" class=""btn btn-primary"" ng-click=""TambahSkorTimTuanRumah()"">Tambah Skor</button>
                            </div>
                            <div class=""col-lg-12"" ng-repeat=""skor in hasil.skorPertandingan"">
                                <div class=""row"">
                                    <div class=""col-lg-1"">
                                        <span ng-click=""HapusSkorTimTuanRumah($index,hasil.skorPertandingan)"" class=""btn btn-danger"">X</span>
                                    </div>
                ");
                WriteLiteral(@"                    <div class=""col-lg-3"">
                                        <label for=""tim"">Tim Pemain</label>
                                        <select class=""form-control"" title=""hasil"" ng-change=""Check(skor)"" ng-model=""skor.timId_tim"" ng-options=""item.id_tim as item.namaTim for item in listTim | myFilter:filterTim""></select>
                                    </div><div class=""col-lg-3"">
                                        <label for=""tim"">Pemain</label>
                                        <select class=""form-control"" title=""hasil"" ng-model=""skor.pemainId_pemain"" ng-options=""item.id_pemain as item.namaPemain for item in listPemain | filter:{timPemainId_tim: skor.timId_tim}""></select>
                                    </div>
                                    <div class=""col-lg-3"">
                                        <label for=""Hasil"">Skor</label>
                                        <input type=""number"" ng-model=""skor.skor"" class=""form-control"" name=""hasil"" id=""Sk");
                WriteLiteral(@"or"" placeholder=""Skor"">
                                    </div>
                                    <div class=""col-lg-5"">
                                        <label for=""Hasil"">Waktu Cetak Gol *menit</label>
                                        <input type=""number"" ng-model=""skor.menitSkor"" class=""form-control"" name=""hasil"" id=""MenitSkor"" placeholder=""0"">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"" style=""margin-top:25px;"">
                        <div class=""col-lg-12"">
                            <div class=""col-lg-3"">
                                <button style=""width:100px;"" class=""btn btn-primary"" ng-click=""Simpan()"">Simpan</button>
                                <button style=""width:100px;"" class=""btn btn-primary"" ng-click=""Hapus()"">Hapus</button>
                            </div>
                        </d");
                WriteLiteral("iv>\r\n                    </div>\r\n                ");
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
                            <th>Skor Tim Tamu</th>
                            <th>Skor Tuan Rumah</th>
                            <th>Status Aktif</th>
                            <th>Detail</th>
                        </tr>
                    </thead>
                    <tbody ng-repeat=""item in listHasil"">
                        <tr class=""clickableRow"" ng-click=""selectTableRow($index, item)"" ng-class=""{selected : item.id_hasil === selectedIdHasil}"">
                            <td hidden>
                                {{item.id_hasil}}
                            </td>
                            <td>
                                {{item.skorTimTamu}}
                            </td>
                            <td>
                                {{item.skorTimTua");
            WriteLiteral(@"nRumah}}
                            </td>
                            <td>
                                {{item.flag}}
                            </td>
                            <td>
                                <button style=""width:100px;"" class=""btn btn-primary"" ng-click=""Skorhasil(item)"">Detail</button>
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
