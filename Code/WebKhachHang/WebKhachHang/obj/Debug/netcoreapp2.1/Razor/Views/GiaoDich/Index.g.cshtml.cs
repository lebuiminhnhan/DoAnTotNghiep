#pragma checksum "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27932a8ca95c193caa68c068de175fe9d93e1b27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GiaoDich_Index), @"mvc.1.0.view", @"/Views/GiaoDich/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GiaoDich/Index.cshtml", typeof(AspNetCore.Views_GiaoDich_Index))]
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
#line 1 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\_ViewImports.cshtml"
using WebKhachHang;

#line default
#line hidden
#line 2 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\_ViewImports.cshtml"
using WebKhachHang.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27932a8ca95c193caa68c068de175fe9d93e1b27", @"/Views/GiaoDich/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"959091463304aa0cd629dea441244072bf3df308", @"/Views/_ViewImports.cshtml")]
    public class Views_GiaoDich_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebKhachHang.Models.TblGiaoDich>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Index.cshtml"
  
    
        ViewData["Title"] = "Lịch sử giao dịch";
    
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(171, 907, true);
            WriteLiteral(@"<section class=""frequently_area"" style=""margin-top:10em"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h2>Lịch Sử Giao Dịch</h2> <br />
                <table id=""mytable"" class=""table"">
                    <thead>
                        <tr>
                            <th>
                                Ngày Giao Dịch
                            </th>
                            <th>
                                Tiền Thanh Toán
                            </th>
                            <th>
                                Điểm Tích Lũy
                            </th>
                            <th>
                                Điểm Trừ
                            </th>

                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 34 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1159, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1268, 47, false);
#line 38 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.NgayGiaoDich));

#line default
#line hidden
            EndContext();
            BeginContext(1315, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1431, 48, false);
#line 41 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.TienThanhToan));

#line default
#line hidden
            EndContext();
            BeginContext(1479, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1595, 43, false);
#line 44 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DiemTich));

#line default
#line hidden
            EndContext();
            BeginContext(1638, 117, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1756, 42, false);
#line 48 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DiemTru));

#line default
#line hidden
            EndContext();
            BeginContext(1798, 154, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                   \r\n                                    ");
            EndContext();
            BeginContext(1952, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e25a7bc4eb9411f951da588680ace1b", async() => {
                BeginContext(2002, 8, true);
                WriteLiteral("Chi Tiết");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Index.cshtml"
                                                              WriteLiteral(item.MaGd);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2014, 112, true);
            WriteLiteral("\r\n                                  \r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 57 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2153, 126, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    </section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebKhachHang.Models.TblGiaoDich>> Html { get; private set; }
    }
}
#pragma warning restore 1591
