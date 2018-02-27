class Solver {
    solve(input: string): string {
        var parts = input.split(' ');
        return (parseInt(parts[0]) + parseInt(parts[1])).toString();
    }
}

function solve(input: string): string {
    var solver: Solver = new Solver();
    return solver.solve(input);
}
