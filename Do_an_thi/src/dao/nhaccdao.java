package dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;
import java.text.SimpleDateFormat;

import bean.hanghoabean;
import bean.nhaccbean;

public class nhaccdao {
	ArrayList<nhaccbean> ds= new ArrayList<nhaccbean>();
	public ArrayList<nhaccbean> getdv() throws Exception{
		

		String sql="select * from nhacc";
		PreparedStatement cmd= coso.cn.prepareStatement(sql);

		ResultSet rs= cmd.executeQuery();
		while(rs.next()) {
			nhaccbean hh=new nhaccbean();
			//dn.setMahang(rs.getString("mahang"));
			hh.setNcc(rs.getString("ncc"));
			hh.setTenncc(rs.getString("tenncc"));
			hh.setDiachi(rs.getString("diachi"));
			hh.setSdt(rs.getDouble("sdt"));
			hh.setNgayhoptac(rs.getDate("ngayhoptac"));
			
			ds.add(hh);
		}
		rs.close();
		return ds;
	}
	public int Them(String ncc, String tenncc, String diachi, double sdt, Date ngayhoptac) throws Exception
	{
		String sql="insert into nhacc(ncc,tenncc,diachi,sdt,ngayhoptac) values (?, ?,?,?,?)";

		PreparedStatement cmd= coso.cn.prepareStatement (sql);
		cmd. setString(1,ncc);
		cmd.setString(2, tenncc);
		cmd.setString(3, diachi);
		cmd.setDouble(4, sdt);
		cmd.setDate(5, new java.sql.Date(ngayhoptac.getTime()));

		return cmd.executeUpdate();
		
	}
	public int Xoa(String ncc) throws Exception {
	    String sql="delete from nhacc where ncc=?";
	    PreparedStatement cmd= coso.cn.prepareStatement (sql);
	    cmd.setString (1, ncc);
	    return cmd.executeUpdate();
 }
}
