﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;
using WaterLibrary.Util;
using WaterLibrary.pilipala;
using WaterLibrary.pilipala.Entity;
using WaterLibrary.pilipala.Entity.PostProp;
using WaterLibrary.pilipala.Components;

namespace PILIPALA.Controllers
{
    public class PanelController : Controller
    {
        public Reader Reader;
        public Writer Writer;
        public Counter Counter;
        public CommentLake CommentLake;

        private readonly ComponentFactory ComponentFactory = new();

        public PanelController(ICORE CORE)
        {
            CORE.CoreReady += ComponentFactory.Ready;

            /* 启动内核 */
            CORE.Run();

            Reader = ComponentFactory.GenReader(Reader.ReadMode.CleanRead);
            Writer = ComponentFactory.GenWriter();
            Counter = ComponentFactory.GenCounter();
            CommentLake = ComponentFactory.GenCommentLake();
        }

        public ActionResult List(bool ajax)
        {
            string fun(string s)
            {
                var archive = system.ThemeReader.GetConfigJson("wwwroot/field_config.json")["Pannel"][s].ToList();
                return ConvertH.ListToString(archive, '|');
            }

            PostSet PostSet置顶 = new PostSet();
            foreach (Post el in Reader.GetPost<ArchiveName>(fun("ToppedArchive")))
            {
                el.PropertyContainer.Add("CommentCount", CommentLake.GetCommentCount(el.PostID));
                PostSet置顶.Add(el);
            }
            ViewBag.置顶文章 = PostSet置顶;

            PostSet PostSet其他 = new PostSet();
            foreach (Post el in Reader.GetPost<ArchiveName>(fun("DefaultArchive")))
            {
                el.PropertyContainer.Add("CommentCount", CommentLake.GetCommentCount(el.PostID));
                PostSet其他.Add(el);
            }
            ViewBag.其他文章 = PostSet其他;

            if (ajax == false)
            {
                ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
                return View();
            }
            else
            {
                ViewBag.Layout = null;
                return View();
            }

        }
        public ActionResult Content(int ID, bool ajax)
        {
            string fun(string s)
            {
                var archive = system.ThemeReader.GetConfigJson("wwwroot/field_config.json")["Pannel"][s].ToList();
                return ConvertH.ListToString(archive, '|');
            }

            ViewBag.ID = ID;//请求ID

            ViewBag.Post = Reader.GetPost(ID);//文章数据
            ViewBag.Post.PropertyContainer.Add("CommentCount", CommentLake.GetCommentCount(ID));//添加评论计数，可优化


            ViewBag.CommentList = CommentLake.GetComments(ID);//评论数据

            ViewBag.PrevID = Reader.Smaller<PostID>(ID, fun("DefaultArchive"), PostPropEnum.ArchiveName);
            ViewBag.PrevTitle = Reader.GetPostProp<Title>(ViewBag.PrevID);

            ViewBag.NextID = Reader.Bigger<PostID>(ID, fun("DefaultArchive"), PostPropEnum.ArchiveName);
            ViewBag.NextTitle = Reader.GetPostProp<Title>(ViewBag.NextID);



            if (ajax == false)
            {
                ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
                return View();
            }
            else
            {
                ViewBag.Layout = null;
                return View();
            }

        }
    }
}
