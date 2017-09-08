Imports System.Data.SqlClient
Imports System.Data
Public Class Manager

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objConnection As SqlConnection
        Dim objCommand As SqlCommand
        Dim retValue As Boolean

        objConnection = New SqlConnection("Data Source=PE205-26;Initial Catalog=WattsALoan;Integrated Security=True")
        objCommand = New SqlCommand("DeleteEmployee", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        Dim objParameter1 As New SqlParameter("@EmployeeID", SqlDbType.Int)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = txbEmpNum.Text

        Dim objOutputParameter As New SqlParameter("@Response", SqlDbType.Bit)
        objCommand.Parameters.Add(objOutputParameter)
        objOutputParameter.Direction = ParameterDirection.Output

        objConnection.Open()

        objCommand.ExecuteNonQuery()
        retValue = objCommand.Parameters("@Response").Value
        objConnection.Close()

        TextBox1.Text = retValue.ToString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objConnection As SqlConnection
        Dim objCommand As SqlCommand
        Dim retValue As Boolean

        objConnection = New SqlConnection("Data Source=PE205-26;Initial Catalog=WattsALoan;Integrated Security=True")
        objCommand = New SqlCommand("InsertEmployee", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure


        Dim objParameter1 As New SqlParameter("@EmployeeNumber", SqlDbType.NChar, 10)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = txbEmpNum.Text

        Dim objParameter2 As New SqlParameter("@FirstName", SqlDbType.NVarChar, 20)
        objCommand.Parameters.Add(objParameter2)
        objParameter2.Direction = ParameterDirection.Input
        objParameter2.Value = txbFName.Text

        Dim objParameter3 As New SqlParameter("@LastName", SqlDbType.NVarChar, 20)
        objCommand.Parameters.Add(objParameter3)
        objParameter3.Direction = ParameterDirection.Input
        objParameter3.Value = txbLName.Text

        Dim objParameter4 As New SqlParameter("@Title", SqlDbType.NVarChar, 100)
        objCommand.Parameters.Add(objParameter4)
        objParameter4.Direction = ParameterDirection.Input
        objParameter4.Value = txbTitle.Text

        Dim objParameter5 As New SqlParameter("@HourlySalary", SqlDbType.Money)
        objCommand.Parameters.Add(objParameter5)
        objParameter5.Direction = ParameterDirection.Input
        objParameter5.Value = txbSalary.Text

        Dim objOutputParameter As New SqlParameter("@Response", SqlDbType.Bit)
        objCommand.Parameters.Add(objOutputParameter)
        objOutputParameter.Direction = ParameterDirection.Output

        objConnection.Open()

        objCommand.ExecuteNonQuery()
        retValue = objCommand.Parameters("@Response").Value
        objConnection.Close()

        TextBox1.Text = retValue.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim objConnection As SqlConnection
        Dim objCommand As SqlCommand
        Dim retValue As Boolean

        objConnection = New SqlConnection("Data Source=PE205-26;Initial Catalog=WattsALoan;Integrated Security=True")
        objCommand = New SqlCommand("InsertLoan", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        Dim objParameter1 As New SqlParameter("@LoanType", SqlDbType.NVarChar, 50)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = txbCreateLoanType.Text

        Dim objOutputParameter As New SqlParameter("@Response", SqlDbType.Bit)
        objCommand.Parameters.Add(objOutputParameter)
        objOutputParameter.Direction = ParameterDirection.Output

        objConnection.Open()

        objCommand.ExecuteNonQuery()
        retValue = objCommand.Parameters("@Response").Value
        objConnection.Close()

        TextBox1.Text = retValue.ToString
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim objConnection As SqlConnection
        Dim objCommand As SqlCommand
        Dim retValue As Boolean

        objConnection = New SqlConnection("Data Source=PE205-26;Initial Catalog=WattsALoan;Integrated Security=True")
        objCommand = New SqlCommand("UpdateEmployee", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure


        Dim objParameter1 As New SqlParameter("@EmployeeID", SqlDbType.Int)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = txbEmployeeID.Text

        Dim objParameter2 As New SqlParameter("@EmployeeNumber", SqlDbType.NChar, 10)
        objCommand.Parameters.Add(objParameter2)
        objParameter2.Direction = ParameterDirection.Input
        objParameter2.Value = txbEmpNumMod.Text

        Dim objParameter3 As New SqlParameter("@FirstName", SqlDbType.NVarChar, 20)
        objCommand.Parameters.Add(objParameter3)
        objParameter3.Direction = ParameterDirection.Input
        objParameter3.Value = txbFNameMod.Text

        Dim objParameter4 As New SqlParameter("@LastName", SqlDbType.NVarChar, 20)
        objCommand.Parameters.Add(objParameter4)
        objParameter4.Direction = ParameterDirection.Input
        objParameter4.Value = txbLNameMod.Text

        Dim objParameter5 As New SqlParameter("@Title", SqlDbType.NVarChar, 100)
        objCommand.Parameters.Add(objParameter5)
        objParameter5.Direction = ParameterDirection.Input
        objParameter5.Value = txbTitleMod.Text

        Dim objParameter6 As New SqlParameter("@HourlySalary", SqlDbType.Money)
        objCommand.Parameters.Add(objParameter6)
        objParameter6.Direction = ParameterDirection.Input
        objParameter6.Value = txbSalaryMod.Text

        Dim objOutputParameter As New SqlParameter("@Response", SqlDbType.Bit)
        objCommand.Parameters.Add(objOutputParameter)
        objOutputParameter.Direction = ParameterDirection.Output

        objConnection.Open()

        objCommand.ExecuteNonQuery()
        retValue = objCommand.Parameters("@Response").Value
        objConnection.Close()

        TextBox1.Text = retValue.ToString
    End Sub
End Class