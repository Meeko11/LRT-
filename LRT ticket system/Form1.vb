Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim price As Double = 0
        Dim discount As Double = 0

        ' Determine the price based on ComboBox1 selection
        Select Case ComboBox1.SelectedIndex
            Case 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
                price = 20
        End Select

        ' Determine the discount based on ComboBox3 selection
        Select Case ComboBox3.SelectedIndex
            Case 0
                discount = 0
            Case 1
                discount = 0.1
            Case 2
                discount = 0.15
            Case 3
                discount = 0.2
            Case 4
                discount = 0.5
        End Select

        ' Calculate total after discount
        Dim total As Double = price * (1 - discount)

        ' Pass values to Form2
        Form2.Label10.Text = Me.ComboBox1.SelectedItem?.ToString()
        Form2.Label11.Text = Me.ComboBox2.SelectedItem?.ToString()
        Form2.Label12.Text = Me.NumericUpDown1.Value.ToString()
        Form2.Label1.Text = Format(Date.Now, "MMM dd, yyyy")
        Form2.Label2.Text = Format(Date.Now, "Long Time")
        Form2.Label14.Text = Me.ComboBox3.SelectedItem?.ToString()
        Form2.Label13.Text = price
        Form2.Label15.Text = total.ToString("C") ' Display total in currency format

        Me.Hide()
        Form2.Show()
    End Sub







    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Me.DT.Text = Format(Date.Now, "MMM dd , yyyy")

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.TM.Text = Format(Date.Now, "long time")




    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim discount As Double
        Select Case ComboBox3.SelectedIndex
            Case 0
                discount = 0
            Case 1
                discount = 0.1
            Case 2
                discount = 0.15
            Case 3
                discount = 0.2
            Case 4
                discount = 0.5

        End Select

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim price As Double

        If ComboBox1.SelectedIndex = 0 Then

        End If

        If ComboBox1.SelectedIndex = 1 Then
            price = 20

        End If

        If ComboBox1.SelectedIndex = 2 Then
            price = 20

        End If


        If ComboBox1.SelectedIndex = 3 Then
            price = 20

        End If

        If ComboBox1.SelectedIndex = 4 Then
            price = 20

        End If

        If ComboBox1.SelectedIndex = 5 Then
            price = 20

        End If

        If ComboBox1.SelectedIndex = 6 Then
            price = 20

        End If


        If ComboBox1.SelectedIndex = 7 Then
            price = 20

        End If

        If ComboBox1.SelectedIndex = 8 Then
            price = 20

        End If

        If ComboBox1.SelectedIndex = 9 Then
            price = 20

        End If

        If ComboBox1.SelectedIndex = 10 Then
            price = 20

        End If

        If ComboBox1.SelectedIndex = 11 Then
            price = 20

        End If


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
