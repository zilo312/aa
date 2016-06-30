#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

#endregion

namespace FormsSample.SampleControls
{
  public class FileNode : System.Windows.Forms.TreeNode
  {
    string _fileName = "";
    FileInfo _info;

    public FileNode(string fileName)
    {
      _fileName = fileName;
      _info = new FileInfo(_fileName);
      base.Text = _info.Name;
      if (_info.Extension.ToLower() == ".exe")
        this.ForeColor = System.Drawing.Color.Red;

    }

    public string FileName
    {
      get { return _fileName; }
      set { _fileName = value; }
    }


    public FileInfo FileNodeInfo
    {
      get { return _info; }
    }

  }
}
