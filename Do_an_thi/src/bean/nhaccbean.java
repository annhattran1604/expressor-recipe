package bean;
import java.text.SimpleDateFormat;
import java.util.Date;

public class nhaccbean {
	private String ncc;
	private String tenncc;
	private String diachi;
	private double sdt;
	private Date ngayhoptac;
	
	public nhaccbean() {
		super();
		// TODO Auto-generated constructor stub
	}
	public nhaccbean(String ncc, String tenncc, String diachi, double sdt, Date ngayhoptac) {
		super();
		this.ncc = ncc;
		this.tenncc = tenncc;
		this.diachi = diachi;
		this.sdt = sdt;
		this.ngayhoptac = ngayhoptac;
	}
	public String getNcc() {
		return ncc;
	}
	public void setNcc(String ncc) {
		this.ncc = ncc;
	}
	public String getTenncc() {
		return tenncc;
	}
	public void setTenncc(String tenncc) {
		this.tenncc = tenncc;
	}
	public String getDiachi() {
		return diachi;
	}
	public void setDiachi(String diachi) {
		this.diachi = diachi;
	}
	public double getSdt() {
		return sdt;
	}
	public void setSdt(double sdt) {
		this.sdt = sdt;
	}
	public Date getNgayhoptac() {
		return ngayhoptac;
	}
	public void setNgayhoptac(Date ngayhoptac) {
		this.ngayhoptac = ngayhoptac;
	}

}
