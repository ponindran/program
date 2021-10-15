 // A $( document ).ready() block.
 $( document ).ready(function() {

    
    $(".in-color").focus(function(){
        $(this).css("background-color", "#cccccc");
      });

      $(".in-color").blur(function(){
        $(this).css("background-color", "#ffffff");
      });

      $('input[type=radio][name=gender]').change(function() {

        alert(this.value);

        if (this.value == 'male') {
            alert("Allot Thai Gayo Bhai");
        }
        else if (this.value == 'female') {
            alert("Transfer Thai Gayo");
        }
    });


    $(".checkbox").change(function() {

        alert(this.checked);
        if(this.checked) {

            //Do stuff
        }
    });

    $("#btnSubmit").click(function(){
        // action goes here!!

        var favorite = [];

        $.each($(".checkbox:checked"), function(){
            favorite.push($(this).val());
        });
        alert("My favourite sports are: " + favorite.join(", "));


        
      });
 
 });