package controller;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import bean.giohang_bean;
import bean.hang_bean;
import bo.giohang_bo;

/**
 * Servlet implementation class giohangController
 */
@WebServlet("/giohangController")
public class giohangController extends HttpServlet {
	private static final long serialVersionUID = 1L;
       

    public giohangController() {
        super();
    }


	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String madt=request.getParameter("mdt");
		String tendt=request.getParameter("tendt");
		String anh=request.getParameter("anh");
		String gia=request.getParameter("gia");
		String size=request.getParameter("size");
		if(tendt!=null && anh!=null && gia!=null && size!=null)
		{
			giohang_bo gio = new giohang_bo();
			HttpSession session = request.getSession();
			if(session.getAttribute("giohang") == null)
			{
				//Tạo session chứa ds hàng trong giỏ
				session.setAttribute("giohang", gio);
			}
			gio=(giohang_bo)session.getAttribute("giohang");
			session.setAttribute("giohang1", gio.ds);
			hang_bean dienthoai=new hang_bean(madt, tendt, 0, anh, Long.parseLong(gia),"", null, 0, size);
			//Thêm vào với sl ban đầu là 1
			long soluong=1;
			gio.ThemHang(soluong, soluong * dienthoai.getGia(), dienthoai);
			session.setAttribute("giohang", gio);
		}
		response.sendRedirect("htgiohangController"); 
	}

	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
