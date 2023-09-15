package bean;

import java.util.Date;

import javax.xml.crypto.Data;

public class hang_bean {
	private String madt; 
	private String tendt;
	private long soluong;
	private String anh;
	private long gia;
	private String mahang;
	private Date ngaynhap;
	private long namsx;
	private String size;
	
	
	public hang_bean() {
		super();
		// TODO Auto-generated constructor stub
	}
	public hang_bean(String madt, String tendt, long soluong, String anh, long gia, String mahang, Date ngaynhap,
			long namsx, String size) {
		super();
		this.madt = madt;
		this.tendt = tendt;
		this.soluong = soluong;
		this.anh = anh;
		this.gia = gia;
		this.mahang = mahang;
		this.ngaynhap = ngaynhap;
		this.namsx = namsx;
		this.size = size;
	}
	public String getMadt() {
		return madt;
	}
	public void setMadt(String madt) {
		this.madt = madt;
	}
	public String getTendt() {
		return tendt;
	}
	public void setTendt(String tendt) {
		this.tendt = tendt;
	}
	public long getSoluong() {
		return soluong;
	}
	public void setSoluong(long soluong) {
		this.soluong = soluong;
	}
	public String getAnh() {
		return anh;
	}
	public void setAnh(String anh) {
		this.anh = anh;
	}
	public long getGia() {
		return gia;
	}
	public void setGia(long gia) {
		this.gia = gia;
	}
	public String getMahang() {
		return mahang;
	}
	public void setMahang(String mahang) {
		this.mahang = mahang;
	}
	public Date getNgaynhap() {
		return ngaynhap;
	}
	public void setNgaynhap(Date ngaynhap) {
		this.ngaynhap = ngaynhap;
	}
	public long getNamsx() {
		return namsx;
	}
	public void setNamsx(long namsx) {
		this.namsx = namsx;
	}
	public String getSize() {
		return size;
	}
	public void setSize(String size) {
		this.size = size;
	}
	
}
