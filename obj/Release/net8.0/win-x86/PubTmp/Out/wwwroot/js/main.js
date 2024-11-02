$(document).ready(function(){
    var owl = $('.owl-carousel');
    owl.owlCarousel({
      loop: true,
      margin: 10,
      responsive: {
        0: {
          items: 1
        },
        600: {
          items: 2
        },
        1000: {
          items: 4
        }
      }
    });

    // Custom Navigation
    $('.owl-next').click(function() {
      owl.trigger('next.owl.carousel');
    });
    $('.owl-prev').click(function() {
      owl.trigger('prev.owl.carousel', [300]);
    });
  });


  