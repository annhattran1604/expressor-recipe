package controller;

import java.io.IOException;
import java.util.ArrayList;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import bean.kh_bean;
import bean.xacnhantt_bean;
import bo.KH_bo;
import bo.xacnhantt_bo;

/**
 * Servlet implementation class AdminXacNhanController
 */
@WebServlet("/AdminXacNhanController")
public class AdminXacNhanController extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
   
    public AdminXacNhanController() {
        super();
        // TODO Auto-generated constructor stub
    }

	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		try {
			String maCTHD=request.getParameter("macthd");
			xacnhantt_bo xbo=new xacnhantt_bo();
			KH_bo kbo=new KH_bo();
			if(maCTHD!=null)
			{
				xbo.CapNhat(Long.parseLong(maCTHD));
			}
			ArrayList<xacnhantt_bean>hd=xbo.getHDXN();

			request.setAttribute("dshoadon", xbo.getHDXN());
			RequestDispatcher rd=request.getRequestDispatcher("AdminXacNhan.jsp");
			rd.forward(request, response);
		} catch (Exception e) {
			// TODO: handle exception
		}
	}

	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
