Public Class Form2
    Dim x As Integer
    Dim y As Integer
    Dim z As Integer
    Dim s As Integer = 1


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If (RadioButton1.Checked = True) Then
            NumericUpDown1.Enabled = True
            NumericUpDown2.Enabled = False
            NumericUpDown3.Enabled = False
        End If
        If (Form1.c1 = 1) Then
            Form3.TextBox4.Text = ""
            Form3.TextBox4.Text = RadioButton1.Text
        End If
        If (Form1.c1 = 2) Then
            Form3.TextBox10.Text = ""
            Form3.TextBox10.Text = RadioButton1.Text
        End If
        If (Form1.c1 = 3) Then
            Form3.TextBox16.Text = ""
            Form3.TextBox16.Text = RadioButton1.Text
        End If
        If (Form1.c1 = 4) Then
            Form3.TextBox22.Text = ""
            Form3.TextBox22.Text = RadioButton1.Text
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If (RadioButton2.Checked = True) Then
            NumericUpDown1.Enabled = False
            NumericUpDown2.Enabled = True
            NumericUpDown3.Enabled = False
        End If
        
        If (Form1.c1 = 1) Then
            Form3.TextBox4.Text = ""
            Form3.TextBox4.Text = RadioButton2.Text
        End If
        If (Form1.c1 = 2) Then
            Form3.TextBox10.Text = ""
            Form3.TextBox10.Text = RadioButton2.Text
        End If
        If (Form1.c1 = 3) Then
            Form3.TextBox16.Text = ""
            Form3.TextBox16.Text = RadioButton2.Text
        End If
        If (Form1.c1 = 4) Then
            Form3.TextBox22.Text = ""
            Form3.TextBox22.Text = RadioButton2.Text
        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If (RadioButton3.Checked = True) Then
            NumericUpDown1.Enabled = False
            NumericUpDown2.Enabled = False
            NumericUpDown3.Enabled = True
        End If
       
        If (Form1.c1 = 1) Then
            Form3.TextBox4.Text = ""
            Form3.TextBox4.Text = RadioButton3.Text
        End If
        If (Form1.c1 = 2) Then
            Form3.TextBox10.Text = ""
            Form3.TextBox10.Text = RadioButton3.Text
        End If
        If (Form1.c1 = 3) Then
            Form3.TextBox16.Text = ""
            Form3.TextBox16.Text = RadioButton3.Text
        End If
        If (Form1.c1 = 4) Then
            Form3.TextBox22.Text = ""
            Form3.TextBox22.Text = RadioButton3.Text
        End If

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox3.Visible = False
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        x = Me.NumericUpDown1.Value
        If (Form1.c1 = 1) Then
            Form3.TextBox5.Text = ""
            Form3.TextBox5.Text = x
        End If
        If (Form1.c1 = 2) Then
            Form3.TextBox11.Text = ""
            Form3.TextBox11.Text = x
        End If
        If (Form1.c1 = 3) Then
            Form3.TextBox17.Text = ""
            Form3.TextBox17.Text = x
        End If
        If (Form1.c1 = 4) Then
            Form3.TextBox23.Text = ""
            Form3.TextBox23.Text = x
        End If
    End Sub

    Private Sub NumericUpDown2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged
        y = Me.NumericUpDown2.Value
        If (Form1.c1 = 1) Then
            Form3.TextBox5.Text = ""
            Form3.TextBox5.Text = y
        End If
        If (Form1.c1 = 2) Then
            Form3.TextBox11.Text = ""
            Form3.TextBox11.Text = y
        End If
        If (Form1.c1 = 3) Then
            Form3.TextBox17.Text = ""
            Form3.TextBox17.Text = y
        End If
        If (Form1.c1 = 4) Then
            Form3.TextBox23.Text = ""
            Form3.TextBox23.Text = y
        End If
    End Sub

    Private Sub NumericUpDown3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown3.ValueChanged
        z = Me.NumericUpDown3.Value
        If (Form1.c1 = 1) Then
            Form3.TextBox5.Text = ""
            Form3.TextBox5.Text = z
        End If
        If (Form1.c1 = 2) Then
            Form3.TextBox11.Text = ""
            Form3.TextBox11.Text = z
        End If
        If (Form1.c1 = 3) Then
            Form3.TextBox17.Text = ""
            Form3.TextBox17.Text = z
        End If
        If (Form1.c1 = 4) Then
            Form3.TextBox23.Text = ""
            Form3.TextBox23.Text = z
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        GroupBox3.Visible = True
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        GroupBox3.Visible = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        If (Form1.c1 = 1) Then
            Form3.ListBox1.Items.Add("NIL")
        End If
        If (Form1.c1 = 2) Then
            Form3.ListBox2.Items.Add("NIL")
        End If
        If (Form1.c1 = 3) Then
            Form3.ListBox3.Items.Add("NIL")
        End If
        If (Form1.c1 = 4) Then
            Form3.ListBox4.Items.Add("NIL")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False) Then
            MessageBox.Show("Please Select Pizza Size")
        ElseIf (x = 0 And y = 0 And z = 0) Then
            MessageBox.Show("Please Select Quantity")
        ElseIf (RadioButton4.Checked = False And RadioButton5.Checked = False) Then
            MessageBox.Show("Please Select YES or NO in Topping Option")
        Else

            If (Form1.c1 = 1) Then
                If (RadioButton1.Checked = True) Then
                    Form3.TextBox6.Text = x * Integer.Parse(Label1.Text)
                End If
                If (RadioButton2.Checked = True) Then

                    Form3.TextBox6.Text = y * Integer.Parse(Label2.Text)
                End If
                If (RadioButton3.Checked = True) Then

                    Form3.TextBox6.Text = z * Integer.Parse(Label3.Text)
                End If
            End If

            If (Form1.c1 = 2) Then
                If (RadioButton1.Checked = True) Then
                    Form3.TextBox12.Text = x * Integer.Parse(Label1.Text)
                End If
                If (RadioButton2.Checked = True) Then

                    Form3.TextBox12.Text = y * Integer.Parse(Label2.Text)
                End If
                If (RadioButton3.Checked = True) Then

                    Form3.TextBox12.Text = z * Integer.Parse(Label3.Text)
                End If
            End If
            If (Form1.c1 = 3) Then
                If (RadioButton1.Checked = True) Then
                    Form3.TextBox18.Text = x * Integer.Parse(Label1.Text)
                End If
                If (RadioButton2.Checked = True) Then

                    Form3.TextBox18.Text = y * Integer.Parse(Label2.Text)
                End If
                If (RadioButton3.Checked = True) Then

                    Form3.TextBox18.Text = z * Integer.Parse(Label3.Text)
                End If
            End If
            If (Form1.c1 = 4) Then
                If (RadioButton1.Checked = True) Then
                    Form3.TextBox24.Text = x * Integer.Parse(Label1.Text)
                End If
                If (RadioButton2.Checked = True) Then

                    Form3.TextBox24.Text = y * Integer.Parse(Label2.Text)
                End If
                If (RadioButton3.Checked = True) Then

                    Form3.TextBox24.Text = z * Integer.Parse(Label3.Text)
                End If
            End If





            If (Form1.c1 = 1) Then
                If (CheckBox1.Checked = True) Then

                    Form3.ListBox1.Items.Add(CheckBox1.Text)
                End If
                If (CheckBox2.Checked = True) Then

                    Form3.ListBox1.Items.Add(CheckBox2.Text)
                End If
                If (CheckBox3.Checked = True) Then

                    Form3.ListBox1.Items.Add(CheckBox3.Text)
                End If
                If (CheckBox4.Checked = True) Then

                    Form3.ListBox1.Items.Add(CheckBox4.Text)
                End If
                If (CheckBox5.Checked = True) Then

                    Form3.ListBox1.Items.Add(CheckBox5.Text)
                End If
            End If
            If (Form1.c1 = 2) Then
                If (CheckBox1.Checked = True) Then

                    Form3.ListBox2.Items.Add(CheckBox1.Text)
                End If
                If (CheckBox2.Checked = True) Then

                    Form3.ListBox2.Items.Add(CheckBox2.Text)
                End If
                If (CheckBox3.Checked = True) Then

                    Form3.ListBox2.Items.Add(CheckBox3.Text)
                End If
                If (CheckBox4.Checked = True) Then

                    Form3.ListBox2.Items.Add(CheckBox4.Text)
                End If
                If (CheckBox5.Checked = True) Then

                    Form3.ListBox2.Items.Add(CheckBox5.Text)
                End If
            End If
            If (Form1.c1 = 3) Then
                If (CheckBox1.Checked = True) Then

                    Form3.ListBox3.Items.Add(CheckBox1.Text)
                End If
                If (CheckBox2.Checked = True) Then

                    Form3.ListBox3.Items.Add(CheckBox2.Text)
                End If
                If (CheckBox3.Checked = True) Then

                    Form3.ListBox3.Items.Add(CheckBox3.Text)
                End If
                If (CheckBox4.Checked = True) Then

                    Form3.ListBox3.Items.Add(CheckBox4.Text)
                End If
                If (CheckBox5.Checked = True) Then

                    Form3.ListBox3.Items.Add(CheckBox5.Text)
                End If
            End If
            If (Form1.c1 = 4) Then
                If (CheckBox1.Checked = True) Then

                    Form3.ListBox4.Items.Add(CheckBox1.Text)
                End If
                If (CheckBox2.Checked = True) Then

                    Form3.ListBox4.Items.Add(CheckBox2.Text)
                End If
                If (CheckBox3.Checked = True) Then

                    Form3.ListBox4.Items.Add(CheckBox3.Text)
                End If
                If (CheckBox4.Checked = True) Then

                    Form3.ListBox4.Items.Add(CheckBox4.Text)
                End If
                If (CheckBox5.Checked = True) Then

                    Form3.ListBox4.Items.Add(CheckBox5.Text)
                End If
            End If


            If (Form1.c1 = 1) Then
                Form3.GroupBox1.Visible = True
                Form3.GroupBox2.Visible = False
                Form3.GroupBox3.Visible = False
                Form3.GroupBox4.Visible = False
            End If
            If (Form1.c1 = 2) Then
                Form3.GroupBox1.Visible = True
                Form3.GroupBox2.Visible = True
                Form3.GroupBox3.Visible = False
                Form3.GroupBox4.Visible = False
            End If
            If (Form1.c1 = 3) Then
                Form3.GroupBox1.Visible = True
                Form3.GroupBox2.Visible = True
                Form3.GroupBox3.Visible = True
                Form3.GroupBox4.Visible = False
            End If
            If (Form1.c1 = 4) Then
                Form3.GroupBox1.Visible = True
                Form3.GroupBox2.Visible = True
                Form3.GroupBox3.Visible = True
                Form3.GroupBox4.Visible = True
            End If
            's = Form1.c1
            If (Form1.c1 = 1) Then
                Form3.TextBox1.Text = Form1.c1
            End If
            If (Form1.c1 = 2) Then
                Form3.TextBox7.Text = Form1.c1
            End If
            If (Form1.c1 = 3) Then
                Form3.TextBox13.Text = Form1.c1
            End If
            If (Form1.c1 = 4) Then
                Form3.TextBox19.Text = Form1.c1
            End If
            's = s + 1
            If (Form1.c1 = 1) Then
                Form3.TextBox25.Text = ""
                Form3.TextBox25.Text = Integer.Parse(Form3.TextBox6.Text)
            End If
            If (Form1.c1 = 2) Then
                Form3.TextBox25.Text = ""
                Form3.TextBox25.Text = Integer.Parse(Form3.TextBox6.Text) + Integer.Parse(Form3.TextBox12.Text)
            End If
            If (Form1.c1 = 3) Then
                Form3.TextBox25.Text = ""
                Form3.TextBox25.Text = Integer.Parse(Form3.TextBox6.Text) + Integer.Parse(Form3.TextBox12.Text) + Integer.Parse(Form3.TextBox18.Text)
            End If
            If (Form1.c1 = 4) Then
                Form3.TextBox25.Text = ""
                Form3.TextBox25.Text = Integer.Parse(Form3.TextBox6.Text) + Integer.Parse(Form3.TextBox12.Text) + Integer.Parse(Form3.TextBox18.Text) + Integer.Parse(Form3.TextBox24.Text)
            End If
            Form3.Show()

            Me.Hide()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (Form1.c1 = 1) Then
            Form3.TextBox1.Text = " "
            Form3.TextBox2.Text = " "
            Form3.TextBox3.Text = " "
            Form3.TextBox4.Text = " "
            Form3.ListBox1.Items.Clear()
            Form3.TextBox5.Text = " "
            Form3.TextBox6.Text = " "
            Form1.c1 = Form1.c1 - 1
        End If
        If (Form1.c1 = 2) Then
            Form3.TextBox7.Text = " "
            Form3.TextBox8.Text = " "
            Form3.TextBox9.Text = " "
            Form3.TextBox10.Text = " "
            Form3.ListBox2.Items.Clear()
            Form3.TextBox11.Text = " "
            Form3.TextBox12.Text = " "
            Form1.c1 = Form1.c1 - 1
        End If
        If (Form1.c1 = 3) Then
            Form3.TextBox13.Text = " "
            Form3.TextBox14.Text = " "
            Form3.TextBox15.Text = " "
            Form3.TextBox16.Text = " "
            Form3.ListBox3.Items.Clear()
            Form3.TextBox17.Text = " "
            Form3.TextBox18.Text = " "
            Form1.c1 = Form1.c1 - 1
        End If
        If (Form1.c1 = 4) Then
            Form3.TextBox19.Text = " "
            Form3.TextBox20.Text = " "
            Form3.TextBox21.Text = " "
            Form3.TextBox22.Text = " "
            Form3.ListBox4.Items.Clear()
            Form3.TextBox23.Text = " "
            Form3.TextBox24.Text = " "
            Form1.c1 = Form1.c1 - 1
        End If

        Form1.tb1 = 0
        Form1.GroupBox1.Visible = False
        Form1.GroupBox2.Visible = False
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class