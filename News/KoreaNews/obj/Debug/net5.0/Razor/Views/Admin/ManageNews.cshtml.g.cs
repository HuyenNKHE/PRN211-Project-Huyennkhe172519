#pragma checksum "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3f5551d205f6bd1715367e98b56966c672ccc369d2c47fba6f8d250425517dd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManageNews), @"mvc.1.0.view", @"/Views/Admin/ManageNews.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\_ViewImports.cshtml"
using KoreaNews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\_ViewImports.cshtml"
using KoreaNews.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3f5551d205f6bd1715367e98b56966c672ccc369d2c47fba6f8d250425517dd8", @"/Views/Admin/ManageNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9308ce8eac1e482482e757ddc38014dd8f7fa05acb9964916373288ac8c056c2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_ManageNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/admin_news.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/avatar/2120b058cb9946e36306778243eadae5.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("40px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("40px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Error"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("adminSearchNews"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f5551d205f6bd1715367e98b56966c672ccc369d2c47fba6f8d250425517dd88168", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet""
          href=""https://maxst.icons8.com/vue-static/landings/line-awesome/line-awesome/1.3.0/css/line-awesome.min.css"" />
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css""
          integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"" />
    <script src=""https://kit.fontawesome.com/64bb7a6643.js"" crossorigin=""anonymous""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3f5551d205f6bd1715367e98b56966c672ccc369d2c47fba6f8d250425517dd89106", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <title>Manage News</title>\n\n");
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f5551d205f6bd1715367e98b56966c672ccc369d2c47fba6f8d250425517dd811045", async() => {
                WriteLiteral("\n");
#nullable restore
#line 22 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
      
        User CurrentUser = JsonConvert.DeserializeObject<User>(Context.Session.GetString("CurrentUser"));
    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <div class=""sidebar"" style=""background:#007bff"">
        <div class=""form-input"" style=""float: left; margin: 20px 10px; width: 10%;"">
            <a href=""/Home/Index""><span><i class=""fa fa-arrow-circle-o-left"" style=""font-size: 25px; color: white;""></i></span><a");
                BeginWriteAttribute("href", " href=\"", 1217, "\"", 1224, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\n        </div>\n        <div class=\"sidebar-brand\" style=\"float: right; margin: 0px; width: 80%; padding-left: 0;\">\n            <div class=\"user-wrapper\">\n");
#nullable restore
#line 31 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                 if (@CurrentUser.Avatar == null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f5551d205f6bd1715367e98b56966c672ccc369d2c47fba6f8d250425517dd812569", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 35 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f5551d205f6bd1715367e98b56966c672ccc369d2c47fba6f8d250425517dd814232", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1687, "~/images/avatar/", 1687, 16, true);
#nullable restore
#line 38 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
AddHtmlAttributeValue("", 1703, CurrentUser.Avatar, 1703, 19, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 40 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div>\n                    <h4 style=\"font-size: 20px;\">");
#nullable restore
#line 42 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                                            Write(CurrentUser.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h4>
                </div>
            </div>
        </div>

        <div class=""sidebar-menu"" style=""clear: both;"">
            <ul>
                <li>
                    <a href=""/Admin/ManageUser""><i class=""fas fa-user-circle""></i> <span>Manage User</span></a>
                </li>
                <li>
                    <a href=""/Admin/ManageNews"" class=""active""><i class=""fas fa-book-open""></i><span>Manage News</span></a>
                </li>
            </ul>
        </div>
    </div>
    <div class=""main-content"">
        <header>
            <h2>
                <label");
                BeginWriteAttribute("for", " for=\"", 2487, "\"", 2493, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                    <span class=\"las la-bars\"></span>\n                </label>\n                Dashboard\n            </h2>\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f5551d205f6bd1715367e98b56966c672ccc369d2c47fba6f8d250425517dd817594", async() => {
                    WriteLiteral(@"
                <div class=""search-wrapper"">
                    <span class=""class las la-search""></span>
                    <input type=""search"" placeholder=""Search here"" />
                    <input type=""submit"" value=""Search"" />
                </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </header>

        <main>
            <div class=""container-fluid"">
                <h2 style=""float: left; margin: 50px 0;"" style=""margin-top: 80px;"">News Management</h2>
                <a href=""/Admin/AddNews"">
                    <button style=""float: right; margin: 60px 0;"" type=""button"" class=""btn btn-success"" data-toggle=""modal""
                            data-target=""#exampleModal"">
                        Add News
                    </button>
                </a>

                <table class=""table table-bordered"">
                    <thead style=""text-align: center;"">
                        <tr>
                            <th>ID</th>
                            <th>Ttile</th>
                            <th>Author Name</th>
                            <th>Thumbnail</th>
                            <th>Category</th>
                            <th>Date Published</th>
                            <th>Delete</th>
                            <th>Update</th>
                        </tr>
  ");
                WriteLiteral("                  </thead>\n                    <tbody style=\"text-align: center;\">\n");
#nullable restore
#line 99 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                         foreach (News n in ViewBag.AllNews)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 102 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                               Write(n.NewsId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 103 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                               Write(n.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n");
#nullable restore
#line 104 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                                 foreach (User u in ViewBag.AllUsers)
                                {
                                    if (u.UserId == n.AuthorId)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td>");
#nullable restore
#line 108 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                                       Write(u.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n");
#nullable restore
#line 109 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"

                                    }
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3f5551d205f6bd1715367e98b56966c672ccc369d2c47fba6f8d250425517dd822685", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4669, "~/images/news/", 4669, 14, true);
#nullable restore
#line 112 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
AddHtmlAttributeValue("", 4683, n.Thumbnail, 4683, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\n");
#nullable restore
#line 113 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                                 foreach (Category c in  ViewBag.AllCategories)
                               {
                                   if (c.CategoryId == n.CategoryId)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td>");
#nullable restore
#line 117 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                                       Write(c.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n");
#nullable restore
#line 118 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"

                                    }
                               }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>");
#nullable restore
#line 121 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                               Write(n.DatePublished);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                <td><a href=\"#\"");
                BeginWriteAttribute("onclick", " onclick=\"", 5201, "\"", 5227, 3);
                WriteAttributeValue("", 5211, "alert(", 5211, 6, true);
#nullable restore
#line 122 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
WriteAttributeValue("", 5217, n.NewsId, 5217, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5226, ")", 5226, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\n                                <td><a");
                BeginWriteAttribute("href", " href=\"", 5306, "\"", 5347, 2);
                WriteAttributeValue("", 5313, "/Admin/UpdateNews?NewsId=", 5313, 25, true);
#nullable restore
#line 123 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
WriteAttributeValue("", 5338, n.NewsId, 5338, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\">Update</a></td>\n                            </tr>\n");
#nullable restore
#line 125 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </tbody>\n                </table>\n                <div class=\"pagination\">\n");
#nullable restore
#line 130 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                     if (Convert.ToInt32(ViewData["CurrentPage"]) > 1)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a");
                BeginWriteAttribute("href", " href=\"", 5664, "\"", 5744, 5);
                WriteAttributeValue("", 5671, "/Admin/ManageNews/", 5671, 18, true);
#nullable restore
#line 132 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
WriteAttributeValue("", 5689, ViewData["CurrentCategory"], 5689, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5717, "/", 5717, 1, true);
#nullable restore
#line 132 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
WriteAttributeValue("", 5718, ViewData["CurrentPage"], 5718, 24, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5742, "-1", 5742, 2, true);
                EndWriteAttribute();
                WriteLiteral(">&laquo;</a>\n");
#nullable restore
#line 133 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                     for (int i = 1; i <= (int)ViewData["TotalPage"]; i++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a");
                BeginWriteAttribute("class", " class=\'", 5903, "\'", 5957, 1);
#nullable restore
#line 136 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
WriteAttributeValue("", 5911, (int)ViewData["CurrentPage"]==i?"active":"", 5911, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("href", "\n                       href=\"", 5958, "\"", 6037, 4);
                WriteAttributeValue("", 5988, "/Admin/ManageNews/", 5988, 18, true);
#nullable restore
#line 137 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
WriteAttributeValue("", 6006, ViewData["CurrentCategory"], 6006, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6034, "/", 6034, 1, true);
#nullable restore
#line 137 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
WriteAttributeValue("", 6035, i, 6035, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 137 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                                                                           Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\n");
#nullable restore
#line 138 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                     if (Convert.ToInt32(ViewData["TotalPage"]) != Convert.ToInt32(ViewData["CurrentPage"]))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a");
                BeginWriteAttribute("href", " href=\"", 6225, "\"", 6305, 5);
                WriteAttributeValue("", 6232, "/Admin/ManageNews/", 6232, 18, true);
#nullable restore
#line 141 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
WriteAttributeValue("", 6250, ViewData["CurrentCategory"], 6250, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6278, "/", 6278, 1, true);
#nullable restore
#line 141 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
WriteAttributeValue("", 6279, ViewData["CurrentPage"], 6279, 24, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6303, "+1", 6303, 2, true);
                EndWriteAttribute();
                WriteLiteral(">&raquo;</a>\n");
#nullable restore
#line 142 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\Admin\ManageNews.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </div>
                <style>
                    .pagination {
                        display: inline-block;
                    }

                        .pagination a {
                            color: black;
                            float: left;
                            padding: 8px 16px;
                            text-decoration: none;
                        }

                            .pagination a.active {
                                background-color: #065aa2;
                                color: white;
                            }

                            .pagination a:hover:not(.active) {
                                background-color: #ddd;
                            }
                </style>
            </div>
        </main>
    </div>
    <script>
        function alert(NewsId) {
            var check = confirm('Are you sure to delete ?');

            if (check === true) {
                window.location.href = '/Admin/DeleteNews?NewsId=' + NewsId;");
                WriteLiteral("\n            }\n        }\n    </script>\n");
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
            WriteLiteral("\n\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
