package bo;

import dao.chitiet_dao;

public class chitiet_bo {
	chitiet_dao cdao=new chitiet_dao();
	public int them(String madt, long slmua,long mahd) throws Exception{
		return cdao.them(madt, slmua, mahd);
	}
}
