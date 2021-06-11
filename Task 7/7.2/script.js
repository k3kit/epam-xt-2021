function calculator(str){
    const reg = str.match(/(\d+\.\d+)|(\d+)|(\+|\-|\/|\*|\=)/g);
    let res = parseFloat(reg[0]);


    for(let i = 1; i <= reg.length; i++)    {
        switch(reg[i]){
            case "+":
            res +=parseFloat(reg[i + 1]);
            break;
            case "-":
            res -=parseFloat(reg[i + 1]);
            break;
            case "*":
            res *=parseFloat(reg[i + 1]);
            break;
            case "/":
            res /=parseFloat(reg[i + 1]);
            break;
            case "=":
            console.log(res.toFixed(2));
            break;
            default:
            break;
         }
    }
}

calculator('3.5+4*10-5.3/5=');


