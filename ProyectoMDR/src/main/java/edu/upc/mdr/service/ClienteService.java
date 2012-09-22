package edu.upc.mdr.service;

import java.util.ArrayList;

import edu.upc.mdr.bean.BeanCliente;

import javax.jws.WebParam;
import javax.jws.WebService;

@SuppressWarnings("restriction")
@WebService
public interface ClienteService {
	
	public String NombreCliente();
	
	public BeanCliente ConsultarCliente(@WebParam(name = "idCliente") int idCliente);
	
	public ArrayList<BeanCliente> ListarClientes();

}
