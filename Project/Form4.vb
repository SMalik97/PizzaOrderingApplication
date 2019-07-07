Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Form1.tb1 = 0
        Form1.GroupBox1.Visible = False
        Form1.GroupBox2.Visible = False
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False

        Form1.c1 = 0

        Form2.Close()
        Form3.Close()
        Me.Close()
        Form1.Show()


    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = Label2.Text + Form3.TextBox25.Text
    End Sub
End Class