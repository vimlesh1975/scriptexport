Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Form1
    Dim conn As New MySqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        conn.ConnectionString = "server=" & txtNewsServerIP.Text & ";user=" & "itmaint" & ";database=" & "c1news" & ";port=" & "3306" & ";password=" & "itddkchn"
        Using cmd As New MySqlCommand("Show_RunOrder", conn) ' calling store procedure
            ' Using cmd As New MySqlCommand("Show_Users", conn) ' calling store procedure


            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@RunOrderTitle", cmbRO.Text)
            Using sda As New MySqlDataAdapter()
                sda.SelectCommand = cmd
                Using dt As New DataSet
                    sda.Fill(dt)
                    dgvContents.DataSource = dt.Tables(0)
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using ofd1 As New SaveFileDialog
            ofd1.FileName = "Script_" & cmbRO.Text & ".txt"
            If ofd1.ShowDialog = DialogResult.OK Then
                Using aa As New IO.StreamWriter(ofd1.FileName, False, System.Text.Encoding.UTF8)
                    For i = 0 To dgvContents.Rows.Count - 1
                        aa.Write(dgvContents.Rows(i).Cells("SlugName").Value + txtSlugSeparator.Text + vbCrLf)
                        aa.Write(dgvContents.Rows(i).Cells("Script").Value + txtScriptSeparator.Text + vbCrLf)
                    Next
                End Using

            End If
        End Using
    End Sub

    Private Sub cmdGetRo_Click(sender As Object, e As EventArgs) Handles cmdGetRo.Click
        conn.ConnectionString = "server=" & txtNewsServerIP.Text & ";user=" & "itmaint" & ";database=" & "C1NEWS" & ";port=" & "3306" & ";password=" & "itddkchn"
        Using cmd As New MySqlCommand("select title from newsid", conn)
            Using sda As New MySqlDataAdapter()
                sda.SelectCommand = cmd
                Using dt As New DataSet
                    sda.Fill(dt)
                    cmbRO.DataSource = dt.Tables(0)
                    cmbRO.ValueMember = "title"
                End Using
            End Using
        End Using
    End Sub
End Class
