// 1.
const double = x => x * 2;

// 2.
console.log(double(double(5)));

// 3.
function total(scores) {
    if (scores.length === 0) {
        return 0;
    }
    return scores[0] + total(scores.slice(1));
}

// 4.
function square(number) {
    return number * number;
}
const scoresSquared = numbers.map(square);

// 5.
numbers.map(num => Math.pow(num, 2));