package bo;

import java.util.ArrayList;

import bean.xacnhantt_bean;
import dao.xacnhantt_dao;

public class xacnhantt_bo {
	xacnhantt_dao xdao=new xacnhantt_dao();
	public int CapNhat(long machitiet) throws Exception {
		return xdao.CapNhat(machitiet);
	}
	public ArrayList<xacnhantt_bean> getHDXN() throws Exception{
		return xdao.getHDXN();
	}
}
