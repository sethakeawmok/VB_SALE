Public Class Frm_saletotal
    Dim total As String
   
    Private Sub btn_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_1.Click
        total &= btn_1.Text
        txt_remonn.Text = total
    End Sub

    Private Sub btn_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_2.Click
        total &= btn_2.Text
        txt_remonn.Text = total
    End Sub

    Private Sub btn_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_3.Click
        total &= btn_3.Text
        txt_remonn.Text = total
    End Sub

    Private Sub btn_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_4.Click
        total &= btn_4.Text
        txt_remonn.Text = total
    End Sub

    Private Sub btn_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_5.Click
        total &= btn_5.Text
        txt_remonn.Text = total
    End Sub

    Private Sub btn_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_6.Click
        total &= btn_6.Text
        txt_remonn.Text = total
    End Sub

    Private Sub btn_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_7.Click
        total &= btn_7.Text
        txt_remonn.Text = total
    End Sub

    Private Sub btn_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_8.Click
        total &= btn_8.Text
        txt_remonn.Text = total
    End Sub

    Private Sub btn_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_9.Click
        total &= btn_9.Text
        txt_remonn.Text = total
    End Sub

  
    Private Sub btn_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_0.Click
        total &= btn_0.Text
        txt_remonn.Text = total
    End Sub
    Private Sub btn_tod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tod.Click
        total &= btn_tod.Text
        txt_remonn.Text = total
    End Sub
    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        txt_remonn.Text = ""
        total = ""
    End Sub
    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click

        Dim get_monn, new_total As Single
        get_monn = txt_remonn.Text
        new_total = lbl_total.Text

        If get_monn < new_total Then
            MessageBox.Show("คุณกรอกจำนวนน้อยเกินไป", "เตือน!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        lbl_getmonn.Text = Format(get_monn, "#,##0.00")
        new_total = get_monn - new_total
        lbl_sum.Text = Format(new_total, "#,##0.00")

        Dim num1, num2, num3, num4, num5, num6, num7, num8, num9, num10 As Double
        Dim mon1, mon2, mon3, mon4, mon5, mon6, mon7, mon8, mon9, mon10 As Double
        ListBox1.Items.Clear()
        num1 = new_total
        num1 = Val(new_total) Mod 1000
        num2 = num1 Mod 500
        num3 = num2 Mod 100
        num4 = num3 Mod 50
        num5 = num4 Mod 20
        num6 = num5 Mod 10
        num7 = num6 Mod 5
        num8 = num7 Mod 1
        num9 = num8 Mod 0.5
        num10 = num9 Mod 0.25

        mon1 = Val(new_total) - num1
        mon2 = num1 - num2
        mon3 = num2 - num3
        mon4 = num3 - num4
        mon5 = num4 - num5
        mon6 = num5 - num6
        mon7 = num6 - num7
        mon8 = num7 - num8
        mon9 = num8 - num9
        mon10 = num9 - num10

        If mon1 / 1000 <> 0 Then
            ListBox1.Items.Add("ธนบัตร         1000           จำนวน            " & mon1 / 1000 & "             ใบ")
        End If
        If mon2 / 500 <> 0 Then
            ListBox1.Items.Add("ธนบัตร          500            จำนวน             " & mon2 / 500 & "             ใบ")
        End If
        If mon3 / 100 <> 0 Then
            ListBox1.Items.Add("ธนบัตร          100            จำนวน             " & mon3 / 100 & "             ใบ")
        End If
        If mon4 / 50 <> 0 Then
            ListBox1.Items.Add("ธนบัตร            50            จำนวน             " & mon4 / 50 & "              ใบ")
        End If
        If mon5 / 20 <> 0 Then
            ListBox1.Items.Add("ธนบัตร            20            จำนวน             " & mon5 / 20 & "              ใบ")
        End If
        If mon6 / 10 <> 0 Then
            ListBox1.Items.Add("เหรียญ            10             จำนวน             " & mon6 / 10 & "              เหรียญ")
        End If
        If mon7 / 5 <> 0 Then
            ListBox1.Items.Add("เหรียญ              5             จำนวน             " & mon7 / 5 & "               เหรียญ")
        End If
        If mon8 / 1 <> 0 Then
            ListBox1.Items.Add("เหรียญ              1             จำนวน             " & mon8 / 1 & "               เหรียญ")
        End If
        If mon9 / 0.5 <> 0 Then
            ListBox1.Items.Add("เหรียญ              0.5          จำนวน             " & mon9 / 0.5 & "              เหรียญ")
        End If
        If mon10 / 0.25 <> 0 Then
            ListBox1.Items.Add("เหรียญ              0.25        จำนวน             " & mon10 / 0.25 & "             เหรียญ")
        End If
    End Sub
End Class