var imgBig = document.querySelector(".product__image img")
var imgSmall = document.querySelectorAll(".img--small img")


   for (let index = 0; index < imgSmall.length; index++) {
        imgSmall[index].onclick=function(){
            var path = this.src;
            imgBig.setAttribute("src",path);
        }
   }
    
   
// header
const hero=document.querySelector(".hero")
const slider=document.querySelector(".slider")
const logo=document.querySelector("#logo")
const headline=document.querySelector(".headline")

const tl = new TimelineMax();
tl.fromTo(hero,1,{height:'10%'},{height:'100%',ease: Power2.easeInOut})
.fromTo(hero,1.2,{width:'80%'},{width:'100%',ease: Power2.easeInOut})
.fromTo(slider,1.2,{x:'-100%'},{x:'0%',ease: Power2.easeInOut})
.fromTo(logo,0.5,{opacity:0,x:30},{opacity:1,x:0},'-=0.5')
.fromTo(headline,0.5,{opacity:0,x:0},{opacity:1,x:30},'-=0.5')


// chuyen anh product




