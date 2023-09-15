<%@page import="bean.hang_bean"%>
<%@page import="bean.hangdt_bean"%>
<%@page import="java.util.ArrayList"%>
<%@ page language="java" contentType="text/html; charset=utf-8"
    pageEncoding="utf-8"%>
   <%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<!DOCTYPE html>
<html>
<head>
        <title>Quản lý điện thoại</title>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet">
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" rel="stylesheet">
        <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/all.min.css" rel="stylesheet">
        <link href="https://cdn.jsdelivr.net/npm/boxicons@latest/css/boxicons.min.css" rel="stylesheet">
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js"></script>
      </head>
      <style>
      @import url("https://fonts.googleapis.com/css2?family=Nunito:wght@400;600;700&display=swap");:root{--header-height: 3rem;--nav-width: 68px;--first-color: #4723D9;--first-color-light: #AFA5D9;--white-color: #F7F6FB;--body-font: 'Nunito', sans-serif;--normal-font-size: 1rem;--z-fixed: 100}*,::before,::after{box-sizing: border-box}body{position: relative;margin: var(--header-height) 0 0 0;padding: 0 1rem;font-family: var(--body-font);font-size: var(--normal-font-size);transition: .5s}a{text-decoration: none}.header{width: 100%;height: var(--header-height);position: fixed;top: 0;left: 0;display: flex;align-items: center;justify-content: space-between;padding: 0 1rem;background-color: var(--white-color);z-index: var(--z-fixed);transition: .5s}.header_toggle{color: var(--first-color);font-size: 1.5rem;cursor: pointer}.header_img{width: 35px;height: 35px;display: flex;justify-content: center;border-radius: 50%;overflow: hidden}.header_img img{width: 40px}.l-navbar{position: fixed;top: 0;left: -30%;width: var(--nav-width);height: 100vh;background-color: var(--first-color);padding: .5rem 1rem 0 0;transition: .5s;z-index: var(--z-fixed)}.nav{height: 100%;display: flex;flex-direction: column;justify-content: space-between;overflow: hidden}.nav_logo, .nav_link{display: grid;grid-template-columns: max-content max-content;align-items: center;column-gap: 1rem;padding: .5rem 0 .5rem 1.5rem}.nav_logo{margin-bottom: 2rem}.nav_logo-icon{font-size: 1.25rem;color: var(--white-color)}.nav_logo-name{color: var(--white-color);font-weight: 700}.nav_link{position: relative;color: var(--first-color-light);margin-bottom: 1.5rem;transition: .3s}.nav_link:hover{color: var(--white-color)}.nav_icon{font-size: 1.25rem}.show{left: 0}.body-pd{padding-left: calc(var(--nav-width) + 1rem)}.active{color: var(--white-color)}.active::before{content: '';position: absolute;left: 0;width: 2px;height: 32px;background-color: var(--white-color)}.height-100{height:100vh}@media screen and (min-width: 768px){body{margin: calc(var(--header-height) + 1rem) 0 0 0;padding-left: calc(var(--nav-width) + 2rem)}.header{height: calc(var(--header-height) + 1rem);padding: 0 2rem 0 calc(var(--nav-width) + 2rem)}.header_img{width: 40px;height: 40px}.header_img img{width: 45px}.l-navbar{left: 0;padding: 1rem 1rem 0 0}.show{width: calc(var(--nav-width) + 156px)}.body-pd{padding-left: calc(var(--nav-width) + 188px)}}
      </style>
<body id="body-pd">
          <header class="header" id="header">
              <div class="header_toggle"> <i class='bx bx-menu' id="header-toggle"></i> </div>
          </header>
          <div class="l-navbar" id="nav-bar">
              <nav class="nav">
				<div>
				<a href="#" class="nav_logo"> <i
					class='bx bx-layer nav_logo-icon'></i> <span class="nav_logo-name">An Store</span>
				</a>
				<div class="nav_list">
					<a href="AdminXacNhanController" class="nav_link"> <i
						class="fa-regular fa-square-check"></i> <span class="nav_name">Xác
							nhận thanh toán</span>
					</a> <a href="AdminQLLoaiController" class="nav_link"> <i
						class="fa-brands fa-typo3"></i> <span class="nav_name">Quản
							lý loại</span>
					</a> <a href="AdminQLDTController" class="nav_link active"> <i
						class="fa-brands fa-phoenix-squadron"></i> <span class="nav_name">Quản
							lý điện thoại</span>
					</a> <a href="AdminKHTTController" class="nav_link"> <i class="fa-brands fa-typo3"></i>
						<span class="nav_name">Khách hàng đã thanh toán</span>
					</a> 

				</div>
				<a href="dangxuatController?dx=1" class="nav_link"><i class='bx bx-log-out nav_icon'></i>
					<span class="nav_name">SignOut</span> </a>
			</nav>
          </div>
          <!--Container Main start-->
          <div class="height-100 bg-light">
              <h4>Quản lý điện thoại</h4>
            <div  >
              <a style="color: green;font-weight:800; font-size: 20px;" onclick="Show()" id="mytext" href="#">
                <p style="border: .5px solid green;width: 300px;padding: 5px;">
                  <i class="fa-regular fa-square-plus"></i> Thêm sản phẩm mới
                </p>
              </a>
            </div>
            <c:set var="mdt" value="${requestScope.mdt!=null ? requestScope.mdt : ''}" />
			<c:set var="tdt" value="${requestScope.tdt!=null ? requestScope.tdt : ''}" />
			<c:set var="ml" value="${requestScope.mlc!=null ? requestScope.mlc : ''}" />
			<c:set var="gia" value="${requestScope.giac!=null ? requestScope.giac : ''}" />
			<c:set var="sl" value="${requestScope.slc!=null ? requestScope.slc : ''}" />
			<c:set var="size" value="${requestScope.sizec!=null ? requestScope.sizec : ''}" />
            	<form style="margin-bottom: 10px;" id="login-form" action="AdminQLDTController" method="post" enctype="multipart/form-data">
                    <div style="margin-bottom: 10px; font-size: 17px;">
                        <input name="madt" type="text" placeholder="Nhập mã điện thoại" value="${mdt.trim()}">
                        <input name="tendt" type="text" placeholder="Nhập tên điện thoại" value="${tdt}">
                    </div>
                    <div style="margin-bottom: 10px; font-size: 17px;">
                      <input type="number" min="1" name="soluong" placeholder="Nhập số lượng" value="${sl}">
                      <input type="number" min="1" name="gia" placeholder="Nhập giá" value="${gia.trim()}">
                    </div>
                    <div style="margin-bottom: 10px; font-size: 17px;">
                      <select style="width: 150px;" name="maloai">
    					<c:forEach var="h" items="${dsl}">
        					<c:choose>
            					<c:when test="${h.getMahang() == ml}">
                					<option selected="selected" value="${h.getMahang()}">${h.getTenhang()}</option>
            					</c:when>
            					<c:otherwise>
                					<option value="${h.getMahang()}">${h.getTenhang()}</option>
            					</c:otherwise>
        					</c:choose>
    					</c:forEach>
						</select>
                      <input name="size" style="width: 260px;" type="text" placeholder="Nhập kích thước màn hình" value="${size}">
                    </div>
                    <div style="margin-bottom: 10px; font-size: 17px;">
                      <input type="file" name="hinhanh">
                    </div>
                		<input type="submit" name="butadd" class="btn btn-success" value="Add">
                		<input type="submit" name="butupdate" class="btn btn-warning" value="Update">
              </form>
              <table class="table table-striped">
                <thead>
                  <tr>
                    <th scope="col">Mã ĐT</th>
                    <th scope="col">Ảnh</th>
                    <th scope="col">Tên ĐT</th>
                    <th scope="col">Số lượng</th>
                    <th scope="col">Giá</th>
                    <th scope="col">Mã hàng</th>
                    <th scope="col">Năm SX</th>
                    <th scope="col">Màn hình</th>
                  </tr>
                </thead>
                
                <tbody>
    				<c:forEach var="h" items="${ds}">
        				<tr>
            				<td>${h.getMadt()}</td>
            				<td><img style="width: 80px" src="${h.getAnh()}" alt="Product Image"></td>
            				<td>${h.getTendt()}</td>
            				<td>${h.getSoluong()}</td>
            				<td>${h.getGia()}</td>
            				<td>${h.getMahang()}</td>
            				<td>${h.getNamsx()}</td>
            				<td>${h.getSize()}</td>
            				<td>
                				<a href="AdminQLDTController?tab=chon&mdt=${h.getMadt()}
                					&tdt=${h.getTendt()}&ml=${h.getMahang()}&gia=${h.getGia()}
                					&sl=${h.getSoluong()}&size=${h.getSize()}" class="btn btn-success">
                    				<i class="fa-solid fa-check"></i>
                				</a>
            				</td>
            				<td>
                				<a href="AdminQLDTController?tab=xoa&mdt=${h.getMadt()}" class="btn btn-danger">
                    			<i class="fa-solid fa-trash"></i>
                				</a>
            				</td>
        				</tr>
    				</c:forEach>
				</tbody>
              </table>
          </div>
      <script>
        function Show(){
            if(document.getElementById("login-form").style.display === "none")
            { 
                document.getElementById("login-form").style.display = "block";
                document.getElementById("login-form2").style.display = "none";
                // document.getElementById("mytext").innerHTML = "Đăng nhập"; 
                // innerHTML đổi giá trị của id 
            }
            else
            {
                document.getElementById("login-form").style.display = "none";
            }
        }
      document.addEventListener("DOMContentLoaded", function(event) {
         
      const showNavbar = (toggleId, navId, bodyId, headerId) =>{
      const toggle = document.getElementById(toggleId),
      nav = document.getElementById(navId),
      bodypd = document.getElementById(bodyId),
      headerpd = document.getElementById(headerId)
      
      // Validate that all variables exist
      if(toggle && nav && bodypd && headerpd){
      toggle.addEventListener('click', ()=>{
      // show navbar
      nav.classList.toggle('show')
      // change icon
      toggle.classList.toggle('bx-x')
      // add padding to body
      bodypd.classList.toggle('body-pd')
      // add padding to header
      headerpd.classList.toggle('body-pd')
      })
      }
      }
      
      showNavbar('header-toggle','nav-bar','body-pd','header')
      
      /*===== LINK ACTIVE =====*/
      const linkColor = document.querySelectorAll('.nav_link')
      
      function colorLink(){
      if(linkColor){
      linkColor.forEach(l=> l.classList.remove('active'))
      this.classList.add('active')
      }
      }
      linkColor.forEach(l=> l.addEventListener('click', colorLink))
      
       // Your code to run since DOM is loaded and ready
      });
      </script>
      </body>
</html>