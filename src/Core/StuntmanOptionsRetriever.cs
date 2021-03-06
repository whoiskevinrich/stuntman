﻿using System;
using System.IO;
using System.Net;

namespace RimDev.Stuntman.Core
{
    public class StuntmanOptionsRetriever
    {
        public virtual string GetStringFromLocalFile(Uri uri)
        {
            return File.ReadAllText(uri.AbsolutePath);
        }

        public virtual string GetStringUsingWebClient(Uri uri)
        {
            return new WebClient().DownloadString(uri);
        }
    }
}
