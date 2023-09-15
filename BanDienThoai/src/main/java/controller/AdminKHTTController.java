package controller;

import java.io.IOException;
import java.util.ArrayList;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import bean.lichsu_bean;
import bo.lichsuMH_bo;

/**
 * Servlet implementation class AdminKHTTController
 */
@WebServlet("/AdminKHTTController")
public class AdminKHTTController extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    public AdminKHTTController() {
        super();
        // TODO Auto-generated constructor stub
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		response.setCharacterEncoding("utf-8");
		request.setCharacterEncoding("utf-8");
		ArrayList<lichsu_bean> ds=new ArrayList<lichsu_bean>();
		lichsuMH_bo lbo=new lichsuMH_bo();
		try {
			ds=lbo.getKHTT();
			request.setAttribute("dathanhtoan", ds);
			RequestDispatcher rd=request.getRequestDispatcher("AdminKHTT.jsp");
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
