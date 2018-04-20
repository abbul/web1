/* SIEMPRE COLOCAR TODO TU CODIGO DE JAVASCRIPT EN UNA FUNCION AUTO INVOCADA.
	
	(fuction(){
	
			aca ira todo el codigooooo!!!!
	}())

*/

		var suma = function(){
			  var numero1 = parseInt( document.getElementById("numero1").value ); // pedimos el valor del id numero1
			  var numero2 = parseInt(document.getElementById("numero2").value ); // pedimos el valor del id numero2
			  var resultado= numero1+numero2;
			  
			  
			  var primerElemento = document.getElementById("pru1");
			  primerElemento.innerHTML=resultado; // tambien innerHTMl puede agregar clases desde aca
			 // primerElemento.textContent=resultado; // es lo mismo q innerHTML, la diferencia es q no toma las etiquetas como string
		  }

			var eventoA = document.getElementById("botonA");
 				eventoA.addEventListener("click" , suma);



 			var validarNombre = function(e)
		   {
			   if(formulario.nombres.value < 2)
				   {
					   alert("Pon el nombre");
					   e.preventDefault();
				   }
		   }
		   
		    var validarApellido = function(e)
		   {
			   if(formulario.apellidos.value < 2 )
				   {
					   alert("Pon el Apellido");
					   e.preventDefault();
				   }
		   }
			
		   var validarCorreo = function(e)
		   {
			   if(formulario.mail.value < 2)
				   {
					   alert("Pon el Correo");
					   e.preventDefault();
				   }
		   }
			 
		   var validarEdad = function(e)
		   {
			   if( formulario.edad.value < 18 || formulario.edad.value > 105 )
				   {
					   alert("Debes tener entre 18 y 100 años");
					   e.preventDefault();
				   }
		   }
			 
		   var validarSexo = function(e)
		   {
			   if(formulario.sexo[0].checked == false && formulario.sexo[1].checked == false && formulario.sexo[2].checked == false  )
				   {
					   alert("Debes seleccionar tu sexo");
					  e.preventDefault(e);
				   }
		   } 
			 
			 var validarTodo = function(e)
		   {
			   validarNombre(e);
			   validarApellido(e);
			   validarCorreo(e);
			   validarEdad(e);
			   validarSexo(e);
		   }
		   
	
			 var formulario = document.getElementById("formulario_0");
			 var elementos = formulario.elements;
			var boton = document.getElementById("registrar");

			 boton.addEventListener("click",validarTodo); 
		 

