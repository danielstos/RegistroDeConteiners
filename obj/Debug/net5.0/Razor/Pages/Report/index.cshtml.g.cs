#pragma checksum "C:\Users\danie\OneDrive\Área de Trabalho\Nova pasta (5)\projeto\RegistroDeConteiners\Pages\Report\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27db59b724fb2e1e512b484cb396a5dbbf9fdebb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RegistroDeConteiners.Pages.Report.Pages_Report_index), @"mvc.1.0.razor-page", @"/Pages/Report/index.cshtml")]
namespace RegistroDeConteiners.Pages.Report
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
#line 1 "C:\Users\danie\OneDrive\Área de Trabalho\Nova pasta (5)\projeto\RegistroDeConteiners\Pages\_ViewImports.cshtml"
using RegistroDeConteiners;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27db59b724fb2e1e512b484cb396a5dbbf9fdebb", @"/Pages/Report/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be4b41fcada70599cccbd28f778bdd26c9dedcfd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Report_index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\danie\OneDrive\Área de Trabalho\Nova pasta (5)\projeto\RegistroDeConteiners\Pages\Report\index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Report</h1>

<hr>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Cliente
            </th>
            <th>
                Tipo de Movimentacao
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "C:\Users\danie\OneDrive\Área de Trabalho\Nova pasta (5)\projeto\RegistroDeConteiners\Pages\Report\index.cshtml"
 foreach (var item in Model.Movimentacoes) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\Users\danie\OneDrive\Área de Trabalho\Nova pasta (5)\projeto\RegistroDeConteiners\Pages\Report\index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Conteiner.Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "C:\Users\danie\OneDrive\Área de Trabalho\Nova pasta (5)\projeto\RegistroDeConteiners\Pages\Report\index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TipodeMv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\danie\OneDrive\Área de Trabalho\Nova pasta (5)\projeto\RegistroDeConteiners\Pages\Report\index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<hr>\r\n\r\n<footer>\r\n    <h2>Total</h2>\r\n    <p>\r\n        <b>Importacoes:</b>\r\n        ");
#nullable restore
#line 43 "C:\Users\danie\OneDrive\Área de Trabalho\Nova pasta (5)\projeto\RegistroDeConteiners\Pages\Report\index.cshtml"
   Write(Model.totalImportacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        <b>Exportacoes:</b>\r\n        ");
#nullable restore
#line 47 "C:\Users\danie\OneDrive\Área de Trabalho\Nova pasta (5)\projeto\RegistroDeConteiners\Pages\Report\index.cshtml"
   Write(Model.totalExportacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegistroDeConteiners.Pages_Report.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegistroDeConteiners.Pages_Report.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegistroDeConteiners.Pages_Report.IndexModel>)PageContext?.ViewData;
        public RegistroDeConteiners.Pages_Report.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591