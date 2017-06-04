$(function () {
    var code_a = "a";
    var code_A = "A";
    var code_l = "l";
    var code_L = "L";

    $(document).keypress(function (e) {
        if (e.key == code_a || e.key == code_A) {
            keyStrokes.push({ Vote: 'dislike', Time: player.getCurrentTime() });
            console.log(keyStrokes);
        }
        else if (e.key == code_l || e.key == code_L) {
            keyStrokes.push({ Vote: 'like', Time: player.getCurrentTime() });
            console.log(keyStrokes);
        }
    });
});