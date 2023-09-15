package controller;

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import bean.giohang_bean;
import bean.kh_bean;
import bo.chitiet_bo;
import bo.giohang_bo;
import bo.hoadon_bo;

/**
 * Servlet implementation class xacnhanGioController
 */
@WebServlet("/xacnhanGioController")
public class xacnhanGioController extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
 
    public xacnhanGioController() {
        super();
        // TODO Auto-generated constructor stub
    }

	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		HttpSession session= request.getSession();
		kh_bean kh= (kh_bean) session.getAttribute("dn");
		if(kh==null)
		{
			RequestDispatcher rd= request.getRequestDispatcher("dangnhap.jsp");
			rd.forward(request, response);
		}
		else {
			giohang_bo gh=(giohang_bo)session.getAttribute("giohang");
			if(gh!=null)
			{
				hoadon_bo hbo=new hoadon_bo();
				try {
					hbo.them(kh.getMakh());
					long mahd=hbo.getMaxHD();
					//Duyet gio de lýu vào cthoadon
					chitiet_bo ct=new chitiet_bo();
					for(giohang_bean g:gh.ds) {
						ct.them(g.getHang().getMadt(), g.getSl(), mahd);
					}
					session.removeAttribute("giohang");
					response.sendRedirect("hangController");
				} catch (Exception e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			}
		}
	}

	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
