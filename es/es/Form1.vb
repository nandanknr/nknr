
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If collegeDataSetUtil.DesignerUtil.IsRunTime Then
            'TODO: Delete this line of code to remove the default AutoFill for 'CollegeDataSet.student'.
            Me.StudentTableAdapter.Fill(Me.CollegeDataSet.student)
            DataGrid1.Visible = False


        End If

    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Equals("gct") Then
            If TextBox2.Text.Equals("cse123") Then
                DataGrid1.Visible = True
                TextBox2.Hide()
                TextBox1.Hide()
                Label1.Hide()
                Label2.Hide()


            Else
                MsgBox("Username or Password Incorrect")
                TextBox1.Text = " "
                TextBox2.Text = " "









            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
