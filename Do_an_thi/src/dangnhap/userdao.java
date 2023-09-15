package dangnhap;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;

import javax.swing.JOptionPane;

import dao.coso;

public class userdao {
	ArrayList<userbean> ds= new ArrayList<userbean>();
	public ArrayList<userbean> getdv() throws Exception{
		
		//b1: tao cau lenh sql
		String sql="select * from [nguoidung]";
		//b2: tao ra doi tuong prepareStatement
		PreparedStatement cmd= coso.cn.prepareStatement(sql);
		//b3: thuc hien cau lenh
		ResultSet rs= cmd.executeQuery();
		while(rs.next()) {
			
			userbean dn=new userbean();
			dn.setUsername(rs.getString("username"));
			dn.setPassword(rs.getString("password"));
			ds.add(dn);
		}
		rs.close();
		return ds;
	}
	ArrayList<userbean> dsdo;
	public static int Them(String tk,String mk) throws Exception
	{
		
		String sql="insert into [nguoidung](username, password) values (?, ?)";
		PreparedStatement cmd= coso.cn.prepareStatement (sql);
		
		cmd. setString(1,tk);
		cmd.setString(2, mk);
		return cmd.executeUpdate();
		
	}

}
