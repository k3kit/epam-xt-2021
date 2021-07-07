
let submitBtn = document.getElementById('submit');
let realSubmitBtn = document.getElementById('realSubmit');

function redirect(url) {
    location = url;

        
}

submitBtn.onclick = function () {
    res = confirm("do you want to remove this award?");
    if (res)
        realSbmtBtn.click();
    else
        redirect('/pages/DeleteAward.cshtml');

    sbmtBtn.hidden = 1;
    realSbmtBtn.hidden = 0;
}
