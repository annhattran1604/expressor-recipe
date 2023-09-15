package view;

	import java.util.ArrayList;
	import java.util.Arrays;
	import java.util.Scanner;
	import javax.sql.rowset.spi.SyncFactory;

	public class docso {

		public static final String KHONG = "khong";    
	    public static final String MOT = "mot";
	    public static final String HAI = "hai";
	    public static final String BA = "ba";
	    public static final String BON = "bon";
	    public static final String NAM = "nam";
	    public static final String SAU = "sau";
	    public static final String BAY = "bay";
	    public static final String TAM = "tam";
	    public static final String CHIN = "chin";
	    public static final String LAM = "lam";
	    public static final String LE = "le";
	    public static final String MUOI = "muoi";
	    public static final String MUOIF = "muoi(10)";
	    public static final String MOTS = "mốt";
	    public static final String TRAM = "tram";
	    public static final String NGHIN = "nghin";
	    public static final String TRIEU = "trieu";
	    public static final String TY = "ty";
	 
	 
	    public static final String [] number = {KHONG, MOT, HAI, BA,
	        BON, NAM, SAU, BAY, TAM, CHIN};
	    
	    public static ArrayList<String> readNum1(String a)
	    {
	        ArrayList<String> kq = new ArrayList<String>();
	 
	 
	        //Cắt chuổi string chử số ra thành các chuổi nhỏ 3 chử số
	        ArrayList<String> List_Num = Split(a, 3);
	 
	 
	        while (List_Num.size() != 0)
	        {      
	            //Xét 3 số đầu tiên của chuổi (số đầu tiên của List_Num)
	            switch (List_Num.size() % 3)
	            {
	            //3 số đó thuộc hàng trăm
	            case 1:
	                kq.addAll(read_3num(List_Num.get(0)));
	                break;
	            // 3 số đó thuộc hàng nghìn
	            case 2:
	                ArrayList<String> nghin = read_3num(List_Num.get(0));
	                if(!nghin.isEmpty()){
	                    kq.addAll(nghin);
	                    kq.add(NGHIN);
	                }
	                break;
	            //3 số đó thuộc hàng triệu
	            case 0:                    
	                ArrayList<String> trieu = read_3num(List_Num.get(0));
	                if(!trieu.isEmpty()) {
	                    kq.addAll(trieu);
	                    kq.add(TRIEU);
	                }
	                break;
	            }
	           
	            //Xét nếu 3 số đó thuộc hàng tỷ
	            if (List_Num.size() == (List_Num.size() / 3) * 3 + 1 && List_Num.size() != 1) kq.add(TY);
	           
	            //Xóa 3 số đầu tiên để tiếp tục 3 số kế
	            List_Num.remove(0);
	        }
	 
	 
	        return kq;
	    }
	    
	    public static ArrayList<String> read_3num(String a)
	    {
	        ArrayList<String> kq = new ArrayList<String>();
	        int num = -1;
	        try{ num = Integer.parseInt(a); } catch(Exception ex){}
	        if (num == 0) return kq;
	 
	 
	 
	 
	        int hang_tram = -1;
	        try{ hang_tram = Integer.parseInt(a.substring(0, 1)); } catch(Exception ex){}
	        int hang_chuc = -1;
	        try{ hang_chuc = Integer.parseInt(a.substring(1, 2)); } catch(Exception ex){}
	        int hang_dv = -1;
	        try{ hang_dv = Integer.parseInt(a.substring(2, 3)); } catch(Exception ex){}
	 
	 
	        //xét hàng trăm
	        if (hang_tram != -1){
	            kq.add(number[hang_tram]);
	            kq.add(TRAM);
	        }
	 
	 
	        //xét hàng chục
	        switch (hang_chuc)
	        {
	        case -1:
	            break;
	        case 1:
	            kq.add(MUOIF);
	            break;
	        case 0:
	            if (hang_dv != 0) kq.add(LE);
	            break;
	        default:
	            kq.add(number[hang_chuc]);
	            kq.add(MUOI);
	            break;
	        }
	 
	 
	        //xét hàng đơn vị
	        switch (hang_dv)
	        {
	        case -1:
	            break;
	        case 1:
	            if ((hang_chuc != 0) && (hang_chuc != 1) && (hang_chuc != -1))
	                kq.add(MOTS);
	            else kq.add(number[hang_dv]);
	            break;
	        case 5:
	            if ((hang_chuc != 0) && (hang_chuc != -1))
	                kq.add(LAM);
	            else kq.add(number[hang_dv]);
	            break;
	        case 0:
	            if (kq.isEmpty()) kq.add(number[hang_dv]);
	            break;
	        default:
	            kq.add(number[hang_dv]);
	            break;
	        }
	        return kq;
	    }
	    
	    public static ArrayList<String> Split(String str, int chunkSize)    {
	        int du = str.length() % chunkSize;
	        //Nếu độ dài chuổi không phải bội số của chunkSize thì thêm # vào trước cho đủ.
	        if (du != 0)
	            for (int i = 0; i < (chunkSize - du); i++) str = "#" + str;
	        return splitStringEvery(str, chunkSize);
	    }
	 
	 
	    //Hàm cắt chuổi ra thành chuổi nhỏ
	    public static ArrayList<String> splitStringEvery(String s, int interval) {
	        ArrayList<String> arrList = new ArrayList<String>();
	        int arrayLength = (int) Math.ceil(((s.length() / (double) interval)));
	        String[] result = new String[arrayLength];
	        int j = 0;
	        int lastIndex = result.length - 1;
	        for (int i = 0; i < lastIndex; i++) {
	            result[i] = s.substring(j, j + interval);
	            j += interval;
	        }
	        result[lastIndex] = s.substring(j);
	 
	        /*
	          Có thể dùng hàm sau để cắt nhưng hiệu suất sẽ thấp hơn cách trên
	         result = s.split("(?<=\\G.{" + interval + "})");
	         */
	 
	        arrList.addAll(Arrays.asList(result));
	        return arrList;
	    }
	    public static void main(String[] args) {
			System.out.print("Nhap: ");
			Scanner nhap=new Scanner(System.in);
			String a11=nhap.next();
				ArrayList<String> kq= readNum1(a11);
	            for (int i = 0; i < kq.size(); i++) {
	                System.out.print(kq.get(i)+ " ");
			
	            }

		}

	    
		
	}




