Public Class frmmain

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        frmlogin.ShowDialog()

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class