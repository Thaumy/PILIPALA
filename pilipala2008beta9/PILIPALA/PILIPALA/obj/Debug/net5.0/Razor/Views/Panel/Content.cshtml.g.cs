#pragma checksum "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "836b3af4cdbca0f10ef5d95e95b8f027c6bcc79f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Panel_Content), @"mvc.1.0.view", @"/Views/Panel/Content.cshtml")]
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
#line 1 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\_ViewImports.cshtml"
using PILIPALA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\_ViewImports.cshtml"
using PILIPALA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
using PILIPALA.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
using WaterLibrary.pilipala.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"836b3af4cdbca0f10ef5d95e95b8f027c6bcc79f", @"/Views/Panel/Content.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e60be9c90af2170990e47eff766018c8e075941", @"/Views/_ViewImports.cshtml")]
    public class Views_Panel_Content : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
  
    ViewBag.Title = "Content";
    Layout = ViewBag.Layout;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"Card M bSha bRds\">\r\n    <div class=\"contain bRds\">\r\n\r\n        ");
#nullable restore
#line 13 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
   Write(Html.Raw(ViewBag.Post.Cover));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 15 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
         if (ViewBag.Post.Title != "")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"Title\">");
#nullable restore
#line 17 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                          Write(ViewBag.Post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 18 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
         if (ViewBag.Post.Summary != "")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"Summary\">");
#nullable restore
#line 21 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                            Write(ViewBag.Post.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 22 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
        }

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
         if (ViewBag.Post.Mode == "scheduled")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"SchedulTip bSha\"><div class=\"con\">计划中的项目。此文章将会于近期更新</div></div>\r\n");
#nullable restore
#line 28 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
         if (ViewBag.Post.Mode == "archived")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"ArchivTip bSha\"><div class=\"con\">此文章已归档。这意味着其内容将不受维护，但仍具有一定的参考价值。</div></div>\r\n");
#nullable restore
#line 32 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"ReadTimeTip bSha\">\r\n            <div class=\"con\"></div>\r\n        </div>\r\n\r\n        <div class=\"Content markdown-body\">");
#nullable restore
#line 39 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                      Write(Html.Raw(ViewBag.Post.HtmlContent()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            WriteLiteral("        <div>\r\n");
#nullable restore
#line 43 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
             if (ViewBag.NextID != -1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"nxtBtn L bRds cur\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1168, "\"", 1208, 3);
            WriteAttributeValue("", 1178, "up();showPost(", 1178, 14, true);
