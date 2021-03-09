function infoStart() { 
    updateTime();
}

function updateTime() {
    const td = document.getElementById("timeDisplay");
    const now = new Date();

    let hrs = now.getHours();
    if (hrs < 10) {
        hrs = "0" + hrs;
    }

    let min = now.getMinutes();
    if (min < 10) {
        min = "0" + min;
    }

    let sec = now.getSeconds();
    if (sec < 10) {
        sec = "0" + sec;
    }

    td.innerHTML = `${hrs}:${min}:${sec}`;
    setTimeout(updateTime, 1000);
}
