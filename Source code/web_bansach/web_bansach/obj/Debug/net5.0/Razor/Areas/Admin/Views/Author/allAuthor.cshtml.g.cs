#pragma checksum "C:\web_bansach\web_bansach\web_bansach\Areas\Admin\Views\Author\allAuthor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d08dcf8396e66b6f15f9981b40c5c1e253c79639"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Author_allAuthor), @"mvc.1.0.view", @"/Areas/Admin/Views/Author/allAuthor.cshtml")]
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
#line 1 "C:\web_bansach\web_bansach\web_bansach\Areas\Admin\Views\_ViewImports.cshtml"
using web_bansach;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\web_bansach\web_bansach\web_bansach\Areas\Admin\Views\_ViewImports.cshtml"
using web_bansach.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d08dcf8396e66b6f15f9981b40c5c1e253c79639", @"/Areas/Admin/Views/Author/allAuthor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"622165dcd2f2f0fd1a40fb0a24c8750c40bbf48e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Author_allAuthor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("searchAuthorController"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: 1100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"


<div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12"">
    <div class=""section-block"" id=""basicform"">
        <h3 class=""section-title"">Danh mục tác giả</h3>
        <!-- <p>Use custom button styles for actions in forms, dialogs, and more with support for multiple sizes, states, and more.</p> -->
    </div>

    <div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d08dcf8396e66b6f15f9981b40c5c1e253c796395364", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <input type=""text"" class=""form-control"" id=""email"" placeholder=""Search..."" name=""searchString"" required>
            </div>
            <button type=""submit"" class=""btn btn-default"" style=""background-color: #ccc""><i class=""fa fa-search""></i></button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>

    <div class=""cardall"">
        <div class=""ecommerce-widget"">
            <div class=""row"">
                <div class=""col-xl-12 col-lg-12 col-md-6 col-sm-12 col-12"">
                    <div class=""card"">
                        <div class=""card-body p-0"">
                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <thead class=""bg-light"">
                                        <tr class=""border-0"">
                                            <th class=""border-0"">ID</th>
                                            <th class=""border-0"">Tên tác giả</th>
                                            <th class=""border-0"">Số điện thoại</th>
                                            <th class=""border-0"">Email</th>
                                            <th class=""border-0"">Giới tính</th>
                                            <th class=""border-0"">Ngày tạo</th>
                    ");
            WriteLiteral(@"                        <th class=""border-0"">Trạng thái</th>
                                            <th class=""border-0"">Thao tác</th>
                                        </tr>
                                    </thead>
                                    <tbody>

");
#nullable restore
#line 41 "C:\web_bansach\web_bansach\web_bansach\Areas\Admin\Views\Author\allAuthor.cshtml"
                                         foreach (var item in Model)
                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 45 "C:\web_bansach\web_bansach\web_bansach\Areas\Admin\Views\Author\allAuthor.cshtml"
                                               Write(item.AuthorID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 46 "C:\web_bansach\web_bansach\web_bansach\Areas\Admin\Views\Author\allAuthor.cshtml"
                                               Write(item.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 47 "C:\web_bansach\web_bansach\web_bansach\Areas\Admin\Views\Author\allAuthor.cshtml"
                                               Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 48 "C:\web_bansach\web_bansach\web_bansach\Areas\Admin\Views\Author\allAuthor.cshtml"
                                               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>\r\n");
#nullable restore
#line 50 "C:\web_bansach\web_bansach\web_bansach\Areas\Admin\Views\Author\allAuthor.cshtml"
                                                     if (@item.Gender == 0)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p>Nam</p>\r\n");
#nullable restore
#line 53 "C:\web_bansach\web_bansach\web_bansach\Areas\Admin\Views\Author\allAuthor.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p>Nữ</p>\r\n");
#nullable restore
#line 57 "C:\web_bansach\web_bansach\web_bansach\Areas\Admin\Views\Author\allAuthor.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n                                                <td>");
#nullable restore
#line 59 "C:\web_bansach\web_bansach\web_bansach\Areas\Admin\Views\Author\allAuthor.cshtml"
                                               Write(item.Created_at.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>\r\n");
#nullable restore
#line 61 "C:\web_bansach\web_bansach\web_bansach\Areas\Admin\Views\Author\allAuthor.cshtml"
                                                     if (@item.AuthorStatus == 0)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"badge-dot badge-success mr-1\"></span>\r\n                                                        <p>Đang kinh doanh</p>\r\n");
#nullable restore
#line 65 "C:\web_bansach\web_bansach\web_bansach\Areas\Admin\Views\Author\allAuthor.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"badge-dot badge-brand mr-1\"></span>\r\n                                                        <p>Ngừng kinh doanh</p>\r\n");
#nullable restore
#line 70 "C:\web_bansach\web_bansach\web_bansach\Areas\Admin\Views\Author\allAuthor.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    <a onclick=\"return confirm(\'Bạn có chắc muốn xóa tác giả ?\')\"");
            BeginWriteAttribute("href", " href=\"", 4261, "\"", 4298, 2);
            WriteAttributeValue("", 4268, "deleteAuthor?id=", 4268, 16, true);
#nullable restore
#line 74 "C:\web_bansach\web_bansach\web_bansach\Areas\Admin\Views\Author\allAuthor.cshtml"
WriteAttributeValue("", 4284, item.AuthorID, 4284, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-light\">Xóa</a>\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 4393, "\"", 4456, 4);
            WriteAttributeValue("", 4400, "viewupdateAuthor?id=", 4400, 20, true);
#nullable restore
#line 75 "C:\web_bansach\web_bansach\web_bansach\Areas\Admin\Views\Author\allAuthor.cshtml"
WriteAttributeValue("", 4420, item.AuthorID, 4420, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4434, "&name=", 4434, 6, true);
#nullable restore
#line 75 "C:\web_bansach\web_bansach\web_bansach\Areas\Admin\Views\Author\allAuthor.cshtml"
WriteAttributeValue("", 4440, item.AuthorName, 4440, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-light\">Sửa</a>\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 78 "C:\web_bansach\web_bansach\web_bansach\Areas\Admin\Views\Author\allAuthor.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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