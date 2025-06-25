// This is a JavaScript module that is loaded on demand. It can export any number of
// functions, and may import other JavaScript modules if required.

export function Slick(sliderContainer, innerSlider) {


    let pressed = false;
    let startX;
    let x;
    let moved = false;


    sliderContainer.addEventListener("touchstart", (e) => {
        pressed = true;
        var translateXValue = getTranslateXValue(sliderContainer.style.transform)
        startX = e.touches[0].clientX - translateXValue;
        sliderContainer.style.cursor = "grabbing";
    });

    sliderContainer.addEventListener("touchend", (e) => {

        sliderContainer.style.cursor = "grab";
        pressed = false;
    });

    sliderContainer.addEventListener("touchmove", (e) => {

        if (!pressed) return;
        e.preventDefault();

        x = e.touches[0].clientX;
        let scrollTo = x - startX; //ToDo Check The opposite side
        if (scrollTo < 0)
            return;
        sliderContainer.style.transform = 'translateX(' + scrollTo + 'px)';


    });


    sliderContainer.addEventListener("mousedown", (e) => {

        pressed = true;
        var translateXValue = getTranslateXValue(sliderContainer.style.transform)
        startX = e.screenX - translateXValue;
        sliderContainer.style.cursor = "grabbing";
    });


    sliderContainer.addEventListener("mouseup", (e) => {
        sliderContainer.style.cursor = "grab";
        pressed = false;
    });
    sliderContainer.addEventListener("mouseleave", (e) => {

        if (pressed) {
            sliderContainer.style.cursor = "grab";
            pressed = false;
        }

    });


    sliderContainer.addEventListener("click", (e) => {

        if (moved) {
            moved = false;
            e.preventDefault();
        }

    });

    sliderContainer.addEventListener("mousemove", (e) => {

        if (!pressed) return;
        e.preventDefault();
        moved = true;
        x = e.screenX;

        let scrollTo = x - startX; //ToDo Check The opposite side
        if (scrollTo < 0)
            return;
        sliderContainer.style.transform = 'translateX(' + scrollTo + 'px)';


    });





}
function getTranslateXValue(translateString) {

    var n = translateString.indexOf("(");
    var n1 = translateString.indexOf(",");

    var res = parseInt(translateString.slice(n + 1, n1 - 2));

    return res;

}
function getTranslateYValue(translateString) {

    var n = translateString.indexOf(",");
    var n1 = translateString.indexOf(")");

    var res = parseInt(translateString.slice(n + 1, n1 - 1));
    return res;

}

export function MoveCarousel(sliderContainer, length) {

    var translateXValue = getTranslateXValue(sliderContainer.style.transform);
    var scrollTo = translateXValue + length;
    if (scrollTo < 0) //ToDo Check The opposite side
        return;
    sliderContainer.style.transition = "transform 0.7s linear 0s";
    sliderContainer.style.transform = 'translateX(' + scrollTo + 'px)';







}

