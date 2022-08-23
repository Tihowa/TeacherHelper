#pragma checksum "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\AddStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffd36140b1a4ffd5a5785e9845224c4576174de1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddStudent), @"mvc.1.0.view", @"/Views/Home/AddStudent.cshtml")]
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
#line 1 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\_ViewImports.cshtml"
using TeacherHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\_ViewImports.cshtml"
using TeacherHelper.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\AddStudent.cshtml"
using TeacherHelper.BLL.ModelsDTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffd36140b1a4ffd5a5785e9845224c4576174de1", @"/Views/Home/AddStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d38cfde61a4ac822aa71fd1ade00490d3e8d1848", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GroupDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffd36140b1a4ffd5a5785e9845224c4576174de13955", async() => {
                WriteLiteral(@"
    <div class=""mb-3"">
        <label for=""studentName"" class=""form-label"">Student's name</label>
        <input type=""text"" class=""form-control"" id=""studentName"" name=""studentName"" />
    </div>
    <div class=""mb-3"">
        <label for=""studentSurname"" class=""form-label"">Student's surname</label>
        <input type=""text"" class=""form-control"" id=""studentSurname"" name=""studentSurname"">
    </div>
    <div class=""mb-3"">
        <label for=""studentAvarageMark"" class=""form-label"">Student's avarage mark</label>
        <input type=""number"" min=""1"" max=""10"" step=""0.1"" class=""form-control"" id=""studentAvarageMark"" name=""studentAvarageMark"">
    </div>
    <div class=""mb-3"">
        <label for=""select"" class=""form-label"">Group</label>
        <select id=""groupId"" name=""groupId"" class=""form-select"">
");
#nullable restore
#line 20 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\AddStudent.cshtml"
              
                foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffd36140b1a4ffd5a5785e9845224c4576174de15410", async() => {
#nullable restore
#line 23 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\AddStudent.cshtml"
                                        Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\AddStudent.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 24 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\AddStudent.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GroupDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591