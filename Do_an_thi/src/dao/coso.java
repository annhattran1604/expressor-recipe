package dao;

import java.sql.Connection;
import java.sql.DriverManager;

public class coso {
	public static Connection cn;
	public void KetNoi() {
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
			//System.out.println("Da xac dinh HQTCSDL");
			String st=
					"jdbc:sqlserver://DESKTOP-HPRJ4H7:1433;databaseName=qlbh; user=sa; password=123456";
			cn=DriverManager.getConnection(st);
			//System.out.print("Ngon");
		} catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}
	}
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		coso cs= new coso();
		cs.KetNoi();
	}
}
