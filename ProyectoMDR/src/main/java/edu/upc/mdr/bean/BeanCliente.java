package edu.upc.mdr.bean;

public class BeanCliente {

	int idCliente;
	String NombreCliente;
	String ApellidosCliente;
	int idTipoCliente;
	int idEstadoCivil;
	int idTipoDocumento;
	String NroDocumento;
	int Estado;
	String EstadoCivil;
	String TipoDocumento;
	
	public BeanCliente() {
		super();
	}

	public BeanCliente(int idCliente, String nombreCliente,
			String apellidosCliente, int idTipoCliente, int idEstadoCivil,
			int idTipoDocumento, String nroDocumento, int estado,
			String estadoCivil, String tipoDocumento) {
		super();
		this.idCliente = idCliente;
		NombreCliente = nombreCliente;
		ApellidosCliente = apellidosCliente;
		this.idTipoCliente = idTipoCliente;
		this.idEstadoCivil = idEstadoCivil;
		this.idTipoDocumento = idTipoDocumento;
		NroDocumento = nroDocumento;
		Estado = estado;
		EstadoCivil = estadoCivil;
		TipoDocumento = tipoDocumento;
	}
	

	public int getIdCliente() {
		return idCliente;
	}

	public void setIdCliente(int idCliente) {
		this.idCliente = idCliente;
	}

	public String getNombreCliente() {
		return NombreCliente;
	}

	public void setNombreCliente(String nombreCliente) {
		NombreCliente = nombreCliente;
	}

	public String getApellidosCliente() {
		return ApellidosCliente;
	}

	public void setApellidosCliente(String apellidosCliente) {
		ApellidosCliente = apellidosCliente;
	}

	public int getIdTipoCliente() {
		return idTipoCliente;
	}

	public void setIdTipoCliente(int idTipoCliente) {
		this.idTipoCliente = idTipoCliente;
	}

	public int getIdEstadoCivil() {
		return idEstadoCivil;
	}

	public void setIdEstadoCivil(int idEstadoCivil) {
		this.idEstadoCivil = idEstadoCivil;
	}

	public int getIdTipoDocumento() {
		return idTipoDocumento;
	}

	public void setIdTipoDocumento(int idTipoDocumento) {
		this.idTipoDocumento = idTipoDocumento;
	}

	public String getNroDocumento() {
		return NroDocumento;
	}

	public void setNroDocumento(String nroDocumento) {
		NroDocumento = nroDocumento;
	}

	public int getEstado() {
		return Estado;
	}

	public void setEstado(int estado) {
		Estado = estado;
	}

	public String getEstadoCivil() {
		return EstadoCivil;
	}

	public void setEstadoCivil(String estadoCivil) {
		EstadoCivil = estadoCivil;
	}

	public String getTipoDocumento() {
		return TipoDocumento;
	}

	public void setTipoDocumento(String tipoDocumento) {
		TipoDocumento = tipoDocumento;
	}
	
	
}
