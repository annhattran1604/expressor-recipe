package dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.text.SimpleDateFormat;
import java.util.Date;

public class hoadon_dao {
	public int them(long makh) throws Exception{
		ktsql kn=new ktsql();
		kn.ketnoi();
		String sql="insert into hoadon(makh,ngaymua,damua) values(?,?,?)";
		PreparedStatement cmd=kn.cn.prepareStatement(sql);
		cmd.setLong(1, makh);
		//Lấy ngày giờ hiện tại
		Date n1=new Date();
		SimpleDateFormat dd= new SimpleDateFormat("yyyy-MM-dd");
		//đổi ngày util sang chuoi theo dinh dang
		String tam=dd.format(n1);
		//đổi chuổi ra ngày util;
		Date n2=dd.parse(tam);
		//Đổi ngày util sang ngày sql và đưa vào tham số
		cmd.setDate(2, new java.sql.Date(n2.getTime()));
		cmd.setBoolean(3, false);
		int kq=cmd.executeUpdate();
		cmd.close();
		kn.cn.close();
		return kq;
	}
	public long getMaxHD () throws Exception
	{	
		ktsql kn=new ktsql();
		kn.ketnoi();
		String sql="select max(maHD) as Max from hoadon";
		PreparedStatement cmd=kn.cn.prepareStatement(sql);
		ResultSet rs=cmd.executeQuery();
		long max=0;
		if(rs.next())
		{
			max=rs.getLong(1);//lấy giá trị côt đầu tiên
		}
		rs.close();
		kn.cn.close();
		return max;
	}
}
