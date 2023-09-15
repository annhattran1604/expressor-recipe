package bean;

import java.util.Date;

public class lichsu_bean {
	private String madt;
	private String tendt;
	private long makh;
	private String hoten;
	private long gia;
	private long soluongmua;
	private boolean damua;
	private long ThanhTien;
	private Date ngaymua;
	public lichsu_bean() {
		super();
		// TODO Auto-generated constructor stub
	}
	public lichsu_bean(String madt, String tendt, long makh, String hoten, long gia, long soluongmua, boolean damua,
			long thanhTien, Date ngaymua) {
		super();
		this.madt = madt;
		this.tendt = tendt;
		this.makh = makh;
		this.hoten = hoten;
		this.gia = gia;
		this.soluongmua = soluongmua;
		this.damua = damua;
		ThanhTien = thanhTien;
		this.ngaymua = ngaymua;
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
	public long getGia() {
		return gia;
	}
	public void setGia(long gia) {
		this.gia = gia;
	}
	public long getSoluongmua() {
		return soluongmua;
	}
	public void setSoluongmua(long soluongmua) {
		this.soluongmua = soluongmua;
	}
	public boolean isDamua() {
		return damua;
	}
	public void setDamua(boolean damua) {
		this.damua = damua;
	}
	public long getThanhTien() {
		return ThanhTien;
	}
	public void setThanhTien(long thanhTien) {
		ThanhTien = thanhTien;
	}
	public Date getNgaymua() {
		return ngaymua;
	}
	public void setNgaymua(Date ngaymua) {
		this.ngaymua = ngaymua;
	}
	
}
