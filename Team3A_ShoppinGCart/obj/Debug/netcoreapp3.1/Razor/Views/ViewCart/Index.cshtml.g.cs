#pragma checksum "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdcb36b32f1ce6be0d06047272affd2003e45a0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ViewCart_Index), @"mvc.1.0.view", @"/Views/ViewCart/Index.cshtml")]
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
#line 1 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\_ViewImports.cshtml"
using ShoppinG_Cart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\_ViewImports.cshtml"
using ShoppinG_Cart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdcb36b32f1ce6be0d06047272affd2003e45a0e", @"/Views/ViewCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff75bc593bdde8d7d5cfa9d63246711131ecfe5", @"/Views/_ViewImports.cshtml")]
    public class Views_ViewCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ViewCart/ViewCart.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Placholder Image 2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-frame"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml"
  
    ViewData["Title"] = "ViewCart";
    Layout = "_ViewCartLayout";
    //List<Cart_Model> cart = (List<Cart_Model>)ViewData["cart"];
    //double TotalAmt = 0.0;
    List<UserCart> cart = (List<UserCart>)ViewData["selectedproducts"];
    var count = ViewData["count"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdcb36b32f1ce6be0d06047272affd2003e45a0e5491", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"x-ua-compatible\" content=\"ie=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <title>Basket</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cdcb36b32f1ce6be0d06047272affd2003e45a0e5959", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdcb36b32f1ce6be0d06047272affd2003e45a0e7841", async() => {
                WriteLiteral("\r\n    <main>\r\n        <div class=\"basket\">\r\n");
                WriteLiteral(@"            <div class=""basket-labels"">
                <ul>
                    <li class=""item item-heading"">Item</li>
                    <li class=""price"">Price</li>
                    <li class=""quantity"">Quantity</li>
                    <li class=""subtotal"">Subtotal</li>
                </ul>
            </div>
");
#nullable restore
#line 37 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml"
              

                double TotalAmt = 0.0;

                foreach (var item in cart)
                {
                    
                    TotalAmt += @item.subTotal;
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"basket-product\">\r\n                            <div class=\"item\">\r\n                                <div class=\"product-image\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cdcb36b32f1ce6be0d06047272affd2003e45a0e9169", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1690, "~/images/softwares/", 1690, 19, true);
#nullable restore
#line 48 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml"
AddHtmlAttributeValue("", 1709, item.ProductImage, 1709, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"product-details\">\r\n                                    <h1><strong>");
#nullable restore
#line 51 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml"
                                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong> </h1>\r\n                                    <p>");
#nullable restore
#line 52 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml"
                                  Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"price\">");
#nullable restore
#line 55 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml"
                                          Write(item.ProductPrice.ToString(format: "#,##0.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                            <div class=\"quantity\">\r\n                                <input type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 2307, "\"", 2336, 1);
#nullable restore
#line 57 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml"
WriteAttributeValue("", 2315, item.ProductQuantity, 2315, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"1\" class=\"quantity-field\">\r\n                            </div>\r\n                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2455, "\"", 2478, 1);
#nullable restore
#line 59 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml"
WriteAttributeValue("", 2463, item.ProductId, 2463, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <div class=\"subtotal\">");
#nullable restore
#line 60 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml"
                                             Write(item.subTotal.ToString(format: "#,##0.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                            <div class=\"remove\">\r\n");
                WriteLiteral("                                <button value=\"Remove\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2915, "\"", 2981, 5);
                WriteAttributeValue("", 2925, "DeleteProduct(\'", 2925, 15, true);
#nullable restore
#line 64 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml"
WriteAttributeValue("", 2940, item.ProductId, 2940, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2955, "\',\'", 2955, 3, true);
#nullable restore
#line 64 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml"
WriteAttributeValue("", 2958, item.ProductQuantity, 2958, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2979, "\')", 2979, 2, true);
                EndWriteAttribute();
                WriteLiteral(">Remove</button>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 67 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div width=\"auto\" style=\"margin-left:300px; font-size:20px;\">");
#nullable restore
#line 69 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml"
                                                                Write(Html.ActionLink("Continue Shopping", "Index", "List"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
        </div>
        <aside>
            <div class=""summary"">
                <div class=""summary-total-items""><span class=""total-items""></span> Items in your Bag</div>
                <div class=""summary-subtotal"">
                    <div class=""subtotal-title"">Subtotal</div>
                    <div class=""subtotal-value final-value"" id=""basket-subtotal"">");
#nullable restore
#line 76 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml"
                                                                            Write(TotalAmt.ToString(format: "#,##0.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                    <div class=""summary-promo hide"">
                        <div class=""promo-title"">Promotion</div>
                        <div class=""promo-value final-value"" id=""basket-promo""></div>
                    </div>
                </div>

                <div class=""summary-total"">
                    <div class=""total-title"">Total</div>
                    <div class=""total-value final-value"" id=""basket-total"">");
#nullable restore
#line 85 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml"
                                                                      Write(TotalAmt.ToString(format: "#,##0.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"summary-checkout\">\r\n                    <button class=\"checkout-cta\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4261, "\"", 4292, 3);
                WriteAttributeValue("", 4271, "AddOrder(\'", 4271, 10, true);
#nullable restore
#line 88 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml"
WriteAttributeValue("", 4281, TotalAmt, 4281, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4290, "\')", 4290, 2, true);
                EndWriteAttribute();
                WriteLiteral(">Checkout</button>\r\n\r\n");
                WriteLiteral("                </div>\r\n            </div>\r\n        </aside>\r\n    </main>\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $("".quantity-field"").on(""change"", function () {
            var productID = $(this).parent().next().val();
            var quantity=$(this).val();
            var productPrice = $(this).parent().prev().text();
            $(this).parent().next().text(quantity * productPrice);
            var subtotal = $(this).parent().next().text();

            $.ajax({
                type: ""POST"",
                contentType: ""application/json"",
                url: `");
#nullable restore
#line 111 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml"
                 Write(Url.Action("Quantity", "ViewCart"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`,
                data: JSON.stringify({
                    ProductId: productID, ProductQuantity: Number(quantity), subTotal: Number(subtotal)
                }),
                success: function (response) {

                },
                error: function (response) {
                    var result = JSON.parse(response.responseText);
                    console.error(""error "" + result);
                },
                complete: function(result){
                location.href=""../ViewCart/Index"";
            }
            });

        })
     //remove item from cart
    function DeleteProduct(id, qty) {
        $.ajax({
            cache: false,
            url: '");
#nullable restore
#line 132 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml"
             Write(Url.Action("Delete", "ViewCart"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
            data: { id: id, qty: qty},
            success: function (result) {
                if (result.success) {
                    //alert(""Delete succeed"");
                }
                else {
                    alert(""Remove item is failed."")
                }
            },
            complete: function(result){
                //window.location.replace(result.newUrl);
                location.href=""../ViewCart/Index"";
            }

    });
        }

        //Checkout
        function AddOrder(totalamt) {
        $.ajax({
            cache: false,
            url: '");
#nullable restore
#line 154 "G:\NUS ISS SA 50\Term1\SA4102\NETCORE\CA\T3A-submission\Team3A_ShoppingCart\Team3A_ShoppinGCart\Views\ViewCart\Index.cshtml"
             Write(Url.Action("AddOrder", "ViewCart"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
            data: {  totalamt: totalamt },
            success: function (result) {
                if (result.success) {
                    alert(""Order is successful."");
                    location.href = ""../MyPurchases/Index"";
                }
                else {
                    alert(""Login Required"");

                    location.href = ""../Login/Index"";
                }
            },
            complete: function (result) {
            }
    });
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
