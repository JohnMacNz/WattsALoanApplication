' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService" in both code and config file together.
<ServiceContract()>
Public Interface IWattsALoanService
    ' Manager Functions
    <OperationContract()>
    Function DeleteEmployee(ByVal empID As Integer) As Boolean
    <OperationContract()>
    Function InsertEmployee(ByVal empNum As Integer, ByVal fName As String, ByVal lName As String, ByVal title As String, ByVal salary As Double) As Boolean
    <OperationContract()>
    Function InsertLoan(ByVal loanType As String) As Boolean
    <OperationContract()>
    Function UpdateEmployee(ByVal empID As Integer, ByVal empNum As Integer, ByVal fName As String, ByVal lName As String, ByVal title As String, ByVal salary As Double) As Boolean
    ' Financial Advisor Functions
    <OperationContract()>
    Function InsertCustomer(ByVal dateCreated As Date, ByVal fullName As String, ByVal address As String, ByVal city As String, ByVal state As String, ByVal zipCode As String, ByVal email As String) As Boolean
    <OperationContract()>
    Function UpdateCustomer(ByVal custID As Integer, ByVal dateCreated As Date, ByVal fullName As String, ByVal address As String, ByVal city As String, ByVal state As String, ByVal zipCode As String, ByVal email As String) As Boolean
    <OperationContract()>
    Function InsertLoanAllocation(ByVal datePrepared As Date, ByVal empID As Integer, ByVal custID As Integer, ByVal accountNum As Integer, ByVal loanTypeID As Integer, ByVal loanAmount As Double, ByVal interestRate As Decimal, ByVal periods As Decimal) As Boolean
    <OperationContract()>
    Function SpecifyCurrentBalance(ByVal paymentDate As Date, ByVal empID As Integer, ByVal loanAllocationID As Integer, ByVal paymentAmount As Double) As Boolean

End Interface

