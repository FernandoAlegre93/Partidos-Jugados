Public Class Form1

    Dim empatados As Integer
    Dim jugados As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        If txtBox2.Text = txtBox3.Text Then

            empatados = empatados + 1
            txtbox5.Text = empatados

        End If

        If txtBox2.Text <> "" And txtBox3.Text <> "" And txtBox1.Text <> "" Then
            DgvGrilla.Rows.Add(txtBox1.Text, txtBox2.Text, txtBox3.Text)

            jugados = jugados + 1
            txtbox4.Text = jugados
        End If

        If txtBox2.Text = "" Or txtBox3.Text = "" Or txtBox1.Text = "" Then
            MessageBox.Show("¡Complete bien todos los casilleros!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtBox1.Text = ""
        txtBox2.Text = ""
        txtBox3.Text = ""
        txtbox4.Text = ""
        txtbox5.Text = ""
        DgvGrilla.Rows.Clear()
    End Sub
End Class
