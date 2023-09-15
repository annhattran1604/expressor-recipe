package bean;

public class giohang_bean {
	private long sl;
	private long thanhgia;
	private hang_bean hang;
	public giohang_bean() {
		super();
		// TODO Auto-generated constructor stub
	}
	public giohang_bean(long sl, long thanhgia, hang_bean hang) {
		super();
		this.sl = sl;
		this.thanhgia = thanhgia;
		this.hang = hang;
	}
	public long getSl() {
		return sl;
	}
	public void setSl(long sl) {
		this.sl = sl;
	}
	public long getThanhgia() {
		return thanhgia;
	}
	public void setThanhgia(long thanhgia) {
		this.thanhgia = thanhgia;
	}
	public hang_bean getHang() {
		return hang;
	}
	public void setHang(hang_bean hang) {
		this.hang = hang;
	}
	
}
