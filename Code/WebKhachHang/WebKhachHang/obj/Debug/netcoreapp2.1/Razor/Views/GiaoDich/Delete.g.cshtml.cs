#pragma checksum "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd671b7735b6b78d574711e0f0ea6073a57fc107"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GiaoDich_Delete), @"mvc.1.0.view", @"/Views/GiaoDich/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GiaoDich/Delete.cshtml", typeof(AspNetCore.Views_GiaoDich_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd671b7735b6b78d574711e0f0ea6073a57fc107", @"/Views/GiaoDich/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"959091463304aa0cd629dea441244072bf3df308", @"/Views/_ViewImports.cshtml")]
    public class Views_GiaoDich_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebKhachHang.Models.TblGiaoDich>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(131, 172, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>TblGiaoDich</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(304, 48, false);
#line 16 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NgayGiaoDich));

#line default
#line hidden
            EndContext();
            BeginContext(352, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(396, 44, false);
#line 19 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NgayGiaoDich));

#line default
#line hidden
            EndContext();
            BeginContext(440, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(484, 49, false);
#line 22 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TienThanhToan));

#line default
#line hidden
            EndContext();
            BeginContext(533, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(577, 45, false);
#line 25 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TienThanhToan));

#line default
#line hidden
            EndContext();
            BeginContext(622, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(666, 44, false);
#line 28 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DiemTich));

#line default
#line hidden
            EndContext();
            BeginContext(710, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(754, 40, false);
#line 31 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DiemTich));

#line default
#line hidden
            EndContext();
            BeginContext(794, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(838, 44, false);
#line 34 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TienGiam));

#line default
#line hidden
            EndContext();
            BeginContext(882, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(926, 40, false);
#line 37 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TienGiam));

#line default
#line hidden
            EndContext();
            BeginContext(966, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1010, 43, false);
#line 40 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DiemTru));

#line default
#line hidden
            EndContext();
            BeginContext(1053, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1097, 39, false);
#line 43 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DiemTru));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1180, 44, false);
#line 46 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TienThem));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1268, 40, false);
#line 49 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TienThem));

#line default
#line hidden
            EndContext();
            BeginContext(1308, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1352, 45, false);
#line 52 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TrangThai));

#line default
#line hidden
            EndContext();
            BeginContext(1397, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1441, 41, false);
#line 55 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TrangThai));

#line default
#line hidden
            EndContext();
            BeginContext(1482, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1526, 50, false);
#line 58 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaKhNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1576, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1620, 51, false);
#line 61 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaKhNavigation.MaKh));

#line default
#line hidden
            EndContext();
            BeginContext(1671, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1715, 50, false);
#line 64 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaNvNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1765, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1809, 51, false);
#line 67 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaNvNavigation.MaNv));

#line default
#line hidden
            EndContext();
            BeginContext(1860, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1898, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dec041b6d8694d5d84855b71dd3be57c", async() => {
                BeginContext(1924, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1934, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "efae9bba12b8433e96bf349f6f220d78", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 72 "D:\SaoLuuGithub\Code\WebKhachHang\WebKhachHang\Views\GiaoDich\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MaGd);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1972, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2056, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6739cf4497e74ec68e5609f5a54a1e3b", async() => {
                    BeginContext(2078, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2094, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2107, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebKhachHang.Models.TblGiaoDich> Html { get; private set; }
    }
}
#pragma warning restore 1591
