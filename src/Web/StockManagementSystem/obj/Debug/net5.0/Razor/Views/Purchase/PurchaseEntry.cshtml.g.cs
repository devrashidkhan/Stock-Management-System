#pragma checksum "E:\LEADS IT\StockManagementSystem\Views\Purchase\PurchaseEntry.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf88bc913f9c3419ef7b4476166101ea0fa35341"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchase_PurchaseEntry), @"mvc.1.0.view", @"/Views/Purchase/PurchaseEntry.cshtml")]
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
#line 1 "E:\LEADS IT\StockManagementSystem\Views\_ViewImports.cshtml"
using StockManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\LEADS IT\StockManagementSystem\Views\_ViewImports.cshtml"
using StockManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf88bc913f9c3419ef7b4476166101ea0fa35341", @"/Views/Purchase/PurchaseEntry.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0fb294ee70aca11051a3cc05a73456c6f2024a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Purchase_PurchaseEntry : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Purchase>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("purchaseForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PurchaseEntry", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "E:\LEADS IT\StockManagementSystem\Views\Purchase\PurchaseEntry.cshtml"
  
    ViewData["Title"] = "Purchase Entry";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <div class=\"card shadow\">\r\n        <div class=\"card-header py-3\">\r\n            <h6 class=\"m-0 font-weight-bold text-primary\">Purchase</h6>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf88bc913f9c3419ef7b4476166101ea0fa353415096", async() => {
                WriteLiteral(@"


            <div class=""form-group row"">
                <div class=""col-sm-2""></div>
                <label for=""vendorId"" class=""col-sm-3 col-form-label"">Vendor Name</label>
                <div class=""col-sm-5"">
                    <select  required class=""selectpicker form-select form-select mb-3"" Name=""VendorId"" id=""vendorId"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf88bc913f9c3419ef7b4476166101ea0fa353415736", async() => {
                    WriteLiteral("Select Vendor");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 22 "E:\LEADS IT\StockManagementSystem\Views\Purchase\PurchaseEntry.cshtml"
                         foreach (var item in ViewBag.Vendors)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf88bc913f9c3419ef7b4476166101ea0fa353417917", async() => {
#nullable restore
#line 24 "E:\LEADS IT\StockManagementSystem\Views\Purchase\PurchaseEntry.cshtml"
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
#line 24 "E:\LEADS IT\StockManagementSystem\Views\Purchase\PurchaseEntry.cshtml"
                               WriteLiteral(item.VendorId);

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
#line 25 "E:\LEADS IT\StockManagementSystem\Views\Purchase\PurchaseEntry.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </select>
                </div>
                <div class=""col-sm-2""></div>

            </div>

            <div class=""form-group row"">
                <div class=""col-sm-2""></div>
                <label for=""categoryId"" class=""col-sm-3 col-form-label"">Category Name</label>
                <div class=""col-sm-5"">
                    <select required  class=""selectpicker form-select form-select mb-3"" Name=""CategoryId"" id=""categoryId"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf88bc913f9c3419ef7b4476166101ea0fa3534110510", async() => {
                    WriteLiteral("Select Category");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 39 "E:\LEADS IT\StockManagementSystem\Views\Purchase\PurchaseEntry.cshtml"
                         foreach (var item in ViewBag.Categories)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf88bc913f9c3419ef7b4476166101ea0fa3534112697", async() => {
#nullable restore
#line 41 "E:\LEADS IT\StockManagementSystem\Views\Purchase\PurchaseEntry.cshtml"
                                                        Write(item.CategoryName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "E:\LEADS IT\StockManagementSystem\Views\Purchase\PurchaseEntry.cshtml"
                               WriteLiteral(item.CategoryId);

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
#line 42 "E:\LEADS IT\StockManagementSystem\Views\Purchase\PurchaseEntry.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </select>
                </div>
                <div class=""col-sm-2""></div>
            </div>

            <div class=""form-group row"">
                <div class=""col-sm-2""></div>
                <label for=""item_id"" class=""col-sm-3 col-form-label"">Item Name</label>
                <div class=""col-sm-5"">
                    <select  required name=""ItemId"" class=""selectpicker form-select form-select mb-3"" id=""item_id"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf88bc913f9c3419ef7b4476166101ea0fa3534115287", async() => {
                    WriteLiteral("Select Item");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
                <div class=""col-sm-2""></div>
            </div>

            <div class=""form-group row"">
                <div class=""col-sm-2""></div>
                <label for=""itemQuantiy"" class=""col-sm-3 col-form-label"">Item Quantity</label>
                <div class=""col-sm-5"">
                    <input  required type=""number"" class=""form-control"" id=""itemQuantiy"" name=""Quantity"" placeholder=""Item Quantity"">

                </div>
                <div class=""col-sm-2"" id=""availableQuantiy"">

                </div>
            </div>

            <div class=""form-group row"">
                <div class=""col-sm-2""></div>
                <label for=""unitPrice"" class=""col-sm-3 col-form-label"">Unit Price</label>
                <div class=""col-sm-5"">
                    <input required type=""number"" class=""form-control"" id=""unitPrice"" name=""UnitPrice"" placeholder=""Unit price"">

                </div>
                <div class=""c");
                WriteLiteral(@"ol-sm-2""></div>
            </div>

            <div class=""form-group row"">
                <div class=""col-sm-2""></div>
                <label for=""purchaseDate"" class=""col-sm-3 col-form-label"">Purchase Date</label>
                <div class=""col-sm-5"">
                    <input required type=""date""");
                BeginWriteAttribute("value", " value=\"", 3664, "\"", 3708, 1);
#nullable restore
#line 86 "E:\LEADS IT\StockManagementSystem\Views\Purchase\PurchaseEntry.cshtml"
WriteAttributeValue("", 3672, DateTime.Now.ToString("yyyy-MM-dd"), 3672, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" id=""purchaseDate"" name=""PurchaseDate"" placeholder=""Purchase Date"">

                </div>
                <div class=""col-sm-2""></div>
            </div>

            <div class=""form-group row"">
                <div class=""col-sm-5""></div>

                <div class=""col-sm-7"">
                    <input type=""button"" id=""purchase"" class=""btn btn-success"" name=""Save"" value=""Purchase"" />

                </div>
            </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n\r\n    $(document).ready(function () {\r\n        $(\'#categoryId\').on(\'change\', function () {\r\n            var category_id = $(\'#categoryId\').val();\r\n            let url = \'");
#nullable restore
#line 111 "E:\LEADS IT\StockManagementSystem\Views\Purchase\PurchaseEntry.cshtml"
                  Write(Url.Action("GetItemByCategory", "Purchase"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';

            let parameters = {
                cid: category_id
            };

            AjaxPostRequest(url, parameters, function (response) {

                var $select = $('#item_id');
                console.log(response);
                $select.find('option').remove();
                $('#item_id').append('<option value = ""0"" disabled selected > Select Item</option>')

                $.each(response, function (key, value) {
                    //$('#item_id').append('<option value=' + value.ItemId + ',' + value.Quantity +'>'+ value.Name + '</option > ');
                    $('<option/>') 
                        .val(value.ItemId)
                        .text(value.Name)
                        .appendTo('#item_id');
                });

                $('#item_id').on('change', function () {
                    let itemId = $('#item_id').val();
                    //alert(itemId);
                    //var available = response.filter(element => element.ItemId == ite");
                WriteLiteral(@"mId)[0].Quantity;
                    //$('#availableQuantiy').empty();
                    //$('#availableQuantiy').append('<p id=""qty"">Available: <span style=color:green>' + available + '<span></p>');
                });

            });

        });
        function AjaxPostRequest(url, parameters, successCallback) {
            $.ajax({
                type: 'POST',
                dataType: 'json',
                url: url,
                data: parameters,
                cache: false,
                success: successCallback,
                error: function (err) {
                    alert(""Failed to Load Data"");
                    //console.log(err);
                }
            });
        }

        $('#purchase').on('click', function () {
            if ($(""#purchaseForm"")[0].checkValidity()) {
                Swal.fire({
                    title: 'Do you want to purchase?',
                    showCancelButton: true,
                    confirmButtonText: 'Purchase'");
                WriteLiteral(@",
                }).then((result) => {
                    /* Read more about isConfirmed, isDenied below */
                    if (result.isConfirmed) {

                        $('#purchaseForm').submit();

                    }
                })
            }
            else {
                $(""#purchaseForm"")[0].reportValidity();
            }
           
            
                
        });
       

    });

    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Purchase> Html { get; private set; }
    }
}
#pragma warning restore 1591
