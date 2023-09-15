package bo;

import java.util.ArrayList;

import bean.giohang_bean;
import bean.lichsu_bean;
import dao.lichsuMH_dao;

public class lichsuMH_bo {
	lichsuMH_dao ldao=new lichsuMH_dao();
	ArrayList<lichsu_bean>ds=new ArrayList<lichsu_bean>();
	public ArrayList<lichsu_bean> getLSMH(long makh1) throws Exception{
		ds= ldao.getLSMH(makh1);
		return ds;
	}
	public ArrayList<lichsu_bean> getKHTT() throws Exception{
		return ldao.getKHTT();
	}
	public long Tongtien()
	{
		long s=0;
		for(lichsu_bean ls :ds) {
			s=s+ls.getThanhTien();
		}
		return s;
	}
}
