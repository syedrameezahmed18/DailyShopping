var scrollUp = document.getElementsByClassName('clickTop')[0];

  scrollUp.onclick = function(){
    window.scrollTo({
      top: 0,
      left: 0,
      behavior: "smooth"
    });

  }