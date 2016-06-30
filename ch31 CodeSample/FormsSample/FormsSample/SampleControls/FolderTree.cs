#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.IO;

#endregion

namespace FormsSample.SampleControls
{
  public class FolderTree : System.Windows.Forms.TreeView, ISupportInitialize
  {
    string _rootFolder = "";
    bool _showFiles = true;
    bool _inInit = false;

    public FolderTree()
    {

    }

    private void InitializeTree()
    {
      if (!this.DesignMode)
      {
        FolderNode rootNode = new FolderNode(_rootFolder);
        LoadTree(rootNode);
        this.Nodes.Clear();
        this.Nodes.Add(rootNode);
      }
    }


    private void LoadTree(FolderNode folder)
    {

      string[] dirs = Directory.GetDirectories(folder.FolderPath);
      foreach (string dir in dirs)
      {
        FolderNode tmpfolder = new FolderNode(dir);
        folder.Nodes.Add(tmpfolder);
        LoadTree(tmpfolder);
      }
      if (_showFiles)
      {

        string[] files = Directory.GetFiles(folder.FolderPath);
        foreach (string file in files)
        {
          FileNode fnode = new FileNode(file);
          folder.Nodes.Add(fnode);
        }

      }
    }


    [Category("Behavior"),
    Description("Gets or sets the base or root folder of the tree"),
    DefaultValue("")]
    public string RootFolder
    {
      get { return _rootFolder; }
      set
      {
        _rootFolder = value;
        if (!_inInit)
          InitializeTree();

      }
    }

    [Category("Behavior"),
      Description("Indicates whether files will be seen in the list."),
      DefaultValue(true)]
    public bool ShowFiles
    {
      get { return _showFiles; }
      set { _showFiles = value; }
    }


    [Browsable(false)]
    public string SelectedFolder
    {
      get
      {
        if (this.SelectedNode is FolderNode)
          return ((FolderNode)this.SelectedNode).FolderPath;

        return "";
      }
    }


    #region ISupportInitialize Members

    public void BeginInit()
    {
      _inInit = true;
    }

    public void EndInit()
    {
      if (_rootFolder != "")
      {
        InitializeTree();
      }
      _inInit = false;
    }

    #endregion

  }
}
