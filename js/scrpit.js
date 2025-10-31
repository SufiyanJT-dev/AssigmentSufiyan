// 1️) Output Prediction + Explanation
// What will be the output of the following code?
//     inside if the value will be 30
//     and outside if the value will be 20
//     and outside the function the value will be 10
// 2️) Hoisting Behavior (var vs let vs const)
// while in var it shows defined
// in let and const errror occured
// 3️) Reassignment &amp; Re-declaration Rules
// using var we can Reassignment and re-declaration
// but not in const while in let we can Reassignment not re-declaration
// 4️) Convert Normal Functions to Arrow Functions
const multiply=(a,b)=>a*b; 
console.log(multiply(2,3));
const greeting=(name)=>"Hello " +name;
console.log(greeting('Alice'));
// 5️) Arrow Function + Array Methods
const numbers=[2,5,8,11,14];
const squaredNumbers=numbers.map(num=>num+num);
console.log(squaredNumbers);
const sum=numbers.reduce((acc,cur)=>acc+cur,0);
console.log(sum);
const isEven=num=>num%2===0;
console.log(isEven(4));