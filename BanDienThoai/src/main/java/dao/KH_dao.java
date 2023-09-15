package dao;

import java.math.BigInteger;
import java.security.MessageDigest;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;

import bean.kh_bean;

public class KH_dao {
	ktsql kn=new ktsql();
	//Chuyển đổi MD5
	public static String encryptMD5(String password) throws Exception {
		MessageDigest m = MessageDigest.getInstance("MD5");
		m.update(password.getBytes(), 0, password.length());
		return new BigInteger(1, m.digest()).toString(16);
	}
	
	//hàm kiểm tra user và pass
	public kh_bean ktdn(String tendn, String pass) throws Exception
	{
		kn.ketnoi();
		String sql="select * from KhachHang where username=? and password=?";
		PreparedStatement cmd = kn.cn.prepareStatement(sql);
		cmd.setString(1, tendn);
		cmd.setString(2, encryptMD5(pass));
		ResultSet rs= cmd.executeQuery();
		kh_bean kh=null;
		if(rs.next())
		{
			long makh = rs.getLong("makh");
			String hoten = rs.getString("hoten");
			String diachi = rs.getString("diachi");
			String sdt = rs.getString("sdt");
			String username = rs.getString("username");
			String password = rs.getString("password");
			kh=new kh_bean(makh, hoten, diachi, sdt, username, password);
		}
		rs.close();
		kn.cn.close();
		return kh;
	}
	public int ktadmin(String user) throws Exception
	{
		kn.ketnoi();
		String sql="select * from KhachHang where username='admin'";
		PreparedStatement cmd = kn.cn.prepareStatement(sql);
		ResultSet rs= cmd.executeQuery();
		kh_bean kh=null;
		while (rs.next()) {
			String tendn = rs.getString("username");
			if (user.trim().equals(tendn.trim()) ) {
				return 1;
			}
		}
		rs.close();
		kn.cn.close();
		return 0;
	}
	public kh_bean ktdk(String tendn) throws Exception
	{
		kn.ketnoi();
		String sql="select * from KhachHang where username=?";
		PreparedStatement cmd = kn.cn.prepareStatement(sql);
		cmd.setString(1, tendn);
		ResultSet rs= cmd.executeQuery();
		kh_bean kh=null;
		if(rs.next())
		{
			long makh = rs.getLong("makh");
			String hoten = rs.getString("hoten");
			String diachi = rs.getString("diachi");
			String sdt = rs.getString("sdt");
			String username = rs.getString("username");
			String password = rs.getString("password");
			kh=new kh_bean(makh, hoten, diachi, sdt, username, password);
		}
		return kh;
	}
	public void ThemKH(String hoten, String diachi, String sdt, String username, String password) throws Exception{
		String sql="insert into [KhachHang](hoten,diachi,sdt,username,password) values (?,?,?,?,?)";
		PreparedStatement cmd=kn.cn.prepareStatement(sql);
		cmd.setString(1, hoten);
		cmd.setString(2, diachi);
		cmd.setString(3, sdt);
		cmd.setString(4, username);
		cmd.setString(5, encryptMD5(password));
		cmd.executeUpdate();
	}
}
