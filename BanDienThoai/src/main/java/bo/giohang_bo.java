package bo;

import java.util.ArrayList;

import bean.giohang_bean;
import bean.hang_bean;

public class giohang_bo {
	public ArrayList<giohang_bean> ds=new ArrayList<giohang_bean>();
	//Thêm vào ds giỏ hàng
	public void ThemHang(long sl, long thanhgia, hang_bean hang) {
		sl = 1;
		thanhgia = hang.getGia() * sl;
		int n=ds.size();
		for(int i = 0 ; i < n ; i++) {
			if(ds.get(i).getHang().getMadt().equals(hang.getMadt())) {
				sl = ds.get(i).getSl() + 1;
				thanhgia = ds.get(i).getHang().getGia() * sl;
				ds.get(i).setSl(sl);
				ds.get(i).setThanhgia(thanhgia);
				return;
			}
		}
		giohang_bean gio=new giohang_bean(sl, thanhgia, hang);
		ds.add(gio);
	}
	public long Tongtien()
	{
		long s=0;
		for(giohang_bean gio :ds) {
			s=s+gio.getThanhgia();
		}
		return s;
	}
	public void Sua(String madt, long slmoi)
	{
		int n=ds.size();
		for(int i=0;i<n;i++)
		{
			giohang_bean h=ds.get(i);
			if(h.getHang().getMadt().equals(madt))
			{
				h.setSl(slmoi);
				h.setThanhgia(slmoi * h.getHang().getGia());
				return;
			}
		}
	}
	public void Xoa(String madt)
	{
		for(giohang_bean h:ds)
			if(h.getHang().getMadt().equals(madt))
			{
				ds.remove(h);
				return;
			}
	}
}
