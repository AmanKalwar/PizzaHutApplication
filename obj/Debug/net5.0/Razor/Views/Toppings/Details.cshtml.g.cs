#pragma checksum "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e39ffaed1ca6e33bd8bedf4dd64f4b115a9ddea2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Toppings_Details), @"mvc.1.0.view", @"/Views/Toppings/Details.cshtml")]
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
#line 1 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\_ViewImports.cshtml"
using PizzaHut;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\_ViewImports.cshtml"
using PizzaHut.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e39ffaed1ca6e33bd8bedf4dd64f4b115a9ddea2", @"/Views/Toppings/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e37da2dc4f4f9368457193c61a97d84750b0e1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Toppings_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
  
    var DictPizza = (Dictionary<string, Cart>)ViewData["Pizza"];
    var DictToppings = (Dictionary<string, Toppings>)ViewData["Toppings"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e39ffaed1ca6e33bd8bedf4dd64f4b115a9ddea23596", async() => {
                WriteLiteral("\n    <title></title>\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e39ffaed1ca6e33bd8bedf4dd64f4b115a9ddea24579", async() => {
                WriteLiteral("\n");
#nullable restore
#line 15 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
     if (TempData["Added"] != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\n            alert(\"Ädded To Cart Successfully\");\n        </script>\n");
#nullable restore
#line 20 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <p>");
#nullable restore
#line 22 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
  Write(TempData.Peek("UserID"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
    <p>Pizza</p>
    <table class=""table table-striped table-dark"" style=""text-align:center"">
        <thead>
            <tr>
                <th>Pizza Id</th>
                <th>Pizza Name</th>
                <th>Toppings ID</th>
                <th>Toppings Name</th>
                <th>Price</th>
                <th>Quantity</th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 37 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
             foreach (var item in DictPizza.Keys)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 41 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
               Write(DictPizza[item].Pizza.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 44 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
               Write(DictPizza[item].Pizza.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n");
#nullable restore
#line 46 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
                 if (DictToppings != null)
                {
                    if (DictToppings.ContainsKey(item))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>");
#nullable restore
#line 50 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
                       Write(DictToppings[item].ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 51 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
                       Write(DictToppings[item].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 52 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
                        Write((@Convert.ToInt32(DictPizza[item].Pizza.Price)+@Convert.ToInt32(DictToppings[item].Price))*Convert.ToInt32(DictPizza[item].Qty));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n");
#nullable restore
#line 53 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td colspan=\"2\"> - </td>\n                        <td>");
#nullable restore
#line 57 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
                        Write(@Convert.ToInt32(DictPizza[item].Pizza.Price)*@Convert.ToInt32(DictPizza[item].Qty));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n");
#nullable restore
#line 58 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
                    }

                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td colspan=\"2\"> - </td>\n                    <td>");
#nullable restore
#line 64 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
                    Write(@Convert.ToInt32(DictPizza[item].Pizza.Price)*@Convert.ToInt32(DictPizza[item].Qty));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n");
#nullable restore
#line 65 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <td>");
#nullable restore
#line 66 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
               Write(DictPizza[item].Qty);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                <td><a");
                BeginWriteAttribute("href", " href=\"", 2155, "\"", 2209, 1);
#nullable restore
#line 67 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
WriteAttributeValue("", 2162, Url.Action("Delete","Toppings",new {ID=@item}), 2162, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><button class=\"btn btn-warning\">Delete</button></a></td>\n                <td><a");
                BeginWriteAttribute("href", " href=\"", 2290, "\"", 2341, 1);
#nullable restore
#line 68 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
WriteAttributeValue("", 2297, Url.Action("Add","Toppings",new {ID=@item}), 2297, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><button class=\"btn btn-warning\">Add</button></a></td>\n            </tr>\n");
#nullable restore
#line 70 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\n    </table>\n    ");
#nullable restore
#line 74 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
Write(Html.ActionLink("Go Back", "Index", "Pizza"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <a");
                BeginWriteAttribute("href", " href=\"", 2516, "\"", 2552, 1);
#nullable restore
#line 75 "C:\Users\Administrator\source\repos\PizzaHutApplication\Views\Toppings\Details.cshtml"
WriteAttributeValue("", 2523, Url.Action("Index","Orders"), 2523, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><button class=\"btn btn-warning\">Order Now</button></a>\n");
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
            WriteLiteral("\n</html>");
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
