#pragma checksum "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\User\Login.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7c4f53362419a8fa7c898fbf21ccca14b1f043ad870699ec388a7813055d44dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Login), @"mvc.1.0.view", @"/Views/User/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7c4f53362419a8fa7c898fbf21ccca14b1f043ad870699ec388a7813055d44dd", @"/Views/User/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9308ce8eac1e482482e757ddc38014dd8f7fa05acb9964916373288ac8c056c2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c4f53362419a8fa7c898fbf21ccca14b1f043ad870699ec388a7813055d44dd4377", async() => {
                WriteLiteral(@"
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">

    <style>
        html {
            background: #818089;
        }

        body {
            font-family: Arial, Helvetica, sans-serif;
        }

        .form-login {
            width: 30%;
            margin: 5% auto;
        }

            .form-login h2 {
                font-size: 40px;
                text-align: center;
            }

            .form-login form {
                border: 3px solid #f1f1f1;
            }

            .form-login .alert {
                padding: 20px;
                background-color: #065aa2;
                color: white;
                width: 90%;
                margin: 0 auto;
            }

            .form-login .closebtn {
                margin-left: 15px;
                color: white;
                font-weight: bold;
                float: right;
                font-size: 22px;
                line-height: 20px;
                cursor: pointer;
                transition: 0.3");
                WriteLiteral(@"s;
            }

                .form-login .closebtn:hover {
                    color: black;
                }

            .form-login input[type=text],
            .form-login input[type=email],
            .form-login input[type=password] {
                width: 100%;
                padding: 12px 20px;
                margin: 8px 0;
                display: inline-block;
                border: 1px solid #ccc;
                box-sizing: border-box;
            }

            .form-login button {
                background-color: #065aa2;
                color: white;
                padding: 14px 20px;
                margin: 8px 0;
                border: none;
                cursor: pointer;
                width: 100%;
            }

            .form-login cancelbtn:hover {
                opacity: 0.8;
                text-decoration: none;
            }

            .form-login .cancelbtn {
                width: auto;
                padding: 10px 18px;
                background-color: #06");
                WriteLiteral(@"5aa2;
                text-decoration: none;
                color: #fff;
            }

            .form-login .imgcontainer {
                text-align: center;
                margin: 24px 0 12px 0;
            }

            .form-login .container {
                padding: 16px;
            }

            .form-login span.psw {
                float: right;
                padding-top: 16px;
            }

            .form-login .private {
                margin: 5px 10px;
            }

            .form-login span.private {
                float: right;
            }

        media screen and (max-width: 300px) {
            .form-login span.psw

        {
            display: block;
            float: none;
        }

        .form-login .cancelbtn {
            width: 100%;
        }

        }</style>

    <title>Login</title>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c4f53362419a8fa7c898fbf21ccca14b1f043ad870699ec388a7813055d44dd8338", async() => {
                WriteLiteral("\n    <div class=\"form-login\">\n        <h2>Login</h2>\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c4f53362419a8fa7c898fbf21ccca14b1f043ad870699ec388a7813055d44dd8682", async() => {
                    WriteLiteral("\n");
#nullable restore
#line 128 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\User\Login.cshtml"
             if (ViewBag.Error != null)
            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                <div class=\"alert\">\n                    <span class=\"closebtn\" onclick=\"this.parentElement.style.display = \'none\';\">&times;</span>\n                    ");
#nullable restore
#line 132 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\User\Login.cshtml"
               Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\n                </div>\n");
#nullable restore
#line 134 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\User\Login.cshtml"
            }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"            <div class=""container"">
                <label for=""username""><b>UserName</b></label>
                <input type=""text"" placeholder=""Enter UserName"" name=""Username"" required>

                <label for=""psw""><b>Password</b></label>
                <input type=""password"" placeholder=""Enter Password"" name=""Password"" required>

                <button type=""submit"">Login</button>
            </div>

            <div class=""container"" style=""background-color:#f1f1f1;height: 40px;"">
                <a href=""/Home/Index"" class=""cancelbtn"">Back</a>
                <span class=""private"">Forgot <a href=""/User/ForgotPassword"">password?</a></span>
                <span class=""private"">Don't have an account yet? <a href=""/User/Register"">Register</a></span>
            </div>
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
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    </div>\n");
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
            WriteLiteral("\n</html>\n\n");
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