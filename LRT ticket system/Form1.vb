Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Label10.Text = Me.ComboBox1.SelectedItem
        Form2.Label11.Text = Me.ComboBox2.SelectedItem
        Form2.Label12.Text = Me.NumericUpDown1.Value
        Form2.Label1.Text = Format(Date.Now, "MMM dd , yyyy")
        Form2.Label2.Text = Format(Date.Now, "Long Time")
        Form2.Label14.Text = Me.ComboBox3.SelectedItem
        Form2.Label15.Text = ""


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


        If ComboBox3.SelectedIndex = 0 Then

        End If
        'COV
        If ComboBox3.SelectedIndex = 1 Then
            discount = 0.1
        End If
        'Student 
        If ComboBox3.SelectedIndex = 2 Then
            discount = 0.15
        End If

        'Senior citizen
        If ComboBox3.SelectedIndex = 3 Then

            discount = 0.2
        End If

        'Children
        If ComboBox3.SelectedIndex = 3 Then
            discount = 0.5
        End If
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
