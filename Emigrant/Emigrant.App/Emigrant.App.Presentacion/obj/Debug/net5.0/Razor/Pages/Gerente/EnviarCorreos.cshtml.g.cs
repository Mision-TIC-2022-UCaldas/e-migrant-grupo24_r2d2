#pragma checksum "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a15586579e352c6a65c265e6b989ac91e526920"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Emigrant.App.Presentacion.Pages.Gerente.Pages_Gerente_EnviarCorreos), @"mvc.1.0.razor-page", @"/Pages/Gerente/EnviarCorreos.cshtml")]
namespace Emigrant.App.Presentacion.Pages.Gerente
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a15586579e352c6a65c265e6b989ac91e526920", @"/Pages/Gerente/EnviarCorreos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c587e1ae29f3d71737a581da5d83833e4c791939", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Gerente_EnviarCorreos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("formulario-contacto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/SuspenderCuenta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a15586579e352c6a65c265e6b989ac91e5269204715", async() => {
                WriteLiteral(@"
    <label for=""nombre"">Nombre:</label>
    <input type=""text"" name=""Nombre"" id=""Nombre"" />
    <br />

    <label for=""correo"">Correo:</label>
    <input type=""email"" name=""Correo"" id=""Correo"" />
    <br />

    <label for=""mensaje"">Mensaje:</label>
    <textarea name=""Mensaje"" id=""Mensaje""  cols=""30"" rows=""10""></textarea>
    <br />
    <input id=""enviarCorreoM"" type=""submit"" value=""Enviar a todos los migrantes""/>
    <input id=""enviarCorreoE"" type=""submit"" value=""Enviar a todas las entidades""/>  
    
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<br />
<br />

<div class=""content-wrapper"" style=""display:flex; justify-content:center; align-items:start; background-color:#FFFFFF;"">
  <div class=""container-fluid"">
    <div class=""row"" style=""justify-content:center;"">
      <div class=""col-md-12"" style=""padding-top:1rem; padding-left:1rem; padding-right:1rem; "">
  
        <div class=""card"">
          <div class=""card-header"" style=""background-color:#FCC16D; border-style:none; color:#000000;"">
            <h3 class=""card-title"">Lista Migrantes</h3>

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
                 ");
            WriteLiteral(@" <th>Apellido</th>
                  <th>Pais Origen</th>
                  <th>Ciudad</th>
                  <th>Tipo Documento</th>
                  <th>Numero</th>
                  <th>Suspender Cuenta</th>
                </tr>
              </thead>
              <tbody>
");
#nullable restore
#line 57 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                  
                      if(Model.entidades != null){  
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                         foreach (var migrante in Model.migrantes)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 62 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                           Write(migrante.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 63 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                           Write(migrante.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 64 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                           Write(migrante.PaisOrigen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 65 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                           Write(migrante.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 66 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                           Write(migrante.TipoDoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 67 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                           Write(migrante.Documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a15586579e352c6a65c265e6b989ac91e52692010857", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a15586579e352c6a65c265e6b989ac91e52692011148", async() => {
                    WriteLiteral("Enviar Correo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                                                                        WriteLiteral(migrante.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                                                                                                      WriteLiteral(migrante.TipoCuenta);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Type"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Type", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Type"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("                    \r\n                            ");
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
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 74 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                         
                      }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"              </tbody>
            </table>
          </div>
          <!-- /.card-body -->
        </div>
      </div>
    </div>
  </div>
</div>

<br />



<div class=""content-wrapper"" style=""display:flex; justify-content:center; align-items:start; background-color:#FFFFFF;"">
  <div class=""container-fluid"">
    <div class=""row"" style=""justify-content:center;"">
      <div class=""col-md-12"" style=""padding-top:1rem; padding-left:1rem; padding-right:1rem; "">
  
        <div class=""card"">
          <div class=""card-header"" style=""background-color:#FCC16D; border-style:none; color:#000000;"">
            <h3 class=""card-title"">Lista Entidades</h3>

            <div class=""card-tools"">
              <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" title=""Collapse"">
                <i class=""fas fa-minus""></i>
              </button>

            </div>
          </div>
          <!-- /.card-header -->
          <div class=""card-body table-responsive p-0"">
      ");
            WriteLiteral(@"      <table class=""table table-hover text-nowrap"">
              <thead>
                <tr>
                  <th>Razon Social</th>
                  <th>NIT</th>
                  <th>Direccion</th>
                  <th>Telefono</th>
                  <th>Ciudad</th>
                  <th>Sector</th>
                  <th>Tipo de Servicio</th>
                  <th>Suspender Cuenta</th>
                </tr>
              </thead>
              <tbody>
                  
");
#nullable restore
#line 124 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                    
                      if(Model.entidades != null){
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                         foreach (var entidad in Model.entidades)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 129 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                               Write(entidad.RazonSocial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 130 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                               Write(entidad.NIT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 131 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                               Write(entidad.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 132 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                               Write(entidad.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 133 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                               Write(entidad.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 134 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                               Write(entidad.Sector);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 135 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                               Write(entidad.TipoServicios);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a15586579e352c6a65c265e6b989ac91e52692021020", async() => {
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a15586579e352c6a65c265e6b989ac91e52692021315", async() => {
                    WriteLiteral("Enviar Correo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 138 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                                                                                                  WriteLiteral(entidad.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 138 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                                                                                                                               WriteLiteral(entidad.TipoCuenta);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Type"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Type", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Type"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("                    \r\n                                ");
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
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 142 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
                          
                      }
                  

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                
              </tbody>
            </table>
          </div>
          <!-- /.card-body -->
        </div>
      </div>
    </div>
  </div>
</div>



<script>

  const btnEnvio = document.getElementById('enviarCorreoM');
  
  btnEnvio.addEventListenet('click', funtion(e){
");
#nullable restore
#line 163 "F:\Documentos\Jesus\MisionTIC\Hackaton\e-migrant-grupo24_r2d2\Emigrant\Emigrant.App\Emigrant.App.Presentacion\Pages\Gerente\EnviarCorreos.cshtml"
      Console.WriteLine("Por aqui pase");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    e.preventDefault();
    const Correo = document.getElementById('Correo').value;
    const Nombre = document.getElementById('Nombre').value;
    const Mensaje = document.getElementById('Mensaje').value;
    window.location.href='mailto:jedaga123@gmail.com?subject=envioDesdeFormulario&body=Nombre%3A%20${Nombre}%0ACorreo%3A%20${Correo}%0AMensaje%3A%20${Mensaje}';
    
  });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Emigrant.App.Presentacion.Pages.EnviarCorreosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Emigrant.App.Presentacion.Pages.EnviarCorreosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Emigrant.App.Presentacion.Pages.EnviarCorreosModel>)PageContext?.ViewData;
        public Emigrant.App.Presentacion.Pages.EnviarCorreosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591