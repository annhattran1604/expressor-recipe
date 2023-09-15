package bo;

import java.util.ArrayList;
import java.util.Calendar;

import bean.hang_bean;
import bean.hangdt_bean;

import dao.hang_dao;


public class hang_bo {
	hang_dao hdao=new hang_dao();
	ArrayList<hang_bean> ds;
	public ArrayList<hang_bean> getHach() throws Exception{
		ds=hdao.gethang();
		return ds;
	}
	public ArrayList<hangdt_bean> getHangDT() throws Exception{
		return hdao.gethangdt();
	}
	public ArrayList<hang_bean> TimMa(String maloai) throws Exception{
		ArrayList<hang_bean> tam = new ArrayList<hang_bean>();
		for(hang_bean i :ds)
		{
			if(i.getMahang().equals(maloai))
				tam.add(i);
		}
		return tam;
	}
	public ArrayList<hang_bean> TimDT(String key) throws Exception{
		ArrayList<hang_bean> tam = new ArrayList<hang_bean>();
		for(hang_bean i :ds)
		{
			if(i.getTendt().toLowerCase().contains(key.toLowerCase()))
				tam.add(i);
		}
		return tam;
	}

	public ArrayList<hang_bean> MoiNhat() throws Exception{
		ArrayList<hang_bean> tam = new ArrayList<hang_bean>();
		Calendar d=Calendar.getInstance();
		int nam=d.get(Calendar.YEAR);
		for(hang_bean i :ds)
		{
			if(i.getNamsx()==nam)
				tam.add(i);
		}
		return tam;
	}
	public void TangDan() throws Exception{

		int n=ds.size();
		for(int i=0;i<n-1;i++)
		{
			for(int j=i+1;j<n;j++)
			{
				if(ds.get(i).getGia()>ds.get(j).getGia())
				{
					hang_bean tam=ds.get(i);
					 ds.set(i, ds.get(j));
		             ds.set(j, tam);
				}
			}
		}
	}
	public void GiamDan() throws Exception{

		int n=ds.size();
		for(int i=0;i<n-1;i++)
		{
			for(int j=i+1;j<n;j++)
			{
				if(ds.get(i).getGia()<ds.get(j).getGia())
				{
					hang_bean tam=ds.get(i);
					 ds.set(i, ds.get(j));
		             ds.set(j, tam);
				}
			}
		}
	}
	public String TimLoai(String madt) throws Exception
	{	
		ds = hdao.gethang();
		for(hang_bean s: ds)
			if(s.getMadt().trim().equals(madt.trim()))
				return s.getMadt();
		return null;
	}
	public int ThemDT(String madt, String tendt, long soluong, String anh, long gia, String mahang, String size) throws Exception{
		return hdao.ThemDT(madt, tendt, soluong, anh, gia, mahang, size);
	}
	public int SuaDT(String madt, String tendt, long soluong, String anh, long gia, String mahang, String size) throws Exception{
		return hdao.SuaDT(madt, tendt, soluong, anh, gia, mahang, size);
	}
	public int XoaDT(String madt) throws Exception{
		return hdao.XoaDT(madt);
	}
}
