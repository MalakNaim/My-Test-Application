#pragma checksum "D:\githup\My-Test-Application\TaskApp\TaskApp.Web\Areas\Admin\Views\Status\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fc8c5ae3833bb8f1284f5728264ed9e31276a61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Status_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Status/Create.cshtml")]
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
#line 2 "D:\githup\My-Test-Application\TaskApp\TaskApp.Web\Areas\Admin\Views\Status\Create.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\githup\My-Test-Application\TaskApp\TaskApp.Web\Areas\Admin\Views\Status\Create.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\githup\My-Test-Application\TaskApp\TaskApp.Web\Areas\Admin\Views\Status\Create.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fc8c5ae3833bb8f1284f5728264ed9e31276a61", @"/Areas/Admin/Views/Status/Create.cshtml")]
    public class Areas_Admin_Views_Status_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskApp.Web.DTOs.StatusDTO.CreateStatusDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\githup\My-Test-Application\TaskApp\TaskApp.Web\Areas\Admin\Views\Status\Create.cshtml"
  
    string z = System.Globalization.CultureInfo.CurrentCulture.Name;

    if (Context.Request.Headers["X-Requested-With"].Equals("XMLHttpRequest"))
    {
        ViewData["Title"] = "Add Status  ";
        Layout = "~/Areas/Admin/Views/Shared/_EmptyLayout.cshtml";

    }
    else
    {
        ViewData["Title"] = "Add Status  ";
        Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<form asp-action=""Create"" tname=""StatusTable"" method=""post"" class=""ajaxForm"">

    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label class=""control-label"">Name</label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
        </div>
    </div>



    <div class=""form-group"" style=""float:right;"">
        <button type=""submit"" class=""btn btn-primary text-white"">Create <i class=""fa fa-arrow-right text-white""></i></button>
    </div>


</form>


<partial name=""_ValidationScriptsPartial"" />

<script>
    PageLoadActions();
</script>



");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<RequestLocalizationOptions> LocOptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskApp.Web.DTOs.StatusDTO.CreateStatusDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
