#pragma checksum "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Migrantes\ConsultarInformacion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5fb5fb73b5683d21fa5ac762bbef8b9876583c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Emigrant.App.Presentacion.Pages.Migrantes.Pages_Migrantes_ConsultarInformacion), @"mvc.1.0.razor-page", @"/Pages/Migrantes/ConsultarInformacion.cshtml")]
namespace Emigrant.App.Presentacion.Pages.Migrantes
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
#line 1 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\_ViewImports.cshtml"
using Emigrant.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5fb5fb73b5683d21fa5ac762bbef8b9876583c4", @"/Pages/Migrantes/ConsultarInformacion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c587e1ae29f3d71737a581da5d83833e4c791939", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Migrantes_ConsultarInformacion : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Migrantes/ActualizarInformacion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"



<div class=""content-wrapper"" style=""display:flex; justify-content:center; align-items:start; background-color:#FFFFFF;"">
  <div class=""container-fluid"">
    <div class=""row"" style=""justify-content:center;"">
      <div class=""col-md-12"" style=""padding-top:1rem; padding-left:1rem; padding-right:1rem; "">
  
        <div class=""card"">
          <div class=""card-header"" style=""background-color:#FCC16D; border-style:none; color:#000000;"">
            <h3 class=""card-title"">Migrante</h3>

            <div class=""card-tools"">
              <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" title=""Collapse"">
                <i class=""fas fa-minus""></i>
              </button>
            </div>
          </div>
          <!-- /.card-header -->
          <div class=""card-body table-responsive p-0"">
            <table class=""table table-hover text-nowrap"">
              <thead>
                <tr>
                  <th>Nombre</th>
                  <th>Apellido</th>
   ");
            WriteLiteral(@"               <th>Correo</th>
                  <th>Direccion</th>
                  <th>Pais Origen</th>
                  <th>Ciudad</th>
                  <th>Tipo Documento</th>
                  <th>Numero Documento</th>
                  <th>Fecha Nacimiento</th>
                  <th>Situacion Laboral</th>
                  <th>Telefono</th>
                  <th>Actualizar</th>
                </tr>
              </thead>
              <tbody>
                  
                  <tr>
                    <td>");
#nullable restore
#line 46 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Migrantes\ConsultarInformacion.cshtml"
                   Write(Model.migrante.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Migrantes\ConsultarInformacion.cshtml"
                   Write(Model.migrante.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Migrantes\ConsultarInformacion.cshtml"
                   Write(Model.migrante.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Migrantes\ConsultarInformacion.cshtml"
                   Write(Model.migrante.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Migrantes\ConsultarInformacion.cshtml"
                   Write(Model.migrante.PaisOrigen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 51 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Migrantes\ConsultarInformacion.cshtml"
                   Write(Model.migrante.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Migrantes\ConsultarInformacion.cshtml"
                   Write(Model.migrante.TipoDoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 53 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Migrantes\ConsultarInformacion.cshtml"
                   Write(Model.migrante.Documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 54 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Migrantes\ConsultarInformacion.cshtml"
                   Write(Model.migrante.FechaNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 55 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Migrantes\ConsultarInformacion.cshtml"
                   Write(Model.migrante.SituacionLaboral);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 56 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Migrantes\ConsultarInformacion.cshtml"
                   Write(Model.migrante.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5fb5fb73b5683d21fa5ac762bbef8b9876583c49653", async() => {
                WriteLiteral("\r\n                             ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5fb5fb73b5683d21fa5ac762bbef8b9876583c49940", async() => {
                    WriteLiteral("Actualizar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Migrantes\ConsultarInformacion.cshtml"
                                                                                                      WriteLiteral(Model.migrante.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("                    \r\n                         ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                  </tr>\r\n                \r\n              </tbody>\r\n            </table>\r\n          </div>\r\n          <!-- /.card-body -->\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Emigrant.App.Presentacion.Pages.ConsultarInformacionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Emigrant.App.Presentacion.Pages.ConsultarInformacionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Emigrant.App.Presentacion.Pages.ConsultarInformacionModel>)PageContext?.ViewData;
        public Emigrant.App.Presentacion.Pages.ConsultarInformacionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
