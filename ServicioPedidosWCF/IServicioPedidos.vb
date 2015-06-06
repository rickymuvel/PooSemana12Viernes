Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IServicioPedidos" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IServicioPedidos

    <OperationContract()>
    Function ClienteListar() As DataSet

    <OperationContract()>
    Function EmpleadoListar() As DataSet

    <OperationContract()>
    Function AñosListar() As DataSet

    <OperationContract()>
    Function PedidosConsulta(idCliente As String, idEmpleado As Integer,
                             año As Integer) As DataSet




End Interface
