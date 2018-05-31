function roadRader(arr) {
    let speedLimits = {
    'motorway': 130,
    'interstate' : 90,
    "city" : 50,
    "residential" : 20
    };

    let area = arr[1];
    let speed = arr[0];

    console.log(checkSpeedLimit(area, speed));

    function checkSpeedLimit(area, speed) {
        if (speedLimits[area] != undefined) {
            let overLimit = speed - speedLimits[area];
            if (overLimit <= 0) {
                return "";
            }
            
            if (overLimit <= 20) {
                return "speeding";
            }
            else if (overLimit <= 40) {
                return "excessive speeding";
            }
            else {
                return "reckless driving";
            }
        }
    }
}

roadRader([21, "residential"]);
roadRader([200, "motorway"]);
