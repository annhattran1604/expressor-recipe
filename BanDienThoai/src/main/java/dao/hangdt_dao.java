package dao;

import java.sql.PreparedStatement;

public class hangdt_dao {
	public int ThemLoai(String maloai,String tenloai) throws Exception
	{
		ktsql kn=new ktsql();
		kn.ketnoi();
		String sql="insert into hangdt(mahang,tenhang) values(?, ?)";
		PreparedStatement cmd=kn.cn.prepareStatement(sql);
		cmd.setString(1, maloai);
		cmd.setString(2, tenloai);
		int kq= cmd.executeUpdate();
		cmd.close();kn.cn.close();
		return kq;
	}
	public int SuaLoai(String maloai,String tenloai) throws Exception{
		ktsql kn=new ktsql();
		kn.ketnoi();
		String sql="update hangdt set tenhang=? where mahang=?";
		PreparedStatement cmd=kn.cn.prepareStatement(sql);
		cmd.setString(1, tenloai);
		cmd.setString(2, maloai);
		int kq= cmd.executeUpdate();
		cmd.close();kn.cn.close();
		return kq;
	}
	public int XoaLoai(String maloai) throws Exception{
		ktsql kn=new ktsql();
		kn.ketnoi();
		String sql="delete from hangdt where mahang=?";
		PreparedStatement cmd=kn.cn.prepareStatement(sql);
		cmd.setString(1, maloai);
		int kq= cmd.executeUpdate();
		cmd.close();kn.cn.close();
		return kq;
	}
}
