﻿using System;
using System.IO;

using Vocabulary.Data.Languages;
using Vocabulary.Droid;

using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace Vocabulary.Droid
{
    class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}