int numberOfApples = 12;
decimal pricePerApple = 0.35M;
string type = "organic";

// Up to three parameter values can use named arguments
WriteLine(
    format: "{0} {1} apples cost {2:C}",
    arg0: numberOfApples,
    arg1: type,
    arg2: pricePerApple * numberOfApples);

// Four or more parameter values cannot use named arguments
WriteLine(
    "{0} {1} lived in {2} and worked in the {3} team at {4}.",
    "Roger", "Cevung", "Stockholm", "Education", "Optimizely");

