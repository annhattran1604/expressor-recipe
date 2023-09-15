package bean;

import java.util.Date;

public class xacnhantt_bean {
	private String tendt;
	private Date ngaymua;
	private String hoten;
	private long makh;
	private long soluongmua;
	private Boolean damua;
	private long maCTHD;
	private long ThanhTien;
	private long gia;
	public xacnhantt_bean() {
		super();
		// TODO Auto-generated constructor stub
	}
	public xacnhantt_bean(String tendt, Date ngaymua, String hoten, long makh, long soluongmua, Boolean damua,
			long maCTHD, long thanhTien, long gia) {
		super();
		this.tendt = tendt;
		this.ngaymua = ngaymua;
		this.hoten = hoten;
		this.makh = makh;
		this.soluongmua = soluongmua;
		this.damua = damua;
		this.maCTHD = maCTHD;
		ThanhTien = thanhTien;
		this.gia = gia;
	}
	public String getTendt() {
		return tendt;
	}
	public void setTendt(String tendt) {
		this.tendt = tendt;
	}
	public Date getNgaymua() {
		return ngaymua;
	}
	public void setNgaymua(Date ngaymua) {
		this.ngaymua = ngaymua;
	}
	public String getHoten() {
		return hoten;
	}
	public void setHoten(String hoten) {
		this.hoten = hoten;
	}
	public long getMakh() {
		return makh;
	}
	public void setMakh(long makh) {
		this.makh = makh;
	}
	public long getSoluongmua() {
		return soluongmua;
	}
	public void setSoluongmua(long soluongmua) {
		this.soluongmua = soluongmua;
	}
	public Boolean getDamua() {
		return damua;
	}
	public void setDamua(Boolean damua) {
		this.damua = damua;
	}
	public long getMaCTHD() {
		return maCTHD;
	}
	public void setMaCTHD(long maCTHD) {
		this.maCTHD = maCTHD;
	}
	public long getThanhTien() {
		return ThanhTien;
	}
	public void setThanhTien(long thanhTien) {
		ThanhTien = thanhTien;
	}
	public long getGia() {
		return gia;
	}
	public void setGia(long gia) {
		this.gia = gia;
	}
	
}
