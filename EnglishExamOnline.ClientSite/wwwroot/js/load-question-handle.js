//Use ajax for load result page
function PostAnswer() {
    var listAnswer = [];
    for (var i = 1; i <= 10; i++) {
        var answer = $('input[name="optradio{' + i + '}"]:checked').val()
        if (answer != undefined) {
            console.log("here!")
            listAnswer.push(answer);
        }
        else {
            listAnswer.push("null");
        }
    }

    $.ajax({
        method: "POST",
        url: "/result",
        data: { listAnswer: listAnswer },
        success: function (result) {
            $('#render-view').html(result);
        }
    });
}

//Count down to submit
var sdate = document.getElementById('test').innerHTML;
var stime = new Date(sdate);
var now = Date.now();
var dates = stime.getTime();
var compare = now - dates;
var minutes = Math.floor(compare / 60000);
function startTimer(duration, display) {
    var start = Date.now();
    var diff;
    var minutes;
    var seconds;
    async function timer() {
        diff = duration - (((Date.now() - start) / 1000) | 0);
        minutes = (diff / 60) | 0;
        seconds = (diff % 60) | 0;

        minutes = minutes < 10 ? "0" + minutes : minutes;
        seconds = seconds < 10 ? "0" + seconds : seconds;

        display.textContent = minutes + ":" + seconds;
        if (diff < 0) {
            clearInterval(timer);
            document.getElementById('submit').click();
        }
    };
    timer();
    setInterval(timer, 1000);
}
var display = document.querySelector('#timeTest');
startTimer(3600 - (minutes * 60), display);

