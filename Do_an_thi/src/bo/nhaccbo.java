package bo;

import java.util.Date;
import java.util.ArrayList;
import java.text.SimpleDateFormat;
import javax.swing.JOptionPane;

import bean.hanghoabean;
import bean.nhaccbean;
import dao.nhaccdao;

public class nhaccbo {
	nhaccdao dao= new nhaccdao();
    ArrayList<nhaccbean> ds;
    
    public ArrayList<nhaccbean> getdv() throws Exception{
    	ds=dao.getdv();
    	return ds;
    }
    public int Them(String ncc, String tenncc, String diachi, double sdt, Date ngayhoptac) throws Exception {
	
		for(nhaccbean hh: ds)
			if(hh.getNcc().equals(ncc))
			{
				JOptionPane.showMessageDialog(null,"Xem lại mã nhà cung cấp!");
				return 0;}
		ds.add(new nhaccbean(ncc, tenncc, diachi, sdt, ngayhoptac));
		dao.Them(ncc, tenncc, diachi, sdt, ngayhoptac);//Them vao csdl
		return 1;
	}
    public int Xoa(String ncc) throws Exception {
		for(nhaccbean cc: ds)
			if(cc.getNcc().equals(ncc)) {
				ds.remove(cc);
				dao.Xoa(ncc);
				return 1;
			}
		return 0;		
	}
    public ArrayList<nhaccbean> TimDC(String dv) throws Exception{
    	ArrayList<nhaccbean>  tam= new ArrayList<nhaccbean>();
			for(nhaccbean cc: ds)
			{
				if(cc.getDiachi().toLowerCase().equals(dv.toLowerCase()))
					tam.add(cc);}
			return tam;
	}
    public ArrayList<nhaccbean> Load() throws Exception{
    	ArrayList<nhaccbean>  tam= new ArrayList<nhaccbean>();
			for(nhaccbean cc: ds)
			{
					tam.add(cc);}
			return tam;
	}

}
