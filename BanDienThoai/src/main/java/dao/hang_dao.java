package dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;

import javax.xml.crypto.Data;

import bean.hang_bean;
import bean.hangdt_bean;

public class hang_dao {
	public ArrayList<hang_bean> ds =new ArrayList<hang_bean>();
	public ArrayList<hangdt_bean> dshang =new ArrayList<hangdt_bean>();
	ktsql kn = new ktsql();
	public ArrayList<hang_bean> gethang() throws Exception{
		kn.ketnoi();
		String sql ="Select * from dienthoai";
		PreparedStatement cmd = kn.cn.prepareStatement(sql);
		ResultSet rs=cmd.executeQuery();
		while (rs.next())
		{
			String madt = rs.getString("madt");
			String tendt = rs.getString("tendt");
			long soluong = rs.getLong("soluong");
			String anh = rs.getString("anh");
			long gia=rs.getLong("gia");
			String mahang = rs.getString("mahang");
			Date ngaynhap = (Date) rs.getDate("ngaynhap");
			long namsx = rs.getLong("namsx");
			String size = rs.getString("size");
			ds.add(new hang_bean(madt, tendt, soluong, anh, gia, mahang, ngaynhap, namsx, size));
		}
		rs.close();
		kn.cn.close();
		return ds;
	}
	public ArrayList<hangdt_bean> gethangdt() throws Exception{
		kn.ketnoi();
		String sql ="Select * from hangdt";
		PreparedStatement cmd = kn.cn.prepareStatement(sql);
		ResultSet rs=cmd.executeQuery();
		while (rs.next())
		{
			String madt = rs.getString("mahang");
			String tendt = rs.getString("tenhang");

			dshang.add(new hangdt_bean(madt, tendt));
		}
		//đóng rs và kết nối 
		rs.close();
		kn.cn.close();
		return dshang;
	}
	public int ThemDT(String madt, String tendt, long soluong, String anh, long gia, String mahang, String size) throws Exception
	{
		ktsql kn=new ktsql();
		kn.ketnoi();
		String sql="insert into dienthoai(madt,tendt,soluong,anh,gia,mahang,ngaynhap,namsx,size) values(?, ?,?,?,?,?,?,?,?)";
		PreparedStatement cmd=kn.cn.prepareStatement(sql);
		//Lấy ngày giờ hiện tại
		Date n1=new Date();
		SimpleDateFormat dd= new SimpleDateFormat("yyyy-MM-dd");
		//đổi ngày util sang chuoi theo dinh dang
		String tam=dd.format(n1);
		//đổi chuổi ra ngày util;
		Date n2=dd.parse(tam);
		Calendar d=Calendar.getInstance();
		long nam=d.get(Calendar.YEAR);
		cmd.setString(1, madt);
		cmd.setString(2,tendt);
		cmd.setLong(3, soluong);
		cmd.setString(4, anh);
		cmd.setLong(5, gia);
		cmd.setString(6,mahang);
		cmd.setDate(7, new java.sql.Date(n2.getTime()));
		cmd.setLong(8, nam);
		cmd.setString(9,size);
		int kq= cmd.executeUpdate();
		cmd.close();kn.cn.close();
		return kq;
	}
	public int SuaDT(String madt, String tendt, long soluong, String anh, long gia, String mahang, String size) throws Exception{
		ktsql kn=new ktsql();
		kn.ketnoi();
		String sql="update dienthoai set tendt=?,soluong=?,gia=?,mahang=?,size=? where madt=?";
		PreparedStatement cmd=kn.cn.prepareStatement(sql);
		cmd.setString(6, madt);
		cmd.setString(1, tendt);
		cmd.setLong(2, soluong);
		cmd.setLong(3,gia);
		cmd.setString(4, mahang);
		cmd.setString(5, size);	
		int kq= cmd.executeUpdate();
		cmd.close();kn.cn.close();
		return kq;
	}
	public int XoaDT(String madt) throws Exception{
		ktsql kn=new ktsql();
		kn.ketnoi();
		String sql="delete from dienthoai where madt=?";
		PreparedStatement cmd=kn.cn.prepareStatement(sql);
		cmd.setString(1, madt);
		int kq= cmd.executeUpdate();
		cmd.close();kn.cn.close();
		return kq;
	}
}
