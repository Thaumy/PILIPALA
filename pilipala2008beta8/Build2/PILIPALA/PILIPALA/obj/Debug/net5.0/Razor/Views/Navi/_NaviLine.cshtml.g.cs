#pragma checksum "H:\博客项目\pilipala2008beta8\Build2\PILIPALA\PILIPALA\Views\Navi\_NaviLine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3d29d9bd7a2abb2422472292912b3472553f471"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Navi__NaviLine), @"mvc.1.0.view", @"/Views/Navi/_NaviLine.cshtml")]
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
#line 1 "H:\博客项目\pilipala2008beta8\Build2\PILIPALA\PILIPALA\Views\_ViewImports.cshtml"
using PILIPALA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\博客项目\pilipala2008beta8\Build2\PILIPALA\PILIPALA\Views\_ViewImports.cshtml"
using PILIPALA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\博客项目\pilipala2008beta8\Build2\PILIPALA\PILIPALA\Views\Navi\_NaviLine.cshtml"
using WaterLibrary.stru.pilipala;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\博客项目\pilipala2008beta8\Build2\PILIPALA\PILIPALA\Views\Navi\_NaviLine.cshtml"
using WaterLibrary.stru.pilipala.DB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "H:\博客项目\pilipala2008beta8\Build2\PILIPALA\PILIPALA\Views\Navi\_NaviLine.cshtml"
using WaterLibrary.stru.pilipala.Post.Property;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\博客项目\pilipala2008beta8\Build2\PILIPALA\PILIPALA\Views\Navi\_NaviLine.cshtml"
using WaterLibrary.com.MySQL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\博客项目\pilipala2008beta8\Build2\PILIPALA\PILIPALA\Views\Navi\_NaviLine.cshtml"
using WaterLibrary.com.pilipala;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\博客项目\pilipala2008beta8\Build2\PILIPALA\PILIPALA\Views\Navi\_NaviLine.cshtml"
using WaterLibrary.com.pilipala.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "H:\博客项目\pilipala2008beta8\Build2\PILIPALA\PILIPALA\Views\Navi\_NaviLine.cshtml"
using WaterLibrary.com.CommentLake;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d29d9bd7a2abb2422472292912b3472553f471", @"/Views/Navi/_NaviLine.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e60be9c90af2170990e47eff766018c8e075941", @"/Views/_ViewImports.cshtml")]
    public class Views_Navi__NaviLine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 12 "H:\博客项目\pilipala2008beta8\Build2\PILIPALA\PILIPALA\Views\Navi\_NaviLine.cshtml"
  
    WaterLibrary.stru.pilipala.User User;
    Reader Reader = new Reader();
    Writer Writer = new Writer();
    Counter Counter = new Counter();

    CommentLake CommentLake = new CommentLake();


    CORE.SetTables();
    CORE.SetViews();

    CORE.LinkOn += Reader.Ready;
    CORE.LinkOn += Writer.Ready;
    CORE.LinkOn += Counter.Ready;
    CORE.LinkOn += CommentLake.Ready;

    /* 启动内核 */
    User = CORE.Run();

    ViewBag.Avatar = User.Avatar;
    ViewBag.Name = User.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"NavLine\" class=\"L M bSha\">\r\n    <div class=\"contain cur bRds\" onclick=\"up(); showPost(12387, \'我\'); debounce(console.log(\'SS\'),1000)\">\r\n        <img class=\"Avatar bSha\"");
            BeginWriteAttribute("src", " src=\"", 993, "\"", 1014, 1);
#nullable restore
#line 38 "H:\博客项目\pilipala2008beta8\Build2\PILIPALA\PILIPALA\Views\Navi\_NaviLine.cshtml"
WriteAttributeValue("", 999, ViewBag.Avatar, 999, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"Name\">");
#nullable restore
#line 39 "H:\博客项目\pilipala2008beta8\Build2\PILIPALA\PILIPALA\Views\Navi\_NaviLine.cshtml"
                     Write(ViewBag.Name.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"的小站</div>
    </div>
    <div class=""SiderBtn R cur"" onclick=""ListToggle()""></div>
</div>

<div id=""SiderList"" class=""bSha"">
    <m-card v-for=""d in List"" v-bind:item=""d"" v-bind:key=""d.index""></m-card>

    <div class=""Co cur"" onclick=""up();(12388,'关于博客');ListToggle()"">
        ");
#nullable restore
#line 48 "H:\博客项目\pilipala2008beta8\Build2\PILIPALA\PILIPALA\Views\Navi\_NaviLine.cshtml"
    Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"的博客©2016-2020保留所有权利<br>
        基于pilipala构建<br>
        Field Theme Designed By Thaumy<br>
    </div>
</div>

<div class=""Shadow"" onclick=""ListToggle()""></div>

<!-- vue导航组件 -->
<script>
    Vue.component('m-card', {
        props: ['item'],
        template: '<div class=""Card cur bRds"" v-on:click=""m_card_click(item.ID)"" :key=""item.index""><div class=""contain"">{{item.Title}}</div></div>',
        methods: {
            m_card_click: function (ID) {
                up();
                ListToggle();

                showPost(ID);

                AvaOutline.style = {
                    'border-color': 'rgba(0,0,0,0)'
                }
                CoOutline.style = {
                    'border-color': 'rgba(0,0,0,0)'
                }
            }
        }
    })
</script>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICORE CORE { get; private set; }
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