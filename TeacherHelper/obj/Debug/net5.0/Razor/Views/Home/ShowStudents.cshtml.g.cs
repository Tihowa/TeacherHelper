#pragma checksum "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\ShowStudents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c726f4e86b5c37c050b67f49923ba915da4b6716"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowStudents), @"mvc.1.0.view", @"/Views/Home/ShowStudents.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c726f4e86b5c37c050b67f49923ba915da4b6716", @"/Views/Home/ShowStudents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d38cfde61a4ac822aa71fd1ade00490d3e8d1848", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowStudents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TeacherHelper.ViewModels.ShowStudentViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\ShowStudents.cshtml"
  
    ViewData["Title"] = "ShowStudents";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Students</h1>\r\n");
#nullable restore
#line 8 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\ShowStudents.cshtml"
 if (User.IsInRole("Admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c726f4e86b5c37c050b67f49923ba915da4b67164727", async() => {
                WriteLiteral("Add student");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 13 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\ShowStudents.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\ShowStudents.cshtml"
  
    if (Model.Count() != 0)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">
            <thead>
                <tr>
                    <th>№</th>
                    <th>Имя</th>
                    <th>Фамилия</th>
                    <th>Группа</th>
                    <th>Средний балл</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 30 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\ShowStudents.cshtml"
                  
                    int i = 1;
                    foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 35 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\ShowStudents.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\ShowStudents.cshtml"
                           Write(item.Student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\ShowStudents.cshtml"
                           Write(item.Student.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\ShowStudents.cshtml"
                           Write(item.Group.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\ShowStudents.cshtml"
                           Write(item.Student.AvarageMark);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 41 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\ShowStudents.cshtml"
                           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                                ");
#nullable restore
#line 42 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\ShowStudents.cshtml"
                           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                                ");
#nullable restore
#line 43 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\ShowStudents.cshtml"
                           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 46 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\ShowStudents.cshtml"
                        i++;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 51 "D:\Tikhon\Proga\AspNetCore\NotMainBranch\NExt\TeacherHelper\TeacherHelper\Views\Home\ShowStudents.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TeacherHelper.ViewModels.ShowStudentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
