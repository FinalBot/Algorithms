var Solver = /** @class */ (function () {
    function Solver() {
    }
    Solver.prototype.solve = function (input) {
        var parts = input.split(' ');
        return (parseInt(parts[0]) + parseInt(parts[1])).toString();
    };
    return Solver;
}());
function solve(input) {
    var solver = new Solver();
    return solver.solve(input);
}
//# sourceMappingURL=solve.js.map