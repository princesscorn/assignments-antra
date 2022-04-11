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

/******************* 4: Truncate strings ********************************/
function truncate(str, maxlength) 
{
    console.log(str.length);
    let len = str.length;
    console.log("str original length: ", len);
    if (len > maxlength)
    {
        str = str.substr(0, maxlength) + "..."
    }
    console.log(str);
    return str;
}

function truncateReplace()
{
    let str = document.getElementById("stringTxt").value;
    let maxlength = parseInt(document.getElementById("lengthTxt").value);

    let result = truncate(str, maxlength);

    console.log(result);
    document.querySelector("#txtResult").value = result;
}





/******************* 5: Array operations *********************************/

console.log("problem 5");
let arr = ["James", "Brennie"];
console.log(arr);

arr.push("Robert");
console.log(arr);

//replace the middle with "Calvin"
function replaceMid(arr, replaceStr)
{
    let len = arr.length;
    if (len % 2 == 1)
    {
        arr[parseInt(len/2)] = replaceStr;
    }
    console.log(arr);
}
replaceMid(arr, "Calvin");

//Remove the first value of the array and show it.
arr.shift();
console.log(arr);

//Prepend Rose and Regal to the array.
arr.unshift("Regal");
arr.unshift("Rose");
console.log(arr);