#nullable restore
#line 45 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
WriteAttributeValue("", 1192, ViewBag.NextID, 1192, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1207, ")", 1207, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 45 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                                                                    Write(ViewBag.NextTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 46 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
             if (ViewBag.PrevID != -1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"pvsBtn R bRds cur\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1354, "\"", 1394, 3);
            WriteAttributeValue("", 1364, "up();showPost(", 1364, 14, true);
#nullable restore
#line 49 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
WriteAttributeValue("", 1378, ViewBag.PrevID, 1378, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1393, ")", 1393, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                                                                    Write(ViewBag.PrevTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 50 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <script>\r\n");
            WriteLiteral("        hljs.highlightAll();\r\n");
            WriteLiteral("        putWordCount();\r\n    </script>\r\n\r\n</div>\r\n\r\n<div class=\"CoBox M bSha\">\r\n    <span class=\"text_auth L\">由 ");
#nullable restore
#line 64 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                           Write(ViewBag.Post.User);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 最后编辑于 ");
#nullable restore
#line 64 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                                     Write(Convert.ToString(ViewBag.Post.LCT.Year).Substring(2, 2) + "-" + ViewBag.Post.LCT.Month + "-" + ViewBag.Post.LCT.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    <span");
            BeginWriteAttribute("title", " title=\"", 1832, "\"", 1867, 3);
            WriteAttributeValue("", 1840, "MD5签名", 1840, 5, true);
            WriteAttributeValue(" ", 1845, ":", 1846, 2, true);
#nullable restore
#line 65 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
WriteAttributeValue(" ", 1847, ViewBag.Post.MD5(), 1848, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text_mId R\">");
#nullable restore
#line 65 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                                            Write(ViewBag.Post.MD5(7));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n    <div class=\"AtBox bRds-b\">\r\n        <div class=\"Date\">创建于");
#nullable restore
#line 68 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                         Write(Convert.ToString(ViewBag.Post.CT.Year) + "-" + ViewBag.Post.CT.Month + "-" + ViewBag.Post.CT.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"UVCount\">");
#nullable restore
#line 69 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                        Write(ViewBag.Post.UVCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"CommentCount cur\">");
#nullable restore
#line 70 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                 Write(ViewBag.Post.PropertyContainer["CommentCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"StarCount cur\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2272, "\"", 2310, 3);
            WriteAttributeValue("", 2282, "refre_StarCount(", 2282, 16, true);
#nullable restore
#line 71 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
WriteAttributeValue("", 2298, ViewBag.ID, 2298, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2309, ")", 2309, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 71 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                                                     Write(ViewBag.Post.StarCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"Time\">");
#nullable restore
#line 72 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                     Write(Formatter.CN_Week(ViewBag.Post.CT));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 74 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
         if (ViewBag.Post.ArchiveName != "")
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"Archiv\">");
#nullable restore
#line 77 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                           Write(ViewBag.Post.ArchiveName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 78 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
         if (ViewBag.Post.Label != "")
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                        
            foreach (string el in ViewBag.Post.LabelList())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"Label\">");
#nullable restore
#line 84 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                              Write(el);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 85 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            WriteLiteral("<div>\r\n");
#nullable restore
#line 92 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
     if (ViewBag.CommentList.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"ShadowBox M\">\r\n            <div class=\"CommentTip bSha\">\r\n                <div class=\"con\">评论尚无，快来吃个螃蟹！</div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 99 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"CommentList M bSha bRds\">\r\n");
#nullable restore
#line 103 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
             foreach (Comment Comment in ViewBag.CommentList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"Box bSha\" onmouseover=\"CommentList_Over(this)\" onmouseleave=\"CommentList_Leave(this)\">\r\n");
#nullable restore
#line 106 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                     if (Comment.HEAD == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"Name\">");
#nullable restore
#line 108 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                     Write(Comment.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 109 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                
                        foreach (Comment temp in ViewBag.CommentList)
                        {
                            if (temp.CommentID == Comment.HEAD)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"Name\">\r\n                                    ");
#nullable restore
#line 118 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                Write(Comment.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("(回复)\r\n                                    <span class=\"ReplyLogo\"></span>\r\n                                    <span class=\"ReplyFloor\">");
#nullable restore
#line 120 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                                         Write(temp.Floor);

#line default
#line hidden
#nullable disable
            WriteLiteral("F</span>");
#nullable restore
#line 120 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                                                             Write(temp.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 122 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                break;
                            }
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"Floor cur bSha\" data-f=\"");
#nullable restore
#line 127 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                                   Write(Comment.Floor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-id=\"");
#nullable restore
#line 127 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                                                            Write(Comment.CommentID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" onclick=\"CommentBox.doReply(this)\">");
#nullable restore
#line 127 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                                                                                                                   Write(Comment.Floor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"Email\">");
#nullable restore
#line 128 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                  Write(Comment.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"Time\">");
#nullable restore
#line 129 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                  Write(Convert.ToString(Comment.Time.Year).Substring(2, 2) + "-" + Comment.Time.Month + "-" + Comment.Time.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 129 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                                                                                                                               Write(Comment.Time.Hour + ":" + Comment.Time.Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"Content\">");
#nullable restore
#line 130 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                                    Write(Comment.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n");
#nullable restore
#line 132 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 134 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div id=""CommentBox"" class=""CommentBox M bRds bSha"">
        <div class=""Content"">
            <div class=""Logo""></div>
            <div class=""ReplyLogo"" v-show=""HEAD""></div>
            <transition name=""fade"">
                <div class=""ReplyFloor cur"" v-show=""HEAD"" v-on:click=""closeReply"" onmouseover=""CommentBox_ReplyBtn_Over()""
                     onmouseleave=""CommentBox_ReplyBtn_Leave()"">
                    {{FloorText}}
                </div>
            </transition>
            <textarea v-model=""Content"" placeholder=""评论内容(必填)""></textarea>
        </div>
        <div class=""Name"">
            <div class=""Logo""></div>
            <input v-model=""Name"" placeholder=""昵称(必填)"" />
        </div>
        <div class=""Email"">
            <div class=""Logo""></div>
            <input v-model=""Email"" placeholder=""邮箱(必填)"" />
        </div>
        <div class=""WebSite"">
            <div class=""Logo""></div>
            <input v-model=""WebSite"" placeholder=""网站(可选)"" />
        </div>");
            WriteLiteral(@"
        <v-app class=""Captcha"" style=""background:rgba(0,0,0,0)"">
            <div>
                <v-btn color=""primary"" block height=""34"" onclick=""Commit()"" class=""CaptchaLine"">提交</v-btn>
            </div>
        </v-app>
    </div>
</div>

<!-- 评论组件 -->
<script>
    var CommentBox = new Vue({
        el: '#CommentBox',
        vuetify: new Vuetify(),
        data: {
            FloorText: '0F',

            HEAD: 0,
            Content: '',
            Name: '',
            Email: '',
            WebSite: ''
        },
        methods: {
            check: function () {
                if (ContentCheck(this.Content) &
                    NameCheck(this.Name) &
                    EmailCheck(this.Email) &
                    WebSiteCheck(this.WebSite)) {
                    //TODO
                    return true;
                } else {
                    //TODO
                    window.alert(""请检查填写是否有误"");
                    return false;
                }
        ");
            WriteLiteral(@"    },
            doReply: function (el) {
                this.FloorText = el.dataset.f + ""F"";
                this.HEAD = el.dataset.id;
            },
            closeReply: function () {
                /* HEAD为0时，回复不会显示 */
                this.HEAD = 0;
            }
        }
    })

    /* 鼠标移入移出回复按钮事件 */
    var FloorText_temp;
    function CommentBox_ReplyBtn_Over() {
        FloorText_temp = CommentBox.FloorText;
        CommentBox.FloorText = ""取消"";
    }
    function CommentBox_ReplyBtn_Leave() {
        CommentBox.FloorText = FloorText_temp;
    }
    function CommentList_Over(el) {
        $(el).children("".Floor"").text(""回复"");
        $(el).children("".Floor"").css({
            ""height"": ""22px"",
            ""width"": ""32px"",

            ""font-size"": ""0.8em"",
            ""font-weight"": ""500"",
            ""font-family"": ""Source Sans Pro"",
            ""color"": ""rgb(255, 255, 255)"",
            ""line-height"": ""22px"",

            ""background"": ""rgb(0, 180, 255)""
    ");
            WriteLiteral(@"    });
    }
    function CommentList_Leave(el) {
        /* 把属性data-f赋给内容 */
        $(el).children("".Floor"").text($(el).children("".Floor"").attr(""data-f""));
        /* 移除添加的样式 */
        $(el).children("".Floor"").removeAttr(""style"", """");
    }

    /*评论检查*/
    function ContentCheck(value) {
        if (value == """") {
            return false;
        } else {
            if (value.length > 320) {
                return false;
            } else {
                return true;
            }
        }
    };
    function NameCheck(value) {
        if (value == """") {
            return false;
        } else {
            if (value.length > 12) {
                return false;
            } else {
                return true;
            }
        }
    };
    function EmailCheck(value) {
        if (value == """") {
            return false;
        } else {
            const reg = /^([A-Za-z0-9_\-\.])+\");
            WriteLiteral(@"@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
            if (!reg.test(value)) {
                return false;
            } else {
                return true;
            }
        }
    };
    function WebSiteCheck(value) {
        if (value == """") {
            return true;
        } else {
            const reg0 = /^(http|https|ftp)\:\/\/([a-zA-Z0-9]([a-zA-Z0-9\-]{0,61}[a-zA-Z0-9])?\.)+[a-zA-Z]{2,6}(\/)?$/;
            if (!reg0.test(value)) {
                return false;
            } else {
                return true;
            }
        }
    };
</script>

<!-- 评论Captcha -->
<script>
    function Commit() {
        if (CommentBox.check() == true)
        {
            Captcha(");
#nullable restore
#line 293 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
               Write(ViewBag.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(", CommentBox.HEAD, CommentBox.Content, CommentBox.Name, CommentBox.Email, CommentBox.WebSite);\r\n        }\r\n    }\r\n</script>\r\n\r\n<script>\r\n    if ($.cookie(\'isStar\' + ");
#nullable restore
#line 299 "H:\GitHub\pilipala\pilipala2008beta9\PILIPALA\PILIPALA\Views\Panel\Content.cshtml"
                       Write(ViewBag.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(") == \'true\') {/* 如果cookie显示目前文本已点赞 */\r\n        starOpacity100();/* 透明度1 */\r\n    } else {\r\n        starOpacity050();/* 透明度0.5 */\r\n    }\r\n</script>\r\n\r\n<!-- Markdown数学公式支持(使用MathJax) -->\r\n<script>MathJax.typeset()</script>");
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
