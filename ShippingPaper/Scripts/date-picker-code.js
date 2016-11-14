$(document).ready(function(){  
  $("#demo").on("hide.bs.collapse", function(){
    $(".btnSearch").html('Advanced search&nbsp;<span class="glyphicon glyphicon-triangle-bottom"></span> ');
	$(".btnViewAll").show();
  });
  $("#demo").on("show.bs.collapse", function(){
    $(".btnSearch").html('Basic search&nbsp;<span class="glyphicon glyphicon-triangle-top"></span>');
	$(".btnViewAll").hide();
  });
  $('.datepicker').datepicker();  
});