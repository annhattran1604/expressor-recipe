package controller;

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import bo.KH_bo;

/**
 * Servlet implementation class dangkyController
 */
@WebServlet("/dangkyController")
public class dangkyController extends HttpServlet {
	private static final long serialVersionUID = 1L;
    public dangkyController() {
        super();
    }
	protected void doGet(HttpServletRequest request, HttpServletResponse response) 
		throws ServletException, IOException {
		response.setCharacterEncoding("utf-8");
		request.setCharacterEncoding("utf-8");
		String hoten=request.getParameter("hoten");
		String dc=request.getParameter("dc");
		String sdt=request.getParameter("sdt");
		String us=request.getParameter("us");
		String pass=request.getParameter("pass");
		String repass=request.getParameter("repass");
		String check=request.getParameter("check");
		KH_bo khbo=new KH_bo();
		String kq = null;
		if(check!=null)
		{
			if (hoten != "" && dc != "" && sdt != "" && us != "" && pass != "" && repass != "") {
				if (!pass.equals(repass)) {
					kq="1";
					response.sendRedirect("dangky.jsp?kq="+kq);
				} else {
					try {
						if (khbo.ktdk(us) == null) {
							try {
								khbo.ThemKH(hoten, kq, sdt, us, pass);
							} catch (Exception e) {
								// TODO Auto-generated catch block
								e.printStackTrace();
							}
							response.sendRedirect("hangController");
						} else {
							kq="2";
							response.sendRedirect("dangky.jsp?kq="+kq);
						}
					} catch (Exception e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}

				}
			} else {
				kq="3";
				response.sendRedirect("dangky.jsp?kq=" +kq);
			}
		}
		else {
			kq="4";
			response.sendRedirect("dangky.jsp?kq="+kq);
		}
	}

	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
