Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Partial Public Class Form1
    Inherits MetroForm
    Private treeView1 As New TreeViewAdv()
    Public Sub New()
        InitializeComponent()
        treeView1 = New TreeViewAdv()
        treeView1.Name = "treeView1"
        treeView1.ShowCheckBoxes = True
        treeView1.Size = New Size(312, 368)
        treeView1.Style = TreeStyle.Office2016Colorful

        'Create instances of TreeNodeAdv named treeNode1 and treenode7
        Dim treeNode1 As New TreeNodeAdv("Node1")
        Dim treeNode7 As New TreeNodeAdv("Node7")

        'Adding the subnode of [treeNode1 and treenode7] in Root [treeNode2].
        Dim treeNode2 As New TreeNodeAdv("Node0", New TreeNodeAdv() {treeNode1, treeNode7})
        treeNode2.Expanded = True

        'Create instances of TreeNodeAdv named treeNode3 and treenode8
        Dim treeNode3 As New TreeNodeAdv("Node3")
        Dim treeNode8 As New TreeNodeAdv("Node8")

        'Adding the subnode of [treeNode3 and treenode8] in Root [treeNode4].
        Dim treeNode4 As New TreeNodeAdv("Node2", New TreeNodeAdv() {treeNode3, treeNode8})
        treeNode4.Expanded = True

        ' Create instances of TreeNodeAdv named treeNode5 and treenode9
        Dim treeNode5 As New TreeNodeAdv("Node5")
        Dim treeNode9 As New TreeNodeAdv("Node9")

        'Adding the subnode of [treeNode5 and treenode9] in Root [treeNode6].
        Dim treeNode6 As New TreeNodeAdv("Node4", New TreeNodeAdv() {treeNode5, treeNode9})
        treeNode6.Expanded = True

        'Assigning the text and Name

        treeNode1.Name = "Node1"
        treeNode1.Text = "India"

        treeNode7.Name = "Node7"
        treeNode7.Text = "China"

        treeNode2.Name = "Node0"
        treeNode2.Text = "Asia"

        treeNode3.Name = "Node3"
        treeNode3.Text = "Britain"

        treeNode8.Name = "Node8"
        treeNode8.Text = "France"

        treeNode4.Name = "Node2"
        treeNode4.Text = "Europe"

        treeNode5.Name = "Node5"
        treeNode5.Text = "South Africa"

        treeNode9.Name = "Node9"
        treeNode9.Text = "Zimbabwe"

        treeNode6.Name = "Node4"
        treeNode6.Text = "Africa"

        'Add the nodes in TreeViewAdv nodes collection
        treeView1.Nodes.AddRange(New TreeNodeAdv() {treeNode2, treeNode4, treeNode6})

        ' Add the TreeViewAdv to the Form controls
        Me.Controls.Add(treeView1)
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim TotalNodesInTree As Integer = treeView1.GetNodeCount(True)
        Dim checkedCount As Integer = treeView1.CheckedNodes.Count
        MessageBox.Show("Total nodes in tree = " & TotalNodesInTree.ToString() & Constants.vbLf & "Total number of checked nodes = " & checkedCount)
    End Sub
End Class