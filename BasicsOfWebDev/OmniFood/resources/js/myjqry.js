$(document).ready(function(){

    /*
    var waypoint = new Waypoint({
    element: document.getElementById('px-offset-waypoint'),
    handler: function(direction) {
    notify('I am 20px from the top of the window')
    },
        offset: 20 
    })
    */

    //identify the direction of scroll and add the sticky class to nav element
    $('.js--section-features').waypoint(
        function(direction){
            if(direction =='down' ){
                $('nav').addClass('sticky');
            }
            else{
                $('nav').removeClass('sticky');
            }
        },
        // {offset: '60px;'}
        {offset: '10%'}
    );

    //scroll to plan section
    $('.js--scroll-to-plans').click(function(){
        $('html, body').animate({scrollTop:$('.js--section-plans').offset().top}, 1200);
    });

    //scroll to features section
    $('.js--scroll-to-features').click(function(){
        $('html, body').animate({scrollTop:$('.js--section-features').offset().top}, 1200);
    });

  //animate the navigation to different sections -- smooth scrolling
    $('a[href*="#"]')
  // Remove links that don't actually link to anything
  .not('[href="#"]')
  .not('[href="#0"]')
  .click(function(event) {
    // On-page links
    if (
        location.pathname.replace(/^\//, '') == this.pathname.replace(/^\//, '')    &&   location.hostname == this.hostname
        ) {
      // Figure out element to scroll to
      var target = $(this.hash);
      target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
      // Does a scroll target exist?
      if (target.length) {
        // Only prevent default if animation is actually gonna happen
        event.preventDefault();
        $('html, body').animate({
          scrollTop: target.offset().top
        }, 1200, function() {
          // Callback after animation
          // Must change focus!
          var $target = $(target);
          $target.focus();
          if ($target.is(":focus")) { // Checking if the target was focused
            return false;
          } else {
            $target.attr('tabindex','-1'); // Adding tabindex for elements not focusable
            $target.focus(); // Set focus again
          };
        });
      }
    }
  });


  //animation on scroll
  //get class name of the animation from https://animate.style/

  //1
  $('.js--animation-on-scroll-1').waypoint(function(direction){
    $('.js--animation-on-scroll-1').addClass('animate__animated animate__fadeIn');
  },{offset:'50%'});

  //2
  $('.js--animation-on-scroll-2').waypoint(function(direction){
    $('.js--animation-on-scroll-2').addClass('animate__animated animate__fadeInUp');
  },{offset:'50%'});

  //3
  $('.js--animation-on-scroll-3').waypoint(function(direction){
    $('.js--animation-on-scroll-3').addClass('animate__animated animate__fadeIn');
  },{offset:'50%'});

  //4
  $('.js--animation-on-scroll-4').waypoint(function(direction){
    $('.js--animation-on-scroll-4').addClass('animate__animated animate__pulse');
  },{offset:'50%'});

  // mobile navigation
  $('.js--mobile-nav').click(function(){
    var nav=$('.js--main-nav');
    nav.slideToggle(300);
    var opennav=$('ion-icon[name ="menu"]');
    var closenav=$('ion-icon[name ="close"]');
    
    if(opennav.hasClass('open')){
      opennav.removeClass('open');
      opennav.addClass('close');
      closenav.addClass('open');
    }
    else{
      closenav.addClass('close');
      closenav.removeClass('open');
      opennav.addClass('open');
    }
  });
  

});