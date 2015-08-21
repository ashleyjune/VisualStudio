﻿using GitHub.Extensions;
using GitHub.Primitives;
using GitHub.UI;
using System;

namespace GitHub.Models
{
    public class SimpleRepositoryModel : ISimpleRepositoryModel
    {
        public SimpleRepositoryModel(string name, UriString cloneUrl, string localPath = null)
        {
            Name = name;
            CloneUrl = cloneUrl;
            LocalPath = localPath;
        }
        public string Name { get; private set; }
        public UriString CloneUrl { get; private set; }
        public string LocalPath { get; private set; }
    }
}