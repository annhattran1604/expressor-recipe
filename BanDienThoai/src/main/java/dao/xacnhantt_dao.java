package dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;

import bean.xacnhantt_bean;

public class xacnhantt_dao {
	public int CapNhat(long machitiet) throws Exception {
		ktsql kn=new ktsql();
		kn.ketnoi();
		String sql="update chitietHD set damua='1' where maCTHD=?";
		PreparedStatement cmd=kn.cn.prepareStatement(sql);
		cmd.setLong(1, machitiet);
		int kq=cmd.executeUpdate();
		cmd.close();
		kn.cn.close();
		return kq;
	}
	
	public ArrayList<xacnhantt_bean> getHDXN() throws Exception{
		ArrayList<xacnhantt_bean> ds =new ArrayList<xacnhantt_bean>();
		ktsql kn=new ktsql();
		kn.ketnoi();
		String sql="select * from Vxacnhan order by makh,ngaymua desc";
		PreparedStatement cmd=kn.cn.prepareStatement(sql);
		ResultSet rs=cmd.executeQuery();
		while(rs.next())
		{
			String tendt=rs.getString("tendt");
			Date ngaymua=rs.getDate("ngaymua");
			String hoten=rs.getString("hoten");
			long makh=rs.getLong("makh");
			long soluongmua=rs.getLong("soluongmua");
			Boolean damua=rs.getBoolean("damua");
			long maCTHD=rs.getLong("maCTHD");
			long thanhTien=rs.getLong("ThanhTien");
			long gia=rs.getLong("gia");
			ds.add(new xacnhantt_bean(tendt, ngaymua, hoten, makh, soluongmua, damua, maCTHD, thanhTien, gia));
		}
		rs.close();kn.cn.close();
		return ds;
	}
}
