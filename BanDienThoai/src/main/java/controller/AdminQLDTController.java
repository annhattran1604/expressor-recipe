package controller;

import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.commons.fileupload.FileItem;
import org.apache.commons.fileupload.FileUploadException;
import org.apache.commons.fileupload.disk.DiskFileItemFactory;
import org.apache.commons.fileupload.servlet.ServletFileUpload;

import bean.hang_bean;
import bo.hang_bo;

/**
 * Servlet implementation class AdminQLDTController
 */
@WebServlet("/AdminQLDTController")
public class AdminQLDTController extends HttpServlet {
	private static final long serialVersionUID = 1L;
    
    public AdminQLDTController() {
        super();
        // TODO Auto-generated constructor stub
    }

	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		DiskFileItemFactory factory = new DiskFileItemFactory();
		DiskFileItemFactory fileItemFactory = new DiskFileItemFactory();
		ServletFileUpload upload = new ServletFileUpload(fileItemFactory);
		Map<String, String> fieldMap = new HashMap<>();
		String anh=null;
		try {
			List<FileItem> fileItems = upload.parseRequest(request);
			for (FileItem fileItem : fileItems) {
				if (fileItem.isFormField()) {
				    String fieldName = fileItem.getFieldName();
				    String fieldValue = fileItem.getString("UTF-8"); // Lấy giá trị của trường
				    fieldMap.put(fieldName, fieldValue);
				}
				if (!fileItem.isFormField()) {
					String nameimg = fileItem.getName();
					anh="img-phone/"+nameimg;
					if (!nameimg.equals("")) {
						
						String dirUrl = "E:\\Java\\BanDienThoai\\src\\main\\webapp\\img-phone" + File.separator;
						File dir = new File(dirUrl);
						if (!dir.exists()) {
							dir.mkdir();
						} 
						String fileImg = dirUrl + nameimg;
						//System.out.println(fileImg);
						File file = new File(fileImg);
						try {
							fileItem.write(file);
						} catch (Exception e) {
							e.printStackTrace();
						}
					}
				}
			}

		} catch (FileUploadException e) {
			e.printStackTrace();
		}
		try {
			response.setCharacterEncoding("utf-8");
			request.setCharacterEncoding("utf-8");
			ArrayList<hang_bean> ds = new ArrayList<hang_bean>();
			String tab=request.getParameter("tab");
			String madt = fieldMap.get("madt");
			String tendt = fieldMap.get("tendt");
			String soluong = fieldMap.get("soluong");
			String gia = fieldMap.get("gia");
			String maloai = fieldMap.get("maloai");
			String size = fieldMap.get("size");
			String addButtonValue = fieldMap.get("butadd");
			String updateButtonValue = fieldMap.get("butupdate");
			hang_bo hbo=new hang_bo();
			if(addButtonValue!=null)
			{	
				hbo.ThemDT(madt, tendt, Long.parseLong(soluong), anh, Long.parseLong(gia), maloai, size);
			}
			else {
				if(updateButtonValue!=null) {
					hbo.SuaDT(madt, tendt, Long.parseLong(soluong), anh, Long.parseLong(gia), maloai, size);
				}else {
					
					if(tab!=null && tab.equals("xoa"))
					{
						String mdt=request.getParameter("mdt");
						hbo.XoaDT(mdt);
					}
					else
						if(tab!=null && tab.equals("chon"))
						{
							String mdt=request.getParameter("mdt");
							String tdt=request.getParameter("tdt");
							String ml=request.getParameter("ml");
							String giac=request.getParameter("gia");
							String sl=request.getParameter("sl");
							String sizec=request.getParameter("size");
							request.setAttribute("mdt", mdt);
							request.setAttribute("tdt", tdt);
							request.setAttribute("mlc", ml);
							request.setAttribute("giac", giac);
							request.setAttribute("slc", sl);
							request.setAttribute("sizec", sizec);
						}
				}
			}
			request.setAttribute("dsl", hbo.getHangDT());
			request.setAttribute("ds", hbo.getHach());
			RequestDispatcher rd= request.getRequestDispatcher("AdminQLDT.jsp");
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
