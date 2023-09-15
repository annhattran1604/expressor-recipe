package controller;

import java.io.IOException;
import java.io.PrintWriter;
import java.text.NumberFormat;
import java.util.ArrayList;
import java.util.Locale;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import bean.hang_bean;
import bo.hang_bo;

/**
 * Servlet implementation class searchbyAjax
 */
@WebServlet("/searchbyAjax")
public class searchbyAjax extends HttpServlet {
	private static final long serialVersionUID = 1L;

	public searchbyAjax() {
		super();

	}

	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		response.setCharacterEncoding("utf-8");
		request.setCharacterEncoding("utf-8");
		ArrayList<hang_bean> ds;
		hang_bo hbo = new hang_bo();
		try {
			ds = hbo.getHach();
			String madt = request.getParameter("madt");
			String tendt = request.getParameter("key");
			//tim kiem 
			if (madt != null && tendt == null) {
				ds = hbo.TimMa(madt);
			}
			if (madt == null && tendt != null) {
				ds = hbo.TimDT(tendt);
			}
			PrintWriter out = response.getWriter();
			String size;
			int n=ds.size();
			if(n==0)
			{
				out.print("<h1 style=\"display: flex;margin: auto;\">Không tìm thấy mặt hàng</h1>");
			}
			for (hang_bean hang : ds) {
				if(hang.getSize()==null){
  					size ="\n";}
  				else{
  					size=hang.getSize();
  				}
				long gia = hang.getGia();
	  			 NumberFormat format = NumberFormat.getNumberInstance(new Locale("vi", "VN"));
	  			 String formattedGia = format.format(gia);
	  			 out.println("<div class=\"body--items\">\r\n"
	  			 		+ "					<img src=\""+hang.getAnh() +"\" alt=\"\"> <a href=\"\">"+hang.getTendt() +"</a>\r\n"
	  			 		+ "					<p>"+size +"</p>\r\n"
	  			 		+ "					<p class=\"cost\">\r\n"
	  			 		+ "						<i class=\"fa-solid fa-circle-dollar-to-slot\"></i>\r\n"
	  			 		+ "						"+formattedGia +"₫\r\n"
	  			 		+ "					</p>\r\n"
	  			 		+ "					<a style=\"width: 50%;\" href=\"giohangController?mdt="+hang.getMadt()+"&tendt="+hang.getTendt()+"&anh="+hang.getAnh()+"&gia="+hang.getGia()+"&size="+hang.getSize()+"\">\r\n"
	  			 		+ "						Thêm vào giỏ </a>\r\n"
	  			 		+ "				</div>");
			}
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
