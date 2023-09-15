package dao;

import java.beans.Statement;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;

import bean.hanghoabean;

public class hanghoadao {

	ArrayList<hanghoabean> ds= new ArrayList<hanghoabean>();
	public ArrayList<hanghoabean> getdv() throws Exception{
		

		String sql="select * from  hanghoa";
		PreparedStatement cmd= coso.cn.prepareStatement(sql);

		ResultSet rs= cmd.executeQuery();
		while(rs.next()) {
			
			hanghoabean dn=new hanghoabean();
			dn.setMahang(rs.getString("mahang"));
			dn.setTenhang(rs.getString("tenhang"));
			dn.setGiaban(rs.getDouble("giaban"));
			dn.setNcc(rs.getString("ncc"));
			dn.setTonkho(rs.getDouble("tonkho"));
			ds.add(dn);
		}
		rs.close();
		return ds;
	}
	public int Them(String mahang, String tenhang, double giaban, String ncc, double tonkho) throws Exception
	{
		String sql="insert into hanghoa(mahang, tenhang, giaban, ncc, tonkho) values (?, ?,?,?,?)";

		PreparedStatement cmd= coso.cn.prepareStatement (sql);
		cmd. setString(1,mahang);
		cmd.setString(2, tenhang);
		cmd.setDouble(3, giaban);
		cmd.setString(4, ncc);
		cmd.setDouble(5, tonkho);

		return cmd.executeUpdate();
		
	}
	public int Xoa(String mahang) throws Exception {
	    String sql="delete from hanghoa where mahang=?";
	    PreparedStatement cmd= coso.cn.prepareStatement (sql);
	    cmd.setString (1, mahang);
	    return cmd.executeUpdate();
 }
	public int Sua(String mahang, String tenhang, double giaban, String ncc, double tonkho) throws Exception {

		String sql="update hanghoa set tenhang=? , giaban=? , ncc=? , tonkho=? where mahang=?";
		PreparedStatement cmd= coso.cn.prepareStatement(sql);
		cmd.setString(5,mahang);
		cmd.setString(1,tenhang);
		cmd.setDouble(2, giaban);
		cmd.setString(3, ncc);
		cmd.setDouble(4, tonkho);
		
		return cmd.executeUpdate();
	}

	
	
}
