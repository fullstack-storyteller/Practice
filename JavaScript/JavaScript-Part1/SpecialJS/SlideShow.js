//alert('this works!');

var SlideIntervalID;

function startSlideShow() {
    if (SlideIntervalID != null)
        stopSlideShow();
    if ((document.getElementById('picDuration').value).trim() == '' || isNaN(document.getElementById('picDuration').value)) {
        alert('Invalid Duration Input');
        return;
    }
    
    SlideIntervalID = setInterval(SlideShow, Number((document.getElementById('picDuration').value).trim()) * 1000);
}

function stopSlideShow() {
    
    clearInterval(SlideIntervalID);

}
function SlideShow() {
    var currentImage = document.getElementById('currentImage').getAttribute('src');
    var currentImageName = currentImage.substring(currentImage.lastIndexOf('/') + 1, currentImage.lastIndexOf('.'));
    var nextImageName = Number(currentImageName) + 1;
    if (nextImageName == 6) {
        nextImageName = 1;
    }
    document.getElementById('currentImage').setAttribute('src', 'Images/' + nextImageName + '.jpg');
    document.getElementById('divTest').innerHTML = 'Current Image ' + currentImageName + '.jpg <br/>';
    document.getElementById('divTest').innerHTML += 'Next up ' + nextImageName + '.jpg <br.>';

}