package controller;

import java.io.IOException;
import java.util.ArrayList;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import bean.kh_bean;
import bean.lichsu_bean;
import bo.lichsuMH_bo;

/**
 * Servlet implementation class lichsuMHController
 */
@WebServlet("/lichsuMHController")
public class lichsuMHController extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    public lichsuMHController() {
        super();
    }

	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		response.setCharacterEncoding("utf-8");
		request.setCharacterEncoding("utf-8");
		ArrayList<lichsu_bean> ds;
		lichsuMH_bo lbo=new lichsuMH_bo();
		HttpSession session = request.getSession();
		try {
			kh_bean kh=(kh_bean)session.getAttribute("dn");
			if(kh!=null) {
			long makh=kh.getMakh();
			ds=lbo.getLSMH(makh);
			String user=kh.getHoten();
			long tong=lbo.Tongtien();
			System.out.print(ds.size());
			request.setAttribute("tong", tong);
			request.setAttribute("lichsuMH", ds);
			RequestDispatcher rs=request.getRequestDispatcher("lichsuMH.jsp");
			rs.forward(request, response);}
			else {
				response.sendRedirect("dangnhap.jsp");
			}
		} catch (Exception e) {
			// TODO: handle exception
		}
	}

	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
