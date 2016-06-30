#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

#endregion

namespace FormsSample.SampleControls
{
  public class FolderNode : System.Windows.Forms.TreeNode
  {
    string _folderPath = "";
    DirectoryInfo _info;

    public FolderNode(string folderPath)
    {
      _folderPath = folderPath;
      _info = new DirectoryInfo(folderPath);
      this.Text = _info.Name;
    }

    public string FolderPath
    {
      get { return _folderPath; }
      set { _folderPath = value; }
    }

    public DirectoryInfo FolderNodeInfo
    {
      get { return _info; }
    }

  }
}
