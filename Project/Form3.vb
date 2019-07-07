Public Class Form3

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        ''If (Form1.c1 = 4) Then
        ''    Form1.c1 = 0
        ''End If
        'Form2.Close()
        'Form1.tb1 = 0
        'Form1.GroupBox1.Visible = False
        'Form1.GroupBox2.Visible = False
        'Form1.RadioButton1.Checked = False
        'Form1.RadioButton2.Checked = False
        Form4.Label2.Text = "Total Price = Rs."
        Form4.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Form1.tb1 = 0
        Form1.GroupBox1.Visible = False
        Form1.GroupBox2.Visible = False
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Form2.Close()

        If (Form1.c1 = 1) Then
            ListBox1.Items.Clear()
        End If
        If (Form1.c1 = 2) Then
            ListBox2.Items.Clear()
        End If
        If (Form1.c1 = 3) Then
            ListBox3.Items.Clear()
        End If
        If (Form1.c1 = 4) Then
            ListBox4.Items.Clear()
        End If
        Form1.c1 = Form1.c1 - 1
        Form1.Show()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.tb1 = 0
        Form1.GroupBox1.Visible = False
        Form1.GroupBox2.Visible = False
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        If (Form1.c1 = 4) Then
            Form1.c1 = 0
        End If
        Form2.Close()
        Me.Hide()
        Form1.Show()
    End Sub
End Class