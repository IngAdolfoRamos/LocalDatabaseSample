using System;
using System.Collections.Generic;
using System.Text;

namespace LocalDatabaseSample.Services
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string fileName);
    }
}
