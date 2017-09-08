Imports System.Data.SqlClient
Imports System.Data
Public Class WattsALoanService
    Implements IWattsALoanService

    Public Function DeleteEmployee(ByVal empID As Integer) As Boolean Implements IWattsALoanService.DeleteEmployee
        Dim objConnection As SqlConnection
        Dim objCommand As SqlCommand
        Dim retValue As Boolean

        objConnection = New SqlConnection("Data Source=PE205-26;Initial Catalog=WattsALoan;Integrated Security=True")
        objCommand = New SqlCommand("DeleteEmployee", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        Dim objParameter1 As New SqlParameter("@EmployeeID", SqlDbType.Int)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = empID

        Dim objOutputParameter As New SqlParameter("@Response", SqlDbType.Bit)
        objCommand.Parameters.Add(objOutputParameter)
        objOutputParameter.Direction = ParameterDirection.Output

        objConnection.Open()

        objCommand.ExecuteNonQuery()
        retValue = objCommand.Parameters("@Response").Value
        objConnection.Close()

        If retValue Then Return True

        Return False

    End Function

End Class
