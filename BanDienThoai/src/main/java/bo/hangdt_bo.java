package bo;

import dao.hangdt_dao;

public class hangdt_bo {
	hangdt_dao hdao=new hangdt_dao();
	public int ThemLoai(String maloai,String tenloai) throws Exception{
		return hdao.ThemLoai(maloai, tenloai);
	}
	public int SuaLoai(String maloai,String tenloai) throws Exception{
		return hdao.SuaLoai(maloai, tenloai);
	}
	public int XoaLoai(String maloai) throws Exception{
		return hdao.XoaLoai(maloai);
	}
}
