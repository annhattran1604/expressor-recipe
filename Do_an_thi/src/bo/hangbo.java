package bo;

import java.util.ArrayList;

import javax.swing.JOptionPane;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

import bean.hanghoabean;
import dao.hanghoadao;

public class hangbo {

	hanghoadao hhdao= new hanghoadao();
    ArrayList<hanghoabean> ds;
    public ArrayList<hanghoabean> getdv() throws Exception{
    	ds=hhdao.getdv();
    	return ds;
    }
    public int Them(String mahang, String tenhang, double giaban, String ncc, double tonkho) throws Exception {
		for(hanghoabean hh: ds)
			if(hh.getMahang().equals(mahang))
			{
				JOptionPane.showMessageDialog(null,"Mã hàng này đã có!");
				return 0;}
		ds.add(new hanghoabean(mahang, tenhang, giaban, ncc, tonkho));//Them vao bonho
		hhdao.Them(mahang, tenhang, giaban, ncc, tonkho);//Them vao csdl
		return 1;
	}
    public int Xoa(String mahang) throws Exception {
		for(hanghoabean hh: ds)
			if(hh.getMahang().equals(mahang)) {
				ds.remove(hh);
				hhdao.Xoa(mahang);
				return 1;
			}
		return 0;		
	}
    public int Sua(String mahang, String tenhang, double giaban, String ncc, double tonkho) throws Exception {
		for(hanghoabean dv: ds)
			if(dv.getMahang().equals(mahang)) {
				dv.setMahang(mahang);
				dv.setTenhang(tenhang);
				dv.setGiaban(giaban);
				dv.setNcc(ncc);
				dv.setTonkho(tonkho);

				hhdao.Sua(mahang, tenhang, giaban, ncc, tonkho);
				return 1;
			}
		return 0;
	}
    public ArrayList<hanghoabean> Tim(String dv) throws Exception{
		ArrayList<hanghoabean>  tam= new ArrayList<hanghoabean>();
			for(hanghoabean hh: ds)
			{
				if(hh.getNcc().toLowerCase().equals(dv.toLowerCase()))
					tam.add(hh);}
			return tam;
	}
    public ArrayList<hanghoabean> Hienthi() throws Exception{
		ArrayList<hanghoabean>  tam= new ArrayList<hanghoabean>();
			for(hanghoabean hh: ds)
			{
					tam.add(hh);}
			return tam;
	}
    
}
