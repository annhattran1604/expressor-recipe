package controller;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import javax.websocket.Session;

import bean.giohang_bean;
import bean.hang_bean;
import bo.giohang_bo;

/**
 * Servlet implementation class xoaController
 */
@WebServlet("/xoaController")
public class xoaController extends HttpServlet {
	private static final long serialVersionUID = 1L;
       

    public xoaController() {
        super();
        // TODO Auto-generated constructor stub
    }

	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String ms=request.getParameter("ms");
		HttpSession session=request.getSession();
		giohang_bo gio=(giohang_bo)session.getAttribute("giohang");
		if(ms!=null)
		{
			if(gio!=null)
			{
				gio.Xoa(ms);
			}
			else {
			    gio =new giohang_bo();
			  }
			session.setAttribute("giohang", gio);
			response.sendRedirect("giohangController");
		}
		String xoaAll=request.getParameter("xoaAll");
		if(ms ==null && xoaAll!=null)
		{
			if (gio != null) {
			      gio.ds.clear(); // Xóa tất cả các mặt hàng trong danh sách
			   }
			session.setAttribute("giohang", gio);
			response.sendRedirect("giohangController");
		}
		String xoaCB=request.getParameter("xoacb");
		if(ms==null && xoaAll==null && xoaCB !=null)
		{
			giohang_bo s=(giohang_bo)session.getAttribute("giohang");
			String[] selected=request.getParameterValues("checkb");
			if(selected!=null)
			{	
				int n = selected.length;
				for(int i=0;i<n;i++)
				{
					s.Xoa(selected[i]);
				}
				session.setAttribute("giohang", s);
				response.sendRedirect("giohangController");
			}
		}
	}

	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
