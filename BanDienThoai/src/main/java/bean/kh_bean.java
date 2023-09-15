package bean;

public class kh_bean {
	private long makh; 
	private String hoten;
	private String diachi;
	private String sdt;
	private String username;
	private String password;
	public kh_bean() {
		super();
		// TODO Auto-generated constructor stub
	}
	public kh_bean(long makh, String hoten, String diachi, String sdt, String username, String password) {
		super();
		this.makh = makh;
		this.hoten = hoten;
		this.diachi = diachi;
		this.sdt = sdt;
		this.username = username;
		this.password = password;
	}
	public long getMakh() {
		return makh;
	}
	public void setMakh(long makh) {
		this.makh = makh;
	}
	public String getHoten() {
		return hoten;
	}
	public void setHoten(String hoten) {
		this.hoten = hoten;
	}
	public String getDiachi() {
		return diachi;
	}
	public void setDiachi(String diachi) {
		this.diachi = diachi;
	}
	public String getSdt() {
		return sdt;
	}
	public void setSdt(String sdt) {
		this.sdt = sdt;
	}
	public String getUsername() {
		return username;
	}
	public void setUsername(String username) {
		this.username = username;
	}
	public String getPassword() {
		return password;
	}
	public void setPassword(String password) {
		this.password = password;
	}
	
}
