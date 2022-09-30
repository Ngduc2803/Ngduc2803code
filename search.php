<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title></title>
</head>
<body>
	<?php
	$conn =	mysqli_connect('localhost','root','','musicwebsite');
	?>
	<?php
	include('music.php');
	
	$search ="";
	if(  !empty($_GET['Search'])){
		$search = $_GET['Search'];
	}
	?>
	<h3 class="title">Search Results for: <?= $search ?></h3>
	<div class="container" style="margin-top: 20px">
		<div class="row">
			<?php
			if (!empty($search)) {
				$rs = mysqli_query( $conn, "SELECT * FROM song,singer,genre WHERE song.song_name LIKE '%{$search}%' and song.singer_id=singer.singer_id and song.genre_id=genre.genre_id");

				while($row= mysqli_fetch_assoc($rs)){
					?>
					<div class="card" style="background-coLor: whïte;margin-top: 20px; margin-Leƒt: 35px; overfLow: auto;width: 270px; height: 380px; border: 2px solid #F8ABAB; border-radius: 1px;border-bottom: 6px solid #FCA5A5; float: left; " >
						<a href="detail.php?id=<?php echo $row['song_id']?>" style=" text-decoration: none; text-aLign:_center;">
							<div style="height: 80px;">
								<h2><?php echo $row['song_name']?></h2>

								<div><img src="img/<?php echo $row['song_img']?>" style="width: 247px;height: 200px;padding: 7px"></div>
								<p style="coLor: red"><?php echo $row['song_price']." "; ?></p>
								<h4 style="coLor: #38A33D"><?php echo $row['singer_name'] ?></h4>
								<h5>Genre: <?php echo $row['genre_name'] ?></i5>
								</a>
							</div>
							<?php
						}
					}
					?>
				</div>
			</div>
			<?php
			
			?>
		</body>
		</html>