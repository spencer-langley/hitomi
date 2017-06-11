using Hitomi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hitomi.Controllers
{
    public class VideosController : Controller
    {
        //
        // GET: /Videos/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult A()
        {
            VideoModel videoA = new VideoModel
            {
                VideoId = "xqeR8gwEPiI",
                VideoName = "DRO Technical Final"
            };
            return View("Video", videoA);
        }

        public ActionResult B()
        {
            VideoModel videoB = new VideoModel
            {
                VideoId = "YhgT3IeOk6Q",
                VideoName = "DRO Conversational Final"
            };
            return View("Video", videoB);
        }

        public ActionResult C()
        {
            VideoModel videoC = new VideoModel
            {
                VideoId = "cOlxtQqaNkI",
                VideoName = "Pairing Conversational"
            };
            return View("Video", videoC);
        }

        public ActionResult D()
        {
            VideoModel videoD = new VideoModel
            {
                VideoId = "7wZ6pmODGc0",
                VideoName = "Pairing Technical"
            };
            return View("Video", videoD);
        }

        public ActionResult E()
        {
            VideoModel videoE = new VideoModel
            {
                VideoId = "qClzarQXI-E",
                VideoName = "Misconception Autism"
            };
            return View("Video", videoE);
        }

        public ActionResult F()
        {
            VideoModel videoF = new VideoModel
            {
                VideoId = "l34vH3YWF2E",
                VideoName = "Misconception Punishment"
            };
            return View("Video", videoF);
        }

        public ActionResult G()
        {
            VideoModel videoG = new VideoModel
            {
                VideoId = "C9OBpAujtMk",
                VideoName = "Generality Interview"
            };
            return View("Video", videoG);
        }

        public ActionResult H()
        {
            VideoModel videoH = new VideoModel
            {
                VideoId = "t_VCA9h0jjY",
                VideoName = "Generality Everyday Life"
            };
            return View("Video", videoH);
        }
    }
}