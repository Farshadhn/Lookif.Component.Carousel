// This is a JavaScript module that is loaded on demand. It can export any number of
// functions, and may import other JavaScript modules if required.

export function Slick(sliderContainer, innerSlider) {
 

    let pressed = false;
    let startX;
    let x;

    sliderContainer.addEventListener("mousedown", (e) => {
        pressed = true; 
        startX = e.offsetX - innerSlider.offsetLeft + sliderContainer.scrollLeft;
     
        sliderContainer.style.cursor = "grabbing";
    });

    sliderContainer.addEventListener("mouseenter", () => {
        sliderContainer.style.cursor = "grab";
    });

    sliderContainer.addEventListener("mouseleave", () => {
        sliderContainer.style.cursor = "default";
    });

    sliderContainer.addEventListener("mouseup", () => {
        sliderContainer.style.cursor = "grab";
        pressed = false;
    });

    window.addEventListener("mouseup", () => {
        // pressed = false;
    });

    sliderContainer.addEventListener("mousemove", (e) => {
        if (!pressed) return;
        e.preventDefault(); 
        x = e.offsetX;
        let scrollTo = startX - x; 
        sliderContainer.scroll(`${scrollTo}`,0);
        
    });

   



}
