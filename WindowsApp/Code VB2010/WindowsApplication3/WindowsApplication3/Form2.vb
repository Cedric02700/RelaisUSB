Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Form1.Button1.Text
        TextBox2.Text = Form1.Button2.Text
        TextBox3.Text = Form1.Button3.Text
        TextBox4.Text = Form1.Button4.Text
        TextBox5.Text = Form1.Button5.Text
        TextBox6.Text = Form1.Button6.Text
        TextBox7.Text = Form1.Button7.Text
        TextBox8.Text = Form1.Button8.Text
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Form1.Button1.Text = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Form1.Button2.Text = TextBox2.Text
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Form1.Button3.Text = TextBox3.Text
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Form1.Button4.Text = TextBox4.Text
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Form1.Button5.Text = TextBox5.Text
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Form1.Button6.Text = TextBox6.Text
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        Form1.Button7.Text = TextBox7.Text
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        Form1.Button8.Text = TextBox8.Text
    End Sub

    Private Sub btEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnregistrer.Click
        Form1.save()
        Me.Close()
    End Sub
End Class