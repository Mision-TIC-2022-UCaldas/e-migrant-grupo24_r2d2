#pragma checksum "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Entidades\ConsultarInformacionE.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4511720242133b1f4c9fb6abd3630a74a35a20c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Emigrant.App.Presentacion.Pages.Entidades.Pages_Entidades_ConsultarInformacionE), @"mvc.1.0.razor-page", @"/Pages/Entidades/ConsultarInformacionE.cshtml")]
namespace Emigrant.App.Presentacion.Pages.Entidades
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4511720242133b1f4c9fb6abd3630a74a35a20c9", @"/Pages/Entidades/ConsultarInformacionE.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c587e1ae29f3d71737a581da5d83833e4c791939", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Entidades_ConsultarInformacionE : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Entidades/ActualizarInformacionE", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            <h3 class=""card-title"">Entidad</h3>

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
                  <th>RazonSocial</th>
                  <th>NIT</th>
    ");
            WriteLiteral(@"              <th>Correo</th>
                  <th>Direccion</th>
                  <th>Pagina WEB</th>
                  <th>Ciudad</th>
                  <th>Sector</th>
                  <th>Tipo Servicio</th>
                  <th>Telefono</th>
                  <th>Actualizar</th>
                </tr>
              </thead>
              <tbody>
                  
                  <tr>
                    <td>");
#nullable restore
#line 44 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Entidades\ConsultarInformacionE.cshtml"
                   Write(Model.entidad.RazonSocial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Entidades\ConsultarInformacionE.cshtml"
                   Write(Model.entidad.NIT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Entidades\ConsultarInformacionE.cshtml"
                   Write(Model.entidad.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Entidades\ConsultarInformacionE.cshtml"
                   Write(Model.entidad.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Entidades\ConsultarInformacionE.cshtml"
                   Write(Model.entidad.PaginaWeb);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Entidades\ConsultarInformacionE.cshtml"
                   Write(Model.entidad.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Entidades\ConsultarInformacionE.cshtml"
                   Write(Model.entidad.Sector);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 51 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Entidades\ConsultarInformacionE.cshtml"
                   Write(Model.entidad.TipoServicios);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Entidades\ConsultarInformacionE.cshtml"
                   Write(Model.entidad.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4511720242133b1f4c9fb6abd3630a74a35a20c98840", async() => {
                WriteLiteral("\r\n                             ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4511720242133b1f4c9fb6abd3630a74a35a20c99127", async() => {
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
#line 55 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Entidades\ConsultarInformacionE.cshtml"
                                                                                                       WriteLiteral(Model.entidad.Id);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Emigrant.App.Presentacion.Pages.ConsultarInformacionEModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Emigrant.App.Presentacion.Pages.ConsultarInformacionEModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Emigrant.App.Presentacion.Pages.ConsultarInformacionEModel>)PageContext?.ViewData;
        public Emigrant.App.Presentacion.Pages.ConsultarInformacionEModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591