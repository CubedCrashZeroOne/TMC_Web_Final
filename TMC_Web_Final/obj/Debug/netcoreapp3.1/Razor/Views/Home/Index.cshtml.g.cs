#pragma checksum "C:\Users\PETROS.NOWHERE\source\repos\TMC_Web_Final\TMC_Web_Final\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd72160f69ddcda8f68060b34a132a37f2e2bcba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd72160f69ddcda8f68060b34a132a37f2e2bcba", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<(string num1, string num2, string result)>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd72160f69ddcda8f68060b34a132a37f2e2bcba2725", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <style>
        /*insert css here*/
        .select{
            margin: 10px 0px 10px 0px
        }

        .result{
            font-size: larger;
            font-weight: bold;
            margin-top: 20px;
        }
        
        .secretLink{
            margin-top: 450px;
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd72160f69ddcda8f68060b34a132a37f2e2bcba4059", async() => {
                WriteLiteral("\r\n    <form method=\"post\" action=\"Home/DoMath\">\r\n        <input id=\"box1\" type=\"text\" name=\"firstNum\"");
                BeginWriteAttribute("value", " value=\"", 541, "\"", 560, 1);
#nullable restore
#line 26 "C:\Users\PETROS.NOWHERE\source\repos\TMC_Web_Final\TMC_Web_Final\Views\Home\Index.cshtml"
WriteAttributeValue("", 549, Model.num1, 549, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n        <input id=\"box2\" type=\"text\" name=\"secondNum\"");
                BeginWriteAttribute("value", " value=\"", 619, "\"", 638, 1);
#nullable restore
#line 28 "C:\Users\PETROS.NOWHERE\source\repos\TMC_Web_Final\TMC_Web_Final\Views\Home\Index.cshtml"
WriteAttributeValue("", 627, Model.num2, 627, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" onchange=""NoZero();"">

        <div class=""select"">
            <select id=""oper"" name=""operation"" onchange=""NoZero();"">
                <option value=""add"">Add</option>
                <option value=""sub"">Subtract</option>
                <option value=""mul"">Multiply</option>
                <option value=""div"">Divide</option>
                <option value=""pow"">Power</option>
            </select>
        </div>
        
        <div>
            <button type=""submit"">Calculate</button>
        </div>
   
    </form>

    <div class=""result"">R   E   S   U   L   T:   ");
#nullable restore
#line 46 "C:\Users\PETROS.NOWHERE\source\repos\TMC_Web_Final\TMC_Web_Final\Views\Home\Index.cshtml"
                                            Write(Model.result);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n    <div class=\"secretLink\">\r\n    ");
#nullable restore
#line 49 "C:\Users\PETROS.NOWHERE\source\repos\TMC_Web_Final\TMC_Web_Final\Views\Home\Index.cshtml"
Write(Html.ActionLink("The End", "ThankYou", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<(string num1, string num2, string result)> Html { get; private set; }
    }
}
#pragma warning restore 1591
