Imports System.Data.SqlClient

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "ServicioPedidos" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioPedidos.svc o ServicioPedidos.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class ServicioPedidos
    Implements IServicioPedidos

    Dim cn As New SqlConnection(
    "Data Source=localhost;Initial Catalog=Negocios2015;UID=sa;PWD=sql")

    Public Function AñosListar() As DataSet Implements IServicioPedidos.AñosListar
        Dim da As New SqlDataAdapter("usp_AñosListar", cn)
        Dim ds As New DataSet
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(ds)
        Return ds
    End Function

    Public Function ClienteListar() As DataSet Implements IServicioPedidos.ClienteListar
        Dim da As New SqlDataAdapter("usp_ClienteListarWCF", cn)
        Dim ds As New DataSet
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(ds)
        Return ds
    End Function

    Public Function EmpleadoListar() As DataSet Implements IServicioPedidos.EmpleadoListar
        Dim da As New SqlDataAdapter("usp_EmpleadoListarWCF", cn)
        Dim ds As New DataSet
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(ds)
        Return ds
    End Function

    Public Function PedidosConsulta(idCliente As String, idEmpleado As Integer, año As Integer) As DataSet Implements IServicioPedidos.PedidosConsulta
        Dim da As New SqlDataAdapter("usp_ConsultaPedidosWCF", cn)
        Dim ds As New DataSet
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        '@idCliente varchar(5), @idEmpleado int,
        '@Año int
        da.SelectCommand.Parameters.AddWithValue("@idCliente", idCliente)
        da.SelectCommand.Parameters.AddWithValue("@idEmpleado", idEmpleado)
        da.SelectCommand.Parameters.AddWithValue("@Año", año)
        da.Fill(ds)
        Return ds
    End Function
End Class
