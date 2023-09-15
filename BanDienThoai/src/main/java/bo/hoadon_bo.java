package bo;

import dao.hoadon_dao;

public class hoadon_bo {
	hoadon_dao hdao=new hoadon_dao();
	public int them(long makh) throws Exception{
		return hdao.them(makh);
	}
	public long getMaxHD () throws Exception{
		return hdao.getMaxHD();
	}
}
