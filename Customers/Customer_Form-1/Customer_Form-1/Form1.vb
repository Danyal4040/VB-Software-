Imports System.Data
Imports System.Data.OleDb

Public Class Form1

    Dim con As OleDbConnection


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles phone.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clear()
    End Sub
    Sub clear()
        Ref.Clear()
        F_Name.Clear()
        L_Name.Clear()
        Gender.Clear()
        CNIC.Clear()
        Bill_Number.Clear()
        Address.Clear()
        phone.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim Insertquery As String = "INSERT INTO Table1 (Refn_N, F_name, L_name, Gender,,CNIC_N) values(@Refn_N, @F_name , @L_name ,@gender,@CNIC_N)"

        Runquery(Insertquery)




    End Sub
    Public Sub Runquery(ByVal query As String)
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Danyal\Desktop\Customers\Data_base\Database3.mdb")
        Dim cmd As New OleDbCommand(query, con)
        cmd.Parameters.AddWithValue("@Refn_N", Ref.Text)
        cmd.Parameters.AddWithValue("@F_name", F_Name.Text)
        cmd.Parameters.AddWithValue("@L_name", L_Name.Text)
        cmd.Parameters.AddWithValue("@gender", Gender.Text)
        cmd.Parameters.AddWithValue("@CNIC_N", CNIC.Text)
        cmd.Parameters.AddWithValue("@Bill_N", Bill_Number.Text)
        cmd.Parameters.AddWithValue("@date", D_t.Text)
        cmd.Parameters.AddWithValue("@address", Address.Text)
        cmd.Parameters.AddWithValue("@P_N", phone.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()


    End Sub
End Class
