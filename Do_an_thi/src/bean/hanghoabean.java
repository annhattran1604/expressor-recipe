package bean;

public class hanghoabean {
	private String mahang;
	private String tenhang;
	private double giaban;
	private String ncc;
	private double tonkho;
	
	public hanghoabean() {
		super();
		// TODO Auto-generated constructor stub
	}
	public hanghoabean(String mahang, String tenhang, double giaban, String ncc, double tonkho) {
		super();
		this.mahang = mahang;
		this.tenhang = tenhang;
		this.giaban = giaban;
		this.ncc = ncc;
		this.tonkho = tonkho;
	}
	public String getMahang() {
		return mahang;
	}
	public void setMahang(String mahang) {
		this.mahang = mahang;
	}
	public String getTenhang() {
		return tenhang;
	}
	public void setTenhang(String tenhang) {
		this.tenhang = tenhang;
	}
	public double getGiaban() {
		return giaban;
	}
	public void setGiaban(double d) {
		this.giaban = d;
	}
	public String getNcc() {
		return ncc;
	}
	public void setNcc(String ncc) {
		this.ncc = ncc;
	}
	public double getTonkho() {
		return tonkho;
	}
	public void setTonkho(double tonkho) {
		this.tonkho = tonkho;
	}
	

}
