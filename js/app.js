var firstName = '';
var lastName = '';

$('#load').click(function(){
    firstName = $('#firstName').val();
    lastName = $('#lastName').val();
    if((firstName && lastName) == ''){
        alert('Los campos nombre y apellido no pueden estar vacíos')
    }
    else {
        document.getElementById("dataRegistry").submit();        
        alert('Los datos fueron cargados correctamente')
    }
});

$('#erease').click(function(){
    $('input').val('');
});

function showalert(message,alerttype) {

    $('#alert_placeholder').append('<div id="alertdiv" class="alert ' +  alerttype + '"><a class="close" data-dismiss="alert">×</a><span>'+message+'</span></div>')

    setTimeout(function() { // this will automatically close the alert and remove this if the users doesnt close it in 5 secs


      $("#alertdiv").remove();

    }, 5000);
  }

