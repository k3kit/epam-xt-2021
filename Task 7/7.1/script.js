function charRemover() {
    const  separators = '.,:;!?';
    let str = "У попа была собака";
    let words;
    let del = [];
    for (let i = 0; i < separators.length; i++) {
       words = str.split(separators[i])
       str = words.join('');
    }
    words = str.split(' ');

    for(let i = 0; i < words.length; i++ ){
        for(let j = 0; j < words[i].length; j++){
            if(words[i].includes(words[i][j],j+1))
            del.push(words[i][j])
        }
    }
    for(let i = 0; i < del.length; i++){
        str = str.split(del[i]).join('')
    }
   console.log(str);
}

charRemover();

