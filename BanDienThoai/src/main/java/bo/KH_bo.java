package bo;

import java.util.ArrayList;

import bean.kh_bean;
import dao.KH_dao;

public class KH_bo {
	KH_dao kdao=new KH_dao();
	public kh_bean ktdn(String tendn, String pass) throws Exception{
		return kdao.ktdn(tendn, pass);
	}
	public kh_bean ktdk(String tendn) throws Exception{
		return kdao.ktdk(tendn);
	}
	public void ThemKH(String hoten, String diachi, String sdt, String username, String password) throws Exception{
		kdao.ThemKH(hoten, diachi, sdt, username, password);
	}
	public int ktadmin(String user) throws Exception{
		return kdao.ktadmin(user);
	}
}
