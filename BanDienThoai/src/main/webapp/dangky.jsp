<%@ page language="java" contentType="text/html; charset=utf-8"
	pageEncoding="utf-8"%>
<!DOCTYPE html>
<html>
<head>
<link rel="stylesheet"
	href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">
<title>Đăng Ký</title>
<link rel="icon" type="png" href="img-phone/iconlogo.png">
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<style>
* {
	padding: 0;
	margin: 0;
	box-sizing: border-box;
}

html {
	font-family: Arial, Helvetica, sans-serif;
	scroll-behavior: smooth;
}

body {
	background: rgb(241, 188, 49);
	background-image: linear-gradient(to right top, #ffffff, #d7d4ea, #afabd4, #8783bf,
		#5c5eaa, #7250a4, #873d97, #9a2284, #d02a69, #eb5647, #ec8a26, #d6bd1f
		);
	display: flex;
	justify-content: space-around;
	align-items: center;
}

p {
	margin-bottom: 0 !important;
}

.pd-10-20 {
	padding: 20px 20px;
}

.regis-container {
	margin-bottom: 10em;
	background-color: #fff;
	margin-top: 120px;
	width: 50%;
	border-radius: 10px;
}
/*Header*/
.regis-header {
	background-color: #202040;
	display: flex;
	justify-content: space-between;
	box-sizing: border-box;
	align-items: center;
	position: relative;
	border-top-left-radius: 10px;
	border-top-right-radius: 10px;
}

.regis-header .title {
	color: #fff;
	line-height: 100%;
	font-size: 20px;
}

.regis-header a {
	position: absolute;
	top: 0;
	bottom: 0;
	right: 0;
	width: 10%;
	font-size: 20px;
	color: #fff;
	display: flex;
	justify-content: center;
	align-items: center;
	transition: 0.2s ease-in;
	border-top-right-radius: 10px;
	text-decoration: none;
}

.regis-header a:hover {
	background-color: #CECE5A;
}

.regis-header a:hover i {
	color: #fff;
}
/*Header*
/*Body*/
.regis-body {
	background-color: rgba(255, 255, 255, 0.2);
	background-image: linear-gradient(to right top, #ffffff, #d7d4ea, #afabd4, #8783bf,
		#5c5eaa, #7250a4, #873d97, #9a2284, #d02a69, #eb5647, #ec8a26, #d6bd1f
		);
	border-bottom-left-radius: 10px;
	border-bottom-right-radius: 10px;
}

.regis-body form {
	display: flex;
	flex-wrap: wrap;
}
.form {
		display: flex;
		flex-wrap: nowrap;
	}
.form-right {
	width: 45%;
}

.form-left {
	width: 45%;
}

input {
	width: 90%;
	height: 30px;
	border: none;
	padding-left: 10px;
	box-shadow: inset rgba(99, 99, 99, 0.2) 2px 2px 2px 2px;
}

input:focus {
	outline: none;
}

.input {
	margin: 12px 0;
}

.block {
	display: block;
	line-height: 30px;
}

.block p {
	color: #000;
	font-size: 16px;
	font-weight: 600;
}

input[type="submit"] {
	width: 95%;
	height: 40px;
	border: none;
	transition: 0.1s;
	margin-top: 10px;
	box-shadow: none;
	font-size: 20px;
	font-weight: 700;
}

input[type="submit"]:hover {
	background-color: #202040;
	color: #fff;
}
/*Vadilate*/
.vadilate {
	display: flex;
	width: 100%;
}

input[type="checkbox"] {
	box-shadow: none;
	height: 20px;
	width: initial;
	margin-right: 10px;
}

img {
	margin-top: -50px;
	width: 30%;
	filter: brightness(0) invert(1);
	height: auto;
}

@media ( max-width : 1124px) {
	img {
		display: none;
	}
	.regis-container {
		width: 80%;
	}
}

@media ( max-width : 739px) {
	.form-right {
		width: 100%;
	}
	.form-left {
		width: 100%;
	}
	.regis-container {
		width: 90%;
	}
	.form {
		display: flex;
		flex-wrap: wrap;
	}
}
/*Vadilate*/
/*Body*/
</style>
</head>
<body>

	<img alt="" src="img-phone/nen.png">
	<div class="regis-container">
		<div class="regis-header pd-10-20">
			<p class="title">Đăng ký</p>
			<a href="hangController"> <i class="fa-solid fa-delete-left"></i>
			</a>
		</div>
		<div class="regis-body pd-10-20">
			<form class="form" action="dangkyController">
				<div class="form-right">
					<div class="un input">
						<div class="block">
							<p>User Name</p>
							<input type="text" name="us" placeholder="Nhập Username">
						</div>
					</div>
					<div class="pass input">
						<div class="block">
							<p>Mật khẩu</p>
							<input type="password" class="input__field" name="pass" placeholder="Nhập mật khẩu">
						</div>
					</div>
					<div class="repass input">
						<div class="block">
							<p>Nhập lại mật khẩu</p>
							<input type="password" class="input__field2" name="repass" placeholder="Nhập lại mật khẩu">
						</div>
					</div>
				</div>
				<div class="form-left">
					<div class="name input">
						<div class="block">
							<p>Họ và tên</p>
							<input type="text" name="hoten" placeholder="Nhập họ và tên">
						</div>
					</div>
					<div class="adress input">
						<div class="block">
							<p>Địa chỉ</p>
							<input type="text" name="dc" placeholder="Nhập địa chỉ">
						</div>
					</div>
					<div class="phone input">
						<div class="block">
							<p>Số điện thoại</p>
							<input type="text" name="sdt" placeholder="Nhập sdt">
						</div>
					</div>
				</div>
				<h5 class="input__eye" style="cursor: pointer;margin: 5px;"><i class="fa-solid fa-eye"></i> Show Password </h5>
				<div class="vadilate">
					<input type="checkbox" name="check">
					<p>
						Tôi đồng ý với <a href="">điều lệ</a> và quy định
					</p>
				</div>
				<c:choose>
    				<c:when test="${param.kq == '1'}">
        				<p style="color: #1600D2; font-weight: 600"><i class="fa-solid fa-triangle-exclamation"></i> Mật khẩu không trùng khớp !</p>
    				</c:when>
    				<c:when test="${param.kq == '2'}">
        				<p style="color: #1600D2; font-weight: 600"><i class="fa-solid fa-triangle-exclamation"></i> User đã tồn tại !</p>
    				</c:when>
    				<c:when test="${param.kq == '3'}">
        				<p style="color: #1600D2; font-weight: 600"><i class="fa-solid fa-triangle-exclamation"></i> Điền đầy đủ thông tin !</p>
    				</c:when>
    				<c:when test="${param.kq == '4'}">
        				<p style="color: #1600D2; font-weight: 600"><i class="fa-solid fa-triangle-exclamation"></i> Đồng ý điều lệ !</p>
    				</c:when>
				</c:choose>
				<input type="submit" class="submit" value="Đăng ký">
			</form>
		</div>
	</div>
	<script type="text/javascript">
		const input = document.querySelector(".input__field");
		const input2 = document.querySelector(".input__field2");
		const inputIcon = document.querySelector(".input__eye");
		inputIcon.addEventListener("click",(e) =>{
			e.preventDefault();
			input.setAttribute(
				'type',
				input.getAttribute('type') ==='password' ? 'text':'password');
			input2.setAttribute(
					'type',
					input2.getAttribute('type') ==='password' ? 'text':'password');
		});
		
	</script>
</body>
</html>