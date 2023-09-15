package dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;

import bean.lichsu_bean;

public class lichsuMH_dao {
	ArrayList<lichsu_bean> ds=new ArrayList<lichsu_bean>();
	public ArrayList<lichsu_bean> getLSMH(long makh1) throws Exception{
		String sql="select * from Vlichsu where makh=? order by ngaymua desc";
		ktsql kn= new ktsql();
		kn.ketnoi();
		PreparedStatement cmd=kn.cn.prepareStatement(sql);
		cmd.setLong(1,makh1);
		ResultSet rs=cmd.executeQuery();
		while(rs.next())
		{
			String madt= rs.getString("madt");
			String tendt=rs.getString("tendt");
			long makh=rs.getLong("makh");
			String hoten=rs.getString("hoten");
			long gia=rs.getLong("gia");
			long soluongmua=rs.getLong("soluongmua");
			boolean damua=rs.getBoolean("damua");
			long thanhTien=rs.getLong("ThanhTien");
			Date ngaymua=rs.getDate("ngaymua");
			ds.add(new lichsu_bean(madt, tendt, makh, hoten, gia, soluongmua, damua, thanhTien, ngaymua));
		}
		rs.close();
		kn.cn.close();
		return ds;
	}
	public ArrayList<lichsu_bean> getKHTT() throws Exception{
		String sql="select * from Vlichsu where damua=1 order by makh,ngaymua desc";
		ktsql kn= new ktsql();
		kn.ketnoi();
		PreparedStatement cmd=kn.cn.prepareStatement(sql);
		ResultSet rs=cmd.executeQuery();
		while(rs.next())
		{
			String madt= rs.getString("madt");
			String tendt=rs.getString("tendt");
			long makh=rs.getLong("makh");
			String hoten=rs.getString("hoten");
			long gia=rs.getLong("gia");
			long soluongmua=rs.getLong("soluongmua");
			boolean damua=rs.getBoolean("damua");
			long thanhTien=rs.getLong("ThanhTien");
			Date ngaymua=rs.getDate("ngaymua");
			ds.add(new lichsu_bean(madt, tendt, makh, hoten, gia, soluongmua, damua, thanhTien, ngaymua));
		}
		rs.close();
		kn.cn.close();
		return ds;
	}
}
