# How to count checked nodes of WinForms TreeViewAdv

This respository contains the sample that illustrate how to count the checked nodes of [WinForms TreeViewAdv](https://www.syncfusion.com/winforms-ui-controls/treeview) control.

You can get the count for all checked nodes in WinForms [TreeViewAdv](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Tools.TreeViewAdv.html) control by using [CheckedNodes](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Tools.TreeViewAdv.html#Syncfusion_Windows_Forms_Tools_TreeViewAdv_CheckedNodes) property. The `CheckedNodes` property retrieves the checked nodes of the `TreeViewAdv`, which is of type [CheckedNodesCollection](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Tools.CheckedNodesCollection.html). Refer the below code for your reference.

#### C#

``` csharp
int checkedCount = treeView1.CheckedNodes.Count;
```

#### VB

``` vb
Dim checkedCount As Integer = treeView1.CheckedNodes.Count
```

![How to count checked nodes of WinForms TreeViewAdv](https://www.syncfusion.com/uploads/user/kb/wf/wf-57845/wf-57845_img1.png)