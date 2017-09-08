Imports System.Data.SqlClient
Imports System.Data
Public Class Advisor

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objConnection As SqlConnection
        Dim objCommand As SqlCommand
        Dim retValue As Boolean

        objConnection = New SqlConnection("Data Source=PE205-26;Initial Catalog=WattsALoan;Integrated Security=True")
        objCommand = New SqlCommand("InsertCustomer", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        Dim objParameter1 As New SqlParameter("@DateCreated", SqlDbType.DateTime2, 7)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = txbDate.Text

        Dim objParameter2 As New SqlParameter("@FullName", SqlDbType.NVarChar, 20)
        objCommand.Parameters.Add(objParameter2)
        objParameter2.Direction = ParameterDirection.Input
        objParameter2.Value = txbName.Text

        Dim objParameter3 As New SqlParameter("@BillingAddress", SqlDbType.NVarChar, 100)
        objCommand.Parameters.Add(objParameter3)
        objParameter3.Direction = ParameterDirection.Input
        objParameter3.Value = txbBillAddress.Text

        Dim objParameter4 As New SqlParameter("@BillingCity", SqlDbType.NVarChar, 50)
        objCommand.Parameters.Add(objParameter4)
        objParameter4.Direction = ParameterDirection.Input
        objParameter4.Value = txbBillCity.Text

        Dim objParameter5 As New SqlParameter("@BillingState", SqlDbType.NVarChar, 50)
        objCommand.Parameters.Add(objParameter5)
        objParameter5.Direction = ParameterDirection.Input
        objParameter5.Value = txbBillState.Text

        Dim objParameter6 As New SqlParameter("@BillingZIPCide", SqlDbType.NVarChar, 10)
        objCommand.Parameters.Add(objParameter6)
        objParameter6.Direction = ParameterDirection.Input
        objParameter6.Value = txbZIP.Text

        Dim objParameter7 As New SqlParameter("@EmailAddress", SqlDbType.NVarChar, 100)
        objCommand.Parameters.Add(objParameter7)
        objParameter7.Direction = ParameterDirection.Input
        objParameter7.Value = txbEmail.Text

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
        objCommand = New SqlCommand("UpdateCustomer", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        Dim objParameter1 As New SqlParameter("@CustomerID", SqlDbType.Int)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = txbIDMod.Text

        Dim objParameter2 As New SqlParameter("@DateCreated", SqlDbType.DateTime2, 7)
        objCommand.Parameters.Add(objParameter2)
        objParameter2.Direction = ParameterDirection.Input
        objParameter2.Value = txbDateMod.Text

        Dim objParameter3 As New SqlParameter("@Fullname", SqlDbType.NVarChar, 50)
        objCommand.Parameters.Add(objParameter3)
        objParameter3.Direction = ParameterDirection.Input
        objParameter3.Value = txbNameMod.Text

        Dim objParameter4 As New SqlParameter("@BillingAddress", SqlDbType.NVarChar, 100)
        objCommand.Parameters.Add(objParameter4)
        objParameter4.Direction = ParameterDirection.Input
        objParameter4.Value = txbBillingAddressMod.Text


        Dim objParameter5 As New SqlParameter("@BillingCity", SqlDbType.NVarChar, 50)
        objCommand.Parameters.Add(objParameter5)
        objParameter5.Direction = ParameterDirection.Input
        objParameter5.Value = txbCityMod.Text

        Dim objParameter6 As New SqlParameter("@BillingState", SqlDbType.NVarChar, 50)
        objCommand.Parameters.Add(objParameter6)
        objParameter6.Direction = ParameterDirection.Input
        objParameter6.Value = txbStateMod.Text

        Dim objParameter7 As New SqlParameter("@BillingZIPCide", SqlDbType.NVarChar, 10)
        objCommand.Parameters.Add(objParameter7)
        objParameter7.Direction = ParameterDirection.Input
        objParameter7.Value = txbZIPMod.Text

        Dim objParameter8 As New SqlParameter("@EmailAddress", SqlDbType.NVarChar, 100)
        objCommand.Parameters.Add(objParameter8)
        objParameter8.Direction = ParameterDirection.Input
        objParameter8.Value = txbEmailMod.Text

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
        objCommand = New SqlCommand("InsertLoanAllocation", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        Dim objParameter1 As New SqlParameter("@DatePrepared", SqlDbType.DateTime2, 7)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = txbDatePrep.Text

        Dim objParameter2 As New SqlParameter("@EmployeeID", SqlDbType.Int)
        objCommand.Parameters.Add(objParameter2)
        objParameter2.Direction = ParameterDirection.Input
        objParameter2.Value = txbEmployeeID.Text

        Dim objParameter3 As New SqlParameter("@CustomerID", SqlDbType.Int)
        objCommand.Parameters.Add(objParameter3)
        objParameter3.Direction = ParameterDirection.Input
        objParameter3.Value = txbCustomerID.Text

        Dim objParameter4 As New SqlParameter("@AccountNumber", SqlDbType.NChar, 10)
        objCommand.Parameters.Add(objParameter4)
        objParameter4.Direction = ParameterDirection.Input
        objParameter4.Value = txbAccountNumber.Text

        Dim objParameter5 As New SqlParameter("@LoanTypeID", SqlDbType.Int)
        objCommand.Parameters.Add(objParameter5)
        objParameter5.Direction = ParameterDirection.Input
        objParameter5.Value = txbLoanTypeID.Text

        Dim objParameter6 As New SqlParameter("@LoanAmount", SqlDbType.Money)
        objCommand.Parameters.Add(objParameter6)
        objParameter6.Direction = ParameterDirection.Input
        objParameter6.Value = txbLoanAmount.Text

        Dim objParameter7 As New SqlParameter("@InterestRate", SqlDbType.Decimal, 6, 2)
        objCommand.Parameters.Add(objParameter7)
        objParameter7.Direction = ParameterDirection.Input
        objParameter7.Value = txbInterestRate.Text

        Dim objParameter8 As New SqlParameter("@Periods", SqlDbType.Decimal, 6, 2)
        objCommand.Parameters.Add(objParameter8)
        objParameter8.Direction = ParameterDirection.Input
        objParameter8.Value = txbPeriods.Text

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
        objCommand = New SqlCommand("SpecifyCurrentBalance", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        Dim objParameter1 As New SqlParameter("@PmtDate", SqlDbType.DateTime2, 7)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = txbPmtDate.Text

        Dim objParameter2 As New SqlParameter("@EmplID", SqlDbType.Int)
        objCommand.Parameters.Add(objParameter2)
        objParameter2.Direction = ParameterDirection.Input
        objParameter2.Value = txbEmpID.Text

        Dim objParameter3 As New SqlParameter("@LaID", SqlDbType.Int)
        objCommand.Parameters.Add(objParameter3)
        objParameter3.Direction = ParameterDirection.Input
        objParameter3.Value = txbLoanID.Text

        Dim objParameter4 As New SqlParameter("@PmtAmt", SqlDbType.Money)
        objCommand.Parameters.Add(objParameter4)
        objParameter4.Direction = ParameterDirection.Input
        objParameter4.Value = txbPmtAmt.Text

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