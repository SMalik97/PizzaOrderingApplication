Public Class Form1
    Public c1 As Integer = 0
    Public tb1 As Integer = 0
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        GroupBox1.Visible = False
        GroupBox2.Visible = False

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If (RadioButton1.Checked = True) Then
            tb1 = 1
            GroupBox1.Visible = True
            GroupBox2.Visible = False
        End If
        If (tb1 = 1) Then
            Form2.ListBox1.Items.Clear()
            Form2.ListBox1.Items.Add(RadioButton1.Text)

        End If
        If (c1 = 0) Then
            Form3.TextBox3.Text = (RadioButton1.Text)
        End If
        If (c1 = 1) Then
            Form3.TextBox9.Text = (RadioButton1.Text)
        End If
        If (c1 = 2) Then
            Form3.TextBox15.Text = (RadioButton1.Text)
        End If
        If (c1 = 3) Then
            Form3.TextBox21.Text = (RadioButton1.Text)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If (RadioButton2.Checked = True) Then
            GroupBox1.Visible = False
            tb1 = 1
            GroupBox2.Visible = True
        End If
        If (tb1 = 1) Then
            Form2.ListBox1.Items.Clear()
            Form2.ListBox1.Items.Add(RadioButton2.Text)

        End If
        If (c1 = 0) Then
            Form3.TextBox3.Text = (RadioButton2.Text)
        End If
        If (c1 = 1) Then
            Form3.TextBox9.Text = (RadioButton2.Text)
        End If
        If (c1 = 2) Then
            Form3.TextBox15.Text = (RadioButton2.Text)
        End If
        If (c1 = 3) Then
            Form3.TextBox21.Text = (RadioButton2.Text)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        c1 = c1 + 1
        Form2.ListBox1.Items.Add(Button1.Text)
        If (c1 = 1) Then
            Form3.TextBox2.Text = Button1.Text
        End If
        If (c1 = 2) Then
            Form3.TextBox8.Text = Button1.Text
        End If
        If (c1 = 3) Then
            Form3.TextBox14.Text = Button1.Text
        End If
        If (c1 = 4) Then
            Form3.TextBox20.Text = Button1.Text
        End If
        Me.Hide()
        Form2.Show()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        c1 = c1 + 1
        Form2.ListBox1.Items.Add(Button2.Text)
        If (c1 = 1) Then
            Form3.TextBox2.Text = Button2.Text
        End If
        If (c1 = 2) Then
            Form3.TextBox8.Text = Button2.Text
        End If
        If (c1 = 3) Then
            Form3.TextBox14.Text = Button2.Text
        End If
        If (c1 = 4) Then
            Form3.TextBox20.Text = Button2.Text
        End If
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        c1 = c1 + 1
        Form2.ListBox1.Items.Add(Button3.Text)
        If (c1 = 1) Then
            Form3.TextBox2.Text = Button3.Text
        End If
        If (c1 = 2) Then
            Form3.TextBox8.Text = Button3.Text
        End If
        If (c1 = 3) Then
            Form3.TextBox14.Text = Button3.Text
        End If
        If (c1 = 4) Then
            Form3.TextBox20.Text = Button3.Text
        End If
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        c1 = c1 + 1
        Form2.ListBox1.Items.Add(Button4.Text)
        If (c1 = 1) Then
            Form3.TextBox2.Text = Button4.Text
        End If
        If (c1 = 2) Then
            Form3.TextBox8.Text = Button4.Text
        End If
        If (c1 = 3) Then
            Form3.TextBox14.Text = Button4.Text
        End If
        If (c1 = 4) Then
            Form3.TextBox20.Text = Button4.Text
        End If
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        c1 = c1 + 1
        Form2.ListBox1.Items.Add(Button5.Text)
        If (c1 = 1) Then
            Form3.TextBox2.Text = Button5.Text
        End If
        If (c1 = 2) Then
            Form3.TextBox8.Text = Button5.Text
        End If
        If (c1 = 3) Then
            Form3.TextBox14.Text = Button5.Text
        End If
        If (c1 = 4) Then
            Form3.TextBox20.Text = Button5.Text
        End If
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        c1 = c1 + 1
        Form2.ListBox1.Items.Add(Button6.Text)
        If (c1 = 1) Then
            Form3.TextBox2.Text = Button6.Text
        End If
        If (c1 = 2) Then
            Form3.TextBox8.Text = Button6.Text
        End If
        If (c1 = 3) Then
            Form3.TextBox14.Text = Button6.Text
        End If
        If (c1 = 4) Then
            Form3.TextBox20.Text = Button6.Text
        End If
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        c1 = c1 + 1
        Form2.ListBox1.Items.Add(Button7.Text)
        If (c1 = 1) Then
            Form3.TextBox2.Text = Button7.Text
        End If
        If (c1 = 2) Then
            Form3.TextBox8.Text = Button7.Text
        End If
        If (c1 = 3) Then
            Form3.TextBox14.Text = Button7.Text
        End If
        If (c1 = 4) Then
            Form3.TextBox20.Text = Button7.Text
        End If
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        c1 = c1 + 1
        Form2.ListBox1.Items.Add(Button8.Text)
        If (c1 = 1) Then
            Form3.TextBox2.Text = Button8.Text
        End If
        If (c1 = 2) Then
            Form3.TextBox8.Text = Button8.Text
        End If
        If (c1 = 3) Then
            Form3.TextBox14.Text = Button8.Text
        End If
        If (c1 = 4) Then
            Form3.TextBox20.Text = Button8.Text
        End If
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        End
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.Show()
    End Sub
End Class
