<?php 
session_start();
?>
<!DOCTYPE html>
<html>
<head>
	<title></title>
<style type="text/css">
  img.card-img-top{
    height:170px ;
  }
</style>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<link rel="stylesheet" type="text/css" href="style.css">
	<link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>&gt;
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>&gt;
</head>
<body>
  <!-- menu -->
  <nav class="navbar navbar-expand-lg navbar-light bg-light">
    <div class="container">
     <a class="navbar-brand" href="#"></a>
     <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
       <span class="navbar-toggler-icon"></span>
     </button>

     <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav mr-auto">
        <li class="nav-item active">
          <a class="nav-link" href="#"> Login <span class="glyphicon glyphicon-home sr-only">(current)</span></a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#"> <span class="glyphicon glyphicon-user"></span>Home</a>
        </li>
        <li class="nav-item dropdown">
          <a class="nav-link" href="#" id="navbarDropdown">
            Steal Deal
          </a>
          <div class="dropdown-content">
            <a class="dropdown-item" href="#">Sale 20%</a>
            <a class="dropdown-item" href="#">Buy 1 get 1 free</a>
            <div class="dropdown-divider"></div>
            <a class="dropdown-item" href="#">Premium pack</a>
          </div>
        </li>
      </ul>

      <form class="form-inline my-2 my-lg-0" action="search.php" method="GET">
<input class="form-control mr-sm-2" type="search" placeholder="Search for song" style="width: 400px" name="Search">
<input type="submit"name="search" value="Search" />
</form>
    </div>
  </div>
</nav>
<!-- end menu -->
<!-- slide -->
<div id="carouselExampleIndicators" class="carousel slide mt-1" data-ride="carousel"> 
  <ol class="carousel-indicators">
    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
  </ol>
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img class="d-block w-100" src="https://i.ytimg.com/vi/szYx80LQMm4/maxresdefault.jpg" alt="First slide" >
    </div>
    <div class="carousel-item">
      <img class="d-block w-100" src="https://i.ytimg.com/vi/WeGGWBU8EeI/maxresdefault.jpg" alt="Second slide">
    </div>
    <div class="carousel-item">
      <img class="d-block w-100" src="https://s.yimg.com/hd/cp-video-transcode/prod/2021-04/28/608961c0901e25342b5ccc76/608961c0901e25342b5ccc77_o_U_v2.jpg" alt="Third slide">
    </div>
  </div>
  <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
<!-- end slide -->
<!-- list product -->
<div class="container">
	<div class="row mt-5">
		<h2 class="list-product-title">HOT MUSIC</h2>
		<div class="list-product-subtitle">
			<p>List product description</p>
		</div>
		<div class="product-group">
  <div class="row">            
    <?php
    $connect = mysqli_connect('localhost','root','','musicwebsite');

    if(!$connect){
      echo "Kết nối thất bại";
    }
    $sql = "SELECT * FROM song";            
    $result = mysqli_query($connect, $sql);
            // Trả về kết quả dạng 1 mảng
    while ($row_song = mysqli_fetch_array($result)){
      $song_id = $row_song['song_id'];
      $song_description = $row_song['song_description'];
      $song_name = $row_song['song_name'];
      $song_price = $row_song['song_price'];
      $song_audio = $row_song['song_audio'];
      $song_image = $row_song['song_img'];
      ?>
      <div class="col-md-3 col-sm-6 col-12" >
        <div class="card card-product mb-3">
          <img class="card-img-top" src="img/<?php echo $song_image;?>" >
          <div class="card-body" style="width: 500px;">
            <h5 class="card-title"><?php echo"$song_name"?></h5>
            <h5 class="card-title"><?php echo"$song_description"?></h5>
            <audio controls controlsList="nodownload" ontimeupdate="myAudio(this)" style="width: 250px;">
             <source src="Audio/<?php echo $song_audio?>" type="audio/mp3">
             </audio>
             <script type="text/javascript">
               function myAudio(event){
                 if(event.currentTime>10){
                   event.currentTime=0;
                   event.pause();
                   alert("Bạn phải trả phí để nghe cả bài")
                 }
               }
             </script>
             <br>
             <?php
             echo"
             <a href='detail.php?id=$song_id' class='btn btn-primary'>Details</a>"
             ?>
           </div>
         </div>
       </div>
       <?php
     }
     ?>

   </div>
 </div>

 <!-- end list product -->

 <!-- Load jquery trước khi load bootstrap js -->
 <script src="jquery-3.3.1.min.js"></script>
 <script src="bootstrap/js/bootstrap.min.js"></script>
  </div>
</div>
</div>


</body>

</html>