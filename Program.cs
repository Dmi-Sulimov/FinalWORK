function getThreeSymbolString(array){
    let newArray = [];
    let i = 0;
    for (i = 0; i < array.length; i++) {
        if (array[i].length < 4) {
            newArray.push(array[i]);
        }
    }
    return newArray;
}