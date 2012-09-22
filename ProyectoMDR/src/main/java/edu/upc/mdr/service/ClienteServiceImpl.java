package edu.upc.mdr.service;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import javax.jws.WebService;
import edu.upc.mdr.bean.BeanCliente;

@SuppressWarnings("restriction")
@WebService(endpointInterface = "edu.upc.mdr.service.ClienteService")
public class ClienteServiceImpl implements ClienteService {

	public String NombreCliente() {
		//ArrayList<BeanCliente> ListaCliente = ListarClientes();
		//return ListaCliente.get(0).getNombreCliente();
		return "Aprobado";
	}

	public BeanCliente ConsultarCliente(int idCliente) {
		return null;
	}

	public ArrayList<BeanCliente> ListarClientes() {
		// TODO Auto-generated method stub
		/*Connection conn = null;

		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
			conn = DriverManager.getConnection(
					"jdbc:sqlserver://localhost:1433;DatabaseName=MdgArquitectos;user=sa;Password=adc");
		} catch (SQLException ex) {
			ex.printStackTrace();
		} catch (ClassNotFoundException exx) {
			exx.printStackTrace();
		}

		if (conn != null) {
			String SQL = "SELECT * FROM CLIENTES";
			try {
				PreparedStatement statement = conn.prepareStatement(SQL);
				ResultSet result = statement.executeQuery();
				ArrayList list = new ArrayList();
				while (result.next()) {
					BeanCliente cliente = new BeanCliente();
					cliente.setIdCliente(result.getInt("IdCliente"));
					cliente.setNombreCliente(result.getString("NombreCliente"));
					cliente.setApellidosCliente(result
							.getString("ApellidosCliente"));
					cliente.setEstadoCivil(result.getString("EstadoCivil"));
					cliente.setTipoDocumento(result.getString("TipoDocumento"));
					cliente.setNroDocumento(result.getString("NroDocumento"));
					list.add(cliente);
				}
				return list;
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}*/
		
		ArrayList<BeanCliente> ListaCliente = null;
		BeanCliente cliente = new BeanCliente();
		
		cliente.setIdCliente(1);
		cliente.setNombreCliente("Pepito");
		cliente.setApellidosCliente("Pepin");
		cliente.setEstadoCivil("SOLTERO");
		cliente.setTipoDocumento("DNI");
		cliente.setNroDocumento("12345678");
		
		ListaCliente.add(cliente);
		
		return ListaCliente;
	}

}
