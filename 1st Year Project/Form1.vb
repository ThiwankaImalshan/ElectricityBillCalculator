Public Class Form1

    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Electricity_CustomersDataSet)

    End Sub


    Private Sub CustomerBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Electricity_CustomersDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Electricity_CustomersDataSet.Meter_Readings' table. You can move, or remove it, as needed.
        Me.Meter_ReadingsTableAdapter1.Fill(Me.Electricity_CustomersDataSet.Meter_Readings)
        'TODO: This line of code loads data into the 'Electricity_CustomersDataSet1.Meter_Readings' table. You can move, or remove it, as needed.
        Me.Meter_ReadingsTableAdapter.Fill(Me.Electricity_CustomersDataSet1.Meter_Readings)
        'TODO: This line of code loads data into the 'Electricity_CustomersDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.Electricity_CustomersDataSet.Customer)

    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        CustomerBindingSource.MoveNext()
        Current_ReadingTextBox.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label15.Text = "00"
        Label16.Text = "00"
        Label19.Text = "00"
        Label23.Text = "00"
        Label28.Text = "00"
        Label30.Text = "00"
        Label33.Text = "00"
        Label34.Text = "00"
        Label37.Text = "00"
        Label38.Text = "00"
        Label41.Text = "00"
        Label42.Text = "00"
        Label20.Text = "00"
        Label21.Text = "00"
        Label22.Text = "00"
        Label18.Text = "Rs.30"
        Current_ReadingTextBox.Focus()

        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label23.Visible = True

        Label24.Visible = True
        Label27.Visible = True
        Label28.Visible = True
        Label30.Visible = True

        Label31.Visible = True
        Label32.Visible = True
        Label33.Visible = True
        Label34.Visible = True

        Label35.Visible = True
        Label36.Visible = True
        Label37.Visible = True
        Label38.Visible = True

        Label39.Visible = True
        Label40.Visible = True
        Label41.Visible = True
        Label42.Visible = True
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        CustomerBindingSource.MovePrevious()
        Current_ReadingTextBox.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label15.Text = "00"
        Label16.Text = "00"
        Label19.Text = "00"
        Label23.Text = "00"
        Label28.Text = "00"
        Label30.Text = "00"
        Label33.Text = "00"
        Label34.Text = "00"
        Label37.Text = "00"
        Label38.Text = "00"
        Label41.Text = "00"
        Label42.Text = "00"
        Label20.Text = "00"
        Label21.Text = "00"
        Label22.Text = "00"
        Label18.Text = "Rs.30"

        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label23.Visible = True

        Label24.Visible = True
        Label27.Visible = True
        Label28.Visible = True
        Label30.Visible = True

        Label31.Visible = True
        Label32.Visible = True
        Label33.Visible = True
        Label34.Visible = True

        Label35.Visible = True
        Label36.Visible = True
        Label37.Visible = True
        Label38.Visible = True

        Label39.Visible = True
        Label40.Visible = True
        Label41.Visible = True
        Label42.Visible = True
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click

        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label23.Visible = True

        Label24.Visible = True
        Label27.Visible = True
        Label28.Visible = True
        Label30.Visible = True

        Label31.Visible = True
        Label32.Visible = True
        Label33.Visible = True
        Label34.Visible = True

        Label35.Visible = True
        Label36.Visible = True
        Label37.Visible = True
        Label38.Visible = True

        Label39.Visible = True
        Label40.Visible = True
        Label41.Visible = True
        Label42.Visible = True

        Label16.Text = "00"
        Label23.Text = "00"
        Label30.Text = "00"
        Label34.Text = "00"
        Label38.Text = "00"
        Label42.Text = "00"
        Label20.Text = "00"
        Label21.Text = "00"

        Dim dt1 As DateTime = Convert.ToDateTime(Previous_Reading_DateDateTimePicker1.Text)
        Dim dt2 As DateTime = Convert.ToDateTime(Current_Reading_DateDateTimePicker1.Text)
        Dim ts As TimeSpan = dt2.Subtract(dt1)
        If Convert.ToInt32(ts.Days) >= 0 Then
            TextBox2.Text = Convert.ToInt32(ts.Days)
        Else
            TextBox2.Text = "Invalid Input"
        End If


        If Val(Current_ReadingTextBox.Text) <= Val(Previous_ReadingLabel1.Text) Then
            TextBox3.Text = 0
        Else
            TextBox3.Text = Val(Current_ReadingTextBox.Text) - Val(Previous_ReadingLabel1.Text)
        End If



        If Val(TextBox3.Text) < 31 Then
            Label15.Text = TextBox3.Text
            Label16.Text = Val(Label15.Text) * 12
            Label21.Text = 180

            Label17.Visible = False
            Label18.Visible = False
            Label19.Visible = False
            Label23.Visible = False

            Label24.Visible = False
            Label27.Visible = False
            Label28.Visible = False
            Label30.Visible = False

            Label31.Visible = False
            Label32.Visible = False
            Label33.Visible = False
            Label34.Visible = False

            Label35.Visible = False
            Label36.Visible = False
            Label37.Visible = False
            Label38.Visible = False

            Label39.Visible = False
            Label40.Visible = False
            Label41.Visible = False
            Label42.Visible = False

        ElseIf Val(TextBox3.Text) < 61 Then
            Label15.Text = 30
            Label16.Text = Val(Label15.Text) * 12

            Label19.Text = Val(TextBox3.Text) - 30
            Label23.Text = Val(Label19.Text) * 30
            Label21.Text = 360

            Label24.Visible = False
            Label27.Visible = False
            Label28.Visible = False
            Label30.Visible = False

            Label31.Visible = False
            Label32.Visible = False
            Label33.Visible = False
            Label34.Visible = False

            Label35.Visible = False
            Label36.Visible = False
            Label37.Visible = False
            Label38.Visible = False

            Label39.Visible = False
            Label40.Visible = False
            Label41.Visible = False
            Label42.Visible = False

        ElseIf Val(TextBox3.Text) < 91 Then
            Label15.Text = 30
            Label16.Text = Val(Label15.Text) * 12
            Label19.Text = 60
            Label23.Text = Val(Label19.Text) * 38
            Label18.Text = "Rs.38"

            Label28.Text = Val(TextBox3.Text) - 60
            Label30.Text = Val(Label28.Text) * 41
            Label21.Text = 480

            Label31.Visible = False
            Label32.Visible = False
            Label33.Visible = False
            Label34.Visible = False

            Label35.Visible = False
            Label36.Visible = False
            Label37.Visible = False
            Label38.Visible = False

            Label39.Visible = False
            Label40.Visible = False
            Label41.Visible = False
            Label42.Visible = False

        ElseIf Val(TextBox3.Text) < 121 Then
            Label15.Text = 30
            Label16.Text = Val(Label15.Text) * 12
            Label19.Text = 60
            Label23.Text = Val(Label19.Text) * 38
            Label28.Text = 90
            Label30.Text = Val(Label28.Text) * 41
            Label18.Text = "Rs.38"

            Label33.Text = Val(TextBox3.Text) - 90
            Label34.Text = Val(Label33.Text) * 59
            Label21.Text = 1180

            Label35.Visible = False
            Label36.Visible = False
            Label37.Visible = False
            Label38.Visible = False

            Label39.Visible = False
            Label40.Visible = False
            Label41.Visible = False
            Label42.Visible = False

        ElseIf Val(TextBox3.Text) < 181 Then
            Label15.Text = 30
            Label16.Text = Val(Label15.Text) * 12
            Label19.Text = 60
            Label23.Text = Val(Label19.Text) * 38
            Label28.Text = 90
            Label30.Text = Val(Label28.Text) * 41
            Label33.Text = 120
            Label34.Text = Val(Label33.Text) * 59
            Label18.Text = "Rs.38"

            Label37.Text = Val(TextBox3.Text) - 120
            Label38.Text = Val(Label37.Text) * 59
            Label21.Text = 1770

            Label39.Visible = False
            Label40.Visible = False
            Label41.Visible = False
            Label42.Visible = False

        ElseIf Val(TextBox3.Text) > 180 Then
            Label15.Text = 30
            Label16.Text = Val(Label15.Text) * 12
            Label19.Text = 60
            Label23.Text = Val(Label19.Text) * 38
            Label28.Text = 90
            Label30.Text = Val(Label28.Text) * 41
            Label33.Text = 120
            Label34.Text = Val(Label33.Text) * 59
            Label37.Text = 180
            Label38.Text = Val(Label37.Text) * 59
            Label18.Text = "Rs.38"

            Label41.Text = Val(TextBox3.Text) - 180
            Label42.Text = Val(Label41.Text) * 89
            Label21.Text = 2360

        End If


        If Val(Current_ReadingTextBox.Text) <= Val(Previous_ReadingLabel1.Text) Then
            Label21.Text = "00"
            Label19.Text = "00"
            Label23.Text = "00"
            Label28.Text = "00"
            Label30.Text = "00"
            Label33.Text = "00"
            Label34.Text = "00"
            Label37.Text = "00"
            Label38.Text = "00"
            Label41.Text = "00"
            Label42.Text = "00"
        End If


        Label20.Text = Val(Label16.Text) + Val(Label23.Text) + Val(Label30.Text) + Val(Label34.Text) + Val(Label38.Text) + Val(Label42.Text)

        Label22.Text = Val(Label20.Text) + Val(Label21.Text)
        Label22.Text = Convert.ToString(Label22.Text)
        Label22.Text = ("Rs." + Label22.Text)

    End Sub
End Class
