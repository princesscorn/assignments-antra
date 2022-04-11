/*****************1. summary salaries *************************************/

let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
}

let summary = 0;

summary = salaries.John + salaries.Ann + salaries.Pete;
console.log(summary);


/*****************2. double the menu *************************************/
let menu = {
    width: 200,
    height: 300,
    title: "My menu"
};


function multiplyNumeric(menu)
{
    menu.width = 2 * menu.width;
    menu.height = 2 * menu.height;
}
    
multiplyNumeric(menu);
console.log(menu);


/******************3. Email Check ***************************************
3 check email, we can solve this problem without caring case-sensive 
or, can use RegExp
**************************************************************************/

function checkEmailId() {
    console.log("enter");
    
    let result = true;
    let str = document.getElementById("emailTxt").value;
    
    console.log(str);

    if (str == null)
    {
        console.log("no input");
        result = false;
    }
    else 
    {
        let position1 = str.indexOf('@');
        let position2 = str.indexOf('.');
        console.log("position1:", position1);
        console.log("position2:", position2);
    
        if ((position1 == -1) || (position2 == -1))
        {
            console.log("not found @ or .");
            result = false;
        }
        else if (position1 > position2) {
                result = false;
        }
        else if (position2 - position1 <= 1)
        {
            result = false;
        }
    }
    
    console.log(result);
    document.querySelector("#txtResult").value = result;
}


function toggleIt(element) {
    let nextElement = element.nextElementSibling;
    if(nextElement.classList.contains("hide")) {
        nextElement.classList.remove("hide");
        nextElement.classList.add("show");
    }
    else{
        nextElement.classList.remove("show");
        nextElement.classList.add("hide");
    }
}

