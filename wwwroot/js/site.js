// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var total;

function updatePrice(item) {
    var computer = document.getElementById("computer").innerHTML.trim();
    console.log("comp: " + computer);
    console.log(computer.match("MacBookAir M1 13\""));
    switch (computer) {
        case "MacBookAir M1 13\"":
            total = 1299;
            console.log("yee");
            break;
        case "MacBook Pro M1 13\"":
            total = 1699;
            break;
        case "MacBook Pro 13\"":
            total = 2399;
            break;
        case "MacBook Pro 16\"":
            total = 2999;
            break;
    }
    console.log("total:" + total);
    var cpu = parseInt(document.getElementById("Cpu").value.split(",")[1]);
    console.log("cpu : " + cpu);
    var ram = parseInt(document.getElementById("Ram").value.split(",")[1]);
    console.log("ram : " + ram);
    var storage = parseInt(document.getElementById("Storage").value.split(",")[1]);
    console.log("storage : " + storage);
    var display = parseInt(document.getElementById("Display").value.split(",")[1]);
    console.log("display : " + display);
    var gpu = parseInt(document.getElementById("Gpu").value.split(",")[1]);
    console.log("gpu : " + gpu);
    total += cpu + ram + storage + display + gpu;
    document.getElementById("total").innerHTML = "$" + total;
}