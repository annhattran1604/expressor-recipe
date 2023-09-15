<%@ page language="java" contentType="text/html; charset=utf-8"
    pageEncoding="utf-8"%>
   <%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Đăng nhập</title>
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css">
  <link rel="stylesheet"
	href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">
  <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.4/dist/jquery.slim.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>
  <link rel="icon" type="png" href="img-phone/iconlogo.png">
</head>
<style>
body{
    background-image: linear-gradient(to right top, #ffffff, #d7d4ea, #afabd4, #8783bf,
		#5c5eaa, #7250a4, #873d97, #9a2284, #d02a69, #eb5647, #ec8a26, #d6bd1f
		);
}
form{
    box-shadow: 0px 0px 24px 3px rgba(0,0,0,0.1);
    padding: 20px;
}
.divider:after,
.divider:before {
content: "";
flex: 1;
height: 1px;
background: #eee;
}
.h-custom {
height: calc(100% - 73px);
}
@media (max-width: 450px) {
.h-custom {
height: 100%;
}
}
</style>
<body>
<section class="vh-100">
  <div class="container-fluid h-custom">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-md-9 col-lg-6 col-xl-5">
        <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-login-form/draw2.webp"
          class="img-fluid" alt="Sample image">
      </div>
      <div class="col-md-8 col-lg-6 col-xl-4 offset-xl-1">
        <form action="dangnhapController" method="post">
          <div class="divider d-flex align-items-center my-4">
            <h2 class="text-center fw-bold mx-3 mb-0">Đăng nhập</h2>
          </div>

          <!-- Email input -->
          <div class="form-outline mb-4">
            <label class="form-label" for="form3Example3">Tên đăng nhâp</label>
            <input type="text" name="txtus" class="form-control form-control-lg"
              placeholder="Enter UserName" />

          </div>

          <!-- Password input -->
          <div class="form-outline mb-3">
            <label class="form-label" for="form3Example4">Password</label>
            <input type="password" name="txtpass"  class="input__field form-control form-control-lg"
              placeholder="Enter Password" />

          </div>
          <c:if test="${not empty requestScope.err}">
    			<h5>${requestScope.err}</h5>
		  </c:if>
          <div class="d-flex justify-content-between align-items-center">
            <!-- Checkbox -->
            <div  class="form-check mb-0">
             <h6 class="input__eye" style="cursor: pointer;margin: 5px;"><i class="fa-solid fa-eye"></i> Show Password </h6>
            </div>
          </div>
		  <div class="text-center text-lg-start mt-4 pt-2">
            <c:set var="loginAttempts" value="${sessionScope.loginAttempts}" />

			<c:choose>
    			<c:when test="${loginAttempts != null && loginAttempts >= 3}">
        			<img src="simpleCaptcha.jpg" /> <!-- Hiển thị Captcha -->
        			<input type="text" name="answer" /><br> <!-- Input để người dùng nhập Captcha -->
    			</c:when>
    			<c:otherwise>
        			<input type="hidden" name="answer" value="skip" /> <!-- Giá trị ẩn nếu không cần Captcha -->
    			</c:otherwise>
			</c:choose>
          </div>
          <div class="text-center text-lg-start mt-4 pt-2">
            <input type="submit" style="padding-left: 2.5rem; padding-right: 2.5rem;" name="submit" class="btn btn-info btn-md" value="Đăng nhập">
          </div>
			<div style="color: black;text-decoration: none;" class="text-center text-lg-start mt-4 pt-2">
             <a href="hangController"class="link-danger">Quay trở lại cửa hàng</a></p>
          </div>
        </form>
      </div>
    </div>
  </div>
</section>
<script type="text/javascript">
		const input = document.querySelector(".input__field");
		const inputIcon = document.querySelector(".input__eye");
		inputIcon.addEventListener("click",(e) =>{
			e.preventDefault();
			input.setAttribute(
				'type',
				input.getAttribute('type') ==='password' ? 'text':'password');
		});
		
	</script>
</body>
</html>