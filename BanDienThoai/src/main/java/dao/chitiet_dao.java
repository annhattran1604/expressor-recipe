package dao;

import java.sql.PreparedStatement;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;


public class chitiet_dao {
	
	public int them(String madt, long slmua,long mahd) throws Exception{
		ktsql kn=new ktsql();
		kn.ketnoi();
		String sql="insert into chitietHD(madt,soluongmua,maHD,damua) values (?,?,?,?)";
		PreparedStatement cmd=kn.cn.prepareStatement(sql);
		cmd.setString(1, madt);
		cmd.setLong(2, slmua);
		cmd.setLong(3, mahd);
		cmd.setBoolean(4, false);
		int kq=cmd.executeUpdate();
		cmd.close();
		// update so luong cua giay
		String sql2 = "update dienthoai set soluong = soluong - soluongmua from  dienthoai, chitietHD where dienthoai.madt = chitietHD.madt and maHD=?";
		PreparedStatement updatecmd = kn.cn.prepareStatement(sql2);
		// Set gia tri vao ?
		updatecmd.setLong(1, mahd);
		int kqupdate = updatecmd.executeUpdate();
		updatecmd.close();
		kn.cn.close();
		return kq + kqupdate;
	}
	
}
