#pragma checksum "E:\WebFolder\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1af3b2caf609b6a2fdf25d82c563acb0dcf714f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 2 "E:\WebFolder\Views\_ViewImports.cshtml"
using InventoryManagement;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1af3b2caf609b6a2fdf25d82c563acb0dcf714f", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b453ed080abe3d8314dfd66101486cdb48e8648", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<InventoryManagement.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary m-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("CategoryId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("BrandId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\WebFolder\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""container"">
        <div class=""col-md-12"">
            <div class=""col-md-6"">

            </div>
            <div class=""col-md-6"">

            </div>
        </div>
    </div>

</div>



<h1>&nbsp;&nbsp;Product List</h1>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1af3b2caf609b6a2fdf25d82c563acb0dcf714f5900", async() => {
                WriteLiteral("Create Product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 offset-4\">\r\n        <div class=\"col-md-4\">\r\n            <label class=\"control-label\"></label>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1af3b2caf609b6a2fdf25d82c563acb0dcf714f7523", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1af3b2caf609b6a2fdf25d82c563acb0dcf714f7799", async() => {
                    WriteLiteral("Select Category");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 31 "E:\WebFolder\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.CategoryList;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <label class=\"control-label\"></label>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1af3b2caf609b6a2fdf25d82c563acb0dcf714f10454", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1af3b2caf609b6a2fdf25d82c563acb0dcf714f10731", async() => {
                    WriteLiteral("Select Brand");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 37 "E:\WebFolder\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.BrandList;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        </div>


        <div class=""col-md-4 py-2 mb-5"">
            <button type=""button"" class=""btn btn-default btn-md float-right"" data-toggle=""modal"" data-target=""#advancedSearchModal"" id=""advancedsearch-button"" onclick=""popupSearch()"">
                <span class=""fas fa-search fa-fw"" aria-hidden=""true""></span> Advanced Search
            </button>
        </div>

    </div>
</div>

<table class=""table table-bordered table-hover table-striped"" id=""ProductTable"">
    <thead>
        <tr>
            <th>Product Code</th>
            <th>Product Name</th>
            <th>Sale Price</th>
            <th>Qty</th>
            <th>Category</th>
            <th>Brand</th>
            <th>Action</th>
        </tr>
    </thead>
    <tbody>
    </tbody>

</table>

<div class=""modal fade show"" id=""modal-lg"" style=""display: none; padding-right: 17px;"" aria-modal=""true"" role=""dialog"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div clas");
            WriteLiteral(@"s=""modal-header"">
                <h4 class=""modal-title"">Edit Product</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div id=""divid"">

                </div>

            </div>
");
            WriteLiteral(@"        </div>

    </div>

</div>



<div class=""modal fade show"" id=""modal-lg-Del"" style=""display: none; padding-right: 17px;"" aria-modal=""true"" role=""dialog"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Delete Product</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div id=""dividdelete"">

                </div>

            </div>
");
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
            WriteLiteral(@"


<div class=""modal fade show"" id=""modal-lg-AdvanceSearch"" style=""display: none; padding-right: 17px;"" aria-modal=""true"" role=""dialog"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Search Product</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">

                <table id=""assets-data-table""
                       class=""table table-striped table-bordered""
                       style=""width:100%;"">
                </table>

");
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral(@"        </div>

    </div>

</div>








<!--<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-6"">-->
<!-- general form elements -->
<!--<div class=""card card-primary"">
    <div class=""card-header"">
        <h3 class=""card-title"">CreateProduct</h3>
    </div>-->
<!-- /.card-header -->
<!-- form start -->
<!--<form role=""form"">
    <div class=""card-body"">
        <div class=""form-group"">
            <label for=""exampleInputEmail1"">Email address</label>
            <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" placeholder=""Enter email"">
        </div>
        <div class=""form-group"">
            <label for=""exampleInputPassword1"">Password</label>
            <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Password"">
        </div>
        <div class=""form-group"">
            <label for=""exampleInputFile"">File input</label>
            <div class=""input-group");
            WriteLiteral(@""">
                <div class=""custom-file"">
                    <input type=""file"" class=""custom-file-input"" id=""exampleInputFile"">
                    <label class=""custom-file-label"" for=""exampleInputFile"">Choose file</label>
                </div>
                <div class=""input-group-append"">
                    <span class=""input-group-text"" id="""">Upload</span>
                </div>
            </div>
        </div>
        <div class=""form-check"">
            <input type=""checkbox"" class=""form-check-input"" id=""exampleCheck1"">
            <label class=""form-check-label"" for=""exampleCheck1"">Check me out</label>
        </div>
    </div>-->
<!-- /.card-body -->
<!--<div class=""card-footer"">
            <button type=""submit"" class=""btn btn-primary"">Submit</button>
        </div>
    </form>
</div>-->
<!-- /.card -->
<!-- /.col-lg-6 -->
<!--</div>


</div>-->
<!-- /.card-body -->
<!--</div>-->
<!-- /.card -->
<!--</div>-->

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"




    <script>
        //$(document).ready(function () {
        //    $('#ProductTable').DataTable();
        //});

        $(""bbb"").click(function () {


        });

  



        function Popup(u) {

            $(""#modal-lg"").modal('show');
            $.get('/product/edit/' + u, function (data) {

                $(""#divid"").html("""");
                $(""#divid"").html(data);
                $('#modal-lg').on('hidden.bs.modal', function (e) {
                    popupSearch()
                })
            })

        }

        function popupDelete(d) {
            $(""#modal-lg-Del"").modal('show');
            $.get('/product/DeleteProduct?Id=' + d, function (data) {

                $(""#dividdelete"").html("""");
                $(""#dividdelete"").html(data);
            })
      
            $('#modal-lg-Del').on('hidden.bs.modal', function (e) {
                popupSearch()
            })

        }


        function popupSearch() {
            debugg");
                WriteLiteral(@"er

            $.ajax({
                url: '/Product/AdvanceSearchViewModal',
                datatype: JSON,
                data: { BrandId: $('#BrandId').val(), CategoryId: $('#CategoryId').val() },
                success: function (kkk) {
                    if ($.fn.DataTable.isDataTable('#ProductTable')) {
                        $('#ProductTable').DataTable().destroy();
                    }
                    $('#ProductTable').dataTable({
                        data: kkk.data,  ///Json(new {data=''});  ///ProductID  == productID //network reposne
                        columns: [
                            { data: 'productId' },
                            { data: 'name' },
                            { data: 'salePrice' },
                            { data: 'qty' },                           
                            { data: 'categoryname' },
                            { data: 'brandname' },
                            {
                                render: functi");
                WriteLiteral(@"on (a, b, c) {
                                
                                    return '<a href=""javascript:void(0)"" onclick=""Popup('+c.productId+')"" class=""btn btn-primary"">Edit</a>' + ""|""
                                        + '<a class=""btn btn-danger"" href=""javascript:void(0)"" onclick=""popupDelete(' + c.productId +')"">Delete</a>'
                                }
                            },
                          
                            

                        ],
                    });
                }
            })

        }

                    //$(function () {
                    //    $(""#ProductTable"").DataTable();
                    //})
    </script>




");
            }
            );
            WriteLiteral(@"

<!--foreach (var item in Model)
       {
           <tr>
               <td>item.ProductId</td>
               <td>item.Name</td>
               <td>item.SalePrice</td>
               <td>
                   if (item.Category != null)
                   {
                       item.Category.Name
                   }

               </td>
               <td>
                   if (item.Brand != null)
                   {
                       item.Brand.Name
                   }
               </td>
               <td>
                   <button type=""button"" class=""btn btn-default"" onclick=""Popup(item.ProductId)"">EDIT</button>
               </td>
               <td>
                   <button type=""button"" class=""btn btn-default"" onclick=""popupDelete(item.ProductId)"">DELETE</button>
               </td>-->
<!--*<td>Html.ActionLink(""Edit"", ""Edit"", ""Product"",  new { id = item.ProductId } , new {class = ""btn btn-default"", data_toggle = ""modal"", data_target =""#modal-lg"" })</td>*
*");
            WriteLiteral("<td>Html.ActionLink(\"Edit\", \"Edit\", new { id = item.ProductId } , class=\"btn btn-default\" data-toggle=\"modal\" data-target=\"#modal-lg\")</td>*-->\r\n<!--</tr>\r\n\r\n}-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<InventoryManagement.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
