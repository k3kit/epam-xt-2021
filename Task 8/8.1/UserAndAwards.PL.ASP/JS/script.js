let addUserBtn = document.getElementById('addUser');
let editUserBtn = document.getElementById('editUser');
let showUsersBtn = document.getElementById('showUsers');
let delUserBtn = document.getElementById('delUser');
let getUserbyIdBtn = document.getElementById('getUserById');
let addAwardBtn = document.getElementById('addAward');
let editAwardBtn = document.getElementById('editAward');
let delAwardBtn = document.getElementById('delAward');
let showAwardsBtn = document.getElementById('showAwards');
let getAwardByIdBtn = document.getElementById('getAwardById');
let addAwardToUserBtn = document.getElementById('addAwardToUser');



function redirect(url) {
    location = url;
}

showUsersBtn.onclick = function () {
    redirect('/pages/GetAllUsers.cshtml');
}

addUserBtn.onclick = function () {
    redirect('/pages/AddUser.cshtml');
}

delUserBtn.onclick = function () {
    redirect('/pages/DeleteUser.cshtml');
}

getUserbyIdBtn.onclick = function () {
    redirect('/pages/GetUserById.cshtml');
}

addAwardBtn.onclick = function () {
    redirect('/pages/AddAward.cshtml');
}

delAwardBtn.onclick = function () {
    redirect('/pages/DeleteAward.cshtml');
}

showAwardsBtn.onclick = function () {
    redirect('/pages/GetAllAwards.cshtml');
}

getAwardByIdBtn.onclick = function () {
    redirect('/pages/GetAwardById.cshtml');
}

addAwardToUserBtn.onclick = function () {
    redirect('/pages/AddAwardToUser.cshtml');
}

editUserBtn.onclick = function () {
    redirect('/pages/EditUser.cshtml');
}

editAwardBtn.onclick = function () {
    redirect('/pages/EditAward.cshtml');
}